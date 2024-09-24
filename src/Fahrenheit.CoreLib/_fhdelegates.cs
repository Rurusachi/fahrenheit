﻿namespace Fahrenheit.CoreLib;

public static partial class FhHookDelegates {
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PrintfVarargDelegate(string fmt, nint va0, nint va1, nint va2, nint va3, nint va4, nint va5, nint va6, nint va7, nint va8, nint va9, nint va10, nint va11, nint va12, nint va13, nint va14, nint va15);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int TkIsDebugDelegate();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Sg_MainLoop(float delta);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void TODrawMessageWindow();

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AtelExecInternal_00871d10();
}