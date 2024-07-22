using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coflnet.Sky.PlayerInfo.Models.HypixelProfile;
#pragma warning disable CS1591

public class Crate
{
    [JsonPropertyName("NORMAL")]
    public bool NORMAL { get; set; }

    [JsonPropertyName("VIP")]
    public bool VIP { get; set; }

    [JsonPropertyName("VIP_PLUS")]
    public bool VIP_PLUS { get; set; }

    [JsonPropertyName("MVP")]
    public bool MVP { get; set; }

    [JsonPropertyName("MVP_PLUS")]
    public bool MVP_PLUS { get; set; }
}

public class SkyblockProfile
{
    [JsonPropertyName("profile_id")]
    public string profile_id { get; set; }

    [JsonPropertyName("cute_name")]
    public string cute_name { get; set; }
}

public class _2021
{
    [JsonPropertyName("presents")]
    public Presents presents { get; set; }
}

public class _2022
{
    [JsonPropertyName("levelling")]
    public Levelling levelling { get; set; }
}

public class _2023
{
    [JsonPropertyName("levelling")]
    public Levelling levelling { get; set; }

    [JsonPropertyName("adventRewards")]
    public AdventRewards adventRewards { get; set; }

    [JsonPropertyName("presents")]
    public Presents presents { get; set; }

    [JsonPropertyName("bingo")]
    public Bingo bingo { get; set; }

    [JsonPropertyName("skyBlockAlchemistIntro")]
    public bool skyBlockAlchemistIntro { get; set; }
}

public class _2024
{
    [JsonPropertyName("levelling")]
    public Levelling levelling { get; set; }

    [JsonPropertyName("egghunt")]
    public Egghunt egghunt { get; set; }

    [JsonPropertyName("bingo")]
    public Bingo bingo { get; set; }

    [JsonPropertyName("bedWarsWinsAchievement")]
    public float bedWarsWinsAchievement { get; set; }
}

public class _22023
{
    [JsonPropertyName("REGULAR")]
    public bool REGULAR { get; set; }

    [JsonPropertyName("VIP")]
    public bool VIP { get; set; }

    [JsonPropertyName("VIP_PLUS")]
    public bool VIP_PLUS { get; set; }

    [JsonPropertyName("MVP")]
    public bool MVP { get; set; }

    [JsonPropertyName("MVP_PLUS")]
    public bool MVP_PLUS { get; set; }
}

public class _22024
{
    [JsonPropertyName("MVP_PLUS")]
    public bool MVP_PLUS { get; set; }

    [JsonPropertyName("MVP")]
    public bool MVP { get; set; }

    [JsonPropertyName("VIP_PLUS")]
    public bool VIP_PLUS { get; set; }

    [JsonPropertyName("VIP")]
    public bool VIP { get; set; }

    [JsonPropertyName("NORMAL")]
    public bool NORMAL { get; set; }
}

public class _32021
{
    [JsonPropertyName("REGULAR")]
    public bool REGULAR { get; set; }
}

public class _32024
{
    [JsonPropertyName("NORMAL")]
    public bool NORMAL { get; set; }

    [JsonPropertyName("VIP")]
    public bool VIP { get; set; }

    [JsonPropertyName("VIP_PLUS")]
    public bool VIP_PLUS { get; set; }

    [JsonPropertyName("MVP")]
    public bool MVP { get; set; }

    [JsonPropertyName("MVP_PLUS")]
    public bool MVP_PLUS { get; set; }
}

public class _42021
{
    [JsonPropertyName("REGULAR")]
    public bool REGULAR { get; set; }

    [JsonPropertyName("VIP")]
    public bool VIP { get; set; }

    [JsonPropertyName("VIP_PLUS")]
    public bool VIP_PLUS { get; set; }
}


public class _72022
{
    [JsonPropertyName("MVP_PLUS")]
    public bool MVP_PLUS { get; set; }

    [JsonPropertyName("MVP")]
    public bool MVP { get; set; }

    [JsonPropertyName("VIP_PLUS")]
    public bool VIP_PLUS { get; set; }

    [JsonPropertyName("VIP")]
    public bool VIP { get; set; }

    [JsonPropertyName("REGULAR")]
    public bool REGULAR { get; set; }
}

public class AchievementRewardsNew
{
    [JsonPropertyName("for_points_1300")]
    public long for_points_1300 { get; set; }

    [JsonPropertyName("for_points_1200")]
    public long for_points_1200 { get; set; }

    [JsonPropertyName("for_points_900")]
    public long for_points_900 { get; set; }

    [JsonPropertyName("for_points_600")]
    public long for_points_600 { get; set; }

    [JsonPropertyName("for_points_300")]
    public long for_points_300 { get; set; }

    [JsonPropertyName("for_points_500")]
    public long for_points_500 { get; set; }

    [JsonPropertyName("for_points_200")]
    public long for_points_200 { get; set; }

    [JsonPropertyName("for_points_400")]
    public long for_points_400 { get; set; }

    [JsonPropertyName("for_points_700")]
    public long for_points_700 { get; set; }

    [JsonPropertyName("for_points_800")]
    public long for_points_800 { get; set; }

    [JsonPropertyName("for_points_1000")]
    public long for_points_1000 { get; set; }

    [JsonPropertyName("for_points_1100")]
    public long for_points_1100 { get; set; }

    [JsonPropertyName("for_points_1400")]
    public long for_points_1400 { get; set; }

    [JsonPropertyName("for_points_1500")]
    public long for_points_1500 { get; set; }

    [JsonPropertyName("for_points_1600")]
    public long for_points_1600 { get; set; }

    [JsonPropertyName("for_points_1700")]
    public long for_points_1700 { get; set; }

    [JsonPropertyName("for_points_1800")]
    public long for_points_1800 { get; set; }

    [JsonPropertyName("for_points_1900")]
    public long for_points_1900 { get; set; }

    [JsonPropertyName("for_points_2000")]
    public long for_points_2000 { get; set; }

    [JsonPropertyName("for_points_2100")]
    public long for_points_2100 { get; set; }

    [JsonPropertyName("for_points_2300")]
    public long for_points_2300 { get; set; }

    [JsonPropertyName("for_points_2200")]
    public long for_points_2200 { get; set; }

    [JsonPropertyName("for_points_2400")]
    public long for_points_2400 { get; set; }

    [JsonPropertyName("for_points_2500")]
    public long for_points_2500 { get; set; }

    [JsonPropertyName("for_points_2600")]
    public long for_points_2600 { get; set; }

    [JsonPropertyName("for_points_2700")]
    public long for_points_2700 { get; set; }

    [JsonPropertyName("for_points_2800")]
    public long for_points_2800 { get; set; }

    [JsonPropertyName("for_points_2900")]
    public long for_points_2900 { get; set; }

    [JsonPropertyName("for_points_3000")]
    public long for_points_3000 { get; set; }

    [JsonPropertyName("for_points_3100")]
    public long for_points_3100 { get; set; }

    [JsonPropertyName("for_points_3200")]
    public long for_points_3200 { get; set; }

    [JsonPropertyName("for_points_3300")]
    public long for_points_3300 { get; set; }

    [JsonPropertyName("for_points_3400")]
    public long for_points_3400 { get; set; }

    [JsonPropertyName("for_points_3500")]
    public long for_points_3500 { get; set; }

    [JsonPropertyName("for_points_3600")]
    public long for_points_3600 { get; set; }

    [JsonPropertyName("for_points_3700")]
    public long for_points_3700 { get; set; }

    [JsonPropertyName("for_points_3800")]
    public long for_points_3800 { get; set; }

    [JsonPropertyName("for_points_3900")]
    public long for_points_3900 { get; set; }

    [JsonPropertyName("for_points_4000")]
    public long for_points_4000 { get; set; }
}

public class Achievements
{
    [JsonPropertyName("bedwars_level")]
    public float bedwars_level { get; set; }

    [JsonPropertyName("bedwars_loot_box")]
    public float bedwars_loot_box { get; set; }

    [JsonPropertyName("buildbattle_build_battle_voter")]
    public float buildbattle_build_battle_voter { get; set; }

    [JsonPropertyName("buildbattle_build_battle_points")]
    public float buildbattle_build_battle_points { get; set; }

    [JsonPropertyName("buildbattle_build_battle_score")]
    public float buildbattle_build_battle_score { get; set; }

    [JsonPropertyName("murdermystery_hoarder")]
    public float murdermystery_hoarder { get; set; }

    [JsonPropertyName("general_wins")]
    public float general_wins { get; set; }

    [JsonPropertyName("murdermystery_wins_as_survivor")]
    public float murdermystery_wins_as_survivor { get; set; }

    [JsonPropertyName("general_challenger")]
    public float general_challenger { get; set; }

    [JsonPropertyName("supersmash_hero_slayer")]
    public float supersmash_hero_slayer { get; set; }

    [JsonPropertyName("general_coins")]
    public float general_coins { get; set; }

    [JsonPropertyName("arcade_arcade_banker")]
    public float arcade_arcade_banker { get; set; }

    [JsonPropertyName("skywars_cages")]
    public float skywars_cages { get; set; }

    [JsonPropertyName("blitz_looter")]
    public float blitz_looter { get; set; }

    [JsonPropertyName("blitz_coins")]
    public float blitz_coins { get; set; }

    [JsonPropertyName("blitz_kills")]
    public float blitz_kills { get; set; }

    [JsonPropertyName("blitz_kit_expert")]
    public float blitz_kit_expert { get; set; }

    [JsonPropertyName("bedwars_bedwars_killer")]
    public float bedwars_bedwars_killer { get; set; }

    [JsonPropertyName("bedwars_beds")]
    public float bedwars_beds { get; set; }

    [JsonPropertyName("duels_duels_winner")]
    public float duels_duels_winner { get; set; }

    [JsonPropertyName("duels_duels_traveller")]
    public float duels_duels_traveller { get; set; }

    [JsonPropertyName("duels_duels_win_streak")]
    public float duels_duels_win_streak { get; set; }

    [JsonPropertyName("skywars_wins_lab")]
    public float skywars_wins_lab { get; set; }

    [JsonPropertyName("skywars_kits_team")]
    public float skywars_kits_team { get; set; }

    [JsonPropertyName("christmas2017_santa_says_rounds")]
    public float christmas2017_santa_says_rounds { get; set; }

    [JsonPropertyName("murdermystery_kills_as_murderer")]
    public float murdermystery_kills_as_murderer { get; set; }

    [JsonPropertyName("skywars_kits_solo")]
    public float skywars_kits_solo { get; set; }

    [JsonPropertyName("arcade_miniwalls_winner")]
    public float arcade_miniwalls_winner { get; set; }

    [JsonPropertyName("skywars_kills_solo")]
    public float skywars_kills_solo { get; set; }

    [JsonPropertyName("skyclash_cards_unlocked")]
    public float skyclash_cards_unlocked { get; set; }

    [JsonPropertyName("arcade_zombies_round_progression")]
    public float arcade_zombies_round_progression { get; set; }

    [JsonPropertyName("walls3_jack_of_all_trades")]
    public float walls3_jack_of_all_trades { get; set; }

    [JsonPropertyName("tntgames_tnt_banker")]
    public float tntgames_tnt_banker { get; set; }

    [JsonPropertyName("tntgames_tnt_triathlon")]
    public float tntgames_tnt_triathlon { get; set; }

    [JsonPropertyName("tntgames_clinic")]
    public float tntgames_clinic { get; set; }

    [JsonPropertyName("skywars_kills_team")]
    public float skywars_kills_team { get; set; }

    [JsonPropertyName("blitz_kit_experience_collector")]
    public float blitz_kit_experience_collector { get; set; }

    [JsonPropertyName("skyblock_treasury")]
    public float skyblock_treasury { get; set; }

    [JsonPropertyName("skyblock_combat")]
    public float skyblock_combat { get; set; }

    [JsonPropertyName("skyblock_excavator")]
    public float skyblock_excavator { get; set; }

    [JsonPropertyName("skyblock_gatherer")]
    public float skyblock_gatherer { get; set; }

    [JsonPropertyName("skyblock_harvester")]
    public float skyblock_harvester { get; set; }

    [JsonPropertyName("skyblock_minion_lover")]
    public float skyblock_minion_lover { get; set; }

    [JsonPropertyName("skyblock_augmentation")]
    public float skyblock_augmentation { get; set; }

    [JsonPropertyName("skyblock_angler")]
    public float skyblock_angler { get; set; }

    [JsonPropertyName("arcade_zombies_nice_shot")]
    public float arcade_zombies_nice_shot { get; set; }

    [JsonPropertyName("skyblock_concoctor")]
    public float skyblock_concoctor { get; set; }

    [JsonPropertyName("christmas2017_no_christmas")]
    public float christmas2017_no_christmas { get; set; }

    [JsonPropertyName("uhc_bounty")]
    public float uhc_bounty { get; set; }

    [JsonPropertyName("bedwars_wins")]
    public float bedwars_wins { get; set; }

    [JsonPropertyName("arcade_zombies_high_round")]
    public float arcade_zombies_high_round { get; set; }

    [JsonPropertyName("general_quest_master")]
    public float general_quest_master { get; set; }

    [JsonPropertyName("arena_climb_the_ranks")]
    public float arena_climb_the_ranks { get; set; }

    [JsonPropertyName("paintball_coins")]
    public float paintball_coins { get; set; }

    [JsonPropertyName("paintball_kills")]
    public float paintball_kills { get; set; }

    [JsonPropertyName("paintball_wins")]
    public float paintball_wins { get; set; }

    [JsonPropertyName("murdermystery_wins_as_murderer")]
    public float murdermystery_wins_as_murderer { get; set; }

    [JsonPropertyName("easter_throw_eggs")]
    public float easter_throw_eggs { get; set; }

    [JsonPropertyName("easter_egg_finder")]
    public float easter_egg_finder { get; set; }

    [JsonPropertyName("tntgames_block_runner")]
    public float tntgames_block_runner { get; set; }

    [JsonPropertyName("pit_contracts")]
    public float pit_contracts { get; set; }

    [JsonPropertyName("pit_gold")]
    public float pit_gold { get; set; }

    [JsonPropertyName("pit_kills")]
    public float pit_kills { get; set; }

    [JsonPropertyName("pit_events")]
    public float pit_events { get; set; }

    [JsonPropertyName("skyblock_domesticator")]
    public float skyblock_domesticator { get; set; }

    [JsonPropertyName("skywars_you_re_a_star")]
    public float skywars_you_re_a_star { get; set; }

    [JsonPropertyName("christmas2017_present_collector")]
    public float christmas2017_present_collector { get; set; }

    [JsonPropertyName("tntgames_pvp_run_killer")]
    public float tntgames_pvp_run_killer { get; set; }

    [JsonPropertyName("skyblock_dungeoneer")]
    public float skyblock_dungeoneer { get; set; }

    [JsonPropertyName("skyblock_unique_gifts")]
    public float skyblock_unique_gifts { get; set; }

    [JsonPropertyName("skyblock_treasure_hunter")]
    public float skyblock_treasure_hunter { get; set; }

    [JsonPropertyName("skyblock_slayer")]
    public float skyblock_slayer { get; set; }

    [JsonPropertyName("bedwars_collectors_edition")]
    public float bedwars_collectors_edition { get; set; }

    [JsonPropertyName("skywars_heads")]
    public float skywars_heads { get; set; }

    [JsonPropertyName("arcade_ctw_oh_sheep")]
    public float arcade_ctw_oh_sheep { get; set; }

    [JsonPropertyName("arcade_ctw_slayer")]
    public float arcade_ctw_slayer { get; set; }

    [JsonPropertyName("warlords_assist")]
    public float warlords_assist { get; set; }

    [JsonPropertyName("warlords_coins")]
    public float warlords_coins { get; set; }

    [JsonPropertyName("skyblock_goblin_killer")]
    public float skyblock_goblin_killer { get; set; }

    [JsonPropertyName("skyblock_hard_working_miner")]
    public float skyblock_hard_working_miner { get; set; }

    [JsonPropertyName("arcade_arcade_winner")]
    public float arcade_arcade_winner { get; set; }

    [JsonPropertyName("skyblock_divans_treasures")]
    public float skyblock_divans_treasures { get; set; }

    [JsonPropertyName("skyblock_crystal_nucleus")]
    public float skyblock_crystal_nucleus { get; set; }

    [JsonPropertyName("gingerbread_banker")]
    public float gingerbread_banker { get; set; }

    [JsonPropertyName("copsandcrims_cac_banker")]
    public float copsandcrims_cac_banker { get; set; }

    [JsonPropertyName("copsandcrims_headshot_kills")]
    public float copsandcrims_headshot_kills { get; set; }

    [JsonPropertyName("copsandcrims_serial_killer")]
    public float copsandcrims_serial_killer { get; set; }

    [JsonPropertyName("arcade_party_super_star")]
    public float arcade_party_super_star { get; set; }

    [JsonPropertyName("buildbattle_guess_the_build_guesses")]
    public float buildbattle_guess_the_build_guesses { get; set; }

    [JsonPropertyName("murdermystery_countermeasures")]
    public float murdermystery_countermeasures { get; set; }

    [JsonPropertyName("murdermystery_survival_skills")]
    public float murdermystery_survival_skills { get; set; }

    [JsonPropertyName("summer_shopaholic")]
    public float summer_shopaholic { get; set; }

    [JsonPropertyName("arcade_ender_spleef_powerups")]
    public float arcade_ender_spleef_powerups { get; set; }

    [JsonPropertyName("arcade_ender_spleef_block_stealer")]
    public float arcade_ender_spleef_block_stealer { get; set; }

    [JsonPropertyName("arcade_zombie_killer")]
    public float arcade_zombie_killer { get; set; }

    [JsonPropertyName("arcade_galaxy_wars_kills")]
    public float arcade_galaxy_wars_kills { get; set; }

    [JsonPropertyName("arcade_team_work")]
    public float arcade_team_work { get; set; }

    [JsonPropertyName("arcade_bounty_hunter")]
    public float arcade_bounty_hunter { get; set; }

    [JsonPropertyName("walls3_cake_hunter_tiered")]
    public float walls3_cake_hunter_tiered { get; set; }

    [JsonPropertyName("walls3_coins")]
    public float walls3_coins { get; set; }

    [JsonPropertyName("tntgames_tnt_wizards_caps")]
    public float tntgames_tnt_wizards_caps { get; set; }

    [JsonPropertyName("tntgames_tnt_wizards_kills")]
    public float tntgames_tnt_wizards_kills { get; set; }

    [JsonPropertyName("tntgames_wizards_wins")]
    public float tntgames_wizards_wins { get; set; }

    [JsonPropertyName("vampirez_coins")]
    public float vampirez_coins { get; set; }

    [JsonPropertyName("vampirez_zombie_killer")]
    public float vampirez_zombie_killer { get; set; }

    [JsonPropertyName("vampirez_kill_vampires")]
    public float vampirez_kill_vampires { get; set; }

    [JsonPropertyName("arcade_dw_slayer")]
    public float arcade_dw_slayer { get; set; }

    [JsonPropertyName("arcade_dw_dragonborn")]
    public float arcade_dw_dragonborn { get; set; }

    [JsonPropertyName("woolgames_wool_contest")]
    public float woolgames_wool_contest { get; set; }

    [JsonPropertyName("woolgames_wool_kills")]
    public float woolgames_wool_kills { get; set; }

    [JsonPropertyName("woolgames_wool_wins")]
    public float woolgames_wool_wins { get; set; }

    [JsonPropertyName("skyblock_curator")]
    public float skyblock_curator { get; set; }

    [JsonPropertyName("skyblock_sb_levels")]
    public float skyblock_sb_levels { get; set; }

    [JsonPropertyName("skyblock_people_pleaser")]
    public float skyblock_people_pleaser { get; set; }

    [JsonPropertyName("arcade_dropper_skydiver")]
    public float arcade_dropper_skydiver { get; set; }

    [JsonPropertyName("skywars_wins_solo")]
    public float skywars_wins_solo { get; set; }

    [JsonPropertyName("skywars_opal_obsession")]
    public float skywars_opal_obsession { get; set; }

    [JsonPropertyName("christmas2017_advent_2023")]
    public float christmas2017_advent_2023 { get; set; }

    [JsonPropertyName("bedwars_slumber_ticket_master")]
    public float bedwars_slumber_ticket_master { get; set; }

    [JsonPropertyName("arcade_hitw_practice_makes_perfect")]
    public float arcade_hitw_practice_makes_perfect { get; set; }

    [JsonPropertyName("duels_goals")]
    public float duels_goals { get; set; }

    [JsonPropertyName("duels_bridge_doubles_wins")]
    public float duels_bridge_doubles_wins { get; set; }

    [JsonPropertyName("duels_bridge_win_streak")]
    public float duels_bridge_win_streak { get; set; }

    [JsonPropertyName("duels_bridge_wins")]
    public float duels_bridge_wins { get; set; }

    [JsonPropertyName("duels_unique_map_wins")]
    public float duels_unique_map_wins { get; set; }
}

public class AchievementSync
{
    [JsonPropertyName("quake_tiered")]
    public float quake_tiered { get; set; }
}

public class AchievementTotem
{
    [JsonPropertyName("canCustomize")]
    public bool canCustomize { get; set; }

    [JsonPropertyName("allowed_max_height")]
    public float allowed_max_height { get; set; }

    [JsonPropertyName("unlockedParts")]
    public List<string> unlockedParts { get; set; }

    [JsonPropertyName("selectedParts")]
    public SelectedParts selectedParts { get; set; }

    [JsonPropertyName("unlockedColors")]
    public List<string> unlockedColors { get; set; }

    [JsonPropertyName("selectedColors")]
    public SelectedColors selectedColors { get; set; }
}

public class Active
{
    [JsonPropertyName("objectives")]
    public Objectives objectives { get; set; }

    [JsonPropertyName("started")]
    public long started { get; set; }
}

public class AdventRewards
{
    [JsonPropertyName("day1")]
    public long day1 { get; set; }

    [JsonPropertyName("day2")]
    public long day2 { get; set; }

    [JsonPropertyName("day4")]
    public long day4 { get; set; }

    [JsonPropertyName("day5")]
    public long day5 { get; set; }

    [JsonPropertyName("day6")]
    public long day6 { get; set; }

    [JsonPropertyName("day7")]
    public long day7 { get; set; }

    [JsonPropertyName("day8")]
    public long day8 { get; set; }

    [JsonPropertyName("day10")]
    public long day10 { get; set; }

    [JsonPropertyName("day11")]
    public long day11 { get; set; }

    [JsonPropertyName("day13")]
    public long day13 { get; set; }

    [JsonPropertyName("day14")]
    public long day14 { get; set; }

    [JsonPropertyName("day20")]
    public long day20 { get; set; }

    [JsonPropertyName("day21")]
    public long day21 { get; set; }

    [JsonPropertyName("day23")]
    public long day23 { get; set; }
}

public class AllTime
{
    [JsonPropertyName("MURDER_MYSTERY__hero")]
    public float MURDER_MYSTERY__hero { get; set; }

    [JsonPropertyName("BEDWARS__support")]
    public float BEDWARS__support { get; set; }

    [JsonPropertyName("SKYWARS__rush_challenge")]
    public float SKYWARS__rush_challenge { get; set; }

    [JsonPropertyName("MURDER_MYSTERY__murder_spree")]
    public float MURDER_MYSTERY__murder_spree { get; set; }

    [JsonPropertyName("SKYWARS__feeding_the_void_challenge")]
    public float SKYWARS__feeding_the_void_challenge { get; set; }

    [JsonPropertyName("DUELS__feed_the_void_challenge")]
    public float DUELS__feed_the_void_challenge { get; set; }

    [JsonPropertyName("ARCADE__zombies_challenge")]
    public float ARCADE__zombies_challenge { get; set; }

    [JsonPropertyName("TNTGAMES__tnt_tag_challenge")]
    public float TNTGAMES__tnt_tag_challenge { get; set; }

    [JsonPropertyName("UHC__threat_challenge")]
    public float UHC__threat_challenge { get; set; }

    [JsonPropertyName("WALLS__looting_challenge")]
    public float WALLS__looting_challenge { get; set; }

    [JsonPropertyName("ARCADE__ender_spleef_challenge")]
    public float ARCADE__ender_spleef_challenge { get; set; }

    [JsonPropertyName("ARCADE__blocking_dead_challenge")]
    public float ARCADE__blocking_dead_challenge { get; set; }

    [JsonPropertyName("ARCADE__galaxy_wars_challenge")]
    public float ARCADE__galaxy_wars_challenge { get; set; }

    [JsonPropertyName("DUELS__target_practice_challenge")]
    public float DUELS__target_practice_challenge { get; set; }

    [JsonPropertyName("ARCADE__creeper_attack_challenge")]
    public float ARCADE__creeper_attack_challenge { get; set; }

    [JsonPropertyName("ARCADE__party_games_challenge")]
    public float ARCADE__party_games_challenge { get; set; }

    [JsonPropertyName("WOOL_GAMES__flawless_challenge")]
    public float WOOL_GAMES__flawless_challenge { get; set; }

    [JsonPropertyName("BEDWARS__offensive")]
    public float BEDWARS__offensive { get; set; }

    [JsonPropertyName("DUELS__teams_challenge")]
    public float DUELS__teams_challenge { get; set; }
}

public class Arcade
{
    [JsonPropertyName("monthly_coins_b")]
    public float monthly_coins_b { get; set; }

    [JsonPropertyName("weekly_coins_a")]
    public float weekly_coins_a { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("showinfobook")]
    public bool showinfobook { get; set; }

    [JsonPropertyName("monthly_coins_a")]
    public float monthly_coins_a { get; set; }

    [JsonPropertyName("stamp_level")]
    public float stamp_level { get; set; }

    [JsonPropertyName("time_stamp")]
    public long time_stamp { get; set; }

    [JsonPropertyName("rounds_simon_says")]
    public float rounds_simon_says { get; set; }

    [JsonPropertyName("miniwalls_activeKit")]
    public string miniwalls_activeKit { get; set; }

    [JsonPropertyName("kills_mini_walls")]
    public float kills_mini_walls { get; set; }

    [JsonPropertyName("wins_mini_walls")]
    public float wins_mini_walls { get; set; }

    [JsonPropertyName("deaths_mini_walls")]
    public float deaths_mini_walls { get; set; }

    [JsonPropertyName("arrows_shot_mini_walls")]
    public float arrows_shot_mini_walls { get; set; }

    [JsonPropertyName("best_round_zombies_deadend_normal")]
    public float best_round_zombies_deadend_normal { get; set; }

    [JsonPropertyName("best_round_zombies_deadend")]
    public float best_round_zombies_deadend { get; set; }

    [JsonPropertyName("best_round_zombies")]
    public float best_round_zombies { get; set; }

    [JsonPropertyName("zombie_kills_zombies_deadend")]
    public float zombie_kills_zombies_deadend { get; set; }

    [JsonPropertyName("headshots_zombies")]
    public float headshots_zombies { get; set; }

    [JsonPropertyName("total_rounds_survived_zombies_deadend")]
    public float total_rounds_survived_zombies_deadend { get; set; }

    [JsonPropertyName("deaths_zombies")]
    public float deaths_zombies { get; set; }

    [JsonPropertyName("times_knocked_down_zombies")]
    public float times_knocked_down_zombies { get; set; }

    [JsonPropertyName("total_rounds_survived_zombies_deadend_normal")]
    public float total_rounds_survived_zombies_deadend_normal { get; set; }

    [JsonPropertyName("total_rounds_survived_zombies")]
    public float total_rounds_survived_zombies { get; set; }

    [JsonPropertyName("windows_repaired_zombies")]
    public float windows_repaired_zombies { get; set; }

    [JsonPropertyName("zombie_kills_zombies")]
    public float zombie_kills_zombies { get; set; }

    [JsonPropertyName("zombie_kills_zombies_deadend_normal")]
    public float zombie_kills_zombies_deadend_normal { get; set; }

    [JsonPropertyName("wolf_zombie_kills_zombies")]
    public float wolf_zombie_kills_zombies { get; set; }

    [JsonPropertyName("pig_zombie_zombie_kills_zombies")]
    public float pig_zombie_zombie_kills_zombies { get; set; }

    [JsonPropertyName("deaths_zombies_deadend")]
    public float deaths_zombies_deadend { get; set; }

    [JsonPropertyName("windows_repaired_zombies_deadend_normal")]
    public float windows_repaired_zombies_deadend_normal { get; set; }

    [JsonPropertyName("times_knocked_down_zombies_deadend_normal")]
    public float times_knocked_down_zombies_deadend_normal { get; set; }

    [JsonPropertyName("deaths_zombies_deadend_normal")]
    public float deaths_zombies_deadend_normal { get; set; }

    [JsonPropertyName("bullets_shot_zombies")]
    public float bullets_shot_zombies { get; set; }

    [JsonPropertyName("basic_zombie_kills_zombies")]
    public float basic_zombie_kills_zombies { get; set; }

    [JsonPropertyName("times_knocked_down_zombies_deadend")]
    public float times_knocked_down_zombies_deadend { get; set; }

    [JsonPropertyName("windows_repaired_zombies_deadend")]
    public float windows_repaired_zombies_deadend { get; set; }

    [JsonPropertyName("tnt_baby_zombie_kills_zombies")]
    public float tnt_baby_zombie_kills_zombies { get; set; }

    [JsonPropertyName("bullets_hit_zombies")]
    public float bullets_hit_zombies { get; set; }

    [JsonPropertyName("weekly_coins_b")]
    public float weekly_coins_b { get; set; }

    [JsonPropertyName("wither_damage_mini_walls")]
    public float wither_damage_mini_walls { get; set; }

    [JsonPropertyName("fastest_time_10_zombies_deadend_normal")]
    public float fastest_time_10_zombies_deadend_normal { get; set; }

    [JsonPropertyName("fastest_time_10_zombies")]
    public float fastest_time_10_zombies { get; set; }

    [JsonPropertyName("fire_zombie_kills_zombies")]
    public float fire_zombie_kills_zombies { get; set; }

    [JsonPropertyName("empowered_zombie_kills_zombies")]
    public float empowered_zombie_kills_zombies { get; set; }

    [JsonPropertyName("best_round_zombies_alienarcadium")]
    public float best_round_zombies_alienarcadium { get; set; }

    [JsonPropertyName("best_round_zombies_alienarcadium_normal")]
    public float best_round_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("deaths_zombies_alienarcadium")]
    public float deaths_zombies_alienarcadium { get; set; }

    [JsonPropertyName("deaths_zombies_alienarcadium_normal")]
    public float deaths_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("doors_opened_zombies")]
    public float doors_opened_zombies { get; set; }

    [JsonPropertyName("doors_opened_zombies_alienarcadium")]
    public float doors_opened_zombies_alienarcadium { get; set; }

    [JsonPropertyName("doors_opened_zombies_alienarcadium_normal")]
    public float doors_opened_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("rainbow_zombie_kills_zombies")]
    public float rainbow_zombie_kills_zombies { get; set; }

    [JsonPropertyName("skeleton_zombie_kills_zombies")]
    public float skeleton_zombie_kills_zombies { get; set; }

    [JsonPropertyName("space_blaster_zombie_kills_zombies")]
    public float space_blaster_zombie_kills_zombies { get; set; }

    [JsonPropertyName("space_grunt_zombie_kills_zombies")]
    public float space_grunt_zombie_kills_zombies { get; set; }

    [JsonPropertyName("times_knocked_down_zombies_alienarcadium")]
    public float times_knocked_down_zombies_alienarcadium { get; set; }

    [JsonPropertyName("times_knocked_down_zombies_alienarcadium_normal")]
    public float times_knocked_down_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("total_rounds_survived_zombies_alienarcadium")]
    public float total_rounds_survived_zombies_alienarcadium { get; set; }

    [JsonPropertyName("total_rounds_survived_zombies_alienarcadium_normal")]
    public float total_rounds_survived_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("windows_repaired_zombies_alienarcadium")]
    public float windows_repaired_zombies_alienarcadium { get; set; }

    [JsonPropertyName("windows_repaired_zombies_alienarcadium_normal")]
    public float windows_repaired_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("worm_small_zombie_kills_zombies")]
    public float worm_small_zombie_kills_zombies { get; set; }

    [JsonPropertyName("worm_zombie_kills_zombies")]
    public float worm_zombie_kills_zombies { get; set; }

    [JsonPropertyName("zombie_kills_zombies_alienarcadium")]
    public float zombie_kills_zombies_alienarcadium { get; set; }

    [JsonPropertyName("zombie_kills_zombies_alienarcadium_normal")]
    public float zombie_kills_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("doors_opened_zombies_deadend")]
    public float doors_opened_zombies_deadend { get; set; }

    [JsonPropertyName("doors_opened_zombies_deadend_normal")]
    public float doors_opened_zombies_deadend_normal { get; set; }

    [JsonPropertyName("eggs_found_easter_simulator")]
    public float eggs_found_easter_simulator { get; set; }

    [JsonPropertyName("magma_cube_zombie_kills_zombies")]
    public float magma_cube_zombie_kills_zombies { get; set; }

    [JsonPropertyName("magma_zombie_kills_zombies")]
    public float magma_zombie_kills_zombies { get; set; }

    [JsonPropertyName("tnt_zombie_kills_zombies")]
    public float tnt_zombie_kills_zombies { get; set; }

    [JsonPropertyName("players_revived_zombies")]
    public float players_revived_zombies { get; set; }

    [JsonPropertyName("players_revived_zombies_deadend")]
    public float players_revived_zombies_deadend { get; set; }

    [JsonPropertyName("players_revived_zombies_deadend_normal")]
    public float players_revived_zombies_deadend_normal { get; set; }

    [JsonPropertyName("lastTourneyAd")]
    public long lastTourneyAd { get; set; }

    [JsonPropertyName("best_round_zombies_deadend_rip")]
    public float best_round_zombies_deadend_rip { get; set; }

    [JsonPropertyName("deaths_zombies_deadend_rip")]
    public float deaths_zombies_deadend_rip { get; set; }

    [JsonPropertyName("players_revived_zombies_deadend_rip")]
    public float players_revived_zombies_deadend_rip { get; set; }

    [JsonPropertyName("times_knocked_down_zombies_deadend_rip")]
    public float times_knocked_down_zombies_deadend_rip { get; set; }

    [JsonPropertyName("total_rounds_survived_zombies_deadend_rip")]
    public float total_rounds_survived_zombies_deadend_rip { get; set; }

    [JsonPropertyName("zombie_kills_zombies_deadend_rip")]
    public float zombie_kills_zombies_deadend_rip { get; set; }

    [JsonPropertyName("blaze_zombie_kills_zombies")]
    public float blaze_zombie_kills_zombies { get; set; }

    [JsonPropertyName("animal_slaughter_best_score_party")]
    public float animal_slaughter_best_score_party { get; set; }

    [JsonPropertyName("animal_slaughter_kills_party")]
    public float animal_slaughter_kills_party { get; set; }

    [JsonPropertyName("hoe_hoe_hoe_best_score_party")]
    public float hoe_hoe_hoe_best_score_party { get; set; }

    [JsonPropertyName("hoe_hoe_hoe_total_score_party")]
    public float hoe_hoe_hoe_total_score_party { get; set; }

    [JsonPropertyName("jungle_jump_best_time_party")]
    public float jungle_jump_best_time_party { get; set; }

    [JsonPropertyName("total_stars_party")]
    public float total_stars_party { get; set; }

    [JsonPropertyName("bombardment_best_time_party")]
    public float bombardment_best_time_party { get; set; }

    [JsonPropertyName("dive_best_score_party")]
    public float dive_best_score_party { get; set; }

    [JsonPropertyName("dive_total_score_party")]
    public float dive_total_score_party { get; set; }

    [JsonPropertyName("jigsaw_rush_best_time_party")]
    public float jigsaw_rush_best_time_party { get; set; }

    [JsonPropertyName("lawn_moower_mowed_best_score_party")]
    public float lawn_moower_mowed_best_score_party { get; set; }

    [JsonPropertyName("lawn_moower_mowed_total_score_party")]
    public float lawn_moower_mowed_total_score_party { get; set; }

    [JsonPropertyName("anvil_spleef_best_time_party")]
    public float anvil_spleef_best_time_party { get; set; }

    [JsonPropertyName("anvil_spleef_round_wins_party")]
    public float anvil_spleef_round_wins_party { get; set; }

    [JsonPropertyName("round_wins_party")]
    public float round_wins_party { get; set; }

    [JsonPropertyName("rpg_16_kills_best_score_party")]
    public float rpg_16_kills_best_score_party { get; set; }

    [JsonPropertyName("rpg_16_kills_party")]
    public float rpg_16_kills_party { get; set; }

    [JsonPropertyName("chicken_rings_best_time_party")]
    public float chicken_rings_best_time_party { get; set; }

    [JsonPropertyName("chicken_rings_round_wins_party")]
    public float chicken_rings_round_wins_party { get; set; }

    [JsonPropertyName("hoe_hoe_hoe_round_wins_party")]
    public float hoe_hoe_hoe_round_wins_party { get; set; }

    [JsonPropertyName("spider_maze_best_time_party")]
    public float spider_maze_best_time_party { get; set; }

    [JsonPropertyName("wins_ender")]
    public float wins_ender { get; set; }

    [JsonPropertyName("bigshot_powerup_activations_ender")]
    public float bigshot_powerup_activations_ender { get; set; }

    [JsonPropertyName("blocks_destroyed_ender")]
    public float blocks_destroyed_ender { get; set; }

    [JsonPropertyName("powerup_activations_ender")]
    public float powerup_activations_ender { get; set; }

    [JsonPropertyName("tripleshot_powerup_activations_ender")]
    public float tripleshot_powerup_activations_ender { get; set; }

    [JsonPropertyName("hider_wins_hide_and_seek")]
    public float hider_wins_hide_and_seek { get; set; }

    [JsonPropertyName("prop_hunt_hider_wins_hide_and_seek")]
    public float prop_hunt_hider_wins_hide_and_seek { get; set; }

    [JsonPropertyName("headshots_dayone")]
    public float headshots_dayone { get; set; }

    [JsonPropertyName("kills_dayone")]
    public float kills_dayone { get; set; }

    [JsonPropertyName("wins_dayone")]
    public float wins_dayone { get; set; }

    [JsonPropertyName("sw_deaths")]
    public float sw_deaths { get; set; }

    [JsonPropertyName("sw_kills")]
    public float sw_kills { get; set; }

    [JsonPropertyName("sw_rebel_kills")]
    public float sw_rebel_kills { get; set; }

    [JsonPropertyName("sw_shots_fired")]
    public float sw_shots_fired { get; set; }

    [JsonPropertyName("max_wave")]
    public float max_wave { get; set; }

    [JsonPropertyName("jungle_jump_round_wins_party")]
    public float jungle_jump_round_wins_party { get; set; }

    [JsonPropertyName("bounty_kills_oneinthequiver")]
    public float bounty_kills_oneinthequiver { get; set; }

    [JsonPropertyName("bow_kills_oneinthequiver")]
    public float bow_kills_oneinthequiver { get; set; }

    [JsonPropertyName("deaths_oneinthequiver")]
    public float deaths_oneinthequiver { get; set; }

    [JsonPropertyName("kills_oneinthequiver")]
    public float kills_oneinthequiver { get; set; }

    [JsonPropertyName("sword_kills_oneinthequiver")]
    public float sword_kills_oneinthequiver { get; set; }

    [JsonPropertyName("wins_oneinthequiver")]
    public float wins_oneinthequiver { get; set; }

    [JsonPropertyName("persistArcadeResourcePack")]
    public string persistArcadeResourcePack { get; set; }

    [JsonPropertyName("round_wins_simon_says")]
    public float round_wins_simon_says { get; set; }

    [JsonPropertyName("top_score_simon_says")]
    public float top_score_simon_says { get; set; }

    [JsonPropertyName("arrows_hit_mini_walls")]
    public float arrows_hit_mini_walls { get; set; }

    [JsonPropertyName("kills_dragonwars2")]
    public float kills_dragonwars2 { get; set; }

    [JsonPropertyName("wins_dragonwars2")]
    public float wins_dragonwars2 { get; set; }

    [JsonPropertyName("blob_zombie_kills_zombies")]
    public float blob_zombie_kills_zombies { get; set; }

    [JsonPropertyName("chgluglu_zombie_kills_zombies")]
    public float chgluglu_zombie_kills_zombies { get; set; }

    [JsonPropertyName("clown_zombie_kills_zombies")]
    public float clown_zombie_kills_zombies { get; set; }

    [JsonPropertyName("fastest_time_10_zombies_alienarcadium_normal")]
    public float fastest_time_10_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("fastest_time_20_zombies")]
    public float fastest_time_20_zombies { get; set; }

    [JsonPropertyName("fastest_time_20_zombies_alienarcadium_normal")]
    public float fastest_time_20_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("ghast_zombie_kills_zombies")]
    public float ghast_zombie_kills_zombies { get; set; }

    [JsonPropertyName("giant_zombie_kills_zombies")]
    public float giant_zombie_kills_zombies { get; set; }

    [JsonPropertyName("iron_golem_zombie_kills_zombies")]
    public float iron_golem_zombie_kills_zombies { get; set; }

    [JsonPropertyName("mega_blob_zombie_kills_zombies")]
    public float mega_blob_zombie_kills_zombies { get; set; }

    [JsonPropertyName("mega_magma_zombie_kills_zombies")]
    public float mega_magma_zombie_kills_zombies { get; set; }

    [JsonPropertyName("players_revived_zombies_alienarcadium")]
    public float players_revived_zombies_alienarcadium { get; set; }

    [JsonPropertyName("players_revived_zombies_alienarcadium_normal")]
    public float players_revived_zombies_alienarcadium_normal { get; set; }

    [JsonPropertyName("sentinel_zombie_kills_zombies")]
    public float sentinel_zombie_kills_zombies { get; set; }

    [JsonPropertyName("option_show_tutorial_book")]
    public string option_show_tutorial_book { get; set; }

    [JsonPropertyName("woolhunt_assists")]
    public float woolhunt_assists { get; set; }

    [JsonPropertyName("woolhunt_deaths")]
    public float woolhunt_deaths { get; set; }

    [JsonPropertyName("woolhunt_deaths_to_woolholder")]
    public float woolhunt_deaths_to_woolholder { get; set; }

    [JsonPropertyName("woolhunt_deaths_with_wool")]
    public float woolhunt_deaths_with_wool { get; set; }

    [JsonPropertyName("woolhunt_experienced_losses")]
    public float woolhunt_experienced_losses { get; set; }

    [JsonPropertyName("woolhunt_experienced_wins")]
    public float woolhunt_experienced_wins { get; set; }

    [JsonPropertyName("woolhunt_fastest_win")]
    public float woolhunt_fastest_win { get; set; }

    [JsonPropertyName("woolhunt_gold_earned")]
    public float woolhunt_gold_earned { get; set; }

    [JsonPropertyName("woolhunt_gold_spent")]
    public float woolhunt_gold_spent { get; set; }

    [JsonPropertyName("woolhunt_kills")]
    public float woolhunt_kills { get; set; }

    [JsonPropertyName("woolhunt_kills_on_woolholder")]
    public float woolhunt_kills_on_woolholder { get; set; }

    [JsonPropertyName("woolhunt_kills_with_wool")]
    public float woolhunt_kills_with_wool { get; set; }

    [JsonPropertyName("woolhunt_longest_game")]
    public float woolhunt_longest_game { get; set; }

    [JsonPropertyName("woolhunt_most_gold_earned")]
    public float woolhunt_most_gold_earned { get; set; }

    [JsonPropertyName("woolhunt_most_kills_and_assists")]
    public float woolhunt_most_kills_and_assists { get; set; }

    [JsonPropertyName("woolhunt_participated_losses")]
    public float woolhunt_participated_losses { get; set; }

    [JsonPropertyName("woolhunt_participated_wins")]
    public float woolhunt_participated_wins { get; set; }

    [JsonPropertyName("woolhunt_wools_captured")]
    public float woolhunt_wools_captured { get; set; }

    [JsonPropertyName("woolhunt_wools_stolen")]
    public float woolhunt_wools_stolen { get; set; }

    [JsonPropertyName("dropper")]
    public Dropper dropper { get; set; }

    [JsonPropertyName("avalanche_round_wins_party")]
    public float avalanche_round_wins_party { get; set; }

    [JsonPropertyName("pig_fishing_round_wins_party")]
    public float pig_fishing_round_wins_party { get; set; }

    [JsonPropertyName("pig_jousting_round_wins_party")]
    public float pig_jousting_round_wins_party { get; set; }

    [JsonPropertyName("the_floor_is_lava_best_time_party")]
    public float the_floor_is_lava_best_time_party { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("fire_leapers_round_wins_party")]
    public float fire_leapers_round_wins_party { get; set; }

    [JsonPropertyName("minecart_racing_best_time_party")]
    public float minecart_racing_best_time_party { get; set; }

    [JsonPropertyName("minecart_racing_round_wins_party")]
    public float minecart_racing_round_wins_party { get; set; }

    [JsonPropertyName("wins_party")]
    public float wins_party { get; set; }

    [JsonPropertyName("hitw_record_q")]
    public float hitw_record_q { get; set; }

    [JsonPropertyName("rounds_hole_in_the_wall")]
    public float rounds_hole_in_the_wall { get; set; }

    [JsonPropertyName("active_victory_dance")]
    public string active_victory_dance { get; set; }
}

public class ArcadeGamer
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class ArcadeSpecialist
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class ArcadeWinner
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class Arena
{
    [JsonPropertyName("coins")]
    public float coins { get; set; }
}

public class Battleground
{
    [JsonPropertyName("paladin_spec")]
    public string paladin_spec { get; set; }

    [JsonPropertyName("shaman_spec")]
    public string shaman_spec { get; set; }

    [JsonPropertyName("chosen_class")]
    public string chosen_class { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("mage_spec")]
    public string mage_spec { get; set; }

    [JsonPropertyName("warrior_spec")]
    public string warrior_spec { get; set; }

    [JsonPropertyName("selected_mount")]
    public string selected_mount { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("play_streak")]
    public float play_streak { get; set; }

    [JsonPropertyName("assists")]
    public float assists { get; set; }

    [JsonPropertyName("damage")]
    public float damage { get; set; }

    [JsonPropertyName("damage_mage")]
    public float damage_mage { get; set; }

    [JsonPropertyName("damage_prevented")]
    public float damage_prevented { get; set; }

    [JsonPropertyName("damage_prevented_mage")]
    public float damage_prevented_mage { get; set; }

    [JsonPropertyName("damage_prevented_pyromancer")]
    public float damage_prevented_pyromancer { get; set; }

    [JsonPropertyName("damage_pyromancer")]
    public float damage_pyromancer { get; set; }

    [JsonPropertyName("damage_taken")]
    public float damage_taken { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("heal")]
    public float heal { get; set; }

    [JsonPropertyName("heal_mage")]
    public float heal_mage { get; set; }

    [JsonPropertyName("heal_pyromancer")]
    public float heal_pyromancer { get; set; }

    [JsonPropertyName("mage_plays")]
    public float mage_plays { get; set; }

    [JsonPropertyName("pyromancer_plays")]
    public float pyromancer_plays { get; set; }

    [JsonPropertyName("berserker_plays")]
    public float berserker_plays { get; set; }

    [JsonPropertyName("damage_berserker")]
    public float damage_berserker { get; set; }

    [JsonPropertyName("damage_prevented_berserker")]
    public float damage_prevented_berserker { get; set; }

    [JsonPropertyName("damage_prevented_warrior")]
    public float damage_prevented_warrior { get; set; }

    [JsonPropertyName("damage_warrior")]
    public float damage_warrior { get; set; }

    [JsonPropertyName("heal_berserker")]
    public float heal_berserker { get; set; }

    [JsonPropertyName("heal_warrior")]
    public float heal_warrior { get; set; }

    [JsonPropertyName("life_leeched")]
    public float life_leeched { get; set; }

    [JsonPropertyName("life_leeched_berserker")]
    public float life_leeched_berserker { get; set; }

    [JsonPropertyName("life_leeched_warrior")]
    public float life_leeched_warrior { get; set; }

    [JsonPropertyName("warrior_plays")]
    public float warrior_plays { get; set; }
}

public class Bedwar
{
    [JsonPropertyName("timeStart")]
    public long timeStart { get; set; }

    [JsonPropertyName("timeTook")]
    public float timeTook { get; set; }

    [JsonPropertyName("first_join_7")]
    public bool first_join_7 { get; set; }

    [JsonPropertyName("Experience")]
    public float Experience { get; set; }

    [JsonPropertyName("bedwars_boxes")]
    public float bedwars_boxes { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("Bedwars_openedCommons")]
    public float Bedwars_openedCommons { get; set; }

    [JsonPropertyName("Bedwars_openedChests")]
    public float Bedwars_openedChests { get; set; }

    [JsonPropertyName("chest_history_new")]
    public List<string> chest_history_new { get; set; }

    [JsonPropertyName("Bedwars_openedRares")]
    public float Bedwars_openedRares { get; set; }

    [JsonPropertyName("favorite_slots")]
    public string favorite_slots { get; set; }

    [JsonPropertyName("understands_resource_bank")]
    public bool understands_resource_bank { get; set; }

    [JsonPropertyName("castle_beds_lost_bedwars")]
    public float castle_beds_lost_bedwars { get; set; }

    [JsonPropertyName("castle_deaths_bedwars")]
    public float castle_deaths_bedwars { get; set; }

    [JsonPropertyName("castle__items_purchased_bedwars")]
    public float castle__items_purchased_bedwars { get; set; }

    [JsonPropertyName("castle_final_deaths_bedwars")]
    public float castle_final_deaths_bedwars { get; set; }

    [JsonPropertyName("castle_void_final_deaths_bedwars")]
    public float castle_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("castle_items_purchased_bedwars")]
    public float castle_items_purchased_bedwars { get; set; }

    [JsonPropertyName("castle_gold_resources_collected_bedwars")]
    public float castle_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("castle_resources_collected_bedwars")]
    public float castle_resources_collected_bedwars { get; set; }

    [JsonPropertyName("castle_entity_attack_deaths_bedwars")]
    public float castle_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("castle_emerald_resources_collected_bedwars")]
    public float castle_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("castle_losses_bedwars")]
    public float castle_losses_bedwars { get; set; }

    [JsonPropertyName("castle_void_deaths_bedwars")]
    public float castle_void_deaths_bedwars { get; set; }

    [JsonPropertyName("castle_iron_resources_collected_bedwars")]
    public float castle_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("castle_winstreak")]
    public float castle_winstreak { get; set; }

    [JsonPropertyName("games_played_bedwars_1")]
    public float games_played_bedwars_1 { get; set; }

    [JsonPropertyName("four_four_rush_winstreak")]
    public float four_four_rush_winstreak { get; set; }

    [JsonPropertyName("four_four_rush_gold_resources_collected_bedwars")]
    public float four_four_rush_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_resources_collected_bedwars")]
    public float four_four_rush_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_games_played_bedwars")]
    public float four_four_rush_games_played_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_deaths_bedwars")]
    public float four_four_rush_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_iron_resources_collected_bedwars")]
    public float four_four_rush_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_void_deaths_bedwars")]
    public float four_four_rush_void_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_items_purchased_bedwars")]
    public float four_four_rush_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_entity_attack_final_deaths_bedwars")]
    public float four_four_rush_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_emerald_resources_collected_bedwars")]
    public float four_four_rush_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_beds_lost_bedwars")]
    public float four_four_rush_beds_lost_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_diamond_resources_collected_bedwars")]
    public float four_four_rush_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_final_deaths_bedwars")]
    public float four_four_rush_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_rush__items_purchased_bedwars")]
    public float four_four_rush__items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_wins_bedwars")]
    public float four_four_rush_wins_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_losses_bedwars")]
    public float four_four_rush_losses_bedwars { get; set; }

    [JsonPropertyName("favourites_2")]
    public string favourites_2 { get; set; }

    [JsonPropertyName("four_four_rush_kills_bedwars")]
    public float four_four_rush_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_entity_attack_final_kills_bedwars")]
    public float four_four_rush_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_final_kills_bedwars")]
    public float four_four_rush_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_void_kills_bedwars")]
    public float four_four_rush_void_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_entity_attack_kills_bedwars")]
    public float four_four_rush_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("selected_ultimate")]
    public string selected_ultimate { get; set; }

    [JsonPropertyName("four_four_ultimate_winstreak")]
    public float four_four_ultimate_winstreak { get; set; }

    [JsonPropertyName("four_four_ultimate__items_purchased_bedwars")]
    public float four_four_ultimate__items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_entity_attack_kills_bedwars")]
    public float four_four_ultimate_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_resources_collected_bedwars")]
    public float four_four_ultimate_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_beds_lost_bedwars")]
    public float four_four_ultimate_beds_lost_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_items_purchased_bedwars")]
    public float four_four_ultimate_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_iron_resources_collected_bedwars")]
    public float four_four_ultimate_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_losses_bedwars")]
    public float four_four_ultimate_losses_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_gold_resources_collected_bedwars")]
    public float four_four_ultimate_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_games_played_bedwars")]
    public float four_four_ultimate_games_played_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_kills_bedwars")]
    public float four_four_ultimate_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_entity_attack_final_deaths_bedwars")]
    public float four_four_ultimate_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_final_deaths_bedwars")]
    public float four_four_ultimate_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_deaths_bedwars")]
    public float four_four_ultimate_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_void_deaths_bedwars")]
    public float four_four_ultimate_void_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_permanent _items_purchased_bedwars")]
    public float four_four_ultimate_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_emerald_resources_collected_bedwars")]
    public float four_four_ultimate_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_diamond_resources_collected_bedwars")]
    public float four_four_ultimate_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_void_kills_bedwars")]
    public float four_four_ultimate_void_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_final_kills_bedwars")]
    public float four_four_ultimate_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_void_final_deaths_bedwars")]
    public float four_four_ultimate_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_void_final_kills_bedwars")]
    public float four_four_ultimate_void_final_kills_bedwars { get; set; }

    [JsonPropertyName("understands_streaks")]
    public bool understands_streaks { get; set; }

    [JsonPropertyName("castle_entity_attack_final_deaths_bedwars")]
    public float castle_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("castle_wins_bedwars")]
    public float castle_wins_bedwars { get; set; }

    [JsonPropertyName("castle_diamond_resources_collected_bedwars")]
    public float castle_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("lastHytaleAd")]
    public long lastHytaleAd { get; set; }

    [JsonPropertyName("castle_entity_attack_final_kills_bedwars")]
    public float castle_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("castle_final_kills_bedwars")]
    public float castle_final_kills_bedwars { get; set; }

    [JsonPropertyName("castle_games_played_bedwars")]
    public float castle_games_played_bedwars { get; set; }

    [JsonPropertyName("castle_fall_kills_bedwars")]
    public float castle_fall_kills_bedwars { get; set; }

    [JsonPropertyName("castle_kills_bedwars")]
    public float castle_kills_bedwars { get; set; }

    [JsonPropertyName("castle_fire_tick_final_deaths_bedwars")]
    public float castle_fire_tick_final_deaths_bedwars { get; set; }

    [JsonPropertyName("castle_permanent _items_purchased_bedwars")]
    public float castle_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("castle_fall_deaths_bedwars")]
    public float castle_fall_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_winstreak")]
    public float eight_two_winstreak { get; set; }

    [JsonPropertyName("final_deaths_bedwars")]
    public float final_deaths_bedwars { get; set; }

    [JsonPropertyName("gold_resources_collected_bedwars")]
    public float gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("void_kills_bedwars")]
    public float void_kills_bedwars { get; set; }

    [JsonPropertyName("deaths_bedwars")]
    public float deaths_bedwars { get; set; }

    [JsonPropertyName("entity_attack_final_deaths_bedwars")]
    public float entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("resources_collected_bedwars")]
    public float resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_resources_collected_bedwars")]
    public float eight_two_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_kills_bedwars")]
    public float eight_two_kills_bedwars { get; set; }

    [JsonPropertyName("games_played_bedwars")]
    public float games_played_bedwars { get; set; }

    [JsonPropertyName("eight_two_iron_resources_collected_bedwars")]
    public float eight_two_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_void_kills_bedwars")]
    public float eight_two_void_kills_bedwars { get; set; }

    [JsonPropertyName("beds_lost_bedwars")]
    public float beds_lost_bedwars { get; set; }

    [JsonPropertyName("kills_bedwars")]
    public float kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_final_deaths_bedwars")]
    public float eight_two_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_deaths_bedwars")]
    public float eight_two_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two__items_purchased_bedwars")]
    public float eight_two__items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_entity_attack_final_deaths_bedwars")]
    public float eight_two_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_games_played_bedwars")]
    public float eight_two_games_played_bedwars { get; set; }

    [JsonPropertyName("eight_two_items_purchased_bedwars")]
    public float eight_two_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_beds_lost_bedwars")]
    public float eight_two_beds_lost_bedwars { get; set; }

    [JsonPropertyName("eight_two_entity_attack_deaths_bedwars")]
    public float eight_two_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_gold_resources_collected_bedwars")]
    public float eight_two_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("entity_attack_deaths_bedwars")]
    public float entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("losses_bedwars")]
    public float losses_bedwars { get; set; }

    [JsonPropertyName("items_purchased_bedwars")]
    public float items_purchased_bedwars { get; set; }

    [JsonPropertyName("iron_resources_collected_bedwars")]
    public float iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_losses_bedwars")]
    public float eight_two_losses_bedwars { get; set; }

    [JsonPropertyName("_items_purchased_bedwars")]
    public float _items_purchased_bedwars { get; set; }

    [JsonPropertyName("void_deaths_bedwars")]
    public float void_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_void_deaths_bedwars")]
    public float eight_two_void_deaths_bedwars { get; set; }

    [JsonPropertyName("diamond_resources_collected_bedwars")]
    public float diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_diamond_resources_collected_bedwars")]
    public float eight_two_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_entity_attack_final_kills_bedwars")]
    public float eight_two_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("entity_attack_final_kills_bedwars")]
    public float entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_void_final_deaths_bedwars")]
    public float eight_two_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("void_final_deaths_bedwars")]
    public float void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("final_kills_bedwars")]
    public float final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_final_kills_bedwars")]
    public float eight_two_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_beds_broken_bedwars")]
    public float eight_two_beds_broken_bedwars { get; set; }

    [JsonPropertyName("emerald_resources_collected_bedwars")]
    public float emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_emerald_resources_collected_bedwars")]
    public float eight_two_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_entity_attack_kills_bedwars")]
    public float eight_two_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("entity_attack_kills_bedwars")]
    public float entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("beds_broken_bedwars")]
    public float beds_broken_bedwars { get; set; }

    [JsonPropertyName("castle_entity_explosion_final_deaths_bedwars")]
    public float castle_entity_explosion_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_winstreak")]
    public float eight_two_rush_winstreak { get; set; }

    [JsonPropertyName("eight_two_rush_items_purchased_bedwars")]
    public float eight_two_rush_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_losses_bedwars")]
    public float eight_two_rush_losses_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_void_final_deaths_bedwars")]
    public float eight_two_rush_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush__items_purchased_bedwars")]
    public float eight_two_rush__items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_resources_collected_bedwars")]
    public float eight_two_rush_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_emerald_resources_collected_bedwars")]
    public float eight_two_rush_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_kills_bedwars")]
    public float eight_two_rush_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_gold_resources_collected_bedwars")]
    public float eight_two_rush_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_games_played_bedwars")]
    public float eight_two_rush_games_played_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_entity_attack_kills_bedwars")]
    public float eight_two_rush_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_beds_lost_bedwars")]
    public float eight_two_rush_beds_lost_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_final_deaths_bedwars")]
    public float eight_two_rush_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_iron_resources_collected_bedwars")]
    public float eight_two_rush_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_entity_attack_deaths_bedwars")]
    public float eight_two_rush_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_diamond_resources_collected_bedwars")]
    public float eight_two_rush_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_deaths_bedwars")]
    public float eight_two_rush_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_void_kills_bedwars")]
    public float eight_two_rush_void_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_void_deaths_bedwars")]
    public float eight_two_rush_void_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_entity_attack_final_deaths_bedwars")]
    public float eight_two_rush_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_wins_bedwars")]
    public float eight_two_rush_wins_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_entity_attack_final_kills_bedwars")]
    public float eight_two_rush_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_final_kills_bedwars")]
    public float eight_two_rush_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_permanent _items_purchased_bedwars")]
    public float eight_two_rush_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_rush_fall_kills_bedwars")]
    public float eight_two_rush_fall_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_entity_attack_deaths_bedwars")]
    public float four_four_rush_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_void_final_deaths_bedwars")]
    public float four_four_rush_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_winstreak")]
    public float four_four_lucky_winstreak { get; set; }

    [JsonPropertyName("four_four_lucky_entity_attack_final_kills_bedwars")]
    public float four_four_lucky_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_emerald_resources_collected_bedwars")]
    public float four_four_lucky_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_items_purchased_bedwars")]
    public float four_four_lucky_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_games_played_bedwars")]
    public float four_four_lucky_games_played_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky__items_purchased_bedwars")]
    public float four_four_lucky__items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_kills_bedwars")]
    public float four_four_lucky_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_resources_collected_bedwars")]
    public float four_four_lucky_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_final_kills_bedwars")]
    public float four_four_lucky_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_iron_resources_collected_bedwars")]
    public float four_four_lucky_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_void_kills_bedwars")]
    public float four_four_lucky_void_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_gold_resources_collected_bedwars")]
    public float four_four_lucky_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_wins_bedwars")]
    public float four_four_lucky_wins_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_final_deaths_bedwars")]
    public float four_four_lucky_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_beds_lost_bedwars")]
    public float four_four_lucky_beds_lost_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_losses_bedwars")]
    public float four_four_lucky_losses_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_void_final_deaths_bedwars")]
    public float four_four_lucky_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_deaths_bedwars")]
    public float four_four_lucky_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_void_deaths_bedwars")]
    public float four_four_lucky_void_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_diamond_resources_collected_bedwars")]
    public float four_four_lucky_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_entity_attack_kills_bedwars")]
    public float four_four_lucky_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_fire_tick_final_deaths_bedwars")]
    public float four_four_lucky_fire_tick_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_entity_attack_deaths_bedwars")]
    public float four_four_lucky_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_beds_broken_bedwars")]
    public float four_four_lucky_beds_broken_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_entity_attack_final_deaths_bedwars")]
    public float four_four_lucky_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_permanent _items_purchased_bedwars")]
    public float four_four_rush_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("bedwars_easter_boxes")]
    public float bedwars_easter_boxes { get; set; }

    [JsonPropertyName("four_four_rush_fall_deaths_bedwars")]
    public float four_four_rush_fall_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_beds_broken_bedwars")]
    public float four_four_rush_beds_broken_bedwars { get; set; }

    [JsonPropertyName("four_four_rush_fall_kills_bedwars")]
    public float four_four_rush_fall_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_wins_bedwars")]
    public float four_four_ultimate_wins_bedwars { get; set; }

    [JsonPropertyName("four_four_winstreak")]
    public float four_four_winstreak { get; set; }

    [JsonPropertyName("four_four__items_purchased_bedwars")]
    public float four_four__items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_final_deaths_bedwars")]
    public float four_four_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_deaths_bedwars")]
    public float four_four_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_gold_resources_collected_bedwars")]
    public float four_four_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_diamond_resources_collected_bedwars")]
    public float four_four_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_beds_lost_bedwars")]
    public float four_four_beds_lost_bedwars { get; set; }

    [JsonPropertyName("four_four_losses_bedwars")]
    public float four_four_losses_bedwars { get; set; }

    [JsonPropertyName("four_four_iron_resources_collected_bedwars")]
    public float four_four_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_entity_attack_final_deaths_bedwars")]
    public float four_four_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_games_played_bedwars")]
    public float four_four_games_played_bedwars { get; set; }

    [JsonPropertyName("four_four_resources_collected_bedwars")]
    public float four_four_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_void_deaths_bedwars")]
    public float four_four_void_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_items_purchased_bedwars")]
    public float four_four_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_emerald_resources_collected_bedwars")]
    public float four_four_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_entity_attack_kills_bedwars")]
    public float four_four_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_kills_bedwars")]
    public float four_four_kills_bedwars { get; set; }

    [JsonPropertyName("winstreak")]
    public float winstreak { get; set; }

    [JsonPropertyName("four_four_entity_attack_deaths_bedwars")]
    public float four_four_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_entity_attack_final_kills_bedwars")]
    public float four_four_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_final_kills_bedwars")]
    public float four_four_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_wins_bedwars")]
    public float four_four_wins_bedwars { get; set; }

    [JsonPropertyName("wins_bedwars")]
    public float wins_bedwars { get; set; }

    [JsonPropertyName("four_four_void_final_kills_bedwars")]
    public float four_four_void_final_kills_bedwars { get; set; }

    [JsonPropertyName("void_final_kills_bedwars")]
    public float void_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_void_kills_bedwars")]
    public float four_four_void_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_void_final_deaths_bedwars")]
    public float four_four_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("fall_kills_bedwars")]
    public float fall_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_beds_broken_bedwars")]
    public float four_four_beds_broken_bedwars { get; set; }

    [JsonPropertyName("four_four_fall_kills_bedwars")]
    public float four_four_fall_kills_bedwars { get; set; }

    [JsonPropertyName("fall_deaths_bedwars")]
    public float fall_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_fall_deaths_bedwars")]
    public float four_four_fall_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_magic_deaths_bedwars")]
    public float four_four_magic_deaths_bedwars { get; set; }

    [JsonPropertyName("magic_deaths_bedwars")]
    public float magic_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_winstreak")]
    public float four_four_armed_winstreak { get; set; }

    [JsonPropertyName("four_four_armed__items_purchased_bedwars")]
    public float four_four_armed__items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_beds_lost_bedwars")]
    public float four_four_armed_beds_lost_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_diamond_resources_collected_bedwars")]
    public float four_four_armed_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_final_deaths_bedwars")]
    public float four_four_armed_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_games_played_bedwars")]
    public float four_four_armed_games_played_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_gold_resources_collected_bedwars")]
    public float four_four_armed_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_iron_resources_collected_bedwars")]
    public float four_four_armed_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_items_purchased_bedwars")]
    public float four_four_armed_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_losses_bedwars")]
    public float four_four_armed_losses_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_permanent _items_purchased_bedwars")]
    public float four_four_armed_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_projectile_final_deaths_bedwars")]
    public float four_four_armed_projectile_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_resources_collected_bedwars")]
    public float four_four_armed_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_three_winstreak")]
    public float four_three_winstreak { get; set; }

    [JsonPropertyName("four_three__items_purchased_bedwars")]
    public float four_three__items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_three_beds_lost_bedwars")]
    public float four_three_beds_lost_bedwars { get; set; }

    [JsonPropertyName("four_three_final_deaths_bedwars")]
    public float four_three_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_games_played_bedwars")]
    public float four_three_games_played_bedwars { get; set; }

    [JsonPropertyName("four_three_gold_resources_collected_bedwars")]
    public float four_three_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_three_iron_resources_collected_bedwars")]
    public float four_three_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_three_items_purchased_bedwars")]
    public float four_three_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_three_losses_bedwars")]
    public float four_three_losses_bedwars { get; set; }

    [JsonPropertyName("four_three_resources_collected_bedwars")]
    public float four_three_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_three_void_final_deaths_bedwars")]
    public float four_three_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("two_four_winstreak")]
    public float two_four_winstreak { get; set; }

    [JsonPropertyName("two_four__items_purchased_bedwars")]
    public float two_four__items_purchased_bedwars { get; set; }

    [JsonPropertyName("two_four_deaths_bedwars")]
    public float two_four_deaths_bedwars { get; set; }

    [JsonPropertyName("two_four_diamond_resources_collected_bedwars")]
    public float two_four_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("two_four_emerald_resources_collected_bedwars")]
    public float two_four_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("two_four_entity_attack_final_kills_bedwars")]
    public float two_four_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("two_four_final_kills_bedwars")]
    public float two_four_final_kills_bedwars { get; set; }

    [JsonPropertyName("two_four_games_played_bedwars")]
    public float two_four_games_played_bedwars { get; set; }

    [JsonPropertyName("two_four_gold_resources_collected_bedwars")]
    public float two_four_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("two_four_iron_resources_collected_bedwars")]
    public float two_four_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("two_four_items_purchased_bedwars")]
    public float two_four_items_purchased_bedwars { get; set; }

    [JsonPropertyName("two_four_resources_collected_bedwars")]
    public float two_four_resources_collected_bedwars { get; set; }

    [JsonPropertyName("two_four_void_deaths_bedwars")]
    public float two_four_void_deaths_bedwars { get; set; }

    [JsonPropertyName("two_four_wins_bedwars")]
    public float two_four_wins_bedwars { get; set; }

    [JsonPropertyName("two_four_beds_lost_bedwars")]
    public float two_four_beds_lost_bedwars { get; set; }

    [JsonPropertyName("two_four_entity_attack_final_deaths_bedwars")]
    public float two_four_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("two_four_final_deaths_bedwars")]
    public float two_four_final_deaths_bedwars { get; set; }

    [JsonPropertyName("two_four_kills_bedwars")]
    public float two_four_kills_bedwars { get; set; }

    [JsonPropertyName("two_four_losses_bedwars")]
    public float two_four_losses_bedwars { get; set; }

    [JsonPropertyName("two_four_void_kills_bedwars")]
    public float two_four_void_kills_bedwars { get; set; }

    [JsonPropertyName("two_four_magic_deaths_bedwars")]
    public float two_four_magic_deaths_bedwars { get; set; }

    [JsonPropertyName("free_event_key_bedwars_christmas_boxes_2020")]
    public bool free_event_key_bedwars_christmas_boxes_2020 { get; set; }

    [JsonPropertyName("bedwars_christmas_boxes")]
    public float bedwars_christmas_boxes { get; set; }

    [JsonPropertyName("Bedwars_openedEpics")]
    public float Bedwars_openedEpics { get; set; }

    [JsonPropertyName("activeIslandTopper")]
    public string activeIslandTopper { get; set; }

    [JsonPropertyName("four_four_permanent_items_purchased_bedwars")]
    public float four_four_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("permanent_items_purchased_bedwars")]
    public float permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("fall_final_deaths_bedwars")]
    public float fall_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_fall_final_deaths_bedwars")]
    public float four_four_fall_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_entity_explosion_kills_bedwars")]
    public float eight_two_entity_explosion_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_permanent_items_purchased_bedwars")]
    public float eight_two_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("entity_explosion_kills_bedwars")]
    public float entity_explosion_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_magic_deaths_bedwars")]
    public float eight_two_magic_deaths_bedwars { get; set; }

    [JsonPropertyName("practice")]
    public Practice practice { get; set; }

    [JsonPropertyName("free_event_key_bedwars_easter_boxes_2021")]
    public bool free_event_key_bedwars_easter_boxes_2021 { get; set; }

    [JsonPropertyName("four_four_magic_kills_bedwars")]
    public float four_four_magic_kills_bedwars { get; set; }

    [JsonPropertyName("magic_kills_bedwars")]
    public float magic_kills_bedwars { get; set; }

    [JsonPropertyName("activeNPCSkin")]
    public string activeNPCSkin { get; set; }

    [JsonPropertyName("activeSprays")]
    public string activeSprays { get; set; }

    [JsonPropertyName("activeGlyph")]
    public string activeGlyph { get; set; }

    [JsonPropertyName("activeDeathCry")]
    public string activeDeathCry { get; set; }

    [JsonPropertyName("Bedwars_openedLegendaries")]
    public float Bedwars_openedLegendaries { get; set; }

    [JsonPropertyName("activeKillEffect")]
    public string activeKillEffect { get; set; }

    [JsonPropertyName("activeVictoryDance")]
    public string activeVictoryDance { get; set; }

    [JsonPropertyName("activeBedDestroy")]
    public string activeBedDestroy { get; set; }

    [JsonPropertyName("eight_two_fall_kills_bedwars")]
    public float eight_two_fall_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_wins_bedwars")]
    public float eight_two_wins_bedwars { get; set; }

    [JsonPropertyName("four_three_deaths_bedwars")]
    public float four_three_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_entity_attack_deaths_bedwars")]
    public float four_three_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_entity_attack_final_deaths_bedwars")]
    public float four_three_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_entity_attack_kills_bedwars")]
    public float four_three_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("four_three_kills_bedwars")]
    public float four_three_kills_bedwars { get; set; }

    [JsonPropertyName("eight_one_winstreak")]
    public float eight_one_winstreak { get; set; }

    [JsonPropertyName("eight_one__items_purchased_bedwars")]
    public float eight_one__items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_one_beds_lost_bedwars")]
    public float eight_one_beds_lost_bedwars { get; set; }

    [JsonPropertyName("eight_one_deaths_bedwars")]
    public float eight_one_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_one_diamond_resources_collected_bedwars")]
    public float eight_one_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_one_emerald_resources_collected_bedwars")]
    public float eight_one_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_one_entity_attack_deaths_bedwars")]
    public float eight_one_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_one_entity_attack_final_deaths_bedwars")]
    public float eight_one_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_one_entity_attack_kills_bedwars")]
    public float eight_one_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("eight_one_final_deaths_bedwars")]
    public float eight_one_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_one_games_played_bedwars")]
    public float eight_one_games_played_bedwars { get; set; }

    [JsonPropertyName("eight_one_gold_resources_collected_bedwars")]
    public float eight_one_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_one_iron_resources_collected_bedwars")]
    public float eight_one_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_one_items_purchased_bedwars")]
    public float eight_one_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_one_kills_bedwars")]
    public float eight_one_kills_bedwars { get; set; }

    [JsonPropertyName("eight_one_losses_bedwars")]
    public float eight_one_losses_bedwars { get; set; }

    [JsonPropertyName("eight_one_resources_collected_bedwars")]
    public float eight_one_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_one_void_kills_bedwars")]
    public float eight_one_void_kills_bedwars { get; set; }

    [JsonPropertyName("selected_challenge_type")]
    public string selected_challenge_type { get; set; }

    [JsonPropertyName("eight_two_ultimate_winstreak")]
    public float eight_two_ultimate_winstreak { get; set; }

    [JsonPropertyName("eight_two_ultimate__items_purchased_bedwars")]
    public float eight_two_ultimate__items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_beds_lost_bedwars")]
    public float eight_two_ultimate_beds_lost_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_deaths_bedwars")]
    public float eight_two_ultimate_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_entity_attack_deaths_bedwars")]
    public float eight_two_ultimate_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_entity_attack_final_deaths_bedwars")]
    public float eight_two_ultimate_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_entity_attack_kills_bedwars")]
    public float eight_two_ultimate_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_final_deaths_bedwars")]
    public float eight_two_ultimate_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_final_kills_bedwars")]
    public float eight_two_ultimate_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_games_played_bedwars")]
    public float eight_two_ultimate_games_played_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_gold_resources_collected_bedwars")]
    public float eight_two_ultimate_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_iron_resources_collected_bedwars")]
    public float eight_two_ultimate_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_items_purchased_bedwars")]
    public float eight_two_ultimate_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_kills_bedwars")]
    public float eight_two_ultimate_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_losses_bedwars")]
    public float eight_two_ultimate_losses_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_resources_collected_bedwars")]
    public float eight_two_ultimate_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_ultimate_void_final_kills_bedwars")]
    public float eight_two_ultimate_void_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_projectile_final_kills_bedwars")]
    public float four_four_projectile_final_kills_bedwars { get; set; }

    [JsonPropertyName("projectile_final_kills_bedwars")]
    public float projectile_final_kills_bedwars { get; set; }

    [JsonPropertyName("lastTourneyAd")]
    public long lastTourneyAd { get; set; }

    [JsonPropertyName("four_four_armed_kills_bedwars")]
    public float four_four_armed_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_projectile_kills_bedwars")]
    public float four_four_armed_projectile_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_deaths_bedwars")]
    public float four_four_armed_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_emerald_resources_collected_bedwars")]
    public float four_four_armed_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_armed_projectile_deaths_bedwars")]
    public float four_four_armed_projectile_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_winstreak")]
    public float eight_two_armed_winstreak { get; set; }

    [JsonPropertyName("eight_two_armed__items_purchased_bedwars")]
    public float eight_two_armed__items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_beds_lost_bedwars")]
    public float eight_two_armed_beds_lost_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_deaths_bedwars")]
    public float eight_two_armed_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_diamond_resources_collected_bedwars")]
    public float eight_two_armed_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_emerald_resources_collected_bedwars")]
    public float eight_two_armed_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_entity_attack_final_deaths_bedwars")]
    public float eight_two_armed_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_final_deaths_bedwars")]
    public float eight_two_armed_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_fire_tick_kills_bedwars")]
    public float eight_two_armed_fire_tick_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_games_played_bedwars")]
    public float eight_two_armed_games_played_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_gold_resources_collected_bedwars")]
    public float eight_two_armed_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_iron_resources_collected_bedwars")]
    public float eight_two_armed_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_items_purchased_bedwars")]
    public float eight_two_armed_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_kills_bedwars")]
    public float eight_two_armed_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_losses_bedwars")]
    public float eight_two_armed_losses_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_permanent_items_purchased_bedwars")]
    public float eight_two_armed_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_projectile_deaths_bedwars")]
    public float eight_two_armed_projectile_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_armed_resources_collected_bedwars")]
    public float eight_two_armed_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_fall_kills_bedwars")]
    public float four_four_lucky_fall_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_fire_tick_deaths_bedwars")]
    public float four_four_lucky_fire_tick_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_magic_deaths_bedwars")]
    public float four_four_lucky_magic_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_permanent_items_purchased_bedwars")]
    public float four_four_lucky_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_lucky_void_final_kills_bedwars")]
    public float four_four_lucky_void_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_winstreak")]
    public float eight_two_lucky_winstreak { get; set; }

    [JsonPropertyName("eight_two_lucky_beds_lost_bedwars")]
    public float eight_two_lucky_beds_lost_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_entity_attack_kills_bedwars")]
    public float eight_two_lucky_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_final_deaths_bedwars")]
    public float eight_two_lucky_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_games_played_bedwars")]
    public float eight_two_lucky_games_played_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_gold_resources_collected_bedwars")]
    public float eight_two_lucky_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_iron_resources_collected_bedwars")]
    public float eight_two_lucky_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_kills_bedwars")]
    public float eight_two_lucky_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_losses_bedwars")]
    public float eight_two_lucky_losses_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_magic_final_deaths_bedwars")]
    public float eight_two_lucky_magic_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_resources_collected_bedwars")]
    public float eight_two_lucky_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky__items_purchased_bedwars")]
    public float eight_two_lucky__items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_diamond_resources_collected_bedwars")]
    public float eight_two_lucky_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_emerald_resources_collected_bedwars")]
    public float eight_two_lucky_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_items_purchased_bedwars")]
    public float eight_two_lucky_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_permanent_items_purchased_bedwars")]
    public float eight_two_lucky_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_wins_bedwars")]
    public float eight_two_lucky_wins_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_winstreak")]
    public float four_four_swap_winstreak { get; set; }

    [JsonPropertyName("four_four_swap__items_purchased_bedwars")]
    public float four_four_swap__items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_beds_lost_bedwars")]
    public float four_four_swap_beds_lost_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_deaths_bedwars")]
    public float four_four_swap_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_diamond_resources_collected_bedwars")]
    public float four_four_swap_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_emerald_resources_collected_bedwars")]
    public float four_four_swap_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_entity_attack_deaths_bedwars")]
    public float four_four_swap_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_entity_attack_final_kills_bedwars")]
    public float four_four_swap_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_final_deaths_bedwars")]
    public float four_four_swap_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_final_kills_bedwars")]
    public float four_four_swap_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_games_played_bedwars")]
    public float four_four_swap_games_played_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_gold_resources_collected_bedwars")]
    public float four_four_swap_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_iron_resources_collected_bedwars")]
    public float four_four_swap_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_items_purchased_bedwars")]
    public float four_four_swap_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_losses_bedwars")]
    public float four_four_swap_losses_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_magic_final_deaths_bedwars")]
    public float four_four_swap_magic_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_permanent_items_purchased_bedwars")]
    public float four_four_swap_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_resources_collected_bedwars")]
    public float four_four_swap_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_void_deaths_bedwars")]
    public float four_four_swap_void_deaths_bedwars { get; set; }

    [JsonPropertyName("two_four_void_final_deaths_bedwars")]
    public float two_four_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_magic_final_deaths_bedwars")]
    public float four_four_magic_final_deaths_bedwars { get; set; }

    [JsonPropertyName("magic_final_deaths_bedwars")]
    public float magic_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_one_void_deaths_bedwars")]
    public float eight_one_void_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_one_void_final_deaths_bedwars")]
    public float eight_one_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_one_beds_broken_bedwars")]
    public float eight_one_beds_broken_bedwars { get; set; }

    [JsonPropertyName("eight_one_entity_attack_final_kills_bedwars")]
    public float eight_one_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_one_final_kills_bedwars")]
    public float eight_one_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_one_magic_deaths_bedwars")]
    public float eight_one_magic_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_ultimate_entity_attack_deaths_bedwars")]
    public float four_four_ultimate_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_diamond_resources_collected_bedwars")]
    public float four_three_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_three_permanent_items_purchased_bedwars")]
    public float four_three_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_three_void_kills_bedwars")]
    public float four_three_void_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_fall_deaths_bedwars")]
    public float eight_two_fall_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_void_final_kills_bedwars")]
    public float eight_two_void_final_kills_bedwars { get; set; }

    [JsonPropertyName("castle_void_kills_bedwars")]
    public float castle_void_kills_bedwars { get; set; }

    [JsonPropertyName("two_four_entity_attack_deaths_bedwars")]
    public float two_four_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_one_fall_deaths_bedwars")]
    public float eight_one_fall_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_kills_bedwars")]
    public float four_four_swap_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_void_final_deaths_bedwars")]
    public float four_four_swap_void_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_void_kills_bedwars")]
    public float four_four_swap_void_kills_bedwars { get; set; }

    [JsonPropertyName("eight_one_magic_final_kills_bedwars")]
    public float eight_one_magic_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_one_permanent_items_purchased_bedwars")]
    public float eight_one_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_one_wins_bedwars")]
    public float eight_one_wins_bedwars { get; set; }

    [JsonPropertyName("magic_final_kills_bedwars")]
    public float magic_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_deaths_bedwars")]
    public float eight_two_lucky_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_lucky_void_deaths_bedwars")]
    public float eight_two_lucky_void_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_emerald_resources_collected_bedwars")]
    public float four_three_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_three_entity_attack_final_kills_bedwars")]
    public float four_three_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_three_final_kills_bedwars")]
    public float four_three_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_three_void_deaths_bedwars")]
    public float four_three_void_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_wins_bedwars")]
    public float four_three_wins_bedwars { get; set; }

    [JsonPropertyName("four_three_beds_broken_bedwars")]
    public float four_three_beds_broken_bedwars { get; set; }

    [JsonPropertyName("four_three_void_final_kills_bedwars")]
    public float four_three_void_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_magic_kills_bedwars")]
    public float eight_two_magic_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_magic_final_deaths_bedwars")]
    public float eight_two_magic_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_winstreak")]
    public float eight_two_voidless_winstreak { get; set; }

    [JsonPropertyName("eight_two_voidless__items_purchased_bedwars")]
    public float eight_two_voidless__items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_beds_lost_bedwars")]
    public float eight_two_voidless_beds_lost_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_deaths_bedwars")]
    public float eight_two_voidless_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_diamond_resources_collected_bedwars")]
    public float eight_two_voidless_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_emerald_resources_collected_bedwars")]
    public float eight_two_voidless_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_entity_attack_deaths_bedwars")]
    public float eight_two_voidless_entity_attack_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_entity_attack_final_deaths_bedwars")]
    public float eight_two_voidless_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_fall_deaths_bedwars")]
    public float eight_two_voidless_fall_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_final_deaths_bedwars")]
    public float eight_two_voidless_final_deaths_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_games_played_bedwars")]
    public float eight_two_voidless_games_played_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_gold_resources_collected_bedwars")]
    public float eight_two_voidless_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_iron_resources_collected_bedwars")]
    public float eight_two_voidless_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_items_purchased_bedwars")]
    public float eight_two_voidless_items_purchased_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_losses_bedwars")]
    public float eight_two_voidless_losses_bedwars { get; set; }

    [JsonPropertyName("eight_two_voidless_resources_collected_bedwars")]
    public float eight_two_voidless_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_winstreak")]
    public float four_four_voidless_winstreak { get; set; }

    [JsonPropertyName("four_four_voidless__items_purchased_bedwars")]
    public float four_four_voidless__items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_beds_lost_bedwars")]
    public float four_four_voidless_beds_lost_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_diamond_resources_collected_bedwars")]
    public float four_four_voidless_diamond_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_emerald_resources_collected_bedwars")]
    public float four_four_voidless_emerald_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_entity_attack_final_deaths_bedwars")]
    public float four_four_voidless_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_entity_attack_final_kills_bedwars")]
    public float four_four_voidless_entity_attack_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_entity_attack_kills_bedwars")]
    public float four_four_voidless_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_final_deaths_bedwars")]
    public float four_four_voidless_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_final_kills_bedwars")]
    public float four_four_voidless_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_games_played_bedwars")]
    public float four_four_voidless_games_played_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_gold_resources_collected_bedwars")]
    public float four_four_voidless_gold_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_iron_resources_collected_bedwars")]
    public float four_four_voidless_iron_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_items_purchased_bedwars")]
    public float four_four_voidless_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_kills_bedwars")]
    public float four_four_voidless_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_losses_bedwars")]
    public float four_four_voidless_losses_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_permanent_items_purchased_bedwars")]
    public float four_four_voidless_permanent_items_purchased_bedwars { get; set; }

    [JsonPropertyName("four_four_voidless_resources_collected_bedwars")]
    public float four_four_voidless_resources_collected_bedwars { get; set; }

    [JsonPropertyName("four_three_fall_deaths_bedwars")]
    public float four_three_fall_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_fall_kills_bedwars")]
    public float four_three_fall_kills_bedwars { get; set; }

    [JsonPropertyName("entity_explosion_deaths_bedwars")]
    public float entity_explosion_deaths_bedwars { get; set; }

    [JsonPropertyName("four_three_entity_explosion_deaths_bedwars")]
    public float four_three_entity_explosion_deaths_bedwars { get; set; }

    [JsonPropertyName("slumber")]
    public Slumber slumber { get; set; }

    [JsonPropertyName("activeProjectileTrail")]
    public string activeProjectileTrail { get; set; }

    [JsonPropertyName("shop_sort")]
    public string shop_sort { get; set; }

    [JsonPropertyName("eight_two_entity_explosion_final_kills_bedwars")]
    public float eight_two_entity_explosion_final_kills_bedwars { get; set; }

    [JsonPropertyName("eight_two_fall_final_kills_bedwars")]
    public float eight_two_fall_final_kills_bedwars { get; set; }

    [JsonPropertyName("entity_explosion_final_kills_bedwars")]
    public float entity_explosion_final_kills_bedwars { get; set; }

    [JsonPropertyName("fall_final_kills_bedwars")]
    public float fall_final_kills_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_entity_attack_final_deaths_bedwars")]
    public float four_four_swap_entity_attack_final_deaths_bedwars { get; set; }

    [JsonPropertyName("four_four_swap_entity_attack_kills_bedwars")]
    public float four_four_swap_entity_attack_kills_bedwars { get; set; }

    [JsonPropertyName("activeKillMessages")]
    public string activeKillMessages { get; set; }

    [JsonPropertyName("figurines")]
    public Figurines figurines { get; set; }

    [JsonPropertyName("shop_sort_enable_owned_first")]
    public bool shop_sort_enable_owned_first { get; set; }

    [JsonPropertyName("privategames")]
    public Privategames privategames { get; set; }

    [JsonPropertyName("0")]
    public float _0 { get; set; }

    [JsonPropertyName("1")]
    public float _1 { get; set; }

    [JsonPropertyName("2")]
    public float _2 { get; set; }

    [JsonPropertyName("3")]
    public float _3 { get; set; }
}

public class BedwarsDailyBedBreaker
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BedwarsDailyFinalKiller
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BedwarsDailyGifts
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BedwarsDailyOneMore
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BedwarsDailyWin
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BedwarsSpring2023
{
    [JsonPropertyName("0")]
    public float _0 { get; set; }

    [JsonPropertyName("1")]
    public float _1 { get; set; }
}

public class BedwarsWeeklyBedElims
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BedwarsWeeklyChallengesWin
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BedwarsWeeklyDreamWin
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BedwarsWeeklyFinalKiller
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class Bingo
{
    [JsonPropertyName("easy")]
    public Easy easy { get; set; }
}

public class Boulder
{
    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("damage_dealt_normal")]
    public float damage_dealt_normal { get; set; }
}

public class Bridging
{
    [JsonPropertyName("failed_attempts")]
    public float failed_attempts { get; set; }

    [JsonPropertyName("blocks_placed")]
    public float blocks_placed { get; set; }

    [JsonPropertyName("successful_attempts")]
    public float successful_attempts { get; set; }
}

public class BuildBattle
{
    [JsonPropertyName("games_played")]
    public float games_played { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("monthly_coins_a")]
    public float monthly_coins_a { get; set; }

    [JsonPropertyName("weekly_coins_a")]
    public float weekly_coins_a { get; set; }

    [JsonPropertyName("total_votes")]
    public float total_votes { get; set; }

    [JsonPropertyName("solo_most_points")]
    public float solo_most_points { get; set; }

    [JsonPropertyName("score")]
    public float score { get; set; }

    [JsonPropertyName("weekly_coins_b")]
    public float weekly_coins_b { get; set; }

    [JsonPropertyName("monthly_coins_b")]
    public float monthly_coins_b { get; set; }

    [JsonPropertyName("votes_Waterfall")]
    public float votes_Waterfall { get; set; }

    [JsonPropertyName("correct_guesses")]
    public float correct_guesses { get; set; }

    [JsonPropertyName("votes_Penguin")]
    public float votes_Penguin { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }
}

public class BuildBattlePlayer
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BuildBattleWeekly
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class BuildBattleWinner
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}


public class CAKEMONSTER
{
    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("damage_dealt_normal")]
    public float damage_dealt_normal { get; set; }

    [JsonPropertyName("defecake")]
    public Defecake defecake { get; set; }

    [JsonPropertyName("games")]
    public float games { get; set; }

    [JsonPropertyName("games_normal")]
    public float games_normal { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("kills_normal")]
    public float kills_normal { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("losses_normal")]
    public float losses_normal { get; set; }

    [JsonPropertyName("melee")]
    public Melee melee { get; set; }
}

public class CakeStorm
{
    [JsonPropertyName("smashed")]
    public float smashed { get; set; }

    [JsonPropertyName("smashed_normal")]
    public float smashed_normal { get; set; }
}

public class CATBLACK
{
    [JsonPropertyName("THIRST")]
    public THIRST THIRST { get; set; }

    [JsonPropertyName("HUNGER")]
    public HUNGER HUNGER { get; set; }

    [JsonPropertyName("EXERCISE")]
    public EXERCISE EXERCISE { get; set; }
}

public class Challenges
{
    [JsonPropertyName("all_time")]
    public AllTime all_time { get; set; }
}

public class Christmas
{
    [JsonPropertyName("2021")]
    public _2021 _2021 { get; set; }

    [JsonPropertyName("2022")]
    public _2022 _2022 { get; set; }

    [JsonPropertyName("2023")]
    public _2023 _2023 { get; set; }
}

public class Classes
{
    [JsonPropertyName("herobrine")]
    public Herobrine herobrine { get; set; }

    [JsonPropertyName("skeleton")]
    public Skeleton skeleton { get; set; }

    [JsonPropertyName("enderman")]
    public Enderman enderman { get; set; }

    [JsonPropertyName("zombie")]
    public Zombie zombie { get; set; }

    [JsonPropertyName("tank")]
    public Tank tank { get; set; }
}

public class ClassStats
{
    [JsonPropertyName("THE_BULK")]
    public THEBULK THE_BULK { get; set; }

    [JsonPropertyName("CAKE_MONSTER")]
    public CAKEMONSTER CAKE_MONSTER { get; set; }
}

public class Completed
{
    [JsonPropertyName("npc_reception_start")]
    public bool npc_reception_start { get; set; }

    [JsonPropertyName("npc_lady_saichi")]
    public bool npc_lady_saichi { get; set; }
}

public class Completion
{
    [JsonPropertyName("time")]
    public object time { get; set; }
}

public class DeathRecaps
{
    [JsonPropertyName("type")]
    public float type { get; set; }

    [JsonPropertyName("data")]
    public List<int> data { get; set; }
}

public class Defecake
{
    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("damage_dealt_normal")]
    public float damage_dealt_normal { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("kills_normal")]
    public float kills_normal { get; set; }
}

public class DiscoveredZones
{
    [JsonPropertyName("village")]
    public bool village { get; set; }
}

public class Dropper
{
    [JsonPropertyName("fastest_game")]
    public float fastest_game { get; set; }

    [JsonPropertyName("games_played")]
    public float games_played { get; set; }

    [JsonPropertyName("maps_completed")]
    public float maps_completed { get; set; }

    [JsonPropertyName("fails")]
    public float fails { get; set; }

    [JsonPropertyName("games_finished")]
    public float games_finished { get; set; }
}

public class Duels
{
    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("all_modes_rookie_title_prestige")]
    public float all_modes_rookie_title_prestige { get; set; }

    [JsonPropertyName("sumo_rookie_title_prestige")]
    public float sumo_rookie_title_prestige { get; set; }

    [JsonPropertyName("tnt_games_rookie_title_prestige")]
    public float tnt_games_rookie_title_prestige { get; set; }

    [JsonPropertyName("bridge_rookie_title_prestige")]
    public float bridge_rookie_title_prestige { get; set; }

    [JsonPropertyName("bow_rookie_title_prestige")]
    public float bow_rookie_title_prestige { get; set; }

    [JsonPropertyName("skywars_rookie_title_prestige")]
    public float skywars_rookie_title_prestige { get; set; }

    [JsonPropertyName("mega_walls_rookie_title_prestige")]
    public float mega_walls_rookie_title_prestige { get; set; }

    [JsonPropertyName("op_rookie_title_prestige")]
    public float op_rookie_title_prestige { get; set; }

    [JsonPropertyName("classic_rookie_title_prestige")]
    public float classic_rookie_title_prestige { get; set; }

    [JsonPropertyName("blitz_rookie_title_prestige")]
    public float blitz_rookie_title_prestige { get; set; }

    [JsonPropertyName("tournament_rookie_title_prestige")]
    public float tournament_rookie_title_prestige { get; set; }

    [JsonPropertyName("combo_rookie_title_prestige")]
    public float combo_rookie_title_prestige { get; set; }

    [JsonPropertyName("no_debuff_rookie_title_prestige")]
    public float no_debuff_rookie_title_prestige { get; set; }

    [JsonPropertyName("uhc_rookie_title_prestige")]
    public float uhc_rookie_title_prestige { get; set; }

    [JsonPropertyName("duels_recently_played")]
    public string duels_recently_played { get; set; }

    [JsonPropertyName("selected_1_new")]
    public string selected_1_new { get; set; }

    [JsonPropertyName("selected_2_new")]
    public string selected_2_new { get; set; }

    [JsonPropertyName("show_lb_option")]
    public string show_lb_option { get; set; }

    [JsonPropertyName("chat_enabled")]
    public string chat_enabled { get; set; }

    [JsonPropertyName("games_played_duels")]
    public float games_played_duels { get; set; }

    [JsonPropertyName("current_uhc_winstreak")]
    public float current_uhc_winstreak { get; set; }

    [JsonPropertyName("current_winstreak")]
    public float current_winstreak { get; set; }

    [JsonPropertyName("current_winstreak_mode_uhc_duel")]
    public float current_winstreak_mode_uhc_duel { get; set; }

    [JsonPropertyName("melee_swings")]
    public float melee_swings { get; set; }

    [JsonPropertyName("uhc_duel_health_regenerated")]
    public float uhc_duel_health_regenerated { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("melee_hits")]
    public float melee_hits { get; set; }

    [JsonPropertyName("uhc_duel_losses")]
    public float uhc_duel_losses { get; set; }

    [JsonPropertyName("uhc_duel_bow_shots")]
    public float uhc_duel_bow_shots { get; set; }

    [JsonPropertyName("rounds_played")]
    public float rounds_played { get; set; }

    [JsonPropertyName("uhc_duel_melee_swings")]
    public float uhc_duel_melee_swings { get; set; }

    [JsonPropertyName("bow_shots")]
    public float bow_shots { get; set; }

    [JsonPropertyName("golden_apples_eaten")]
    public float golden_apples_eaten { get; set; }

    [JsonPropertyName("uhc_duel_bow_hits")]
    public float uhc_duel_bow_hits { get; set; }

    [JsonPropertyName("uhc_duel_rounds_played")]
    public float uhc_duel_rounds_played { get; set; }

    [JsonPropertyName("bow_hits")]
    public float bow_hits { get; set; }

    [JsonPropertyName("uhc_duel_deaths")]
    public float uhc_duel_deaths { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("uhc_duel_damage_dealt")]
    public float uhc_duel_damage_dealt { get; set; }

    [JsonPropertyName("health_regenerated")]
    public float health_regenerated { get; set; }

    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("uhc_duel_golden_apples_eaten")]
    public float uhc_duel_golden_apples_eaten { get; set; }

    [JsonPropertyName("uhc_duel_melee_hits")]
    public float uhc_duel_melee_hits { get; set; }

    [JsonPropertyName("sw_duels_kit_new2")]
    public string sw_duels_kit_new2 { get; set; }

    [JsonPropertyName("current_winstreak_mode_sw_doubles")]
    public float current_winstreak_mode_sw_doubles { get; set; }

    [JsonPropertyName("current_skywars_winstreak")]
    public float current_skywars_winstreak { get; set; }

    [JsonPropertyName("sw_doubles_melee_swings")]
    public float sw_doubles_melee_swings { get; set; }

    [JsonPropertyName("blocks_placed")]
    public float blocks_placed { get; set; }

    [JsonPropertyName("sw_doubles_health_regenerated")]
    public float sw_doubles_health_regenerated { get; set; }

    [JsonPropertyName("sw_doubles_deaths")]
    public float sw_doubles_deaths { get; set; }

    [JsonPropertyName("sw_doubles_melee_hits")]
    public float sw_doubles_melee_hits { get; set; }

    [JsonPropertyName("sw_doubles_rounds_played")]
    public float sw_doubles_rounds_played { get; set; }

    [JsonPropertyName("sw_doubles_blocks_placed")]
    public float sw_doubles_blocks_placed { get; set; }

    [JsonPropertyName("sw_doubles_losses")]
    public float sw_doubles_losses { get; set; }

    [JsonPropertyName("sw_doubles_damage_dealt")]
    public float sw_doubles_damage_dealt { get; set; }

    [JsonPropertyName("best_skywars_winstreak")]
    public float best_skywars_winstreak { get; set; }

    [JsonPropertyName("best_overall_winstreak")]
    public float best_overall_winstreak { get; set; }

    [JsonPropertyName("best_winstreak_mode_sw_doubles")]
    public float best_winstreak_mode_sw_doubles { get; set; }

    [JsonPropertyName("maps_won_on")]
    public List<string> maps_won_on { get; set; }

    [JsonPropertyName("scout_kit_wins")]
    public float scout_kit_wins { get; set; }

    [JsonPropertyName("wins")]
    public float wins { get; set; }

    [JsonPropertyName("sw_doubles_kit_wins")]
    public float sw_doubles_kit_wins { get; set; }

    [JsonPropertyName("sw_doubles_scout_kit_wins")]
    public float sw_doubles_scout_kit_wins { get; set; }

    [JsonPropertyName("sw_doubles_kills")]
    public float sw_doubles_kills { get; set; }

    [JsonPropertyName("kit_wins")]
    public float kit_wins { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("sw_doubles_wins")]
    public float sw_doubles_wins { get; set; }

    [JsonPropertyName("duels_winstreak_best_sw_doubles")]
    public float duels_winstreak_best_sw_doubles { get; set; }

    [JsonPropertyName("sw_doubles_bow_shots")]
    public float sw_doubles_bow_shots { get; set; }

    [JsonPropertyName("sw_doubles_bow_hits")]
    public float sw_doubles_bow_hits { get; set; }

    [JsonPropertyName("sw_duels_kit_new3")]
    public string sw_duels_kit_new3 { get; set; }

    [JsonPropertyName("sw_doubles_bowman_kit_wins")]
    public float sw_doubles_bowman_kit_wins { get; set; }

    [JsonPropertyName("bowman_kit_wins")]
    public float bowman_kit_wins { get; set; }

    [JsonPropertyName("current_tnt_games_winstreak")]
    public float current_tnt_games_winstreak { get; set; }

    [JsonPropertyName("current_winstreak_mode_bowspleef_duel")]
    public float current_winstreak_mode_bowspleef_duel { get; set; }

    [JsonPropertyName("bowspleef_duel_rounds_played")]
    public float bowspleef_duel_rounds_played { get; set; }

    [JsonPropertyName("bowspleef_duel_bow_shots")]
    public float bowspleef_duel_bow_shots { get; set; }

    [JsonPropertyName("bowspleef_duel_deaths")]
    public float bowspleef_duel_deaths { get; set; }

    [JsonPropertyName("bowspleef_duel_losses")]
    public float bowspleef_duel_losses { get; set; }

    [JsonPropertyName("best_winstreak_mode_bowspleef_duel")]
    public float best_winstreak_mode_bowspleef_duel { get; set; }

    [JsonPropertyName("best_tnt_games_winstreak")]
    public float best_tnt_games_winstreak { get; set; }

    [JsonPropertyName("bowspleef_duel_wins")]
    public float bowspleef_duel_wins { get; set; }

    [JsonPropertyName("leaderboardPage_win_streak")]
    public float leaderboardPage_win_streak { get; set; }

    [JsonPropertyName("blitz_duel")]
    public bool blitz_duel { get; set; }

    [JsonPropertyName("active_hat")]
    public string active_hat { get; set; }

    [JsonPropertyName("duels_recently_played2")]
    public string duels_recently_played2 { get; set; }

    [JsonPropertyName("current_winstreak_mode_uhc_meetup")]
    public float current_winstreak_mode_uhc_meetup { get; set; }

    [JsonPropertyName("uhc_meetup_health_regenerated")]
    public float uhc_meetup_health_regenerated { get; set; }

    [JsonPropertyName("uhc_meetup_losses")]
    public float uhc_meetup_losses { get; set; }

    [JsonPropertyName("uhc_meetup_deaths")]
    public float uhc_meetup_deaths { get; set; }

    [JsonPropertyName("uhc_meetup_melee_hits")]
    public float uhc_meetup_melee_hits { get; set; }

    [JsonPropertyName("uhc_meetup_damage_dealt")]
    public float uhc_meetup_damage_dealt { get; set; }

    [JsonPropertyName("uhc_meetup_rounds_played")]
    public float uhc_meetup_rounds_played { get; set; }

    [JsonPropertyName("uhc_meetup_melee_swings")]
    public float uhc_meetup_melee_swings { get; set; }

    [JsonPropertyName("current_winstreak_mode_classic_duel")]
    public float current_winstreak_mode_classic_duel { get; set; }

    [JsonPropertyName("current_classic_winstreak")]
    public float current_classic_winstreak { get; set; }

    [JsonPropertyName("classic_duel_damage_dealt")]
    public float classic_duel_damage_dealt { get; set; }

    [JsonPropertyName("classic_duel_deaths")]
    public float classic_duel_deaths { get; set; }

    [JsonPropertyName("classic_duel_health_regenerated")]
    public float classic_duel_health_regenerated { get; set; }

    [JsonPropertyName("classic_duel_losses")]
    public float classic_duel_losses { get; set; }

    [JsonPropertyName("classic_duel_melee_hits")]
    public float classic_duel_melee_hits { get; set; }

    [JsonPropertyName("classic_duel_melee_swings")]
    public float classic_duel_melee_swings { get; set; }

    [JsonPropertyName("classic_duel_rounds_played")]
    public float classic_duel_rounds_played { get; set; }

    [JsonPropertyName("duels_chests")]
    public float duels_chests { get; set; }

    [JsonPropertyName("current_winstreak_mode_sw_duel")]
    public float current_winstreak_mode_sw_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_sw_duel")]
    public float best_winstreak_mode_sw_duel { get; set; }

    [JsonPropertyName("sw_duel_blocks_placed")]
    public float sw_duel_blocks_placed { get; set; }

    [JsonPropertyName("sw_duel_bow_hits")]
    public float sw_duel_bow_hits { get; set; }

    [JsonPropertyName("sw_duel_bow_shots")]
    public float sw_duel_bow_shots { get; set; }

    [JsonPropertyName("sw_duel_bowman_kit_wins")]
    public float sw_duel_bowman_kit_wins { get; set; }

    [JsonPropertyName("sw_duel_damage_dealt")]
    public float sw_duel_damage_dealt { get; set; }

    [JsonPropertyName("sw_duel_health_regenerated")]
    public float sw_duel_health_regenerated { get; set; }

    [JsonPropertyName("sw_duel_kills")]
    public float sw_duel_kills { get; set; }

    [JsonPropertyName("sw_duel_kit_wins")]
    public float sw_duel_kit_wins { get; set; }

    [JsonPropertyName("sw_duel_melee_hits")]
    public float sw_duel_melee_hits { get; set; }

    [JsonPropertyName("sw_duel_melee_swings")]
    public float sw_duel_melee_swings { get; set; }

    [JsonPropertyName("sw_duel_rounds_played")]
    public float sw_duel_rounds_played { get; set; }

    [JsonPropertyName("sw_duel_wins")]
    public float sw_duel_wins { get; set; }

    [JsonPropertyName("sw_duel_deaths")]
    public float sw_duel_deaths { get; set; }

    [JsonPropertyName("sw_duel_losses")]
    public float sw_duel_losses { get; set; }

    [JsonPropertyName("uhc_duel_blocks_placed")]
    public float uhc_duel_blocks_placed { get; set; }

    [JsonPropertyName("sw_duel_scout_kit_wins")]
    public float sw_duel_scout_kit_wins { get; set; }

    [JsonPropertyName("current_op_winstreak")]
    public float current_op_winstreak { get; set; }

    [JsonPropertyName("current_winstreak_mode_op_duel")]
    public float current_winstreak_mode_op_duel { get; set; }

    [JsonPropertyName("op_duel_damage_dealt")]
    public float op_duel_damage_dealt { get; set; }

    [JsonPropertyName("op_duel_deaths")]
    public float op_duel_deaths { get; set; }

    [JsonPropertyName("op_duel_health_regenerated")]
    public float op_duel_health_regenerated { get; set; }

    [JsonPropertyName("op_duel_losses")]
    public float op_duel_losses { get; set; }

    [JsonPropertyName("op_duel_melee_hits")]
    public float op_duel_melee_hits { get; set; }

    [JsonPropertyName("op_duel_melee_swings")]
    public float op_duel_melee_swings { get; set; }

    [JsonPropertyName("op_duel_rounds_played")]
    public float op_duel_rounds_played { get; set; }

    [JsonPropertyName("classic_duel_bow_hits")]
    public float classic_duel_bow_hits { get; set; }

    [JsonPropertyName("classic_duel_bow_shots")]
    public float classic_duel_bow_shots { get; set; }

    [JsonPropertyName("best_winstreak_mode_classic_duel")]
    public float best_winstreak_mode_classic_duel { get; set; }

    [JsonPropertyName("best_classic_winstreak")]
    public float best_classic_winstreak { get; set; }

    [JsonPropertyName("classic_duel_kills")]
    public float classic_duel_kills { get; set; }

    [JsonPropertyName("classic_duel_wins")]
    public float classic_duel_wins { get; set; }

    [JsonPropertyName("paladin_kit_wins")]
    public float paladin_kit_wins { get; set; }

    [JsonPropertyName("sw_duel_paladin_kit_wins")]
    public float sw_duel_paladin_kit_wins { get; set; }

    [JsonPropertyName("duels_winstreak_best_sw_duel")]
    public float duels_winstreak_best_sw_duel { get; set; }

    [JsonPropertyName("moved_to_redis_2")]
    public bool moved_to_redis_2 { get; set; }

    [JsonPropertyName("parkour_rookie_title_prestige")]
    public float parkour_rookie_title_prestige { get; set; }

    [JsonPropertyName("boxing_rookie_title_prestige")]
    public float boxing_rookie_title_prestige { get; set; }

    [JsonPropertyName("best_all_modes_winstreak")]
    public float best_all_modes_winstreak { get; set; }

    [JsonPropertyName("best_uhc_winstreak")]
    public float best_uhc_winstreak { get; set; }

    [JsonPropertyName("best_mega_walls_winstreak")]
    public float best_mega_walls_winstreak { get; set; }

    [JsonPropertyName("best_blitz_winstreak")]
    public float best_blitz_winstreak { get; set; }

    [JsonPropertyName("best_op_winstreak")]
    public float best_op_winstreak { get; set; }

    [JsonPropertyName("best_bow_winstreak")]
    public float best_bow_winstreak { get; set; }

    [JsonPropertyName("best_no_debuff_winstreak")]
    public float best_no_debuff_winstreak { get; set; }

    [JsonPropertyName("best_combo_winstreak")]
    public float best_combo_winstreak { get; set; }

    [JsonPropertyName("best_sumo_winstreak")]
    public float best_sumo_winstreak { get; set; }

    [JsonPropertyName("best_bridge_winstreak")]
    public float best_bridge_winstreak { get; set; }

    [JsonPropertyName("best_parkour_winstreak")]
    public float best_parkour_winstreak { get; set; }

    [JsonPropertyName("best_boxing_winstreak")]
    public float best_boxing_winstreak { get; set; }

    [JsonPropertyName("best_arena_winstreak")]
    public float best_arena_winstreak { get; set; }

    [JsonPropertyName("rematch_option_1")]
    public string rematch_option_1 { get; set; }

    [JsonPropertyName("best_winstreak_mode_blitz_duel")]
    public float best_winstreak_mode_blitz_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_mw_duel")]
    public float best_winstreak_mode_mw_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_bow_duel")]
    public float best_winstreak_mode_bow_duel { get; set; }

    [JsonPropertyName("moved_to_redis_3")]
    public bool moved_to_redis_3 { get; set; }

    [JsonPropertyName("best_winstreak_mode_op_duel")]
    public float best_winstreak_mode_op_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_uhc_duel")]
    public float best_winstreak_mode_uhc_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_parkour_eight")]
    public float best_winstreak_mode_parkour_eight { get; set; }

    [JsonPropertyName("best_winstreak_mode_combo_duel")]
    public float best_winstreak_mode_combo_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_uhc_four")]
    public float best_winstreak_mode_uhc_four { get; set; }

    [JsonPropertyName("best_winstreak_mode_mw_doubles")]
    public float best_winstreak_mode_mw_doubles { get; set; }

    [JsonPropertyName("best_winstreak_mode_boxing_duel")]
    public float best_winstreak_mode_boxing_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_capture_threes")]
    public float best_winstreak_mode_capture_threes { get; set; }

    [JsonPropertyName("best_winstreak_mode_sumo_duel")]
    public float best_winstreak_mode_sumo_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_bridge_3v3v3v3")]
    public float best_winstreak_mode_bridge_3v3v3v3 { get; set; }

    [JsonPropertyName("best_winstreak_mode_bridge_2v2v2v2")]
    public float best_winstreak_mode_bridge_2v2v2v2 { get; set; }

    [JsonPropertyName("best_winstreak_mode_duel_arena")]
    public float best_winstreak_mode_duel_arena { get; set; }

    [JsonPropertyName("best_winstreak_mode_bridge_four")]
    public float best_winstreak_mode_bridge_four { get; set; }

    [JsonPropertyName("best_winstreak_mode_uhc_meetup")]
    public float best_winstreak_mode_uhc_meetup { get; set; }

    [JsonPropertyName("best_winstreak_mode_bridge_doubles")]
    public float best_winstreak_mode_bridge_doubles { get; set; }

    [JsonPropertyName("best_winstreak_mode_bridge_duel")]
    public float best_winstreak_mode_bridge_duel { get; set; }

    [JsonPropertyName("best_winstreak_mode_bridge_threes")]
    public float best_winstreak_mode_bridge_threes { get; set; }

    [JsonPropertyName("best_winstreak_mode_op_doubles")]
    public float best_winstreak_mode_op_doubles { get; set; }

    [JsonPropertyName("best_winstreak_mode_uhc_doubles")]
    public float best_winstreak_mode_uhc_doubles { get; set; }

    [JsonPropertyName("best_winstreak_mode_potion_duel")]
    public float best_winstreak_mode_potion_duel { get; set; }

    [JsonPropertyName("magician_kit_wins")]
    public float magician_kit_wins { get; set; }

    [JsonPropertyName("sw_duel_magician_kit_wins")]
    public float sw_duel_magician_kit_wins { get; set; }

    [JsonPropertyName("mw_duels_class")]
    public string mw_duels_class { get; set; }

    [JsonPropertyName("mw_duel_bow_hits")]
    public float mw_duel_bow_hits { get; set; }

    [JsonPropertyName("mw_duel_bow_shots")]
    public float mw_duel_bow_shots { get; set; }

    [JsonPropertyName("mw_duel_damage_dealt")]
    public float mw_duel_damage_dealt { get; set; }

    [JsonPropertyName("mw_duel_deaths")]
    public float mw_duel_deaths { get; set; }

    [JsonPropertyName("mw_duel_health_regenerated")]
    public float mw_duel_health_regenerated { get; set; }

    [JsonPropertyName("mw_duel_losses")]
    public float mw_duel_losses { get; set; }

    [JsonPropertyName("mw_duel_melee_hits")]
    public float mw_duel_melee_hits { get; set; }

    [JsonPropertyName("mw_duel_melee_swings")]
    public float mw_duel_melee_swings { get; set; }

    [JsonPropertyName("mw_duel_rounds_played")]
    public float mw_duel_rounds_played { get; set; }

    [JsonPropertyName("bow_duel_bow_hits")]
    public float bow_duel_bow_hits { get; set; }

    [JsonPropertyName("bow_duel_bow_shots")]
    public float bow_duel_bow_shots { get; set; }

    [JsonPropertyName("bow_duel_damage_dealt")]
    public float bow_duel_damage_dealt { get; set; }

    [JsonPropertyName("bow_duel_rounds_played")]
    public float bow_duel_rounds_played { get; set; }

    [JsonPropertyName("sumo_duel_melee_hits")]
    public float sumo_duel_melee_hits { get; set; }

    [JsonPropertyName("sumo_duel_melee_swings")]
    public float sumo_duel_melee_swings { get; set; }

    [JsonPropertyName("sumo_duel_rounds_played")]
    public float sumo_duel_rounds_played { get; set; }

    [JsonPropertyName("arena_mode_uhc")]
    public string arena_mode_uhc { get; set; }

    [JsonPropertyName("arena_mode_op")]
    public string arena_mode_op { get; set; }

    [JsonPropertyName("arena_mode_no_debuff")]
    public string arena_mode_no_debuff { get; set; }

    [JsonPropertyName("duel_arena_bow_hits")]
    public float duel_arena_bow_hits { get; set; }

    [JsonPropertyName("duel_arena_bow_shots")]
    public float duel_arena_bow_shots { get; set; }

    [JsonPropertyName("duel_arena_damage_dealt")]
    public float duel_arena_damage_dealt { get; set; }

    [JsonPropertyName("duel_arena_health_regenerated")]
    public float duel_arena_health_regenerated { get; set; }

    [JsonPropertyName("duel_arena_melee_hits")]
    public float duel_arena_melee_hits { get; set; }

    [JsonPropertyName("duel_arena_melee_swings")]
    public float duel_arena_melee_swings { get; set; }

    [JsonPropertyName("duel_arena_rounds_played")]
    public float duel_arena_rounds_played { get; set; }

    [JsonPropertyName("duel_arena_blocks_placed")]
    public float duel_arena_blocks_placed { get; set; }

    [JsonPropertyName("current_winstreak_mode_duel_arena")]
    public float current_winstreak_mode_duel_arena { get; set; }

    [JsonPropertyName("current_arena_winstreak")]
    public float current_arena_winstreak { get; set; }

    [JsonPropertyName("arena_mode_soup")]
    public string arena_mode_soup { get; set; }

    [JsonPropertyName("duel_arena_wins")]
    public float duel_arena_wins { get; set; }

    [JsonPropertyName("arena_mode_bow")]
    public string arena_mode_bow { get; set; }

    [JsonPropertyName("arena_mode_classic")]
    public string arena_mode_classic { get; set; }

    [JsonPropertyName("current_winstreak_mode_mw_duel")]
    public float current_winstreak_mode_mw_duel { get; set; }

    [JsonPropertyName("current_mega_walls_winstreak")]
    public float current_mega_walls_winstreak { get; set; }

    [JsonPropertyName("herobrine_kit_wins")]
    public float herobrine_kit_wins { get; set; }

    [JsonPropertyName("mw_duel_blocks_placed")]
    public float mw_duel_blocks_placed { get; set; }

    [JsonPropertyName("mw_duel_herobrine_kit_wins")]
    public float mw_duel_herobrine_kit_wins { get; set; }

    [JsonPropertyName("mw_duel_kills")]
    public float mw_duel_kills { get; set; }

    [JsonPropertyName("mw_duel_kit_wins")]
    public float mw_duel_kit_wins { get; set; }

    [JsonPropertyName("mw_duel_wins")]
    public float mw_duel_wins { get; set; }

    [JsonPropertyName("enderman_a_meters_travelled")]
    public float enderman_a_meters_travelled { get; set; }

    [JsonPropertyName("enderman_a_meters_travelled_standard")]
    public float enderman_a_meters_travelled_standard { get; set; }

    [JsonPropertyName("enderman_meters_travelled")]
    public float enderman_meters_travelled { get; set; }

    [JsonPropertyName("enderman_meters_travelled_standard")]
    public float enderman_meters_travelled_standard { get; set; }

    [JsonPropertyName("meters_travelled")]
    public float meters_travelled { get; set; }

    [JsonPropertyName("meters_travelled_standard")]
    public float meters_travelled_standard { get; set; }

    [JsonPropertyName("armorer_kit_wins")]
    public float armorer_kit_wins { get; set; }

    [JsonPropertyName("sw_duel_armorer_kit_wins")]
    public float sw_duel_armorer_kit_wins { get; set; }

    [JsonPropertyName("bridge_duel_blocks_placed")]
    public float bridge_duel_blocks_placed { get; set; }

    [JsonPropertyName("bridge_duel_bow_hits")]
    public float bridge_duel_bow_hits { get; set; }

    [JsonPropertyName("bridge_duel_bow_shots")]
    public float bridge_duel_bow_shots { get; set; }

    [JsonPropertyName("bridge_duel_damage_dealt")]
    public float bridge_duel_damage_dealt { get; set; }

    [JsonPropertyName("bridge_duel_golden_apples_eaten")]
    public float bridge_duel_golden_apples_eaten { get; set; }

    [JsonPropertyName("bridge_duel_melee_hits")]
    public float bridge_duel_melee_hits { get; set; }

    [JsonPropertyName("bridge_duel_melee_swings")]
    public float bridge_duel_melee_swings { get; set; }

    [JsonPropertyName("bridge_duel_rounds_played")]
    public float bridge_duel_rounds_played { get; set; }

    [JsonPropertyName("bridge_doubles_blocks_placed")]
    public float bridge_doubles_blocks_placed { get; set; }

    [JsonPropertyName("bridge_doubles_bow_hits")]
    public float bridge_doubles_bow_hits { get; set; }

    [JsonPropertyName("bridge_doubles_bow_shots")]
    public float bridge_doubles_bow_shots { get; set; }

    [JsonPropertyName("bridge_doubles_damage_dealt")]
    public float bridge_doubles_damage_dealt { get; set; }

    [JsonPropertyName("bridge_doubles_golden_apples_eaten")]
    public float bridge_doubles_golden_apples_eaten { get; set; }

    [JsonPropertyName("bridge_doubles_melee_swings")]
    public float bridge_doubles_melee_swings { get; set; }

    [JsonPropertyName("bridge_doubles_rounds_played")]
    public float bridge_doubles_rounds_played { get; set; }

    [JsonPropertyName("combo_duel_damage_dealt")]
    public float combo_duel_damage_dealt { get; set; }

    [JsonPropertyName("combo_duel_golden_apples_eaten")]
    public float combo_duel_golden_apples_eaten { get; set; }

    [JsonPropertyName("combo_duel_health_regenerated")]
    public float combo_duel_health_regenerated { get; set; }

    [JsonPropertyName("combo_duel_melee_hits")]
    public float combo_duel_melee_hits { get; set; }

    [JsonPropertyName("combo_duel_melee_swings")]
    public float combo_duel_melee_swings { get; set; }

    [JsonPropertyName("combo_duel_rounds_played")]
    public float combo_duel_rounds_played { get; set; }

    [JsonPropertyName("boxing_duel_melee_hits")]
    public float boxing_duel_melee_hits { get; set; }

    [JsonPropertyName("boxing_duel_melee_swings")]
    public float boxing_duel_melee_swings { get; set; }

    [JsonPropertyName("boxing_duel_rounds_played")]
    public float boxing_duel_rounds_played { get; set; }

    [JsonPropertyName("bridgeMapWins")]
    public List<string> bridgeMapWins { get; set; }

    [JsonPropertyName("current_winstreak_mode_bridge_doubles")]
    public float current_winstreak_mode_bridge_doubles { get; set; }

    [JsonPropertyName("current_bridge_winstreak")]
    public float current_bridge_winstreak { get; set; }

    [JsonPropertyName("bridge_deaths")]
    public float bridge_deaths { get; set; }

    [JsonPropertyName("bridge_doubles_bridge_deaths")]
    public float bridge_doubles_bridge_deaths { get; set; }

    [JsonPropertyName("bridge_doubles_bridge_kills")]
    public float bridge_doubles_bridge_kills { get; set; }

    [JsonPropertyName("bridge_doubles_goals")]
    public float bridge_doubles_goals { get; set; }

    [JsonPropertyName("bridge_doubles_melee_hits")]
    public float bridge_doubles_melee_hits { get; set; }

    [JsonPropertyName("bridge_doubles_wins")]
    public float bridge_doubles_wins { get; set; }

    [JsonPropertyName("bridge_kills")]
    public float bridge_kills { get; set; }

    [JsonPropertyName("goals")]
    public float goals { get; set; }
}

public class DuelsKiller
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }
}

public class DuelsPlayer
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class DuelsWeeklyKills
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class DuelsWeeklyWins
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class DuelsWinner
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }
}

public class Easter
{
    [JsonPropertyName("2023")]
    public _2023 _2023 { get; set; }

    [JsonPropertyName("2024")]
    public _2024 _2024 { get; set; }
}

public class Easy
{
    [JsonPropertyName("objectives")]
    public Objectives objectives { get; set; }
}


public class Egghunt
{
    [JsonPropertyName("eggs")]
    public Eggs eggs { get; set; }
}

public class Eggs
{
    [JsonPropertyName("0")]
    public bool _0 { get; set; }
}

public class EndedContract
{
    [JsonPropertyName("difficulty")]
    public string difficulty { get; set; }

    [JsonPropertyName("gold_reward")]
    public float gold_reward { get; set; }

    [JsonPropertyName("requirements")]
    public Requirements requirements { get; set; }

    [JsonPropertyName("progress")]
    public Progress progress { get; set; }

    [JsonPropertyName("chunk_of_viles_reward")]
    public float chunk_of_viles_reward { get; set; }

    [JsonPropertyName("completion_date")]
    public object completion_date { get; set; }

    [JsonPropertyName("remaining_ticks")]
    public float remaining_ticks { get; set; }

    [JsonPropertyName("key")]
    public string key { get; set; }
}

public class Enderman
{
    [JsonPropertyName("skill_level_dChecked5")]
    public bool skill_level_dChecked5 { get; set; }

    [JsonPropertyName("skill_level_d")]
    public float skill_level_d { get; set; }

    [JsonPropertyName("checked4")]
    public bool checked4 { get; set; }

    [JsonPropertyName("unlocked")]
    public bool unlocked { get; set; }
}

public class Eugene
{
    [JsonPropertyName("dailyTwoKExp")]
    public long dailyTwoKExp { get; set; }
}

public class EXERCISE
{
    [JsonPropertyName("timestamp")]
    public long timestamp { get; set; }

    [JsonPropertyName("value")]
    public float value { get; set; }
}

public class Figurines
{
    [JsonPropertyName("active")]
    public string active { get; set; }
}

public class FireballJumping
{
    [JsonPropertyName("failed_attempts")]
    public float failed_attempts { get; set; }

    [JsonPropertyName("successful_attempts")]
    public float successful_attempts { get; set; }

    [JsonPropertyName("blocks_placed")]
    public float blocks_placed { get; set; }
}

public class Flags
{
    [JsonPropertyName("show_tip_holograms")]
    public bool show_tip_holograms { get; set; }

    [JsonPropertyName("show_tntrun_actionbar_info")]
    public bool show_tntrun_actionbar_info { get; set; }

    [JsonPropertyName("show_tnttag_actionbar_info")]
    public bool show_tnttag_actionbar_info { get; set; }

    [JsonPropertyName("enable_explosive_dash")]
    public bool enable_explosive_dash { get; set; }
}

public class Fredgie
{
    [JsonPropertyName("should_update_index")]
    public bool should_update_index { get; set; }

    [JsonPropertyName("dialogue_index")]
    public float dialogue_index { get; set; }
}

public class GamblerGeorge
{
    [JsonPropertyName("gamble_games_won")]
    public float gamble_games_won { get; set; }

    [JsonPropertyName("won_last_game")]
    public bool won_last_game { get; set; }
}

public class GingerBread
{
    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("jacket_active")]
    public string jacket_active { get; set; }

    [JsonPropertyName("helmet_active")]
    public string helmet_active { get; set; }

    [JsonPropertyName("pants_active")]
    public string pants_active { get; set; }

    [JsonPropertyName("skin_active")]
    public string skin_active { get; set; }

    [JsonPropertyName("engine_active")]
    public string engine_active { get; set; }

    [JsonPropertyName("shoes_active")]
    public string shoes_active { get; set; }

    [JsonPropertyName("booster_active")]
    public string booster_active { get; set; }

    [JsonPropertyName("frame_active")]
    public string frame_active { get; set; }

    [JsonPropertyName("lastTourneyAd")]
    public long lastTourneyAd { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }
}

public class Halloween
{
    [JsonPropertyName("2022")]
    public _2022 _2022 { get; set; }

    [JsonPropertyName("2023")]
    public _2023 _2023 { get; set; }
}

public class HeadCollection
{
    [JsonPropertyName("recent")]
    public List<Recent> recent { get; set; }

    [JsonPropertyName("prestigious")]
    public List<Prestigiou> prestigious { get; set; }
}

public class Herobrine
{
    [JsonPropertyName("skill_level_dChecked5")]
    public bool skill_level_dChecked5 { get; set; }

    [JsonPropertyName("skill_level_d")]
    public float skill_level_d { get; set; }

    [JsonPropertyName("checked4")]
    public bool checked4 { get; set; }

    [JsonPropertyName("unlocked")]
    public bool unlocked { get; set; }
}

public class HousingMeta
{
    [JsonPropertyName("tutorialStep")]
    public string tutorialStep { get; set; }

    [JsonPropertyName("firstHouseJoinMs")]
    public long firstHouseJoinMs { get; set; }

    [JsonPropertyName("allowedBlocks")]
    public List<string> allowedBlocks { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("given_cookies_104989")]
    public List<string> given_cookies_104989 { get; set; }

    [JsonPropertyName("given_cookies_104993")]
    public List<string> given_cookies_104993 { get; set; }

    [JsonPropertyName("given_cookies_104997")]
    public List<string> given_cookies_104997 { get; set; }

    [JsonPropertyName("given_cookies_105052")]
    public List<string> given_cookies_105052 { get; set; }

    [JsonPropertyName("playerSettings")]
    public PlayerSettings playerSettings { get; set; }

    [JsonPropertyName("plotSize")]
    public string plotSize { get; set; }

    [JsonPropertyName("given_cookies_105053")]
    public List<string> given_cookies_105053 { get; set; }

    [JsonPropertyName("given_cookies_105112")]
    public List<string> given_cookies_105112 { get; set; }

    [JsonPropertyName("given_cookies_105159")]
    public List<string> given_cookies_105159 { get; set; }
}

public class HUNGER
{
    [JsonPropertyName("timestamp")]
    public long timestamp { get; set; }

    [JsonPropertyName("value")]
    public float value { get; set; }
}

public class HungerGames
{
    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("inGamePresentsCap_2018_9")]
    public float inGamePresentsCap_2018_9 { get; set; }

    [JsonPropertyName("chests_opened_knight")]
    public float chests_opened_knight { get; set; }

    [JsonPropertyName("potions_drunk")]
    public float potions_drunk { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("arrows_fired")]
    public float arrows_fired { get; set; }

    [JsonPropertyName("damage")]
    public float damage { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("arrows_fired_knight")]
    public float arrows_fired_knight { get; set; }

    [JsonPropertyName("time_played")]
    public float time_played { get; set; }

    [JsonPropertyName("time_played_knight")]
    public float time_played_knight { get; set; }

    [JsonPropertyName("damage_knight")]
    public float damage_knight { get; set; }

    [JsonPropertyName("chests_opened")]
    public float chests_opened { get; set; }

    [JsonPropertyName("damage_taken_knight")]
    public float damage_taken_knight { get; set; }

    [JsonPropertyName("damage_taken")]
    public float damage_taken { get; set; }

    [JsonPropertyName("potions_drunk_knight")]
    public float potions_drunk_knight { get; set; }

    [JsonPropertyName("games_played_knight")]
    public float games_played_knight { get; set; }

    [JsonPropertyName("games_played")]
    public float games_played { get; set; }

    [JsonPropertyName("damage_archer")]
    public float damage_archer { get; set; }

    [JsonPropertyName("damage_taken_archer")]
    public float damage_taken_archer { get; set; }

    [JsonPropertyName("games_played_archer")]
    public float games_played_archer { get; set; }

    [JsonPropertyName("time_played_archer")]
    public float time_played_archer { get; set; }

    [JsonPropertyName("damage_taken_fisherman")]
    public float damage_taken_fisherman { get; set; }

    [JsonPropertyName("games_played_fisherman")]
    public float games_played_fisherman { get; set; }

    [JsonPropertyName("chests_opened_fisherman")]
    public float chests_opened_fisherman { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("kills_fisherman")]
    public float kills_fisherman { get; set; }

    [JsonPropertyName("damage_fisherman")]
    public float damage_fisherman { get; set; }

    [JsonPropertyName("time_played_fisherman")]
    public float time_played_fisherman { get; set; }

    [JsonPropertyName("potions_thrown")]
    public float potions_thrown { get; set; }

    [JsonPropertyName("arrows_hit_random")]
    public float arrows_hit_random { get; set; }

    [JsonPropertyName("damage_taken_random")]
    public float damage_taken_random { get; set; }

    [JsonPropertyName("games_played_random")]
    public float games_played_random { get; set; }

    [JsonPropertyName("arrows_hit")]
    public float arrows_hit { get; set; }

    [JsonPropertyName("time_played_random")]
    public float time_played_random { get; set; }

    [JsonPropertyName("chests_opened_random")]
    public float chests_opened_random { get; set; }

    [JsonPropertyName("potions_thrown_random")]
    public float potions_thrown_random { get; set; }

    [JsonPropertyName("damage_random")]
    public float damage_random { get; set; }

    [JsonPropertyName("potions_thrown_knight")]
    public float potions_thrown_knight { get; set; }

    [JsonPropertyName("damage_taken_scout")]
    public float damage_taken_scout { get; set; }

    [JsonPropertyName("arrows_fired_scout")]
    public float arrows_fired_scout { get; set; }

    [JsonPropertyName("damage_scout")]
    public float damage_scout { get; set; }

    [JsonPropertyName("time_played_scout")]
    public float time_played_scout { get; set; }

    [JsonPropertyName("chests_opened_scout")]
    public float chests_opened_scout { get; set; }

    [JsonPropertyName("games_played_scout")]
    public float games_played_scout { get; set; }

    [JsonPropertyName("lastTourneyAd")]
    public long lastTourneyAd { get; set; }

    [JsonPropertyName("wins_teams_normal")]
    public float wins_teams_normal { get; set; }

    [JsonPropertyName("wins_solo_normal")]
    public float wins_solo_normal { get; set; }

    [JsonPropertyName("wins")]
    public float wins { get; set; }

    [JsonPropertyName("wins_backup")]
    public float wins_backup { get; set; }

    [JsonPropertyName("autoarmor")]
    public bool autoarmor { get; set; }

    [JsonPropertyName("exp_knight")]
    public float exp_knight { get; set; }

    [JsonPropertyName("arrows_fired_archer")]
    public float arrows_fired_archer { get; set; }

    [JsonPropertyName("chests_opened_archer")]
    public float chests_opened_archer { get; set; }
}

public class Insane
{
    [JsonPropertyName("3")]
    public string _3 { get; set; }

    [JsonPropertyName("4")]
    public string _4 { get; set; }

    [JsonPropertyName("5")]
    public string _5 { get; set; }
}

public class InvArmor
{
    [JsonPropertyName("type")]
    public float type { get; set; }

    [JsonPropertyName("data")]
    public List<int> data { get; set; }
}

public class InvContents
{
    [JsonPropertyName("type")]
    public float type { get; set; }

    [JsonPropertyName("data")]
    public List<int> data { get; set; }
}

public class InvEnderchest
{
    [JsonPropertyName("type")]
    public float type { get; set; }

    [JsonPropertyName("data")]
    public List<int> data { get; set; }
}

public class Item
{
    [JsonPropertyName("slumber_item_bed_sheets")]
    public float slumber_item_bed_sheets { get; set; }

    [JsonPropertyName("slumber_item_perfume")]
    public float slumber_item_perfume { get; set; }

    [JsonPropertyName("slumber_item_ender_dust")]
    public float slumber_item_ender_dust { get; set; }
}

public class ItemsLastBuy
{
    [JsonPropertyName("diamond_sword")]
    public long diamond_sword { get; set; }
}

public class ItemStash
{
    [JsonPropertyName("type")]
    public float type { get; set; }

    [JsonPropertyName("data")]
    public List<int> data { get; set; }
}

public class KingQuest
{
    [JsonPropertyName("kills")]
    public float kills { get; set; }
}

public class LastCompleted
{
    [JsonPropertyName("npc_reception_start")]
    public long npc_reception_start { get; set; }

    [JsonPropertyName("npc_lady_saichi")]
    public long npc_lady_saichi { get; set; }
}

public class LastStarted
{
    [JsonPropertyName("npc_reception_start")]
    public long npc_reception_start { get; set; }

    [JsonPropertyName("npc_lady_saichi")]
    public long npc_lady_saichi { get; set; }

    [JsonPropertyName("npc_general_daku")]
    public long npc_general_daku { get; set; }

    [JsonPropertyName("npc_john_pireso")]
    public long npc_john_pireso { get; set; }
}

public class LeaderboardStats
{
    [JsonPropertyName("Pit_rage_pit_damage_2021_spring")]
    public float Pit_rage_pit_damage_2021_spring { get; set; }

    [JsonPropertyName("Pit_kotl_gold_2020_winter")]
    public float Pit_kotl_gold_2020_winter { get; set; }

    [JsonPropertyName("Pit_cake_eaten_2020_winter")]
    public float Pit_cake_eaten_2020_winter { get; set; }

    [JsonPropertyName("Pit_kotl_gold_2021_spring")]
    public float Pit_kotl_gold_2021_spring { get; set; }

    [JsonPropertyName("Pit_blockhead_blocks_2020_winter")]
    public float Pit_blockhead_blocks_2020_winter { get; set; }

    [JsonPropertyName("Pit_kotl_time_2020_winter")]
    public float Pit_kotl_time_2020_winter { get; set; }

    [JsonPropertyName("Pit_kotl_time_2021_spring")]
    public float Pit_kotl_time_2021_spring { get; set; }
}

public class Legacy
{
    [JsonPropertyName("next_tokens_seconds")]
    public float next_tokens_seconds { get; set; }

    [JsonPropertyName("paintball_tokens")]
    public float paintball_tokens { get; set; }

    [JsonPropertyName("tokens")]
    public float tokens { get; set; }

    [JsonPropertyName("total_tokens")]
    public float total_tokens { get; set; }

    [JsonPropertyName("walls_tokens")]
    public float walls_tokens { get; set; }

    [JsonPropertyName("vampirez_tokens")]
    public float vampirez_tokens { get; set; }
}

public class Leveling
{
    [JsonPropertyName("claimedRewards")]
    public List<int> claimedRewards { get; set; }
}

public class Levelling
{
    [JsonPropertyName("experience")]
    public float experience { get; set; }
}

public class Links
{
    [JsonPropertyName("DISCORD")]
    public string DISCORD { get; set; }
}

public class MainLobby
{
    [JsonPropertyName("questNPCTutorials")]
    public QuestNPCTutorials questNPCTutorials { get; set; }

    [JsonPropertyName("discoveredZones")]
    public DiscoveredZones discoveredZones { get; set; }
}

public class MCGO
{
    [JsonPropertyName("kills_deathmatch")]
    public float kills_deathmatch { get; set; }

    [JsonPropertyName("headshot_kills")]
    public float headshot_kills { get; set; }

    [JsonPropertyName("grenade_kills")]
    public float grenade_kills { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("bombs_planted")]
    public float bombs_planted { get; set; }

    [JsonPropertyName("game_wins_deathmatch")]
    public float game_wins_deathmatch { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("grenadeKills")]
    public float grenadeKills { get; set; }

    [JsonPropertyName("game_wins")]
    public float game_wins { get; set; }

    [JsonPropertyName("pocket_change")]
    public float pocket_change { get; set; }

    [JsonPropertyName("bombs_defused")]
    public float bombs_defused { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("shots_fired")]
    public float shots_fired { get; set; }

    [JsonPropertyName("lastTourneyAd")]
    public long lastTourneyAd { get; set; }

    [JsonPropertyName("deaths_deathmatch")]
    public float deaths_deathmatch { get; set; }

    [JsonPropertyName("carbineKills")]
    public float carbineKills { get; set; }

    [JsonPropertyName("carbineHeadshots")]
    public float carbineHeadshots { get; set; }

    [JsonPropertyName("autoShotgunKills")]
    public float autoShotgunKills { get; set; }

    [JsonPropertyName("autoShotgunHeadshots")]
    public float autoShotgunHeadshots { get; set; }

    [JsonPropertyName("assists_deathmatch")]
    public float assists_deathmatch { get; set; }

    [JsonPropertyName("criminal_kills_deathmatch")]
    public float criminal_kills_deathmatch { get; set; }

    [JsonPropertyName("game_plays_deathmatch")]
    public float game_plays_deathmatch { get; set; }

    [JsonPropertyName("pistolKills")]
    public float pistolKills { get; set; }

    [JsonPropertyName("shotgunHeadshots")]
    public float shotgunHeadshots { get; set; }

    [JsonPropertyName("scopedRifleHeadshots")]
    public float scopedRifleHeadshots { get; set; }

    [JsonPropertyName("handgunKills")]
    public float handgunKills { get; set; }

    [JsonPropertyName("kills_gungame")]
    public float kills_gungame { get; set; }

    [JsonPropertyName("game_wins_gungame")]
    public float game_wins_gungame { get; set; }
}

public class MegaWallsFaithful
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MegaWallsKill
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MegaWallsPlay
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MegaWallsWeekly
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MegaWallsWin
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class Melee
{
    [JsonPropertyName("kills_normal")]
    public float kills_normal { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("damage_dealt_normal")]
    public float damage_dealt_normal { get; set; }

    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("damage_dealt_2v2")]
    public float damage_dealt_2v2 { get; set; }
}

public class Mlg
{
    [JsonPropertyName("successful_attempts")]
    public float successful_attempts { get; set; }

    [JsonPropertyName("failed_attempts")]
    public float failed_attempts { get; set; }

    [JsonPropertyName("blocks_placed")]
    public float blocks_placed { get; set; }
}

public class MmDailyInfector
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MmDailyPowerPlay
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MmDailyTargetKill
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MmDailyWin
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MmWeeklyMurdererKills
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MmWeeklyWins
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class MonsterCharge
{
    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("damage_dealt_normal")]
    public float damage_dealt_normal { get; set; }
}



public class MurderMystery
{
    [JsonPropertyName("murdermystery_books")]
    public List<string> murdermystery_books { get; set; }

    [JsonPropertyName("wins")]
    public float wins { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("was_hero")]
    public float was_hero { get; set; }

    [JsonPropertyName("games_darkfall_MURDER_CLASSIC")]
    public float games_darkfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games")]
    public float games { get; set; }

    [JsonPropertyName("bow_kills_MURDER_CLASSIC")]
    public float bow_kills_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("was_hero_MURDER_CLASSIC")]
    public float was_hero_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("was_hero_darkfall_MURDER_CLASSIC")]
    public float was_hero_darkfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_MURDER_CLASSIC")]
    public float kills_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_darkfall")]
    public float games_darkfall { get; set; }

    [JsonPropertyName("wins_MURDER_CLASSIC")]
    public float wins_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_MURDER_CLASSIC")]
    public float coins_pickedup_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_darkfall_MURDER_CLASSIC")]
    public float kills_darkfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("bow_kills_darkfall")]
    public float bow_kills_darkfall { get; set; }

    [JsonPropertyName("kills_darkfall")]
    public float kills_darkfall { get; set; }

    [JsonPropertyName("bow_kills")]
    public float bow_kills { get; set; }

    [JsonPropertyName("wins_darkfall_MURDER_CLASSIC")]
    public float wins_darkfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_darkfall")]
    public float wins_darkfall { get; set; }

    [JsonPropertyName("was_hero_darkfall")]
    public float was_hero_darkfall { get; set; }

    [JsonPropertyName("coins_pickedup_darkfall_MURDER_CLASSIC")]
    public float coins_pickedup_darkfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("games_MURDER_CLASSIC")]
    public float games_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup")]
    public float coins_pickedup { get; set; }

    [JsonPropertyName("bow_kills_darkfall_MURDER_CLASSIC")]
    public float bow_kills_darkfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_darkfall")]
    public float coins_pickedup_darkfall { get; set; }

    [JsonPropertyName("detective_chance")]
    public float detective_chance { get; set; }

    [JsonPropertyName("murderer_chance")]
    public float murderer_chance { get; set; }

    [JsonPropertyName("showqueuebook")]
    public bool showqueuebook { get; set; }

    [JsonPropertyName("granted_chests")]
    public float granted_chests { get; set; }

    [JsonPropertyName("mm_chests")]
    public float mm_chests { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("MurderMystery_openedChests")]
    public float MurderMystery_openedChests { get; set; }

    [JsonPropertyName("MurderMystery_openedCommons")]
    public float MurderMystery_openedCommons { get; set; }

    [JsonPropertyName("chest_history_new")]
    public List<string> chest_history_new { get; set; }

    [JsonPropertyName("MurderMystery_openedRares")]
    public float MurderMystery_openedRares { get; set; }

    [JsonPropertyName("active_victory_dance")]
    public string active_victory_dance { get; set; }

    [JsonPropertyName("active_projectile_trail")]
    public string active_projectile_trail { get; set; }

    [JsonPropertyName("wins_transport")]
    public float wins_transport { get; set; }

    [JsonPropertyName("coins_pickedup_transport")]
    public float coins_pickedup_transport { get; set; }

    [JsonPropertyName("wins_transport_MURDER_CLASSIC")]
    public float wins_transport_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_transport_MURDER_CLASSIC")]
    public float games_transport_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_transport")]
    public float games_transport { get; set; }

    [JsonPropertyName("coins_pickedup_transport_MURDER_CLASSIC")]
    public float coins_pickedup_transport_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("knife_kills_snowfall")]
    public float knife_kills_snowfall { get; set; }

    [JsonPropertyName("knife_kills_snowfall_MURDER_CLASSIC")]
    public float knife_kills_snowfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("knife_kills_MURDER_CLASSIC")]
    public float knife_kills_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_snowfall_MURDER_CLASSIC")]
    public float games_snowfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_as_murderer_snowfall")]
    public float kills_as_murderer_snowfall { get; set; }

    [JsonPropertyName("kills_as_murderer_snowfall_MURDER_CLASSIC")]
    public float kills_as_murderer_snowfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_snowfall_MURDER_CLASSIC")]
    public float kills_snowfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_snowfall")]
    public float games_snowfall { get; set; }

    [JsonPropertyName("kills_snowfall")]
    public float kills_snowfall { get; set; }

    [JsonPropertyName("kills_as_murderer_MURDER_CLASSIC")]
    public float kills_as_murderer_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("bow_kills_snowfall_MURDER_CLASSIC")]
    public float bow_kills_snowfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_snowfall_MURDER_CLASSIC")]
    public float coins_pickedup_snowfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_as_murderer")]
    public float kills_as_murderer { get; set; }

    [JsonPropertyName("knife_kills")]
    public float knife_kills { get; set; }

    [JsonPropertyName("coins_pickedup_snowfall")]
    public float coins_pickedup_snowfall { get; set; }

    [JsonPropertyName("bow_kills_snowfall")]
    public float bow_kills_snowfall { get; set; }

    [JsonPropertyName("games_ancient_tomb")]
    public float games_ancient_tomb { get; set; }

    [JsonPropertyName("games_ancient_tomb_MURDER_CLASSIC")]
    public float games_ancient_tomb_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_ancient_tomb_MURDER_CLASSIC")]
    public float wins_ancient_tomb_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_ancient_tomb_MURDER_CLASSIC")]
    public float coins_pickedup_ancient_tomb_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("deaths_ancient_tomb_MURDER_CLASSIC")]
    public float deaths_ancient_tomb_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("deaths_ancient_tomb")]
    public float deaths_ancient_tomb { get; set; }

    [JsonPropertyName("coins_pickedup_ancient_tomb")]
    public float coins_pickedup_ancient_tomb { get; set; }

    [JsonPropertyName("deaths_MURDER_CLASSIC")]
    public float deaths_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_ancient_tomb")]
    public float wins_ancient_tomb { get; set; }

    [JsonPropertyName("coins_pickedup_hypixel_world")]
    public float coins_pickedup_hypixel_world { get; set; }

    [JsonPropertyName("coins_pickedup_hypixel_world_MURDER_CLASSIC")]
    public float coins_pickedup_hypixel_world_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_hypixel_world")]
    public float games_hypixel_world { get; set; }

    [JsonPropertyName("games_hypixel_world_MURDER_CLASSIC")]
    public float games_hypixel_world_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_hypixel_world")]
    public float wins_hypixel_world { get; set; }

    [JsonPropertyName("wins_hypixel_world_MURDER_CLASSIC")]
    public float wins_hypixel_world_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_archives_top_floor")]
    public float coins_pickedup_archives_top_floor { get; set; }

    [JsonPropertyName("coins_pickedup_archives_top_floor_MURDER_CLASSIC")]
    public float coins_pickedup_archives_top_floor_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("deaths_archives_top_floor")]
    public float deaths_archives_top_floor { get; set; }

    [JsonPropertyName("deaths_archives_top_floor_MURDER_CLASSIC")]
    public float deaths_archives_top_floor_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_archives_top_floor")]
    public float games_archives_top_floor { get; set; }

    [JsonPropertyName("games_archives_top_floor_MURDER_CLASSIC")]
    public float games_archives_top_floor_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_archives_top_floor")]
    public float kills_archives_top_floor { get; set; }

    [JsonPropertyName("kills_archives_top_floor_MURDER_CLASSIC")]
    public float kills_archives_top_floor_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_as_murderer_archives_top_floor")]
    public float kills_as_murderer_archives_top_floor { get; set; }

    [JsonPropertyName("kills_as_murderer_archives_top_floor_MURDER_CLASSIC")]
    public float kills_as_murderer_archives_top_floor_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("knife_kills_archives_top_floor")]
    public float knife_kills_archives_top_floor { get; set; }

    [JsonPropertyName("knife_kills_archives_top_floor_MURDER_CLASSIC")]
    public float knife_kills_archives_top_floor_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_hollywood")]
    public float coins_pickedup_hollywood { get; set; }

    [JsonPropertyName("coins_pickedup_hollywood_MURDER_CLASSIC")]
    public float coins_pickedup_hollywood_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_hollywood")]
    public float games_hollywood { get; set; }

    [JsonPropertyName("games_hollywood_MURDER_CLASSIC")]
    public float games_hollywood_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_hollywood")]
    public float wins_hollywood { get; set; }

    [JsonPropertyName("wins_hollywood_MURDER_CLASSIC")]
    public float wins_hollywood_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_aquarium")]
    public float coins_pickedup_aquarium { get; set; }

    [JsonPropertyName("coins_pickedup_aquarium_MURDER_CLASSIC")]
    public float coins_pickedup_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("deaths_aquarium")]
    public float deaths_aquarium { get; set; }

    [JsonPropertyName("deaths_aquarium_MURDER_CLASSIC")]
    public float deaths_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_aquarium")]
    public float games_aquarium { get; set; }

    [JsonPropertyName("games_aquarium_MURDER_CLASSIC")]
    public float games_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_aquarium")]
    public float wins_aquarium { get; set; }

    [JsonPropertyName("wins_aquarium_MURDER_CLASSIC")]
    public float wins_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_towerfall")]
    public float coins_pickedup_towerfall { get; set; }

    [JsonPropertyName("coins_pickedup_towerfall_MURDER_CLASSIC")]
    public float coins_pickedup_towerfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("deaths_towerfall")]
    public float deaths_towerfall { get; set; }

    [JsonPropertyName("deaths_towerfall_MURDER_CLASSIC")]
    public float deaths_towerfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_towerfall")]
    public float games_towerfall { get; set; }

    [JsonPropertyName("games_towerfall_MURDER_CLASSIC")]
    public float games_towerfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_as_murderer_towerfall")]
    public float kills_as_murderer_towerfall { get; set; }

    [JsonPropertyName("kills_as_murderer_towerfall_MURDER_CLASSIC")]
    public float kills_as_murderer_towerfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_towerfall")]
    public float kills_towerfall { get; set; }

    [JsonPropertyName("kills_towerfall_MURDER_CLASSIC")]
    public float kills_towerfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("knife_kills_towerfall")]
    public float knife_kills_towerfall { get; set; }

    [JsonPropertyName("knife_kills_towerfall_MURDER_CLASSIC")]
    public float knife_kills_towerfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_cruise_ship")]
    public float coins_pickedup_cruise_ship { get; set; }

    [JsonPropertyName("coins_pickedup_cruise_ship_MURDER_CLASSIC")]
    public float coins_pickedup_cruise_ship_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_cruise_ship")]
    public float games_cruise_ship { get; set; }

    [JsonPropertyName("games_cruise_ship_MURDER_CLASSIC")]
    public float games_cruise_ship_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_cruise_ship")]
    public float wins_cruise_ship { get; set; }

    [JsonPropertyName("wins_cruise_ship_MURDER_CLASSIC")]
    public float wins_cruise_ship_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_archives_top_floor")]
    public float wins_archives_top_floor { get; set; }

    [JsonPropertyName("wins_archives_top_floor_MURDER_CLASSIC")]
    public float wins_archives_top_floor_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_mountain")]
    public float coins_pickedup_mountain { get; set; }

    [JsonPropertyName("coins_pickedup_mountain_MURDER_CLASSIC")]
    public float coins_pickedup_mountain_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("deaths_mountain")]
    public float deaths_mountain { get; set; }

    [JsonPropertyName("deaths_mountain_MURDER_CLASSIC")]
    public float deaths_mountain_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_mountain")]
    public float games_mountain { get; set; }

    [JsonPropertyName("games_mountain_MURDER_CLASSIC")]
    public float games_mountain_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_mountain")]
    public float wins_mountain { get; set; }

    [JsonPropertyName("wins_mountain_MURDER_CLASSIC")]
    public float wins_mountain_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_archives")]
    public float coins_pickedup_archives { get; set; }

    [JsonPropertyName("coins_pickedup_archives_MURDER_CLASSIC")]
    public float coins_pickedup_archives_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_archives")]
    public float games_archives { get; set; }

    [JsonPropertyName("games_archives_MURDER_CLASSIC")]
    public float games_archives_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_archives")]
    public float wins_archives { get; set; }

    [JsonPropertyName("wins_archives_MURDER_CLASSIC")]
    public float wins_archives_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_gold_rush")]
    public float coins_pickedup_gold_rush { get; set; }

    [JsonPropertyName("coins_pickedup_gold_rush_MURDER_CLASSIC")]
    public float coins_pickedup_gold_rush_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_gold_rush")]
    public float games_gold_rush { get; set; }

    [JsonPropertyName("games_gold_rush_MURDER_CLASSIC")]
    public float games_gold_rush_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_gold_rush")]
    public float wins_gold_rush { get; set; }

    [JsonPropertyName("wins_gold_rush_MURDER_CLASSIC")]
    public float wins_gold_rush_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_library")]
    public float coins_pickedup_library { get; set; }

    [JsonPropertyName("coins_pickedup_library_MURDER_CLASSIC")]
    public float coins_pickedup_library_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_library")]
    public float games_library { get; set; }

    [JsonPropertyName("games_library_MURDER_CLASSIC")]
    public float games_library_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_library")]
    public float wins_library { get; set; }

    [JsonPropertyName("wins_library_MURDER_CLASSIC")]
    public float wins_library_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_as_murderer_mountain")]
    public float kills_as_murderer_mountain { get; set; }

    [JsonPropertyName("kills_as_murderer_mountain_MURDER_CLASSIC")]
    public float kills_as_murderer_mountain_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_mountain")]
    public float kills_mountain { get; set; }

    [JsonPropertyName("kills_mountain_MURDER_CLASSIC")]
    public float kills_mountain_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("knife_kills_mountain")]
    public float knife_kills_mountain { get; set; }

    [JsonPropertyName("knife_kills_mountain_MURDER_CLASSIC")]
    public float knife_kills_mountain_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("deaths_library")]
    public float deaths_library { get; set; }

    [JsonPropertyName("deaths_library_MURDER_CLASSIC")]
    public float deaths_library_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_headquarters")]
    public float coins_pickedup_headquarters { get; set; }

    [JsonPropertyName("coins_pickedup_headquarters_MURDER_CLASSIC")]
    public float coins_pickedup_headquarters_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_headquarters")]
    public float games_headquarters { get; set; }

    [JsonPropertyName("games_headquarters_MURDER_CLASSIC")]
    public float games_headquarters_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_headquarters")]
    public float wins_headquarters { get; set; }

    [JsonPropertyName("wins_headquarters_MURDER_CLASSIC")]
    public float wins_headquarters_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("detective_wins")]
    public float detective_wins { get; set; }

    [JsonPropertyName("detective_wins_MURDER_CLASSIC")]
    public float detective_wins_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("detective_wins_hypixel_world")]
    public float detective_wins_hypixel_world { get; set; }

    [JsonPropertyName("detective_wins_hypixel_world_MURDER_CLASSIC")]
    public float detective_wins_hypixel_world_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("quickest_detective_win_time_seconds")]
    public float quickest_detective_win_time_seconds { get; set; }

    [JsonPropertyName("quickest_detective_win_time_seconds_MURDER_CLASSIC")]
    public float quickest_detective_win_time_seconds_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("quickest_detective_win_time_seconds_hypixel_world")]
    public float quickest_detective_win_time_seconds_hypixel_world { get; set; }

    [JsonPropertyName("quickest_detective_win_time_seconds_hypixel_world_MURDER_CLASSIC")]
    public float quickest_detective_win_time_seconds_hypixel_world_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_towerfall")]
    public float wins_towerfall { get; set; }

    [JsonPropertyName("wins_towerfall_MURDER_CLASSIC")]
    public float wins_towerfall_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_aquarium")]
    public float kills_aquarium { get; set; }

    [JsonPropertyName("kills_aquarium_MURDER_CLASSIC")]
    public float kills_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_as_murderer_aquarium")]
    public float kills_as_murderer_aquarium { get; set; }

    [JsonPropertyName("kills_as_murderer_aquarium_MURDER_CLASSIC")]
    public float kills_as_murderer_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("knife_kills_aquarium")]
    public float knife_kills_aquarium { get; set; }

    [JsonPropertyName("knife_kills_aquarium_MURDER_CLASSIC")]
    public float knife_kills_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("murderer_wins")]
    public float murderer_wins { get; set; }

    [JsonPropertyName("murderer_wins_MURDER_CLASSIC")]
    public float murderer_wins_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("murderer_wins_aquarium")]
    public float murderer_wins_aquarium { get; set; }

    [JsonPropertyName("murderer_wins_aquarium_MURDER_CLASSIC")]
    public float murderer_wins_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("quickest_murderer_win_time_seconds")]
    public float quickest_murderer_win_time_seconds { get; set; }

    [JsonPropertyName("quickest_murderer_win_time_seconds_MURDER_CLASSIC")]
    public float quickest_murderer_win_time_seconds_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("quickest_murderer_win_time_seconds_aquarium")]
    public float quickest_murderer_win_time_seconds_aquarium { get; set; }

    [JsonPropertyName("quickest_murderer_win_time_seconds_aquarium_MURDER_CLASSIC")]
    public float quickest_murderer_win_time_seconds_aquarium_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_subway")]
    public float coins_pickedup_subway { get; set; }

    [JsonPropertyName("coins_pickedup_subway_MURDER_CLASSIC")]
    public float coins_pickedup_subway_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("detective_wins_subway")]
    public float detective_wins_subway { get; set; }

    [JsonPropertyName("detective_wins_subway_MURDER_CLASSIC")]
    public float detective_wins_subway_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_subway")]
    public float games_subway { get; set; }

    [JsonPropertyName("games_subway_MURDER_CLASSIC")]
    public float games_subway_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("quickest_detective_win_time_seconds_subway")]
    public float quickest_detective_win_time_seconds_subway { get; set; }

    [JsonPropertyName("quickest_detective_win_time_seconds_subway_MURDER_CLASSIC")]
    public float quickest_detective_win_time_seconds_subway_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_subway")]
    public float wins_subway { get; set; }

    [JsonPropertyName("wins_subway_MURDER_CLASSIC")]
    public float wins_subway_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("coins_pickedup_villa")]
    public float coins_pickedup_villa { get; set; }

    [JsonPropertyName("coins_pickedup_villa_MURDER_CLASSIC")]
    public float coins_pickedup_villa_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("games_villa")]
    public float games_villa { get; set; }

    [JsonPropertyName("games_villa_MURDER_CLASSIC")]
    public float games_villa_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("wins_villa")]
    public float wins_villa { get; set; }

    [JsonPropertyName("wins_villa_MURDER_CLASSIC")]
    public float wins_villa_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("deaths_villa")]
    public float deaths_villa { get; set; }

    [JsonPropertyName("deaths_villa_MURDER_CLASSIC")]
    public float deaths_villa_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_as_murderer_villa")]
    public float kills_as_murderer_villa { get; set; }

    [JsonPropertyName("kills_as_murderer_villa_MURDER_CLASSIC")]
    public float kills_as_murderer_villa_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("kills_villa")]
    public float kills_villa { get; set; }

    [JsonPropertyName("kills_villa_MURDER_CLASSIC")]
    public float kills_villa_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("knife_kills_villa")]
    public float knife_kills_villa { get; set; }

    [JsonPropertyName("knife_kills_villa_MURDER_CLASSIC")]
    public float knife_kills_villa_MURDER_CLASSIC { get; set; }

    [JsonPropertyName("alpha_chance")]
    public float alpha_chance { get; set; }

    [JsonPropertyName("coins_pickedup_MURDER_INFECTION")]
    public float coins_pickedup_MURDER_INFECTION { get; set; }

    [JsonPropertyName("coins_pickedup_widow's_den")]
    public float coins_pickedup_widows_den { get; set; }

    [JsonPropertyName("coins_pickedup_widow's_den_MURDER_INFECTION")]
    public float coins_pickedup_widows_den_MURDER_INFECTION { get; set; }

    [JsonPropertyName("games_MURDER_INFECTION")]
    public float games_MURDER_INFECTION { get; set; }

    [JsonPropertyName("games_widow's_den")]
    public float games_widows_den { get; set; }

    [JsonPropertyName("games_widow's_den_MURDER_INFECTION")]
    public float games_widows_den_MURDER_INFECTION { get; set; }

    [JsonPropertyName("longest_time_as_survivor_seconds")]
    public float longest_time_as_survivor_seconds { get; set; }

    [JsonPropertyName("longest_time_as_survivor_seconds_MURDER_INFECTION")]
    public float longest_time_as_survivor_seconds_MURDER_INFECTION { get; set; }

    [JsonPropertyName("longest_time_as_survivor_seconds_widow's_den")]
    public float longest_time_as_survivor_seconds_widows_den { get; set; }

    [JsonPropertyName("longest_time_as_survivor_seconds_widow's_den_MURDER_INFECTION")]
    public float longest_time_as_survivor_seconds_widows_den_MURDER_INFECTION { get; set; }

    [JsonPropertyName("total_time_survived_seconds")]
    public float total_time_survived_seconds { get; set; }

    [JsonPropertyName("total_time_survived_seconds_MURDER_INFECTION")]
    public float total_time_survived_seconds_MURDER_INFECTION { get; set; }

    [JsonPropertyName("total_time_survived_seconds_widow's_den")]
    public float total_time_survived_seconds_widows_den { get; set; }

    [JsonPropertyName("total_time_survived_seconds_widow's_den_MURDER_INFECTION")]
    public float total_time_survived_seconds_widows_den_MURDER_INFECTION { get; set; }

    [JsonPropertyName("coins_pickedup_transport_MURDER_INFECTION")]
    public float coins_pickedup_transport_MURDER_INFECTION { get; set; }

    [JsonPropertyName("games_transport_MURDER_INFECTION")]
    public float games_transport_MURDER_INFECTION { get; set; }

    [JsonPropertyName("longest_time_as_survivor_seconds_transport")]
    public float longest_time_as_survivor_seconds_transport { get; set; }

    [JsonPropertyName("longest_time_as_survivor_seconds_transport_MURDER_INFECTION")]
    public float longest_time_as_survivor_seconds_transport_MURDER_INFECTION { get; set; }

    [JsonPropertyName("total_time_survived_seconds_transport")]
    public float total_time_survived_seconds_transport { get; set; }

    [JsonPropertyName("total_time_survived_seconds_transport_MURDER_INFECTION")]
    public float total_time_survived_seconds_transport_MURDER_INFECTION { get; set; }

    [JsonPropertyName("coins_pickedup_ancient_tomb_MURDER_INFECTION")]
    public float coins_pickedup_ancient_tomb_MURDER_INFECTION { get; set; }

    [JsonPropertyName("games_ancient_tomb_MURDER_INFECTION")]
    public float games_ancient_tomb_MURDER_INFECTION { get; set; }

    [JsonPropertyName("total_time_survived_seconds_ancient_tomb")]
    public float total_time_survived_seconds_ancient_tomb { get; set; }

    [JsonPropertyName("total_time_survived_seconds_ancient_tomb_MURDER_INFECTION")]
    public float total_time_survived_seconds_ancient_tomb_MURDER_INFECTION { get; set; }

    [JsonPropertyName("deaths_MURDER_INFECTION")]
    public float deaths_MURDER_INFECTION { get; set; }

    [JsonPropertyName("deaths_widow's_den")]
    public float deaths_widows_den { get; set; }

    [JsonPropertyName("deaths_widow's_den_MURDER_INFECTION")]
    public float deaths_widows_den_MURDER_INFECTION { get; set; }

    [JsonPropertyName("kills_as_survivor")]
    public float kills_as_survivor { get; set; }

    [JsonPropertyName("kills_as_survivor_MURDER_INFECTION")]
    public float kills_as_survivor_MURDER_INFECTION { get; set; }

    [JsonPropertyName("kills_as_survivor_widow's_den")]
    public float kills_as_survivor_widows_den { get; set; }

    [JsonPropertyName("kills_as_survivor_widow's_den_MURDER_INFECTION")]
    public float kills_as_survivor_widows_den_MURDER_INFECTION { get; set; }

    [JsonPropertyName("survivor_wins")]
    public float survivor_wins { get; set; }

    [JsonPropertyName("survivor_wins_MURDER_INFECTION")]
    public float survivor_wins_MURDER_INFECTION { get; set; }

    [JsonPropertyName("survivor_wins_widow's_den")]
    public float survivor_wins_widows_den { get; set; }

    [JsonPropertyName("survivor_wins_widow's_den_MURDER_INFECTION")]
    public float survivor_wins_widows_den_MURDER_INFECTION { get; set; }

    [JsonPropertyName("wins_MURDER_INFECTION")]
    public float wins_MURDER_INFECTION { get; set; }

    [JsonPropertyName("wins_widow's_den")]
    public float wins_widows_den { get; set; }

    [JsonPropertyName("wins_widow's_den_MURDER_INFECTION")]
    public float wins_widows_den_MURDER_INFECTION { get; set; }

    [JsonPropertyName("games_hollywood_MURDER_INFECTION")]
    public float games_hollywood_MURDER_INFECTION { get; set; }

    [JsonPropertyName("survivor_wins_hollywood")]
    public float survivor_wins_hollywood { get; set; }

    [JsonPropertyName("survivor_wins_hollywood_MURDER_INFECTION")]
    public float survivor_wins_hollywood_MURDER_INFECTION { get; set; }

    [JsonPropertyName("total_time_survived_seconds_hollywood")]
    public float total_time_survived_seconds_hollywood { get; set; }

    [JsonPropertyName("total_time_survived_seconds_hollywood_MURDER_INFECTION")]
    public float total_time_survived_seconds_hollywood_MURDER_INFECTION { get; set; }

    [JsonPropertyName("wins_hollywood_MURDER_INFECTION")]
    public float wins_hollywood_MURDER_INFECTION { get; set; }

    [JsonPropertyName("mm_christmas_chests")]
    public float mm_christmas_chests { get; set; }
}

public class Normal
{
    [JsonPropertyName("4")]
    public string _4 { get; set; }

    [JsonPropertyName("5")]
    public string _5 { get; set; }

    [JsonPropertyName("3")]
    public string _3 { get; set; }
}

public class Npc
{
    [JsonPropertyName("talk")]
    public Talk talk { get; set; }
}

public class Objective
{
    [JsonPropertyName("receptionist_introduction")]
    public bool receptionist_introduction { get; set; }

    [JsonPropertyName("lady_saichi_mattress")]
    public bool lady_saichi_mattress { get; set; }
}

public class Objectives
{
    [JsonPropertyName("tnt_bowspleef_daily")]
    public float tnt_bowspleef_daily { get; set; }

    [JsonPropertyName("kill")]
    public float kill { get; set; }

    [JsonPropertyName("skywars_weekly_kills")]
    public float skywars_weekly_kills { get; set; }

    [JsonPropertyName("skywars_solo_kills")]
    public float skywars_solo_kills { get; set; }

    [JsonPropertyName("tnt_bowspleef_weekly")]
    public float tnt_bowspleef_weekly { get; set; }

    [JsonPropertyName("tnt_wizards_weekly_kills")]
    public float tnt_wizards_weekly_kills { get; set; }

    [JsonPropertyName("bedwars_bed_elims")]
    public float bedwars_bed_elims { get; set; }

    [JsonPropertyName("bedwars_weekly_final_killer")]
    public float bedwars_weekly_final_killer { get; set; }

    [JsonPropertyName("bedwars_daily_special_christmas_gifts")]
    public float bedwars_daily_special_christmas_gifts { get; set; }

    [JsonPropertyName("tnt_wizards_daily_kills")]
    public float tnt_wizards_daily_kills { get; set; }

    [JsonPropertyName("tnt_weekly_play")]
    public float tnt_weekly_play { get; set; }

    [JsonPropertyName("play")]
    public float play { get; set; }

    [JsonPropertyName("win")]
    public float win { get; set; }

    [JsonPropertyName("skywars_daily_tokens_wins")]
    public float skywars_daily_tokens_wins { get; set; }

    [JsonPropertyName("Bedwarsdiamond")]
    public float Bedwarsdiamond { get; set; }

    [JsonPropertyName("Bedwarseatthis")]
    public float Bedwarseatthis { get; set; }

    [JsonPropertyName("Bedwarssunshining")]
    public float Bedwarssunshining { get; set; }
}

public class Paintball
{
    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("shots_fired")]
    public float shots_fired { get; set; }

    [JsonPropertyName("wins")]
    public float wins { get; set; }

    [JsonPropertyName("showKillPrefix")]
    public bool showKillPrefix { get; set; }

    [JsonPropertyName("favorite_slots")]
    public string favorite_slots { get; set; }
}

public class ParkourCheckpointBests
{
    [JsonPropertyName("Prototype")]
    public Prototype Prototype { get; set; }

    [JsonPropertyName("BedwarsSpring2023")]
    public BedwarsSpring2023 BedwarsSpring2023 { get; set; }
}

public class ParkourCompletions
{
    [JsonPropertyName("Bedwars")]
    public List<Bedwar> Bedwars { get; set; }
}

public class Perkslot
{
    [JsonPropertyName("normal")]
    public Normal normal { get; set; }

    [JsonPropertyName("insane")]
    public Insane insane { get; set; }
}

public class PetConsumables
{
    [JsonPropertyName("CARROT_ITEM")]
    public float CARROT_ITEM { get; set; }

    [JsonPropertyName("COOKIE")]
    public float COOKIE { get; set; }

    [JsonPropertyName("FEATHER")]
    public float FEATHER { get; set; }

    [JsonPropertyName("ROTTEN_FLESH")]
    public float ROTTEN_FLESH { get; set; }

    [JsonPropertyName("SLIME_BALL")]
    public float SLIME_BALL { get; set; }

    [JsonPropertyName("CAKE")]
    public float CAKE { get; set; }

    [JsonPropertyName("RAW_FISH")]
    public float RAW_FISH { get; set; }

    [JsonPropertyName("WATER_BUCKET")]
    public float WATER_BUCKET { get; set; }

    [JsonPropertyName("STICK")]
    public float STICK { get; set; }

    [JsonPropertyName("WOOD_SWORD")]
    public float WOOD_SWORD { get; set; }

    [JsonPropertyName("MILK_BUCKET")]
    public float MILK_BUCKET { get; set; }

    [JsonPropertyName("PORK")]
    public float PORK { get; set; }

    [JsonPropertyName("LEASH")]
    public float LEASH { get; set; }

    [JsonPropertyName("LAVA_BUCKET")]
    public float LAVA_BUCKET { get; set; }

    [JsonPropertyName("BONE")]
    public float BONE { get; set; }

    [JsonPropertyName("MAGMA_CREAM")]
    public float MAGMA_CREAM { get; set; }

    [JsonPropertyName("APPLE")]
    public float APPLE { get; set; }

    [JsonPropertyName("BAKED_POTATO")]
    public float BAKED_POTATO { get; set; }

    [JsonPropertyName("HAY_BLOCK")]
    public float HAY_BLOCK { get; set; }

    [JsonPropertyName("BREAD")]
    public float BREAD { get; set; }

    [JsonPropertyName("COOKED_BEEF")]
    public float COOKED_BEEF { get; set; }

    [JsonPropertyName("MELON")]
    public float MELON { get; set; }

    [JsonPropertyName("GOLD_RECORD")]
    public float GOLD_RECORD { get; set; }

    [JsonPropertyName("RED_ROSE")]
    public float RED_ROSE { get; set; }

    [JsonPropertyName("WHEAT")]
    public float WHEAT { get; set; }

    [JsonPropertyName("PUMPKIN_PIE")]
    public float PUMPKIN_PIE { get; set; }

    [JsonPropertyName("MUSHROOM_SOUP")]
    public float MUSHROOM_SOUP { get; set; }
}

public class PetStats
{
    [JsonPropertyName("CAT_BLACK")]
    public CATBLACK CAT_BLACK { get; set; }
}

public class Pit
{
    [JsonPropertyName("profile")]
    public Profile profile { get; set; }

    [JsonPropertyName("pit_stats_ptl")]
    public PitStatsPtl pit_stats_ptl { get; set; }

    [JsonPropertyName("stats_move_1")]
    public long stats_move_1 { get; set; }
}

public class PitDailyContract
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class PitDailyKills
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class PitStatsPtl
{
    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("enderchest_opened")]
    public float enderchest_opened { get; set; }

    [JsonPropertyName("fishing_rod_launched")]
    public float fishing_rod_launched { get; set; }

    [JsonPropertyName("melee_damage_dealt")]
    public float melee_damage_dealt { get; set; }

    [JsonPropertyName("sword_hits")]
    public float sword_hits { get; set; }

    [JsonPropertyName("cash_earned")]
    public float cash_earned { get; set; }

    [JsonPropertyName("joins")]
    public float joins { get; set; }

    [JsonPropertyName("damage_received")]
    public float damage_received { get; set; }

    [JsonPropertyName("jumped_into_pit")]
    public float jumped_into_pit { get; set; }

    [JsonPropertyName("melee_damage_received")]
    public float melee_damage_received { get; set; }

    [JsonPropertyName("left_clicks")]
    public float left_clicks { get; set; }

    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("assists")]
    public float assists { get; set; }

    [JsonPropertyName("blocks_placed")]
    public float blocks_placed { get; set; }

    [JsonPropertyName("launched_by_launchers")]
    public float launched_by_launchers { get; set; }

    [JsonPropertyName("playtime_minutes")]
    public float playtime_minutes { get; set; }

    [JsonPropertyName("diamond_items_purchased")]
    public float diamond_items_purchased { get; set; }

    [JsonPropertyName("arrows_fired")]
    public float arrows_fired { get; set; }

    [JsonPropertyName("bow_damage_dealt")]
    public float bow_damage_dealt { get; set; }

    [JsonPropertyName("wheat_farmed")]
    public float wheat_farmed { get; set; }

    [JsonPropertyName("bow_damage_received")]
    public float bow_damage_received { get; set; }

    [JsonPropertyName("arrow_hits")]
    public float arrow_hits { get; set; }

    [JsonPropertyName("fished_anything")]
    public float fished_anything { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("max_streak")]
    public float max_streak { get; set; }

    [JsonPropertyName("gapple_eaten")]
    public float gapple_eaten { get; set; }

    [JsonPropertyName("chat_messages")]
    public float chat_messages { get; set; }

    [JsonPropertyName("ghead_eaten")]
    public float ghead_eaten { get; set; }

    [JsonPropertyName("contracts_started")]
    public float contracts_started { get; set; }

    [JsonPropertyName("contracts_completed")]
    public float contracts_completed { get; set; }

    [JsonPropertyName("blocks_broken")]
    public float blocks_broken { get; set; }

    [JsonPropertyName("extra_from_trickle_down")]
    public float extra_from_trickle_down { get; set; }

    [JsonPropertyName("ingots_cash")]
    public float ingots_cash { get; set; }

    [JsonPropertyName("ingots_picked_up")]
    public float ingots_picked_up { get; set; }

    [JsonPropertyName("rage_potatoes_eaten")]
    public float rage_potatoes_eaten { get; set; }

    [JsonPropertyName("enchanted_tier1")]
    public float enchanted_tier1 { get; set; }

    [JsonPropertyName("enchanted_tier2")]
    public float enchanted_tier2 { get; set; }

    [JsonPropertyName("enchanted_tier3")]
    public float enchanted_tier3 { get; set; }

    [JsonPropertyName("launched_by_angel_spawn")]
    public float launched_by_angel_spawn { get; set; }

    [JsonPropertyName("launched_by_demon_spawn")]
    public float launched_by_demon_spawn { get; set; }

    [JsonPropertyName("lava_bucket_emptied")]
    public float lava_bucket_emptied { get; set; }

    [JsonPropertyName("rage_pants_crafted")]
    public float rage_pants_crafted { get; set; }

    [JsonPropertyName("soups_drank")]
    public float soups_drank { get; set; }
}

public class PitWeeklyGold
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class Player
{
    [JsonPropertyName("_id")]
    public string _id { get; set; }

    [JsonPropertyName("uuid")]
    public string uuid { get; set; }

    [JsonPropertyName("firstLogin")]
    public long firstLogin { get; set; }

    [JsonPropertyName("playername")]
    public string playername { get; set; }

    [JsonPropertyName("lastLogin")]
    public long lastLogin { get; set; }

    [JsonPropertyName("displayname")]
    public string displayname { get; set; }

    [JsonPropertyName("achievementsOneTime")]
    public List<string> achievementsOneTime { get; set; }

    [JsonPropertyName("network_update_book")]
    public string network_update_book { get; set; }

    [JsonPropertyName("stats")]
    public Stats stats { get; set; }

    [JsonPropertyName("achievements")]
    public Achievements achievements { get; set; }

    [JsonPropertyName("networkExp")]
    public float networkExp { get; set; }

    [JsonPropertyName("lastLogout")]
    public long lastLogout { get; set; }

    [JsonPropertyName("housingMeta")]
    public HousingMeta housingMeta { get; set; }

    [JsonPropertyName("parkourCheckpointBests")]
    public ParkourCheckpointBests parkourCheckpointBests { get; set; }

    [JsonPropertyName("achievementTracking")]
    public List<object> achievementTracking { get; set; }

    [JsonPropertyName("achievementPoints")]
    public float achievementPoints { get; set; }

    [JsonPropertyName("karma")]
    public float karma { get; set; }

    [JsonPropertyName("challenges")]
    public Challenges challenges { get; set; }

    [JsonPropertyName("petConsumables")]
    public PetConsumables petConsumables { get; set; }

    [JsonPropertyName("vanityMeta")]
    public VanityMeta vanityMeta { get; set; }

    [JsonPropertyName("spec_auto_teleport")]
    public bool spec_auto_teleport { get; set; }

    [JsonPropertyName("quests")]
    public Quests quests { get; set; }

    [JsonPropertyName("tourney")]
    public Tourney tourney { get; set; }

    [JsonPropertyName("channel")]
    public string channel { get; set; }

    [JsonPropertyName("monthlycrates")]
    public Dictionary<string, Crate> monthlycrates { get; set; }

    [JsonPropertyName("gifts_grinch")]
    public float gifts_grinch { get; set; }

    [JsonPropertyName("achievementSync")]
    public AchievementSync achievementSync { get; set; }

    [JsonPropertyName("parkourCompletions")]
    public ParkourCompletions parkourCompletions { get; set; }

    [JsonPropertyName("lastAdsenseGenerateTime")]
    public long lastAdsenseGenerateTime { get; set; }

    [JsonPropertyName("skyblock_free_cookie")]
    public long skyblock_free_cookie { get; set; }

    [JsonPropertyName("achievementRewardsNew")]
    public AchievementRewardsNew achievementRewardsNew { get; set; }

    [JsonPropertyName("newPackageRank")]
    public string newPackageRank { get; set; }

    [JsonPropertyName("levelUp_VIP_PLUS")]
    public long levelUp_VIP_PLUS { get; set; }

    [JsonPropertyName("currentPet")]
    public string currentPet { get; set; }

    [JsonPropertyName("petStats")]
    public PetStats petStats { get; set; }

    [JsonPropertyName("currentClickEffect")]
    public string currentClickEffect { get; set; }

    [JsonPropertyName("currentGadget")]
    public string currentGadget { get; set; }

    [JsonPropertyName("seasonal")]
    public Seasonal seasonal { get; set; }

    [JsonPropertyName("eugene")]
    public Eugene eugene { get; set; }

    [JsonPropertyName("vanityFavorites")]
    public string vanityFavorites { get; set; }

    [JsonPropertyName("socialMedia")]
    public SocialMedia socialMedia { get; set; }

    [JsonPropertyName("levelUp_MVP_PLUS")]
    public long levelUp_MVP_PLUS { get; set; }

    [JsonPropertyName("currentCloak")]
    public string currentCloak { get; set; }

    [JsonPropertyName("scorpius_bribe_192")]
    public long scorpius_bribe_192 { get; set; }

    [JsonPropertyName("claimed_century_cake200")]
    public long claimed_century_cake200 { get; set; }

    [JsonPropertyName("skyblock_extra")]
    public SkyblockExtra skyblock_extra { get; set; }

    [JsonPropertyName("particlePack")]
    public string particlePack { get; set; }

    [JsonPropertyName("leveling")]
    public Leveling leveling { get; set; }

    [JsonPropertyName("rankPlusColor")]
    public string rankPlusColor { get; set; }

    [JsonPropertyName("collectibles_menu_sort")]
    public string collectibles_menu_sort { get; set; }

    [JsonPropertyName("scorpius_bribe_312")]
    public long scorpius_bribe_312 { get; set; }

    [JsonPropertyName("questSettings")]
    public QuestSettings questSettings { get; set; }

    [JsonPropertyName("adsense_tokens")]
    public float adsense_tokens { get; set; }

    [JsonPropertyName("monthlyPackageRank")]
    public string monthlyPackageRank { get; set; }

    [JsonPropertyName("mostRecentMonthlyPackageRank")]
    public string mostRecentMonthlyPackageRank { get; set; }

    [JsonPropertyName("scorpius_bribe_336")]
    public long scorpius_bribe_336 { get; set; }

    [JsonPropertyName("achievementTotem")]
    public AchievementTotem achievementTotem { get; set; }
}

public class PlayerSettings
{
    [JsonPropertyName("VISIBILITY")]
    public string VISIBILITY { get; set; }
}

public class Practice
{
    [JsonPropertyName("selected")]
    public string selected { get; set; }

    [JsonPropertyName("fireball_jumping")]
    public FireballJumping fireball_jumping { get; set; }

    [JsonPropertyName("mlg")]
    public Mlg mlg { get; set; }

    [JsonPropertyName("bridging")]
    public Bridging bridging { get; set; }

    [JsonPropertyName("records")]
    public Records records { get; set; }
}

public class Presents
{
    [JsonPropertyName("PROTOTYPE_1")]
    public bool PROTOTYPE_1 { get; set; }

    [JsonPropertyName("BEDWARS_1")]
    public bool BEDWARS_1 { get; set; }

    [JsonPropertyName("BEDWARS_2")]
    public bool BEDWARS_2 { get; set; }

    [JsonPropertyName("BEDWARS_5")]
    public bool BEDWARS_5 { get; set; }

    [JsonPropertyName("BEDWARS_3")]
    public bool BEDWARS_3 { get; set; }

    [JsonPropertyName("BEDWARS_4")]
    public bool BEDWARS_4 { get; set; }
}

public class Prestigiou
{
    [JsonPropertyName("uuid")]
    public string uuid { get; set; }

    [JsonPropertyName("timestamp")]
    public long timestamp { get; set; }

    [JsonPropertyName("mode")]
    public string mode { get; set; }

    [JsonPropertyName("sacrifice")]
    public string sacrifice { get; set; }
}

public class Privategames
{
    [JsonPropertyName("one_hit_one_kill")]
    public bool one_hit_one_kill { get; set; }

    [JsonPropertyName("no_emeralds")]
    public bool no_emeralds { get; set; }

    [JsonPropertyName("no_diamonds")]
    public bool no_diamonds { get; set; }

    [JsonPropertyName("max_team_upgrades")]
    public bool max_team_upgrades { get; set; }

    [JsonPropertyName("event_time")]
    public string event_time { get; set; }

    [JsonPropertyName("health_buff")]
    public string health_buff { get; set; }

    [JsonPropertyName("respawn_time")]
    public string respawn_time { get; set; }

    [JsonPropertyName("bed_instabreak")]
    public bool bed_instabreak { get; set; }

    [JsonPropertyName("chest_bows")]
    public string chest_bows { get; set; }

    [JsonPropertyName("enable_legacy_items")]
    public bool enable_legacy_items { get; set; }

    [JsonPropertyName("enable_max_kits_and_perks")]
    public bool enable_max_kits_and_perks { get; set; }

    [JsonPropertyName("enable_night_time")]
    public bool enable_night_time { get; set; }

    [JsonPropertyName("chest_swords")]
    public string chest_swords { get; set; }

    [JsonPropertyName("no_kits")]
    public bool no_kits { get; set; }

    [JsonPropertyName("chest_armour")]
    public string chest_armour { get; set; }

    [JsonPropertyName("enable_teleport_mayhem")]
    public bool enable_teleport_mayhem { get; set; }

    [JsonPropertyName("dragons")]
    public string dragons { get; set; }

    [JsonPropertyName("tnt_tag_no_powerups")]
    public bool tnt_tag_no_powerups { get; set; }

    [JsonPropertyName("maxed_perks")]
    public bool maxed_perks { get; set; }

    [JsonPropertyName("tnt_tag_deathmatch")]
    public bool tnt_tag_deathmatch { get; set; }
}

public class Profile
{
    [JsonPropertyName("moved_achievements_1")]
    public bool moved_achievements_1 { get; set; }

    [JsonPropertyName("outgoing_offers")]
    public List<object> outgoing_offers { get; set; }

    [JsonPropertyName("moved_achievements_2")]
    public bool moved_achievements_2 { get; set; }

    [JsonPropertyName("contract_choices")]
    public object contract_choices { get; set; }

    [JsonPropertyName("items_last_buy")]
    public ItemsLastBuy items_last_buy { get; set; }

    [JsonPropertyName("last_save")]
    public long last_save { get; set; }

    [JsonPropertyName("king_quest")]
    public KingQuest king_quest { get; set; }

    [JsonPropertyName("last_passive_xp")]
    public long last_passive_xp { get; set; }

    [JsonPropertyName("genesis_points")]
    public float genesis_points { get; set; }

    [JsonPropertyName("spire_stash_inv")]
    public SpireStashInv spire_stash_inv { get; set; }

    [JsonPropertyName("zero_point_three_gold_transfer")]
    public bool zero_point_three_gold_transfer { get; set; }

    [JsonPropertyName("inv_enderchest")]
    public InvEnderchest inv_enderchest { get; set; }

    [JsonPropertyName("death_recaps")]
    public DeathRecaps death_recaps { get; set; }

    [JsonPropertyName("genesis_spawn_in_base")]
    public bool genesis_spawn_in_base { get; set; }

    [JsonPropertyName("spire_stash_armor")]
    public SpireStashArmor spire_stash_armor { get; set; }

    [JsonPropertyName("cash")]
    public double cash { get; set; }

    [JsonPropertyName("selected_leaderboard")]
    public string selected_leaderboard { get; set; }

    [JsonPropertyName("last_midfight_disconnect")]
    public long last_midfight_disconnect { get; set; }

    [JsonPropertyName("leaderboard_stats")]
    public LeaderboardStats leaderboard_stats { get; set; }

    [JsonPropertyName("inv_armor")]
    public InvArmor inv_armor { get; set; }

    [JsonPropertyName("selected_perk_1")]
    public string selected_perk_1 { get; set; }

    [JsonPropertyName("selected_perk_0")]
    public string selected_perk_0 { get; set; }

    [JsonPropertyName("last_contract")]
    public long last_contract { get; set; }

    [JsonPropertyName("item_stash")]
    public ItemStash item_stash { get; set; }

    [JsonPropertyName("genesis_allegiance_time")]
    public long genesis_allegiance_time { get; set; }

    [JsonPropertyName("selected_killstreak_1")]
    public string selected_killstreak_1 { get; set; }

    [JsonPropertyName("login_messages")]
    public List<object> login_messages { get; set; }

    [JsonPropertyName("hotbar_favorites")]
    public List<int> hotbar_favorites { get; set; }

    [JsonPropertyName("genesis_allegiance")]
    public string genesis_allegiance { get; set; }

    [JsonPropertyName("xp")]
    public float xp { get; set; }

    [JsonPropertyName("inv_contents")]
    public InvContents inv_contents { get; set; }

    [JsonPropertyName("ended_contracts")]
    public List<EndedContract> ended_contracts { get; set; }

    [JsonPropertyName("bounties")]
    public List<object> bounties { get; set; }

    [JsonPropertyName("unlocks")]
    public List<Unlock> unlocks { get; set; }

    [JsonPropertyName("cash_during_prestige_0")]
    public double cash_during_prestige_0 { get; set; }
}

public class Progress
{
    [JsonPropertyName("kills")]
    public float kills { get; set; }
}

public class Progression
{
    [JsonPropertyName("available_layers")]
    public float available_layers { get; set; }

    [JsonPropertyName("experience")]
    public double experience { get; set; }
}

public class Prototype
{
    [JsonPropertyName("0")]
    public float _0 { get; set; }

    [JsonPropertyName("1")]
    public float _1 { get; set; }

    [JsonPropertyName("2")]
    public float _2 { get; set; }

    [JsonPropertyName("3")]
    public float _3 { get; set; }
}

public class PrototypePitDailyContract
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }
}

public class PrototypePitDailyKills
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }
}

public class PrototypePitWeeklyGold
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }
}

public class Quake
{
    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("enable_sound")]
    public bool enable_sound { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }
}

public class Quest
{
    [JsonPropertyName("started")]
    public Started started { get; set; }

    [JsonPropertyName("lastStarted")]
    public LastStarted lastStarted { get; set; }

    [JsonPropertyName("gambler_george")]
    public GamblerGeorge gambler_george { get; set; }

    [JsonPropertyName("npc")]
    public Npc npc { get; set; }

    [JsonPropertyName("completed")]
    public Completed completed { get; set; }

    [JsonPropertyName("objective")]
    public Objective objective { get; set; }

    [JsonPropertyName("lastCompleted")]
    public LastCompleted lastCompleted { get; set; }

    [JsonPropertyName("item")]
    public Item item { get; set; }
}

public class QuestNPCTutorials
{
    [JsonPropertyName("zone_village")]
    public bool zone_village { get; set; }

    [JsonPropertyName("christmas_guide_2023")]
    public bool christmas_guide_2023 { get; set; }

    [JsonPropertyName("easter_guide_2024")]
    public bool easter_guide_2024 { get; set; }
}

public class Quests
{
    [JsonPropertyName("prototype_pit_weekly_gold")]
    public PrototypePitWeeklyGold prototype_pit_weekly_gold { get; set; }

    [JsonPropertyName("prototype_pit_daily_contract")]
    public PrototypePitDailyContract prototype_pit_daily_contract { get; set; }

    [JsonPropertyName("prototype_pit_daily_kills")]
    public PrototypePitDailyKills prototype_pit_daily_kills { get; set; }

    [JsonPropertyName("tnt_bowspleef_daily")]
    public TntBowspleefDaily tnt_bowspleef_daily { get; set; }

    [JsonPropertyName("tnt_bowspleef_weekly")]
    public TntBowspleefWeekly tnt_bowspleef_weekly { get; set; }

    [JsonPropertyName("tnt_wizards_weekly")]
    public TntWizardsWeekly tnt_wizards_weekly { get; set; }

    [JsonPropertyName("tnt_wizards_daily")]
    public TntWizardsDaily tnt_wizards_daily { get; set; }

    [JsonPropertyName("skywars_weekly_free_loot_chest")]
    public SkywarsWeeklyFreeLootChest skywars_weekly_free_loot_chest { get; set; }

    [JsonPropertyName("skywars_daily_tokens")]
    public SkywarsDailyTokens skywars_daily_tokens { get; set; }

    [JsonPropertyName("arcade_gamer")]
    public ArcadeGamer arcade_gamer { get; set; }

    [JsonPropertyName("arcade_winner")]
    public ArcadeWinner arcade_winner { get; set; }

    [JsonPropertyName("arcade_specialist")]
    public ArcadeSpecialist arcade_specialist { get; set; }

    [JsonPropertyName("pit_daily_contract")]
    public PitDailyContract pit_daily_contract { get; set; }

    [JsonPropertyName("pit_daily_kills")]
    public PitDailyKills pit_daily_kills { get; set; }

    [JsonPropertyName("skywars_special_north_pole")]
    public SkywarsSpecialNorthPole skywars_special_north_pole { get; set; }

    [JsonPropertyName("skywars_arcade_win")]
    public SkywarsArcadeWin skywars_arcade_win { get; set; }

    [JsonPropertyName("skywars_weekly_kills")]
    public SkywarsWeeklyKills skywars_weekly_kills { get; set; }

    [JsonPropertyName("skywars_corrupt_win")]
    public SkywarsCorruptWin skywars_corrupt_win { get; set; }

    [JsonPropertyName("skywars_solo_kills")]
    public SkywarsSoloKills skywars_solo_kills { get; set; }

    [JsonPropertyName("skywars_team_win")]
    public SkywarsTeamWin skywars_team_win { get; set; }

    [JsonPropertyName("skywars_team_kills")]
    public SkywarsTeamKills skywars_team_kills { get; set; }

    [JsonPropertyName("skywars_solo_win")]
    public SkywarsSoloWin skywars_solo_win { get; set; }

    [JsonPropertyName("skywars_weekly_arcade_win_all")]
    public SkywarsWeeklyArcadeWinAll skywars_weekly_arcade_win_all { get; set; }

    [JsonPropertyName("mega_walls_play")]
    public MegaWallsPlay mega_walls_play { get; set; }

    [JsonPropertyName("mega_walls_win")]
    public MegaWallsWin mega_walls_win { get; set; }

    [JsonPropertyName("mega_walls_kill")]
    public MegaWallsKill mega_walls_kill { get; set; }

    [JsonPropertyName("mega_walls_weekly")]
    public MegaWallsWeekly mega_walls_weekly { get; set; }

    [JsonPropertyName("mega_walls_faithful")]
    public MegaWallsFaithful mega_walls_faithful { get; set; }

    [JsonPropertyName("bedwars_daily_win")]
    public BedwarsDailyWin bedwars_daily_win { get; set; }

    [JsonPropertyName("bedwars_daily_one_more")]
    public BedwarsDailyOneMore bedwars_daily_one_more { get; set; }

    [JsonPropertyName("bedwars_daily_bed_breaker")]
    public BedwarsDailyBedBreaker bedwars_daily_bed_breaker { get; set; }

    [JsonPropertyName("bedwars_daily_final_killer")]
    public BedwarsDailyFinalKiller bedwars_daily_final_killer { get; set; }

    [JsonPropertyName("bedwars_weekly_bed_elims")]
    public BedwarsWeeklyBedElims bedwars_weekly_bed_elims { get; set; }

    [JsonPropertyName("bedwars_weekly_dream_win")]
    public BedwarsWeeklyDreamWin bedwars_weekly_dream_win { get; set; }

    [JsonPropertyName("bedwars_weekly_challenges_win")]
    public BedwarsWeeklyChallengesWin bedwars_weekly_challenges_win { get; set; }

    [JsonPropertyName("bedwars_weekly_final_killer")]
    public BedwarsWeeklyFinalKiller bedwars_weekly_final_killer { get; set; }

    [JsonPropertyName("bedwars_daily_gifts")]
    public BedwarsDailyGifts bedwars_daily_gifts { get; set; }

    [JsonPropertyName("wool_wars_daily_play")]
    public WoolWarsDailyPlay wool_wars_daily_play { get; set; }

    [JsonPropertyName("wool_wars_daily_wins")]
    public WoolWarsDailyWins wool_wars_daily_wins { get; set; }

    [JsonPropertyName("wool_wars_daily_kills")]
    public WoolWarsDailyKills wool_wars_daily_kills { get; set; }

    [JsonPropertyName("wool_weekly_play")]
    public WoolWeeklyPlay wool_weekly_play { get; set; }

    [JsonPropertyName("wool_wars_weekly_shears")]
    public WoolWarsWeeklyShears wool_wars_weekly_shears { get; set; }

    [JsonPropertyName("tnt_daily_win")]
    public TntDailyWin tnt_daily_win { get; set; }

    [JsonPropertyName("tnt_tnttag_weekly")]
    public TntTnttagWeekly tnt_tnttag_weekly { get; set; }

    [JsonPropertyName("tnt_weekly_play")]
    public TntWeeklyPlay tnt_weekly_play { get; set; }

    [JsonPropertyName("tnt_weekly_special")]
    public TntWeeklySpecial tnt_weekly_special { get; set; }

    [JsonPropertyName("tnt_tntrun_daily")]
    public TntTntrunDaily tnt_tntrun_daily { get; set; }

    [JsonPropertyName("tnt_tntrun_weekly")]
    public TntTntrunWeekly tnt_tntrun_weekly { get; set; }

    [JsonPropertyName("tnt_pvprun_daily")]
    public TntPvprunDaily tnt_pvprun_daily { get; set; }

    [JsonPropertyName("tnt_pvprun_weekly")]
    public TntPvprunWeekly tnt_pvprun_weekly { get; set; }

    [JsonPropertyName("tnt_tnttag_daily")]
    public TntTnttagDaily tnt_tnttag_daily { get; set; }

    [JsonPropertyName("duels_player")]
    public DuelsPlayer duels_player { get; set; }

    [JsonPropertyName("duels_killer")]
    public DuelsKiller duels_killer { get; set; }

    [JsonPropertyName("duels_winner")]
    public DuelsWinner duels_winner { get; set; }

    [JsonPropertyName("duels_weekly_kills")]
    public DuelsWeeklyKills duels_weekly_kills { get; set; }

    [JsonPropertyName("duels_weekly_wins")]
    public DuelsWeeklyWins duels_weekly_wins { get; set; }

    [JsonPropertyName("mm_daily_win")]
    public MmDailyWin mm_daily_win { get; set; }

    [JsonPropertyName("mm_daily_power_play")]
    public MmDailyPowerPlay mm_daily_power_play { get; set; }

    [JsonPropertyName("mm_daily_target_kill")]
    public MmDailyTargetKill mm_daily_target_kill { get; set; }

    [JsonPropertyName("mm_daily_infector")]
    public MmDailyInfector mm_daily_infector { get; set; }

    [JsonPropertyName("mm_weekly_murderer_kills")]
    public MmWeeklyMurdererKills mm_weekly_murderer_kills { get; set; }

    [JsonPropertyName("mm_weekly_wins")]
    public MmWeeklyWins mm_weekly_wins { get; set; }

    [JsonPropertyName("pit_weekly_gold")]
    public PitWeeklyGold pit_weekly_gold { get; set; }

    [JsonPropertyName("uhc_team")]
    public UhcTeam uhc_team { get; set; }

    [JsonPropertyName("uhc_solo")]
    public UhcSolo uhc_solo { get; set; }

    [JsonPropertyName("uhc_dm")]
    public UhcDm uhc_dm { get; set; }

    [JsonPropertyName("uhc_weekly")]
    public UhcWeekly uhc_weekly { get; set; }

    [JsonPropertyName("solo_brawler")]
    public SoloBrawler solo_brawler { get; set; }

    [JsonPropertyName("team_brawler")]
    public TeamBrawler team_brawler { get; set; }

    [JsonPropertyName("uhc_madness")]
    public UhcMadness uhc_madness { get; set; }

    [JsonPropertyName("build_battle_player")]
    public BuildBattlePlayer build_battle_player { get; set; }

    [JsonPropertyName("build_battle_winner")]
    public BuildBattleWinner build_battle_winner { get; set; }

    [JsonPropertyName("build_battle_weekly")]
    public BuildBattleWeekly build_battle_weekly { get; set; }
}

public class QuestSettings
{
    [JsonPropertyName("autoActivate")]
    public bool autoActivate { get; set; }
}

public class Recent
{
    [JsonPropertyName("uuid")]
    public string uuid { get; set; }

    [JsonPropertyName("timestamp")]
    public object timestamp { get; set; }

    [JsonPropertyName("mode")]
    public string mode { get; set; }

    [JsonPropertyName("sacrifice")]
    public string sacrifice { get; set; }
}

public class Records
{
    [JsonPropertyName("bridging_distance_30:elevation_SLIGHT:angle_STRAIGHT:")]
    public float bridging_distance_30elevation_SLIGHTangle_STRAIGHT { get; set; }
}

public class Requirements
{
    [JsonPropertyName("kills")]
    public float kills { get; set; }
}

public class Root
{
    [JsonPropertyName("success")]
    public bool success { get; set; }

    [JsonPropertyName("player")]
    public Player player { get; set; }
}

public class Seasonal
{
    [JsonPropertyName("christmas")]
    public Christmas christmas { get; set; }

    [JsonPropertyName("summer")]
    public Summer summer { get; set; }

    [JsonPropertyName("silver")]
    public float silver { get; set; }

    [JsonPropertyName("halloween")]
    public Halloween halloween { get; set; }

    [JsonPropertyName("easter")]
    public Easter easter { get; set; }
}

public class SeismicSlam
{
    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("damage_dealt_2v2")]
    public float damage_dealt_2v2 { get; set; }

    [JsonPropertyName("damage_dealt_normal")]
    public float damage_dealt_normal { get; set; }
}

public class SelectedColors
{
    [JsonPropertyName("slotcolor_0")]
    public string slotcolor_0 { get; set; }
}

public class SelectedParts
{
    [JsonPropertyName("slot_0")]
    public string slot_0 { get; set; }

    [JsonPropertyName("slot_1")]
    public string slot_1 { get; set; }
}

public class Skeleton
{
    [JsonPropertyName("skill_level_dChecked5")]
    public bool skill_level_dChecked5 { get; set; }

    [JsonPropertyName("skill_level_d")]
    public float skill_level_d { get; set; }

    [JsonPropertyName("unlocked")]
    public bool unlocked { get; set; }

    [JsonPropertyName("checked4")]
    public bool checked4 { get; set; }
}

public class SkyBlock
{
    [JsonPropertyName("profiles")]
    public Dictionary<string,SkyblockProfile> profiles { get; set; }
}

public class SkyblockExtra
{
    [JsonPropertyName("ozanne_coins")]
    public float ozanne_coins { get; set; }
}

public class SkyClash
{
    [JsonPropertyName("card_packs")]
    public float card_packs { get; set; }
}

public class SkyWars
{
    [JsonPropertyName("souls")]
    public float souls { get; set; }

    [JsonPropertyName("hunters_vs_beasts_explained_last")]
    public long hunters_vs_beasts_explained_last { get; set; }

    [JsonPropertyName("hunters_vs_beasts_explained")]
    public float hunters_vs_beasts_explained { get; set; }

    [JsonPropertyName("activeKit_SOLO")]
    public string activeKit_SOLO { get; set; }

    [JsonPropertyName("activeKit_SOLO_random")]
    public bool activeKit_SOLO_random { get; set; }

    [JsonPropertyName("games_played_skywars")]
    public float games_played_skywars { get; set; }

    [JsonPropertyName("fastest_win_lab_solo")]
    public float fastest_win_lab_solo { get; set; }

    [JsonPropertyName("lastMode")]
    public string lastMode { get; set; }

    [JsonPropertyName("fastest_win_lab")]
    public float fastest_win_lab { get; set; }

    [JsonPropertyName("fastest_win_lab_kit_basic_solo_default")]
    public float fastest_win_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("lab_win_hunters_vs_beasts_lab")]
    public float lab_win_hunters_vs_beasts_lab { get; set; }

    [JsonPropertyName("survived_players_lab_solo")]
    public float survived_players_lab_solo { get; set; }

    [JsonPropertyName("chests_opened_lab_solo")]
    public float chests_opened_lab_solo { get; set; }

    [JsonPropertyName("wins_lab")]
    public float wins_lab { get; set; }

    [JsonPropertyName("winstreak_lab_solo")]
    public float winstreak_lab_solo { get; set; }

    [JsonPropertyName("time_played_lab_solo")]
    public float time_played_lab_solo { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("time_played_lab")]
    public float time_played_lab { get; set; }

    [JsonPropertyName("lab_hvb_hunter_wins_lab")]
    public float lab_hvb_hunter_wins_lab { get; set; }

    [JsonPropertyName("games_lab")]
    public float games_lab { get; set; }

    [JsonPropertyName("coins_gained_lab")]
    public float coins_gained_lab { get; set; }

    [JsonPropertyName("survived_players_lab")]
    public float survived_players_lab { get; set; }

    [JsonPropertyName("lab_win_hunters_vs_beasts_lab_solo")]
    public float lab_win_hunters_vs_beasts_lab_solo { get; set; }

    [JsonPropertyName("games_lab_kit_basic_solo_default")]
    public float games_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("time_played_lab_kit_basic_solo_default")]
    public float time_played_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("winstreak_lab")]
    public float winstreak_lab { get; set; }

    [JsonPropertyName("chests_opened_lab")]
    public float chests_opened_lab { get; set; }

    [JsonPropertyName("games_lab_solo")]
    public float games_lab_solo { get; set; }

    [JsonPropertyName("wins_lab_solo")]
    public float wins_lab_solo { get; set; }

    [JsonPropertyName("survived_players_lab_kit_basic_solo_default")]
    public float survived_players_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("lab_win_hunters_vs_beasts_lab_kit_basic_solo_default")]
    public float lab_win_hunters_vs_beasts_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("winstreak_lab_kit_basic_solo_default")]
    public float winstreak_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("wins_lab_kit_basic_solo_default")]
    public float wins_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("chests_opened_lab_kit_basic_solo_default")]
    public float chests_opened_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("beast_chance")]
    public float beast_chance { get; set; }

    [JsonPropertyName("win_streak_lab")]
    public float win_streak_lab { get; set; }

    [JsonPropertyName("deaths_lab")]
    public float deaths_lab { get; set; }

    [JsonPropertyName("deaths_lab_solo")]
    public float deaths_lab_solo { get; set; }

    [JsonPropertyName("deaths_lab_kit_basic_solo_default")]
    public float deaths_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("items_enchanted_lab")]
    public float items_enchanted_lab { get; set; }

    [JsonPropertyName("losses_lab_solo")]
    public float losses_lab_solo { get; set; }

    [JsonPropertyName("losses_lab")]
    public float losses_lab { get; set; }

    [JsonPropertyName("blocks_placed_lab")]
    public float blocks_placed_lab { get; set; }

    [JsonPropertyName("quits_lab")]
    public float quits_lab { get; set; }

    [JsonPropertyName("losses_lab_kit_basic_solo_default")]
    public float losses_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("arrows_shot_lab_kit_basic_solo_default")]
    public float arrows_shot_lab_kit_basic_solo_default { get; set; }

    [JsonPropertyName("arrows_shot_lab_solo")]
    public float arrows_shot_lab_solo { get; set; }

    [JsonPropertyName("egg_thrown_lab")]
    public float egg_thrown_lab { get; set; }

    [JsonPropertyName("arrows_shot_lab")]
    public float arrows_shot_lab { get; set; }

    [JsonPropertyName("soul_well")]
    public float soul_well { get; set; }

    [JsonPropertyName("usedSoulWell")]
    public bool usedSoulWell { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("blocks_broken_lab")]
    public float blocks_broken_lab { get; set; }

    [JsonPropertyName("enderpearls_thrown_lab")]
    public float enderpearls_thrown_lab { get; set; }

    [JsonPropertyName("rush_explained")]
    public float rush_explained { get; set; }

    [JsonPropertyName("rush_explained_last")]
    public long rush_explained_last { get; set; }

    [JsonPropertyName("tnt_madness_explained")]
    public float tnt_madness_explained { get; set; }

    [JsonPropertyName("tnt_madness_explained_last")]
    public long tnt_madness_explained_last { get; set; }

    [JsonPropertyName("activeKit_TEAMS_random")]
    public bool activeKit_TEAMS_random { get; set; }

    [JsonPropertyName("activeKit_TEAMS")]
    public string activeKit_TEAMS { get; set; }

    [JsonPropertyName("win_streak")]
    public float win_streak { get; set; }

    [JsonPropertyName("survived_players_kit_basic_solo_scout")]
    public float survived_players_kit_basic_solo_scout { get; set; }

    [JsonPropertyName("losses_team_normal")]
    public float losses_team_normal { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("losses_kit_basic_solo_scout")]
    public float losses_kit_basic_solo_scout { get; set; }

    [JsonPropertyName("chests_opened_team")]
    public float chests_opened_team { get; set; }

    [JsonPropertyName("time_played_team")]
    public float time_played_team { get; set; }

    [JsonPropertyName("survived_players_team")]
    public float survived_players_team { get; set; }

    [JsonPropertyName("losses_team")]
    public float losses_team { get; set; }

    [JsonPropertyName("quits")]
    public float quits { get; set; }

    [JsonPropertyName("deaths_team_normal")]
    public float deaths_team_normal { get; set; }

    [JsonPropertyName("survived_players")]
    public float survived_players { get; set; }

    [JsonPropertyName("chests_opened")]
    public float chests_opened { get; set; }

    [JsonPropertyName("time_played")]
    public float time_played { get; set; }

    [JsonPropertyName("deaths_team")]
    public float deaths_team { get; set; }

    [JsonPropertyName("deaths_kit_basic_solo_scout")]
    public float deaths_kit_basic_solo_scout { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("time_played_kit_basic_solo_scout")]
    public float time_played_kit_basic_solo_scout { get; set; }

    [JsonPropertyName("chests_opened_kit_basic_solo_scout")]
    public float chests_opened_kit_basic_solo_scout { get; set; }

    [JsonPropertyName("chests_opened_lab_kit_attacking_team_scout")]
    public float chests_opened_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("deaths_lab_kit_attacking_team_scout")]
    public float deaths_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("survived_players_lab_kit_attacking_team_scout")]
    public float survived_players_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("losses_lab_kit_attacking_team_scout")]
    public float losses_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("time_played_lab_kit_attacking_team_scout")]
    public float time_played_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("games_lab_kit_attacking_team_scout")]
    public float games_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("skywars_experience")]
    public float skywars_experience { get; set; }

    [JsonPropertyName("fastest_win_lab_kit_attacking_team_scout")]
    public float fastest_win_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("arrows_shot_lab_kit_attacking_team_scout")]
    public float arrows_shot_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("winstreak_lab_kit_attacking_team_scout")]
    public float winstreak_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("lab_win_hunters_vs_beasts_lab_kit_attacking_team_scout")]
    public float lab_win_hunters_vs_beasts_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("wins_lab_kit_attacking_team_scout")]
    public float wins_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("most_kills_game_lab_kit_attacking_team_scout")]
    public float most_kills_game_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("most_kills_game_lab_solo")]
    public float most_kills_game_lab_solo { get; set; }

    [JsonPropertyName("most_kills_game_lab")]
    public float most_kills_game_lab { get; set; }

    [JsonPropertyName("void_kills_lab")]
    public float void_kills_lab { get; set; }

    [JsonPropertyName("souls_gathered_lab")]
    public float souls_gathered_lab { get; set; }

    [JsonPropertyName("void_kills_lab_kit_attacking_team_scout")]
    public float void_kills_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("kills_weekly_a")]
    public float kills_weekly_a { get; set; }

    [JsonPropertyName("kills_lab_kit_attacking_team_scout")]
    public float kills_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("kills_lab")]
    public float kills_lab { get; set; }

    [JsonPropertyName("kills_lab_solo")]
    public float kills_lab_solo { get; set; }

    [JsonPropertyName("void_kills_lab_solo")]
    public float void_kills_lab_solo { get; set; }

    [JsonPropertyName("kills_monthly_b")]
    public float kills_monthly_b { get; set; }

    [JsonPropertyName("paid_souls")]
    public float paid_souls { get; set; }

    [JsonPropertyName("longest_bow_shot_lab")]
    public float longest_bow_shot_lab { get; set; }

    [JsonPropertyName("longest_bow_shot_lab_kit_attacking_team_scout")]
    public float longest_bow_shot_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("longest_bow_shot_lab_solo")]
    public float longest_bow_shot_lab_solo { get; set; }

    [JsonPropertyName("lab_hvb_beast_enrages_lab")]
    public float lab_hvb_beast_enrages_lab { get; set; }

    [JsonPropertyName("arrows_hit_lab_kit_attacking_team_scout")]
    public float arrows_hit_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("arrows_hit_lab")]
    public float arrows_hit_lab { get; set; }

    [JsonPropertyName("arrows_hit_lab_solo")]
    public float arrows_hit_lab_solo { get; set; }

    [JsonPropertyName("slime_explained_last")]
    public long slime_explained_last { get; set; }

    [JsonPropertyName("slime_explained")]
    public float slime_explained { get; set; }

    [JsonPropertyName("longest_bow_kill_lab_solo")]
    public float longest_bow_kill_lab_solo { get; set; }

    [JsonPropertyName("longest_bow_kill_lab")]
    public float longest_bow_kill_lab { get; set; }

    [JsonPropertyName("longest_bow_kill_lab_kit_attacking_team_scout")]
    public float longest_bow_kill_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("melee_kills_lab_solo")]
    public float melee_kills_lab_solo { get; set; }

    [JsonPropertyName("melee_kills_lab_kit_attacking_team_scout")]
    public float melee_kills_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("melee_kills_lab")]
    public float melee_kills_lab { get; set; }

    [JsonPropertyName("activeKit_MEGA")]
    public string activeKit_MEGA { get; set; }

    [JsonPropertyName("activeKit_MEGA_random")]
    public bool activeKit_MEGA_random { get; set; }

    [JsonPropertyName("blocks_broken")]
    public float blocks_broken { get; set; }

    [JsonPropertyName("arrows_shot_mega_doubles")]
    public float arrows_shot_mega_doubles { get; set; }

    [JsonPropertyName("time_played_mega_doubles")]
    public float time_played_mega_doubles { get; set; }

    [JsonPropertyName("refill_chest_destroy")]
    public float refill_chest_destroy { get; set; }

    [JsonPropertyName("losses_mega_doubles_normal")]
    public float losses_mega_doubles_normal { get; set; }

    [JsonPropertyName("deaths_kit_mega_mega_default")]
    public float deaths_kit_mega_mega_default { get; set; }

    [JsonPropertyName("games_mega_doubles")]
    public float games_mega_doubles { get; set; }

    [JsonPropertyName("deaths_mega_doubles_normal")]
    public float deaths_mega_doubles_normal { get; set; }

    [JsonPropertyName("survived_players_mega_doubles")]
    public float survived_players_mega_doubles { get; set; }

    [JsonPropertyName("blocks_placed")]
    public float blocks_placed { get; set; }

    [JsonPropertyName("losses_mega_doubles")]
    public float losses_mega_doubles { get; set; }

    [JsonPropertyName("time_played_kit_mega_mega_default")]
    public float time_played_kit_mega_mega_default { get; set; }

    [JsonPropertyName("chests_opened_kit_mega_mega_default")]
    public float chests_opened_kit_mega_mega_default { get; set; }

    [JsonPropertyName("games_kit_mega_mega_default")]
    public float games_kit_mega_mega_default { get; set; }

    [JsonPropertyName("survived_players_kit_mega_mega_default")]
    public float survived_players_kit_mega_mega_default { get; set; }

    [JsonPropertyName("games")]
    public float games { get; set; }

    [JsonPropertyName("arrows_shot_kit_mega_mega_default")]
    public float arrows_shot_kit_mega_mega_default { get; set; }

    [JsonPropertyName("chests_opened_mega_doubles")]
    public float chests_opened_mega_doubles { get; set; }

    [JsonPropertyName("deaths_mega_doubles")]
    public float deaths_mega_doubles { get; set; }

    [JsonPropertyName("losses_kit_mega_mega_default")]
    public float losses_kit_mega_mega_default { get; set; }

    [JsonPropertyName("arrows_shot")]
    public float arrows_shot { get; set; }

    [JsonPropertyName("time_played_lab_kit_mining_team_default")]
    public float time_played_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("losses_lab_kit_mining_team_default")]
    public float losses_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("chests_opened_lab_kit_mining_team_default")]
    public float chests_opened_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("survived_players_lab_kit_mining_team_default")]
    public float survived_players_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("games_lab_kit_mining_team_default")]
    public float games_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("deaths_lab_kit_mining_team_default")]
    public float deaths_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("games_lab_kit_defending_team_frog")]
    public float games_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("deaths_lab_kit_defending_team_frog")]
    public float deaths_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("time_played_lab_kit_defending_team_frog")]
    public float time_played_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("chests_opened_lab_kit_defending_team_frog")]
    public float chests_opened_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("survived_players_lab_kit_defending_team_frog")]
    public float survived_players_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("losses_lab_kit_defending_team_frog")]
    public float losses_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("solo_lucky_charm")]
    public float solo_lucky_charm { get; set; }

    [JsonPropertyName("soul_well_rares")]
    public float soul_well_rares { get; set; }

    [JsonPropertyName("survived_players_solo")]
    public float survived_players_solo { get; set; }

    [JsonPropertyName("time_played_kit_basic_solo_default")]
    public float time_played_kit_basic_solo_default { get; set; }

    [JsonPropertyName("chests_opened_solo")]
    public float chests_opened_solo { get; set; }

    [JsonPropertyName("egg_thrown")]
    public float egg_thrown { get; set; }

    [JsonPropertyName("time_played_solo")]
    public float time_played_solo { get; set; }

    [JsonPropertyName("losses_solo")]
    public float losses_solo { get; set; }

    [JsonPropertyName("deaths_solo_normal")]
    public float deaths_solo_normal { get; set; }

    [JsonPropertyName("chests_opened_kit_basic_solo_default")]
    public float chests_opened_kit_basic_solo_default { get; set; }

    [JsonPropertyName("survived_players_kit_basic_solo_default")]
    public float survived_players_kit_basic_solo_default { get; set; }

    [JsonPropertyName("losses_kit_basic_solo_default")]
    public float losses_kit_basic_solo_default { get; set; }

    [JsonPropertyName("deaths_kit_basic_solo_default")]
    public float deaths_kit_basic_solo_default { get; set; }

    [JsonPropertyName("losses_solo_normal")]
    public float losses_solo_normal { get; set; }

    [JsonPropertyName("deaths_solo")]
    public float deaths_solo { get; set; }

    [JsonPropertyName("most_kills_game_solo")]
    public float most_kills_game_solo { get; set; }

    [JsonPropertyName("most_kills_game")]
    public float most_kills_game { get; set; }

    [JsonPropertyName("most_kills_game_kit_basic_solo_default")]
    public float most_kills_game_kit_basic_solo_default { get; set; }

    [JsonPropertyName("longest_bow_kill")]
    public float longest_bow_kill { get; set; }

    [JsonPropertyName("longest_bow_kill_kit_basic_solo_default")]
    public float longest_bow_kill_kit_basic_solo_default { get; set; }

    [JsonPropertyName("longest_bow_kill_solo")]
    public float longest_bow_kill_solo { get; set; }

    [JsonPropertyName("melee_kills_solo")]
    public float melee_kills_solo { get; set; }

    [JsonPropertyName("kills_weekly_b")]
    public float kills_weekly_b { get; set; }

    [JsonPropertyName("kills_solo_normal")]
    public float kills_solo_normal { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("kills_kit_basic_solo_default")]
    public float kills_kit_basic_solo_default { get; set; }

    [JsonPropertyName("melee_kills")]
    public float melee_kills { get; set; }

    [JsonPropertyName("kills_solo")]
    public float kills_solo { get; set; }

    [JsonPropertyName("games_solo")]
    public float games_solo { get; set; }

    [JsonPropertyName("melee_kills_kit_basic_solo_default")]
    public float melee_kills_kit_basic_solo_default { get; set; }

    [JsonPropertyName("souls_gathered")]
    public float souls_gathered { get; set; }

    [JsonPropertyName("games_kit_basic_solo_default")]
    public float games_kit_basic_solo_default { get; set; }

    [JsonPropertyName("kills_monthly_a")]
    public float kills_monthly_a { get; set; }

    [JsonPropertyName("lucky_explained")]
    public float lucky_explained { get; set; }

    [JsonPropertyName("lucky_explained_last")]
    public long lucky_explained_last { get; set; }

    [JsonPropertyName("chests_opened_lab_team")]
    public float chests_opened_lab_team { get; set; }

    [JsonPropertyName("survived_players_lab_team")]
    public float survived_players_lab_team { get; set; }

    [JsonPropertyName("time_played_lab_team")]
    public float time_played_lab_team { get; set; }

    [JsonPropertyName("losses_lab_team")]
    public float losses_lab_team { get; set; }

    [JsonPropertyName("deaths_lab_team")]
    public float deaths_lab_team { get; set; }

    [JsonPropertyName("most_kills_game_lab_kit_defending_team_frog")]
    public float most_kills_game_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("most_kills_game_lab_team")]
    public float most_kills_game_lab_team { get; set; }

    [JsonPropertyName("kills_lab_kit_defending_team_frog")]
    public float kills_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("kills_lab_team")]
    public float kills_lab_team { get; set; }

    [JsonPropertyName("void_kills_lab_kit_defending_team_frog")]
    public float void_kills_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("void_kills_lab_team")]
    public float void_kills_lab_team { get; set; }

    [JsonPropertyName("fastest_win_lab_kit_defending_team_frog")]
    public float fastest_win_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("fastest_win_lab_team")]
    public float fastest_win_lab_team { get; set; }

    [JsonPropertyName("arrows_shot_lab_kit_defending_team_frog")]
    public float arrows_shot_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("killstreak_lab")]
    public float killstreak_lab { get; set; }

    [JsonPropertyName("arrows_shot_lab_team")]
    public float arrows_shot_lab_team { get; set; }

    [JsonPropertyName("wins_lab_kit_defending_team_frog")]
    public float wins_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("winstreak_lab_kit_defending_team_frog")]
    public float winstreak_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("lab_win_lucky_blocks_lab_team")]
    public float lab_win_lucky_blocks_lab_team { get; set; }

    [JsonPropertyName("winstreak_lab_team")]
    public float winstreak_lab_team { get; set; }

    [JsonPropertyName("lab_win_lucky_blocks_lab")]
    public float lab_win_lucky_blocks_lab { get; set; }

    [JsonPropertyName("killstreak_lab_kit_defending_team_frog")]
    public float killstreak_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("games_lab_team")]
    public float games_lab_team { get; set; }

    [JsonPropertyName("killstreak_lab_team")]
    public float killstreak_lab_team { get; set; }

    [JsonPropertyName("wins_lab_team")]
    public float wins_lab_team { get; set; }

    [JsonPropertyName("lab_win_lucky_blocks_lab_kit_defending_team_frog")]
    public float lab_win_lucky_blocks_lab_kit_defending_team_frog { get; set; }

    [JsonPropertyName("luckyBlockResourcePackEnabled")]
    public bool luckyBlockResourcePackEnabled { get; set; }

    [JsonPropertyName("levelFormatted")]
    public string levelFormatted { get; set; }

    [JsonPropertyName("skywars_chests")]
    public float skywars_chests { get; set; }

    [JsonPropertyName("mega_instant_smelting")]
    public float mega_instant_smelting { get; set; }

    [JsonPropertyName("chests_opened_kit_ranked_ranked_default")]
    public float chests_opened_kit_ranked_ranked_default { get; set; }

    [JsonPropertyName("chests_opened_ranked")]
    public float chests_opened_ranked { get; set; }

    [JsonPropertyName("deaths_kit_ranked_ranked_default")]
    public float deaths_kit_ranked_ranked_default { get; set; }

    [JsonPropertyName("deaths_ranked")]
    public float deaths_ranked { get; set; }

    [JsonPropertyName("deaths_ranked_normal")]
    public float deaths_ranked_normal { get; set; }

    [JsonPropertyName("games_kit_ranked_ranked_default")]
    public float games_kit_ranked_ranked_default { get; set; }

    [JsonPropertyName("games_ranked")]
    public float games_ranked { get; set; }

    [JsonPropertyName("losses_kit_ranked_ranked_default")]
    public float losses_kit_ranked_ranked_default { get; set; }

    [JsonPropertyName("losses_ranked")]
    public float losses_ranked { get; set; }

    [JsonPropertyName("losses_ranked_normal")]
    public float losses_ranked_normal { get; set; }

    [JsonPropertyName("survived_players_kit_ranked_ranked_default")]
    public float survived_players_kit_ranked_ranked_default { get; set; }

    [JsonPropertyName("survived_players_ranked")]
    public float survived_players_ranked { get; set; }

    [JsonPropertyName("time_played_kit_ranked_ranked_default")]
    public float time_played_kit_ranked_ranked_default { get; set; }

    [JsonPropertyName("time_played_ranked")]
    public float time_played_ranked { get; set; }

    [JsonPropertyName("arrows_shot_kit_mining_team_default")]
    public float arrows_shot_kit_mining_team_default { get; set; }

    [JsonPropertyName("arrows_shot_team")]
    public float arrows_shot_team { get; set; }

    [JsonPropertyName("chests_opened_kit_mining_team_default")]
    public float chests_opened_kit_mining_team_default { get; set; }

    [JsonPropertyName("deaths_kit_mining_team_default")]
    public float deaths_kit_mining_team_default { get; set; }

    [JsonPropertyName("deaths_team_insane")]
    public float deaths_team_insane { get; set; }

    [JsonPropertyName("losses_kit_mining_team_default")]
    public float losses_kit_mining_team_default { get; set; }

    [JsonPropertyName("losses_team_insane")]
    public float losses_team_insane { get; set; }

    [JsonPropertyName("survived_players_kit_mining_team_default")]
    public float survived_players_kit_mining_team_default { get; set; }

    [JsonPropertyName("time_played_kit_mining_team_default")]
    public float time_played_kit_mining_team_default { get; set; }

    [JsonPropertyName("chests_opened_mega")]
    public float chests_opened_mega { get; set; }

    [JsonPropertyName("deaths_mega")]
    public float deaths_mega { get; set; }

    [JsonPropertyName("deaths_mega_normal")]
    public float deaths_mega_normal { get; set; }

    [JsonPropertyName("losses_mega")]
    public float losses_mega { get; set; }

    [JsonPropertyName("losses_mega_normal")]
    public float losses_mega_normal { get; set; }

    [JsonPropertyName("survived_players_mega")]
    public float survived_players_mega { get; set; }

    [JsonPropertyName("time_played_mega")]
    public float time_played_mega { get; set; }

    [JsonPropertyName("arrows_shot_lab_kit_mining_team_default")]
    public float arrows_shot_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("kills_lab_kit_mining_team_default")]
    public float kills_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("most_kills_game_lab_kit_mining_team_default")]
    public float most_kills_game_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("void_kills_lab_kit_mining_team_default")]
    public float void_kills_lab_kit_mining_team_default { get; set; }

    [JsonPropertyName("deaths_solo_insane")]
    public float deaths_solo_insane { get; set; }

    [JsonPropertyName("losses_solo_insane")]
    public float losses_solo_insane { get; set; }

    [JsonPropertyName("chests_opened_kit_defending_team_frog")]
    public float chests_opened_kit_defending_team_frog { get; set; }

    [JsonPropertyName("deaths_kit_defending_team_frog")]
    public float deaths_kit_defending_team_frog { get; set; }

    [JsonPropertyName("heads")]
    public float heads { get; set; }

    [JsonPropertyName("heads_eww")]
    public float heads_eww { get; set; }

    [JsonPropertyName("heads_eww_kit_defending_team_frog")]
    public float heads_eww_kit_defending_team_frog { get; set; }

    [JsonPropertyName("heads_eww_team")]
    public float heads_eww_team { get; set; }

    [JsonPropertyName("heads_kit_defending_team_frog")]
    public float heads_kit_defending_team_frog { get; set; }

    [JsonPropertyName("heads_team")]
    public float heads_team { get; set; }

    [JsonPropertyName("kills_kit_defending_team_frog")]
    public float kills_kit_defending_team_frog { get; set; }

    [JsonPropertyName("kills_team")]
    public float kills_team { get; set; }

    [JsonPropertyName("kills_team_insane")]
    public float kills_team_insane { get; set; }

    [JsonPropertyName("longest_bow_kill_kit_defending_team_frog")]
    public float longest_bow_kill_kit_defending_team_frog { get; set; }

    [JsonPropertyName("longest_bow_kill_team")]
    public float longest_bow_kill_team { get; set; }

    [JsonPropertyName("losses_kit_defending_team_frog")]
    public float losses_kit_defending_team_frog { get; set; }

    [JsonPropertyName("melee_kills_kit_defending_team_frog")]
    public float melee_kills_kit_defending_team_frog { get; set; }

    [JsonPropertyName("melee_kills_team")]
    public float melee_kills_team { get; set; }

    [JsonPropertyName("most_kills_game_kit_defending_team_frog")]
    public float most_kills_game_kit_defending_team_frog { get; set; }

    [JsonPropertyName("most_kills_game_team")]
    public float most_kills_game_team { get; set; }

    [JsonPropertyName("survived_players_kit_defending_team_frog")]
    public float survived_players_kit_defending_team_frog { get; set; }

    [JsonPropertyName("time_played_kit_defending_team_frog")]
    public float time_played_kit_defending_team_frog { get; set; }

    [JsonPropertyName("head_collection")]
    public HeadCollection head_collection { get; set; }

    [JsonPropertyName("kills_kit_mining_team_default")]
    public float kills_kit_mining_team_default { get; set; }

    [JsonPropertyName("longest_bow_kill_kit_mining_team_default")]
    public float longest_bow_kill_kit_mining_team_default { get; set; }

    [JsonPropertyName("melee_kills_kit_mining_team_default")]
    public float melee_kills_kit_mining_team_default { get; set; }

    [JsonPropertyName("most_kills_game_kit_mining_team_default")]
    public float most_kills_game_kit_mining_team_default { get; set; }

    [JsonPropertyName("arrows_hit")]
    public float arrows_hit { get; set; }

    [JsonPropertyName("arrows_hit_kit_mining_team_default")]
    public float arrows_hit_kit_mining_team_default { get; set; }

    [JsonPropertyName("arrows_hit_team")]
    public float arrows_hit_team { get; set; }

    [JsonPropertyName("games_kit_mining_team_default")]
    public float games_kit_mining_team_default { get; set; }

    [JsonPropertyName("games_team")]
    public float games_team { get; set; }

    [JsonPropertyName("longest_bow_shot")]
    public float longest_bow_shot { get; set; }

    [JsonPropertyName("longest_bow_shot_kit_mining_team_default")]
    public float longest_bow_shot_kit_mining_team_default { get; set; }

    [JsonPropertyName("longest_bow_shot_team")]
    public float longest_bow_shot_team { get; set; }

    [JsonPropertyName("lastTourneyAd")]
    public long lastTourneyAd { get; set; }

    [JsonPropertyName("arrows_hit_kit_supporting_team_healer")]
    public float arrows_hit_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("arrows_hit_solo")]
    public float arrows_hit_solo { get; set; }

    [JsonPropertyName("arrows_shot_kit_supporting_team_healer")]
    public float arrows_shot_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("arrows_shot_solo")]
    public float arrows_shot_solo { get; set; }

    [JsonPropertyName("chests_opened_kit_supporting_team_healer")]
    public float chests_opened_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("deaths_kit_supporting_team_healer")]
    public float deaths_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("games_kit_supporting_team_healer")]
    public float games_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("items_enchanted")]
    public float items_enchanted { get; set; }

    [JsonPropertyName("longest_bow_shot_kit_supporting_team_healer")]
    public float longest_bow_shot_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("longest_bow_shot_solo")]
    public float longest_bow_shot_solo { get; set; }

    [JsonPropertyName("losses_kit_supporting_team_healer")]
    public float losses_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("survived_players_kit_supporting_team_healer")]
    public float survived_players_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("time_played_kit_supporting_team_healer")]
    public float time_played_kit_supporting_team_healer { get; set; }

    [JsonPropertyName("chests_opened_kit_attacking_team_scout")]
    public float chests_opened_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("deaths_kit_attacking_team_scout")]
    public float deaths_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("losses_kit_attacking_team_scout")]
    public float losses_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("survived_players_kit_attacking_team_scout")]
    public float survived_players_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("time_played_kit_attacking_team_scout")]
    public float time_played_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("arrows_hit_kit_attacking_team_scout")]
    public float arrows_hit_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("arrows_shot_kit_attacking_team_scout")]
    public float arrows_shot_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("longest_bow_shot_kit_attacking_team_scout")]
    public float longest_bow_shot_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("team_savior")]
    public float team_savior { get; set; }

    [JsonPropertyName("xezbeth_luck")]
    public float xezbeth_luck { get; set; }

    [JsonPropertyName("mega_notoriety")]
    public float mega_notoriety { get; set; }

    [JsonPropertyName("soul_well_legendaries")]
    public float soul_well_legendaries { get; set; }

    [JsonPropertyName("mobs_killed_lab")]
    public float mobs_killed_lab { get; set; }

    [JsonPropertyName("mobs_killed_lab_kit_attacking_team_scout")]
    public float mobs_killed_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("mobs_killed_lab_solo")]
    public float mobs_killed_lab_solo { get; set; }

    [JsonPropertyName("refill_chest_destroy_lab")]
    public float refill_chest_destroy_lab { get; set; }

    [JsonPropertyName("lab_win_lucky_blocks_lab_kit_attacking_team_scout")]
    public float lab_win_lucky_blocks_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("lab_win_lucky_blocks_lab_solo")]
    public float lab_win_lucky_blocks_lab_solo { get; set; }

    [JsonPropertyName("killstreak_lab_kit_attacking_team_scout")]
    public float killstreak_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("killstreak_lab_solo")]
    public float killstreak_lab_solo { get; set; }

    [JsonPropertyName("games_kit_attacking_team_scout")]
    public float games_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("chests_opened_kit_basic_solo_ecologist")]
    public float chests_opened_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("deaths_kit_basic_solo_ecologist")]
    public float deaths_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("losses_kit_basic_solo_ecologist")]
    public float losses_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("survived_players_kit_basic_solo_ecologist")]
    public float survived_players_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("time_played_kit_basic_solo_ecologist")]
    public float time_played_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("perkslot")]
    public Perkslot perkslot { get; set; }

    [JsonPropertyName("toggle_mega_arrow_recovery")]
    public bool toggle_mega_arrow_recovery { get; set; }

    [JsonPropertyName("toggle_mega_rusher")]
    public bool toggle_mega_rusher { get; set; }

    [JsonPropertyName("toggle_mega_nourishment")]
    public bool toggle_mega_nourishment { get; set; }

    [JsonPropertyName("toggle_mega_notoriety")]
    public bool toggle_mega_notoriety { get; set; }

    [JsonPropertyName("toggle_mega_environmental_expert")]
    public bool toggle_mega_environmental_expert { get; set; }

    [JsonPropertyName("toggle_ranked_magician_perk")]
    public bool toggle_ranked_magician_perk { get; set; }

    [JsonPropertyName("toggle_mega_mining_expertise")]
    public bool toggle_mega_mining_expertise { get; set; }

    [JsonPropertyName("toggle_ranked_blacksmith_perk")]
    public bool toggle_ranked_blacksmith_perk { get; set; }

    [JsonPropertyName("toggle_ranked_armorer_perk")]
    public bool toggle_ranked_armorer_perk { get; set; }

    [JsonPropertyName("toggle_ranked_scout_perk")]
    public bool toggle_ranked_scout_perk { get; set; }

    [JsonPropertyName("toggle_ranked_paladin_perk")]
    public bool toggle_ranked_paladin_perk { get; set; }

    [JsonPropertyName("toggle_mega_bridger")]
    public bool toggle_mega_bridger { get; set; }

    [JsonPropertyName("toggle_ranked_blazing_arrows")]
    public bool toggle_ranked_blazing_arrows { get; set; }

    [JsonPropertyName("toggle_mega_lucky_charm")]
    public bool toggle_mega_lucky_charm { get; set; }

    [JsonPropertyName("toggle_ranked_pyromancer_perk")]
    public bool toggle_ranked_pyromancer_perk { get; set; }

    [JsonPropertyName("toggle_ranked_healer_perk")]
    public bool toggle_ranked_healer_perk { get; set; }

    [JsonPropertyName("toggle_ranked_rusher")]
    public bool toggle_ranked_rusher { get; set; }

    [JsonPropertyName("toggle_mega_blazing_arrows")]
    public bool toggle_mega_blazing_arrows { get; set; }

    [JsonPropertyName("toggle_ranked_tough_skin")]
    public bool toggle_ranked_tough_skin { get; set; }

    [JsonPropertyName("toggle_ranked_bridger")]
    public bool toggle_ranked_bridger { get; set; }

    [JsonPropertyName("toggle_ranked_hound_perk")]
    public bool toggle_ranked_hound_perk { get; set; }

    [JsonPropertyName("toggle_ranked_arrow_recovery")]
    public bool toggle_ranked_arrow_recovery { get; set; }

    [JsonPropertyName("toggle_mega_tank")]
    public bool toggle_mega_tank { get; set; }

    [JsonPropertyName("toggle_team_bulldozer")]
    public bool toggle_team_bulldozer { get; set; }

    [JsonPropertyName("toggle_ranked_last_stand")]
    public bool toggle_ranked_last_stand { get; set; }

    [JsonPropertyName("toggle_team_blazing_arrows")]
    public bool toggle_team_blazing_arrows { get; set; }

    [JsonPropertyName("toggle_team_juggernaut")]
    public bool toggle_team_juggernaut { get; set; }

    [JsonPropertyName("team_juggernaut")]
    public float team_juggernaut { get; set; }

    [JsonPropertyName("team_resistance_boost")]
    public float team_resistance_boost { get; set; }

    [JsonPropertyName("toggle_team_mining_expertise")]
    public bool toggle_team_mining_expertise { get; set; }

    [JsonPropertyName("toggle_team_knowledge")]
    public bool toggle_team_knowledge { get; set; }

    [JsonPropertyName("toggle_team_annoy-o-mite")]
    public bool toggle_team_annoyomite { get; set; }

    [JsonPropertyName("toggle_team_arrow_recovery")]
    public bool toggle_team_arrow_recovery { get; set; }

    [JsonPropertyName("toggle_ranked_juggernaut")]
    public bool toggle_ranked_juggernaut { get; set; }

    [JsonPropertyName("toggle_team_nourishment")]
    public bool toggle_team_nourishment { get; set; }

    [JsonPropertyName("toggle_team_marksmanship")]
    public bool toggle_team_marksmanship { get; set; }

    [JsonPropertyName("team_fat")]
    public float team_fat { get; set; }

    [JsonPropertyName("toggle_team_fat")]
    public bool toggle_team_fat { get; set; }

    [JsonPropertyName("toggle_team_resistance_boost")]
    public bool toggle_team_resistance_boost { get; set; }

    [JsonPropertyName("toggle_team_lucky_charm")]
    public bool toggle_team_lucky_charm { get; set; }

    [JsonPropertyName("toggle_ranked_environmental_expert")]
    public bool toggle_ranked_environmental_expert { get; set; }

    [JsonPropertyName("toggle_team_bridger")]
    public bool toggle_team_bridger { get; set; }

    [JsonPropertyName("toggle_ranked_athlete_perk")]
    public bool toggle_ranked_athlete_perk { get; set; }

    [JsonPropertyName("toggle_team_robbery")]
    public bool toggle_team_robbery { get; set; }

    [JsonPropertyName("toggle_team_necromancer")]
    public bool toggle_team_necromancer { get; set; }

    [JsonPropertyName("toggle_mega_necromancer")]
    public bool toggle_mega_necromancer { get; set; }

    [JsonPropertyName("toggle_team_environmental_expert")]
    public bool toggle_team_environmental_expert { get; set; }

    [JsonPropertyName("toggle_solo_arrow_recovery")]
    public bool toggle_solo_arrow_recovery { get; set; }

    [JsonPropertyName("solo_bulldozer")]
    public float solo_bulldozer { get; set; }

    [JsonPropertyName("toggle_solo_bulldozer")]
    public bool toggle_solo_bulldozer { get; set; }

    [JsonPropertyName("solo_juggernaut")]
    public float solo_juggernaut { get; set; }

    [JsonPropertyName("toggle_team_frost")]
    public bool toggle_team_frost { get; set; }

    [JsonPropertyName("toggle_solo_juggernaut")]
    public bool toggle_solo_juggernaut { get; set; }

    [JsonPropertyName("toggle_solo_marksmanship")]
    public bool toggle_solo_marksmanship { get; set; }

    [JsonPropertyName("toggle_solo_mining_expertise")]
    public bool toggle_solo_mining_expertise { get; set; }

    [JsonPropertyName("toggle_solo_lucky_charm")]
    public bool toggle_solo_lucky_charm { get; set; }

    [JsonPropertyName("solo_resistance_boost")]
    public float solo_resistance_boost { get; set; }

    [JsonPropertyName("toggle_team_speed_boost")]
    public bool toggle_team_speed_boost { get; set; }

    [JsonPropertyName("toggle_solo_speed_boost")]
    public bool toggle_solo_speed_boost { get; set; }

    [JsonPropertyName("toggle_solo_resistance_boost")]
    public bool toggle_solo_resistance_boost { get; set; }

    [JsonPropertyName("toggle_mega_black_magic")]
    public bool toggle_mega_black_magic { get; set; }

    [JsonPropertyName("solo_savior")]
    public float solo_savior { get; set; }

    [JsonPropertyName("toggle_solo_knowledge")]
    public bool toggle_solo_knowledge { get; set; }

    [JsonPropertyName("toggle_solo_nourishment")]
    public bool toggle_solo_nourishment { get; set; }

    [JsonPropertyName("toggle_solo_revenge")]
    public bool toggle_solo_revenge { get; set; }

    [JsonPropertyName("solo_fat")]
    public float solo_fat { get; set; }

    [JsonPropertyName("toggle_solo_fat")]
    public bool toggle_solo_fat { get; set; }

    [JsonPropertyName("toggle_solo_bridger")]
    public bool toggle_solo_bridger { get; set; }

    [JsonPropertyName("toggle_solo_environmental_expert")]
    public bool toggle_solo_environmental_expert { get; set; }

    [JsonPropertyName("toggle_solo_necromancer")]
    public bool toggle_solo_necromancer { get; set; }

    [JsonPropertyName("toggle_solo_black_magic")]
    public bool toggle_solo_black_magic { get; set; }

    [JsonPropertyName("toggle_team_black_magic")]
    public bool toggle_team_black_magic { get; set; }

    [JsonPropertyName("toggle_solo_barbarian")]
    public bool toggle_solo_barbarian { get; set; }

    [JsonPropertyName("toggle_solo_annoy-o-mite")]
    public bool toggle_solo_annoyomite { get; set; }

    [JsonPropertyName("toggle_mega_juggernaut")]
    public bool toggle_mega_juggernaut { get; set; }

    [JsonPropertyName("toggle_solo_savior")]
    public bool toggle_solo_savior { get; set; }

    [JsonPropertyName("team_bulldozer")]
    public float team_bulldozer { get; set; }

    [JsonPropertyName("toggle_solo_frost")]
    public bool toggle_solo_frost { get; set; }

    [JsonPropertyName("toggle_mega_marksmanship")]
    public bool toggle_mega_marksmanship { get; set; }

    [JsonPropertyName("toggle_solo_robbery")]
    public bool toggle_solo_robbery { get; set; }

    [JsonPropertyName("toggle_ranked_champion_perk")]
    public bool toggle_ranked_champion_perk { get; set; }

    [JsonPropertyName("toggle_team_barbarian")]
    public bool toggle_team_barbarian { get; set; }

    [JsonPropertyName("toggle_solo_blazing_arrows")]
    public bool toggle_solo_blazing_arrows { get; set; }

    [JsonPropertyName("toggle_ranked_bowman_perk")]
    public bool toggle_ranked_bowman_perk { get; set; }

    [JsonPropertyName("toggle_team_savior")]
    public bool toggle_team_savior { get; set; }

    [JsonPropertyName("toggle_team_diamondpiercer")]
    public bool toggle_team_diamondpiercer { get; set; }

    [JsonPropertyName("toggle_ranked_mining_expertise")]
    public bool toggle_ranked_mining_expertise { get; set; }

    [JsonPropertyName("assists_lab")]
    public float assists_lab { get; set; }

    [JsonPropertyName("assists_lab_kit_attacking_team_scout")]
    public float assists_lab_kit_attacking_team_scout { get; set; }

    [JsonPropertyName("assists_lab_solo")]
    public float assists_lab_solo { get; set; }

    [JsonPropertyName("chests_opened_lab_kit_defending_team_baseball-player")]
    public float chests_opened_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("deaths_lab_kit_defending_team_baseball-player")]
    public float deaths_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("losses_lab_kit_defending_team_baseball-player")]
    public float losses_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("survived_players_lab_kit_defending_team_baseball-player")]
    public float survived_players_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("time_played_lab_kit_defending_team_baseball-player")]
    public float time_played_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("games_lab_kit_defending_team_baseball-player")]
    public float games_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("kills_lab_kit_defending_team_baseball-player")]
    public float kills_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("longest_bow_kill_lab_kit_defending_team_baseball-player")]
    public float longest_bow_kill_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("melee_kills_lab_kit_defending_team_baseball-player")]
    public float melee_kills_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("most_kills_game_lab_kit_defending_team_baseball-player")]
    public float most_kills_game_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("arrows_shot_lab_kit_defending_team_baseball-player")]
    public float arrows_shot_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("mobs_killed_lab_kit_defending_team_baseball-player")]
    public float mobs_killed_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("arrows_hit_lab_kit_defending_team_baseball-player")]
    public float arrows_hit_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("bow_kills_lab")]
    public float bow_kills_lab { get; set; }

    [JsonPropertyName("bow_kills_lab_kit_defending_team_baseball-player")]
    public float bow_kills_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("bow_kills_lab_solo")]
    public float bow_kills_lab_solo { get; set; }

    [JsonPropertyName("fastest_win_lab_kit_defending_team_baseball-player")]
    public float fastest_win_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("killstreak_lab_kit_defending_team_baseball-player")]
    public float killstreak_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("lab_win_lucky_blocks_lab_kit_defending_team_baseball-player")]
    public float lab_win_lucky_blocks_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("longest_bow_shot_lab_kit_defending_team_baseball-player")]
    public float longest_bow_shot_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("wins_lab_kit_defending_team_baseball-player")]
    public float wins_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("extra_wheels")]
    public float extra_wheels { get; set; }

    [JsonPropertyName("levelFormattedWithBrackets")]
    public string levelFormattedWithBrackets { get; set; }

    [JsonPropertyName("chests_opened_kit_advanced_solo_enchanter")]
    public float chests_opened_kit_advanced_solo_enchanter { get; set; }

    [JsonPropertyName("deaths_kit_advanced_solo_enchanter")]
    public float deaths_kit_advanced_solo_enchanter { get; set; }

    [JsonPropertyName("games_kit_advanced_solo_enchanter")]
    public float games_kit_advanced_solo_enchanter { get; set; }

    [JsonPropertyName("losses_kit_advanced_solo_enchanter")]
    public float losses_kit_advanced_solo_enchanter { get; set; }

    [JsonPropertyName("survived_players_kit_advanced_solo_enchanter")]
    public float survived_players_kit_advanced_solo_enchanter { get; set; }

    [JsonPropertyName("time_played_kit_advanced_solo_enchanter")]
    public float time_played_kit_advanced_solo_enchanter { get; set; }

    [JsonPropertyName("void_kills_lab_kit_defending_team_baseball-player")]
    public float void_kills_lab_kit_defending_team_baseballplayer { get; set; }

    [JsonPropertyName("assists")]
    public float assists { get; set; }

    [JsonPropertyName("assists_kit_basic_solo_scout")]
    public float assists_kit_basic_solo_scout { get; set; }

    [JsonPropertyName("assists_solo")]
    public float assists_solo { get; set; }

    [JsonPropertyName("chests_opened_kit_attacking_team_knight")]
    public float chests_opened_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("deaths_kit_attacking_team_knight")]
    public float deaths_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("kills_kit_attacking_team_knight")]
    public float kills_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("kills_solo_insane")]
    public float kills_solo_insane { get; set; }

    [JsonPropertyName("longest_bow_kill_kit_attacking_team_knight")]
    public float longest_bow_kill_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("losses_kit_attacking_team_knight")]
    public float losses_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("melee_kills_kit_attacking_team_knight")]
    public float melee_kills_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("most_kills_game_kit_attacking_team_knight")]
    public float most_kills_game_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("survived_players_kit_attacking_team_knight")]
    public float survived_players_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("time_played_kit_attacking_team_knight")]
    public float time_played_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("arrows_shot_kit_attacking_team_knight")]
    public float arrows_shot_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("fastest_win")]
    public float fastest_win { get; set; }

    [JsonPropertyName("fastest_win_kit_attacking_team_knight")]
    public float fastest_win_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("fastest_win_solo")]
    public float fastest_win_solo { get; set; }

    [JsonPropertyName("games_kit_attacking_team_knight")]
    public float games_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("heads_decent")]
    public float heads_decent { get; set; }

    [JsonPropertyName("heads_decent_kit_attacking_team_knight")]
    public float heads_decent_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("heads_decent_solo")]
    public float heads_decent_solo { get; set; }

    [JsonPropertyName("heads_eww_kit_attacking_team_knight")]
    public float heads_eww_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("heads_eww_solo")]
    public float heads_eww_solo { get; set; }

    [JsonPropertyName("heads_kit_attacking_team_knight")]
    public float heads_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("heads_meh")]
    public float heads_meh { get; set; }

    [JsonPropertyName("heads_meh_kit_attacking_team_knight")]
    public float heads_meh_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("heads_meh_solo")]
    public float heads_meh_solo { get; set; }

    [JsonPropertyName("heads_solo")]
    public float heads_solo { get; set; }

    [JsonPropertyName("heads_yucky")]
    public float heads_yucky { get; set; }

    [JsonPropertyName("heads_yucky_kit_attacking_team_knight")]
    public float heads_yucky_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("heads_yucky_solo")]
    public float heads_yucky_solo { get; set; }

    [JsonPropertyName("killstreak")]
    public float killstreak { get; set; }

    [JsonPropertyName("killstreak_kit_attacking_team_knight")]
    public float killstreak_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("killstreak_solo")]
    public float killstreak_solo { get; set; }

    [JsonPropertyName("void_kills")]
    public float void_kills { get; set; }

    [JsonPropertyName("void_kills_kit_attacking_team_knight")]
    public float void_kills_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("void_kills_solo")]
    public float void_kills_solo { get; set; }

    [JsonPropertyName("wins")]
    public float wins { get; set; }

    [JsonPropertyName("wins_kit_attacking_team_knight")]
    public float wins_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("wins_solo")]
    public float wins_solo { get; set; }

    [JsonPropertyName("wins_solo_insane")]
    public float wins_solo_insane { get; set; }

    [JsonPropertyName("cosmetic_tokens")]
    public float cosmetic_tokens { get; set; }

    [JsonPropertyName("assists_kit_attacking_team_knight")]
    public float assists_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("enderpearls_thrown")]
    public float enderpearls_thrown { get; set; }

    [JsonPropertyName("kills_kit_basic_solo_ecologist")]
    public float kills_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("longest_bow_kill_kit_basic_solo_ecologist")]
    public float longest_bow_kill_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("melee_kills_kit_basic_solo_ecologist")]
    public float melee_kills_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("most_kills_game_kit_basic_solo_ecologist")]
    public float most_kills_game_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("arrows_shot_kit_basic_solo_ecologist")]
    public float arrows_shot_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("games_kit_basic_solo_ecologist")]
    public float games_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("fastest_win_kit_basic_solo_ecologist")]
    public float fastest_win_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("killstreak_kit_basic_solo_ecologist")]
    public float killstreak_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("mobs_killed")]
    public float mobs_killed { get; set; }

    [JsonPropertyName("mobs_killed_kit_basic_solo_ecologist")]
    public float mobs_killed_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("mobs_killed_solo")]
    public float mobs_killed_solo { get; set; }

    [JsonPropertyName("void_kills_kit_basic_solo_ecologist")]
    public float void_kills_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("wins_kit_basic_solo_ecologist")]
    public float wins_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("wins_solo_normal")]
    public float wins_solo_normal { get; set; }

    [JsonPropertyName("arrows_hit_kit_basic_solo_ecologist")]
    public float arrows_hit_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("longest_bow_shot_kit_basic_solo_ecologist")]
    public float longest_bow_shot_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("assists_kit_basic_solo_ecologist")]
    public float assists_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("heads_kit_basic_solo_ecologist")]
    public float heads_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("heads_salty")]
    public float heads_salty { get; set; }

    [JsonPropertyName("heads_salty_kit_basic_solo_ecologist")]
    public float heads_salty_kit_basic_solo_ecologist { get; set; }

    [JsonPropertyName("heads_salty_solo")]
    public float heads_salty_solo { get; set; }

    [JsonPropertyName("team_lucky_charm")]
    public float team_lucky_charm { get; set; }

    [JsonPropertyName("mega_nourishment")]
    public float mega_nourishment { get; set; }

    [JsonPropertyName("SkyWars_openedChests")]
    public float SkyWars_openedChests { get; set; }

    [JsonPropertyName("SkyWars_openedCommons")]
    public float SkyWars_openedCommons { get; set; }

    [JsonPropertyName("SkyWars_openedRares")]
    public float SkyWars_openedRares { get; set; }

    [JsonPropertyName("skywars_chest_history")]
    public List<string> skywars_chest_history { get; set; }

    [JsonPropertyName("active_killmessages")]
    public string active_killmessages { get; set; }

    [JsonPropertyName("SkyWars_openedEpics")]
    public float SkyWars_openedEpics { get; set; }

    [JsonPropertyName("SkyWars_openedLegendaries")]
    public float SkyWars_openedLegendaries { get; set; }

    [JsonPropertyName("active_projectiletrail")]
    public string active_projectiletrail { get; set; }

    [JsonPropertyName("active_cage")]
    public string active_cage { get; set; }

    [JsonPropertyName("arrows_hit_kit_attacking_team_knight")]
    public float arrows_hit_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("longest_bow_shot_kit_attacking_team_knight")]
    public float longest_bow_shot_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("arrows_shot_lab_kit_attacking_team_knight")]
    public float arrows_shot_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("chests_opened_lab_kit_attacking_team_knight")]
    public float chests_opened_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("deaths_lab_kit_attacking_team_knight")]
    public float deaths_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("games_lab_kit_attacking_team_knight")]
    public float games_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("losses_lab_kit_attacking_team_knight")]
    public float losses_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("survived_players_lab_kit_attacking_team_knight")]
    public float survived_players_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("time_played_lab_kit_attacking_team_knight")]
    public float time_played_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("arrows_hit_lab_kit_attacking_team_knight")]
    public float arrows_hit_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("assists_lab_kit_attacking_team_knight")]
    public float assists_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("mobs_killed_lab_kit_attacking_team_knight")]
    public float mobs_killed_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("kills_lab_kit_attacking_team_knight")]
    public float kills_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("longest_bow_shot_lab_kit_attacking_team_knight")]
    public float longest_bow_shot_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("mob_kills_lab")]
    public float mob_kills_lab { get; set; }

    [JsonPropertyName("mob_kills_lab_kit_attacking_team_knight")]
    public float mob_kills_lab_kit_attacking_team_knight { get; set; }

    [JsonPropertyName("mob_kills_lab_solo")]
    public float mob_kills_lab_solo { get; set; }

    [JsonPropertyName("inGamePresentsCap_2023_1")]
    public float inGamePresentsCap_2023_1 { get; set; }

    [JsonPropertyName("skywars_christmas_boxes")]
    public float skywars_christmas_boxes { get; set; }

    [JsonPropertyName("opals")]
    public float opals { get; set; }

    [JsonPropertyName("angel_of_death_level")]
    public float angel_of_death_level { get; set; }

    [JsonPropertyName("selected_prestige_icon")]
    public string selected_prestige_icon { get; set; }

    [JsonPropertyName("inGamePresentsCap_2023_2")]
    public float inGamePresentsCap_2023_2 { get; set; }

    [JsonPropertyName("active_victorydance")]
    public string active_victorydance { get; set; }

    [JsonPropertyName("privategames")]
    public Privategames privategames { get; set; }

    [JsonPropertyName("shop_sort")]
    public string shop_sort { get; set; }

    [JsonPropertyName("harvesting_season")]
    public float harvesting_season { get; set; }
}

public class SkywarsArcadeWin
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsCorruptWin
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsDailyTokens
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsSoloKills
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsSoloWin
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsSpecialNorthPole
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsTeamKills
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsTeamWin
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsWeeklyArcadeWinAll
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsWeeklyFreeLootChest
{
    [JsonPropertyName("completions")]
    public List<Completion> completions { get; set; }

    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SkywarsWeeklyKills
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class Slumber
{
    [JsonPropertyName("quest")]
    public Quest quest { get; set; }

    [JsonPropertyName("fredgie")]
    public Fredgie fredgie { get; set; }

    [JsonPropertyName("bag_type")]
    public string bag_type { get; set; }

    [JsonPropertyName("tickets")]
    public float tickets { get; set; }

    [JsonPropertyName("total_tickets_earned")]
    public float total_tickets_earned { get; set; }

    [JsonPropertyName("tickets_given_doorman")]
    public float tickets_given_doorman { get; set; }

    [JsonPropertyName("tickets_requirement_met")]
    public bool tickets_requirement_met { get; set; }
}

public class SocialMedia
{
    [JsonPropertyName("links")]
    public Links links { get; set; }

    [JsonPropertyName("prompt")]
    public bool prompt { get; set; }
}

public class SoloBrawler
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class SpeedUHC
{
    [JsonPropertyName("activeMasterPerk")]
    public string activeMasterPerk { get; set; }

    [JsonPropertyName("activeKit_NORMAL")]
    public string activeKit_NORMAL { get; set; }

    [JsonPropertyName("killstreak")]
    public float killstreak { get; set; }

    [JsonPropertyName("blocks_broken")]
    public float blocks_broken { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("deaths_kit_basic_normal_default")]
    public float deaths_kit_basic_normal_default { get; set; }

    [JsonPropertyName("deaths_mastery_wild_specialist")]
    public float deaths_mastery_wild_specialist { get; set; }

    [JsonPropertyName("deaths_normal")]
    public float deaths_normal { get; set; }

    [JsonPropertyName("deaths_solo")]
    public float deaths_solo { get; set; }

    [JsonPropertyName("deaths_solo_normal")]
    public float deaths_solo_normal { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("losses_kit_basic_normal_default")]
    public float losses_kit_basic_normal_default { get; set; }

    [JsonPropertyName("losses_mastery_wild_specialist")]
    public float losses_mastery_wild_specialist { get; set; }

    [JsonPropertyName("losses_normal")]
    public float losses_normal { get; set; }

    [JsonPropertyName("losses_solo")]
    public float losses_solo { get; set; }

    [JsonPropertyName("losses_solo_normal")]
    public float losses_solo_normal { get; set; }

    [JsonPropertyName("quits")]
    public float quits { get; set; }

    [JsonPropertyName("win_streak")]
    public float win_streak { get; set; }

    [JsonPropertyName("blocks_placed")]
    public float blocks_placed { get; set; }

    [JsonPropertyName("survived_players")]
    public float survived_players { get; set; }

    [JsonPropertyName("survived_players_kit_basic_normal_default")]
    public float survived_players_kit_basic_normal_default { get; set; }

    [JsonPropertyName("survived_players_normal")]
    public float survived_players_normal { get; set; }

    [JsonPropertyName("survived_players_solo")]
    public float survived_players_solo { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }
}

public class SpireStashArmor
{
    [JsonPropertyName("type")]
    public float type { get; set; }

    [JsonPropertyName("data")]
    public List<int> data { get; set; }
}

public class SpireStashInv
{
    [JsonPropertyName("type")]
    public float type { get; set; }

    [JsonPropertyName("data")]
    public List<int> data { get; set; }
}

public class Started
{
    [JsonPropertyName("npc_reception_start")]
    public bool npc_reception_start { get; set; }

    [JsonPropertyName("npc_lady_saichi")]
    public bool npc_lady_saichi { get; set; }

    [JsonPropertyName("npc_general_daku")]
    public bool npc_general_daku { get; set; }

    [JsonPropertyName("npc_john_pireso")]
    public bool npc_john_pireso { get; set; }
}

public class Stats
{
    [JsonPropertyName("BuildBattle")]
    public BuildBattle BuildBattle { get; set; }

    [JsonPropertyName("TrueCombat")]
    public TrueCombat TrueCombat { get; set; }

    [JsonPropertyName("MCGO")]
    public MCGO MCGO { get; set; }

    [JsonPropertyName("Battleground")]
    public Battleground Battleground { get; set; }

    [JsonPropertyName("Duels")]
    public Duels Duels { get; set; }

    [JsonPropertyName("MurderMystery")]
    public MurderMystery MurderMystery { get; set; }

    [JsonPropertyName("SuperSmash")]
    public SuperSmash SuperSmash { get; set; }

    [JsonPropertyName("Arcade")]
    public Arcade Arcade { get; set; }

    [JsonPropertyName("SkyWars")]
    public SkyWars SkyWars { get; set; }

    [JsonPropertyName("HungerGames")]
    public HungerGames HungerGames { get; set; }

    [JsonPropertyName("SkyClash")]
    public SkyClash SkyClash { get; set; }

    [JsonPropertyName("TNTGames")]
    public TNTGames TNTGames { get; set; }

    [JsonPropertyName("Walls3")]
    public Walls3 Walls3 { get; set; }

    [JsonPropertyName("Pit")]
    public Pit Pit { get; set; }

    [JsonPropertyName("SkyBlock")]
    public SkyBlock SkyBlock { get; set; }

    [JsonPropertyName("UHC")]
    public UHC UHC { get; set; }

    [JsonPropertyName("GingerBread")]
    public GingerBread GingerBread { get; set; }

    [JsonPropertyName("Quake")]
    public Quake Quake { get; set; }

    [JsonPropertyName("Paintball")]
    public Paintball Paintball { get; set; }

    [JsonPropertyName("VampireZ")]
    public VampireZ VampireZ { get; set; }

    [JsonPropertyName("Legacy")]
    public Legacy Legacy { get; set; }

    [JsonPropertyName("SpeedUHC")]
    public SpeedUHC SpeedUHC { get; set; }

    [JsonPropertyName("Arena")]
    public Arena Arena { get; set; }

    [JsonPropertyName("Walls")]
    public Walls Walls { get; set; }

    [JsonPropertyName("WoolGames")]
    public WoolGames WoolGames { get; set; }

    [JsonPropertyName("MainLobby")]
    public MainLobby MainLobby { get; set; }

    [JsonPropertyName("classes")]
    public Classes classes { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("games_played")]
    public float games_played { get; set; }

    [JsonPropertyName("assists")]
    public float assists { get; set; }

    [JsonPropertyName("blocks_broken")]
    public float blocks_broken { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("powerups_gotten")]
    public float powerups_gotten { get; set; }

    [JsonPropertyName("wins")]
    public float wins { get; set; }

    [JsonPropertyName("wool_placed")]
    public float wool_placed { get; set; }
}

public class Summer
{
    [JsonPropertyName("2022")]
    public _2022 _2022 { get; set; }

    [JsonPropertyName("2023")]
    public _2023 _2023 { get; set; }

    [JsonPropertyName("2024")]
    public _2024 _2024 { get; set; }
}

public class SuperSmash
{
    [JsonPropertyName("lastLevel_THE_BULK")]
    public float lastLevel_THE_BULK { get; set; }

    [JsonPropertyName("win_streak")]
    public float win_streak { get; set; }

    [JsonPropertyName("class_stats")]
    public ClassStats class_stats { get; set; }

    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("losses_weekly_b")]
    public float losses_weekly_b { get; set; }

    [JsonPropertyName("losses_monthly_b")]
    public float losses_monthly_b { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("smashed_normal")]
    public float smashed_normal { get; set; }

    [JsonPropertyName("kills_monthly_b")]
    public float kills_monthly_b { get; set; }

    [JsonPropertyName("games_monthly_b")]
    public float games_monthly_b { get; set; }

    [JsonPropertyName("quits")]
    public float quits { get; set; }

    [JsonPropertyName("deaths_normal")]
    public float deaths_normal { get; set; }

    [JsonPropertyName("games_normal")]
    public float games_normal { get; set; }

    [JsonPropertyName("losses_normal")]
    public float losses_normal { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("smashed")]
    public float smashed { get; set; }

    [JsonPropertyName("kills_normal")]
    public float kills_normal { get; set; }

    [JsonPropertyName("games_weekly_b")]
    public float games_weekly_b { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("damage_dealt_normal")]
    public float damage_dealt_normal { get; set; }

    [JsonPropertyName("games")]
    public float games { get; set; }

    [JsonPropertyName("kills_weekly_b")]
    public float kills_weekly_b { get; set; }

    [JsonPropertyName("active_class")]
    public string active_class { get; set; }

    [JsonPropertyName("deaths_2v2")]
    public float deaths_2v2 { get; set; }

    [JsonPropertyName("damage_dealt_2v2")]
    public float damage_dealt_2v2 { get; set; }

    [JsonPropertyName("losses_2v2")]
    public float losses_2v2 { get; set; }

    [JsonPropertyName("losses_weekly_a")]
    public float losses_weekly_a { get; set; }

    [JsonPropertyName("games_weekly_a")]
    public float games_weekly_a { get; set; }

    [JsonPropertyName("games_2v2")]
    public float games_2v2 { get; set; }

    [JsonPropertyName("lastLevel_CAKE_MONSTER")]
    public float lastLevel_CAKE_MONSTER { get; set; }
}

public class Talk
{
    [JsonPropertyName("DoorManNpc")]
    public bool DoorManNpc { get; set; }

    [JsonPropertyName("HotelReceptionistNpc")]
    public bool HotelReceptionistNpc { get; set; }

    [JsonPropertyName("HostessKatrinaNpc")]
    public bool HostessKatrinaNpc { get; set; }

    [JsonPropertyName("FredericFerntonNpc")]
    public bool FredericFerntonNpc { get; set; }

    [JsonPropertyName("TicketMachineNpc")]
    public bool TicketMachineNpc { get; set; }

    [JsonPropertyName("LadySaichiNpc")]
    public bool LadySaichiNpc { get; set; }

    [JsonPropertyName("GeneralDakuNpc")]
    public bool GeneralDakuNpc { get; set; }

    [JsonPropertyName("JohnIndigosNpc")]
    public bool JohnIndigosNpc { get; set; }
}

public class Tank
{
    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("assists")]
    public float assists { get; set; }

    [JsonPropertyName("blocks_broken")]
    public float blocks_broken { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("powerups_gotten")]
    public float powerups_gotten { get; set; }

    [JsonPropertyName("wool_placed")]
    public float wool_placed { get; set; }
}

public class TeamBrawler
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class THEBULK
{
    [JsonPropertyName("cake_storm")]
    public CakeStorm cake_storm { get; set; }

    [JsonPropertyName("boulder")]
    public Boulder boulder { get; set; }

    [JsonPropertyName("kills")]
    public float kills { get; set; }

    [JsonPropertyName("melee")]
    public Melee melee { get; set; }

    [JsonPropertyName("smashed")]
    public float smashed { get; set; }

    [JsonPropertyName("monster_charge")]
    public MonsterCharge monster_charge { get; set; }

    [JsonPropertyName("games")]
    public float games { get; set; }

    [JsonPropertyName("smashed_normal")]
    public float smashed_normal { get; set; }

    [JsonPropertyName("deaths_normal")]
    public float deaths_normal { get; set; }

    [JsonPropertyName("losses_normal")]
    public float losses_normal { get; set; }

    [JsonPropertyName("damage_dealt")]
    public float damage_dealt { get; set; }

    [JsonPropertyName("kills_normal")]
    public float kills_normal { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("games_normal")]
    public float games_normal { get; set; }

    [JsonPropertyName("damage_dealt_normal")]
    public float damage_dealt_normal { get; set; }

    [JsonPropertyName("seismic_slam")]
    public SeismicSlam seismic_slam { get; set; }

    [JsonPropertyName("deaths_2v2")]
    public float deaths_2v2 { get; set; }

    [JsonPropertyName("losses_2v2")]
    public float losses_2v2 { get; set; }

    [JsonPropertyName("damage_dealt_2v2")]
    public float damage_dealt_2v2 { get; set; }

    [JsonPropertyName("games_2v2")]
    public float games_2v2 { get; set; }
}

public class THIRST
{
    [JsonPropertyName("timestamp")]
    public long timestamp { get; set; }

    [JsonPropertyName("value")]
    public float value { get; set; }
}

public class TntBowspleefDaily
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntBowspleefWeekly
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntDailyWin
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TNTGames
{
    [JsonPropertyName("new_icewizard_explode")]
    public float new_icewizard_explode { get; set; }

    [JsonPropertyName("new_bloodwizard_regen")]
    public float new_bloodwizard_regen { get; set; }

    [JsonPropertyName("new_bloodwizard_explode")]
    public float new_bloodwizard_explode { get; set; }

    [JsonPropertyName("new_tntag_speedy")]
    public float new_tntag_speedy { get; set; }

    [JsonPropertyName("new_pvprun_double_jumps")]
    public float new_pvprun_double_jumps { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("new_spleef_tripleshot")]
    public float new_spleef_tripleshot { get; set; }

    [JsonPropertyName("new_firewizard_regen")]
    public float new_firewizard_regen { get; set; }

    [JsonPropertyName("new_firewizard_explode")]
    public float new_firewizard_explode { get; set; }

    [JsonPropertyName("new_icewizard_regen")]
    public float new_icewizard_regen { get; set; }

    [JsonPropertyName("new_witherwizard_regen")]
    public float new_witherwizard_regen { get; set; }

    [JsonPropertyName("new_spleef_repulsor")]
    public float new_spleef_repulsor { get; set; }

    [JsonPropertyName("new_witherwizard_explode")]
    public float new_witherwizard_explode { get; set; }

    [JsonPropertyName("wins")]
    public float wins { get; set; }

    [JsonPropertyName("new_kineticwizard_explode")]
    public float new_kineticwizard_explode { get; set; }

    [JsonPropertyName("new_kineticwizard_regen")]
    public float new_kineticwizard_regen { get; set; }

    [JsonPropertyName("new_tntrun_double_jumps")]
    public float new_tntrun_double_jumps { get; set; }

    [JsonPropertyName("new_spleef_double_jumps")]
    public float new_spleef_double_jumps { get; set; }

    [JsonPropertyName("run_potions_splashed_on_players")]
    public float run_potions_splashed_on_players { get; set; }

    [JsonPropertyName("record_tntrun")]
    public float record_tntrun { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("deaths_tntrun")]
    public float deaths_tntrun { get; set; }

    [JsonPropertyName("winstreak")]
    public float winstreak { get; set; }

    [JsonPropertyName("deaths_bowspleef")]
    public float deaths_bowspleef { get; set; }

    [JsonPropertyName("tags_bowspleef")]
    public float tags_bowspleef { get; set; }

    [JsonPropertyName("kills_tntag")]
    public float kills_tntag { get; set; }

    [JsonPropertyName("flags")]
    public Flags flags { get; set; }

    [JsonPropertyName("record_pvprun")]
    public float record_pvprun { get; set; }

    [JsonPropertyName("kills_pvprun")]
    public float kills_pvprun { get; set; }

    [JsonPropertyName("deaths_pvprun")]
    public float deaths_pvprun { get; set; }

    [JsonPropertyName("points_capture")]
    public float points_capture { get; set; }

    [JsonPropertyName("kinetic_healing_capture")]
    public float kinetic_healing_capture { get; set; }

    [JsonPropertyName("air_time_capture")]
    public float air_time_capture { get; set; }

    [JsonPropertyName("lastTourneyAd")]
    public long lastTourneyAd { get; set; }

    [JsonPropertyName("deaths_tntag")]
    public float deaths_tntag { get; set; }

    [JsonPropertyName("wizards_selected_class")]
    public string wizards_selected_class { get; set; }

    [JsonPropertyName("new_ancientwizard_regen")]
    public float new_ancientwizard_regen { get; set; }

    [JsonPropertyName("new_ancientwizard_explode")]
    public float new_ancientwizard_explode { get; set; }

    [JsonPropertyName("new_icewizard_damage_taken")]
    public float new_icewizard_damage_taken { get; set; }

    [JsonPropertyName("new_witherwizard_assists")]
    public float new_witherwizard_assists { get; set; }

    [JsonPropertyName("new_ancientwizard_assists")]
    public float new_ancientwizard_assists { get; set; }

    [JsonPropertyName("new_icewizard_deaths")]
    public float new_icewizard_deaths { get; set; }

    [JsonPropertyName("kills_capture")]
    public float kills_capture { get; set; }

    [JsonPropertyName("new_ancientwizard_deaths")]
    public float new_ancientwizard_deaths { get; set; }

    [JsonPropertyName("new_ancientwizard_kills")]
    public float new_ancientwizard_kills { get; set; }

    [JsonPropertyName("new_ancientwizard_healing")]
    public float new_ancientwizard_healing { get; set; }

    [JsonPropertyName("new_witherwizard_deaths")]
    public float new_witherwizard_deaths { get; set; }

    [JsonPropertyName("new_witherwizard_healing")]
    public float new_witherwizard_healing { get; set; }

    [JsonPropertyName("assists_capture")]
    public float assists_capture { get; set; }

    [JsonPropertyName("new_icewizard_healing")]
    public float new_icewizard_healing { get; set; }

    [JsonPropertyName("wins_capture")]
    public float wins_capture { get; set; }

    [JsonPropertyName("new_ancientwizard_damage_taken")]
    public float new_ancientwizard_damage_taken { get; set; }

    [JsonPropertyName("new_witherwizard_damage_taken")]
    public float new_witherwizard_damage_taken { get; set; }

    [JsonPropertyName("deaths_capture")]
    public float deaths_capture { get; set; }

    [JsonPropertyName("privategames")]
    public Privategames privategames { get; set; }
}

public class TntPvprunDaily
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntPvprunWeekly
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntTntrunDaily
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntTntrunWeekly
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntTnttagDaily
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntTnttagWeekly
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntWeeklyPlay
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntWeeklySpecial
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntWizardsDaily
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class TntWizardsWeekly
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class Tourney
{
    [JsonPropertyName("first_join_lobby")]
    public long first_join_lobby { get; set; }

    [JsonPropertyName("shop_sort")]
    public string shop_sort { get; set; }
}

public class TrueCombat
{
    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("win_streak")]
    public float win_streak { get; set; }

    [JsonPropertyName("games")]
    public float games { get; set; }

    [JsonPropertyName("crazywalls_losses_solo")]
    public float crazywalls_losses_solo { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("crazywalls_deaths_solo")]
    public float crazywalls_deaths_solo { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("crazywalls_games_solo")]
    public float crazywalls_games_solo { get; set; }

    [JsonPropertyName("survived_players")]
    public float survived_players { get; set; }

    [JsonPropertyName("show_noob_holograms")]
    public bool show_noob_holograms { get; set; }
}

public class UHC
{
    [JsonPropertyName("saved_stats")]
    public bool saved_stats { get; set; }

    [JsonPropertyName("clearup_achievement")]
    public bool clearup_achievement { get; set; }

    [JsonPropertyName("equippedKit")]
    public string equippedKit { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("deaths_solo")]
    public float deaths_solo { get; set; }
}

public class UhcDm
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class UhcMadness
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class UhcSolo
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class UhcTeam
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class UhcWeekly
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class Unlock
{
    [JsonPropertyName("tier")]
    public float tier { get; set; }

    [JsonPropertyName("acquireDate")]
    public object acquireDate { get; set; }

    [JsonPropertyName("key")]
    public string key { get; set; }
}

public class VampireZ
{
    [JsonPropertyName("updated_stats")]
    public bool updated_stats { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("most_vampire_kills_new")]
    public float most_vampire_kills_new { get; set; }

    [JsonPropertyName("human_deaths")]
    public float human_deaths { get; set; }

    [JsonPropertyName("vampire_deaths")]
    public float vampire_deaths { get; set; }

    [JsonPropertyName("zombie_kills")]
    public float zombie_kills { get; set; }

    [JsonPropertyName("vampire_kills")]
    public float vampire_kills { get; set; }
}

public class VanityMeta
{
    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }
}

public class Walls
{
    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }
}

public class Walls3
{
    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }

    [JsonPropertyName("chosen_class")]
    public string chosen_class { get; set; }

    [JsonPropertyName("classes")]
    public Classes classes { get; set; }

    [JsonPropertyName("coins")]
    public float coins { get; set; }

    [JsonPropertyName("cakes_found_by_name")]
    public List<string> cakes_found_by_name { get; set; }

    [JsonPropertyName("activations")]
    public float activations { get; set; }

    [JsonPropertyName("activations_standard")]
    public float activations_standard { get; set; }

    [JsonPropertyName("arrows_fired")]
    public float arrows_fired { get; set; }

    [JsonPropertyName("arrows_fired_standard")]
    public float arrows_fired_standard { get; set; }

    [JsonPropertyName("arrows_hit")]
    public float arrows_hit { get; set; }

    [JsonPropertyName("arrows_hit_standard")]
    public float arrows_hit_standard { get; set; }

    [JsonPropertyName("assists")]
    public float assists { get; set; }

    [JsonPropertyName("assists_standard")]
    public float assists_standard { get; set; }

    [JsonPropertyName("blocks_broken")]
    public float blocks_broken { get; set; }

    [JsonPropertyName("blocks_broken_standard")]
    public float blocks_broken_standard { get; set; }

    [JsonPropertyName("blocks_placed")]
    public float blocks_placed { get; set; }

    [JsonPropertyName("blocks_placed_preparation")]
    public float blocks_placed_preparation { get; set; }

    [JsonPropertyName("blocks_placed_preparation_standard")]
    public float blocks_placed_preparation_standard { get; set; }

    [JsonPropertyName("blocks_placed_standard")]
    public float blocks_placed_standard { get; set; }

    [JsonPropertyName("cakes_found")]
    public float cakes_found { get; set; }

    [JsonPropertyName("cakes_found_standard")]
    public float cakes_found_standard { get; set; }

    [JsonPropertyName("deaths")]
    public float deaths { get; set; }

    [JsonPropertyName("deaths_standard")]
    public float deaths_standard { get; set; }

    [JsonPropertyName("final_deaths")]
    public float final_deaths { get; set; }

    [JsonPropertyName("final_deaths_standard")]
    public float final_deaths_standard { get; set; }

    [JsonPropertyName("food_eaten")]
    public float food_eaten { get; set; }

    [JsonPropertyName("food_eaten_standard")]
    public float food_eaten_standard { get; set; }

    [JsonPropertyName("games_played")]
    public float games_played { get; set; }

    [JsonPropertyName("games_played_standard")]
    public float games_played_standard { get; set; }

    [JsonPropertyName("golden_apples_eaten")]
    public float golden_apples_eaten { get; set; }

    [JsonPropertyName("golden_apples_eaten_standard")]
    public float golden_apples_eaten_standard { get; set; }

    [JsonPropertyName("hunter_a_activations")]
    public float hunter_a_activations { get; set; }

    [JsonPropertyName("hunter_a_activations_standard")]
    public float hunter_a_activations_standard { get; set; }

    [JsonPropertyName("hunter_activations")]
    public float hunter_activations { get; set; }

    [JsonPropertyName("hunter_activations_standard")]
    public float hunter_activations_standard { get; set; }

    [JsonPropertyName("hunter_arrows_fired")]
    public float hunter_arrows_fired { get; set; }

    [JsonPropertyName("hunter_arrows_fired_standard")]
    public float hunter_arrows_fired_standard { get; set; }

    [JsonPropertyName("hunter_arrows_hit")]
    public float hunter_arrows_hit { get; set; }

    [JsonPropertyName("hunter_arrows_hit_standard")]
    public float hunter_arrows_hit_standard { get; set; }

    [JsonPropertyName("hunter_assists")]
    public float hunter_assists { get; set; }

    [JsonPropertyName("hunter_assists_standard")]
    public float hunter_assists_standard { get; set; }

    [JsonPropertyName("hunter_b_activations")]
    public float hunter_b_activations { get; set; }

    [JsonPropertyName("hunter_b_activations_standard")]
    public float hunter_b_activations_standard { get; set; }

    [JsonPropertyName("hunter_b_assists")]
    public float hunter_b_assists { get; set; }

    [JsonPropertyName("hunter_b_assists_standard")]
    public float hunter_b_assists_standard { get; set; }

    [JsonPropertyName("hunter_b_total_kills")]
    public float hunter_b_total_kills { get; set; }

    [JsonPropertyName("hunter_b_total_kills_standard")]
    public float hunter_b_total_kills_standard { get; set; }

    [JsonPropertyName("hunter_blocks_broken")]
    public float hunter_blocks_broken { get; set; }

    [JsonPropertyName("hunter_blocks_broken_standard")]
    public float hunter_blocks_broken_standard { get; set; }

    [JsonPropertyName("hunter_blocks_placed")]
    public float hunter_blocks_placed { get; set; }

    [JsonPropertyName("hunter_blocks_placed_preparation")]
    public float hunter_blocks_placed_preparation { get; set; }

    [JsonPropertyName("hunter_blocks_placed_preparation_standard")]
    public float hunter_blocks_placed_preparation_standard { get; set; }

    [JsonPropertyName("hunter_blocks_placed_standard")]
    public float hunter_blocks_placed_standard { get; set; }

    [JsonPropertyName("hunter_c_activations")]
    public float hunter_c_activations { get; set; }

    [JsonPropertyName("hunter_c_activations_standard")]
    public float hunter_c_activations_standard { get; set; }

    [JsonPropertyName("hunter_deaths")]
    public float hunter_deaths { get; set; }

    [JsonPropertyName("hunter_deaths_standard")]
    public float hunter_deaths_standard { get; set; }

    [JsonPropertyName("hunter_final_deaths")]
    public float hunter_final_deaths { get; set; }

    [JsonPropertyName("hunter_final_deaths_standard")]
    public float hunter_final_deaths_standard { get; set; }

    [JsonPropertyName("hunter_food_eaten")]
    public float hunter_food_eaten { get; set; }

    [JsonPropertyName("hunter_food_eaten_standard")]
    public float hunter_food_eaten_standard { get; set; }

    [JsonPropertyName("hunter_g_activations")]
    public float hunter_g_activations { get; set; }

    [JsonPropertyName("hunter_g_activations_standard")]
    public float hunter_g_activations_standard { get; set; }

    [JsonPropertyName("hunter_games_played")]
    public float hunter_games_played { get; set; }

    [JsonPropertyName("hunter_games_played_standard")]
    public float hunter_games_played_standard { get; set; }

    [JsonPropertyName("hunter_golden_apples_eaten")]
    public float hunter_golden_apples_eaten { get; set; }

    [JsonPropertyName("hunter_golden_apples_eaten_standard")]
    public float hunter_golden_apples_eaten_standard { get; set; }

    [JsonPropertyName("hunter_iron_ore_broken")]
    public float hunter_iron_ore_broken { get; set; }

    [JsonPropertyName("hunter_iron_ore_broken_standard")]
    public float hunter_iron_ore_broken_standard { get; set; }

    [JsonPropertyName("hunter_losses")]
    public float hunter_losses { get; set; }

    [JsonPropertyName("hunter_losses_standard")]
    public float hunter_losses_standard { get; set; }

    [JsonPropertyName("hunter_meters_fallen")]
    public float hunter_meters_fallen { get; set; }

    [JsonPropertyName("hunter_meters_fallen_standard")]
    public float hunter_meters_fallen_standard { get; set; }

    [JsonPropertyName("hunter_meters_walked")]
    public float hunter_meters_walked { get; set; }

    [JsonPropertyName("hunter_meters_walked_speed")]
    public float hunter_meters_walked_speed { get; set; }

    [JsonPropertyName("hunter_meters_walked_speed_standard")]
    public float hunter_meters_walked_speed_standard { get; set; }

    [JsonPropertyName("hunter_meters_walked_standard")]
    public float hunter_meters_walked_standard { get; set; }

    [JsonPropertyName("hunter_time_played")]
    public float hunter_time_played { get; set; }

    [JsonPropertyName("hunter_time_played_standard")]
    public float hunter_time_played_standard { get; set; }

    [JsonPropertyName("hunter_total_deaths")]
    public float hunter_total_deaths { get; set; }

    [JsonPropertyName("hunter_total_deaths_standard")]
    public float hunter_total_deaths_standard { get; set; }

    [JsonPropertyName("hunter_total_kills")]
    public float hunter_total_kills { get; set; }

    [JsonPropertyName("hunter_total_kills_standard")]
    public float hunter_total_kills_standard { get; set; }

    [JsonPropertyName("hunter_treasures_found")]
    public float hunter_treasures_found { get; set; }

    [JsonPropertyName("hunter_treasures_found_standard")]
    public float hunter_treasures_found_standard { get; set; }

    [JsonPropertyName("iron_ore_broken")]
    public float iron_ore_broken { get; set; }

    [JsonPropertyName("iron_ore_broken_standard")]
    public float iron_ore_broken_standard { get; set; }

    [JsonPropertyName("losses")]
    public float losses { get; set; }

    [JsonPropertyName("losses_standard")]
    public float losses_standard { get; set; }

    [JsonPropertyName("meters_fallen")]
    public float meters_fallen { get; set; }

    [JsonPropertyName("meters_fallen_standard")]
    public float meters_fallen_standard { get; set; }

    [JsonPropertyName("meters_walked")]
    public float meters_walked { get; set; }

    [JsonPropertyName("meters_walked_speed")]
    public float meters_walked_speed { get; set; }

    [JsonPropertyName("meters_walked_speed_standard")]
    public float meters_walked_speed_standard { get; set; }

    [JsonPropertyName("meters_walked_standard")]
    public float meters_walked_standard { get; set; }

    [JsonPropertyName("time_played")]
    public float time_played { get; set; }

    [JsonPropertyName("time_played_standard")]
    public float time_played_standard { get; set; }

    [JsonPropertyName("total_deaths")]
    public float total_deaths { get; set; }

    [JsonPropertyName("total_deaths_standard")]
    public float total_deaths_standard { get; set; }

    [JsonPropertyName("total_kills")]
    public float total_kills { get; set; }

    [JsonPropertyName("total_kills_standard")]
    public float total_kills_standard { get; set; }

    [JsonPropertyName("treasures_found")]
    public float treasures_found { get; set; }

    [JsonPropertyName("treasures_found_standard")]
    public float treasures_found_standard { get; set; }
}

public class WoolGames
{
    [JsonPropertyName("progression")]
    public Progression progression { get; set; }

    [JsonPropertyName("wool_wars")]
    public WoolWars wool_wars { get; set; }

    [JsonPropertyName("lastTourneyAd")]
    public long lastTourneyAd { get; set; }

    [JsonPropertyName("packages")]
    public List<string> packages { get; set; }
}

public class WoolWars
{
    [JsonPropertyName("stats")]
    public Stats stats { get; set; }
}

public class WoolWarsDailyKills
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class WoolWarsDailyPlay
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class WoolWarsDailyWins
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class WoolWarsWeeklyShears
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class WoolWeeklyPlay
{
    [JsonPropertyName("active")]
    public Active active { get; set; }
}

public class Zombie
{
    [JsonPropertyName("skill_level_d")]
    public float skill_level_d { get; set; }

    [JsonPropertyName("skill_level_dChecked5")]
    public bool skill_level_dChecked5 { get; set; }

    [JsonPropertyName("unlocked")]
    public bool unlocked { get; set; }

    [JsonPropertyName("checked4")]
    public bool checked4 { get; set; }
}

