﻿using System;

namespace Fahrenheit.CoreLib;

[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0x2150)]
public unsafe struct FhXBtlStruct {
	[FieldOffset(0x10)] public byte battle_state;
	[FieldOffset(0x12)] public byte battle_trigger;
	[FieldOffset(0x39)] public bool never_crit;
	[FieldOffset(0x3D)] public bool always_crit;
	[FieldOffset(0x3E)] public bool always_1_dmg;
	[FieldOffset(0x3F)] public bool always_9999_dmg;
	[FieldOffset(0x40)] public bool always_99999_dmg;
	[FieldOffset(0x4F)] public bool always_hit;
	[FieldOffset(0x5C)] public IntPtr command_bin_ptr;
	[FieldOffset(0x60)] public IntPtr monmagic1_bin_ptr;
	[FieldOffset(0x64)] public IntPtr monmagic2_bin_ptr;
	[FieldOffset(0x68)] public IntPtr ply_rom_bin_ptr;
	[FieldOffset(0x70)] public IntPtr item_bin_ptr;
	[FieldOffset(0x74)] public IntPtr a_ability_bin_ptr;
	[FieldOffset(0x78)] public IntPtr sum_assure_bin_ptr;
	[FieldOffset(0x7C)] public IntPtr ctb_base_bin_ptr;
	[FieldOffset(0x80)] public IntPtr magic_bin_ptr;
	[FieldOffset(0x84)] public IntPtr mot_bin_ptr;
	[FieldOffset(0x88)] public IntPtr st_number_bin_ptr;
	[FieldOffset(0x90)] public IntPtr sum_grow_bin_ptr;
	[FieldOffset(0x94)] public IntPtr kaizou_bin_ptr;
	[FieldOffset(0x98)] public ushort command_bin_size;
	[FieldOffset(0x9A)] public ushort ply_rom_bin_size;
	[FieldOffset(0x9E)] public ushort item_bin_size;
	[FieldOffset(0xA0)] public ushort a_ability_bin_size;
	[FieldOffset(0xA2)] public ushort sum_assure_bin_size;
	[FieldOffset(0xA4)] public ushort ctb_base_bin_size;
	[FieldOffset(0xA6)] public ushort magic_bin_size;
	[FieldOffset(0xA8)] public ushort st_number_bin_size;
	[FieldOffset(0xAA)] public ushort mot_bin_size;
	[FieldOffset(0xAE)] public ushort sum_grow_bin_size;
	[FieldOffset(0xB0)] public ushort kaizou_bin_size;
	[FieldOffset(0xF4)] public uint btl_bin_ptr;
	[FieldOffset(0xF8)] public uint btl_bin_fields_ptr;
	[FieldOffset(0xFC)] public uint btl_bin_encounters_ptr;
	[FieldOffset(0x100)] public ushort btl_bin_field_count;
	[FieldOffset(0x102)] public ushort btl_bin_size;
	[FieldOffset(0x120)] public uint btl_bin_cur_field_ptr;
	[FieldOffset(0x124)] public uint btl_bin_cur_encounter_ptr;
	[FieldOffset(0x128)] public uint btl_bin_cur_group_ptr;
	[FieldOffset(0x12C)] public uint btl_bin_cur_formation_ptr;
	[FieldOffset(0x15C0)] public uint chosen_gil;
	[FieldOffset(0x1984)] public ushort battlefield_id;
	[FieldOffset(0x1986)] public ushort field_idx;
	[FieldOffset(0x198A)] public fixed byte field_name[8];
	[FieldOffset(0x2008)] public uint last_com;
	[FieldOffset(0x210C)] public byte ambush_state;
	[FieldOffset(0x2121)] public byte battle_end_type;
}
