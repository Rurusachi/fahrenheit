/* [ct2cs 21/5/23 00:09]
 * This file was generated by Fahrenheit.CT2CS (https://github.com/fkelava/fahrenheit/).
 * 
 * Source file: x_btlactor.ct
 */

namespace Fahrenheit.CoreLib;

[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0xF90)]
public struct FhXChr 
{
	[FieldOffset(0x00C)] public byte chr_id;
    [FieldOffset(0x5D0)] public uint stat_hp;
    [FieldOffset(0x5D4)] public uint stat_mp;
    [FieldOffset(0x594)] public uint stat_maxhp;
    [FieldOffset(0x598)] public uint stat_maxmp;
    [FieldOffset(0xDCC)] public byte stat_death;
    [FieldOffset(0xDCE)] public byte stat_stone;
    [FieldOffset(0x63D)] public byte stat_weak;
    [FieldOffset(0x5A8)] public byte stat_str;
    [FieldOffset(0x5A9)] public byte stat_vit;
    [FieldOffset(0x5AA)] public byte stat_mag;
    [FieldOffset(0x5AB)] public byte stat_spirit;
    [FieldOffset(0x5AC)] public byte stat_dex;
    [FieldOffset(0x5AD)] public byte stat_luck;
    [FieldOffset(0x5AE)] public byte stat_avoid;
    [FieldOffset(0x5AF)] public byte stat_hit;
    [FieldOffset(0x5BA)] public byte stat_poison_per;
    [FieldOffset(0x5BB)] public byte stat_limit_type;
    [FieldOffset(0x5BC)] public byte stat_limit_gauge;
    [FieldOffset(0x5BD)] public byte stat_limit_gauge_max;
    [FieldOffset(0xDC8)] public byte stat_inbattle;
    [FieldOffset(0x590)] public byte __0x590;
    public bool stat_man { get { return (__0x590 & 1) != 0; } }
    public bool stat_female { get { return (__0x590 >> 1 & 1) != 0; } }
    public bool stat_summon { get { return (__0x590 >> 2 & 1) != 0; } }

    [FieldOffset(0x505)] public byte stat_fly;
    [FieldOffset(0xDEC)] public byte stat_will_die;
    [FieldOffset(0x4FC)] public ushort stat_area;
    [FieldOffset(0x4FE)] public byte stat_pos;
    [FieldOffset(0x4FF)] public byte stat_far;
    [FieldOffset(0x504)] public byte stat_group;
    [FieldOffset(0x606)] public ushort __0x606;
    public bool stat_zombie { get { return (__0x606 >> 1 & 1) != 0; } }
	public bool stat_ko { get { return (__0x606 >> 2 & 1) != 0; } }
    public bool stat_poison { get { return (__0x606 >> 3 & 1) != 0; } }
    public bool stat_power_break { get { return (__0x606 >> 4 & 1) != 0; } }
    public bool stat_magic_break { get { return (__0x606 >> 5 & 1) != 0; } }
    public bool stat_armor_break { get { return (__0x606 >> 6 & 1) != 0; } }
    public bool stat_mental_break { get { return (__0x606 >> 7 & 1) != 0; } }
    public bool stat_confuse { get { return (__0x606 >> 8 & 1) != 0; } }
    public bool stat_berserk { get { return (__0x606 >> 9 & 1) != 0; } }
    public bool stat_prov { get { return (__0x606 >> 10 & 1) != 0; } }
    public bool stat_threat { get { return (__0x606 >> 11 & 1) != 0; } }

    [FieldOffset(0x608)] public byte stat_sleep;
    [FieldOffset(0x609)] public byte stat_silence;
    [FieldOffset(0x60A)] public byte stat_dark;
    [FieldOffset(0x60B)] public byte stat_shell;
    [FieldOffset(0x60C)] public byte stat_protess;
    [FieldOffset(0x60D)] public byte stat_reflect;
    [FieldOffset(0x60E)] public byte stat_bawater;
    [FieldOffset(0x60F)] public byte stat_bafire;
    [FieldOffset(0x610)] public byte stat_bathunder;
    [FieldOffset(0x611)] public byte stat_bacold;
    [FieldOffset(0x612)] public byte stat_regen;
    [FieldOffset(0x613)] public byte stat_haste;
    [FieldOffset(0x614)] public byte stat_slow;
    [FieldOffset(0x3F5)] public byte stat_death_pattern;
    [FieldOffset(0xDDD)] public byte stat_event_chr;
    [FieldOffset(0xDD6)] public byte stat_action;
    [FieldOffset(0xDD9)] public byte stat_cursor;
    [FieldOffset(0xDD7)] public byte stat_ctb_list;
    [FieldOffset(0x16)] public byte stat_visible;
    [FieldOffset(0x509)] public byte stat_move_area;
    [FieldOffset(0x50B)] public byte stat_move_pos;
    [FieldOffset(0x408)] public uint stat_efflv;
    [FieldOffset(0x24)] public byte stat_model;
    [FieldOffset(0x422)] public byte stat_damage_chr;
    [FieldOffset(0x416)] public byte stat_move_target;
    [FieldOffset(0x420)] public byte stat_motionlv;
    [FieldOffset(0x412)] public bool stat_move_flag;
    [FieldOffset(0x43E)] public byte stat_live_motion;
    [FieldOffset(0x508)] public byte stat_adjust_pos;
    [FieldOffset(0x50D)] public byte stat_height_on;
    [FieldOffset(0x50E)] public bool stat_sleep_recover_flag;
    [FieldOffset(0x5DA)] public byte stat_abs_e;
    public bool stat_abs_fire { get { return (stat_abs_e & 1) != 0; } }
    public bool stat_abs_cold { get { return (stat_abs_e >> 1 & 1) != 0; } }
    public bool stat_abs_thunder { get { return (stat_abs_e >> 2 & 1) != 0; } }
    public bool stat_abs_water { get { return (stat_abs_e >> 3 & 1) != 0; } }
    public bool stat_abs_holy { get { return (stat_abs_e >> 4 & 1) != 0; } }

    [FieldOffset(0x5DB)] public byte stat_inv_e;
    public bool stat_inv_fire { get { return (stat_inv_e & 1) != 0; } }
    public bool stat_inv_cold { get { return (stat_inv_e >> 1 & 1) != 0; } }
    public bool stat_inv_thunder { get { return (stat_inv_e >> 2 & 1) != 0; } }
    public bool stat_inv_water { get { return (stat_inv_e >> 3 & 1) != 0; } }
    public bool stat_inv_holy { get { return (stat_inv_e >> 4 & 1) != 0; } }

    [FieldOffset(0x5DC)] public byte stat_half_e;
    public bool stat_half_fire { get { return (stat_half_e & 1) != 0; } }
    public bool stat_half_cold { get { return (stat_half_e >> 1 & 1) != 0; } }
    public bool stat_half_thunder { get { return (stat_half_e >> 2 & 1) != 0; } }
    public bool stat_half_water { get { return (stat_half_e >> 3 & 1) != 0; } }
    public bool stat_half_holy { get { return (stat_half_e >> 4 & 1) != 0; } }

	[FieldOffset(0x5DD)] public byte stat_weak_e;
    public bool stat_weak_fire { get { return (stat_weak_e & 1) != 0; } }
    public bool stat_weak_cold { get { return (stat_weak_e >> 1 & 1) != 0; } }
    public bool stat_weak_thunder { get { return (stat_weak_e >> 2 & 1) != 0; } }
    public bool stat_weak_water { get { return (stat_weak_e >> 3 & 1) != 0; } }
    public bool stat_weak_holy { get { return (stat_weak_e >> 4 & 1) != 0; } }

    [FieldOffset(0x426)] public bool stat_adjust_pos_flag;
    [FieldOffset(0x447)] public byte __0x447;
    public bool stat_inv_physic_motion { get { return (__0x447 & 1) != 0; } }
    public bool stat_inv_magic_motion { get { return (__0x447 >> 1 & 1) != 0; } }

    [FieldOffset(0xDEB)] public byte stat_steal_count;
    [FieldOffset(0x448)] public bool stat_wait_motion_flag;
    [FieldOffset(0x40A)] public bool stat_attack_return_flag;
    [FieldOffset(0x40C)] public byte stat_attack_normal_frame;
    [FieldOffset(0x41E)] public bool stat_disable_move_flag;
    [FieldOffset(0x41F)] public bool stat_disable_jump_flag;
    [FieldOffset(0x2D)] public bool stat_bodyhit_flag;
    [FieldOffset(0xE0C)] public byte stat_effvar;
    [FieldOffset(0xF88)] public FhXItemMem __FhXItemMem_0xF88;
    [FieldOffset(0x451)] public byte stat_magiclv;
    [FieldOffset(0x43D)] public bool stat_appear_motion_flag;
    [FieldOffset(0xDF9)] public byte stat_cursor_element;
    [FieldOffset(0x719)] public byte stat_limit_bar_flag_cam;
    [FieldOffset(0x718)] public bool stat_limit_bar_flag;
    [FieldOffset(0xDD2)] public bool stat_exist_flag;
    [FieldOffset(0x616)] public ushort __0x616;
    public bool stat_live { get { return (__0x616 & 1) != 0; } }
    public bool stat_str_memory { get { return (__0x616 >> 1 & 1) != 0; } }
    public bool stat_mag_memory { get { return (__0x616 >> 2 & 1) != 0; } }
    public bool stat_dex_memory { get { return (__0x616 >> 3 & 1) != 0; } }
    public bool stat_move_memory { get { return (__0x616 >> 4 & 1) != 0; } }
    public bool stat_ability_memory { get { return (__0x616 >> 5 & 1) != 0; } }
    public bool stat_dodge { get { return (__0x616 >> 6 & 1) != 0; } }
    public bool stat_defend { get { return (__0x616 >> 7 & 1) != 0; } }
    public bool stat_blow { get { return (__0x616 >> 8 & 1) != 0; } }
    public bool stat_relife { get { return (__0x616 >> 9 & 1) != 0; } }
    public bool stat_curse { get { return (__0x616 >> 10 & 1) != 0; } }
    public bool stat_defense { get { return (__0x616 >> 11 & 1) != 0; } }
    public bool stat_protect { get { return (__0x616 >> 12 & 1) != 0; } }
    public bool stat_iron { get { return (__0x616 >> 13 & 1) != 0; } }
    public bool stat_death_sentence { get { return (__0x616 >> 14 & 1) != 0; } }

    [FieldOffset(0x5C9)] public byte stat_death_sentence_start;
    [FieldOffset(0x5C8)] public byte stat_death_sentence_count;
    [FieldOffset(0x44E)] public byte stat_dmg_dir;
    [FieldOffset(0x41C)] public bool stat_direction_change_flag;
    [FieldOffset(0x41D)] public byte stat_direction_change_effect;
    [FieldOffset(0x41B)] public bool stat_direction_fix_flag;
    [FieldOffset(0x433)] public bool stat_hit_terminate_flag;
    [FieldOffset(0xD34)] public uint stat_damage_hp;
    [FieldOffset(0xD38)] public uint stat_damage_mp;
    [FieldOffset(0xD3C)] public uint stat_damage_ctb;
    [FieldOffset(0x423)] public bool stat_appear_invisible_flag;
    [FieldOffset(0xE0E)] public byte stat_effect_hit_num;
    [FieldOffset(0x425)] public bool stat_avoid_flag;
    [FieldOffset(0xDDE)] public bool stat_blow_exist_flag;
    [FieldOffset(0xDCD)] public bool stat_escape_flag;
    [FieldOffset(0x017)] public byte stat_hide;
    [FieldOffset(0x641)] public byte stat_def_death;
    [FieldOffset(0x642)] public byte stat_def_zombie;
    [FieldOffset(0x643)] public byte stat_def_stone;
    [FieldOffset(0x644)] public byte stat_def_poison;
    [FieldOffset(0x645)] public byte stat_def_power_break;
    [FieldOffset(0x646)] public byte stat_def_magic_break;
    [FieldOffset(0x647)] public byte stat_def_armor_break;
    [FieldOffset(0x648)] public byte stat_def_mental_break;
    [FieldOffset(0x649)] public byte stat_def_confuse;
    [FieldOffset(0x64A)] public byte stat_def_berserk;
    [FieldOffset(0x64B)] public byte stat_def_prov;
    [FieldOffset(0x64C)] public byte stat_def_threat;
    [FieldOffset(0x64D)] public byte stat_def_sleep;
    [FieldOffset(0x64E)] public byte stat_def_silence;
    [FieldOffset(0x64F)] public byte stat_def_dark;
    [FieldOffset(0x650)] public byte stat_def_shell;
    [FieldOffset(0x651)] public byte stat_def_protess;
    [FieldOffset(0x652)] public byte stat_def_reflect;
    [FieldOffset(0x653)] public byte stat_def_bawater;
    [FieldOffset(0x654)] public byte stat_def_bafire;
    [FieldOffset(0x655)] public byte stat_def_bathunder;
    [FieldOffset(0x656)] public byte stat_def_bacold;
    [FieldOffset(0x657)] public byte stat_def_regen;
    [FieldOffset(0x658)] public byte stat_def_haste;
    [FieldOffset(0x659)] public byte stat_def_slow;
    [FieldOffset(0x65A)] public ushort __0x65A;
    public bool stat_def_live { get { return (__0x65A & 1) != 0; } }
    public bool stat_def_str_memory { get { return (__0x65A >> 1 & 1) != 0; } }
    public bool stat_def_mag_memory { get { return (__0x65A >> 2 & 1) != 0; } }
    public bool stat_def_dex_memory { get { return (__0x65A >> 3 & 1) != 0; } }
    public bool stat_def_move_memory { get { return (__0x65A >> 4 & 1) != 0; } }
    public bool stat_def_ability_memory { get { return (__0x65A >> 5 & 1) != 0; } }
    public bool stat_def_dodge { get { return (__0x65A >> 6 & 1) != 0; } }
    public bool stat_def_defend { get { return (__0x65A >> 7 & 1) != 0; } }
    public bool stat_def_blow { get { return (__0x65A >> 8 & 1) != 0; } }
    public bool stat_def_relife { get { return (__0x65A >> 9 & 1) != 0; } }
    public bool stat_def_curse { get { return (__0x65A >> 10 & 1) != 0; } }
    public bool stat_def_defense { get { return (__0x65A >> 11 & 1) != 0; } }
    public bool stat_def_protect { get { return (__0x65A >> 12 & 1) != 0; } }
    public bool stat_def_iron { get { return (__0x65A >> 13 & 1) != 0; } }
    public bool stat_def_death_sentence { get { return (__0x65A >> 14 & 1) != 0; } }

	[FieldOffset(0x65D)] public uint stat_max_ctb;
	[FieldOffset(0x65E)] public byte cheer_count;
	[FieldOffset(0x660)] public byte focus_count;
	[FieldOffset(0x6BC)] public ushort auto_abilities1;
	public bool has_sensor { get { return (auto_abilities1 & 1) != 0; } }
	public bool has_first_strike { get { return (auto_abilities1 >> 1 & 1) != 0; } }
	public bool has_initiative { get { return (auto_abilities1 >> 2 & 1) != 0; } }
	public bool has_counter_attack { get { return (auto_abilities1 >> 3 & 1) != 0; } }
	public bool has_evade_and_counter { get { return (auto_abilities1 >> 4 & 1) != 0; } }
	public bool has_magic_counter { get { return (auto_abilities1 >> 5 & 1) != 0; } }
	public bool has_magic_booster { get { return (auto_abilities1 >> 6 & 1) != 0; } }
	public bool has_alchemy { get { return (auto_abilities1 >> 9 & 1) != 0; } }
	public bool has_auto_potion { get { return (auto_abilities1 >> 10 & 1) != 0; } }
	public bool has_auto_med { get { return (auto_abilities1 >> 11 & 1) != 0; } }
	public bool has_auto_phoenix { get { return (auto_abilities1 >> 12 & 1) != 0; } }
	public bool has_piercing { get { return (auto_abilities1 >> 13 & 1) != 0; } }
	public bool has_half_mp_cost { get { return (auto_abilities1 >> 14 & 1) != 0; } }
	public bool has_one_mp_cost { get { return (auto_abilities1 >> 15 & 1) != 0; } }

	[FieldOffset(0x6BE)] public ushort auto_abilities2;
	public bool has_double_overdrive { get { return (auto_abilities2 & 1) != 0; } }
	public bool has_triple_overdrive { get { return (auto_abilities2 >> 1 & 1) != 0; } }
	public bool has_sos_overdrive { get { return (auto_abilities2 >> 2 & 1) != 0; } }
	public bool has_overdrive_to_ap { get { return (auto_abilities2 >> 3 & 1) != 0; } }
	public bool has_double_ap { get { return (auto_abilities2 >> 5 & 1) != 0; } }
	public bool has_triple_ap { get { return (auto_abilities2 >> 6 & 1) != 0; } }
	public bool has_no_ap { get { return (auto_abilities2 >> 7 & 1) != 0; } }
	public bool has_break_hp_limit { get { return (auto_abilities2 >> 8 & 1) != 0; } }
	public bool has_break_mp_limit { get { return (auto_abilities2 >> 9 & 1) != 0; } }
	public bool has_break_damage_limit { get { return (auto_abilities2 >> 11 & 1) != 0; } }
	public bool has_aa30 { get { return (auto_abilities2 >> 14 & 1) != 0; } }
	public bool has_hp_stroll { get { return (auto_abilities2 >> 15 & 1) != 0; } }

	[FieldOffset(0x6C0)] public ushort auto_abilities3;
	public bool has_mp_stroll { get { return (auto_abilities3 & 1) != 0; } }
	public bool has_no_encounters { get { return (auto_abilities3 >> 1 & 1) != 0; } }
	public bool has_capture { get { return (auto_abilities3 >> 2 & 1) != 0; } }

	[FieldOffset(0xDD8)] public byte stat_hp_list;
    [FieldOffset(0x19)] public byte stat_visible_cam;
    [FieldOffset(0x1B)] public byte stat_visible_out;
    [FieldOffset(0x43B)] public byte stat_win_pose;
    [FieldOffset(0x23)] public bool stat_fast_model_flag;
    [FieldOffset(0x446)] public byte stat_command_type;
    [FieldOffset(0xDDA)] public bool stat_effect_target_flag;
    [FieldOffset(0xE10)] public byte stat_magic_effect_ground;
    [FieldOffset(0xE11)] public byte stat_magic_effect_water;
    [FieldOffset(0x4B8)] public byte stat_idle2_prob;
    [FieldOffset(0x408)] public byte stat_attack_motion_type;
    [FieldOffset(0x4B9)] public byte stat_attack_inc_speed;
    [FieldOffset(0x4BA)] public byte stat_attack_dec_speed;
    [FieldOffset(0x65C)] public byte stat_ctb;
    [FieldOffset(0x424)] public byte stat_appear_count;
    [FieldOffset(0x4BB)] public byte stat_motion_num;
    [FieldOffset(0xF74)] public byte stat_info_mes_id;
    [FieldOffset(0xF75)] public byte stat_live_mes_id;
    [FieldOffset(0x18)] public sbyte stat_visible_eff;
    [FieldOffset(0x21)] public bool stat_motion_dispose_flag;
    [FieldOffset(0x22)] public bool stat_model_dispose_flag;
    [FieldOffset(0x5B8)] public ushort __0x5B8;
	public bool immune_to_gravity { get { return (__0x5B8 >> 1 & 1) != 0; } }
    public bool stat_sp_inv_physic { get { return (__0x5B8 >> 5 & 1) != 0; } }
    public bool stat_sp_inv_magic { get { return (__0x5B8 >> 6 & 1) != 0; } }
    public bool stat_sp_invincible { get { return (__0x5B8 >> 7 & 1) != 0; } }
    public bool stat_def_ctb { get { return (__0x5B8 >> 8 & 1) != 0; } }
    public bool stat_sp_disable_zan { get { return (__0x5B8 >> 9 & 1) != 0; } }
    public bool stat_sp_wairo { get { return (__0x5B8 >> 10 & 1) != 0; } }

    [FieldOffset(0x26)] public sbyte stat_shadow;
    [FieldOffset(0x43C)] public sbyte stat_win_se;
    [FieldOffset(0x6DB)] public byte stat_attack_num;
    [FieldOffset(0x44A)] public sbyte stat_near_motion;
    [FieldOffset(0x44B)] public sbyte stat_near_motion_set;
    [FieldOffset(0x400)] public byte stat_motion_speed_normal;
    [FieldOffset(0x405)] public byte stat_motion_speed_normal_start;
    [FieldOffset(0x4B4)] public byte stat_own_attack_near;
    [FieldOffset(0x5CB)] public bool stat_prov_command_flag;
    [FieldOffset(0x5C4)] public byte stat_prov_chr;
    [FieldOffset(0x6CE)] public byte stat_use_mp0;
    [FieldOffset(0x5C3)] public byte stat_icon_number;
    [FieldOffset(0xE1A)] public short stat_sound_hit_num;
    [FieldOffset(0x6D1)] public byte stat_summoner;
    [FieldOffset(0x5A4)] public uint stat_over_kill_hp;
    [FieldOffset(0x409)] public byte stat_return_motion_type;
    [FieldOffset(0x6DF)] public byte stat_command_exe_count;
    [FieldOffset(0x6E0)] public byte stat_consent;
	[FieldOffset(0x6E4)] public int current_hp;
	[FieldOffset(0x6E8)] public int current_mp;
	[FieldOffset(0x6EC)] public int current_ctb;
    [FieldOffset(0x40D)] public byte stat_attack_near_frame;
    [FieldOffset(0x6E1)] public byte stat_energy;
    [FieldOffset(0x44F)] public byte stat_weak_motion;
    [FieldOffset(0x40E)] public byte stat_attack_motion_frame;
    [FieldOffset(0x700)] public sbyte stat_death_status;
    [FieldOffset(0xDCA)] public byte stat_target_list;
    [FieldOffset(0x3F8)] public bool stat_center_chr_flag;
    [FieldOffset(0x3F9)] public byte stat_death_return;
    [FieldOffset(0x3B)] public byte stat_eternal_relife;
    [FieldOffset(0x437)] public bool stat_neck_target_flag;
    [FieldOffset(0x1C)] public sbyte stat_visible_out_on;
    [FieldOffset(0xDDB)] public bool stat_regen_damage_flag;
    [FieldOffset(0x442)] public byte stat_num_print_element;
}

