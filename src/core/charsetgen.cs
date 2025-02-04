﻿using System.Text;

namespace Fahrenheit.Core;

public static class FhCharsetGenerator {
    private static string Escape(char c) {
        return c switch {
            '\'' => @"'\''",
            '\\' => @"'\\'",
            _    => $"'{c}'"
        };
    }

    public static string EmitCharset(string fpath, string ns) {
        StringBuilder tbsb  = new StringBuilder(); // ToByte switch
        StringBuilder tcsb  = new StringBuilder(); // ToChar switch
        string        csstr = File.ReadAllText(fpath);

        List<char> duplist = new List<char>(csstr.Length);

        int swidx = 0x30;
        for (int i = 0; i < csstr.Length; i++) {
            int  dupidx = duplist.IndexOf(csstr[i]);
            bool isdup  = dupidx != -1;

            duplist.Add(csstr[i]);

            byte[] b    = Encoding.UTF8.GetBytes(csstr[i..(i + 1)]);
            string bstr = Convert.ToHexString(b);

            string swidxstr = swidx.ToString("X");
            string escstr   = Escape(csstr[i]);

            tcsb.AppendLine(isdup
                ? $"            // 0x{swidxstr} => {escstr}, // duplicate of 0x{(dupidx + 0x30):X}"
                : $"            0x{swidxstr} => {escstr}, // {bstr}");
            tbsb.AppendLine(isdup
                ? $"            // {escstr} => 0x{swidxstr}, // duplicate of 0x{(dupidx + 0x30):X}"
                : $"            {escstr} => 0x{swidxstr}, // {bstr}");
            swidx++;
        }

        tcsb.AppendLine($"            _ => {nameof(FhCharset.InvalidChar)},");
        tbsb.AppendLine($"            _ => {nameof(FhCharset.InvalidByte)},");

        string charsetfn  = Path.GetFileName(fpath);
        string charsetidl = charsetfn[(charsetfn.IndexOf('_') + 1)..charsetfn.IndexOf('.')];
        string charsetid  = $"{char.ToUpperInvariant(charsetidl[0])}{charsetidl[1..]}";

        return $$"""
/* [dedit {{DateTime.UtcNow.ToString("dd/M/yy HH:mm")}}]
 * This file was generated by Fahrenheit.DEdit (https://github.com/fkelava/fahrenheit/).
 *
 * Source file: {{fpath}}
 */

namespace {{ns}};

public abstract partial class FhCharset {
    public static FhCharset{{charsetid}} {{charsetid}} = new FhCharset{{charsetid}}();
}

public sealed class FhCharset{{charsetid}} : FhCharset  {
    public override byte ToByte(char c) {
        return c switch  { {{tbsb.ToString()}}
        };
    }

    public override char ToChar(byte b) {
        return b switch  { {{tcsb.ToString()}}
        };
    }
}
""";
    }
}
