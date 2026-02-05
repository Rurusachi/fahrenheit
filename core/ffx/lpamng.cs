// SPDX-License-Identifier: MIT

namespace Fahrenheit.Core.FFX;

public enum SphereGridTilt : byte {
    Flat,
    SlightTilt,
    FarTilt,
}

public enum SphereGridZoom : byte {
    Close,
    Medium,
    Far,
    VeryFar, // supported but not allowed by vanilla
}

public static class SphereGridZoomExt {
    public static float get_zoom(this SphereGridZoom zoom_level) {
        return zoom_level switch {
            SphereGridZoom.VeryFar => 0.125f,
            SphereGridZoom.Far     => 0.25f,
            SphereGridZoom.Medium  => 0.5f,
            SphereGridZoom.Close   => 1.0f,
            _                      => 0.5f,
        };
    }

    public static SphereGridZoom get_closest(float zoom, bool allow_very_far = false) {
        return zoom switch {
             <= 0.1875f => allow_very_far ? SphereGridZoom.VeryFar : SphereGridZoom.Far,
             <= 0.375f  => SphereGridZoom.Far,
             <= 0.75f   => SphereGridZoom.Medium,
            _           => SphereGridZoom.Close,
        };
    }
}

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x12FC0)]
public unsafe struct LpAbilityMapEngine {
    [InlineArray(128)]
    public struct SphereGridClusterArray {
        private SphereGridCluster _data;
    }

    [InlineArray(1024)]
    public struct SphereGridNodeArray {
        private SphereGridNode _data;
    }

    [InlineArray(1024)]
    public struct SphereGridLinkArray {
        private SphereGridLink _data;
    }

    [InlineArray(8)]
    public struct SphereGridClusterSizesArray {
        private Vec2s16 _data;
    }

    [InlineArray(130)]
    public struct SphereGridNodeTypeInfoArray {
        private SphereGridNodeTypeInfo _data;
    }

    [InlineArray(7)]
    public struct SphereGridChrInfoArray {
        private SphereGridChrInfo _data;
    }

    [FieldOffset(0x0)]     public short                       cluster_count;
    [FieldOffset(0x2)]     public short                       node_count;
    [FieldOffset(0x4)]     public short                       link_count;
    [FieldOffset(0x8)]     public SphereGridClusterArray      clusters;
    [FieldOffset(0x808)]   public SphereGridNodeArray         nodes;
    [FieldOffset(0xA808)]  public SphereGridLinkArray         links;
    [FieldOffset(0xF808)]  public SphereGridClusterSizesArray cluster_sizes;
    [FieldOffset(0xF828)]  public SphereGridNodeTypeInfoArray node_type_infos;
    [FieldOffset(0x11088)] public SphereGridChrInfoArray      party_infos;
    [FieldOffset(0x112FC)] public ushort                      selected_node_idx;
    [FieldOffset(0x11308)] public Vector4                     cam_desired_pos;
    [FieldOffset(0x11318)] public Vector4                     cam_limited_pos;
    [FieldOffset(0x11340)] public fixed int                   tilt_vector[4];
    [FieldOffset(0x11350)] public Vector4                     zoom_vector; // Only .x matters
    [FieldOffset(0x115B8)] public byte                        fade_timer;
    [FieldOffset(0x115BC)] public byte                        current_chr_id;
    [FieldOffset(0x115C9)] public byte                        active_indicators;
    [FieldOffset(0x115CB)] public SphereGridTilt              tilt_level;
    [FieldOffset(0x115CC)] public SphereGridZoom              zoom_level;
    [FieldOffset(0x115CE)] public ushort                      tilt_time_left; // in frames
    [FieldOffset(0x115D0)] public ushort                      zoom_time_left; // in frames
    [FieldOffset(0x115D4)] public float                       start_tilt;
    [FieldOffset(0x115D8)] public float                       target_tilt;
    [FieldOffset(0x115DC)] public float                       start_zoom;
    [FieldOffset(0x115E0)] public float                       target_zoom;
    [FieldOffset(0x115E8)] public float                       fade_dark_inv_alpha;
    [FieldOffset(0x115F4)] public float                       select_cursor_alpha;
    [FieldOffset(0x115fc)] public float                       x_min;
    [FieldOffset(0x11600)] public float                       y_min;
    [FieldOffset(0x11604)] public float                       x_max;
    [FieldOffset(0x11608)] public float                       y_max;
    [FieldOffset(0x1160c)] public float                       x_min2;
    [FieldOffset(0x11610)] public float                       y_min2;
    [FieldOffset(0x11614)] public float                       x_max2;
    [FieldOffset(0x11618)] public float                       y_max2;
    [FieldOffset(0x1163c)] public Vector4                     cam_previous_desired_pos;
    [FieldOffset(0x11654)] public byte*                       node_change_text;
    [FieldOffset(0x11658)] public byte*                       old_node_name;
    [FieldOffset(0x1165c)] public byte*                       new_node_name;
    [FieldOffset(0x11668)] public SphereGridLinkPoint*        link_points;
    [FieldOffset(0x1166c)] public fixed ushort                abmap_input[4];
    [FieldOffset(0x116A8)] public int                         should_update_node; // -1 updates all nodes
    [FieldOffset(0x116AC)] public int                         should_update;


    [FieldOffset(0x112b8)] public Vector4   field11_0x112b8;

    [FieldOffset(0x112d8)] public uint      field_0x112d8;
    [FieldOffset(0x112dc)] public uint      field_0x112dc;
    [FieldOffset(0x112e0)] public uint      field_0x112e0;
    [FieldOffset(0x112f4)] public float     field_0x112f4;
    [FieldOffset(0x112f8)] public uint      field_0x112f8;

    [FieldOffset(0x11306)] public byte      field_0x11306;

    [FieldOffset(0x113e0)] public Matrix4x4 field90_0x113e0;

    [FieldOffset(0x11520)] public Vector4   field95_0x11520;
                                           
    [FieldOffset(0x11560)] public Vector4   field144_0x11560;

    [FieldOffset(0x115a0)] public float     field193_0x115a0;
    [FieldOffset(0x115a4)] public float     field_0x115a4;
    [FieldOffset(0x115a8)] public int       field_0x115a8;
    [FieldOffset(0x115ac)] public int       field_0x115ac;
    [FieldOffset(0x115b0)] public int       field_0x115b0;
    [FieldOffset(0x115b4)] public int       field_0x115b4;

    [FieldOffset(0x115b9)] public byte      field_0x115b9;
    [FieldOffset(0x115bd)] public byte      field_0x115bd;
    [FieldOffset(0x115be)] public byte      field_0x115be;
    [FieldOffset(0x115bf)] public byte      field_0x115bf;

    
    [FieldOffset(0x115c3)] public byte      field_0x115c3;
    [FieldOffset(0x115c4)] public byte      field_0x115c4;
    [FieldOffset(0x115c5)] public byte      field_0x115c5;
    [FieldOffset(0x115c6)] public byte      field_0x115c6;
    [FieldOffset(0x115c7)] public byte      field_0x115c7;
    [FieldOffset(0x115c8)] public byte      field_0x115c8;

    [FieldOffset(0x115cd)] public byte      field_0x115cd;

    [FieldOffset(0x115f8)] public int       field_0x115f8;


    [FieldOffset(0x1161c)] public int       field_0x1161c;
    [FieldOffset(0x11620)] public float     field_0x11620;
    [FieldOffset(0x11624)] public float     field272_0x11624;
    [FieldOffset(0x11628)] public float     field_0x11628;
    [FieldOffset(0x1162c)] public float     field_0x1162c;
    [FieldOffset(0x11630)] public ushort    field_0x11630;
    [FieldOffset(0x11632)] public ushort    field_0x11632;
    [FieldOffset(0x11634)] public ushort    field_0x11634;
    [FieldOffset(0x11636)] public ushort    field_0x11636;
    [FieldOffset(0x11638)] public byte      field_0x11638;

    [FieldOffset(0x1164c)] public NodeType  field294_0x1164c; // Double check how this field is used
    [FieldOffset(0x1164c)] public byte      _0x1164c;         // Double check how this field is used
    [FieldOffset(0x1164d)] public byte      _0x1164d;
    [FieldOffset(0x1164e)] public ushort    field295_0x1164e;


    [FieldOffset(0x11650)] public byte      field_0x11650;

    [FieldOffset(0x11666)] public ushort    field_0x11666;

    [FieldOffset(0x11698)] public short     field_0x11698;

    [FieldOffset(0x1169c)] public uint      field_0x1169c;
    [FieldOffset(0x116a0)] public uint      field_0x116a0;
    [FieldOffset(0x116a4)] public uint      field_0x116a4;
    [FieldOffset(0x116a8)] public uint      field_0x116a8;
    [FieldOffset(0x116ac)] public uint      field_0x116ac;
    [FieldOffset(0x116b0)] public int       field374_0x116b0;


    public float current_zoom {
        get => zoom_vector.X;
        set => zoom_vector.X = zoom_vector.Y = zoom_vector.Z = value;
    }
}
