﻿using System;

namespace Fahrenheit.Core.ImGuiNET;

[Flags]
public enum ImGuiModFlags
{
    None  = 0,
    Ctrl  = 1,
    Shift = 2,
    Alt   = 4,
    Super = 8,
}