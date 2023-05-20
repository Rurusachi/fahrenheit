﻿/* [fkelava 13/9/22 08:16]
 * source: MS Store ver.
 * header: __chr_obj_h
 *
 * /ffx_ps2/ffx/proj2/chr/ath/obj.ath
 */

namespace Fahrenheit.CoreLib;

public enum FhXObjId : T_XObjId
{
    F001                = 0x5001, // ＳＡＶＥスフィア
    CHR_SAVESPHERE001   = 0x5001,    
    F002                = 0x5002, // 宝箱ノーマルＡ（近景）
    CHR_TAKARABOX002    = 0x5002,    
    F004                = 0x5004, // エボンの祠
    CHR_HOKORA004       = 0x5004,    
    F005                = 0x5005, // エボンの刻印
    CHR_KOKUIN005       = 0x5005,    
    F006                = 0x5006, // ボール
    CHR_BALL006         = 0x5006,    
    F007                = 0x5007, // 魚群Ａ
    CHR_FISH007         = 0x5007,    
    F008                = 0x5008, // 蝶々
    CHR_BUTTERFLY008    = 0x5008,    
    F009                = 0x5009, // 犬っぽい泳げる動物
    CHR_DOG009          = 0x5009,    
    F010                = 0x500A, // エボン雷猿
    CHR_MONKEY010       = 0x500A,    
    F011                = 0x500B, // アルベド本
    CHR_ALBDBOOK011     = 0x500B,    
    F012                = 0x500C, // ユウナのバッグ
    CHR_LUGGAGE012      = 0x500C,    
    F013                = 0x500D, // 湯呑み
    CHR_YUNOMI013       = 0x500D,    
    F015                = 0x500F, // 空き缶
    CHR_CAN015          = 0x500F,    
    F016                = 0x5010, // スフィア案内板
    CHR_INFOBOARD016    = 0x5010,    
    F017                = 0x5011, // ビン
    CHR_BOTTLE017       = 0x5011,    
    F018                = 0x5012, // クリスタルカップ
    CHR_TROPHY018       = 0x5012,    
    F021                = 0x5015, // 手持ちカメラ
    CHR_HANDYCAMERA021  = 0x5015,    
    F022                = 0x5016, // ジョッキ
    CHR_MUG022          = 0x5016,    
    F023                = 0x5017, // 飛んでるスピラカモメ　（ハイ）
    CHR_KAMOME_HI023    = 0x5017,    
    F024                = 0x5018, // 肩担ぎカメラ
    CHR_SHOULDERCAM024  = 0x5018,    
    F027                = 0x501B, // メガホン
    CHR_MEGAHON027      = 0x501B,    
    F028                = 0x501C, // マイク
    CHR_MIKE028         = 0x501C,    
    F029                = 0x501D, // ネコもどき
    CHR_CAT029          = 0x501D,    
    F030                = 0x501E, // ブリッツ応援旗Ａ
    CHR_CHEERFLAG_A030  = 0x501E,    
    F031                = 0x501F, // ブリッツ応援旗Ｂ
    CHR_CHEERFLAG_B031  = 0x501F,    
    F032                = 0x5020, // ブリッツ応援旗Ｃ
    CHR_CHEERFLAG_C032  = 0x5020,    
    F033                = 0x5021, // ブリッツ応援旗Ｄ
    CHR_CHEERFLAG_D033  = 0x5021,    
    F034                = 0x5022, // ブリッツ応援旗Ｅ
    CHR_CHEERFLAG_E034  = 0x5022,    
    F035                = 0x5023, // ブリッツ応援旗Ｆ
    CHR_CHEERFLAG_F035  = 0x5023,    
    F047                = 0x502F, // シパーフ
    CHR_SIPAHU047       = 0x502F,    
    F048                = 0x5030, // 子供シパーフ
    CHR_SIPAHUKID048    = 0x5030,    
    F049                = 0x5031, // 幻光花（ハイポリ）
    CHR_GENKOUKA_HI049  = 0x5031,    
    F050                = 0x5032, // 幻光花（ローポリ）
    CHR_GENKOUKA_LO050  = 0x5032,    
    F051                = 0x5033, // チョコボ
    CHR_CHOCOBO051      = 0x5033,    
    F052                = 0x5034, // 騎兵チョコボ
    CHR_CHOCOBO_SLD052  = 0x5034,    
    F053                = 0x5035, // 飛んでいない不気味な海鳥（ハイポリ）
    CHR_SEABIRD_HI053   = 0x5035,    
    F054                = 0x5036, // イルカ
    CHR_IRUKA054        = 0x5036,    
    F057                = 0x5039, // モンスターゾリ
    CHR_MON_SORI057     = 0x5039,    
    F058                = 0x503A, // 氷上スクーター
    CHR_ICESCOOT058     = 0x503A,    
    F059                = 0x503B, // 双眼鏡（ローポリ）
    CHR_SCOPE_LO059     = 0x503B,    
    F060                = 0x503C, // 双眼鏡（ハイポリ）
    CHR_SCOPE_HI060     = 0x503C,    
    F061                = 0x503D, // 銛射出装置（ローポリ）
    CHR_ANCHOR_LO061    = 0x503D,    
    F062                = 0x503E, // 銛射出装置（ハイポリ）
    CHR_ANCHOR_HI062    = 0x503E,    
    F064                = 0x5040, // ノコギリ
    CHR_NOKOGIRI064     = 0x5040,    
    F065                = 0x5041, // ハンマー
    CHR_HAMMER065       = 0x5041,    
    F069                = 0x5045, // 壊れたスフィア
    CHR_BREAKSPHERE069  = 0x5045,    
    F072                = 0x5048, // 不気味な海鳥（近景用）
    CHR_SEABIRD_HI072   = 0x5048,    
    F073                = 0x5049, // 不気味な海鳥（遠景用）
    CHR_SEABIRD_LO073   = 0x5049,    
    F075                = 0x504B, // 枯れた花束
    CHR_DRYFLOWER075    = 0x504B,    
    F079                = 0x504F, // 荒天装備マスク
    CHR_ALBDMASK079     = 0x504F,    
    F080                = 0x5050, // コンバットナイフ
    CHR_KNIFE080        = 0x5050,    
    F081                = 0x5051, // レーション
    CHR_RATION081       = 0x5051,    
    F082                = 0x5052, // 水筒
    CHR_SUITOU082       = 0x5052,    
    F084                = 0x5054, // 檻（小）
    CHR_CAGE_S084       = 0x5054,    
    F085                = 0x5055, // 荷車（布有り）
    CHR_WAGONCLOTH085   = 0x5055,    
    F086                = 0x5056, // 荷車（布無し）
    CHR_WAGON086        = 0x5056,    
    F087                = 0x5057, // チョコボの羽
    CHR_FEATHER087      = 0x5057,    
    F088                = 0x5058, // 古ぼけた剣
    CHR_OLDSWORD088     = 0x5058,    
    F090                = 0x505A, // 宝箱ノーマルＢ（遠景）
    CHR_TAKARABOX090    = 0x505A,    
    F091                = 0x505B, // 豪華宝箱Ａ（近景）
    CHR_TAKARABOX_SA091 = 0x505B,    
    F092                = 0x505C, // 豪華宝箱Ｂ（遠景）
    CHR_TAKARABOX_SB092 = 0x505C,    
    F093                = 0x505D, // 魚群Ｂ
    CHR_FISH_B093       = 0x505D,    
    F094                = 0x505E, // 魚群Ｃ
    CHR_FISH_C094       = 0x505E,    
    F095                = 0x505F, // 魚群Ｄ
    CHR_FISH_D095       = 0x505F,    
    F096                = 0x5060, // 魚群Ｅ
    CHR_FISH_E096       = 0x5060,    
    F097                = 0x5061, // 壊れた銛射出装置（ロー）
    CHR_BROKENANCHOR097 = 0x5061,    
    F098                = 0x5062, // シーモア近衛兵の武器
    CHR_GUARDS_WEP098   = 0x5062,    
    F099                = 0x5063, // 風船（１個）
    CHR_BALLOON099      = 0x5063,    
    F100                = 0x5064, // 風船（１０個くらいの束） | 
    CHR_10BALLOONS100   = 0x5064,    
    F101                = 0x5065, // シンから生まれたもの３
    CHR_SHIN3_FLD101    = 0x5065,    
    F102                = 0x5066, // 檻の中のモンスター
    CHR_SHIN3PART102    = 0x5066,    
    F103                = 0x5067, // 討伐隊汎用武器（剣）
    CHR_EXPDS_WEP103    = 0x5067,    
    F105                = 0x5069, // グラス（飲み物あり）
    CHR_GLASS105        = 0x5069,    
    F106                = 0x506A, // 果物Ａ
    CHR_FRUIT_A106      = 0x506A,    
    F107                = 0x506B, // 果物Ｂ
    CHR_FRUIT_B107      = 0x506B,    
    F108                = 0x506C, // 静止スフィア
    CHR_PHOTOSPHERE108  = 0x506C,    
    F109                = 0x506D, // 祭壇
    CHR_SAIDAN109       = 0x506D,    
    F110                = 0x506E, // 光のスフィア
    CHR_SPHERE_A110     = 0x506E,    
    F111                = 0x506F, // 闇のスフィア
    CHR_SPHERE_B111     = 0x506F,    
    F112                = 0x5070, // 無のスフィア
    CHR_SPHERE_C112     = 0x5070,    
    F113                = 0x5071, // 雷のスフィア
    CHR_SPHERE_D113     = 0x5071,    
    F114                = 0x5072, // 炎のスフィア
    CHR_SPHERE_E114     = 0x5072,    
    F116                = 0x5074, // 氷のスフィア
    CHR_SPHERE_G116     = 0x5074,    
    F117                = 0x5075, // 封のスフィア
    CHR_SPHERE_H117     = 0x5075,    
    F118                = 0x5076, // 破のスフィア
    CHR_SPHERE_I118     = 0x5076,    
    F120                = 0x5078, // 階段型リフト
    CHR_STAIRSRIDE120   = 0x5078,    
    F122                = 0x507A, // グラス（飲み物なし）
    CHR_EMPTY_GLASS122  = 0x507A,    
    F123                = 0x507B, // 幻光花・葉の部分のみ（ローポリ）
    CHR_LEAF_LO123      = 0x507B,    
    F124                = 0x507C, // 瓦礫Ａ
    CHR_GAREKI_A124     = 0x507C,    
    F125                = 0x507D, // 瓦礫Ｂ
    CHR_GAREKI_B125     = 0x507D,    
    F126                = 0x507E, // ホバー
    CHR_HOVER126        = 0x507E,    
    F127                = 0x507F, // 封印解除アイテム
    CHR_SEALBREAKER127  = 0x507F,    
    F128                = 0x5080, // ミニ飛空艇（削除）
    CHR_AIRSHIP128      = 0x5080,    
    F129                = 0x5081, // シパーフ乗降用リフト
    CHR_LIFT129         = 0x5081,    
    F146                = 0x5092, // ユウナにかける毛布（削除）
    CHR_BLANKET146      = 0x5092,    
    F147                = 0x5093, // 御開帳岩
    CHR_OPENSTONE147    = 0x5093,    
    F149                = 0x5095, // エボンワープ印
    CHR_WARP149         = 0x5095,    
    F150                = 0x5096, // くさび
    CHR_KUSABI150       = 0x5096,    
    F156                = 0x509C, // シパーフ鞍
    CHR_SIPAHU_KURA156  = 0x509C,    
    F157                = 0x509D, // スフィア映像装置起動スイッチ
    CHR_SPHERE_SW157    = 0x509D,    
    F158                = 0x509E, // ｎ１４４亜人種のラッパ
    CHR_TRUMPET158      = 0x509E,    
    F159                = 0x509F, // 差しこみ口２つの祭壇
    CHR_SAIDAN_2PUT159  = 0x509F,    
    F161                = 0x50A1, // エボン僧兵武器
    CHR_RIFLE161        = 0x50A1,    
    F162                = 0x50A2, // 荷車（檻の乗っていない空車）
    CHR_WAGON_FREE162   = 0x50A2,    
    F163                = 0x50A3, // 飛空艇マップ用カーソル
    CHR_MAP_POINTER163  = 0x50A3,    
    F164                = 0x50A4, // 蝶々２
    CHR_BUTTERFLY2_164  = 0x50A4,    
    F165                = 0x50A5, // 蝶々３
    CHR_BUTTERFLY3_165  = 0x50A5,    
    F166                = 0x50A6, // アルベド本２
    CHR_ALBDBOOK2_166   = 0x50A6,    
    F167                = 0x50A7, // 飛んでいないスピラカモメ（ハイポリ）
    CHR_KAMOME_HI2_167  = 0x50A7,    
    F168                = 0x50A8, // 壊れる柱
    CHR_BREAK_PILLAR168 = 0x50A8,    
    F169                = 0x50A9, // 閃光弾
    CHR_FLASHBOMB169    = 0x50A9,    
    F170                = 0x50AA, // アルベド救命ボックス 
    CHR_ALBD_BOX170     = 0x50AA,    
    F171                = 0x50AB, // 水中用ＳＡＶＥスフィア
    CHR_SAVESPHERE_W171 = 0x50AB,    
    F172                = 0x50AC, // ミニミニ飛空艇
    CHR_MINI_AIRSHIP172 = 0x50AC,    
    F173                = 0x50AD, // ルカ・ゴワーズ応援旗アップ用
    CHR_LUCA_FLAG173    = 0x50AD,    
    F175                = 0x50AF, // ティアラ
    CHR_TIARA           = 0x50AF,    
    F176                = 0x50B0, // 飛空艇マップ用カーソル
    CHR_CURSOR176       = 0x50B0,
}