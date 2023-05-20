﻿/* [fkelava 13/9/22 08:11]
 * source: MS Store ver.
 * header: _header_battle_define
 *
 * /ffx_ps2/ffx/proj2/chr/ath/battle/btl.h
 */

namespace Fahrenheit.CoreLib;

public enum FhXBtlId : T_XBtlId
{
    BTL_SYSTEM_00 = 0x00000000,
    BTL_SYSTEM_01 = 0x00000001,
    BTL_BJYT02_00 = 0x00200000,
    BTL_BJYT02_01 = 0x00200001,
    BTL_BJYT02_02 = 0x00200002,
    BTL_BJYT04_00 = 0x00220000,
    BTL_BJYT04_01 = 0x00220001,
    BTL_CDSP00_00 = 0x00320000,
    BTL_CDSP00_01 = 0x00320001,
    BTL_CDSP07_00 = 0x00390000,
    BTL_CDSP07_01 = 0x00390001,
    BTL_BSIL03_00 = 0x00440000,
    BTL_BSIL03_01 = 0x00440001,
    BTL_BSIL03_02 = 0x00440002,
    BTL_BSIL07_00 = 0x00480000,
    BTL_BSIL07_01 = 0x00480001,
    BTL_BSIL07_02 = 0x00480002,
    BTL_BSIL07_50 = 0x00480032,
    BTL_BSIL07_51 = 0x00480033,
    BTL_BSIL04_00 = 0x00450000,
    BTL_BSIL05_00 = 0x00460000,
    BTL_BSIL05_01 = 0x00460001,
    BTL_BSIL05_02 = 0x00460002,
    BTL_BSIL05_03 = 0x00460003,
    BTL_BSIL05_50 = 0x00460032,
    BTL_BSIL05_51 = 0x00460033,
    BTL_BSIL05_52 = 0x00460034,
    BTL_SLIK02_00 = 0x00610000,
    BTL_SLIK02_01 = 0x00610001,
    BTL_KLYT00_00 = 0x00830000,
    BTL_KLYT00_01 = 0x00830001,
    BTL_KLYT00_02 = 0x00830002,
    BTL_KLYT00_03 = 0x00830003,
    BTL_KLYT00_04 = 0x00830004,
    BTL_KLYT00_05 = 0x00830005,
    BTL_KLYT00_06 = 0x00830006,
    BTL_KLYT00_07 = 0x00830007,
    BTL_KLYT00_50 = 0x00830032,
    BTL_KLYT01_00 = 0x00840000,
    BTL_LCHB02_00 = 0x00A70000,
    BTL_LCHB03_00 = 0x00A80000,
    BTL_LCHB04_00 = 0x00A90000,
    BTL_CDSP02_00 = 0x00340000,
    BTL_LCHB08_00 = 0x00AD0000,
    BTL_LCHB07_00 = 0x00AC0000,
    BTL_LCHB07_01 = 0x00AC0001,
    BTL_MIHN00_00 = 0x00D20000,
    BTL_MIHN00_01 = 0x00D20001,
    BTL_MIHN00_02 = 0x00D20002,
    BTL_MIHN00_03 = 0x00D20003,
    BTL_MIHN00_04 = 0x00D20004,
    BTL_MIHN00_05 = 0x00D20005,
    BTL_MIHN00_20 = 0x00D20014,
    BTL_MIHN00_21 = 0x00D20015,
    BTL_MIHN00_22 = 0x00D20016,
    BTL_MIHN00_23 = 0x00D20017,
    BTL_MIHN00_50 = 0x00D20032,
    BTL_MIHN00_60 = 0x00D2003C,
    BTL_MIHN07_00 = 0x00D90000,
    BTL_MIHN07_01 = 0x00D90001,
    BTL_MIHN07_02 = 0x00D90002,
    BTL_MIHN07_03 = 0x00D90003,
    BTL_MIHN07_04 = 0x00D90004,
    BTL_MIHN07_05 = 0x00D90005,
    BTL_MIHN07_06 = 0x00D90006,
    BTL_MIHN07_07 = 0x00D90007,
    BTL_MIHN07_20 = 0x00D90014,
    BTL_MIHN07_21 = 0x00D90015,
    BTL_MIHN07_22 = 0x00D90016,
    BTL_MIHN07_23 = 0x00D90017,
    BTL_MIHN02_00 = 0x00D40000,
    BTL_MIHN04_00 = 0x00D60000,
    BTL_MIHN04_01 = 0x00D60001,
    BTL_MIHN04_02 = 0x00D60002,
    BTL_MIHN04_03 = 0x00D60003,
    BTL_MIHN04_04 = 0x00D60004,
    BTL_MIHN04_05 = 0x00D60005,
    BTL_MIHN04_06 = 0x00D60006,
    BTL_MIHN04_07 = 0x00D60007,
    BTL_MIHN04_20 = 0x00D60014,
    BTL_MIHN04_21 = 0x00D60015,
    BTL_MIHN04_22 = 0x00D60016,
    BTL_MIHN04_23 = 0x00D60017,
    BTL_MIHN04_24 = 0x00D60018,
    BTL_MIHN04_25 = 0x00D60019,
    BTL_MIHN04_26 = 0x00D6001A,
    BTL_MIHN04_27 = 0x00D6001B,
    BTL_KINO00_00 = 0x00DC0000,
    BTL_KINO00_01 = 0x00DC0001,
    BTL_KINO00_02 = 0x00DC0002,
    BTL_KINO00_03 = 0x00DC0003,
    BTL_KINO00_04 = 0x00DC0004,
    BTL_KINO00_05 = 0x00DC0005,
    BTL_KINO00_06 = 0x00DC0006,
    BTL_KINO01_00 = 0x00DD0000,
    BTL_KINO01_01 = 0x00DD0001,
    BTL_KINO01_02 = 0x00DD0002,
    BTL_KINO01_03 = 0x00DD0003,
    BTL_KINO01_04 = 0x00DD0004,
    BTL_KINO01_05 = 0x00DD0005,
    BTL_KINO01_06 = 0x00DD0006,
    BTL_KINO05_00 = 0x00E10000,
    BTL_KINO05_01 = 0x00E10001,
    BTL_KINO05_02 = 0x00E10002,
    BTL_KINO05_03 = 0x00E10003,
    BTL_KINO05_04 = 0x00E10004,
    BTL_KINO05_05 = 0x00E10005,
    BTL_KINO05_06 = 0x00E10006,
    BTL_KINO05_07 = 0x00E10007,
    BTL_KINO02_00 = 0x00DE0000,
    BTL_KINO07_00 = 0x00E30000,
    BTL_KINO07_01 = 0x00E30001,
    BTL_KINO07_02 = 0x00E30002,
    BTL_KINO07_03 = 0x00E30003,
    BTL_KINO07_04 = 0x00E30004,
    BTL_KINO07_05 = 0x00E30005,
    BTL_KINO03_10 = 0x00DF000A,
    BTL_KINO04_00 = 0x00E00000,
    BTL_KINO04_01 = 0x00E00001,
    BTL_KINO04_02 = 0x00E00002,
    BTL_KINO04_03 = 0x00E00003,
    BTL_KINO04_04 = 0x00E00004,
    BTL_KINO04_05 = 0x00E00005,
    BTL_KINO04_20 = 0x00E00014,
    BTL_KINO04_21 = 0x00E00015,
    BTL_KINO04_22 = 0x00E00016,
    BTL_KINO04_23 = 0x00E00017,
    BTL_KINO04_24 = 0x00E00018,
    BTL_KINO04_25 = 0x00E00019,
    BTL_KINO04_26 = 0x00E0001A,
    BTL_KINO04_27 = 0x00E0001B,
    BTL_GENK00_00 = 0x00F50000,
    BTL_GENK00_01 = 0x00F50001,
    BTL_GENK00_02 = 0x00F50002,
    BTL_GENK00_03 = 0x00F50003,
    BTL_GENK00_04 = 0x00F50004,
    BTL_GENK00_05 = 0x00F50005,
    BTL_GENK00_40 = 0x00F50028,
    BTL_GENK09_00 = 0x00FE0000,
    BTL_GENK16_00 = 0x01050000,
    BTL_GENK16_01 = 0x01050001,
    BTL_GENK16_02 = 0x01050002,
    BTL_GENK16_03 = 0x01050003,
    BTL_GENK16_04 = 0x01050004,
    BTL_GENK16_50 = 0x01050032,
    BTL_KAMI00_00 = 0x012C0000,
    BTL_KAMI00_01 = 0x012C0001,
    BTL_KAMI00_02 = 0x012C0002,
    BTL_KAMI00_03 = 0x012C0003,
    BTL_KAMI00_04 = 0x012C0004,
    BTL_KAMI00_05 = 0x012C0005,
    BTL_KAMI00_06 = 0x012C0006,
    BTL_KAMI00_07 = 0x012C0007,
    BTL_KAMI03_00 = 0x012F0000,
    BTL_KAMI03_01 = 0x012F0001,
    BTL_KAMI03_02 = 0x012F0002,
    BTL_KAMI03_03 = 0x012F0003,
    BTL_KAMI03_04 = 0x012F0004,
    BTL_KAMI03_05 = 0x012F0005,
    BTL_KAMI03_06 = 0x012F0006,
    BTL_KAMI03_07 = 0x012F0007,
    BTL_MCFR00_00 = 0x01360000,
    BTL_MCFR00_01 = 0x01360001,
    BTL_MCFR00_02 = 0x01360002,
    BTL_MCFR00_03 = 0x01360003,
    BTL_MCFR00_04 = 0x01360004,
    BTL_MCFR00_05 = 0x01360005,
    BTL_MCFR03_00 = 0x01390000,
    BTL_MACA00_00 = 0x014A0000,
    BTL_MACA00_01 = 0x014A0001,
    BTL_MACA00_02 = 0x014A0002,
    BTL_MCYT06_00 = 0x01590000,
    BTL_MCYT00_00 = 0x01540000,
    BTL_MCYT00_01 = 0x01540001,
    BTL_MCYT00_02 = 0x01540002,
    BTL_MCYT00_20 = 0x01540014,
    BTL_MCYT00_21 = 0x01540015,
    BTL_MCYT00_22 = 0x01540016,
    BTL_MACA03_00 = 0x014D0000,
    BTL_MACA03_01 = 0x014D0001,
    BTL_MACA03_02 = 0x014D0002,
    BTL_MACA03_20 = 0x014D0014,
    BTL_MACA03_21 = 0x014D0015,
    BTL_MACA03_22 = 0x014D0016,
    BTL_MACA02_00 = 0x014C0000,
    BTL_MACA02_01 = 0x014C0001,
    BTL_BIKA00_00 = 0x015E0000,
    BTL_BIKA00_10 = 0x015E000A,
    BTL_BIKA00_20 = 0x015E0014,
    BTL_BIKA01_00 = 0x015F0000,
    BTL_BIKA01_01 = 0x015F0001,
    BTL_BIKA01_02 = 0x015F0002,
    BTL_BIKA01_03 = 0x015F0003,
    BTL_BIKA01_04 = 0x015F0004,
    BTL_BIKA01_05 = 0x015F0005,
    BTL_BIKA01_10 = 0x015F000A,
    BTL_BIKA01_20 = 0x015F0014,
    BTL_BIKA01_21 = 0x015F0015,
    BTL_BIKA02_00 = 0x01600000,
    BTL_BIKA02_01 = 0x01600001,
    BTL_BIKA02_02 = 0x01600002,
    BTL_BIKA02_03 = 0x01600003,
    BTL_BIKA02_04 = 0x01600004,
    BTL_BIKA02_05 = 0x01600005,
    BTL_BIKA02_30 = 0x0160001E,
    BTL_BIKA02_10 = 0x0160000A,
    BTL_BIKA02_11 = 0x0160000B,
    BTL_BIKA02_12 = 0x0160000C,
    BTL_BIKA02_13 = 0x0160000D,
    BTL_BIKA02_14 = 0x0160000E,
    BTL_BIKA02_20 = 0x01600014,
    BTL_BIKA03_00 = 0x01610000,
    BTL_BIKA03_01 = 0x01610001,
    BTL_BIKA03_02 = 0x01610002,
    BTL_BIKA03_03 = 0x01610003,
    BTL_BIKA03_04 = 0x01610004,
    BTL_BIKA03_05 = 0x01610005,
    BTL_BIKA03_06 = 0x01610006,
    BTL_BIKA03_10 = 0x0161000A,
    BTL_BIKA03_11 = 0x0161000B,
    BTL_BIKA03_12 = 0x0161000C,
    BTL_BIKA03_13 = 0x0161000D,
    BTL_BIKA03_14 = 0x0161000E,
    BTL_BIKA03_15 = 0x0161000F,
    BTL_BIKA03_20 = 0x01610014,
    BTL_BIKA03_30 = 0x0161001E,
    BTL_BIKA03_31 = 0x0161001F,
    BTL_BIKA03_32 = 0x01610020,
    BTL_AZIT03_00 = 0x016B0000,
    BTL_AZIT03_01 = 0x016B0001,
    BTL_AZIT03_02 = 0x016B0002,
    BTL_AZIT03_03 = 0x016B0003,
    BTL_HIKU02_00 = 0x017E0000,
    BTL_HIKU02_01 = 0x017E0001,
    BTL_HIKU02_02 = 0x017E0002,
    BTL_HIKU15_00 = 0x018B0000,
    BTL_BVYT00_00 = 0x019A0000,
    BTL_BVYT00_01 = 0x019A0001,
    BTL_BVYT00_02 = 0x019A0002,
    BTL_BVYT09_00 = 0x01A30000,
    BTL_BVYT09_01 = 0x01A30001,
    BTL_BVYT09_02 = 0x01A30002,
    BTL_BVYT09_03 = 0x01A30003,
    BTL_BVYT09_04 = 0x01A30004,
    BTL_BVYT09_06 = 0x01A30006,
    BTL_BVYT09_20 = 0x01A30014,
    BTL_BVYT09_10 = 0x01A3000A,
    BTL_BVYT09_11 = 0x01A3000B,
    BTL_BVYT09_12 = 0x01A3000C,
    BTL_STBV00_00 = 0x01950000,
    BTL_STBV00_01 = 0x01950001,
    BTL_STBV00_02 = 0x01950002,
    BTL_STBV00_03 = 0x01950003,
    BTL_STBV00_04 = 0x01950004,
    BTL_STBV00_10 = 0x0195000A,
    BTL_STBV00_11 = 0x0195000B,
    BTL_STBV00_12 = 0x0195000C,
    BTL_STBV01_00 = 0x01960000,
    BTL_STBV01_01 = 0x01960001,
    BTL_STBV01_02 = 0x01960002,
    BTL_STBV01_10 = 0x0196000A,
    BTL_NAGI00_00 = 0x01A90000,
    BTL_NAGI00_01 = 0x01A90001,
    BTL_NAGI00_02 = 0x01A90002,
    BTL_NAGI00_03 = 0x01A90003,
    BTL_NAGI00_04 = 0x01A90004,
    BTL_NAGI00_05 = 0x01A90005,
    BTL_NAGI00_06 = 0x01A90006,
    BTL_NAGI00_40 = 0x01A90028,
    BTL_TORI01_20 = 0x02630014,
    BTL_TORI01_21 = 0x02630015,
    BTL_TORI01_22 = 0x02630016,
    BTL_TORI01_23 = 0x02630017,
    BTL_TORI01_24 = 0x02630018,
    BTL_TORI01_25 = 0x02630019,
    BTL_TORI01_26 = 0x0263001A,
    BTL_TORI01_27 = 0x0263001B,
    BTL_TORI01_28 = 0x0263001C,
    BTL_TORI01_29 = 0x0263001D,
    BTL_TORI02_20 = 0x02640014,
    BTL_TORI02_21 = 0x02640015,
    BTL_TORI02_22 = 0x02640016,
    BTL_TORI02_23 = 0x02640017,
    BTL_TORI02_24 = 0x02640018,
    BTL_TORI02_25 = 0x02640019,
    BTL_TORI02_26 = 0x0264001A,
    BTL_TORI02_27 = 0x0264001B,
    BTL_TORI02_28 = 0x0264001C,
    BTL_TORI02_29 = 0x0264001D,
    BTL_TORI03_20 = 0x02650014,
    BTL_TORI03_21 = 0x02650015,
    BTL_TORI03_22 = 0x02650016,
    BTL_TORI03_23 = 0x02650017,
    BTL_TORI03_24 = 0x02650018,
    BTL_TORI03_25 = 0x02650019,
    BTL_TORI03_26 = 0x0265001A,
    BTL_TORI03_27 = 0x0265001B,
    BTL_TORI03_28 = 0x0265001C,
    BTL_TORI03_29 = 0x0265001D,
    BTL_NAGI01_00 = 0x01AA0000,
    BTL_NAGI04_00 = 0x01AD0000,
    BTL_NAGI04_01 = 0x01AD0001,
    BTL_NAGI04_02 = 0x01AD0002,
    BTL_NAGI05_00 = 0x01AE0000,
    BTL_NAGI05_01 = 0x01AE0001,
    BTL_NAGI05_02 = 0x01AE0002,
    BTL_NAGI05_03 = 0x01AE0003,
    BTL_NAGI05_04 = 0x01AE0004,
    BTL_NAGI05_05 = 0x01AE0005,
    BTL_NAGI05_06 = 0x01AE0006,
    BTL_NAGI05_10 = 0x01AE000A,
    BTL_NAGI05_20 = 0x01AE0014,
    BTL_NAGI05_21 = 0x01AE0015,
    BTL_NAGI05_22 = 0x01AE0016,
    BTL_NAGI05_23 = 0x01AE0017,
    BTL_NAGI05_24 = 0x01AE0018,
    BTL_NAGI05_25 = 0x01AE0019,
    BTL_NAGI05_50 = 0x01AE0032,
    BTL_MTGZ01_00 = 0x01E60000,
    BTL_MTGZ01_01 = 0x01E60001,
    BTL_MTGZ01_02 = 0x01E60002,
    BTL_MTGZ01_03 = 0x01E60003,
    BTL_MTGZ01_04 = 0x01E60004,
    BTL_MTGZ01_05 = 0x01E60005,
    BTL_MTGZ01_10 = 0x01E6000A,
    BTL_MTGZ02_00 = 0x01E70000,
    BTL_MTGZ06_00 = 0x01EB0000,
    BTL_MTGZ06_01 = 0x01EB0001,
    BTL_MTGZ06_02 = 0x01EB0002,
    BTL_MTGZ06_03 = 0x01EB0003,
    BTL_MTGZ06_04 = 0x01EB0004,
    BTL_MTGZ06_05 = 0x01EB0005,
    BTL_MTGZ06_06 = 0x01EB0006,
    BTL_MTGZ07_00 = 0x01EC0000,
    BTL_MTGZ07_01 = 0x01EC0001,
    BTL_MTGZ07_02 = 0x01EC0002,
    BTL_MTGZ07_03 = 0x01EC0003,
    BTL_MTGZ08_00 = 0x01ED0000,
    BTL_ZKRN02_00 = 0x01F60000,
    BTL_ZKRN02_01 = 0x01F60001,
    BTL_ZKRN02_02 = 0x01F60002,
    BTL_ZKRN02_03 = 0x01F60003,
    BTL_ZKRN02_04 = 0x01F60004,
    BTL_DOME00_00 = 0x02030000,
    BTL_DOME00_01 = 0x02030001,
    BTL_DOME00_02 = 0x02030002,
    BTL_DOME00_03 = 0x02030003,
    BTL_DOME00_04 = 0x02030004,
    BTL_DOME00_05 = 0x02030005,
    BTL_DOME02_00 = 0x02050000,
    BTL_DOME06_00 = 0x02090000,
    BTL_SSBT00_00 = 0x02350000,
    BTL_SSBT01_00 = 0x02360000,
    BTL_SSBT02_00 = 0x02370000,
    BTL_SSBT03_00 = 0x02380000,
    BTL_SINS02_00 = 0x02460000,
    BTL_SINS02_01 = 0x02460001,
    BTL_SINS02_02 = 0x02460002,
    BTL_SINS02_03 = 0x02460003,
    BTL_SINS02_04 = 0x02460004,
    BTL_SINS03_00 = 0x02470000,
    BTL_SINS04_00 = 0x02480000,
    BTL_SINS04_01 = 0x02480001,
    BTL_SINS04_02 = 0x02480002,
    BTL_SINS04_03 = 0x02480003,
    BTL_SINS04_04 = 0x02480004,
    BTL_SINS04_05 = 0x02480005,
    BTL_SINS04_06 = 0x02480006,
    BTL_SINS04_07 = 0x02480007,
    BTL_SINS05_00 = 0x02490000,
    BTL_SINS05_01 = 0x02490001,
    BTL_SINS05_02 = 0x02490002,
    BTL_SINS05_03 = 0x02490003,
    BTL_SINS05_04 = 0x02490004,
    BTL_SINS05_05 = 0x02490005,
    BTL_SINS05_06 = 0x02490006,
    BTL_SINS05_07 = 0x02490007,
    BTL_SINS06_00 = 0x024A0000,
    BTL_SINS07_00 = 0x024B0000,
    BTL_SINS07_01 = 0x024B0001,
    BTL_SINS07_02 = 0x024B0002,
    BTL_SINS07_03 = 0x024B0003,
    BTL_SINS07_04 = 0x024B0004,
    BTL_SINS07_05 = 0x024B0005,
    BTL_SINS07_06 = 0x024B0006,
    BTL_SINS07_07 = 0x024B0007,
    BTL_SINS07_10 = 0x024B000A,
    BTL_LMYT01_00 = 0x01BE0000,
    BTL_LMYT01_01 = 0x01BE0001,
    BTL_LMYT01_02 = 0x01BE0002,
    BTL_LMYT01_03 = 0x01BE0003,
    BTL_LMYT01_04 = 0x01BE0004,
    BTL_LMYT01_05 = 0x01BE0005,
    BTL_LMYT01_06 = 0x01BE0006,
    BTL_LMYT01_07 = 0x01BE0007,
    BTL_ZNKD08_00 = 0x00120000,
    BTL_ZNKD08_01 = 0x00120001,
    BTL_ZNKD09_00 = 0x00130000,
    BTL_TORI00_00 = 0x02620000,
    BTL_TORI00_01 = 0x02620001,
    BTL_TORI00_02 = 0x02620002,
    BTL_TORI00_03 = 0x02620003,
    BTL_OMEG00_00 = 0x024E0000,
    BTL_OMEG00_01 = 0x024E0001,
    BTL_OMEG00_02 = 0x024E0002,
    BTL_OMEG00_03 = 0x024E0003,
    BTL_OMEG00_04 = 0x024E0004,
    BTL_OMEG00_05 = 0x024E0005,
    BTL_OMEG00_06 = 0x024E0006,
    BTL_OMEG00_07 = 0x024E0007,
    BTL_OMEG00_08 = 0x024E0008,
    BTL_OMEG00_09 = 0x024E0009,
    BTL_OMEG00_11 = 0x024E000B,
    BTL_OMEG00_12 = 0x024E000C,
    BTL_OMEG00_13 = 0x024E000D,
    BTL_OMEG00_14 = 0x024E000E,
    BTL_OMEG00_15 = 0x024E000F,
    BTL_OMEG00_16 = 0x024E0010,
    BTL_OMEG00_17 = 0x024E0011,
    BTL_OMEG00_18 = 0x024E0012,
    BTL_OMEG00_10 = 0x024E000A,
    BTL_OMEG01_00 = 0x024F0000,
    BTL_OMEG01_01 = 0x024F0001,
    BTL_OMEG01_02 = 0x024F0002,
    BTL_OMEG01_03 = 0x024F0003,
    BTL_OMEG01_04 = 0x024F0004,
    BTL_OMEG01_05 = 0x024F0005,
    BTL_OMEG01_06 = 0x024F0006,
    BTL_OMEG01_07 = 0x024F0007,
    BTL_OMEG01_08 = 0x024F0008,
    BTL_OMEG01_10 = 0x024F000A,
    BTL_TEST00_00 = 0x00020000,
    BTL_TEST00_01 = 0x00020001,
    BTL_TEST00_02 = 0x00020002,
    BTL_TEST00_03 = 0x00020003,
    BTL_TEST00_04 = 0x00020004,
    BTL_TEST00_05 = 0x00020005,
    BTL_TEST00_06 = 0x00020006,
    BTL_TEST00_07 = 0x00020007,
    BTL_TEST00_08 = 0x00020008,
    BTL_TEST00_09 = 0x00020009,
    BTL_TEST00_10 = 0x0002000A,
    BTL_TEST00_11 = 0x0002000B,
    BTL_TEST00_12 = 0x0002000C,
    BTL_TEST10_00 = 0x00050000,
    BTL_TEST10_01 = 0x00050001,
    BTL_TEST10_02 = 0x00050002,
    BTL_TEST10_03 = 0x00050003,
    BTL_TEST10_04 = 0x00050004,
    BTL_TEST10_05 = 0x00050005,
    BTL_TEST10_06 = 0x00050006,
    BTL_TEST10_07 = 0x00050007,
    BTL_TEST10_08 = 0x00050008,
    BTL_TEST10_09 = 0x00050009,
    BTL_TEST11_00 = 0x00060000,
    BTL_TEST11_01 = 0x00060001,
    BTL_TEST11_02 = 0x00060002,
    BTL_TEST11_03 = 0x00060003,
    BTL_TEST11_04 = 0x00060004,
    BTL_TEST11_05 = 0x00060005,
    BTL_TEST11_06 = 0x00060006,
    BTL_TEST11_07 = 0x00060007,
    BTL_TEST11_08 = 0x00060008,
    BTL_TEST11_09 = 0x00060009,
    BTL_ZZZZ00_00 = 0x02590000,
    BTL_ZZZZ00_01 = 0x02590001,
    BTL_ZZZZ00_02 = 0x02590002,
    BTL_ZZZZ00_03 = 0x02590003,
    BTL_ZZZZ00_04 = 0x02590004,
    BTL_ZZZZ00_05 = 0x02590005,
    BTL_ZZZZ00_06 = 0x02590006,
    BTL_ZZZZ00_07 = 0x02590007,
    BTL_ZZZZ00_08 = 0x02590008,
    BTL_ZZZZ00_09 = 0x02590009,
    BTL_ZZZZ00_10 = 0x0259000A,
    BTL_ZZZZ00_11 = 0x0259000B,
    BTL_ZZZZ00_12 = 0x0259000C,
    BTL_ZZZZ00_13 = 0x0259000D,
    BTL_ZZZZ00_14 = 0x0259000E,
    BTL_ZZZZ00_15 = 0x0259000F,
    BTL_ZZZZ00_16 = 0x02590010,
    BTL_ZZZZ00_17 = 0x02590011,
    BTL_ZZZZ00_18 = 0x02590012,
    BTL_ZZZZ00_19 = 0x02590013,
    BTL_ZZZZ00_20 = 0x02590014,
    BTL_ZZZZ00_21 = 0x02590015,
    BTL_ZZZZ00_22 = 0x02590016,
    BTL_ZZZZ00_23 = 0x02590017,
    BTL_ZZZZ00_24 = 0x02590018,
    BTL_ZZZZ00_25 = 0x02590019,
    BTL_ZZZZ00_26 = 0x0259001A,
    BTL_ZZZZ00_27 = 0x0259001B,
    BTL_ZZZZ00_28 = 0x0259001C,
    BTL_ZZZZ00_29 = 0x0259001D,
    BTL_ZZZZ00_30 = 0x0259001E,
    BTL_ZZZZ00_31 = 0x0259001F,
    BTL_ZZZZ00_32 = 0x02590020,
    BTL_ZZZZ00_33 = 0x02590021,
    BTL_ZZZZ00_34 = 0x02590022,
    BTL_ZZZZ00_35 = 0x02590023,
    BTL_ZZZZ00_36 = 0x02590024,
    BTL_ZZZZ00_37 = 0x02590025,
    BTL_ZZZZ00_38 = 0x02590026,
    BTL_ZZZZ00_39 = 0x02590027,
    BTL_ZZZZ00_40 = 0x02590028,
    BTL_ZZZZ00_41 = 0x02590029,
    BTL_ZZZZ00_42 = 0x0259002A,
    BTL_ZZZZ00_43 = 0x0259002B,
    BTL_ZZZZ00_44 = 0x0259002C,
    BTL_ZZZZ00_45 = 0x0259002D,
    BTL_ZZZZ00_46 = 0x0259002E,
    BTL_ZZZZ00_47 = 0x0259002F,
    BTL_ZZZZ00_48 = 0x02590030,
    BTL_ZZZZ00_49 = 0x02590031,
    BTL_ZZZZ00_50 = 0x02590032,
    BTL_ZZZZ00_51 = 0x02590033,
    BTL_ZZZZ00_52 = 0x02590034,
    BTL_ZZZZ00_53 = 0x02590035,
    BTL_ZZZZ00_54 = 0x02590036,
    BTL_ZZZZ00_55 = 0x02590037,
    BTL_ZZZZ00_56 = 0x02590038,
    BTL_ZZZZ00_57 = 0x02590039,
    BTL_ZZZZ00_58 = 0x0259003A,
    BTL_ZZZZ00_59 = 0x0259003B,
    BTL_ZZZZ00_60 = 0x0259003C,
    BTL_ZZZZ00_61 = 0x0259003D,
    BTL_ZZZZ00_62 = 0x0259003E,
    BTL_ZZZZ00_63 = 0x0259003F,
    BTL_ZZZZ00_64 = 0x02590040,
    BTL_ZZZZ00_65 = 0x02590041,
    BTL_ZZZZ00_66 = 0x02590042,
    BTL_ZZZZ00_67 = 0x02590043,
    BTL_ZZZZ00_68 = 0x02590044,
    BTL_ZZZZ00_69 = 0x02590045,
    BTL_ZZZZ00_70 = 0x02590046,
    BTL_ZZZZ00_71 = 0x02590047,
    BTL_ZZZZ00_72 = 0x02590048,
    BTL_ZZZZ00_73 = 0x02590049,
    BTL_ZZZZ00_74 = 0x0259004A,
    BTL_ZZZZ00_75 = 0x0259004B,
    BTL_ZZZZ00_76 = 0x0259004C,
    BTL_ZZZZ00_77 = 0x0259004D,
    BTL_ZZZZ00_78 = 0x0259004E,
    BTL_ZZZZ00_79 = 0x0259004F,
    BTL_ZZZZ00_80 = 0x02590050,
    BTL_ZZZZ00_81 = 0x02590051,
    BTL_ZZZZ00_82 = 0x02590052,
    BTL_ZZZZ00_83 = 0x02590053,
    BTL_ZZZZ00_84 = 0x02590054,
    BTL_ZZZZ00_85 = 0x02590055,
    BTL_ZZZZ00_86 = 0x02590056,
    BTL_ZZZZ00_87 = 0x02590057,
    BTL_ZZZZ00_88 = 0x02590058,
    BTL_ZZZZ00_89 = 0x02590059,
    BTL_ZZZZ00_90 = 0x0259005A,
    BTL_ZZZZ00_91 = 0x0259005B,
    BTL_ZZZZ00_92 = 0x0259005C,
    BTL_ZZZZ00_93 = 0x0259005D,
    BTL_ZZZZ00_94 = 0x0259005E,
    BTL_ZZZZ00_95 = 0x0259005F,
    BTL_ZZZZ00_96 = 0x02590060,
    BTL_ZZZZ00_97 = 0x02590061,
    BTL_ZZZZ00_98 = 0x02590062,
    BTL_ZZZZ00_99 = 0x02590063,
    BTL_ZZZZ00_100 = 0x02590064,
    BTL_ZZZZ00_101 = 0x02590065,
    BTL_ZZZZ00_102 = 0x02590066,
    BTL_ZZZZ00_103 = 0x02590067,
    BTL_ZZZZ00_104 = 0x02590068,
    BTL_ZZZZ00_105 = 0x02590069,
    BTL_ZZZZ00_106 = 0x0259006A,
    BTL_ZZZZ00_107 = 0x0259006B,
    BTL_ZZZZ00_108 = 0x0259006C,
    BTL_ZZZZ00_109 = 0x0259006D,
    BTL_ZZZZ00_110 = 0x0259006E,
    BTL_ZZZZ00_111 = 0x0259006F,
    BTL_ZZZZ00_112 = 0x02590070,
    BTL_ZZZZ00_113 = 0x02590071,
    BTL_ZZZZ00_114 = 0x02590072,
    BTL_ZZZZ00_115 = 0x02590073,
    BTL_ZZZZ00_116 = 0x02590074,
    BTL_ZZZZ00_117 = 0x02590075,
    BTL_ZZZZ00_118 = 0x02590076,
    BTL_ZZZZ00_119 = 0x02590077,
    BTL_ZZZZ00_120 = 0x02590078,
    BTL_ZZZZ00_121 = 0x02590079,
    BTL_ZZZZ00_122 = 0x0259007A,
    BTL_ZZZZ00_123 = 0x0259007B,
    BTL_ZZZZ00_124 = 0x0259007C,
    BTL_ZZZZ00_125 = 0x0259007D,
    BTL_ZZZZ00_126 = 0x0259007E,
    BTL_ZZZZ00_127 = 0x0259007F,
    BTL_ZZZZ00_128 = 0x02590080,
    BTL_ZZZZ00_129 = 0x02590081,
    BTL_ZZZZ00_130 = 0x02590082,
    BTL_ZZZZ00_131 = 0x02590083,
    BTL_ZZZZ00_132 = 0x02590084,
    BTL_ZZZZ00_133 = 0x02590085,
    BTL_ZZZZ00_134 = 0x02590086,
    BTL_ZZZZ00_135 = 0x02590087,
    BTL_ZZZZ00_136 = 0x02590088,
    BTL_ZZZZ00_137 = 0x02590089,
    BTL_ZZZZ00_138 = 0x0259008A,
    BTL_ZZZZ00_139 = 0x0259008B,
    BTL_ZZZZ00_140 = 0x0259008C,
    BTL_ZZZZ00_141 = 0x0259008D,
    BTL_ZZZZ00_142 = 0x0259008E,
    BTL_ZZZZ00_143 = 0x0259008F,
    BTL_ZZZZ00_144 = 0x02590090,
    BTL_ZZZZ00_145 = 0x02590091,
    BTL_ZZZZ00_146 = 0x02590092,
    BTL_ZZZZ00_147 = 0x02590093,
    BTL_ZZZZ00_148 = 0x02590094,
    BTL_ZZZZ00_149 = 0x02590095,
    BTL_ZZZZ00_150 = 0x02590096,
    BTL_ZZZZ00_151 = 0x02590097,
    BTL_ZZZZ00_152 = 0x02590098,
    BTL_ZZZZ00_153 = 0x02590099,
    BTL_ZZZZ00_154 = 0x0259009A,
    BTL_ZZZZ00_155 = 0x0259009B,
    BTL_ZZZZ00_156 = 0x0259009C,
    BTL_ZZZZ00_157 = 0x0259009D,
    BTL_ZZZZ00_158 = 0x0259009E,
    BTL_ZZZZ00_159 = 0x0259009F,
    BTL_ZZZZ00_160 = 0x025900A0,
    BTL_ZZZZ00_161 = 0x025900A1,
    BTL_ZZZZ00_162 = 0x025900A2,
    BTL_ZZZZ00_163 = 0x025900A3,
    BTL_ZZZZ00_164 = 0x025900A4,
    BTL_ZZZZ00_165 = 0x025900A5,
    BTL_ZZZZ00_166 = 0x025900A6,
    BTL_ZZZZ00_167 = 0x025900A7,
    BTL_ZZZZ00_168 = 0x025900A8,
    BTL_ZZZZ00_169 = 0x025900A9,
    BTL_ZZZZ00_170 = 0x025900AA,
    BTL_ZZZZ00_171 = 0x025900AB,
    BTL_ZZZZ00_172 = 0x025900AC,
    BTL_ZZZZ00_173 = 0x025900AD,
    BTL_ZZZZ00_174 = 0x025900AE,
    BTL_ZZZZ00_175 = 0x025900AF,
    BTL_ZZZZ00_176 = 0x025900B0,
    BTL_ZZZZ00_177 = 0x025900B1,
    BTL_ZZZZ00_178 = 0x025900B2,
    BTL_ZZZZ00_179 = 0x025900B3,
    BTL_ZZZZ00_180 = 0x025900B4,
    BTL_ZZZZ00_181 = 0x025900B5,
    BTL_ZZZZ00_182 = 0x025900B6,
    BTL_ZZZZ00_183 = 0x025900B7,
    BTL_ZZZZ00_184 = 0x025900B8,
    BTL_ZZZZ00_185 = 0x025900B9,
    BTL_ZZZZ00_186 = 0x025900BA,
    BTL_ZZZZ00_187 = 0x025900BB,
    BTL_ZZZZ00_188 = 0x025900BC,
    BTL_ZZZZ00_189 = 0x025900BD,
    BTL_ZZZZ00_190 = 0x025900BE,
    BTL_ZZZZ00_191 = 0x025900BF,
    BTL_ZZZZ00_192 = 0x025900C0,
    BTL_ZZZZ00_193 = 0x025900C1,
    BTL_ZZZZ00_194 = 0x025900C2,
    BTL_ZZZZ00_195 = 0x025900C3,
    BTL_ZZZZ00_196 = 0x025900C4,
    BTL_ZZZZ00_197 = 0x025900C5,
    BTL_ZZZZ00_198 = 0x025900C6,
    BTL_ZZZZ00_199 = 0x025900C7,
    BTL_ZZZZ00_200 = 0x025900C8,
    BTL_ZZZZ00_201 = 0x025900C9,
    BTL_ZZZZ00_202 = 0x025900CA,
    BTL_ZZZZ00_203 = 0x025900CB,
    BTL_ZZZZ00_204 = 0x025900CC,
    BTL_ZZZZ00_205 = 0x025900CD,
    BTL_ZZZZ00_206 = 0x025900CE,
    BTL_ZZZZ00_207 = 0x025900CF,
    BTL_ZZZZ00_208 = 0x025900D0,
    BTL_ZZZZ00_209 = 0x025900D1,
    BTL_ZZZZ00_210 = 0x025900D2,
    BTL_ZZZZ00_211 = 0x025900D3,
    BTL_ZZZZ00_212 = 0x025900D4,
    BTL_ZZZZ00_213 = 0x025900D5,
    BTL_ZZZZ00_214 = 0x025900D6,
    BTL_ZZZZ00_215 = 0x025900D7,
    BTL_ZZZZ00_216 = 0x025900D8,
    BTL_ZZZZ00_217 = 0x025900D9,
    BTL_ZZZZ00_218 = 0x025900DA,
    BTL_ZZZZ00_219 = 0x025900DB,
    BTL_ZZZZ00_220 = 0x025900DC,
    BTL_ZZZZ00_221 = 0x025900DD,
    BTL_ZZZZ00_222 = 0x025900DE,
    BTL_ZZZZ00_223 = 0x025900DF,
    BTL_ZZZZ00_224 = 0x025900E0,
    BTL_ZZZZ00_225 = 0x025900E1,
    BTL_ZZZZ00_226 = 0x025900E2,
    BTL_ZZZZ00_227 = 0x025900E3,
    BTL_ZZZZ00_228 = 0x025900E4,
    BTL_ZZZZ00_229 = 0x025900E5,
    BTL_ZZZZ00_230 = 0x025900E6,
    BTL_ZZZZ00_231 = 0x025900E7,
    BTL_ZZZZ00_232 = 0x025900E8,
    BTL_ZZZZ00_233 = 0x025900E9,
    BTL_ZZZZ00_234 = 0x025900EA,
    BTL_ZZZZ00_235 = 0x025900EB,
    BTL_ZZZZ00_236 = 0x025900EC,
    BTL_ZZZZ00_237 = 0x025900ED,
    BTL_ZZZZ00_238 = 0x025900EE,
    BTL_ZZZZ00_239 = 0x025900EF,
    BTL_ZZZZ00_240 = 0x025900F0,
    BTL_ZZZZ00_241 = 0x025900F1,
    BTL_ZZZZ00_242 = 0x025900F2,
    BTL_ZZZZ00_243 = 0x025900F3,
    BTL_ZZZZ00_244 = 0x025900F4,
    BTL_ZZZZ00_245 = 0x025900F5,
    BTL_ZZZZ00_246 = 0x025900F6,
    BTL_ZZZZ00_247 = 0x025900F7,
    BTL_ZZZZ00_248 = 0x025900F8,
    BTL_ZZZZ00_249 = 0x025900F9,
    BTL_ZZZZ00_250 = 0x025900FA,
    BTL_ZZZZ00_251 = 0x025900FB,
    BTL_ZZZZ00_252 = 0x025900FC,
    BTL_ZZZZ00_253 = 0x025900FD,
    BTL_ZZZZ00_254 = 0x025900FE,
    BTL_ZZZZ02_55 = 0x025B0037,
    BTL_ZZZZ02_56 = 0x025B0038,
    BTL_ZZZZ02_57 = 0x025B0039,
    BTL_ZZZZ02_58 = 0x025B003A,
    BTL_ZZZZ02_59 = 0x025B003B,
    BTL_ZZZZ02_60 = 0x025B003C,
    BTL_ZZZZ02_61 = 0x025B003D,
    BTL_ZZZZ02_62 = 0x025B003E,
    BTL_ZZZZ02_63 = 0x025B003F,
    BTL_ZZZZ02_64 = 0x025B0040,
    BTL_ZZZZ02_65 = 0x025B0041,
    BTL_ZZZZ02_66 = 0x025B0042,
    BTL_ZZZZ02_67 = 0x025B0043,
    BTL_ZZZZ02_68 = 0x025B0044,
    BTL_ZZZZ02_69 = 0x025B0045,
    BTL_ZZZZ02_70 = 0x025B0046,
    BTL_ZZZZ02_71 = 0x025B0047,
    BTL_ZZZZ02_72 = 0x025B0048,
    BTL_ZZZZ02_73 = 0x025B0049,
    BTL_ZZZZ02_74 = 0x025B004A,
    BTL_ZZZZ02_75 = 0x025B004B,
    BTL_ZZZZ02_76 = 0x025B004C,
    BTL_ZZZZ02_77 = 0x025B004D,
    BTL_ZZZZ02_78 = 0x025B004E,
    BTL_ZZZZ02_79 = 0x025B004F,
    BTL_ZZZZ02_80 = 0x025B0050,
    BTL_ZZZZ02_81 = 0x025B0051,
    BTL_ZZZZ02_82 = 0x025B0052,
    BTL_ZZZZ02_83 = 0x025B0053,
    BTL_ZZZZ02_84 = 0x025B0054,
    BTL_ZZZZ02_85 = 0x025B0055,
    BTL_ZZZZ02_86 = 0x025B0056,
    BTL_ZZZZ02_87 = 0x025B0057,
    BTL_ZZZZ02_88 = 0x025B0058,
    BTL_ZZZZ02_89 = 0x025B0059,
    BTL_ZZZZ02_90 = 0x025B005A,
    BTL_ZZZZ02_91 = 0x025B005B,
    BTL_ZZZZ02_92 = 0x025B005C,
    BTL_ZZZZ02_93 = 0x025B005D,
    BTL_ZZZZ02_94 = 0x025B005E,
    BTL_ZZZZ02_95 = 0x025B005F,
    BTL_ZZZZ02_96 = 0x025B0060,
    BTL_ZZZZ02_97 = 0x025B0061,
    BTL_ZZZZ02_98 = 0x025B0062,
    BTL_ZZZZ02_99 = 0x025B0063,
    BTL_ZZZZ03_00 = 0x025C0000,
    BTL_ZZZZ03_01 = 0x025C0001,
    BTL_ZZZZ03_02 = 0x025C0002,
    BTL_ZZZZ03_03 = 0x025C0003,
    BTL_ZZZZ03_04 = 0x025C0004,
    BTL_ZZZZ03_05 = 0x025C0005,
    BTL_ZZZZ03_06 = 0x025C0006,
    BTL_ZZZZ03_07 = 0x025C0007,
    BTL_ZZZZ03_08 = 0x025C0008,
    BTL_ZZZZ03_09 = 0x025C0009,
    BTL_ZZZZ03_10 = 0x025C000A,
    BTL_ZZZZ03_11 = 0x025C000B,
    BTL_ZZZZ03_12 = 0x025C000C,
    BTL_ZZZZ03_13 = 0x025C000D,
    BTL_ZZZZ03_14 = 0x025C000E,
    BTL_ZZZZ03_15 = 0x025C000F,
    BTL_ZZZZ03_16 = 0x025C0010,
    BTL_ZZZZ03_17 = 0x025C0011,
    BTL_ZZZZ03_18 = 0x025C0012,
    BTL_ZZZZ03_19 = 0x025C0013,
    BTL_ZZZZ03_20 = 0x025C0014,
    BTL_ZZZZ03_21 = 0x025C0015,
    BTL_ZZZZ03_22 = 0x025C0016,
    BTL_ZZZZ03_23 = 0x025C0017,
    BTL_ZZZZ03_24 = 0x025C0018,
    BTL_ZZZZ03_25 = 0x025C0019,
    BTL_ZZZZ03_26 = 0x025C001A,
    BTL_ZZZZ03_27 = 0x025C001B,
    BTL_ZZZZ03_28 = 0x025C001C,
    BTL_ZZZZ03_29 = 0x025C001D,
    BTL_ZZZZ03_30 = 0x025C001E,
    BTL_ZZZZ03_31 = 0x025C001F,
    BTL_ZZZZ03_32 = 0x025C0020,
    BTL_ZZZZ03_33 = 0x025C0021,
    BTL_ZZZZ03_34 = 0x025C0022,
}
