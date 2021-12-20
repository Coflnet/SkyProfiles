using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sky.PlayerInfo.Models
{
    // this file was generated with the help of https://json2csharp.com/
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class InvArmor
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class CoopInvitation
    {
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        [JsonPropertyName("invited_by")]
        public string InvitedBy { get; set; }

        [JsonPropertyName("confirmed")]
        public bool Confirmed { get; set; }

        [JsonPropertyName("confirmed_timestamp")]
        public long ConfirmedTimestamp { get; set; }
    }

    public class Stats
    {
        [JsonPropertyName("pet_milestone_ores_mined")]
        public int PetMilestoneOresMined { get; set; }

        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        [JsonPropertyName("deaths_fire")]
        public int DeathsFire { get; set; }

        [JsonPropertyName("highest_critical_damage")]
        public double HighestCriticalDamage { get; set; }

        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        [JsonPropertyName("kills_lapis_zombie")]
        public int KillsLapisZombie { get; set; }

        [JsonPropertyName("deaths_lapis_zombie")]
        public int DeathsLapisZombie { get; set; }

        [JsonPropertyName("deaths_redstone_pigman")]
        public int DeathsRedstonePigman { get; set; }

        [JsonPropertyName("kills_redstone_pigman")]
        public int KillsRedstonePigman { get; set; }

        [JsonPropertyName("kills_emerald_slime")]
        public int KillsEmeraldSlime { get; set; }

        [JsonPropertyName("deaths_emerald_slime")]
        public int DeathsEmeraldSlime { get; set; }

        [JsonPropertyName("kills_invisible_creeper")]
        public int KillsInvisibleCreeper { get; set; }

        [JsonPropertyName("kills_diamond_skeleton")]
        public int KillsDiamondSkeleton { get; set; }

        [JsonPropertyName("deaths_diamond_zombie")]
        public int DeathsDiamondZombie { get; set; }

        [JsonPropertyName("kills_diamond_zombie")]
        public int KillsDiamondZombie { get; set; }

        [JsonPropertyName("deaths_diamond_skeleton")]
        public int DeathsDiamondSkeleton { get; set; }

        [JsonPropertyName("auctions_bids")]
        public int AuctionsBids { get; set; }

        [JsonPropertyName("auctions_highest_bid")]
        public int AuctionsHighestBid { get; set; }

        [JsonPropertyName("foraging_race_best_time")]
        public int ForagingRaceBestTime { get; set; }

        [JsonPropertyName("gifts_received")]
        public int GiftsReceived { get; set; }

        [JsonPropertyName("kills_zombie")]
        public int KillsZombie { get; set; }

        [JsonPropertyName("kills_skeleton")]
        public int KillsSkeleton { get; set; }

        [JsonPropertyName("kills_spider")]
        public int KillsSpider { get; set; }

        [JsonPropertyName("auctions_won")]
        public int AuctionsWon { get; set; }

        [JsonPropertyName("auctions_bought_common")]
        public int AuctionsBoughtCommon { get; set; }

        [JsonPropertyName("auctions_gold_spent")]
        public double AuctionsGoldSpent { get; set; }

        [JsonPropertyName("deaths_zombie")]
        public int DeathsZombie { get; set; }

        [JsonPropertyName("kills_witch")]
        public int KillsWitch { get; set; }

        [JsonPropertyName("deaths_void")]
        public int DeathsVoid { get; set; }

        [JsonPropertyName("deaths_fall")]
        public int DeathsFall { get; set; }

        [JsonPropertyName("kills_magma_cube")]
        public int KillsMagmaCube { get; set; }

        [JsonPropertyName("kills_wither_skeleton")]
        public int KillsWitherSkeleton { get; set; }

        [JsonPropertyName("kills_pigman")]
        public int KillsPigman { get; set; }

        [JsonPropertyName("kills_sheep")]
        public int KillsSheep { get; set; }

        [JsonPropertyName("kills_slime")]
        public int KillsSlime { get; set; }

        [JsonPropertyName("auctions_created")]
        public int AuctionsCreated { get; set; }

        [JsonPropertyName("auctions_fees")]
        public int AuctionsFees { get; set; }

        [JsonPropertyName("auctions_bought_epic")]
        public int AuctionsBoughtEpic { get; set; }

        [JsonPropertyName("kills_fireball_magma_cube")]
        public int KillsFireballMagmaCube { get; set; }

        [JsonPropertyName("kills_blaze")]
        public int KillsBlaze { get; set; }

        [JsonPropertyName("kills_ruin_wolf")]
        public int KillsRuinWolf { get; set; }

        [JsonPropertyName("kills_old_wolf")]
        public int KillsOldWolf { get; set; }

        [JsonPropertyName("kills_zombie_villager")]
        public int KillsZombieVillager { get; set; }

        [JsonPropertyName("auctions_completed")]
        public int AuctionsCompleted { get; set; }

        [JsonPropertyName("auctions_sold_epic")]
        public int AuctionsSoldEpic { get; set; }

        [JsonPropertyName("auctions_gold_earned")]
        public long AuctionsGoldEarned { get; set; }

        [JsonPropertyName("kills_splitter_spider")]
        public int KillsSplitterSpider { get; set; }

        [JsonPropertyName("kills_splitter_spider_silverfish")]
        public int KillsSplitterSpiderSilverfish { get; set; }

        [JsonPropertyName("kills_spider_jockey")]
        public int KillsSpiderJockey { get; set; }

        [JsonPropertyName("kills_jockey_skeleton")]
        public int KillsJockeySkeleton { get; set; }

        [JsonPropertyName("kills_dasher_spider")]
        public int KillsDasherSpider { get; set; }

        [JsonPropertyName("kills_weaver_spider")]
        public int KillsWeaverSpider { get; set; }

        [JsonPropertyName("kills_voracious_spider")]
        public int KillsVoraciousSpider { get; set; }

        [JsonPropertyName("kills_jockey_shot_silverfish")]
        public int KillsJockeyShotSilverfish { get; set; }

        [JsonPropertyName("kills_respawning_skeleton")]
        public int KillsRespawningSkeleton { get; set; }

        [JsonPropertyName("deaths_endermite")]
        public int DeathsEndermite { get; set; }

        [JsonPropertyName("kills_enderman")]
        public int KillsEnderman { get; set; }

        [JsonPropertyName("deaths_enderman")]
        public int DeathsEnderman { get; set; }

        [JsonPropertyName("auctions_sold_common")]
        public int AuctionsSoldCommon { get; set; }

        [JsonPropertyName("auctions_no_bids")]
        public int AuctionsNoBids { get; set; }

        [JsonPropertyName("auctions_bought_uncommon")]
        public int AuctionsBoughtUncommon { get; set; }

        [JsonPropertyName("kills_pig")]
        public int KillsPig { get; set; }

        [JsonPropertyName("kills_unburried_zombie")]
        public int KillsUnburriedZombie { get; set; }

        [JsonPropertyName("kills_chicken")]
        public int KillsChicken { get; set; }

        [JsonPropertyName("auctions_bought_rare")]
        public int AuctionsBoughtRare { get; set; }

        [JsonPropertyName("gifts_given")]
        public int GiftsGiven { get; set; }

        [JsonPropertyName("kills_mayor_jerry_green")]
        public int KillsMayorJerryGreen { get; set; }

        [JsonPropertyName("deaths_old_wolf")]
        public int DeathsOldWolf { get; set; }

        [JsonPropertyName("kills_goblin_knife_thrower")]
        public int KillsGoblinKnifeThrower { get; set; }

        [JsonPropertyName("kills_goblin")]
        public int KillsGoblin { get; set; }

        [JsonPropertyName("kills_goblin_weakling_melee")]
        public int KillsGoblinWeaklingMelee { get; set; }

        [JsonPropertyName("kills_goblin_weakling_bow")]
        public int KillsGoblinWeaklingBow { get; set; }

        [JsonPropertyName("kills_mushroom_cow")]
        public int KillsMushroomCow { get; set; }

        [JsonPropertyName("kills_cow")]
        public int KillsCow { get; set; }

        [JsonPropertyName("kills_trapper_pig")]
        public int KillsTrapperPig { get; set; }

        [JsonPropertyName("kills_rabbit")]
        public int KillsRabbit { get; set; }

        [JsonPropertyName("mythos_kills")]
        public int MythosKills { get; set; }

        [JsonPropertyName("kills_minos_hunter")]
        public int KillsMinosHunter { get; set; }

        [JsonPropertyName("kills_trapper_rabbit")]
        public int KillsTrapperRabbit { get; set; }

        [JsonPropertyName("kills_trapper_chicken")]
        public int KillsTrapperChicken { get; set; }

        [JsonPropertyName("kills_rat")]
        public int KillsRat { get; set; }

        [JsonPropertyName("kills_crypt_tank_zombie")]
        public int KillsCryptTankZombie { get; set; }

        [JsonPropertyName("kills_crypt_lurker")]
        public int KillsCryptLurker { get; set; }

        [JsonPropertyName("kills_zombie_grunt")]
        public int KillsZombieGrunt { get; set; }

        [JsonPropertyName("deaths_crypt_lurker")]
        public int DeathsCryptLurker { get; set; }

        [JsonPropertyName("kills_scared_skeleton")]
        public int KillsScaredSkeleton { get; set; }

        [JsonPropertyName("kills_dungeon_respawning_skeleton")]
        public int KillsDungeonRespawningSkeleton { get; set; }

        [JsonPropertyName("deaths_sniper_skeleton")]
        public int DeathsSniperSkeleton { get; set; }

        [JsonPropertyName("kills_skeleton_grunt")]
        public int KillsSkeletonGrunt { get; set; }

        [JsonPropertyName("deaths_scared_skeleton")]
        public int DeathsScaredSkeleton { get; set; }

        [JsonPropertyName("auctions_sold_legendary")]
        public int AuctionsSoldLegendary { get; set; }

        [JsonPropertyName("auctions_bought_legendary")]
        public int AuctionsBoughtLegendary { get; set; }

        [JsonPropertyName("kills_crypt_dreadlord")]
        public int KillsCryptDreadlord { get; set; }

        [JsonPropertyName("deaths_skeleton_grunt")]
        public int DeathsSkeletonGrunt { get; set; }

        [JsonPropertyName("deaths_crypt_dreadlord")]
        public int DeathsCryptDreadlord { get; set; }

        [JsonPropertyName("deaths_zombie_grunt")]
        public int DeathsZombieGrunt { get; set; }

        [JsonPropertyName("deaths_dungeon_respawning_skeleton")]
        public int DeathsDungeonRespawningSkeleton { get; set; }

        [JsonPropertyName("kills_lost_adventurer")]
        public int KillsLostAdventurer { get; set; }

        [JsonPropertyName("deaths_lost_adventurer")]
        public int DeathsLostAdventurer { get; set; }

        [JsonPropertyName("kills_dungeon_secret_bat")]
        public int KillsDungeonSecretBat { get; set; }

        [JsonPropertyName("deaths_crypt_souleater")]
        public int DeathsCryptSouleater { get; set; }

        [JsonPropertyName("kills_lonely_spider")]
        public int KillsLonelySpider { get; set; }

        [JsonPropertyName("deaths_trap")]
        public int DeathsTrap { get; set; }

        [JsonPropertyName("kills_watcher_summon_undead")]
        public int KillsWatcherSummonUndead { get; set; }

        [JsonPropertyName("deaths_skeleton_soldier")]
        public int DeathsSkeletonSoldier { get; set; }

        [JsonPropertyName("deaths_crypt_undead")]
        public int DeathsCryptUndead { get; set; }

        [JsonPropertyName("deaths_watcher_summon_undead")]
        public int DeathsWatcherSummonUndead { get; set; }

        [JsonPropertyName("auctions_sold_uncommon")]
        public int AuctionsSoldUncommon { get; set; }

        [JsonPropertyName("defense")]
        public double Defense { get; set; }

        [JsonPropertyName("true_defense")]
        public double TrueDefense { get; set; }

        [JsonPropertyName("strength")]
        public double? Strength { get; set; }

        [JsonPropertyName("crit_chance")]
        public double? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("intelligence")]
        public double? Intelligence { get; set; }

        [JsonPropertyName("magic_find")]
        public double? MagicFind { get; set; }

        [JsonPropertyName("speed")]
        public double? Speed { get; set; }

        [JsonPropertyName("ferocity")]
        public double? Ferocity { get; set; }

        [JsonPropertyName("health")]
        public double? Health { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public double Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public double DamageIncrease { get; set; }

        [JsonPropertyName("times_played")]
        public int TimesPlayed { get; set; }

        [JsonPropertyName("best_score")]
        public int BestScore { get; set; }

        [JsonPropertyName("mobs_killed")]
        public int MobsKilled { get; set; }

        [JsonPropertyName("most_mobs_killed")]
        public int MostMobsKilled { get; set; }

        [JsonPropertyName("most_healing")]
        public double MostHealing { get; set; }

        [JsonPropertyName("tier_completions")]
        public int TierCompletions { get; set; }

        [JsonPropertyName("milestone_completions")]
        public int MilestoneCompletions { get; set; }

        [JsonPropertyName("fastest_time")]
        public int FastestTime { get; set; }

        [JsonPropertyName("watcher_kills")]
        public int WatcherKills { get; set; }

        [JsonPropertyName("last_attempt")]
        public LastAttempt LastAttempt { get; set; }

        [JsonPropertyName("bonus_clicks")]
        public int BonusClicks { get; set; }

        [JsonPropertyName("last_claimed")]
        public LastClaimed LastClaimed { get; set; }

        [JsonPropertyName("highest_crit_damage")]
        public double HighestCritDamage { get; set; }

        [JsonPropertyName("deaths_spider")]
        public int DeathsSpider { get; set; }

        [JsonPropertyName("deaths_skeleton")]
        public int DeathsSkeleton { get; set; }

        [JsonPropertyName("auctions_sold_rare")]
        public int AuctionsSoldRare { get; set; }

        [JsonPropertyName("true defense")]
        public object True_Defense { get; set; }

        [JsonPropertyName("deaths_invisible_creeper")]
        public int DeathsInvisibleCreeper { get; set; }

        [JsonPropertyName("deaths_zombie_villager")]
        public int DeathsZombieVillager { get; set; }

        [JsonPropertyName("deaths_ruin_wolf")]
        public int DeathsRuinWolf { get; set; }

        [JsonPropertyName("deaths_splitter_spider")]
        public int DeathsSplitterSpider { get; set; }

        [JsonPropertyName("kills_night_respawning_skeleton")]
        public int KillsNightRespawningSkeleton { get; set; }

        [JsonPropertyName("kills_sea_archer")]
        public int KillsSeaArcher { get; set; }

        [JsonPropertyName("items_fished")]
        public int ItemsFished { get; set; }

        [JsonPropertyName("items_fished_normal")]
        public int ItemsFishedNormal { get; set; }

        [JsonPropertyName("kills_sea_walker")]
        public int KillsSeaWalker { get; set; }

        [JsonPropertyName("deaths_wither_skeleton")]
        public int DeathsWitherSkeleton { get; set; }

        [JsonPropertyName("end_race_best_time")]
        public int EndRaceBestTime { get; set; }

        [JsonPropertyName("kills_random_slime")]
        public int KillsRandomSlime { get; set; }

        [JsonPropertyName("deaths_suffocation")]
        public int DeathsSuffocation { get; set; }

        [JsonPropertyName("deaths_spider_jockey")]
        public int DeathsSpiderJockey { get; set; }

        [JsonPropertyName("deaths_blaze")]
        public int DeathsBlaze { get; set; }

        [JsonPropertyName("deaths_obsidian_wither")]
        public int DeathsObsidianWither { get; set; }

        [JsonPropertyName("kills_forest_island_bat")]
        public int KillsForestIslandBat { get; set; }

        [JsonPropertyName("kills_ghast")]
        public int KillsGhast { get; set; }

        [JsonPropertyName("kills_generator_magma_cube")]
        public int KillsGeneratorMagmaCube { get; set; }

        [JsonPropertyName("deaths_zealot_enderman")]
        public int DeathsZealotEnderman { get; set; }

        [JsonPropertyName("items_fished_treasure")]
        public int ItemsFishedTreasure { get; set; }

        [JsonPropertyName("kills_pond_squid")]
        public int KillsPondSquid { get; set; }

        [JsonPropertyName("kills_sea_guardian")]
        public int KillsSeaGuardian { get; set; }

        [JsonPropertyName("kills_endermite")]
        public int KillsEndermite { get; set; }

        [JsonPropertyName("kills_watcher")]
        public int KillsWatcher { get; set; }

        [JsonPropertyName("kills_obsidian_wither")]
        public int KillsObsidianWither { get; set; }

        [JsonPropertyName("deaths_magma_cube_boss")]
        public int DeathsMagmaCubeBoss { get; set; }

        [JsonPropertyName("kills_magma_cube_boss")]
        public int KillsMagmaCubeBoss { get; set; }

        [JsonPropertyName("deaths_fireball_magma_cube")]
        public int DeathsFireballMagmaCube { get; set; }

        [JsonPropertyName("kills_zealot_enderman")]
        public int KillsZealotEnderman { get; set; }

        [JsonPropertyName("deaths_unburried_zombie")]
        public int DeathsUnburriedZombie { get; set; }

        [JsonPropertyName("deaths_wolf")]
        public int DeathsWolf { get; set; }

        [JsonPropertyName("kills_bat_pinata")]
        public int KillsBatPinata { get; set; }

        [JsonPropertyName("kills_horseman_zombie")]
        public int KillsHorsemanZombie { get; set; }

        [JsonPropertyName("kills_howling_spirit")]
        public int KillsHowlingSpirit { get; set; }

        [JsonPropertyName("kills_soul_of_the_alpha")]
        public int KillsSoulOfTheAlpha { get; set; }

        [JsonPropertyName("kills_pack_spirit")]
        public int KillsPackSpirit { get; set; }

        [JsonPropertyName("deaths_soul_of_the_alpha")]
        public int DeathsSoulOfTheAlpha { get; set; }

        [JsonPropertyName("deaths_unknown")]
        public int DeathsUnknown { get; set; }

        [JsonPropertyName("kills_creeper")]
        public int KillsCreeper { get; set; }

        [JsonPropertyName("deaths_wise_dragon")]
        public int DeathsWiseDragon { get; set; }

        [JsonPropertyName("ender_crystals_destroyed")]
        public int EnderCrystalsDestroyed { get; set; }

        [JsonPropertyName("deaths_watcher")]
        public int DeathsWatcher { get; set; }

        [JsonPropertyName("kills_horseman_bat")]
        public int KillsHorsemanBat { get; set; }

        [JsonPropertyName("kills_zombie_deep")]
        public int KillsZombieDeep { get; set; }

        [JsonPropertyName("deaths_young_dragon")]
        public int DeathsYoungDragon { get; set; }

        [JsonPropertyName("deaths_unstable_dragon")]
        public int DeathsUnstableDragon { get; set; }

        [JsonPropertyName("kills_liquid_hot_magma")]
        public int KillsLiquidHotMagma { get; set; }

        [JsonPropertyName("most_winter_snowballs_hit")]
        public int MostWinterSnowballsHit { get; set; }

        [JsonPropertyName("most_winter_damage_dealt")]
        public int MostWinterDamageDealt { get; set; }

        [JsonPropertyName("most_winter_magma_damage_dealt")]
        public int MostWinterMagmaDamageDealt { get; set; }

        [JsonPropertyName("deaths_player")]
        public int DeathsPlayer { get; set; }

        [JsonPropertyName("kills_strong_dragon")]
        public int KillsStrongDragon { get; set; }

        [JsonPropertyName("kills_generator_ghast")]
        public int KillsGeneratorGhast { get; set; }

        [JsonPropertyName("kills_player")]
        public int KillsPlayer { get; set; }

        [JsonPropertyName("most_winter_cannonballs_hit")]
        public int MostWinterCannonballsHit { get; set; }

        [JsonPropertyName("items_fished_large_treasure")]
        public int ItemsFishedLargeTreasure { get; set; }

        [JsonPropertyName("kills_catfish")]
        public int KillsCatfish { get; set; }

        [JsonPropertyName("kills_guardian_defender")]
        public int KillsGuardianDefender { get; set; }

        [JsonPropertyName("kills_deep_sea_protector")]
        public int KillsDeepSeaProtector { get; set; }

        [JsonPropertyName("kills_frosty_the_snowman")]
        public int KillsFrostyTheSnowman { get; set; }

        [JsonPropertyName("kills_sea_leech")]
        public int KillsSeaLeech { get; set; }

        [JsonPropertyName("kills_frozen_steve")]
        public int KillsFrozenSteve { get; set; }

        [JsonPropertyName("kills_chicken_deep")]
        public int KillsChickenDeep { get; set; }

        [JsonPropertyName("kills_night_squid")]
        public int KillsNightSquid { get; set; }

        [JsonPropertyName("kills_horseman_horse")]
        public int KillsHorsemanHorse { get; set; }

        [JsonPropertyName("kills_revenant_zombie")]
        public int KillsRevenantZombie { get; set; }

        [JsonPropertyName("deaths_magma_cube")]
        public int DeathsMagmaCube { get; set; }

        [JsonPropertyName("pet_milestone_sea_creatures_killed")]
        public int PetMilestoneSeaCreaturesKilled { get; set; }

        [JsonPropertyName("kills_water_hydra")]
        public int KillsWaterHydra { get; set; }

        [JsonPropertyName("kills_generator_slime")]
        public int KillsGeneratorSlime { get; set; }

        [JsonPropertyName("deaths_liquid_hot_magma")]
        public int DeathsLiquidHotMagma { get; set; }

        [JsonPropertyName("kills_cave_spider")]
        public int KillsCaveSpider { get; set; }

        [JsonPropertyName("deaths_revenant_zombie")]
        public int DeathsRevenantZombie { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_anything_no_return_best_time")]
        public int DungeonHubCrystalCoreAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_giant_mushroom_anything_no_return_best_time")]
        public int DungeonHubGiantMushroomAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_precursor_ruins_anything_no_return_best_time")]
        public int DungeonHubPrecursorRuinsAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_no_pearls_no_return_best_time")]
        public int DungeonHubCrystalCoreNoPearlsNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_no_abilities_no_return_best_time")]
        public int DungeonHubCrystalCoreNoAbilitiesNoReturnBestTime { get; set; }

        [JsonPropertyName("kills_tarantula_spider")]
        public int KillsTarantulaSpider { get; set; }

        [JsonPropertyName("kills_skeleton_soldier")]
        public int KillsSkeletonSoldier { get; set; }

        [JsonPropertyName("kills_crypt_undead")]
        public int KillsCryptUndead { get; set; }

        [JsonPropertyName("kills_crypt_souleater")]
        public int KillsCryptSouleater { get; set; }

        [JsonPropertyName("kills_diamond_guy")]
        public int KillsDiamondGuy { get; set; }

        [JsonPropertyName("kills_sniper_skeleton")]
        public int KillsSniperSkeleton { get; set; }

        [JsonPropertyName("kills_bonzo_summon_undead")]
        public int KillsBonzoSummonUndead { get; set; }

        [JsonPropertyName("kills_skeleton_master")]
        public int KillsSkeletonMaster { get; set; }

        [JsonPropertyName("deaths_skeleton_master")]
        public int DeathsSkeletonMaster { get; set; }

        [JsonPropertyName("kills_parasite")]
        public int KillsParasite { get; set; }

        [JsonPropertyName("deaths_scarf_mage")]
        public int DeathsScarfMage { get; set; }

        [JsonPropertyName("kills_cellar_spider")]
        public int KillsCellarSpider { get; set; }

        [JsonPropertyName("deaths_bonzo")]
        public int DeathsBonzo { get; set; }

        [JsonPropertyName("kills_crypt_undead_nicholas")]
        public int KillsCryptUndeadNicholas { get; set; }

        [JsonPropertyName("deaths_drowning")]
        public int DeathsDrowning { get; set; }

        [JsonPropertyName("kills_crypt_undead_alexander")]
        public int KillsCryptUndeadAlexander { get; set; }

        [JsonPropertyName("kills_crypt_undead_friedrich")]
        public int KillsCryptUndeadFriedrich { get; set; }

        [JsonPropertyName("kills_headless_horseman")]
        public int KillsHeadlessHorseman { get; set; }

        [JsonPropertyName("kills_crypt_undead_marius")]
        public int KillsCryptUndeadMarius { get; set; }

        [JsonPropertyName("kills_carrot_king")]
        public int KillsCarrotKing { get; set; }

        [JsonPropertyName("deaths_tarantula_spider")]
        public int DeathsTarantulaSpider { get; set; }

        [JsonPropertyName("kills_crypt_undead_christian")]
        public int KillsCryptUndeadChristian { get; set; }

        [JsonPropertyName("kills_skeleton_emperor")]
        public int KillsSkeletonEmperor { get; set; }

        [JsonPropertyName("kills_sea_witch")]
        public int KillsSeaWitch { get; set; }

        [JsonPropertyName("kills_crypt_undead_valentin")]
        public int KillsCryptUndeadValentin { get; set; }

        [JsonPropertyName("kills_grinch")]
        public int KillsGrinch { get; set; }

        [JsonPropertyName("kills_guardian_emperor")]
        public int KillsGuardianEmperor { get; set; }

        [JsonPropertyName("deaths_superior_dragon")]
        public int DeathsSuperiorDragon { get; set; }

        [JsonPropertyName("kills_blaze_higher_or_lower")]
        public int KillsBlazeHigherOrLower { get; set; }

        [JsonPropertyName("deaths_scarf_warrior")]
        public int DeathsScarfWarrior { get; set; }

        [JsonPropertyName("deaths_scarf")]
        public int DeathsScarf { get; set; }

        [JsonPropertyName("kills_scarf_mage")]
        public int KillsScarfMage { get; set; }

        [JsonPropertyName("kills_crypt_undead_bernhard")]
        public int KillsCryptUndeadBernhard { get; set; }

        [JsonPropertyName("kills_scary_jerry")]
        public int KillsScaryJerry { get; set; }

        [JsonPropertyName("kills_batty_witch")]
        public int KillsBattyWitch { get; set; }

        [JsonPropertyName("kills_wither_gourd")]
        public int KillsWitherGourd { get; set; }

        [JsonPropertyName("kills_trick_or_treater")]
        public int KillsTrickOrTreater { get; set; }

        [JsonPropertyName("kills_phantom_spirit")]
        public int KillsPhantomSpirit { get; set; }

        [JsonPropertyName("kills_wraith")]
        public int KillsWraith { get; set; }

        [JsonPropertyName("auctions_bought_special")]
        public int AuctionsBoughtSpecial { get; set; }

        [JsonPropertyName("shredder_bait")]
        public int ShredderBait { get; set; }

        [JsonPropertyName("shredder_fished")]
        public int ShredderFished { get; set; }

        [JsonPropertyName("kills_nurse_shark")]
        public int KillsNurseShark { get; set; }

        [JsonPropertyName("kills_blue_shark")]
        public int KillsBlueShark { get; set; }

        [JsonPropertyName("kills_tiger_shark")]
        public int KillsTigerShark { get; set; }

        [JsonPropertyName("kills_crypt_undead_pieter")]
        public int KillsCryptUndeadPieter { get; set; }

        [JsonPropertyName("kills_bat_spooky")]
        public int KillsBatSpooky { get; set; }

        [JsonPropertyName("kills_scarecrow")]
        public int KillsScarecrow { get; set; }

        [JsonPropertyName("kills_werewolf")]
        public int KillsWerewolf { get; set; }

        [JsonPropertyName("kills_nightmare")]
        public int KillsNightmare { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next")]
        public int MythosBurrowsDugNext { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_null")]
        public int MythosBurrowsDugNextNull { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat")]
        public int MythosBurrowsDugCombat { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_null")]
        public int MythosBurrowsDugCombatNull { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure")]
        public int MythosBurrowsDugTreasure { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_null")]
        public int MythosBurrowsDugTreasureNull { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete")]
        public int MythosBurrowsChainsComplete { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_null")]
        public int MythosBurrowsChainsCompleteNull { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_COMMON")]
        public int MythosBurrowsDugNextCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_COMMON")]
        public int MythosBurrowsDugCombatCOMMON { get; set; }

        [JsonPropertyName("kills_siamese_lynx")]
        public int KillsSiameseLynx { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_COMMON")]
        public int MythosBurrowsDugTreasureCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_COMMON")]
        public int MythosBurrowsChainsCompleteCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_UNCOMMON")]
        public int MythosBurrowsDugNextUNCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_UNCOMMON")]
        public int MythosBurrowsDugCombatUNCOMMON { get; set; }

        [JsonPropertyName("kills_minotaur")]
        public int KillsMinotaur { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_UNCOMMON")]
        public int MythosBurrowsDugTreasureUNCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_UNCOMMON")]
        public int MythosBurrowsChainsCompleteUNCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_RARE")]
        public int MythosBurrowsDugNextRARE { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_RARE")]
        public int MythosBurrowsDugCombatRARE { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_RARE")]
        public int MythosBurrowsDugTreasureRARE { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_RARE")]
        public int MythosBurrowsChainsCompleteRARE { get; set; }

        [JsonPropertyName("kills_gaia_construct")]
        public int KillsGaiaConstruct { get; set; }

        [JsonPropertyName("deaths_minotaur")]
        public int DeathsMinotaur { get; set; }

        [JsonPropertyName("deaths_gaia_construct")]
        public int DeathsGaiaConstruct { get; set; }

        [JsonPropertyName("kills_mayor_jerry_blue")]
        public int KillsMayorJerryBlue { get; set; }

        [JsonPropertyName("kills_mayor_jerry_golden")]
        public int KillsMayorJerryGolden { get; set; }

        [JsonPropertyName("kills_mayor_jerry_purple")]
        public int KillsMayorJerryPurple { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_EPIC")]
        public int MythosBurrowsDugNextEPIC { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_EPIC")]
        public int MythosBurrowsDugCombatEPIC { get; set; }

        [JsonPropertyName("kills_minos_champion")]
        public int KillsMinosChampion { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_EPIC")]
        public int MythosBurrowsDugTreasureEPIC { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_EPIC")]
        public int MythosBurrowsChainsCompleteEPIC { get; set; }

        [JsonPropertyName("kills_ice_walker")]
        public int KillsIceWalker { get; set; }

        [JsonPropertyName("kills_treasure_hoarder")]
        public int KillsTreasureHoarder { get; set; }

        [JsonPropertyName("kills_goblin_golem")]
        public int KillsGoblinGolem { get; set; }

        [JsonPropertyName("kills_goblin_battler")]
        public int KillsGoblinBattler { get; set; }

        [JsonPropertyName("kills_goblin_creepertamer")]
        public int KillsGoblinCreepertamer { get; set; }

        [JsonPropertyName("kills_goblin_creeper")]
        public int KillsGoblinCreeper { get; set; }

        [JsonPropertyName("deaths_caverns_ghost")]
        public int DeathsCavernsGhost { get; set; }

        [JsonPropertyName("kills_zombie_soldier")]
        public int KillsZombieSoldier { get; set; }

        [JsonPropertyName("kills_zombie_knight")]
        public int KillsZombieKnight { get; set; }

        [JsonPropertyName("kills_skeletor")]
        public int KillsSkeletor { get; set; }

        [JsonPropertyName("deaths_deathmite")]
        public int DeathsDeathmite { get; set; }

        [JsonPropertyName("deaths_diamond_guy")]
        public int DeathsDiamondGuy { get; set; }

        [JsonPropertyName("kills_scarf_warrior")]
        public int KillsScarfWarrior { get; set; }

        [JsonPropertyName("kills_shadow_assassin")]
        public int KillsShadowAssassin { get; set; }

        [JsonPropertyName("kills_professor_guardian_summon")]
        public int KillsProfessorGuardianSummon { get; set; }

        [JsonPropertyName("deaths_tiger_shark")]
        public int DeathsTigerShark { get; set; }

        [JsonPropertyName("kills_goblin_murderlover")]
        public int KillsGoblinMurderlover { get; set; }

        [JsonPropertyName("kills_crystal_sentry")]
        public int KillsCrystalSentry { get; set; }

        [JsonPropertyName("kills_powder_ghast")]
        public int KillsPowderGhast { get; set; }

        [JsonPropertyName("deaths_wither_gourd")]
        public int DeathsWitherGourd { get; set; }

        [JsonPropertyName("deaths_goblin_murderlover")]
        public int DeathsGoblinMurderlover { get; set; }

        [JsonPropertyName("kills_caverns_ghost")]
        public int KillsCavernsGhost { get; set; }

        [JsonPropertyName("deaths_ice_walker")]
        public int DeathsIceWalker { get; set; }

        [JsonPropertyName("deaths_treasure_hoarder")]
        public int DeathsTreasureHoarder { get; set; }

        [JsonPropertyName("kills_arachne_brood")]
        public int KillsArachneBrood { get; set; }

        [JsonPropertyName("deaths_arachne_keeper")]
        public int DeathsArachneKeeper { get; set; }

        [JsonPropertyName("deaths_arachne_brood")]
        public int DeathsArachneBrood { get; set; }

        [JsonPropertyName("deaths_arachne")]
        public int DeathsArachne { get; set; }

        [JsonPropertyName("kills_arachne_keeper")]
        public int KillsArachneKeeper { get; set; }

        [JsonPropertyName("deaths_witch_bat")]
        public int DeathsWitchBat { get; set; }

        [JsonPropertyName("deaths_phantom_spirit")]
        public int DeathsPhantomSpirit { get; set; }

        [JsonPropertyName("kills_dante_goon")]
        public int KillsDanteGoon { get; set; }

        [JsonPropertyName("kills_dante_slime_goon")]
        public int KillsDanteSlimeGoon { get; set; }

        [JsonPropertyName("kills_trapper_sheep")]
        public int KillsTrapperSheep { get; set; }

        [JsonPropertyName("kills_trapper_cow")]
        public int KillsTrapperCow { get; set; }

        [JsonPropertyName("deaths_watcher_bonzo")]
        public int DeathsWatcherBonzo { get; set; }

        [JsonPropertyName("kills_watcher_bonzo")]
        public int KillsWatcherBonzo { get; set; }

        [JsonPropertyName("deaths_professor_mage_guardian")]
        public int DeathsProfessorMageGuardian { get; set; }

        [JsonPropertyName("kills_yeti")]
        public int KillsYeti { get; set; }

        [JsonPropertyName("kills_oasis_sheep")]
        public int KillsOasisSheep { get; set; }

        [JsonPropertyName("kills_shrine_charged_creeper")]
        public int KillsShrineChargedCreeper { get; set; }

        [JsonPropertyName("kills_oasis_rabbit")]
        public int KillsOasisRabbit { get; set; }

        [JsonPropertyName("kills_arachne")]
        public int KillsArachne { get; set; }

        [JsonPropertyName("deaths_scary_jerry")]
        public int DeathsScaryJerry { get; set; }

        [JsonPropertyName("kills_scarf_archer")]
        public int KillsScarfArcher { get; set; }

        [JsonPropertyName("kills_scarf_priest")]
        public int KillsScarfPriest { get; set; }

        [JsonPropertyName("deaths_shadow_assassin")]
        public int DeathsShadowAssassin { get; set; }

        [JsonPropertyName("kills_voidling_fanatic")]
        public int KillsVoidlingFanatic { get; set; }

        [JsonPropertyName("deaths_lonely_spider")]
        public int DeathsLonelySpider { get; set; }

        [JsonPropertyName("kills_super_tank_zombie")]
        public int KillsSuperTankZombie { get; set; }

        [JsonPropertyName("kills_spirit_bull")]
        public int KillsSpiritBull { get; set; }

        [JsonPropertyName("kills_spirit_bat")]
        public int KillsSpiritBat { get; set; }

        [JsonPropertyName("kills_spirit_sheep")]
        public int KillsSpiritSheep { get; set; }

        [JsonPropertyName("kills_spirit_wolf")]
        public int KillsSpiritWolf { get; set; }

        [JsonPropertyName("kills_spirit_rabbit")]
        public int KillsSpiritRabbit { get; set; }

        [JsonPropertyName("kills_spirit_miniboss")]
        public int KillsSpiritMiniboss { get; set; }

        [JsonPropertyName("deaths_spirit_rabbit")]
        public int DeathsSpiritRabbit { get; set; }

        [JsonPropertyName("kills_tentaclees")]
        public int KillsTentaclees { get; set; }

        [JsonPropertyName("deaths_livid_clone")]
        public int DeathsLividClone { get; set; }

        [JsonPropertyName("deaths_skeletor")]
        public int DeathsSkeletor { get; set; }

        [JsonPropertyName("kills_super_archer")]
        public int KillsSuperArcher { get; set; }

        [JsonPropertyName("deaths_spirit_bat")]
        public int DeathsSpiritBat { get; set; }

        [JsonPropertyName("deaths_spirit_chicken")]
        public int DeathsSpiritChicken { get; set; }

        [JsonPropertyName("kills_spirit_chicken")]
        public int KillsSpiritChicken { get; set; }

        [JsonPropertyName("kills_crypt_witherskeleton")]
        public int KillsCryptWitherskeleton { get; set; }

        [JsonPropertyName("deaths_spirit_bull")]
        public int DeathsSpiritBull { get; set; }

        [JsonPropertyName("deaths_watcher_guardian")]
        public int DeathsWatcherGuardian { get; set; }

        [JsonPropertyName("kills_zombie_commander")]
        public int KillsZombieCommander { get; set; }

        [JsonPropertyName("kills_mimic")]
        public int KillsMimic { get; set; }

        [JsonPropertyName("deaths_sadan_golem")]
        public int DeathsSadanGolem { get; set; }

        [JsonPropertyName("deaths_tentaclees")]
        public int DeathsTentaclees { get; set; }

        [JsonPropertyName("deaths_sadan_statue")]
        public int DeathsSadanStatue { get; set; }

        [JsonPropertyName("kills_skeletor_prime")]
        public int KillsSkeletorPrime { get; set; }

        [JsonPropertyName("kills_sadan_statue")]
        public int KillsSadanStatue { get; set; }

        [JsonPropertyName("kills_sadan_golem")]
        public int KillsSadanGolem { get; set; }

        [JsonPropertyName("deaths_mimic")]
        public int DeathsMimic { get; set; }

        [JsonPropertyName("kills_watcher_scarf")]
        public int KillsWatcherScarf { get; set; }

        [JsonPropertyName("kills_king_midas")]
        public int KillsKingMidas { get; set; }

        [JsonPropertyName("deaths_professor_guardian_summon")]
        public int DeathsProfessorGuardianSummon { get; set; }

        [JsonPropertyName("kills_protector_dragon")]
        public int KillsProtectorDragon { get; set; }

        [JsonPropertyName("kills_corrupted_protector")]
        public int KillsCorruptedProtector { get; set; }

        [JsonPropertyName("kills_voidling_extremist")]
        public int KillsVoidlingExtremist { get; set; }

        [JsonPropertyName("auctions_sold_special")]
        public int AuctionsSoldSpecial { get; set; }

        [JsonPropertyName("deaths_professor")]
        public int DeathsProfessor { get; set; }

        [JsonPropertyName("deaths_kalhuiki_tribe_man")]
        public int DeathsKalhuikiTribeMan { get; set; }

        [JsonPropertyName("kills_sludge")]
        public int KillsSludge { get; set; }

        [JsonPropertyName("deaths_yog")]
        public int DeathsYog { get; set; }

        [JsonPropertyName("kills_yog")]
        public int KillsYog { get; set; }

        [JsonPropertyName("kills_trapped_sludge")]
        public int KillsTrappedSludge { get; set; }

        [JsonPropertyName("kills_team_treasurite_viper")]
        public int KillsTeamTreasuriteViper { get; set; }

        [JsonPropertyName("kills_team_treasurite_grunt")]
        public int KillsTeamTreasuriteGrunt { get; set; }

        [JsonPropertyName("kills_team_treasurite_sebastian")]
        public int KillsTeamTreasuriteSebastian { get; set; }

        [JsonPropertyName("kills_automaton")]
        public int KillsAutomaton { get; set; }

        [JsonPropertyName("kills_team_treasurite_wendy")]
        public int KillsTeamTreasuriteWendy { get; set; }

        [JsonPropertyName("kills_belle")]
        public int KillsBelle { get; set; }

        [JsonPropertyName("kills_cavitak")]
        public int KillsCavitak { get; set; }

        [JsonPropertyName("kills_goblin_flamethrower")]
        public int KillsGoblinFlamethrower { get; set; }

        [JsonPropertyName("kills_vittomite")]
        public int KillsVittomite { get; set; }

        [JsonPropertyName("kills_fire_bat")]
        public int KillsFireBat { get; set; }

        [JsonPropertyName("kills_butterfly")]
        public int KillsButterfly { get; set; }

        [JsonPropertyName("kills_sadan_giant")]
        public int KillsSadanGiant { get; set; }

        [JsonPropertyName("deaths_sadan_giant")]
        public int DeathsSadanGiant { get; set; }

        [JsonPropertyName("kills_silvo")]
        public int KillsSilvo { get; set; }

        [JsonPropertyName("kills_thyst")]
        public int KillsThyst { get; set; }

        [JsonPropertyName("kills_key_guardian")]
        public int KillsKeyGuardian { get; set; }

        [JsonPropertyName("deaths_wraith")]
        public int DeathsWraith { get; set; }

        [JsonPropertyName("deaths_livid")]
        public int DeathsLivid { get; set; }

        [JsonPropertyName("kills_kalhuiki_tribe_woman")]
        public int KillsKalhuikiTribeWoman { get; set; }

        [JsonPropertyName("kills_kalhuiki_tribe_man")]
        public int KillsKalhuikiTribeMan { get; set; }

        [JsonPropertyName("kills_worm")]
        public int KillsWorm { get; set; }

        [JsonPropertyName("kills_skeleton_lord")]
        public int KillsSkeletonLord { get; set; }

        [JsonPropertyName("kills_zombie_lord")]
        public int KillsZombieLord { get; set; }

        [JsonPropertyName("kills_wither_miner")]
        public int KillsWitherMiner { get; set; }

        [JsonPropertyName("deaths_maxor")]
        public int DeathsMaxor { get; set; }

        [JsonPropertyName("kills_wither_guard")]
        public int KillsWitherGuard { get; set; }

        [JsonPropertyName("deaths_wither_miner")]
        public int DeathsWitherMiner { get; set; }

        [JsonPropertyName("kills_smog")]
        public int KillsSmog { get; set; }

        [JsonPropertyName("kills_team_treasurite_corleone")]
        public int KillsTeamTreasuriteCorleone { get; set; }

        [JsonPropertyName("deaths_cellar_spider")]
        public int DeathsCellarSpider { get; set; }

        [JsonPropertyName("kills_lava_blaze")]
        public int KillsLavaBlaze { get; set; }

        [JsonPropertyName("kills_lava_pigman")]
        public int KillsLavaPigman { get; set; }

        [JsonPropertyName("deaths_watcher_scarf")]
        public int DeathsWatcherScarf { get; set; }

        [JsonPropertyName("deaths_kalhuiki_tribe_woman")]
        public int DeathsKalhuikiTribeWoman { get; set; }

        [JsonPropertyName("deaths_voidling_extremist")]
        public int DeathsVoidlingExtremist { get; set; }

        [JsonPropertyName("kills_flaming_worm")]
        public int KillsFlamingWorm { get; set; }

        [JsonPropertyName("deaths_automaton")]
        public int DeathsAutomaton { get; set; }

        [JsonPropertyName("kills_great_white_shark")]
        public int KillsGreatWhiteShark { get; set; }

        [JsonPropertyName("deaths_entity")]
        public int DeathsEntity { get; set; }

        [JsonPropertyName("kills_young_dragon")]
        public int KillsYoungDragon { get; set; }

        [JsonPropertyName("kills_watcher_livid")]
        public int KillsWatcherLivid { get; set; }

        [JsonPropertyName("deaths_sadan")]
        public int DeathsSadan { get; set; }

        [JsonPropertyName("deaths_dasher_spider")]
        public int DeathsDasherSpider { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_LEGENDARY")]
        public int MythosBurrowsDugNextLEGENDARY { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_LEGENDARY")]
        public int MythosBurrowsDugCombatLEGENDARY { get; set; }

        [JsonPropertyName("deaths_minos_inquisitor")]
        public int DeathsMinosInquisitor { get; set; }

        [JsonPropertyName("deaths_minos_champion")]
        public int DeathsMinosChampion { get; set; }

        [JsonPropertyName("kills_watcher_giant_laser")]
        public int KillsWatcherGiantLaser { get; set; }

        [JsonPropertyName("kills_watcher_giant_boulder")]
        public int KillsWatcherGiantBoulder { get; set; }

        [JsonPropertyName("kills_watcher_giant_bigfoot")]
        public int KillsWatcherGiantBigfoot { get; set; }

        [JsonPropertyName("kills_watcher_giant_diamond")]
        public int KillsWatcherGiantDiamond { get; set; }

        [JsonPropertyName("kills_scatha")]
        public int KillsScatha { get; set; }

        [JsonPropertyName("kills_master_crypt_tank_zombie")]
        public int KillsMasterCryptTankZombie { get; set; }

        [JsonPropertyName("kills_master_zombie_grunt")]
        public int KillsMasterZombieGrunt { get; set; }

        [JsonPropertyName("kills_master_crypt_lurker")]
        public int KillsMasterCryptLurker { get; set; }

        [JsonPropertyName("kills_master_skeleton_soldier")]
        public int KillsMasterSkeletonSoldier { get; set; }

        [JsonPropertyName("kills_master_dungeon_respawning_skeleton")]
        public int KillsMasterDungeonRespawningSkeleton { get; set; }

        [JsonPropertyName("kills_master_crypt_dreadlord")]
        public int KillsMasterCryptDreadlord { get; set; }

        [JsonPropertyName("kills_master_scared_skeleton")]
        public int KillsMasterScaredSkeleton { get; set; }

        [JsonPropertyName("kills_master_skeleton_grunt")]
        public int KillsMasterSkeletonGrunt { get; set; }

        [JsonPropertyName("deaths_master_crypt_lurker")]
        public int DeathsMasterCryptLurker { get; set; }

        [JsonPropertyName("kills_master_sniper_skeleton")]
        public int KillsMasterSniperSkeleton { get; set; }

        [JsonPropertyName("kills_master_crypt_souleater")]
        public int KillsMasterCryptSouleater { get; set; }

        [JsonPropertyName("deaths_master_dungeon_respawning_skeleton")]
        public int DeathsMasterDungeonRespawningSkeleton { get; set; }

        [JsonPropertyName("kills_master_lost_adventurer")]
        public int KillsMasterLostAdventurer { get; set; }

        [JsonPropertyName("kills_master_crypt_undead")]
        public int KillsMasterCryptUndead { get; set; }

        [JsonPropertyName("kills_master_crypt_undead_nicholas")]
        public int KillsMasterCryptUndeadNicholas { get; set; }

        [JsonPropertyName("kills_master_watcher_summon_undead")]
        public int KillsMasterWatcherSummonUndead { get; set; }

        [JsonPropertyName("deaths_master_bonzo_summon_undead")]
        public int DeathsMasterBonzoSummonUndead { get; set; }

        [JsonPropertyName("kills_master_diamond_guy")]
        public int KillsMasterDiamondGuy { get; set; }

        [JsonPropertyName("deaths_master_crypt_dreadlord")]
        public int DeathsMasterCryptDreadlord { get; set; }

        [JsonPropertyName("kills_master_cellar_spider")]
        public int KillsMasterCellarSpider { get; set; }

        [JsonPropertyName("deaths_master_diamond_guy")]
        public int DeathsMasterDiamondGuy { get; set; }

        [JsonPropertyName("deaths_master_sniper_skeleton")]
        public int DeathsMasterSniperSkeleton { get; set; }

        [JsonPropertyName("deaths_master_watcher_summon_undead")]
        public int DeathsMasterWatcherSummonUndead { get; set; }

        [JsonPropertyName("deaths_master_bonzo")]
        public int DeathsMasterBonzo { get; set; }

        [JsonPropertyName("deaths_master_crypt_souleater")]
        public int DeathsMasterCryptSouleater { get; set; }

        [JsonPropertyName("deaths_master_scared_skeleton")]
        public int DeathsMasterScaredSkeleton { get; set; }

        [JsonPropertyName("deaths_master_zombie_grunt")]
        public int DeathsMasterZombieGrunt { get; set; }

        [JsonPropertyName("deaths_master_scarf_warrior")]
        public int DeathsMasterScarfWarrior { get; set; }

        [JsonPropertyName("deaths_master_scarf")]
        public int DeathsMasterScarf { get; set; }

        [JsonPropertyName("deaths_skeletor_prime")]
        public int DeathsSkeletorPrime { get; set; }

        [JsonPropertyName("deaths_super_archer")]
        public int DeathsSuperArcher { get; set; }

        [JsonPropertyName("kills_master_crypt_undead_alexander")]
        public int KillsMasterCryptUndeadAlexander { get; set; }

        [JsonPropertyName("deaths_master_lost_adventurer")]
        public int DeathsMasterLostAdventurer { get; set; }

        [JsonPropertyName("kills_master_lonely_spider")]
        public int KillsMasterLonelySpider { get; set; }

        [JsonPropertyName("kills_master_bonzo_summon_undead")]
        public int KillsMasterBonzoSummonUndead { get; set; }

        [JsonPropertyName("deaths_crypt_witherskeleton")]
        public int DeathsCryptWitherskeleton { get; set; }

        [JsonPropertyName("fastest_time_s")]
        public int FastestTimeS { get; set; }

        [JsonPropertyName("fastest_time_s_plus")]
        public int FastestTimeSPlus { get; set; }

        [JsonPropertyName("deaths_siamese_lynx")]
        public int DeathsSiameseLynx { get; set; }

        [JsonPropertyName("deaths_goblin_weakling_melee")]
        public int DeathsGoblinWeaklingMelee { get; set; }

        [JsonPropertyName("deaths_crystal_sentry")]
        public int DeathsCrystalSentry { get; set; }

        [JsonPropertyName("deaths_respawning_skeleton")]
        public int DeathsRespawningSkeleton { get; set; }

        [JsonPropertyName("deaths_sea_walker")]
        public int DeathsSeaWalker { get; set; }

        [JsonPropertyName("deaths_sea_witch")]
        public int DeathsSeaWitch { get; set; }

        [JsonPropertyName("deaths_sea_archer")]
        public int DeathsSeaArcher { get; set; }
    }

    public class CollectLog
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToGuide
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class PublicIsland
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CraftWorkbench
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ExploreHub
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class ExploreVillage
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToLibrarian
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToFarmer
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToBlacksmith
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToLumberjack
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToEventMaster
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToAuctionMaster
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToBanker
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToFairy
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFisherman1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToCarpenter
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToArtist1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class PaintCanvas
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToPetCollector
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToPetSitter
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CraftWoodPickaxe
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class DepositCoins
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ChopTree
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToLumberjack2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToLazyMiner
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class IncreaseMiningSkill5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToTelekinesisApplier
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindPickaxe
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectIngots
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("GOLD_INGOT")]
        public bool GOLDINGOT { get; set; }

        [JsonPropertyName("IRON_INGOT")]
        public bool IRONINGOT { get; set; }
    }

    public class WarpDeepCaverns
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToLapisMiner
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class EnchantItem
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class GiveFairySouls
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseForagingSkill5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToGustave1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class CollectDarkOakLogs
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheWoodsRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGustave2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheWoodsRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFarmhand1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class IncreaseFarmingSkill5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class WarpMushroomDesert
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CraftWheatMinion
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectFarmingResources2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("INK_SACK:3")]
        public bool INKSACK3 { get; set; }

        [JsonPropertyName("CACTUS")]
        public bool CACTUS { get; set; }

        [JsonPropertyName("SUGAR_CANE")]
        public bool SUGARCANE { get; set; }
    }

    public class TalkToLiftOperator
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ReachLapisQuarry
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectLapis
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("INK_SACK:4")]
        public bool INKSACK4 { get; set; }
    }

    public class ReachPigmensDen
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectRedstone
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("REDSTONE")]
        public bool REDSTONE { get; set; }
    }

    public class ReachSlimehill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectEmerald
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("EMERALD")]
        public bool EMERALD { get; set; }
    }

    public class ReachDiamondReserve
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectDiamond
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("DIAMOND")]
        public bool DIAMOND { get; set; }
    }

    public class ReachObsidianSanctuary
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectObsidian
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("OBSIDIAN")]
        public bool OBSIDIAN { get; set; }
    }

    public class GivePickaxeLapisMiner
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineCoal
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToBlacksmith2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseMiningSkill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ReforgeItem
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class WarpGoldMine
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToArtist2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectWoolCarpenter
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToCharlie2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFrosty
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGulliver1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class CompleteTheChickenRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGulliver2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheChickenRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGulliver3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheChickenRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseCombatSkill5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToRick
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class WarpTheEnd
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class WarpBlazingFortress
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuber1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToEndDealer
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class CollectEndStone
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("ENDER_STONE")]
        public bool ENDERSTONE { get; set; }
    }

    public class ReachDragonsNest
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheEndRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FightDragon
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class GiveRickIngots
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectFarmAnimalResources2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("RABBIT")]
        public bool RABBIT { get; set; }

        [JsonPropertyName("MUTTON")]
        public bool MUTTON { get; set; }
    }

    public class TalkToGuildford1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToRhys
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class IncreaseMining12
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class HotmGiveMaterials
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("started")]
        public bool Started { get; set; }

        [JsonPropertyName("ENCHANTED_REDSTONE")]
        public int ENCHANTEDREDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_LAPIS_LAZULI")]
        public int ENCHANTEDLAPISLAZULI { get; set; }

        [JsonPropertyName("ENCHANTED_EMERALD")]
        public int ENCHANTEDEMERALD { get; set; }

        [JsonPropertyName("ENCHANTED_COAL")]
        public int ENCHANTEDCOAL { get; set; }
    }

    public class Objectives
    {
        [JsonPropertyName("collect_log")]
        public CollectLog CollectLog { get; set; }

        [JsonPropertyName("talk_to_guide")]
        public TalkToGuide TalkToGuide { get; set; }

        [JsonPropertyName("public_island")]
        public PublicIsland PublicIsland { get; set; }

        [JsonPropertyName("craft_workbench")]
        public CraftWorkbench CraftWorkbench { get; set; }

        [JsonPropertyName("explore_hub")]
        public ExploreHub ExploreHub { get; set; }

        [JsonPropertyName("explore_village")]
        public ExploreVillage ExploreVillage { get; set; }

        [JsonPropertyName("talk_to_librarian")]
        public TalkToLibrarian TalkToLibrarian { get; set; }

        [JsonPropertyName("talk_to_farmer")]
        public TalkToFarmer TalkToFarmer { get; set; }

        [JsonPropertyName("talk_to_blacksmith")]
        public TalkToBlacksmith TalkToBlacksmith { get; set; }

        [JsonPropertyName("talk_to_lumberjack")]
        public TalkToLumberjack TalkToLumberjack { get; set; }

        [JsonPropertyName("talk_to_event_master")]
        public TalkToEventMaster TalkToEventMaster { get; set; }

        [JsonPropertyName("talk_to_auction_master")]
        public TalkToAuctionMaster TalkToAuctionMaster { get; set; }

        [JsonPropertyName("talk_to_banker")]
        public TalkToBanker TalkToBanker { get; set; }

        [JsonPropertyName("talk_to_fairy")]
        public TalkToFairy TalkToFairy { get; set; }

        [JsonPropertyName("talk_to_fisherman_1")]
        public TalkToFisherman1 TalkToFisherman1 { get; set; }

        [JsonPropertyName("talk_to_carpenter")]
        public TalkToCarpenter TalkToCarpenter { get; set; }

        [JsonPropertyName("talk_to_artist_1")]
        public TalkToArtist1 TalkToArtist1 { get; set; }

        [JsonPropertyName("paint_canvas")]
        public PaintCanvas PaintCanvas { get; set; }

        [JsonPropertyName("talk_to_pet_collector")]
        public TalkToPetCollector TalkToPetCollector { get; set; }

        [JsonPropertyName("talk_to_pet_sitter")]
        public TalkToPetSitter TalkToPetSitter { get; set; }

        [JsonPropertyName("craft_wood_pickaxe")]
        public CraftWoodPickaxe CraftWoodPickaxe { get; set; }

        [JsonPropertyName("deposit_coins")]
        public DepositCoins DepositCoins { get; set; }

        [JsonPropertyName("chop_tree")]
        public ChopTree ChopTree { get; set; }

        [JsonPropertyName("talk_to_lumberjack_2")]
        public TalkToLumberjack2 TalkToLumberjack2 { get; set; }

        [JsonPropertyName("talk_to_lazy_miner")]
        public TalkToLazyMiner TalkToLazyMiner { get; set; }

        [JsonPropertyName("increase_mining_skill_5")]
        public IncreaseMiningSkill5 IncreaseMiningSkill5 { get; set; }

        [JsonPropertyName("talk_to_telekinesis_applier")]
        public TalkToTelekinesisApplier TalkToTelekinesisApplier { get; set; }

        [JsonPropertyName("find_pickaxe")]
        public FindPickaxe FindPickaxe { get; set; }

        [JsonPropertyName("collect_ingots")]
        public CollectIngots CollectIngots { get; set; }

        [JsonPropertyName("warp_deep_caverns")]
        public WarpDeepCaverns WarpDeepCaverns { get; set; }

        [JsonPropertyName("talk_to_lapis_miner")]
        public TalkToLapisMiner TalkToLapisMiner { get; set; }

        [JsonPropertyName("enchant_item")]
        public EnchantItem EnchantItem { get; set; }

        [JsonPropertyName("give_fairy_souls")]
        public GiveFairySouls GiveFairySouls { get; set; }

        [JsonPropertyName("increase_foraging_skill_5")]
        public IncreaseForagingSkill5 IncreaseForagingSkill5 { get; set; }

        [JsonPropertyName("talk_to_gustave_1")]
        public TalkToGustave1 TalkToGustave1 { get; set; }

        [JsonPropertyName("collect_dark_oak_logs")]
        public CollectDarkOakLogs CollectDarkOakLogs { get; set; }

        [JsonPropertyName("complete_the_woods_race_1")]
        public CompleteTheWoodsRace1 CompleteTheWoodsRace1 { get; set; }

        [JsonPropertyName("talk_to_gustave_2")]
        public TalkToGustave2 TalkToGustave2 { get; set; }

        [JsonPropertyName("complete_the_woods_race_2")]
        public CompleteTheWoodsRace2 CompleteTheWoodsRace2 { get; set; }

        [JsonPropertyName("talk_to_farmhand_1")]
        public TalkToFarmhand1 TalkToFarmhand1 { get; set; }

        [JsonPropertyName("increase_farming_skill_5")]
        public IncreaseFarmingSkill5 IncreaseFarmingSkill5 { get; set; }

        [JsonPropertyName("warp_mushroom_desert")]
        public WarpMushroomDesert WarpMushroomDesert { get; set; }

        [JsonPropertyName("craft_wheat_minion")]
        public CraftWheatMinion CraftWheatMinion { get; set; }

        [JsonPropertyName("collect_farming_resources_2")]
        public CollectFarmingResources2 CollectFarmingResources2 { get; set; }

        [JsonPropertyName("talk_to_lift_operator")]
        public TalkToLiftOperator TalkToLiftOperator { get; set; }

        [JsonPropertyName("reach_lapis_quarry")]
        public ReachLapisQuarry ReachLapisQuarry { get; set; }

        [JsonPropertyName("collect_lapis")]
        public CollectLapis CollectLapis { get; set; }

        [JsonPropertyName("reach_pigmens_den")]
        public ReachPigmensDen ReachPigmensDen { get; set; }

        [JsonPropertyName("collect_redstone")]
        public CollectRedstone CollectRedstone { get; set; }

        [JsonPropertyName("reach_slimehill")]
        public ReachSlimehill ReachSlimehill { get; set; }

        [JsonPropertyName("collect_emerald")]
        public CollectEmerald CollectEmerald { get; set; }

        [JsonPropertyName("reach_diamond_reserve")]
        public ReachDiamondReserve ReachDiamondReserve { get; set; }

        [JsonPropertyName("collect_diamond")]
        public CollectDiamond CollectDiamond { get; set; }

        [JsonPropertyName("reach_obsidian_sanctuary")]
        public ReachObsidianSanctuary ReachObsidianSanctuary { get; set; }

        [JsonPropertyName("collect_obsidian")]
        public CollectObsidian CollectObsidian { get; set; }

        [JsonPropertyName("give_pickaxe_lapis_miner")]
        public GivePickaxeLapisMiner GivePickaxeLapisMiner { get; set; }

        [JsonPropertyName("mine_coal")]
        public MineCoal MineCoal { get; set; }

        [JsonPropertyName("talk_to_blacksmith_2")]
        public TalkToBlacksmith2 TalkToBlacksmith2 { get; set; }

        [JsonPropertyName("increase_mining_skill")]
        public IncreaseMiningSkill IncreaseMiningSkill { get; set; }

        [JsonPropertyName("reforge_item")]
        public ReforgeItem ReforgeItem { get; set; }

        [JsonPropertyName("warp_gold_mine")]
        public WarpGoldMine WarpGoldMine { get; set; }

        [JsonPropertyName("talk_to_artist_2")]
        public TalkToArtist2 TalkToArtist2 { get; set; }

        [JsonPropertyName("collect_wool_carpenter")]
        public CollectWoolCarpenter CollectWoolCarpenter { get; set; }

        [JsonPropertyName("talk_to_charlie_2")]
        public TalkToCharlie2 TalkToCharlie2 { get; set; }

        [JsonPropertyName("talk_to_frosty")]
        public TalkToFrosty TalkToFrosty { get; set; }

        [JsonPropertyName("talk_to_gulliver_1")]
        public TalkToGulliver1 TalkToGulliver1 { get; set; }

        [JsonPropertyName("complete_the_chicken_race_1")]
        public CompleteTheChickenRace1 CompleteTheChickenRace1 { get; set; }

        [JsonPropertyName("talk_to_gulliver_2")]
        public TalkToGulliver2 TalkToGulliver2 { get; set; }

        [JsonPropertyName("complete_the_chicken_race_2")]
        public CompleteTheChickenRace2 CompleteTheChickenRace2 { get; set; }

        [JsonPropertyName("talk_to_gulliver_3")]
        public TalkToGulliver3 TalkToGulliver3 { get; set; }

        [JsonPropertyName("complete_the_chicken_race_3")]
        public CompleteTheChickenRace3 CompleteTheChickenRace3 { get; set; }

        [JsonPropertyName("increase_combat_skill_5")]
        public IncreaseCombatSkill5 IncreaseCombatSkill5 { get; set; }

        [JsonPropertyName("talk_to_rick")]
        public TalkToRick TalkToRick { get; set; }

        [JsonPropertyName("warp_the_end")]
        public WarpTheEnd WarpTheEnd { get; set; }

        [JsonPropertyName("warp_blazing_fortress")]
        public WarpBlazingFortress WarpBlazingFortress { get; set; }

        [JsonPropertyName("talk_to_guber_1")]
        public TalkToGuber1 TalkToGuber1 { get; set; }

        [JsonPropertyName("talk_to_end_dealer")]
        public TalkToEndDealer TalkToEndDealer { get; set; }

        [JsonPropertyName("collect_end_stone")]
        public CollectEndStone CollectEndStone { get; set; }

        [JsonPropertyName("reach_dragons_nest")]
        public ReachDragonsNest ReachDragonsNest { get; set; }

        [JsonPropertyName("complete_the_end_race_1")]
        public CompleteTheEndRace1 CompleteTheEndRace1 { get; set; }

        [JsonPropertyName("fight_dragon")]
        public FightDragon FightDragon { get; set; }

        [JsonPropertyName("give_rick_ingots")]
        public GiveRickIngots GiveRickIngots { get; set; }

        [JsonPropertyName("collect_farm_animal_resources_2")]
        public CollectFarmAnimalResources2 CollectFarmAnimalResources2 { get; set; }

        [JsonPropertyName("talk_to_guildford_1")]
        public TalkToGuildford1 TalkToGuildford1 { get; set; }

        [JsonPropertyName("talk_to_rhys")]
        public TalkToRhys TalkToRhys { get; set; }

        [JsonPropertyName("increase_mining_12")]
        public IncreaseMining12 IncreaseMining12 { get; set; }

        [JsonPropertyName("hotm_give_materials")]
        public HotmGiveMaterials HotmGiveMaterials { get; set; }

        [JsonPropertyName("collect_wheat")]
        public CollectWheat CollectWheat { get; set; }

        [JsonPropertyName("talk_to_farmer_2")]
        public TalkToFarmer2 TalkToFarmer2 { get; set; }

        [JsonPropertyName("increase_farming_skill")]
        public IncreaseFarmingSkill IncreaseFarmingSkill { get; set; }

        [JsonPropertyName("warp_barn_island")]
        public WarpBarnIsland WarpBarnIsland { get; set; }

        [JsonPropertyName("increase_foraging_skill")]
        public IncreaseForagingSkill IncreaseForagingSkill { get; set; }

        [JsonPropertyName("warp_foraging_islands")]
        public WarpForagingIslands WarpForagingIslands { get; set; }

        [JsonPropertyName("collect_birch_logs")]
        public CollectBirchLogs CollectBirchLogs { get; set; }

        [JsonPropertyName("talk_to_farmhand_2")]
        public TalkToFarmhand2 TalkToFarmhand2 { get; set; }

        [JsonPropertyName("collect_farming_resources")]
        public CollectFarmingResources CollectFarmingResources { get; set; }

        [JsonPropertyName("collect_farm_animal_resources")]
        public CollectFarmAnimalResources CollectFarmAnimalResources { get; set; }

        [JsonPropertyName("kill_danger_mobs")]
        public KillDangerMobs KillDangerMobs { get; set; }

        [JsonPropertyName("talk_to_bartender")]
        public TalkToBartender TalkToBartender { get; set; }

        [JsonPropertyName("increase_combat_skill")]
        public IncreaseCombatSkill IncreaseCombatSkill { get; set; }

        [JsonPropertyName("warp_spiders_den")]
        public WarpSpidersDen WarpSpidersDen { get; set; }

        [JsonPropertyName("collect_clay")]
        public CollectClay CollectClay { get; set; }

        [JsonPropertyName("talk_to_charlie")]
        public TalkToCharlie TalkToCharlie { get; set; }

        [JsonPropertyName("talk_to_haymitch")]
        public TalkToHaymitch TalkToHaymitch { get; set; }

        [JsonPropertyName("collect_spider")]
        public CollectSpider CollectSpider { get; set; }

        [JsonPropertyName("talk_to_elle")]
        public TalkToElle TalkToElle { get; set; }

        [JsonPropertyName("talk_to_fisherman_2")]
        public TalkToFisherman2 TalkToFisherman2 { get; set; }

        [JsonPropertyName("talk_to_guber_2")]
        public TalkToGuber2 TalkToGuber2 { get; set; }

        [JsonPropertyName("complete_the_end_race_2")]
        public CompleteTheEndRace2 CompleteTheEndRace2 { get; set; }

        [JsonPropertyName("talk_to_guber_3")]
        public TalkToGuber3 TalkToGuber3 { get; set; }

        [JsonPropertyName("complete_the_end_race_3")]
        public CompleteTheEndRace3 CompleteTheEndRace3 { get; set; }

        [JsonPropertyName("collect_nether_resources")]
        public CollectNetherResources CollectNetherResources { get; set; }

        [JsonPropertyName("collect_nether_resources_2")]
        public CollectNetherResources2 CollectNetherResources2 { get; set; }

        [JsonPropertyName("talk_to_guber_4")]
        public TalkToGuber4 TalkToGuber4 { get; set; }

        [JsonPropertyName("complete_the_end_race_4")]
        public CompleteTheEndRace4 CompleteTheEndRace4 { get; set; }

        [JsonPropertyName("talk_to_melody")]
        public TalkToMelody TalkToMelody { get; set; }

        [JsonPropertyName("talk_to_gustave_3")]
        public TalkToGustave3 TalkToGustave3 { get; set; }

        [JsonPropertyName("complete_the_woods_race_3")]
        public CompleteTheWoodsRace3 CompleteTheWoodsRace3 { get; set; }

        [JsonPropertyName("talk_to_gustave_4")]
        public TalkToGustave4 TalkToGustave4 { get; set; }

        [JsonPropertyName("complete_the_woods_race_4")]
        public CompleteTheWoodsRace4 CompleteTheWoodsRace4 { get; set; }

        [JsonPropertyName("talk_to_guber_5")]
        public TalkToGuber5 TalkToGuber5 { get; set; }

        [JsonPropertyName("talk_to_gustave_5")]
        public TalkToGustave5 TalkToGustave5 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_anything_with_return_race_1")]
        public CompleteTheGiantMushroomAnythingWithReturnRace1 CompleteTheGiantMushroomAnythingWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_no_pearls_with_return_race_1")]
        public CompleteTheGiantMushroomNoPearlsWithReturnRace1 CompleteTheGiantMushroomNoPearlsWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_no_abilities_with_return_race_1")]
        public CompleteTheGiantMushroomNoAbilitiesWithReturnRace1 CompleteTheGiantMushroomNoAbilitiesWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_nothing_with_return_race_1")]
        public CompleteTheGiantMushroomNothingWithReturnRace1 CompleteTheGiantMushroomNothingWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_anything_with_return_race_1")]
        public CompleteThePrecursorRuinsAnythingWithReturnRace1 CompleteThePrecursorRuinsAnythingWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_no_pearls_with_return_race_1")]
        public CompleteThePrecursorRuinsNoPearlsWithReturnRace1 CompleteThePrecursorRuinsNoPearlsWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_no_abilities_with_return_race_1")]
        public CompleteThePrecursorRuinsNoAbilitiesWithReturnRace1 CompleteThePrecursorRuinsNoAbilitiesWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_nothing_with_return_race_1")]
        public CompleteThePrecursorRuinsNothingWithReturnRace1 CompleteThePrecursorRuinsNothingWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_anything_with_return_race_1")]
        public CompleteTheCrystalCoreAnythingWithReturnRace1 CompleteTheCrystalCoreAnythingWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_no_pearls_with_return_race_1")]
        public CompleteTheCrystalCoreNoPearlsWithReturnRace1 CompleteTheCrystalCoreNoPearlsWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_no_abilities_with_return_race_1")]
        public CompleteTheCrystalCoreNoAbilitiesWithReturnRace1 CompleteTheCrystalCoreNoAbilitiesWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_nothing_with_return_race_1")]
        public CompleteTheCrystalCoreNothingWithReturnRace1 CompleteTheCrystalCoreNothingWithReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_anything_no_return_race_1")]
        public CompleteTheGiantMushroomAnythingNoReturnRace1 CompleteTheGiantMushroomAnythingNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_no_pearls_no_return_race_1")]
        public CompleteTheGiantMushroomNoPearlsNoReturnRace1 CompleteTheGiantMushroomNoPearlsNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_no_abilities_no_return_race_1")]
        public CompleteTheGiantMushroomNoAbilitiesNoReturnRace1 CompleteTheGiantMushroomNoAbilitiesNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_nothing_no_return_race_1")]
        public CompleteTheGiantMushroomNothingNoReturnRace1 CompleteTheGiantMushroomNothingNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_anything_no_return_race_1")]
        public CompleteThePrecursorRuinsAnythingNoReturnRace1 CompleteThePrecursorRuinsAnythingNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_no_pearls_no_return_race_1")]
        public CompleteThePrecursorRuinsNoPearlsNoReturnRace1 CompleteThePrecursorRuinsNoPearlsNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_no_abilities_no_return_race_1")]
        public CompleteThePrecursorRuinsNoAbilitiesNoReturnRace1 CompleteThePrecursorRuinsNoAbilitiesNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_nothing_no_return_race_1")]
        public CompleteThePrecursorRuinsNothingNoReturnRace1 CompleteThePrecursorRuinsNothingNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_anything_no_return_race_1")]
        public CompleteTheCrystalCoreAnythingNoReturnRace1 CompleteTheCrystalCoreAnythingNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_no_pearls_no_return_race_1")]
        public CompleteTheCrystalCoreNoPearlsNoReturnRace1 CompleteTheCrystalCoreNoPearlsNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_no_abilities_no_return_race_1")]
        public CompleteTheCrystalCoreNoAbilitiesNoReturnRace1 CompleteTheCrystalCoreNoAbilitiesNoReturnRace1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_nothing_no_return_race_1")]
        public CompleteTheCrystalCoreNothingNoReturnRace1 CompleteTheCrystalCoreNothingNoReturnRace1 { get; set; }

        [JsonPropertyName("talk_to_guildford_giant_mushroom_anything_no_return_1")]
        public TalkToGuildfordGiantMushroomAnythingNoReturn1 TalkToGuildfordGiantMushroomAnythingNoReturn1 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_anything_no_return_race_2")]
        public CompleteTheGiantMushroomAnythingNoReturnRace2 CompleteTheGiantMushroomAnythingNoReturnRace2 { get; set; }

        [JsonPropertyName("talk_to_guildford_giant_mushroom_anything_no_return_2")]
        public TalkToGuildfordGiantMushroomAnythingNoReturn2 TalkToGuildfordGiantMushroomAnythingNoReturn2 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_anything_no_return_race_3")]
        public CompleteTheGiantMushroomAnythingNoReturnRace3 CompleteTheGiantMushroomAnythingNoReturnRace3 { get; set; }

        [JsonPropertyName("talk_to_guildford_giant_mushroom_anything_no_return_3")]
        public TalkToGuildfordGiantMushroomAnythingNoReturn3 TalkToGuildfordGiantMushroomAnythingNoReturn3 { get; set; }

        [JsonPropertyName("complete_the_giant_mushroom_anything_no_return_race_4")]
        public CompleteTheGiantMushroomAnythingNoReturnRace4 CompleteTheGiantMushroomAnythingNoReturnRace4 { get; set; }

        [JsonPropertyName("talk_to_guildford_giant_mushroom_anything_no_return_4")]
        public TalkToGuildfordGiantMushroomAnythingNoReturn4 TalkToGuildfordGiantMushroomAnythingNoReturn4 { get; set; }

        [JsonPropertyName("talk_to_guildford_precursor_ruins_anything_no_return_1")]
        public TalkToGuildfordPrecursorRuinsAnythingNoReturn1 TalkToGuildfordPrecursorRuinsAnythingNoReturn1 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_anything_no_return_race_2")]
        public CompleteThePrecursorRuinsAnythingNoReturnRace2 CompleteThePrecursorRuinsAnythingNoReturnRace2 { get; set; }

        [JsonPropertyName("talk_to_guildford_precursor_ruins_anything_no_return_2")]
        public TalkToGuildfordPrecursorRuinsAnythingNoReturn2 TalkToGuildfordPrecursorRuinsAnythingNoReturn2 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_anything_no_return_race_3")]
        public CompleteThePrecursorRuinsAnythingNoReturnRace3 CompleteThePrecursorRuinsAnythingNoReturnRace3 { get; set; }

        [JsonPropertyName("talk_to_guildford_precursor_ruins_anything_no_return_3")]
        public TalkToGuildfordPrecursorRuinsAnythingNoReturn3 TalkToGuildfordPrecursorRuinsAnythingNoReturn3 { get; set; }

        [JsonPropertyName("complete_the_precursor_ruins_anything_no_return_race_4")]
        public CompleteThePrecursorRuinsAnythingNoReturnRace4 CompleteThePrecursorRuinsAnythingNoReturnRace4 { get; set; }

        [JsonPropertyName("talk_to_guildford_precursor_ruins_anything_no_return_4")]
        public TalkToGuildfordPrecursorRuinsAnythingNoReturn4 TalkToGuildfordPrecursorRuinsAnythingNoReturn4 { get; set; }

        [JsonPropertyName("talk_to_guildford_crystal_core_anything_no_return_1")]
        public TalkToGuildfordCrystalCoreAnythingNoReturn1 TalkToGuildfordCrystalCoreAnythingNoReturn1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_anything_no_return_race_2")]
        public CompleteTheCrystalCoreAnythingNoReturnRace2 CompleteTheCrystalCoreAnythingNoReturnRace2 { get; set; }

        [JsonPropertyName("talk_to_guildford_crystal_core_anything_no_return_2")]
        public TalkToGuildfordCrystalCoreAnythingNoReturn2 TalkToGuildfordCrystalCoreAnythingNoReturn2 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_anything_no_return_race_3")]
        public CompleteTheCrystalCoreAnythingNoReturnRace3 CompleteTheCrystalCoreAnythingNoReturnRace3 { get; set; }

        [JsonPropertyName("talk_to_guildford_crystal_core_anything_no_return_3")]
        public TalkToGuildfordCrystalCoreAnythingNoReturn3 TalkToGuildfordCrystalCoreAnythingNoReturn3 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_anything_no_return_race_4")]
        public CompleteTheCrystalCoreAnythingNoReturnRace4 CompleteTheCrystalCoreAnythingNoReturnRace4 { get; set; }

        [JsonPropertyName("talk_to_guildford_crystal_core_no_pearls_no_return_1")]
        public TalkToGuildfordCrystalCoreNoPearlsNoReturn1 TalkToGuildfordCrystalCoreNoPearlsNoReturn1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_no_pearls_no_return_race_2")]
        public CompleteTheCrystalCoreNoPearlsNoReturnRace2 CompleteTheCrystalCoreNoPearlsNoReturnRace2 { get; set; }

        [JsonPropertyName("talk_to_guildford_crystal_core_no_pearls_no_return_2")]
        public TalkToGuildfordCrystalCoreNoPearlsNoReturn2 TalkToGuildfordCrystalCoreNoPearlsNoReturn2 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_no_pearls_no_return_race_3")]
        public CompleteTheCrystalCoreNoPearlsNoReturnRace3 CompleteTheCrystalCoreNoPearlsNoReturnRace3 { get; set; }

        [JsonPropertyName("talk_to_guildford_crystal_core_no_pearls_no_return_3")]
        public TalkToGuildfordCrystalCoreNoPearlsNoReturn3 TalkToGuildfordCrystalCoreNoPearlsNoReturn3 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_no_pearls_no_return_race_4")]
        public CompleteTheCrystalCoreNoPearlsNoReturnRace4 CompleteTheCrystalCoreNoPearlsNoReturnRace4 { get; set; }

        [JsonPropertyName("talk_to_guildford_crystal_core_no_pearls_no_return_4")]
        public TalkToGuildfordCrystalCoreNoPearlsNoReturn4 TalkToGuildfordCrystalCoreNoPearlsNoReturn4 { get; set; }

        [JsonPropertyName("talk_to_guildford_crystal_core_no_abilities_no_return_1")]
        public TalkToGuildfordCrystalCoreNoAbilitiesNoReturn1 TalkToGuildfordCrystalCoreNoAbilitiesNoReturn1 { get; set; }

        [JsonPropertyName("complete_the_crystal_core_no_abilities_no_return_race_2")]
        public CompleteTheCrystalCoreNoAbilitiesNoReturnRace2 CompleteTheCrystalCoreNoAbilitiesNoReturnRace2 { get; set; }

        [JsonPropertyName("fetchur-26-1")]
        public Fetchur261 Fetchur261 { get; set; }

        [JsonPropertyName("fetchur-27-1")]
        public Fetchur271 Fetchur271 { get; set; }

        [JsonPropertyName("fetchur-28-1")]
        public Fetchur281 Fetchur281 { get; set; }

        [JsonPropertyName("fetchur-1-2")]
        public Fetchur12 Fetchur12 { get; set; }

        [JsonPropertyName("fetchur-2-2")]
        public Fetchur22 Fetchur22 { get; set; }

        [JsonPropertyName("fetchur-3-2")]
        public Fetchur32 Fetchur32 { get; set; }

        [JsonPropertyName("fetchur-4-2")]
        public Fetchur42 Fetchur42 { get; set; }

        [JsonPropertyName("fetchur-5-2")]
        public Fetchur52 Fetchur52 { get; set; }

        [JsonPropertyName("fetchur-6-2")]
        public Fetchur62 Fetchur62 { get; set; }

        [JsonPropertyName("fetchur-7-2")]
        public Fetchur72 Fetchur72 { get; set; }

        [JsonPropertyName("talk_to_archaeologist")]
        public TalkToArchaeologist TalkToArchaeologist { get; set; }

        [JsonPropertyName("talk_to_shaggy")]
        public TalkToShaggy TalkToShaggy { get; set; }

        [JsonPropertyName("find_relics")]
        public FindRelics FindRelics { get; set; }

        [JsonPropertyName("find_uber_relics")]
        public FindUberRelics FindUberRelics { get; set; }

        [JsonPropertyName("fetchur-18-2")]
        public Fetchur182 Fetchur182 { get; set; }

        [JsonPropertyName("fetchur-19-2")]
        public Fetchur192 Fetchur192 { get; set; }

        [JsonPropertyName("fetchur-23-2")]
        public Fetchur232 Fetchur232 { get; set; }

        [JsonPropertyName("fetchur-26-2")]
        public Fetchur262 Fetchur262 { get; set; }

        [JsonPropertyName("fetchur-27-2")]
        public Fetchur272 Fetchur272 { get; set; }

        [JsonPropertyName("fetchur-29-2")]
        public Fetchur292 Fetchur292 { get; set; }

        [JsonPropertyName("fetchur-4-3")]
        public Fetchur43 Fetchur43 { get; set; }

        [JsonPropertyName("fetchur-6-3")]
        public Fetchur63 Fetchur63 { get; set; }

        [JsonPropertyName("fetchur-8-3")]
        public Fetchur83 Fetchur83 { get; set; }

        [JsonPropertyName("fetchur-13-3")]
        public Fetchur133 Fetchur133 { get; set; }

        [JsonPropertyName("fetchur-16-3")]
        public Fetchur163 Fetchur163 { get; set; }

        [JsonPropertyName("fetchur-19-3")]
        public Fetchur193 Fetchur193 { get; set; }

        [JsonPropertyName("fetchur-23-3")]
        public Fetchur233 Fetchur233 { get; set; }

        [JsonPropertyName("fetchur-29-3")]
        public Fetchur293 Fetchur293 { get; set; }

        [JsonPropertyName("fetchur-30-3")]
        public Fetchur303 Fetchur303 { get; set; }

        [JsonPropertyName("fetchur-6-4")]
        public Fetchur64 Fetchur64 { get; set; }

        [JsonPropertyName("fetchur-10-4")]
        public Fetchur104 Fetchur104 { get; set; }

        [JsonPropertyName("fetchur-11-4")]
        public Fetchur114 Fetchur114 { get; set; }

        [JsonPropertyName("fetchur-12-4")]
        public Fetchur124 Fetchur124 { get; set; }

        [JsonPropertyName("fetchur-13-4")]
        public Fetchur134 Fetchur134 { get; set; }

        [JsonPropertyName("fetchur-15-4")]
        public Fetchur154 Fetchur154 { get; set; }

        [JsonPropertyName("fetchur-18-4")]
        public Fetchur184 Fetchur184 { get; set; }

        [JsonPropertyName("fetchur-21-4")]
        public Fetchur214 Fetchur214 { get; set; }

        [JsonPropertyName("fetchur-22-4")]
        public Fetchur224 Fetchur224 { get; set; }

        [JsonPropertyName("fetchur-4-5")]
        public Fetchur45 Fetchur45 { get; set; }

        [JsonPropertyName("fetchur-26-5")]
        public Fetchur265 Fetchur265 { get; set; }

        [JsonPropertyName("talk_to_gwendolyn")]
        public TalkToGwendolyn TalkToGwendolyn { get; set; }

        [JsonPropertyName("talk_to_braum")]
        public TalkToBraum TalkToBraum { get; set; }

        [JsonPropertyName("visit_greater_mines")]
        public VisitGreaterMines VisitGreaterMines { get; set; }

        [JsonPropertyName("talk_to_the_goblin_king")]
        public TalkToTheGoblinKing TalkToTheGoblinKing { get; set; }

        [JsonPropertyName("kill_automatons")]
        public KillAutomatons KillAutomatons { get; set; }

        [JsonPropertyName("enter_divan_mines")]
        public EnterDivanMines EnterDivanMines { get; set; }

        [JsonPropertyName("find_a_jungle_key")]
        public FindAJungleKey FindAJungleKey { get; set; }

        [JsonPropertyName("mine_ruby")]
        public MineRuby MineRuby { get; set; }

        [JsonPropertyName("talk_to_professor_robot")]
        public TalkToProfessorRobot TalkToProfessorRobot { get; set; }

        [JsonPropertyName("find_four_missing_pieces")]
        public FindFourMissingPieces FindFourMissingPieces { get; set; }

        [JsonPropertyName("mine_jade")]
        public MineJade MineJade { get; set; }

        [JsonPropertyName("mine_sapphire")]
        public MineSapphire MineSapphire { get; set; }

        [JsonPropertyName("find_the_goblin_queen")]
        public FindTheGoblinQueen FindTheGoblinQueen { get; set; }

        [JsonPropertyName("mine_amber")]
        public MineAmber MineAmber { get; set; }

        [JsonPropertyName("complete_trials_of_jungle_temple")]
        public CompleteTrialsOfJungleTemple CompleteTrialsOfJungleTemple { get; set; }

        [JsonPropertyName("mine_amethyst")]
        public MineAmethyst MineAmethyst { get; set; }

        [JsonPropertyName("fetchur-15-8")]
        public Fetchur158 Fetchur158 { get; set; }

        [JsonPropertyName("fetchur-20-8")]
        public Fetchur208 Fetchur208 { get; set; }

        [JsonPropertyName("fetchur-21-8")]
        public Fetchur218 Fetchur218 { get; set; }

        [JsonPropertyName("fetchur-3-9")]
        public Fetchur39 Fetchur39 { get; set; }

        [JsonPropertyName("fetchur-6-9")]
        public Fetchur69 Fetchur69 { get; set; }

        [JsonPropertyName("fetchur-7-9")]
        public Fetchur79 Fetchur79 { get; set; }

        [JsonPropertyName("fetchur-10-9")]
        public Fetchur109 Fetchur109 { get; set; }

        [JsonPropertyName("fetchur-19-9")]
        public Fetchur199 Fetchur199 { get; set; }

        [JsonPropertyName("fetchur-21-9")]
        public Fetchur219 Fetchur219 { get; set; }
    }

    public class Quests
    {
        [JsonPropertyName("collect_log")]
        public CollectLog CollectLog { get; set; }

        [JsonPropertyName("explore_hub")]
        public ExploreHub ExploreHub { get; set; }

        [JsonPropertyName("explore_village")]
        public ExploreVillage ExploreVillage { get; set; }

        [JsonPropertyName("talk_to_librarian")]
        public TalkToLibrarian TalkToLibrarian { get; set; }

        [JsonPropertyName("talk_to_farmer")]
        public TalkToFarmer TalkToFarmer { get; set; }

        [JsonPropertyName("talk_to_blacksmith")]
        public TalkToBlacksmith TalkToBlacksmith { get; set; }

        [JsonPropertyName("talk_to_lumberjack")]
        public TalkToLumberjack TalkToLumberjack { get; set; }

        [JsonPropertyName("talk_to_auction_master")]
        public TalkToAuctionMaster TalkToAuctionMaster { get; set; }

        [JsonPropertyName("talk_to_banker")]
        public TalkToBanker TalkToBanker { get; set; }

        [JsonPropertyName("talk_to_carpenter")]
        public TalkToCarpenter TalkToCarpenter { get; set; }

        [JsonPropertyName("talk_to_artist_1")]
        public TalkToArtist1 TalkToArtist1 { get; set; }

        [JsonPropertyName("talk_to_lazy_miner")]
        public TalkToLazyMiner TalkToLazyMiner { get; set; }

        [JsonPropertyName("increase_mining_skill_5")]
        public IncreaseMiningSkill5 IncreaseMiningSkill5 { get; set; }

        [JsonPropertyName("talk_to_lapis_miner")]
        public TalkToLapisMiner TalkToLapisMiner { get; set; }

        [JsonPropertyName("increase_foraging_skill_5")]
        public IncreaseForagingSkill5 IncreaseForagingSkill5 { get; set; }

        [JsonPropertyName("talk_to_gustave_1")]
        public TalkToGustave1 TalkToGustave1 { get; set; }

        [JsonPropertyName("talk_to_farmhand_1")]
        public TalkToFarmhand1 TalkToFarmhand1 { get; set; }

        [JsonPropertyName("increase_farming_skill_5")]
        public IncreaseFarmingSkill5 IncreaseFarmingSkill5 { get; set; }

        [JsonPropertyName("reforge_item")]
        public ReforgeItem ReforgeItem { get; set; }

        [JsonPropertyName("talk_to_gulliver_1")]
        public TalkToGulliver1 TalkToGulliver1 { get; set; }

        [JsonPropertyName("increase_combat_skill_5")]
        public IncreaseCombatSkill5 IncreaseCombatSkill5 { get; set; }

        [JsonPropertyName("talk_to_rick")]
        public TalkToRick TalkToRick { get; set; }

        [JsonPropertyName("talk_to_guber_1")]
        public TalkToGuber1 TalkToGuber1 { get; set; }

        [JsonPropertyName("talk_to_end_dealer")]
        public TalkToEndDealer TalkToEndDealer { get; set; }

        [JsonPropertyName("talk_to_guildford_1")]
        public TalkToGuildford1 TalkToGuildford1 { get; set; }

        [JsonPropertyName("talk_to_rhys")]
        public TalkToRhys TalkToRhys { get; set; }

        [JsonPropertyName("kill_danger_mobs")]
        public KillDangerMobs KillDangerMobs { get; set; }

        [JsonPropertyName("talk_to_archaeologist")]
        public TalkToArchaeologist TalkToArchaeologist { get; set; }

        [JsonPropertyName("talk_to_gwendolyn")]
        public TalkToGwendolyn TalkToGwendolyn { get; set; }

        [JsonPropertyName("talk_to_the_goblin_king")]
        public TalkToTheGoblinKing TalkToTheGoblinKing { get; set; }

        [JsonPropertyName("kill_automatons")]
        public KillAutomatons KillAutomatons { get; set; }

        [JsonPropertyName("enter_divan_mines")]
        public EnterDivanMines EnterDivanMines { get; set; }

        [JsonPropertyName("find_a_jungle_key")]
        public FindAJungleKey FindAJungleKey { get; set; }
    }

    public class ClaimedLevels
    {
        [JsonPropertyName("level_1")]
        public bool Level1 { get; set; }

        [JsonPropertyName("level_2")]
        public bool Level2 { get; set; }

        [JsonPropertyName("level_3")]
        public bool Level3 { get; set; }

        [JsonPropertyName("level_4")]
        public bool Level4 { get; set; }

        [JsonPropertyName("level_5")]
        public bool Level5 { get; set; }

        [JsonPropertyName("level_6")]
        public bool Level6 { get; set; }

        [JsonPropertyName("level_7_special")]
        public bool Level7Special { get; set; }
    }

    public class Spider
    {
        [JsonPropertyName("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("kills")]
        public Kills Kills { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public int BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public int BossKillsTier1 { get; set; }

        [JsonPropertyName("boss_kills_tier_2")]
        public int BossKillsTier2 { get; set; }

        [JsonPropertyName("boss_kills_tier_3")]
        public int BossKillsTier3 { get; set; }
    }

    public class Wolf
    {
        [JsonPropertyName("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("kills")]
        public Kills Kills { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public int BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public int BossKillsTier1 { get; set; }

        [JsonPropertyName("boss_kills_tier_2")]
        public int BossKillsTier2 { get; set; }

        [JsonPropertyName("boss_kills_tier_3")]
        public int BossKillsTier3 { get; set; }
    }

    public class Zombie
    {
        [JsonPropertyName("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("kills")]
        public Kills Kills { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public int BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public int BossKillsTier1 { get; set; }

        [JsonPropertyName("boss_kills_tier_2")]
        public int BossKillsTier2 { get; set; }

        [JsonPropertyName("boss_kills_tier_3")]
        public int BossKillsTier3 { get; set; }
    }

    public class Enderman
    {
        [JsonPropertyName("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("kills")]
        public Kills Kills { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public int BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public int BossKillsTier1 { get; set; }
    }

    public class SlayerBosses
    {
        [JsonPropertyName("spider")]
        public Spider Spider { get; set; }

        [JsonPropertyName("wolf")]
        public Wolf Wolf { get; set; }

        [JsonPropertyName("zombie")]
        public Zombie Zombie { get; set; }

        [JsonPropertyName("enderman")]
        public Enderman Enderman { get; set; }
    }

    public class Level
    {
        [JsonPropertyName("level")]
        public double LevelProperty { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("xpMaxLevel")]
        public double XpMaxLevel { get; set; }

        [JsonPropertyName("currentLevel")]
        public int CurrentLevel { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("weight")]
        public Weight Weight { get; set; }

        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("level_cap")]
        public double Level_Cap { get; set; }

        [JsonPropertyName("uncapped_level")]
        public int Uncapped_Level { get; set; }
    }

    public class Ref
    {
        [JsonPropertyName("rarity")]
        public int Rarity { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }
    }

    public class Pet
    {
        [JsonPropertyName("uuid")]
        public object Uuid { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("exp")]
        public double Exp { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("tier")]
        public string Tier { get; set; }

        [JsonPropertyName("heldItem")]
        public string HeldItem { get; set; }

        [JsonPropertyName("candyUsed")]
        public int CandyUsed { get; set; }

        [JsonPropertyName("skin")]
        public object Skin { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

 /*        [JsonPropertyName("level")]
       public Level Level { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("ref")]
        public Ref Ref { get; set; }

        [JsonPropertyName("lore")]
        public string Lore { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; } */

        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }
    }

    public class TimesPlayed
    {
        [JsonPropertyName("0")]
        public int _0 { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }

    public class BestScore
    {
        [JsonPropertyName("0")]
        public int _0 { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }

    public class MobsKilled
    {
        [JsonPropertyName("0")]
        public int _0 { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }

    public class MostMobsKilled
    {
        [JsonPropertyName("0")]
        public int _0 { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }

    public class MostDamageTank
    {
        [JsonPropertyName("0")]
        public double _0 { get; set; }

        [JsonPropertyName("1")]
        public double _1 { get; set; }

        [JsonPropertyName("2")]
        public double _2 { get; set; }

        [JsonPropertyName("3")]
        public double _3 { get; set; }

        [JsonPropertyName("4")]
        public double _4 { get; set; }

        [JsonPropertyName("5")]
        public double _5 { get; set; }

        [JsonPropertyName("6")]
        public double _6 { get; set; }

        [JsonPropertyName("7")]
        public double _7 { get; set; }
    }

    public class MostHealing
    {
        [JsonPropertyName("0")]
        public double _0 { get; set; }

        [JsonPropertyName("1")]
        public double _1 { get; set; }

        [JsonPropertyName("2")]
        public double _2 { get; set; }

        [JsonPropertyName("3")]
        public double _3 { get; set; }

        [JsonPropertyName("4")]
        public double _4 { get; set; }

        [JsonPropertyName("5")]
        public double _5 { get; set; }

        [JsonPropertyName("6")]
        public double _6 { get; set; }

        [JsonPropertyName("7")]
        public double _7 { get; set; }
    }

    public class MostDamageArcher
    {
        [JsonPropertyName("0")]
        public double _0 { get; set; }

        [JsonPropertyName("1")]
        public double _1 { get; set; }

        [JsonPropertyName("2")]
        public double _2 { get; set; }

        [JsonPropertyName("3")]
        public double _3 { get; set; }

        [JsonPropertyName("4")]
        public double _4 { get; set; }

        [JsonPropertyName("5")]
        public double _5 { get; set; }

        [JsonPropertyName("6")]
        public double _6 { get; set; }

        [JsonPropertyName("7")]
        public double _7 { get; set; }
    }

    public class MostDamageMage
    {
        [JsonPropertyName("0")]
        public double _0 { get; set; }

        [JsonPropertyName("1")]
        public double _1 { get; set; }

        [JsonPropertyName("2")]
        public double _2 { get; set; }

        [JsonPropertyName("3")]
        public double _3 { get; set; }

        [JsonPropertyName("4")]
        public double _4 { get; set; }

        [JsonPropertyName("5")]
        public double _5 { get; set; }

        [JsonPropertyName("6")]
        public double _6 { get; set; }

        [JsonPropertyName("7")]
        public double _7 { get; set; }
    }

    public class MostDamageHealer
    {
        [JsonPropertyName("0")]
        public double _0 { get; set; }

        [JsonPropertyName("1")]
        public double _1 { get; set; }

        [JsonPropertyName("2")]
        public double _2 { get; set; }

        [JsonPropertyName("3")]
        public double _3 { get; set; }

        [JsonPropertyName("4")]
        public double _4 { get; set; }

        [JsonPropertyName("5")]
        public double _5 { get; set; }

        [JsonPropertyName("6")]
        public double _6 { get; set; }

        [JsonPropertyName("7")]
        public double _7 { get; set; }
    }

    public class TierCompletions
    {
        [JsonPropertyName("0")]
        public int _0 { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }

    public class MilestoneCompletions
    {
        [JsonPropertyName("0")]
        public int _0 { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }

    public class FastestTime
    {
        [JsonPropertyName("0")]
        public int _0 { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }


    public class BestRuns
    {
        [JsonPropertyName("timestamp")]
        public object Timestamp { get; set; }

        [JsonPropertyName("score_exploration")]
        public int ScoreExploration { get; set; }

        [JsonPropertyName("score_speed")]
        public int ScoreSpeed { get; set; }

        [JsonPropertyName("score_skill")]
        public int ScoreSkill { get; set; }

        [JsonPropertyName("score_bonus")]
        public int ScoreBonus { get; set; }

        [JsonPropertyName("dungeon_class")]
        public string DungeonClass { get; set; }

        [JsonPropertyName("teammates")]
        public List<string> Teammates { get; set; }

        [JsonPropertyName("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonPropertyName("damage_dealt")]
        public double DamageDealt { get; set; }

        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        [JsonPropertyName("mobs_killed")]
        public int MobsKilled { get; set; }

        [JsonPropertyName("secrets_found")]
        public int SecretsFound { get; set; }

        [JsonPropertyName("damage_mitigated")]
        public double DamageMitigated { get; set; }

        [JsonPropertyName("ally_healing")]
        public double AllyHealing { get; set; }
    }

    public class WatcherKills
    {
        [JsonPropertyName("0")]
        public int _0 { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }

    public class Catacombs
    {
        [JsonPropertyName("times_played")]
        public TimesPlayed TimesPlayed { get; set; }

        [JsonPropertyName("experience")]
        public double Experience { get; set; }

        [JsonPropertyName("best_score")]
        public BestScore BestScore { get; set; }

        [JsonPropertyName("mobs_killed")]
        public MobsKilled MobsKilled { get; set; }

        [JsonPropertyName("most_mobs_killed")]
        public MostMobsKilled MostMobsKilled { get; set; }

        [JsonPropertyName("most_damage_tank")]
        public MostDamageTank MostDamageTank { get; set; }

        [JsonPropertyName("most_healing")]
        public MostHealing MostHealing { get; set; }

        [JsonPropertyName("most_damage_archer")]
        public MostDamageArcher MostDamageArcher { get; set; }

        [JsonPropertyName("most_damage_mage")]
        public MostDamageMage MostDamageMage { get; set; }

        [JsonPropertyName("most_damage_healer")]
        public MostDamageHealer MostDamageHealer { get; set; }

        [JsonPropertyName("tier_completions")]
        public TierCompletions TierCompletions { get; set; }

        [JsonPropertyName("milestone_completions")]
        public MilestoneCompletions MilestoneCompletions { get; set; }

        [JsonPropertyName("fastest_time")]
        public FastestTime FastestTime { get; set; }

        [JsonPropertyName("best_runs")]
        public BestRuns BestRuns { get; set; }

        [JsonPropertyName("watcher_kills")]
        public WatcherKills WatcherKills { get; set; }

        [JsonPropertyName("highest_tier_completed")]
        public int HighestTierCompleted { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("visited")]
        public bool Visited { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("highest_floor")]
        public string HighestFloor { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("bonuses")]
        public Bonuses Bonuses { get; set; }

        [JsonPropertyName("fastest_time_s")]
        public FastestTimeS FastestTimeS { get; set; }

        [JsonPropertyName("fastest_time_s_plus")]
        public FastestTimeSPlus FastestTimeSPlus { get; set; }

        [JsonPropertyName("most_damage_berserk")]
        public MostDamageBerserk MostDamageBerserk { get; set; }
    }

    public class MasterCatacombs
    {
        [JsonPropertyName("visited")]
        public bool Visited { get; set; }

        [JsonPropertyName("best_score")]
        public BestScore BestScore { get; set; }

        [JsonPropertyName("mobs_killed")]
        public MobsKilled MobsKilled { get; set; }

        [JsonPropertyName("most_mobs_killed")]
        public MostMobsKilled MostMobsKilled { get; set; }

        [JsonPropertyName("most_damage_tank")]
        public MostDamageTank MostDamageTank { get; set; }

        [JsonPropertyName("most_healing")]
        public MostHealing MostHealing { get; set; }

        [JsonPropertyName("most_damage_archer")]
        public MostDamageArcher MostDamageArcher { get; set; }

        [JsonPropertyName("most_damage_healer")]
        public MostDamageHealer MostDamageHealer { get; set; }

        [JsonPropertyName("tier_completions")]
        public TierCompletions TierCompletions { get; set; }

        [JsonPropertyName("milestone_completions")]
        public MilestoneCompletions MilestoneCompletions { get; set; }

        [JsonPropertyName("highest_tier_completed")]
        public int HighestTierCompleted { get; set; }

        [JsonPropertyName("fastest_time")]
        public FastestTime FastestTime { get; set; }

        [JsonPropertyName("fastest_time_s")]
        public FastestTimeS FastestTimeS { get; set; }

        [JsonPropertyName("best_runs")]
        public BestRuns BestRuns { get; set; }

        [JsonPropertyName("most_damage_mage")]
        public MostDamageMage MostDamageMage { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("highest_floor")]
        public string HighestFloor { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }
    }

    public class DungeonTypes
    {
        [JsonPropertyName("catacombs")]
        public Catacombs Catacombs { get; set; }

        [JsonPropertyName("master_catacombs")]
        public MasterCatacombs MasterCatacombs { get; set; }
    }

    public class Healer
    {
        [JsonPropertyName("experience")]
        public double Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class Mage
    {
        [JsonPropertyName("experience")]
        public double Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class Berserk
    {
        [JsonPropertyName("experience")]
        public double Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class Archer
    {
        [JsonPropertyName("experience")]
        public double Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class Tank
    {
        [JsonPropertyName("experience")]
        public double Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class PlayerClasses
    {
        [JsonPropertyName("healer")]
        public Healer Healer { get; set; }

        [JsonPropertyName("mage")]
        public Mage Mage { get; set; }

        [JsonPropertyName("berserk")]
        public Berserk Berserk { get; set; }

        [JsonPropertyName("archer")]
        public Archer Archer { get; set; }

        [JsonPropertyName("tank")]
        public Tank Tank { get; set; }
    }

    public class JournalEntries
    {
        [JsonPropertyName("karylles_diary")]
        public List<int> KaryllesDiary { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("pages_collected")]
        public int PagesCollected { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("the_study")]
        public List<int> TheStudy { get; set; }

        [JsonPropertyName("expedition_volume_1")]
        public List<int> ExpeditionVolume1 { get; set; }

        [JsonPropertyName("uncanny_remains")]
        public List<int> UncannyRemains { get; set; }

        [JsonPropertyName("expedition_volume_3")]
        public List<int> ExpeditionVolume3 { get; set; }

        [JsonPropertyName("expedition_volume_2")]
        public List<int> ExpeditionVolume2 { get; set; }

        [JsonPropertyName("grim_adversity")]
        public List<int> GrimAdversity { get; set; }

        [JsonPropertyName("the_walls")]
        public List<int> TheWalls { get; set; }

        [JsonPropertyName("expedition_volume_4")]
        public List<int> ExpeditionVolume4 { get; set; }

        [JsonPropertyName("the_eye")]
        public List<int> TheEye { get; set; }

        [JsonPropertyName("aftermath")]
        public List<int> Aftermath { get; set; }

        [JsonPropertyName("the_apprentice")]
        public List<int> TheApprentice { get; set; }

        [JsonPropertyName("the_follower")]
        public List<int> TheFollower { get; set; }

        [JsonPropertyName("the_apprentice_2")]
        public List<int> TheApprentice2 { get; set; }

        [JsonPropertyName("the_apprentice_3")]
        public List<int> TheApprentice3 { get; set; }

        [JsonPropertyName("the_follower_2")]
        public List<int> TheFollower2 { get; set; }

        [JsonPropertyName("necrons_magic_scroll")]
        public List<object> NecronsMagicScroll { get; set; }

        [JsonPropertyName("murderer")]
        public List<int> Murderer { get; set; }
    }

    public class DungeonJournal
    {
        [JsonPropertyName("journal_entries")]
        public JournalEntries JournalEntries { get; set; }
    }

    public class Dungeons
    {
        [JsonPropertyName("dungeon_types")]
        public DungeonTypes DungeonTypes { get; set; }

        [JsonPropertyName("player_classes")]
        public PlayerClasses PlayerClasses { get; set; }

        [JsonPropertyName("dungeon_journal")]
        public DungeonJournal DungeonJournal { get; set; }

        [JsonPropertyName("dungeons_blah_blah")]
        public List<string> DungeonsBlahBlah { get; set; }

        [JsonPropertyName("selected_dungeon_class")]
        public string SelectedDungeonClass { get; set; }

        [JsonPropertyName("dungeonsWeight")]
        public double DungeonsWeight { get; set; }

        [JsonPropertyName("catacombs")]
        public Catacombs Catacombs { get; set; }

        [JsonPropertyName("master_catacombs")]
        public MasterCatacombs MasterCatacombs { get; set; }

//        [JsonPropertyName("classes")]
//        public Classes Classes { get; set; }

        [JsonPropertyName("used_classes")]
        public bool UsedClasses { get; set; }

        [JsonPropertyName("selected_class")]
        public string SelectedClass { get; set; }

        [JsonPropertyName("secrets_found")]
        public int SecretsFound { get; set; }

        [JsonPropertyName("unlocked_collections")]
        public bool UnlockedCollections { get; set; }

        [JsonPropertyName("boss_collections")]
        public BossCollections BossCollections { get; set; }

        [JsonPropertyName("journals")]
        public Journals Journals { get; set; }
    }

    public class Griffin
    {
        [JsonPropertyName("burrows")]
        public List<object> Burrows { get; set; }
    }

    public class MedalsInv
    {
        [JsonPropertyName("bronze")]
        public int Bronze { get; set; }

        [JsonPropertyName("silver")]
        public int Silver { get; set; }

        [JsonPropertyName("gold")]
        public int Gold { get; set; }
    }

    public class Perks
    {
        [JsonPropertyName("double_drops")]
        public int DoubleDrops { get; set; }

        [JsonPropertyName("farming_level_cap")]
        public int FarmingLevelCap { get; set; }

        [JsonPropertyName("forbidden_blessing")]
        public int ForbiddenBlessing { get; set; }

        [JsonPropertyName("permanent_health")]
        public int PermanentHealth { get; set; }

        [JsonPropertyName("permanent_speed")]
        public int PermanentSpeed { get; set; }

        [JsonPropertyName("permanent_intelligence")]
        public int PermanentIntelligence { get; set; }

        [JsonPropertyName("permanent_defense")]
        public int PermanentDefense { get; set; }

        [JsonPropertyName("catacombs_boss_luck")]
        public int CatacombsBossLuck { get; set; }

        [JsonPropertyName("catacombs_health")]
        public int CatacombsHealth { get; set; }

        [JsonPropertyName("catacombs_intelligence")]
        public int CatacombsIntelligence { get; set; }

        [JsonPropertyName("catacombs_looting")]
        public int CatacombsLooting { get; set; }
    }

    public class _108219POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _108219SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _108219MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _108228NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _108231WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _108531WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _110129INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _111129NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _111210INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _111216INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _111222NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _111420SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _111429INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _11151NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _111711INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _11199NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _111912INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1111128INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _11263SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _112624INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1131029INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _11412INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114210INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _11436INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114513INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114531INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _11463SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114714INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1151212INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _117330INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13184NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13184INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _132531MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13263INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _135420INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _135924INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13624INKSACK3
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _144813WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class Jacob2
    {
        [JsonPropertyName("medals_inv")]
        public MedalsInv MedalsInv { get; set; }

        [JsonPropertyName("perks")]
        public Perks Perks { get; set; }

        [JsonPropertyName("talked")]
        public bool Talked { get; set; }
    }

    public class Pairings
    {
        [JsonPropertyName("last_claimed")]
        public long LastClaimed { get; set; }

        [JsonPropertyName("claims_0")]
        public int Claims0 { get; set; }

        [JsonPropertyName("best_score_0")]
        public int BestScore0 { get; set; }

        [JsonPropertyName("claims_1")]
        public int Claims1 { get; set; }

        [JsonPropertyName("best_score_1")]
        public int BestScore1 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("tiers")]
        public Tiers Tiers { get; set; }

        [JsonPropertyName("claims_2")]
        public int Claims2 { get; set; }

        [JsonPropertyName("best_score_2")]
        public int BestScore2 { get; set; }

        [JsonPropertyName("claims_3")]
        public int Claims3 { get; set; }

        [JsonPropertyName("best_score_3")]
        public int BestScore3 { get; set; }

        [JsonPropertyName("claims_4")]
        public int Claims4 { get; set; }

        [JsonPropertyName("best_score_4")]
        public int BestScore4 { get; set; }

        [JsonPropertyName("last_attempt")]
        public int LastAttempt { get; set; }

        [JsonPropertyName("claims_5")]
        public int Claims5 { get; set; }

        [JsonPropertyName("best_score_5")]
        public int BestScore5 { get; set; }
    }

    public class Simon
    {
        [JsonPropertyName("last_attempt")]
        public long LastAttempt { get; set; }

        [JsonPropertyName("attempts_0")]
        public int Attempts0 { get; set; }

        [JsonPropertyName("bonus_clicks")]
        public int BonusClicks { get; set; }

        [JsonPropertyName("last_claimed")]
        public long LastClaimed { get; set; }

        [JsonPropertyName("claims_0")]
        public int Claims0 { get; set; }

        [JsonPropertyName("best_score_0")]
        public int BestScore0 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("tiers")]
        public Tiers Tiers { get; set; }

        [JsonPropertyName("attempts_1")]
        public int Attempts1 { get; set; }

        [JsonPropertyName("claims_1")]
        public int Claims1 { get; set; }

        [JsonPropertyName("best_score_1")]
        public int BestScore1 { get; set; }

        [JsonPropertyName("attempts_2")]
        public int Attempts2 { get; set; }

        [JsonPropertyName("claims_2")]
        public int Claims2 { get; set; }

        [JsonPropertyName("best_score_2")]
        public int BestScore2 { get; set; }

        [JsonPropertyName("attempts_3")]
        public int Attempts3 { get; set; }

        [JsonPropertyName("claims_3")]
        public int Claims3 { get; set; }

        [JsonPropertyName("best_score_3")]
        public int BestScore3 { get; set; }

        [JsonPropertyName("attempts_5")]
        public int Attempts5 { get; set; }

        [JsonPropertyName("claims_5")]
        public int Claims5 { get; set; }

        [JsonPropertyName("best_score_5")]
        public int BestScore5 { get; set; }
    }

    public class Numbers
    {
        [JsonPropertyName("last_attempt")]
        public long LastAttempt { get; set; }

        [JsonPropertyName("attempts_1")]
        public int Attempts1 { get; set; }

        [JsonPropertyName("bonus_clicks")]
        public int BonusClicks { get; set; }

        [JsonPropertyName("last_claimed")]
        public long LastClaimed { get; set; }

        [JsonPropertyName("claims_1")]
        public int Claims1 { get; set; }

        [JsonPropertyName("best_score_1")]
        public int BestScore1 { get; set; }

        [JsonPropertyName("attempts_2")]
        public int Attempts2 { get; set; }

        [JsonPropertyName("claims_2")]
        public int Claims2 { get; set; }

        [JsonPropertyName("best_score_2")]
        public int BestScore2 { get; set; }

        [JsonPropertyName("attempts_3")]
        public int Attempts3 { get; set; }

        [JsonPropertyName("claims_3")]
        public int Claims3 { get; set; }

        [JsonPropertyName("best_score_3")]
        public int BestScore3 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("tiers")]
        public Tiers Tiers { get; set; }
    }

    public class Experimentation
    {
        [JsonPropertyName("pairings")]
        public Pairings Pairings { get; set; }

        [JsonPropertyName("simon")]
        public Simon Simon { get; set; }

        [JsonPropertyName("numbers")]
        public Numbers Numbers { get; set; }

        [JsonPropertyName("claims_resets")]
        public int ClaimsResets { get; set; }

        [JsonPropertyName("claims_resets_timestamp")]
        public long ClaimsResetsTimestamp { get; set; }
    }

    public class TempStatBuff
    {
        [JsonPropertyName("stat")]
        public int Stat { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("expire_at")]
        public object ExpireAt { get; set; }
    }

    public class Nodes
    {
        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("titanium_insanium")]
        public int TitaniumInsanium { get; set; }

        [JsonPropertyName("mining_speed_boost")]
        public int MiningSpeedBoost { get; set; }

        [JsonPropertyName("random_event")]
        public int RandomEvent { get; set; }

        [JsonPropertyName("mining_madness")]
        public int MiningMadness { get; set; }

        [JsonPropertyName("mining_experience")]
        public int MiningExperience { get; set; }

        [JsonPropertyName("special_0")]
        public int Special0 { get; set; }

        [JsonPropertyName("efficient_miner")]
        public int EfficientMiner { get; set; }

        [JsonPropertyName("goblin_killer")]
        public int GoblinKiller { get; set; }

        [JsonPropertyName("daily_effect")]
        public int DailyEffect { get; set; }

        [JsonPropertyName("toggle_mining_speed")]
        public bool ToggleMiningSpeed { get; set; }

        [JsonPropertyName("toggle_efficient_miner")]
        public bool ToggleEfficientMiner { get; set; }

        [JsonPropertyName("mole")]
        public int Mole { get; set; }

        [JsonPropertyName("lonesome_miner")]
        public int LonesomeMiner { get; set; }

        [JsonPropertyName("professional")]
        public int Professional { get; set; }
    }

    public class MiningCore
    {
        [JsonPropertyName("nodes")]
        public Nodes Nodes { get; set; }

        [JsonPropertyName("received_free_tier")]
        public bool ReceivedFreeTier { get; set; }

        [JsonPropertyName("tokens")]
        public int Tokens { get; set; }

        [JsonPropertyName("tokens_spent")]
        public int TokensSpent { get; set; }

        [JsonPropertyName("powder_mithril")]
        public int PowderMithril { get; set; }

        [JsonPropertyName("powder_mithril_total")]
        public int PowderMithrilTotal { get; set; }

        [JsonPropertyName("powder_spent_mithril")]
        public int PowderSpentMithril { get; set; }

        [JsonPropertyName("experience")]
        public int Experience { get; set; }

        [JsonPropertyName("retroactive_tier2_token")]
        public bool RetroactiveTier2Token { get; set; }

        [JsonPropertyName("selected_pickaxe_ability")]
        public string SelectedPickaxeAbility { get; set; }

        [JsonPropertyName("current_daily_effect")]
        public string CurrentDailyEffect { get; set; }

        [JsonPropertyName("current_daily_effect_last_changed")]
        public int CurrentDailyEffectLastChanged { get; set; }

        [JsonPropertyName("greater_mines_last_access")]
        public long GreaterMinesLastAccess { get; set; }

        [JsonPropertyName("crystals")]
        public Crystals Crystals { get; set; }

        [JsonPropertyName("biomes")]
        public Biomes Biomes { get; set; }

        [JsonPropertyName("powder_gemstone")]
        public int PowderGemstone { get; set; }

        [JsonPropertyName("powder_gemstone_total")]
        public int PowderGemstoneTotal { get; set; }

        [JsonPropertyName("powder_spent_gemstone")]
        public int PowderSpentGemstone { get; set; }
    }

    public class ForgeProcesses
    {
        [JsonPropertyName("forge_1")]
        public Forge1 Forge1 { get; set; }
    }

    public class Forge
    {
        [JsonPropertyName("forge_processes")]
        public ForgeProcesses ForgeProcesses { get; set; }

        [JsonPropertyName("processes")]
        public List<object> Processes { get; set; }
    }

    public class Quiver
    {
        [JsonPropertyName("type")]
        public object Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class SacksCounts
    {
        [JsonPropertyName("SEEDS")]
        public int SEEDS { get; set; }

        [JsonPropertyName("WHEAT")]
        public int WHEAT { get; set; }

        [JsonPropertyName("POTATO_ITEM")]
        public int POTATOITEM { get; set; }

        [JsonPropertyName("CARROT_ITEM")]
        public int CARROTITEM { get; set; }

        [JsonPropertyName("BROWN_MUSHROOM")]
        public int BROWNMUSHROOM { get; set; }

        [JsonPropertyName("RED_MUSHROOM")]
        public int REDMUSHROOM { get; set; }

        [JsonPropertyName("ROTTEN_FLESH")]
        public int ROTTENFLESH { get; set; }

        [JsonPropertyName("BONE")]
        public int BONE { get; set; }

        [JsonPropertyName("STRING")]
        public int STRING { get; set; }

        [JsonPropertyName("SPIDER_EYE")]
        public int SPIDEREYE { get; set; }

        [JsonPropertyName("MAGMA_CREAM")]
        public int MAGMACREAM { get; set; }

        [JsonPropertyName("LOG_2:1")]
        public int LOG21 { get; set; }

        [JsonPropertyName("LOG")]
        public int LOG { get; set; }

        [JsonPropertyName("LOG:2")]
        public int LOG2 { get; set; }

        [JsonPropertyName("IRON_INGOT")]
        public int IRONINGOT { get; set; }

        [JsonPropertyName("INK_SACK:4")]
        public int INKSACK4 { get; set; }

        [JsonPropertyName("QUARTZ")]
        public int QUARTZ { get; set; }

        [JsonPropertyName("COBBLESTONE")]
        public int COBBLESTONE { get; set; }

        [JsonPropertyName("REDSTONE")]
        public int REDSTONE { get; set; }

        [JsonPropertyName("COAL")]
        public int COAL { get; set; }

        [JsonPropertyName("PUMPKIN")]
        public int PUMPKIN { get; set; }

        [JsonPropertyName("SUGAR_CANE")]
        public int SUGARCANE { get; set; }

        [JsonPropertyName("MELON")]
        public int MELON { get; set; }

        [JsonPropertyName("MUSHROOM_COLLECTION")]
        public int MUSHROOMCOLLECTION { get; set; }

        [JsonPropertyName("INK_SACK:3")]
        public int INKSACK3 { get; set; }

        [JsonPropertyName("CACTUS")]
        public int CACTUS { get; set; }

        [JsonPropertyName("NETHER_STALK")]
        public int NETHERSTALK { get; set; }

        [JsonPropertyName("DIAMOND")]
        public int DIAMOND { get; set; }

        [JsonPropertyName("EMERALD")]
        public int EMERALD { get; set; }

        [JsonPropertyName("PRISMARINE_CRYSTALS")]
        public int PRISMARINECRYSTALS { get; set; }

        [JsonPropertyName("PRISMARINE_SHARD")]
        public int PRISMARINESHARD { get; set; }

        [JsonPropertyName("RAW_FISH:2")]
        public int RAWFISH2 { get; set; }

        [JsonPropertyName("RAW_FISH:3")]
        public int RAWFISH3 { get; set; }

        [JsonPropertyName("RAW_FISH:1")]
        public int RAWFISH1 { get; set; }

        [JsonPropertyName("SPONGE")]
        public int SPONGE { get; set; }

        [JsonPropertyName("RAW_FISH")]
        public int RAWFISH { get; set; }

        [JsonPropertyName("LOG:1")]
        public int LOG1 { get; set; }

        [JsonPropertyName("LOG_2")]
        public int LOG_2 { get; set; }

        [JsonPropertyName("LOG:3")]
        public int LOG3 { get; set; }

        [JsonPropertyName("SAND")]
        public int SAND { get; set; }

        [JsonPropertyName("BLAZE_ROD")]
        public int BLAZEROD { get; set; }

        [JsonPropertyName("GHAST_TEAR")]
        public int GHASTTEAR { get; set; }

        [JsonPropertyName("RABBIT")]
        public int RABBIT { get; set; }

        [JsonPropertyName("SLIME_BALL")]
        public int SLIMEBALL { get; set; }

        [JsonPropertyName("NETHERRACK")]
        public int NETHERRACK { get; set; }

        [JsonPropertyName("WATER_LILY")]
        public int WATERLILY { get; set; }

        [JsonPropertyName("ICE")]
        public int ICE { get; set; }

        [JsonPropertyName("LEATHER")]
        public int LEATHER { get; set; }

        [JsonPropertyName("FEATHER")]
        public int FEATHER { get; set; }

        [JsonPropertyName("RAW_CHICKEN")]
        public int RAWCHICKEN { get; set; }

        [JsonPropertyName("ENDER_PEARL")]
        public int ENDERPEARL { get; set; }

        [JsonPropertyName("OBSIDIAN")]
        public int OBSIDIAN { get; set; }

        [JsonPropertyName("GOLD_INGOT")]
        public int GOLDINGOT { get; set; }

        [JsonPropertyName("INK_SACK")]
        public int INKSACK { get; set; }

        [JsonPropertyName("CLAY_BALL")]
        public int CLAYBALL { get; set; }

        [JsonPropertyName("SULPHUR")]
        public int SULPHUR { get; set; }

        [JsonPropertyName("GLOWSTONE_DUST")]
        public int GLOWSTONEDUST { get; set; }

        [JsonPropertyName("MUTTON")]
        public int MUTTON { get; set; }

        [JsonPropertyName("GRAVEL")]
        public int GRAVEL { get; set; }

        [JsonPropertyName("REVENANT_FLESH")]
        public int REVENANTFLESH { get; set; }

        [JsonPropertyName("WOLF_TOOTH")]
        public int WOLFTOOTH { get; set; }

        [JsonPropertyName("TARANTULA_WEB")]
        public int TARANTULAWEB { get; set; }

        [JsonPropertyName("PORK")]
        public int PORK { get; set; }

        [JsonPropertyName("ENDER_STONE")]
        public int ENDERSTONE { get; set; }

        [JsonPropertyName("GREEN_CANDY")]
        public int GREENCANDY { get; set; }

        [JsonPropertyName("PURPLE_CANDY")]
        public int PURPLECANDY { get; set; }

        [JsonPropertyName("MITHRIL_ORE")]
        public int MITHRILORE { get; set; }

        [JsonPropertyName("STARFALL")]
        public int STARFALL { get; set; }

        [JsonPropertyName("TITANIUM_ORE")]
        public int TITANIUMORE { get; set; }

        [JsonPropertyName("TREASURITE")]
        public int TREASURITE { get; set; }

        [JsonPropertyName("RABBIT_FOOT")]
        public int RABBITFOOT { get; set; }

        [JsonPropertyName("RAW_BEEF")]
        public int RAWBEEF { get; set; }

        [JsonPropertyName("RABBIT_HIDE")]
        public int RABBITHIDE { get; set; }

        [JsonPropertyName("RUNE_SPARKLING_1")]
        public int RUNESPARKLING1 { get; set; }

        [JsonPropertyName("RUNE_BLOOD_2_1")]
        public int RUNEBLOOD21 { get; set; }

        [JsonPropertyName("RUNE_HOT_1")]
        public int RUNEHOT1 { get; set; }

        [JsonPropertyName("RUNE_SNOW_1")]
        public int RUNESNOW1 { get; set; }

        [JsonPropertyName("RUNE_LAVA_1")]
        public int RUNELAVA1 { get; set; }

        [JsonPropertyName("RUNE_WAKE_1")]
        public int RUNEWAKE1 { get; set; }

        [JsonPropertyName("RUNE_ICE_3")]
        public int RUNEICE3 { get; set; }

        [JsonPropertyName("RUNE_ICE_1")]
        public int RUNEICE1 { get; set; }

        [JsonPropertyName("RUNE_GEM_1")]
        public int RUNEGEM1 { get; set; }

        [JsonPropertyName("RUNE_WHITE_SPIRAL_2")]
        public int RUNEWHITESPIRAL2 { get; set; }

        [JsonPropertyName("RUNE_WHITE_SPIRAL_1")]
        public int RUNEWHITESPIRAL1 { get; set; }

        [JsonPropertyName("RUNE_SNOW_3")]
        public int RUNESNOW3 { get; set; }

        [JsonPropertyName("RUNE_HEARTS_1")]
        public int RUNEHEARTS1 { get; set; }

        [JsonPropertyName("RUNE_HEARTS_2")]
        public int RUNEHEARTS2 { get; set; }

        [JsonPropertyName("RUNE_ZOMBIE_SLAYER_1")]
        public int RUNEZOMBIESLAYER1 { get; set; }

        [JsonPropertyName("RUNE_HEARTS_3")]
        public int RUNEHEARTS3 { get; set; }

        [JsonPropertyName("RUNE_GEM_3")]
        public int RUNEGEM3 { get; set; }

        [JsonPropertyName("RUNE_ICE_2")]
        public int RUNEICE2 { get; set; }

        [JsonPropertyName("RUNE_GEM_2")]
        public int RUNEGEM2 { get; set; }

        [JsonPropertyName("RUNE_CLOUDS_1")]
        public int RUNECLOUDS1 { get; set; }

        [JsonPropertyName("RUNE_MAGIC_1")]
        public int RUNEMAGIC1 { get; set; }

        [JsonPropertyName("RUNE_MAGIC_3")]
        public int RUNEMAGIC3 { get; set; }

        [JsonPropertyName("RUNE_SNOW_2")]
        public int RUNESNOW2 { get; set; }

        [JsonPropertyName("RUNE_ZAP_1")]
        public int RUNEZAP1 { get; set; }

        [JsonPropertyName("RUNE_ZAP_2")]
        public int RUNEZAP2 { get; set; }

        [JsonPropertyName("RUNE_SPIRIT_1")]
        public int RUNESPIRIT1 { get; set; }

        [JsonPropertyName("RUNE_BLOOD_2_2")]
        public int RUNEBLOOD22 { get; set; }

        [JsonPropertyName("RUNE_BLOOD_2_3")]
        public int RUNEBLOOD23 { get; set; }

        [JsonPropertyName("RUNE_LAVA_3")]
        public int RUNELAVA3 { get; set; }

        [JsonPropertyName("RUNE_SMOKEY_2")]
        public int RUNESMOKEY2 { get; set; }

        [JsonPropertyName("RUNE_WHITE_SPIRAL_3")]
        public int RUNEWHITESPIRAL3 { get; set; }

        [JsonPropertyName("RUNE_SPARKLING_2")]
        public int RUNESPARKLING2 { get; set; }

        [JsonPropertyName("RUNE_BITE_1")]
        public int RUNEBITE1 { get; set; }

        [JsonPropertyName("RUNE_HOT_3")]
        public int RUNEHOT3 { get; set; }

        [JsonPropertyName("RUNE_HOT_2")]
        public int RUNEHOT2 { get; set; }

        [JsonPropertyName("RUNE_LAVA_2")]
        public int RUNELAVA2 { get; set; }

        [JsonPropertyName("RUNE_SPARKLING_3")]
        public int RUNESPARKLING3 { get; set; }

        [JsonPropertyName("RUNE_FIRE_SPIRAL_1")]
        public int RUNEFIRESPIRAL1 { get; set; }

        [JsonPropertyName("RUNE_FIRE_SPIRAL_2")]
        public int RUNEFIRESPIRAL2 { get; set; }

        [JsonPropertyName("RUNE_REDSTONE_1")]
        public int RUNEREDSTONE1 { get; set; }

        [JsonPropertyName("RUNE_SNAKE_1")]
        public int RUNESNAKE1 { get; set; }

        [JsonPropertyName("RUNE_GOLDEN_1")]
        public int RUNEGOLDEN1 { get; set; }

        [JsonPropertyName("RUNE_GOLDEN_2")]
        public int RUNEGOLDEN2 { get; set; }

        [JsonPropertyName("RUNE_MUSIC_1")]
        public int RUNEMUSIC1 { get; set; }

        [JsonPropertyName("RUNE_LIGHTNING_1")]
        public int RUNELIGHTNING1 { get; set; }

        [JsonPropertyName("RUNE_RAINBOW_1")]
        public int RUNERAINBOW1 { get; set; }

        [JsonPropertyName("ECTOPLASM")]
        public int ECTOPLASM { get; set; }

        [JsonPropertyName("PUMPKIN_GUTS")]
        public int PUMPKINGUTS { get; set; }

        [JsonPropertyName("WEREWOLF_SKIN")]
        public int WEREWOLFSKIN { get; set; }

        [JsonPropertyName("NULL_SPHERE")]
        public int NULLSPHERE { get; set; }

        [JsonPropertyName("HARD_STONE")]
        public int HARDSTONE { get; set; }

        [JsonPropertyName("ROUGH_SAPPHIRE_GEM")]
        public int ROUGHSAPPHIREGEM { get; set; }

        [JsonPropertyName("FLAWED_SAPPHIRE_GEM")]
        public int FLAWEDSAPPHIREGEM { get; set; }

        [JsonPropertyName("ROUGH_RUBY_GEM")]
        public int ROUGHRUBYGEM { get; set; }

        [JsonPropertyName("ROUGH_JADE_GEM")]
        public int ROUGHJADEGEM { get; set; }

        [JsonPropertyName("FLAWED_JADE_GEM")]
        public int FLAWEDJADEGEM { get; set; }

        [JsonPropertyName("ROUGH_TOPAZ_GEM")]
        public int ROUGHTOPAZGEM { get; set; }

        [JsonPropertyName("FLAWED_AMBER_GEM")]
        public int FLAWEDAMBERGEM { get; set; }

        [JsonPropertyName("FLAWED_TOPAZ_GEM")]
        public int FLAWEDTOPAZGEM { get; set; }

        [JsonPropertyName("ROUGH_AMBER_GEM")]
        public int ROUGHAMBERGEM { get; set; }

        [JsonPropertyName("ROUGH_AMETHYST_GEM")]
        public int ROUGHAMETHYSTGEM { get; set; }

        [JsonPropertyName("FLAWED_AMETHYST_GEM")]
        public int FLAWEDAMETHYSTGEM { get; set; }

        [JsonPropertyName("FINE_AMETHYST_GEM")]
        public int FINEAMETHYSTGEM { get; set; }

        [JsonPropertyName("FLAWLESS_AMETHYST_GEM")]
        public int FLAWLESSAMETHYSTGEM { get; set; }

        [JsonPropertyName("PERFECT_AMETHYST_GEM")]
        public int PERFECTAMETHYSTGEM { get; set; }

        [JsonPropertyName("FLAWED_RUBY_GEM")]
        public int FLAWEDRUBYGEM { get; set; }

        [JsonPropertyName("ROUGH_JASPER_GEM")]
        public int ROUGHJASPERGEM { get; set; }

        [JsonPropertyName("FLAWED_JASPER_GEM")]
        public int FLAWEDJASPERGEM { get; set; }

        [JsonPropertyName("FINE_JASPER_GEM")]
        public int FINEJASPERGEM { get; set; }

        [JsonPropertyName("FLAWLESS_JASPER_GEM")]
        public int FLAWLESSJASPERGEM { get; set; }

        [JsonPropertyName("PERFECT_JASPER_GEM")]
        public int PERFECTJASPERGEM { get; set; }

        [JsonPropertyName("FINE_JADE_GEM")]
        public int FINEJADEGEM { get; set; }

        [JsonPropertyName("FINE_RUBY_GEM")]
        public int FINERUBYGEM { get; set; }

        [JsonPropertyName("FLAWLESS_RUBY_GEM")]
        public int FLAWLESSRUBYGEM { get; set; }

        [JsonPropertyName("PERFECT_RUBY_GEM")]
        public int PERFECTRUBYGEM { get; set; }

        [JsonPropertyName("FINE_SAPPHIRE_GEM")]
        public int FINESAPPHIREGEM { get; set; }

        [JsonPropertyName("FLAWLESS_SAPPHIRE_GEM")]
        public int FLAWLESSSAPPHIREGEM { get; set; }

        [JsonPropertyName("PERFECT_SAPPHIRE_GEM")]
        public int PERFECTSAPPHIREGEM { get; set; }

        [JsonPropertyName("FINE_TOPAZ_GEM")]
        public int FINETOPAZGEM { get; set; }

        [JsonPropertyName("FLAWLESS_TOPAZ_GEM")]
        public int FLAWLESSTOPAZGEM { get; set; }

        [JsonPropertyName("PERFECT_TOPAZ_GEM")]
        public int PERFECTTOPAZGEM { get; set; }

        [JsonPropertyName("FINE_AMBER_GEM")]
        public int FINEAMBERGEM { get; set; }

        [JsonPropertyName("FLAWLESS_AMBER_GEM")]
        public int FLAWLESSAMBERGEM { get; set; }

        [JsonPropertyName("PERFECT_AMBER_GEM")]
        public int PERFECTAMBERGEM { get; set; }

        [JsonPropertyName("ENCHANTED_REDSTONE")]
        public int ENCHANTEDREDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_COAL")]
        public int ENCHANTEDCOAL { get; set; }

        [JsonPropertyName("ENCHANTED_IRON")]
        public int ENCHANTEDIRON { get; set; }

        [JsonPropertyName("ENCHANTED_HARD_STONE")]
        public int ENCHANTEDHARDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_GOLD")]
        public int ENCHANTEDGOLD { get; set; }

        [JsonPropertyName("ENCHANTED_COBBLESTONE")]
        public int ENCHANTEDCOBBLESTONE { get; set; }

        [JsonPropertyName("ENCHANTED_MITHRIL")]
        public int ENCHANTEDMITHRIL { get; set; }

        [JsonPropertyName("ENCHANTED_DIAMOND")]
        public int ENCHANTEDDIAMOND { get; set; }

        [JsonPropertyName("ENCHANTED_ICE")]
        public int ENCHANTEDICE { get; set; }

        [JsonPropertyName("ENCHANTED_EMERALD")]
        public int ENCHANTEDEMERALD { get; set; }

        [JsonPropertyName("ENCHANTED_QUARTZ")]
        public int ENCHANTEDQUARTZ { get; set; }

        [JsonPropertyName("ENCHANTED_LAPIS_LAZULI")]
        public int ENCHANTEDLAPISLAZULI { get; set; }

        [JsonPropertyName("ENCHANTED_FLINT")]
        public int ENCHANTEDFLINT { get; set; }

        [JsonPropertyName("ENCHANTED_OBSIDIAN")]
        public int ENCHANTEDOBSIDIAN { get; set; }

        [JsonPropertyName("ENCHANTED_ENDSTONE")]
        public int ENCHANTEDENDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_CARROT")]
        public int ENCHANTEDCARROT { get; set; }

        [JsonPropertyName("ENCHANTED_MELON")]
        public int ENCHANTEDMELON { get; set; }

        [JsonPropertyName("ENCHANTED_SUGAR")]
        public int ENCHANTEDSUGAR { get; set; }

        [JsonPropertyName("ENCHANTED_PUMPKIN")]
        public int ENCHANTEDPUMPKIN { get; set; }

        [JsonPropertyName("ENCHANTED_NETHER_STALK")]
        public int ENCHANTEDNETHERSTALK { get; set; }

        [JsonPropertyName("ENCHANTED_SEEDS")]
        public int ENCHANTEDSEEDS { get; set; }

        [JsonPropertyName("ENCHANTED_POTATO")]
        public int ENCHANTEDPOTATO { get; set; }

        [JsonPropertyName("ENCHANTED_TITANIUM")]
        public int ENCHANTEDTITANIUM { get; set; }

        [JsonPropertyName("FLAWLESS_JADE_GEM")]
        public int FLAWLESSJADEGEM { get; set; }

        [JsonPropertyName("PERFECT_JADE_GEM")]
        public int PERFECTJADEGEM { get; set; }

        [JsonPropertyName("PACKED_ICE")]
        public int PACKEDICE { get; set; }

        [JsonPropertyName("ICE_HUNK")]
        public int ICEHUNK { get; set; }
    }

    public class TalismanBag
    {
        [JsonPropertyName("type")]
        public object Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

//        [JsonPropertyName("stats")]
//        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class BackpackIcons
    {
        // removed
    }

    public class Collection
    {
        [JsonPropertyName("LOG")]
        public int LOG { get; set; }

        [JsonPropertyName("COAL")]
        public int COAL { get; set; }

        [JsonPropertyName("COBBLESTONE")]
        public int COBBLESTONE { get; set; }

        [JsonPropertyName("GOLD_INGOT")]
        public int GOLDINGOT { get; set; }

        [JsonPropertyName("IRON_INGOT")]
        public int IRONINGOT { get; set; }

        [JsonPropertyName("WHEAT")]
        public int WHEAT { get; set; }

        [JsonPropertyName("SEEDS")]
        public int SEEDS { get; set; }

        [JsonPropertyName("SULPHUR")]
        public int SULPHUR { get; set; }

        [JsonPropertyName("INK_SACK:4")]
        public int INKSACK4 { get; set; }

        [JsonPropertyName("ROTTEN_FLESH")]
        public int ROTTENFLESH { get; set; }

        [JsonPropertyName("POTATO_ITEM")]
        public int POTATOITEM { get; set; }

        [JsonPropertyName("REDSTONE")]
        public int REDSTONE { get; set; }

        [JsonPropertyName("EMERALD")]
        public int EMERALD { get; set; }

        [JsonPropertyName("SLIME_BALL")]
        public int SLIMEBALL { get; set; }

        [JsonPropertyName("DIAMOND")]
        public int DIAMOND { get; set; }

        [JsonPropertyName("BONE")]
        public int BONE { get; set; }

        [JsonPropertyName("NETHER_STALK")]
        public int NETHERSTALK { get; set; }

        [JsonPropertyName("LOG:3")]
        public int LOG3 { get; set; }

        [JsonPropertyName("CARROT_ITEM")]
        public int CARROTITEM { get; set; }

        [JsonPropertyName("SUGAR_CANE")]
        public int SUGARCANE { get; set; }

        [JsonPropertyName("MUSHROOM_COLLECTION")]
        public int MUSHROOMCOLLECTION { get; set; }

        [JsonPropertyName("STRING")]
        public int STRING { get; set; }

        [JsonPropertyName("IRON_BLOCK")]
        public int IRONBLOCK { get; set; }

        [JsonPropertyName("LOG:2")]
        public int LOG2 { get; set; }

        [JsonPropertyName("SPIDER_EYE")]
        public int SPIDEREYE { get; set; }

        [JsonPropertyName("QUARTZ")]
        public int QUARTZ { get; set; }

        [JsonPropertyName("NETHERRACK")]
        public int NETHERRACK { get; set; }

        [JsonPropertyName("MAGMA_CREAM")]
        public int MAGMACREAM { get; set; }

        [JsonPropertyName("GLOWSTONE_DUST")]
        public int GLOWSTONEDUST { get; set; }

        [JsonPropertyName("MUTTON")]
        public int MUTTON { get; set; }

        [JsonPropertyName("LOG_2:1")]
        public int LOG21 { get; set; }

        [JsonPropertyName("OBSIDIAN")]
        public int OBSIDIAN { get; set; }

        [JsonPropertyName("BLAZE_ROD")]
        public int BLAZEROD { get; set; }

        [JsonPropertyName("ENDER_STONE")]
        public int ENDERSTONE { get; set; }

        [JsonPropertyName("ENDER_PEARL")]
        public int ENDERPEARL { get; set; }

        [JsonPropertyName("GRAVEL")]
        public int GRAVEL { get; set; }

        [JsonPropertyName("PORK")]
        public int PORK { get; set; }

        [JsonPropertyName("CACTUS")]
        public int CACTUS { get; set; }

        [JsonPropertyName("INK_SACK:3")]
        public int INKSACK3 { get; set; }

        [JsonPropertyName("FEATHER")]
        public int FEATHER { get; set; }

        [JsonPropertyName("RAW_CHICKEN")]
        public int RAWCHICKEN { get; set; }

        [JsonPropertyName("SAND")]
        public int SAND { get; set; }

        [JsonPropertyName("MELON")]
        public int MELON { get; set; }

        [JsonPropertyName("ENCHANTED_ENDER_PEARL")]
        public int ENCHANTEDENDERPEARL { get; set; }

        [JsonPropertyName("MITHRIL_ORE")]
        public int MITHRILORE { get; set; }

        [JsonPropertyName("LEATHER")]
        public int LEATHER { get; set; }

        [JsonPropertyName("RABBIT")]
        public int RABBIT { get; set; }

        [JsonPropertyName("ENCHANTED_QUARTZ")]
        public int ENCHANTEDQUARTZ { get; set; }

        [JsonPropertyName("LOG:1")]
        public int LOG1 { get; set; }

        [JsonPropertyName("LOG_2")]
        public int LOG_2 { get; set; }

        [JsonPropertyName("ENCHANTED_SPRUCE_LOG")]
        public int ENCHANTEDSPRUCELOG { get; set; }

        [JsonPropertyName("ENCHANTED_DIAMOND")]
        public int ENCHANTEDDIAMOND { get; set; }

        [JsonPropertyName("ENCHANTED_GOLD")]
        public int ENCHANTEDGOLD { get; set; }

        [JsonPropertyName("PUMPKIN")]
        public int PUMPKIN { get; set; }

        [JsonPropertyName("RAW_FISH:3")]
        public int RAWFISH3 { get; set; }

        [JsonPropertyName("RAW_FISH")]
        public int RAWFISH { get; set; }

        [JsonPropertyName("WATER_LILY")]
        public int WATERLILY { get; set; }

        [JsonPropertyName("CLAY_BALL")]
        public int CLAYBALL { get; set; }

        [JsonPropertyName("GHAST_TEAR")]
        public int GHASTTEAR { get; set; }

        [JsonPropertyName("RAW_FISH:2")]
        public int RAWFISH2 { get; set; }

        [JsonPropertyName("RAW_FISH:1")]
        public int RAWFISH1 { get; set; }

        [JsonPropertyName("INK_SACK")]
        public int INKSACK { get; set; }

        [JsonPropertyName("PRISMARINE_SHARD")]
        public int PRISMARINESHARD { get; set; }

        [JsonPropertyName("PRISMARINE_CRYSTALS")]
        public int PRISMARINECRYSTALS { get; set; }

        [JsonPropertyName("SPONGE")]
        public int SPONGE { get; set; }

        [JsonPropertyName("ICE")]
        public int ICE { get; set; }

        [JsonPropertyName("ENCHANTED_LAPIS_LAZULI")]
        public int ENCHANTEDLAPISLAZULI { get; set; }

        [JsonPropertyName("ENCHANTED_ROTTEN_FLESH")]
        public int ENCHANTEDROTTENFLESH { get; set; }

        [JsonPropertyName("ENCHANTED_GHAST_TEAR")]
        public int ENCHANTEDGHASTTEAR { get; set; }

        [JsonPropertyName("ENCHANTED_EGG")]
        public int ENCHANTEDEGG { get; set; }

        [JsonPropertyName("EGG")]
        public int EGG { get; set; }

        [JsonPropertyName("RAW_BEEF")]
        public int RAWBEEF { get; set; }

        [JsonPropertyName("ENCHANTED_SUGAR")]
        public int ENCHANTEDSUGAR { get; set; }

        [JsonPropertyName("ENCHANTED_MELON")]
        public int ENCHANTEDMELON { get; set; }

        [JsonPropertyName("ENCHANTED_STRING")]
        public int ENCHANTEDSTRING { get; set; }

        [JsonPropertyName("WOOL")]
        public int WOOL { get; set; }

        [JsonPropertyName("ENCHANTED_EMERALD")]
        public int ENCHANTEDEMERALD { get; set; }

        [JsonPropertyName("ENCHANTED_REDSTONE")]
        public int ENCHANTEDREDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_SNOW_BLOCK")]
        public int ENCHANTEDSNOWBLOCK { get; set; }

        [JsonPropertyName("SNOW_BALL")]
        public int SNOWBALL { get; set; }

        [JsonPropertyName("ENCHANTED_COAL")]
        public int ENCHANTEDCOAL { get; set; }

        [JsonPropertyName("ENCHANTED_CLAY_BALL")]
        public int ENCHANTEDCLAYBALL { get; set; }

        [JsonPropertyName("ENCHANTED_ACACIA_LOG")]
        public int ENCHANTEDACACIALOG { get; set; }

        [JsonPropertyName("ENCHANTED_MITHRIL")]
        public int ENCHANTEDMITHRIL { get; set; }

        [JsonPropertyName("ENCHANTED_RABBIT")]
        public int ENCHANTEDRABBIT { get; set; }

        [JsonPropertyName("RABBIT_HIDE")]
        public int RABBITHIDE { get; set; }

        [JsonPropertyName("RABBIT_FOOT")]
        public int RABBITFOOT { get; set; }

        [JsonPropertyName("ENCHANTED_GLOWSTONE_DUST")]
        public int ENCHANTEDGLOWSTONEDUST { get; set; }

        [JsonPropertyName("ENCHANTED_SAND")]
        public int ENCHANTEDSAND { get; set; }

        [JsonPropertyName("HARD_STONE")]
        public int HARDSTONE { get; set; }

        [JsonPropertyName("GEMSTONE_COLLECTION")]
        public int GEMSTONECOLLECTION { get; set; }

        [JsonPropertyName("DIAMOND_BLOCK")]
        public int DIAMONDBLOCK { get; set; }
    }

    public class EnderChestContents
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class WardrobeContents
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class PotionBag
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class PersonalVaultContents
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class InvContents
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class Raw
    {
        [JsonPropertyName("last_save")]
        public long LastSave { get; set; }

        [JsonPropertyName("inv_armor")]
        public InvArmor InvArmor { get; set; }

        [JsonPropertyName("coop_invitation")]
        public CoopInvitation CoopInvitation { get; set; }

        [JsonPropertyName("first_join")]
        public long FirstJoin { get; set; }

        [JsonPropertyName("first_join_hub")]
        public int FirstJoinHub { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

//        [JsonPropertyName("objectives")]
//        public Objectives Objectives { get; set; }

        [JsonPropertyName("tutorial")]
        public List<string> Tutorial { get; set; }

        [JsonPropertyName("quests")]
        public Quests Quests { get; set; }

        [JsonPropertyName("coin_purse")]
        public double CoinPurse { get; set; }

        [JsonPropertyName("last_death")]
        public int LastDeath { get; set; }

        [JsonPropertyName("crafted_generators")]
        public List<string> CraftedGenerators { get; set; }

        [JsonPropertyName("visited_zones")]
        public List<string> VisitedZones { get; set; }

        [JsonPropertyName("fairy_souls_collected")]
        public int FairySoulsCollected { get; set; }

        [JsonPropertyName("fairy_souls")]
        public int FairySouls { get; set; }

        [JsonPropertyName("fairy_exchanges")]
        public int FairyExchanges { get; set; }

        [JsonPropertyName("death_count")]
        public int DeathCount { get; set; }

        [JsonPropertyName("achievement_spawned_island_types")]
        public List<string> AchievementSpawnedIslandTypes { get; set; }

        [JsonPropertyName("slayer_bosses")]
        public SlayerBosses SlayerBosses { get; set; }

        [JsonPropertyName("pets")]
        public List<Pet> Pets { get; set; }

        [JsonPropertyName("dungeons")]
        public Dungeons Dungeons { get; set; }

        [JsonPropertyName("griffin")]
        public Griffin Griffin { get; set; }

        [JsonPropertyName("jacob2")]
        public Jacob2 Jacob2 { get; set; }

        [JsonPropertyName("experimentation")]
        public Experimentation Experimentation { get; set; }

        [JsonPropertyName("perks")]
        public Perks Perks { get; set; }

        [JsonPropertyName("active_effects")]
        public List<object> ActiveEffects { get; set; }

        [JsonPropertyName("visited_modes")]
        public List<string> VisitedModes { get; set; }

        [JsonPropertyName("temp_stat_buffs")]
        public List<TempStatBuff> TempStatBuffs { get; set; }

        [JsonPropertyName("mining_core")]
        public MiningCore MiningCore { get; set; }

        [JsonPropertyName("forge")]
        public Forge Forge { get; set; }

        [JsonPropertyName("experience_skill_runecrafting")]
        public double ExperienceSkillRunecrafting { get; set; }

        [JsonPropertyName("experience_skill_mining")]
        public double ExperienceSkillMining { get; set; }

        [JsonPropertyName("unlocked_coll_tiers")]
        public List<string> UnlockedCollTiers { get; set; }

        [JsonPropertyName("experience_skill_alchemy")]
        public double ExperienceSkillAlchemy { get; set; }

        [JsonPropertyName("quiver")]
        public Quiver Quiver { get; set; }

        [JsonPropertyName("experience_skill_taming")]
        public double ExperienceSkillTaming { get; set; }

        [JsonPropertyName("sacks_counts")]
        public SacksCounts SacksCounts { get; set; }

        [JsonPropertyName("essence_undead")]
        public int EssenceUndead { get; set; }

        [JsonPropertyName("talisman_bag")]
        public TalismanBag TalismanBag { get; set; }

        [JsonPropertyName("backpack_icons")]
        public BackpackIcons BackpackIcons { get; set; }

        [JsonPropertyName("experience_skill_combat")]
        public double ExperienceSkillCombat { get; set; }

        [JsonPropertyName("essence_diamond")]
        public int EssenceDiamond { get; set; }

        [JsonPropertyName("experience_skill_farming")]
        public double ExperienceSkillFarming { get; set; }

        [JsonPropertyName("wardrobe_equipped_slot")]
        public int WardrobeEquippedSlot { get; set; }

        [JsonPropertyName("collection")]
        public Collection Collection { get; set; }

        [JsonPropertyName("essence_dragon")]
        public int EssenceDragon { get; set; }

        [JsonPropertyName("ender_chest_contents")]
        public EnderChestContents EnderChestContents { get; set; }

        [JsonPropertyName("wardrobe_contents")]
        public WardrobeContents WardrobeContents { get; set; }

        [JsonPropertyName("potion_bag")]
        public PotionBag PotionBag { get; set; }

        [JsonPropertyName("experience_skill_enchanting")]
        public double ExperienceSkillEnchanting { get; set; }

        [JsonPropertyName("personal_vault_contents")]
        public PersonalVaultContents PersonalVaultContents { get; set; }

        [JsonPropertyName("inv_contents")]
        public InvContents InvContents { get; set; }

        [JsonPropertyName("essence_wither")]
        public int EssenceWither { get; set; }

        [JsonPropertyName("essence_spider")]
        public int EssenceSpider { get; set; }

        [JsonPropertyName("experience_skill_foraging")]
        public double ExperienceSkillForaging { get; set; }

        [JsonPropertyName("experience_skill_carpentry")]
        public double ExperienceSkillCarpentry { get; set; }

        [JsonPropertyName("fishing_treasure_caught")]
        public int FishingTreasureCaught { get; set; }

        [JsonPropertyName("harp_quest")]
        public HarpQuest HarpQuest { get; set; }

        [JsonPropertyName("paused_effects")]
        public List<object> PausedEffects { get; set; }

        [JsonPropertyName("disabled_potion_effects")]
        public List<string> DisabledPotionEffects { get; set; }

        [JsonPropertyName("backpack_contents")]
        public BackpackContents BackpackContents { get; set; }

        [JsonPropertyName("fishing_bag")]
        public FishingBag FishingBag { get; set; }

        [JsonPropertyName("essence_gold")]
        public int EssenceGold { get; set; }

        [JsonPropertyName("experience_skill_fishing")]
        public double ExperienceSkillFishing { get; set; }

        [JsonPropertyName("essence_ice")]
        public int EssenceIce { get; set; }

        [JsonPropertyName("candy_inventory_contents")]
        public CandyInventoryContents CandyInventoryContents { get; set; }

        [JsonPropertyName("current_area")]
        public string CurrentArea { get; set; }
    }

    public class Ench
    {
        [JsonPropertyName("lvl")]
        public int Lvl { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class Display
    {
        [JsonPropertyName("Lore")]
        public List<string> Lore { get; set; }

        [JsonPropertyName("color")]
        public int Color { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }

    public class Enchantments
    {
        [JsonPropertyName("depth_strider")]
        public int DepthStrider { get; set; }

        [JsonPropertyName("thorns")]
        public int Thorns { get; set; }

        [JsonPropertyName("feather_falling")]
        public int FeatherFalling { get; set; }

        [JsonPropertyName("protection")]
        public int Protection { get; set; }

        [JsonPropertyName("growth")]
        public int Growth { get; set; }

        [JsonPropertyName("fire_protection")]
        public int FireProtection { get; set; }

        [JsonPropertyName("syphon")]
        public int Syphon { get; set; }

        [JsonPropertyName("sharpness")]
        public int Sharpness { get; set; }

        [JsonPropertyName("telekinesis")]
        public int Telekinesis { get; set; }

        [JsonPropertyName("vampirism")]
        public int Vampirism { get; set; }

        [JsonPropertyName("chance")]
        public int? Chance { get; set; }

        [JsonPropertyName("piercing")]
        public int? Piercing { get; set; }

        [JsonPropertyName("infinite_quiver")]
        public int? InfiniteQuiver { get; set; }

        [JsonPropertyName("power")]
        public int? Power { get; set; }

        [JsonPropertyName("aiming")]
        public int? Aiming { get; set; }

        [JsonPropertyName("efficiency")]
        public int Efficiency { get; set; }

        [JsonPropertyName("luck")]
        public int? Luck { get; set; }

        [JsonPropertyName("first_strike")]
        public int? FirstStrike { get; set; }

        [JsonPropertyName("looting")]
        public int? Looting { get; set; }

        [JsonPropertyName("scavenger")]
        public int? Scavenger { get; set; }

        [JsonPropertyName("experience")]
        public int? Experience { get; set; }

        [JsonPropertyName("life_steal")]
        public int? LifeSteal { get; set; }

        [JsonPropertyName("critical")]
        public int? Critical { get; set; }

        [JsonPropertyName("ender_slayer")]
        public int? EnderSlayer { get; set; }

        [JsonPropertyName("execute")]
        public int? Execute { get; set; }

        [JsonPropertyName("giant_killer")]
        public int? GiantKiller { get; set; }

        [JsonPropertyName("fortune")]
        public int? Fortune { get; set; }

        [JsonPropertyName("harvesting")]
        public int Harvesting { get; set; }

        [JsonPropertyName("smelting_touch")]
        public int? SmeltingTouch { get; set; }

        [JsonPropertyName("respiration")]
        public int? Respiration { get; set; }

        [JsonPropertyName("aqua_affinity")]
        public int? AquaAffinity { get; set; }

        [JsonPropertyName("true_protection")]
        public int? TrueProtection { get; set; }

        [JsonPropertyName("rejuvenate")]
        public int? Rejuvenate { get; set; }

        [JsonPropertyName("sugar_rush")]
        public int? SugarRush { get; set; }

        [JsonPropertyName("impaling")]
        public int Impaling { get; set; }

        [JsonPropertyName("cleave")]
        public int Cleave { get; set; }

        [JsonPropertyName("thunderbolt")]
        public int Thunderbolt { get; set; }

        [JsonPropertyName("fire_aspect")]
        public int FireAspect { get; set; }

        [JsonPropertyName("venomous")]
        public int Venomous { get; set; }

        [JsonPropertyName("cubism")]
        public int Cubism { get; set; }

        [JsonPropertyName("PROSECUTE")]
        public int PROSECUTE { get; set; }

        [JsonPropertyName("lethality")]
        public int Lethality { get; set; }

        [JsonPropertyName("ultimate_one_for_all")]
        public int? UltimateOneForAll { get; set; }

        [JsonPropertyName("ultimate_wise")]
        public int? UltimateWise { get; set; }

        [JsonPropertyName("snipe")]
        public int? Snipe { get; set; }

        [JsonPropertyName("flame")]
        public int? Flame { get; set; }

        [JsonPropertyName("overload")]
        public int? Overload { get; set; }

        [JsonPropertyName("punch")]
        public int? Punch { get; set; }

        [JsonPropertyName("frail")]
        public int? Frail { get; set; }

        [JsonPropertyName("expertise")]
        public int? Expertise { get; set; }

        [JsonPropertyName("magnet")]
        public int? Magnet { get; set; }

        [JsonPropertyName("luck_of_the_sea")]
        public int? LuckOfTheSea { get; set; }

        [JsonPropertyName("lure")]
        public int? Lure { get; set; }

        [JsonPropertyName("caster")]
        public int? Caster { get; set; }

        [JsonPropertyName("spiked_hook")]
        public int? SpikedHook { get; set; }

        [JsonPropertyName("angler")]
        public int? Angler { get; set; }

        [JsonPropertyName("blessing")]
        public int? Blessing { get; set; }

        [JsonPropertyName("silk_touch")]
        public int? SilkTouch { get; set; }

        [JsonPropertyName("compact")]
        public int? Compact { get; set; }

        [JsonPropertyName("ultimate_jerry")]
        public int? UltimateJerry { get; set; }

        [JsonPropertyName("thunderlord")]
        public int? Thunderlord { get; set; }

        [JsonPropertyName("titan_killer")]
        public int? TitanKiller { get; set; }

        [JsonPropertyName("pristine")]
        public int? Pristine { get; set; }

        [JsonPropertyName("ultimate_bank")]
        public int? UltimateBank { get; set; }

        [JsonPropertyName("ultimate_combo")]
        public int? UltimateCombo { get; set; }

        [JsonPropertyName("cultivating")]
        public int? Cultivating { get; set; }

        [JsonPropertyName("turbo_wheat")]
        public int? TurboWheat { get; set; }

        [JsonPropertyName("replenish")]
        public int? Replenish { get; set; }

        [JsonPropertyName("turbo_cane")]
        public int? TurboCane { get; set; }

        [JsonPropertyName("turbo_pumpkin")]
        public int? TurboPumpkin { get; set; }

        [JsonPropertyName("turbo_warts")]
        public int? TurboWarts { get; set; }

        [JsonPropertyName("turbo_melon")]
        public int? TurboMelon { get; set; }

        [JsonPropertyName("turbo_carrot")]
        public int? TurboCarrot { get; set; }

        [JsonPropertyName("turbo_potato")]
        public int? TurboPotato { get; set; }

        [JsonPropertyName("knockback")]
        public int? Knockback { get; set; }

        [JsonPropertyName("smite")]
        public int? Smite { get; set; }

        [JsonPropertyName("dragon_hunter")]
        public int? DragonHunter { get; set; }
    }

    public class ExtraAttributes
    {
        [JsonPropertyName("dungeon_skill_req")]
        public string DungeonSkillReq { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("baseStatBoostPercentage")]
        public int BaseStatBoostPercentage { get; set; }

        [JsonPropertyName("modifier")]
        public string Modifier { get; set; }

        [JsonPropertyName("originTag")]
        public string OriginTag { get; set; }

        [JsonPropertyName("item_durability")]
        public int ItemDurability { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("enchantments")]
        public Enchantments Enchantments { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("item_tier")]
        public int ItemTier { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("leaderVotes")]
        public int? LeaderVotes { get; set; }

        [JsonPropertyName("leaderPosition")]
        public int? LeaderPosition { get; set; }

        [JsonPropertyName("personal_compact_0")]
        public string PersonalCompact0 { get; set; }

        [JsonPropertyName("blocksBroken")]
        public int? BlocksBroken { get; set; }

        [JsonPropertyName("potion_level")]
        public int PotionLevel { get; set; }

        [JsonPropertyName("enhanced")]
        public int Enhanced { get; set; }

        [JsonPropertyName("potion")]
        public string Potion { get; set; }

        [JsonPropertyName("effects")]
        public List<Effect> Effects { get; set; }

        [JsonPropertyName("potion_type")]
        public string PotionType { get; set; }

        [JsonPropertyName("extended")]
        public int Extended { get; set; }

        [JsonPropertyName("anvil_uses")]
        public int? AnvilUses { get; set; }

        [JsonPropertyName("zombie_kills")]
        public int ZombieKills { get; set; }

        [JsonPropertyName("gems")]
        public Gems Gems { get; set; }

        [JsonPropertyName("edition")]
        public int? Edition { get; set; }

        [JsonPropertyName("dungeon_item_level")]
        public int DungeonItemLevel { get; set; }

        [JsonPropertyName("hot_potato_count")]
        public int? HotPotatoCount { get; set; }

        [JsonPropertyName("hotPotatoBonus")]
        public string HotPotatoBonus { get; set; }

        [JsonPropertyName("tuned_transmission")]
        public int? TunedTransmission { get; set; }

        [JsonPropertyName("maxed_stats")]
        public int? MaxedStats { get; set; }

        [JsonPropertyName("trainingWeightsHeldTime")]
        public int? TrainingWeightsHeldTime { get; set; }

        [JsonPropertyName("ammo")]
        public int? Ammo { get; set; }

        [JsonPropertyName("power_ability_scroll")]
        public string PowerAbilityScroll { get; set; }

        [JsonPropertyName("expertise_kills")]
        public int? ExpertiseKills { get; set; }

        [JsonPropertyName("fishes_caught")]
        public int? FishesCaught { get; set; }

        [JsonPropertyName("compact_blocks")]
        public int? CompactBlocks { get; set; }

        [JsonPropertyName("talisman_enrichment")]
        public string TalismanEnrichment { get; set; }

        [JsonPropertyName("party_hat_year")]
        public int? PartyHatYear { get; set; }

        [JsonPropertyName("party_hat_color")]
        public string PartyHatColor { get; set; }

        [JsonPropertyName("blood_god_kills")]
        public int? BloodGodKills { get; set; }

        [JsonPropertyName("potion_name")]
        public string PotionName { get; set; }

        [JsonPropertyName("dungeon_potion")]
        public int? DungeonPotion { get; set; }

        [JsonPropertyName("backpack_color")]
        public string BackpackColor { get; set; }

        [JsonPropertyName("wood_singularity_count")]
        public int? WoodSingularityCount { get; set; }

        [JsonPropertyName("trapsDefused")]
        public int? TrapsDefused { get; set; }

        [JsonPropertyName("sword_kills")]
        public int? SwordKills { get; set; }

        [JsonPropertyName("wishing_compass_uses")]
        public int? WishingCompassUses { get; set; }

        [JsonPropertyName("pickonimbus_durability")]
        public int? PickonimbusDurability { get; set; }

        [JsonPropertyName("drill_part_upgrade_module")]
        public string DrillPartUpgradeModule { get; set; }

        [JsonPropertyName("drill_fuel")]
        public int? DrillFuel { get; set; }

        [JsonPropertyName("resources_generated")]
        public int? ResourcesGenerated { get; set; }

        [JsonPropertyName("generator_tier")]
        public int? GeneratorTier { get; set; }

        [JsonPropertyName("total_generations")]
        public int? TotalGenerations { get; set; }

        [JsonPropertyName("mithril_infusion")]
        public int? MithrilInfusion { get; set; }

        [JsonPropertyName("rarity_upgrades")]
        public int? RarityUpgrades { get; set; }

        [JsonPropertyName("entity_required")]
        public string EntityRequired { get; set; }

        [JsonPropertyName("leaderboard_score")]
        public int? LeaderboardScore { get; set; }

        [JsonPropertyName("leaderboard_player")]
        public string LeaderboardPlayer { get; set; }

        [JsonPropertyName("leaderboard_position")]
        public int? LeaderboardPosition { get; set; }

        [JsonPropertyName("new_years_cake")]
        public int? NewYearsCake { get; set; }

        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("farmed_cultivating")]
        public int? FarmedCultivating { get; set; }

        [JsonPropertyName("farming_for_dummies_count")]
        public int? FarmingForDummiesCount { get; set; }

        [JsonPropertyName("mined_crops")]
        public List<int> MinedCrops { get; set; }

        [JsonPropertyName("splash")]
        public int? Splash { get; set; }

        [JsonPropertyName("personal_compact_2")]
        public string PersonalCompact2 { get; set; }

        [JsonPropertyName("personal_compact_1")]
        public string PersonalCompact1 { get; set; }

        [JsonPropertyName("personal_compact_8")]
        public string PersonalCompact8 { get; set; }

        [JsonPropertyName("personal_compact_7")]
        public string PersonalCompact7 { get; set; }

        [JsonPropertyName("personal_compact_9")]
        public string PersonalCompact9 { get; set; }

        [JsonPropertyName("personal_compact_4")]
        public string PersonalCompact4 { get; set; }

        [JsonPropertyName("personal_compact_10")]
        public string PersonalCompact10 { get; set; }

        [JsonPropertyName("personal_compact_3")]
        public string PersonalCompact3 { get; set; }

        [JsonPropertyName("personal_compact_6")]
        public string PersonalCompact6 { get; set; }

        [JsonPropertyName("personal_compact_5")]
        public string PersonalCompact5 { get; set; }

        [JsonPropertyName("new_year_cake_bag_data")]
        public List<int> NewYearCakeBagData { get; set; }

        [JsonPropertyName("necromancer_souls")]
        public List<NecromancerSoul> NecromancerSouls { get; set; }

        [JsonPropertyName("raider_kills")]
        public int? RaiderKills { get; set; }
    }

    public class Tag
    {
        [JsonPropertyName("ench")]
        public List<Ench> Ench { get; set; }

        [JsonPropertyName("HideFlags")]
        public int HideFlags { get; set; }

        [JsonPropertyName("display")]
        public Display Display { get; set; }

        [JsonPropertyName("ExtraAttributes")]
        public ExtraAttributes ExtraAttributes { get; set; }

        [JsonPropertyName("Unbreakable")]
        public int? Unbreakable { get; set; }

        [JsonPropertyName("SkullOwner")]
        public SkullOwner SkullOwner { get; set; }

        [JsonPropertyName("CustomPotionEffects")]
        public List<CustomPotionEffect> CustomPotionEffects { get; set; }
    }

    public class Extra
    {
        [JsonPropertyName("hpbs")]
        public int Hpbs { get; set; }

        [JsonPropertyName("anvil_uses")]
        public int AnvilUses { get; set; }

        [JsonPropertyName("timestamp")]
        public object Timestamp { get; set; }

        [JsonPropertyName("base_stat_boost")]
        public int BaseStatBoost { get; set; }

        [JsonPropertyName("floor")]
        public int Floor { get; set; }

        [JsonPropertyName("reforge")]
        public string Reforge { get; set; }

        [JsonPropertyName("gems")]
        public Gems Gems { get; set; }

        [JsonPropertyName("expertise_kills")]
        public int? ExpertiseKills { get; set; }

        [JsonPropertyName("recombobulated")]
        public bool? Recombobulated { get; set; }

        [JsonPropertyName("crop_counter")]
        public List<int> CropCounter { get; set; }
    }

    public class Armor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("armor_name")]
        public string ArmorName { get; set; }
    }

    public class Texture
    {
        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public class Properties
    {
        [JsonPropertyName("textures")]
        public List<Texture> Textures { get; set; }
    }

    public class SkullOwner
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Properties")]
        public Properties Properties { get; set; }
    }

    public class WardrobeInventory
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }
    }

    public class Inventory
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("breaking_power")]
        public string BreakingPower { get; set; }
    }

    public class Enderchest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("breaking_power")]
        public string BreakingPower { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }
    }

    public class CustomPotionEffect
    {
        [JsonPropertyName("Ambient")]
        public int Ambient { get; set; }

        [JsonPropertyName("Duration")]
        public int Duration { get; set; }

        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Amplifier")]
        public int Amplifier { get; set; }
    }

    public class Modifiers
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("amp")]
        public int Amp { get; set; }

        [JsonPropertyName("caffeinated")]
        public int? Caffeinated { get; set; }
    }

    public class Effect
    {
        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("effect")]
        public string EffectProperty { get; set; }

        [JsonPropertyName("duration_ticks")]
        public int DurationTicks { get; set; }

        [JsonPropertyName("modifiers")]
        public Modifiers Modifiers { get; set; }
    }

    public class PersonalVault
    {
        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class Hotm
    {
        [JsonPropertyName("id")]
        public object Id { get; set; }

        [JsonPropertyName("Damage")]
        public object Damage { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public object Rarity { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("glowing")]
        public bool Glowing { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }
    }

    public class Talisman
    {
        [JsonPropertyName("isUnique")]
        public bool IsUnique { get; set; }

        [JsonPropertyName("isInactive")]
        public bool IsInactive { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

//        [JsonPropertyName("stats")]
//        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("base_name")]
        public string BaseName { get; set; }

        [JsonPropertyName("reforge")]
        public string Reforge { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("enrichment")]
        public string Enrichment { get; set; }

        [JsonPropertyName("inBackpack")]
        public bool? InBackpack { get; set; }

        [JsonPropertyName("backpackIndex")]
        public int? BackpackIndex { get; set; }

        [JsonPropertyName("containsItems")]
        public List<ContainsItem> ContainsItems { get; set; }
    }

    public class Weapon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("breaking_power")]
        public string BreakingPower { get; set; }

        [JsonPropertyName("isInactive")]
        public bool? IsInactive { get; set; }

        [JsonPropertyName("inBackpack")]
        public bool? InBackpack { get; set; }

        [JsonPropertyName("backpackIndex")]
        public int? BackpackIndex { get; set; }
    }

    public class Pickax
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("breaking_power")]
        public string BreakingPower { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("isInactive")]
        public bool? IsInactive { get; set; }

        [JsonPropertyName("inBackpack")]
        public bool? InBackpack { get; set; }

        [JsonPropertyName("backpackIndex")]
        public int? BackpackIndex { get; set; }
    }

    public class HighestRaritySword
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class HighestRarityBow
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class HighestRarityPickaxe
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("breaking_power")]
        public string BreakingPower { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class Items
    {
        [JsonPropertyName("armor")]
        public List<Armor> Armor { get; set; }

        [JsonPropertyName("wardrobe")]
        public List<List<object>> Wardrobe { get; set; }

        [JsonPropertyName("wardrobe_inventory")]
        public List<WardrobeInventory> WardrobeInventory { get; set; }

        [JsonPropertyName("inventory")]
        public List<Inventory> Inventory { get; set; }

        [JsonPropertyName("enderchest")]
        public List<Enderchest> Enderchest { get; set; }

        [JsonPropertyName("talisman_bag")]
        public List<TalismanBag> TalismanBag { get; set; }

        [JsonPropertyName("fishing_bag")]
        public List<object> FishingBag { get; set; }

        [JsonPropertyName("quiver")]
        public List<Quiver> Quiver { get; set; }

        [JsonPropertyName("potion_bag")]
        public List<PotionBag> PotionBag { get; set; }

        [JsonPropertyName("personal_vault")]
        public List<PersonalVault> PersonalVault { get; set; }

        [JsonPropertyName("storage")]
        public List<object> Storage { get; set; }

        [JsonPropertyName("hotm")]
        public List<Hotm> Hotm { get; set; }

        [JsonPropertyName("talismans")]
        public List<Talisman> Talismans { get; set; }

        [JsonPropertyName("talisman_ids")]
        public List<string> TalismanIds { get; set; }

        [JsonPropertyName("weapons")]
        public List<Weapon> Weapons { get; set; }

        [JsonPropertyName("hoes")]
        public List<object> Hoes { get; set; }

        [JsonPropertyName("pickaxes")]
        public List<Pickax> Pickaxes { get; set; }

        [JsonPropertyName("rods")]
        public List<object> Rods { get; set; }

        [JsonPropertyName("pets")]
        public List<object> Pets { get; set; }

        [JsonPropertyName("highest_rarity_sword")]
        public HighestRaritySword HighestRaritySword { get; set; }

        [JsonPropertyName("highest_rarity_bow")]
        public HighestRarityBow HighestRarityBow { get; set; }

        [JsonPropertyName("highest_rarity_pickaxe")]
        public HighestRarityPickaxe HighestRarityPickaxe { get; set; }

        [JsonPropertyName("armor_set_rarity")]
        public string ArmorSetRarity { get; set; }

        [JsonPropertyName("highest_rarity_hoe")]
        public HighestRarityHoe HighestRarityHoe { get; set; }

        [JsonPropertyName("armor_set")]
        public string ArmorSet { get; set; }

        [JsonPropertyName("highest_rarity_rod")]
        public HighestRarityRod HighestRarityRod { get; set; }
    }

    public class FairyBonus
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class FairySouls
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }
    }

    public class Taming
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Farming
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }

        [JsonPropertyName("talked")]
        public bool Talked { get; set; }

        [JsonPropertyName("current_badges")]
        public CurrentBadges CurrentBadges { get; set; }

        [JsonPropertyName("total_badges")]
        public TotalBadges TotalBadges { get; set; }

        [JsonPropertyName("perks")]
        public Perks Perks { get; set; }

        [JsonPropertyName("unique_golds")]
        public int UniqueGolds { get; set; }

        [JsonPropertyName("crops")]
        public Crops Crops { get; set; }
    }

    public class Mining
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }

        [JsonPropertyName("commissions")]
        public Commissions Commissions { get; set; }

        [JsonPropertyName("forge")]
        public Forge Forge { get; set; }

        [JsonPropertyName("core")]
        public Core Core { get; set; }
    }

    public class Combat
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public double CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public double DamageIncrease { get; set; }
    }

    public class Foraging
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Fishing
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("treasure")]
        public int Treasure { get; set; }

        [JsonPropertyName("treasure_large")]
        public int TreasureLarge { get; set; }

        [JsonPropertyName("shredder_fished")]
        public int ShredderFished { get; set; }

        [JsonPropertyName("shredder_bait")]
        public int ShredderBait { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Enchanting
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public double AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }

        [JsonPropertyName("experimented")]
        public bool Experimented { get; set; }

        [JsonPropertyName("experiments")]
        public Experiments Experiments { get; set; }
    }

    public class Alchemy
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Carpentry
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Runecrafting
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Levels
    {
        //[JsonPropertyName("taming")]
        //public Taming Taming { get; set; }

        [JsonPropertyName("farming")]
        public Farming Farming { get; set; }

        [JsonPropertyName("mining")]
        public Mining Mining { get; set; }

        [JsonPropertyName("combat")]
        public Combat Combat { get; set; }

        [JsonPropertyName("foraging")]
        public Foraging Foraging { get; set; }

        [JsonPropertyName("fishing")]
        public Fishing Fishing { get; set; }

        [JsonPropertyName("enchanting")]
        public Enchanting Enchanting { get; set; }

        [JsonPropertyName("alchemy")]
        public Alchemy Alchemy { get; set; }

        [JsonPropertyName("carpentry")]
        public Carpentry Carpentry { get; set; }

        [JsonPropertyName("runecrafting")]
        public Runecrafting Runecrafting { get; set; }
    }

    public class LevelCaps
    {
        [JsonPropertyName("farming")]
        public int Farming { get; set; }
    }

    public class SkillBonus
    {
        [JsonPropertyName("taming")]
        public Taming Taming { get; set; }

        [JsonPropertyName("farming")]
        public Farming Farming { get; set; }

        [JsonPropertyName("mining")]
        public Mining Mining { get; set; }

        [JsonPropertyName("combat")]
        public Combat Combat { get; set; }

        [JsonPropertyName("foraging")]
        public Foraging Foraging { get; set; }

        [JsonPropertyName("enchanting")]
        public Enchanting Enchanting { get; set; }

        [JsonPropertyName("alchemy")]
        public Alchemy Alchemy { get; set; }

        [JsonPropertyName("carpentry")]
        public Carpentry Carpentry { get; set; }

        [JsonPropertyName("runecrafting")]
        public Runecrafting Runecrafting { get; set; }

        [JsonPropertyName("fishing")]
        public Fishing Fishing { get; set; }
    }

    public class SlayerCoinsSpent
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("zombie")]
        public int Zombie { get; set; }

        [JsonPropertyName("spider")]
        public int Spider { get; set; }

        [JsonPropertyName("wolf")]
        public int Wolf { get; set; }

        [JsonPropertyName("enderman")]
        public int Enderman { get; set; }
    }

    public class SlayerBonus
    {
        [JsonPropertyName("spider")]
        public Spider Spider { get; set; }

        [JsonPropertyName("wolf")]
        public Wolf Wolf { get; set; }

        [JsonPropertyName("zombie")]
        public Zombie Zombie { get; set; }

        [JsonPropertyName("enderman")]
        public Enderman Enderman { get; set; }
    }

    public class Weight
    {
        [JsonPropertyName("weight")]
        public int WeightProperty { get; set; }

        [JsonPropertyName("weight_overflow")]
        public int WeightOverflow { get; set; }
    }

    public class Kills
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("entityName")]
        public string EntityName { get; set; }

        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }
    }

    public class Slayers
    {
/*        [JsonPropertyName("spider")]
        public Spider Spider { get; set; }

        [JsonPropertyName("wolf")]
        public Wolf Wolf { get; set; }

        [JsonPropertyName("zombie")]
        public Zombie Zombie { get; set; }

        [JsonPropertyName("enderman")]
        public Enderman Enderman { get; set; }*/
    }

    public class Missing
    {
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Upgrade
    {
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class MissingTalismans
    {
        [JsonPropertyName("missing")]
        public List<Missing> Missing { get; set; }

        [JsonPropertyName("upgrades")]
        public List<Upgrade> Upgrades { get; set; }
    }

    public class MissingPet
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("exp")]
        public int Exp { get; set; }

        [JsonPropertyName("tier")]
        public string Tier { get; set; }

        [JsonPropertyName("candyUsed")]
        public int CandyUsed { get; set; }

        [JsonPropertyName("heldItem")]
        public object HeldItem { get; set; }

        [JsonPropertyName("skin")]
        public object Skin { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

/*        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("ref")]
        public Ref Ref { get; set; } */

        [JsonPropertyName("lore")]
        public string Lore { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }
    }

    public class PetBonus
    {
        [JsonPropertyName("strength")]
        public double Strength { get; set; }

        [JsonPropertyName("crit_chance")]
        public double CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("intelligence")]
        public double Intelligence { get; set; }

        [JsonPropertyName("magic_find")]
        public double MagicFind { get; set; }

        [JsonPropertyName("defense")]
        public double Defense { get; set; }

        [JsonPropertyName("health")]
        public double Health { get; set; }
    }

    public class PetScoreBonus
    {
        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }
    }

    public class BaseStats
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public double CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public double AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public double DamageIncrease { get; set; }
    }

    public class _6b3b90c23cbb45789657E05377f26858
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class F05348d31cb44db598b01eabeca24944
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Aadef92c635a4d8eAcfdF8c3bfa6a817
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _15a2792029344178898703eb78f5bbaa
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _22eba515F39047f18b7a50643b290707
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _4830b3e8Ae554ef7A90e1adb2a24c5c2
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class B474b8116acf4cb6Afed7f67ecfa20a4
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class WeaponStats
    {
        [JsonPropertyName("6b3b90c2-3cbb-4578-9657-e05377f26858")]
        public _6b3b90c23cbb45789657E05377f26858 _6b3b90c23cbb45789657E05377f26858 { get; set; }

        [JsonPropertyName("f05348d3-1cb4-4db5-98b0-1eabeca24944")]
        public F05348d31cb44db598b01eabeca24944 F05348d31cb44db598b01eabeca24944 { get; set; }

        [JsonPropertyName("aadef92c-635a-4d8e-acfd-f8c3bfa6a817")]
        public Aadef92c635a4d8eAcfdF8c3bfa6a817 Aadef92c635a4d8eAcfdF8c3bfa6a817 { get; set; }

        [JsonPropertyName("15a27920-2934-4178-8987-03eb78f5bbaa")]
        public _15a2792029344178898703eb78f5bbaa _15a2792029344178898703eb78f5bbaa { get; set; }

        [JsonPropertyName("22eba515-f390-47f1-8b7a-50643b290707")]
        public _22eba515F39047f18b7a50643b290707 _22eba515F39047f18b7a50643b290707 { get; set; }

        [JsonPropertyName("4830b3e8-ae55-4ef7-a90e-1adb2a24c5c2")]
        public _4830b3e8Ae554ef7A90e1adb2a24c5c2 _4830b3e8Ae554ef7A90e1adb2a24c5c2 { get; set; }

        [JsonPropertyName("b474b811-6acf-4cb6-afed-7f67ecfa20a4")]
        public B474b8116acf4cb6Afed7f67ecfa20a4 B474b8116acf4cb6Afed7f67ecfa20a4 { get; set; }

        [JsonPropertyName("586ce947-a73c-4f6d-bec5-25436f57940c")]
        public _586ce947A73c4f6dBec525436f57940c _586ce947A73c4f6dBec525436f57940c { get; set; }

        [JsonPropertyName("1ecf4f14-f74d-497a-bd1d-a6a565b84471")]
        public _1ecf4f14F74d497aBd1dA6a565b84471 _1ecf4f14F74d497aBd1dA6a565b84471 { get; set; }

        [JsonPropertyName("65157459-dc6a-4914-bd6e-ce994305451c")]
        public _65157459Dc6a4914Bd6eCe994305451c _65157459Dc6a4914Bd6eCe994305451c { get; set; }

        [JsonPropertyName("98cc7e53-50de-4e97-819e-8e487b4c059b")]
        public _98cc7e5350de4e97819e8e487b4c059b _98cc7e5350de4e97819e8e487b4c059b { get; set; }

        [JsonPropertyName("d24731f9-e64b-4efa-a6a4-dece489e8cd6")]
        public D24731f9E64b4efaA6a4Dece489e8cd6 D24731f9E64b4efaA6a4Dece489e8cd6 { get; set; }

        [JsonPropertyName("a0989e02-3eb2-460f-bdca-22747b9c8930")]
        public A0989e023eb2460fBdca22747b9c8930 A0989e023eb2460fBdca22747b9c8930 { get; set; }

        [JsonPropertyName("b6b360d9-ea97-413b-9cfe-927ee9d5dde0")]
        public B6b360d9Ea97413b9cfe927ee9d5dde0 B6b360d9Ea97413b9cfe927ee9d5dde0 { get; set; }

        [JsonPropertyName("59b87a21-4ecc-47c8-b475-0a7c92dc2e52")]
        public _59b87a214ecc47c8B4750a7c92dc2e52 _59b87a214ecc47c8B4750a7c92dc2e52 { get; set; }

        [JsonPropertyName("f736618b-3942-4d27-97c2-994f0512e3a4")]
        public F736618b39424d2797c2994f0512e3a4 F736618b39424d2797c2994f0512e3a4 { get; set; }

        [JsonPropertyName("d04997d1-1fed-4825-a028-c6386e6ca312")]
        public D04997d11fed4825A028C6386e6ca312 D04997d11fed4825A028C6386e6ca312 { get; set; }

        [JsonPropertyName("0f2b0ac1-792f-4c30-af94-d6916546615c")]
        public _0f2b0ac1792f4c30Af94D6916546615c _0f2b0ac1792f4c30Af94D6916546615c { get; set; }

        [JsonPropertyName("85cb9236-51e9-4c86-ad90-d17fefb62ec6")]
        public _85cb923651e94c86Ad90D17fefb62ec6 _85cb923651e94c86Ad90D17fefb62ec6 { get; set; }

        [JsonPropertyName("189317b9-d6f2-4604-803e-7ffeaad5b6c5")]
        public _189317b9D6f24604803e7ffeaad5b6c5 _189317b9D6f24604803e7ffeaad5b6c5 { get; set; }

        [JsonPropertyName("5427e50c-c6f2-4f42-85e9-f47a380f03ec")]
        public _5427e50cC6f24f4285e9F47a380f03ec _5427e50cC6f24f4285e9F47a380f03ec { get; set; }

        [JsonPropertyName("f2a964c2-01cb-4630-a240-6109c9218827")]
        public F2a964c201cb4630A2406109c9218827 F2a964c201cb4630A2406109c9218827 { get; set; }

        [JsonPropertyName("8fa16ff9-3de7-4b26-a5d2-19d3d013613f")]
        public _8fa16ff93de74b26A5d219d3d013613f _8fa16ff93de74b26A5d219d3d013613f { get; set; }

        [JsonPropertyName("ff4238de-4409-441d-88c5-7e296c37633d")]
        public Ff4238de4409441d88c57e296c37633d Ff4238de4409441d88c57e296c37633d { get; set; }

        [JsonPropertyName("e75df7aa-9b9c-4e7c-b159-e63aa3bfb8fd")]
        public E75df7aa9b9c4e7cB159E63aa3bfb8fd E75df7aa9b9c4e7cB159E63aa3bfb8fd { get; set; }

        [JsonPropertyName("a6684ecb-3b8d-42e5-beb8-8b82d021b548")]
        public A6684ecb3b8d42e5Beb88b82d021b548 A6684ecb3b8d42e5Beb88b82d021b548 { get; set; }

        [JsonPropertyName("9ebf73e1-4025-4583-b488-4f93f06049f7")]
        public _9ebf73e140254583B4884f93f06049f7 _9ebf73e140254583B4884f93f06049f7 { get; set; }

        [JsonPropertyName("cb0071ec-23d9-4727-92a2-d997a92d9722")]
        public Cb0071ec23d9472792a2D997a92d9722 Cb0071ec23d9472792a2D997a92d9722 { get; set; }

        [JsonPropertyName("16543215-27a6-4072-bbf7-f4c229cdad3f")]
        public _1654321527a64072Bbf7F4c229cdad3f _1654321527a64072Bbf7F4c229cdad3f { get; set; }

        [JsonPropertyName("e89aa6c0-d4a8-4b0e-8caf-6696412044f5")]
        public E89aa6c0D4a84b0e8caf6696412044f5 E89aa6c0D4a84b0e8caf6696412044f5 { get; set; }

        [JsonPropertyName("b4b0876e-629d-43f4-b0e2-8165ccf3daa4")]
        public B4b0876e629d43f4B0e28165ccf3daa4 B4b0876e629d43f4B0e28165ccf3daa4 { get; set; }

        [JsonPropertyName("c4449b23-48f9-48a6-9a16-488080d8ac98")]
        public C4449b2348f948a69a16488080d8ac98 C4449b2348f948a69a16488080d8ac98 { get; set; }

        [JsonPropertyName("70d063bc-133b-40c0-9efc-a8b4801700f2")]
        public _70d063bc133b40c09efcA8b4801700f2 _70d063bc133b40c09efcA8b4801700f2 { get; set; }

        [JsonPropertyName("e83a3f42-d7de-467c-979e-3b540c85f063")]
        public E83a3f42D7de467c979e3b540c85f063 E83a3f42D7de467c979e3b540c85f063 { get; set; }

        [JsonPropertyName("bcffd881-3f74-4d47-9db1-811600094860")]
        public Bcffd8813f744d479db1811600094860 Bcffd8813f744d479db1811600094860 { get; set; }

        [JsonPropertyName("eb81f67f-c10f-4791-8e75-fc7c0dbaad42")]
        public Eb81f67fC10f47918e75Fc7c0dbaad42 Eb81f67fC10f47918e75Fc7c0dbaad42 { get; set; }

        [JsonPropertyName("fb3d5307-441f-495a-b4ed-e0a06c96d272")]
        public Fb3d5307441f495aB4edE0a06c96d272 Fb3d5307441f495aB4edE0a06c96d272 { get; set; }

        [JsonPropertyName("13654f31-0445-4108-8bc8-fab31f801294")]
        public _13654f31044541088bc8Fab31f801294 _13654f31044541088bc8Fab31f801294 { get; set; }

        [JsonPropertyName("fa1ad1aa-4ea1-4cad-9840-a400d2c013a0")]
        public Fa1ad1aa4ea14cad9840A400d2c013a0 Fa1ad1aa4ea14cad9840A400d2c013a0 { get; set; }

        [JsonPropertyName("9fd60c4e-86b8-4dc0-827b-3bdc9dcc0ae2")]
        public _9fd60c4e86b84dc0827b3bdc9dcc0ae2 _9fd60c4e86b84dc0827b3bdc9dcc0ae2 { get; set; }

        [JsonPropertyName("fd738d10-466b-44e1-97fb-db46744d05d0")]
        public Fd738d10466b44e197fbDb46744d05d0 Fd738d10466b44e197fbDb46744d05d0 { get; set; }

        [JsonPropertyName("d1e4aa8b-5abf-4ffb-b3ab-bc3e0d942e74")]
        public D1e4aa8b5abf4ffbB3abBc3e0d942e74 D1e4aa8b5abf4ffbB3abBc3e0d942e74 { get; set; }

        [JsonPropertyName("95d1bd52-6a18-4eb2-ac71-c71c548d9487")]
        public _95d1bd526a184eb2Ac71C71c548d9487 _95d1bd526a184eb2Ac71C71c548d9487 { get; set; }

        [JsonPropertyName("cfdca336-23ad-4a2b-aacf-f0e64f8909f3")]
        public Cfdca33623ad4a2bAacfF0e64f8909f3 Cfdca33623ad4a2bAacfF0e64f8909f3 { get; set; }

        [JsonPropertyName("f79bbad8-2da5-4fda-a9a6-8a0d77eef4c0")]
        public F79bbad82da54fdaA9a68a0d77eef4c0 F79bbad82da54fdaA9a68a0d77eef4c0 { get; set; }
    }

    public class Death
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("entityName")]
        public string EntityName { get; set; }
    }

    public class SkinData
    {
        [JsonPropertyName("skinurl")]
        public string Skinurl { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("capeurl")]
        public string Capeurl { get; set; }
    }

    public class GmUser
    {
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("skin_data")]
        public SkinData SkinData { get; set; }
    }

    public class Guild
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("gid")]
        public string Gid { get; set; }

        [JsonPropertyName("created")]
        public long Created { get; set; }

        [JsonPropertyName("exp")]
        public int Exp { get; set; }

        [JsonPropertyName("gm")]
        public string Gm { get; set; }

        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonPropertyName("members")]
        public int Members { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("gmUser")]
        public GmUser GmUser { get; set; }

        [JsonPropertyName("rank")]
        public string Rank { get; set; }
    }

    public class DataProfile
    {
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        [JsonPropertyName("cute_name")]
        public string CuteName { get; set; }

        [JsonPropertyName("game_mode")]
        public object GameMode { get; set; }
    }

    public class LastUpdated
    {
        [JsonPropertyName("unix")]
        public long Unix { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Profile
    {
        [JsonPropertyName("profile_id")]
        public string ProfileId { get; set; }

        [JsonPropertyName("cute_name")]
        public string CuteName { get; set; }

        [JsonPropertyName("game_mode")]
        public object GameMode { get; set; }

        [JsonPropertyName("last_updated")]
        public LastUpdated LastUpdated { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }

        [JsonPropertyName("last_save")]
        public long LastSave { get; set; }

        [JsonPropertyName("raw")]
        public Raw Raw { get; set; }

        [JsonPropertyName("items")]
        public Items Items { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Member
    {
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("skin_data")]
        public SkinData SkinData { get; set; }

        [JsonPropertyName("last_updated")]
        public LastUpdated LastUpdated { get; set; }
    }

    public class Minion
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("levels")]
        public List<int> Levels { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("head")]
        public string Head { get; set; }

        [JsonPropertyName("tiers")]
        public int Tiers { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class MinionSlots
    {
        [JsonPropertyName("currentSlots")]
        public int CurrentSlots { get; set; }

        [JsonPropertyName("toNext")]
        public int ToNext { get; set; }

        [JsonPropertyName("toNextSlot")]
        public int ToNextSlot { get; set; }
    }

    public class Amount
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("amount")]
        public int AmountPropery { get; set; }
    }

    public class INKSACK3
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class MELON
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class MUSHROOMCOLLECTION
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }


    public class CACTUS
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class CARROTITEM
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class POTATOITEM
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class NETHERSTALK
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class WHEAT
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class SUGARCANE
    {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class CollectionItem
        {
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }
    }

    public class Social
    {
    }

    public class MostDamage
    {
        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }
    }

    public class Floors
    {
        [JsonPropertyName("catacombs_1")]
        public int Catacombs1 { get; set; }

        [JsonPropertyName("master_catacombs_1")]
        public int MasterCatacombs1 { get; set; }

        [JsonPropertyName("catacombs_2")]
        public int Catacombs2 { get; set; }

        [JsonPropertyName("catacombs_3")]
        public int Catacombs3 { get; set; }

        [JsonPropertyName("catacombs_4")]
        public int Catacombs4 { get; set; }

        [JsonPropertyName("catacombs_5")]
        public int Catacombs5 { get; set; }

        [JsonPropertyName("catacombs_6")]
        public int Catacombs6 { get; set; }

        [JsonPropertyName("catacombs_7")]
        public int Catacombs7 { get; set; }
    }

    public class Bonuses
    {
        [JsonPropertyName("item_boost")]
        public int ItemBoost { get; set; }
    }

    public class Experience
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }
    }

    public class Classes
    {
        [JsonPropertyName("healer")]
        public Healer Healer { get; set; }

        [JsonPropertyName("mage")]
        public Mage Mage { get; set; }

        [JsonPropertyName("berserk")]
        public Berserk Berserk { get; set; }

        [JsonPropertyName("archer")]
        public Archer Archer { get; set; }

        [JsonPropertyName("tank")]
        public Tank Tank { get; set; }
    }

    public class Catacombs1
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("texture")]
        public string Texture { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public int Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public int Unclaimed { get; set; }

        [JsonPropertyName("claimed")]
        public List<object> Claimed { get; set; }
    }

    public class BossCollections
    {
        [JsonPropertyName("catacombs_1")]
        public Catacombs1 Catacombs1 { get; set; }
/*
        [JsonPropertyName("catacombs_2")]
        public Catacombs2 Catacombs2 { get; set; }

        [JsonPropertyName("catacombs_3")]
        public Catacombs3 Catacombs3 { get; set; }

        [JsonPropertyName("catacombs_4")]
        public Catacombs4 Catacombs4 { get; set; }

        [JsonPropertyName("catacombs_5")]
        public Catacombs5 Catacombs5 { get; set; }

        [JsonPropertyName("catacombs_6")]
        public Catacombs6 Catacombs6 { get; set; }

        [JsonPropertyName("catacombs_7")]
        public Catacombs7 Catacombs7 { get; set; }*/
    }

    public class Journals
    {
        [JsonPropertyName("pages_collected")]
        public int PagesCollected { get; set; }

        [JsonPropertyName("journals_completed")]
        public int JournalsCompleted { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }
    }

    public class CurrentBadges
    {
        [JsonPropertyName("bronze")]
        public int Bronze { get; set; }

        [JsonPropertyName("silver")]
        public int Silver { get; set; }

        [JsonPropertyName("gold")]
        public int Gold { get; set; }
    }

    public class TotalBadges
    {
        [JsonPropertyName("bronze")]
        public int Bronze { get; set; }

        [JsonPropertyName("silver")]
        public int Silver { get; set; }

        [JsonPropertyName("gold")]
        public int Gold { get; set; }
    }

    public class Badges
    {
        [JsonPropertyName("gold")]
        public int Gold { get; set; }

        [JsonPropertyName("silver")]
        public int Silver { get; set; }

        [JsonPropertyName("bronze")]
        public int Bronze { get; set; }
    }

    public class PUMPKIN
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("attended")]
        public bool Attended { get; set; }

        [JsonPropertyName("unique_gold")]
        public bool UniqueGold { get; set; }

        [JsonPropertyName("contests")]
        public int Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public int PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonPropertyName("amounts")]
        public List<Amount> Amounts { get; set; }
    }

    public class Crops
    {
        [JsonPropertyName("INK_SACK:3")]
        public INKSACK3 INKSACK3 { get; set; }

        [JsonPropertyName("POTATO_ITEM")]
        public POTATOITEM POTATOITEM { get; set; }

        [JsonPropertyName("CARROT_ITEM")]
        public CARROTITEM CARROTITEM { get; set; }

        [JsonPropertyName("CACTUS")]
        public CACTUS CACTUS { get; set; }

        [JsonPropertyName("SUGAR_CANE")]
        public SUGARCANE SUGARCANE { get; set; }

        [JsonPropertyName("MUSHROOM_COLLECTION")]
        public MUSHROOMCOLLECTION MUSHROOMCOLLECTION { get; set; }

        [JsonPropertyName("PUMPKIN")]
        public PUMPKIN PUMPKIN { get; set; }

        [JsonPropertyName("NETHER_STALK")]
        public NETHERSTALK NETHERSTALK { get; set; }

        [JsonPropertyName("WHEAT")]
        public WHEAT WHEAT { get; set; }

        [JsonPropertyName("MELON")]
        public MELON MELON { get; set; }
    }

    public class Placing
    {
        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("percentage")]
        public double? Percentage { get; set; }
    }

    public class AllContest
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("crop")]
        public string Crop { get; set; }

        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed")]
        public bool Claimed { get; set; }

        [JsonPropertyName("medal")]
        public string Medal { get; set; }

        [JsonPropertyName("placing")]
        public Placing Placing { get; set; }
    }

    public class LastAttempt
    {
        [JsonPropertyName("unix")]
        public long Unix { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class LastClaimed
    {
        [JsonPropertyName("unix")]
        public long Unix { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Tiers
    {
        // removed
    }

    public class Experiments
    {
        [JsonPropertyName("simon")]
        public Simon Simon { get; set; }

        [JsonPropertyName("pairings")]
        public Pairings Pairings { get; set; }

        [JsonPropertyName("numbers")]
        public Numbers Numbers { get; set; }
    }

    public class Commissions
    {
    //    [JsonPropertyName("milestone")]
    //    public string Milestone { get; set; }
    }

    public class Tier
    {
        [JsonPropertyName("xp")]
        public double Xp { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public int UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double LevelWithProgress { get; set; }

        [JsonPropertyName("level_cap")]
        public double Level_Cap { get; set; }

        [JsonPropertyName("uncapped_level")]
        public int Uncapped_Level { get; set; }
    }

    public class Tokens
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("spent")]
        public int Spent { get; set; }

        [JsonPropertyName("available")]
        public int Available { get; set; }
    }

    public class Mithril
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("spent")]
        public int Spent { get; set; }

        [JsonPropertyName("available")]
        public int Available { get; set; }
    }

    public class Gemstone
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("spent")]
        public int Spent { get; set; }

        [JsonPropertyName("available")]
        public int Available { get; set; }
    }

    public class Powder
    {
        [JsonPropertyName("mithril")]
        public Mithril Mithril { get; set; }

        [JsonPropertyName("gemstone")]
        public Gemstone Gemstone { get; set; }
    }

    public class Crystals
    {
        [JsonPropertyName("jade_crystal")]
        public JadeCrystal JadeCrystal { get; set; }

        [JsonPropertyName("amber_crystal")]
        public AmberCrystal AmberCrystal { get; set; }

        [JsonPropertyName("topaz_crystal")]
        public TopazCrystal TopazCrystal { get; set; }

        [JsonPropertyName("sapphire_crystal")]
        public SapphireCrystal SapphireCrystal { get; set; }

        [JsonPropertyName("amethyst_crystal")]
        public AmethystCrystal AmethystCrystal { get; set; }

        [JsonPropertyName("jasper_crystal")]
        public JasperCrystal JasperCrystal { get; set; }

        [JsonPropertyName("ruby_crystal")]
        public RubyCrystal RubyCrystal { get; set; }
    }

    public class CrystalNucleus
    {
        [JsonPropertyName("times_completed")]
        public int TimesCompleted { get; set; }

        [JsonPropertyName("crystals")]
        public Crystals Crystals { get; set; }

        [JsonPropertyName("goblin")]
        public object Goblin { get; set; }

        [JsonPropertyName("precursor")]
        public object Precursor { get; set; }
    }

    public class Ores
    {
        [JsonPropertyName("mithril")]
        public Mithril Mithril { get; set; }

        [JsonPropertyName("gemstone")]
        public Gemstone Gemstone { get; set; }
    }

    public class DailyOres
    {
        [JsonPropertyName("ores")]
        public Ores Ores { get; set; }
    }

    public class DailyEffect
    {
        [JsonPropertyName("effect")]
        public object Effect { get; set; }

        [JsonPropertyName("last_changed")]
        public object LastChanged { get; set; }
    }

    public class Core
    {
        [JsonPropertyName("tier")]
        public Tier Tier { get; set; }

        [JsonPropertyName("tokens")]
        public Tokens Tokens { get; set; }

        [JsonPropertyName("selected_pickaxe_ability")]
        public object SelectedPickaxeAbility { get; set; }

        [JsonPropertyName("powder")]
        public Powder Powder { get; set; }

        [JsonPropertyName("crystal_nucleus")]
        public CrystalNucleus CrystalNucleus { get; set; }

        [JsonPropertyName("daily_ores")]
        public DailyOres DailyOres { get; set; }

        [JsonPropertyName("hotm_last_reset")]
        public long HotmLastReset { get; set; }

        [JsonPropertyName("crystal_hollows_last_access")]
        public long CrystalHollowsLastAccess { get; set; }

        [JsonPropertyName("daily_effect")]
        public DailyEffect DailyEffect { get; set; }
    }

    public class Milestones
    {
        [JsonPropertyName("ores_mined")]
        public int OresMined { get; set; }

        [JsonPropertyName("sea_creatures_killed")]
        public int SeaCreaturesKilled { get; set; }
    }

    public class Races
    {
        [JsonPropertyName("foraging_race_best_time")]
        public int ForagingRaceBestTime { get; set; }

        [JsonPropertyName("end_race_best_time")]
        public int EndRaceBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_anything_no_return_best_time")]
        public int DungeonHubCrystalCoreAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_giant_mushroom_anything_no_return_best_time")]
        public int DungeonHubGiantMushroomAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_precursor_ruins_anything_no_return_best_time")]
        public int DungeonHubPrecursorRuinsAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_no_pearls_no_return_best_time")]
        public int DungeonHubCrystalCoreNoPearlsNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_no_abilities_no_return_best_time")]
        public int DungeonHubCrystalCoreNoAbilitiesNoReturnBestTime { get; set; }
    }

    public class Gifts
    {
        [JsonPropertyName("gifts_received")]
        public int GiftsReceived { get; set; }

        [JsonPropertyName("gifts_given")]
        public int GiftsGiven { get; set; }
    }

    public class Damage
    {
        [JsonPropertyName("highest_critical_damage")]
        public double HighestCriticalDamage { get; set; }
    }

    public class ProfileUpgrades
    {
        [JsonPropertyName("island_size")]
        public int IslandSize { get; set; }

        [JsonPropertyName("minion_slots")]
        public int MinionSlots { get; set; }

        [JsonPropertyName("guests_count")]
        public int GuestsCount { get; set; }

        [JsonPropertyName("coop_slots")]
        public int CoopSlots { get; set; }

        [JsonPropertyName("coins_allowance")]
        public int CoinsAllowance { get; set; }
    }

    public class AuctionsSell
    {
        [JsonPropertyName("fees")]
        public double Fees { get; set; }

        [JsonPropertyName("gold_earned")]
        public double GoldEarned { get; set; }

        [JsonPropertyName("items_sold")]
        public int ItemsSold { get; set; }
    }

    public class AuctionsBuy
    {
        [JsonPropertyName("bids")]
        public int Bids { get; set; }

        [JsonPropertyName("highest_bid")]
        public long HighestBid { get; set; }

        [JsonPropertyName("won")]
        public int Won { get; set; }

        [JsonPropertyName("gold_spent")]
        public double GoldSpent { get; set; }

        [JsonPropertyName("items_bought")]
        public int ItemsBought { get; set; }
    }

    public class ClaimedItems
    {
        [JsonPropertyName("Potato Talisman")]
        public long PotatoTalisman { get; set; }

        [JsonPropertyName("Free Booster Cookie")]
        public long FreeBoosterCookie { get; set; }

        [JsonPropertyName("Scorpius Bribe (Year 120)")]
        public long ScorpiusBribeYear120 { get; set; }

        [JsonPropertyName("Scorpius Bribe (Year 144)")]
        public long ScorpiusBribeYear144 { get; set; }
    }

    public class Misc
    {
        [JsonPropertyName("milestones")]
        public Milestones Milestones { get; set; }

        [JsonPropertyName("races")]
        public Races Races { get; set; }

        [JsonPropertyName("gifts")]
        public Gifts Gifts { get; set; }

        [JsonPropertyName("damage")]
        public Damage Damage { get; set; }

        [JsonPropertyName("profile_upgrades")]
        public ProfileUpgrades ProfileUpgrades { get; set; }

        [JsonPropertyName("auctions_sell")]
        public AuctionsSell AuctionsSell { get; set; }

        [JsonPropertyName("auctions_buy")]
        public AuctionsBuy AuctionsBuy { get; set; }

        [JsonPropertyName("claimed_items")]
        public ClaimedItems ClaimedItems { get; set; }

        [JsonPropertyName("winter")]
        public Winter Winter { get; set; }

        [JsonPropertyName("dragons")]
        public Dragons Dragons { get; set; }

        [JsonPropertyName("protector")]
        public Protector Protector { get; set; }

        [JsonPropertyName("burrows")]
        public Burrow Burrows { get; set; }
    }

    public class AuctionsBought
    {
        [JsonPropertyName("common")]
        public int Common { get; set; }

        [JsonPropertyName("epic")]
        public int Epic { get; set; }

        [JsonPropertyName("uncommon")]
        public int Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public int Rare { get; set; }

        [JsonPropertyName("legendary")]
        public int Legendary { get; set; }

        [JsonPropertyName("special")]
        public int Special { get; set; }
    }

    public class AuctionsSold
    {
        [JsonPropertyName("epic")]
        public int Epic { get; set; }

        [JsonPropertyName("common")]
        public int Common { get; set; }

        [JsonPropertyName("legendary")]
        public int Legendary { get; set; }

        [JsonPropertyName("uncommon")]
        public int Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public int Rare { get; set; }

        [JsonPropertyName("special")]
        public int Special { get; set; }
    }

    public class FirstJoin
    {
        [JsonPropertyName("unix")]
        public long Unix { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("fairy_bonus")]
        public FairyBonus FairyBonus { get; set; }

        [JsonPropertyName("fairy_souls")]
        public FairySouls FairySouls { get; set; }

        [JsonPropertyName("levels")]
        public Levels Levels { get; set; }

        [JsonPropertyName("average_level")]
        public double AverageLevel { get; set; }

        [JsonPropertyName("average_level_no_progress")]
        public double AverageLevelNoProgress { get; set; }

        [JsonPropertyName("total_skill_xp")]
        public double TotalSkillXp { get; set; }

        [JsonPropertyName("average_level_rank")]
        public int AverageLevelRank { get; set; }

        [JsonPropertyName("level_caps")]
        public LevelCaps LevelCaps { get; set; }

        [JsonPropertyName("skill_bonus")]
        public SkillBonus SkillBonus { get; set; }

        [JsonPropertyName("slayer_coins_spent")]
        public SlayerCoinsSpent SlayerCoinsSpent { get; set; }

        [JsonPropertyName("slayer_bonus")]
        public SlayerBonus SlayerBonus { get; set; }

        [JsonPropertyName("slayer_xp")]
        public int SlayerXp { get; set; }

        [JsonPropertyName("slayers")]
        public Slayers Slayers { get; set; }

        [JsonPropertyName("missingTalismans")]
        public MissingTalismans MissingTalismans { get; set; }

        [JsonPropertyName("talismanCount")]
        public int TalismanCount { get; set; }

        [JsonPropertyName("pets")]
        public List<Pet> Pets { get; set; }

        [JsonPropertyName("missingPets")]
        public List<MissingPet> MissingPets { get; set; }

        [JsonPropertyName("petScore")]
        public int PetScore { get; set; }

        [JsonPropertyName("pet_bonus")]
        public PetBonus PetBonus { get; set; }

        [JsonPropertyName("pet_score_bonus")]
        public PetScoreBonus PetScoreBonus { get; set; }

        [JsonPropertyName("base_stats")]
        public BaseStats BaseStats { get; set; }

        [JsonPropertyName("weapon_stats")]
        public WeaponStats WeaponStats { get; set; }

        [JsonPropertyName("kills")]
        public List<Kills> Kills { get; set; }

        [JsonPropertyName("deaths")]
        public List<Death> Deaths { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("wardrobe_equipped_slot")]
        public int WardrobeEquippedSlot { get; set; }

        [JsonPropertyName("bank")]
        public double Bank { get; set; }

        [JsonPropertyName("guild")]
        public Guild Guild { get; set; }

        [JsonPropertyName("rank_prefix")]
        public string RankPrefix { get; set; }

        [JsonPropertyName("purse")]
        public double Purse { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("skin_data")]
        public SkinData SkinData { get; set; }

        [JsonPropertyName("profile")]
        public DataProfile Profile { get; set; }

//        [JsonPropertyName("profiles")]
//        public Profiles Profiles { get; set; }

        [JsonPropertyName("members")]
        public List<Member> Members { get; set; }

        [JsonPropertyName("minions")]
        public List<Minion> Minions { get; set; }

        [JsonPropertyName("minion_slots")]
        public MinionSlots MinionSlots { get; set; }

        [JsonPropertyName("collections")]
        public Dictionary<string,CollectionItem> Collections { get; set; }

        [JsonPropertyName("social")]
        public Social Social { get; set; }

        [JsonPropertyName("dungeons")]
        public Dungeons Dungeons { get; set; }

        [JsonPropertyName("fishing")]
        public Fishing Fishing { get; set; }

        [JsonPropertyName("farming")]
        public Farming Farming { get; set; }

        [JsonPropertyName("enchanting")]
        public Enchanting Enchanting { get; set; }

        [JsonPropertyName("mining")]
        public Mining Mining { get; set; }

        [JsonPropertyName("misc")]
        public Misc Misc { get; set; }

        [JsonPropertyName("auctions_bought")]
        public AuctionsBought AuctionsBought { get; set; }

        [JsonPropertyName("auctions_sold")]
        public AuctionsSold AuctionsSold { get; set; }

        [JsonPropertyName("last_updated")]
        public LastUpdated LastUpdated { get; set; }

        [JsonPropertyName("first_join")]
        public FirstJoin FirstJoin { get; set; }

        [JsonPropertyName("dungeonsWeight")]
        public double DungeonsWeight { get; set; }

        [JsonPropertyName("skillWeight")]
        public double SkillWeight { get; set; }

        [JsonPropertyName("slayerWeight")]
        public double SlayerWeight { get; set; }

        [JsonPropertyName("weight")]
        public object Weight { get; set; }

        [JsonPropertyName("current_area")]
        public string CurrentArea { get; set; }
    }

    public class CollectWheat
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFarmer2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseFarmingSkill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class WarpBarnIsland
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ActiveEffect
    {
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("level")]
        public double Level { get; set; }

        [JsonPropertyName("modifiers")]
        public List<object> Modifiers { get; set; }

        [JsonPropertyName("ticks_remaining")]
        public int TicksRemaining { get; set; }

        [JsonPropertyName("infinite")]
        public bool Infinite { get; set; }
    }

    public class Ho
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("isInactive")]
        public bool IsInactive { get; set; }

        [JsonPropertyName("inBackpack")]
        public bool InBackpack { get; set; }

        [JsonPropertyName("backpackIndex")]
        public int BackpackIndex { get; set; }
    }

    public class HighestRarityHoe
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class _586ce947A73c4f6dBec525436f57940c
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }

        [JsonPropertyName("true defense")]
        public object TrueDefense { get; set; }
    }

    public class IncreaseForagingSkill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class WarpForagingIslands
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectBirchLogs
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFarmhand2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectFarmingResources
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("POTATO_ITEM")]
        public bool POTATOITEM { get; set; }

        [JsonPropertyName("CARROT_ITEM")]
        public bool CARROTITEM { get; set; }

        [JsonPropertyName("PUMPKIN")]
        public bool PUMPKIN { get; set; }

        [JsonPropertyName("MELON")]
        public bool MELON { get; set; }
    }

    public class CollectFarmAnimalResources
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("RAW_CHICKEN")]
        public bool RAWCHICKEN { get; set; }

        [JsonPropertyName("LEATHER")]
        public bool LEATHER { get; set; }

        [JsonPropertyName("PORK")]
        public bool PORK { get; set; }
    }

    public class KillDangerMobs
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToBartender
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseCombatSkill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class WarpSpidersDen
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectClay
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToCharlie
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToHaymitch
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectSpider
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("STRING")]
        public bool STRING { get; set; }

        [JsonPropertyName("SPIDER_EYE")]
        public bool SPIDEREYE { get; set; }
    }

    public class TalkToElle
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFisherman2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuber2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheEndRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuber3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheEndRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectNetherResources
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("BLAZE_ROD")]
        public bool BLAZEROD { get; set; }

        [JsonPropertyName("NETHER_STALK")]
        public bool NETHERSTALK { get; set; }
    }

    public class CollectNetherResources2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("MAGMA_CREAM")]
        public bool MAGMACREAM { get; set; }

        [JsonPropertyName("GLOWSTONE_DUST")]
        public bool GLOWSTONEDUST { get; set; }

        [JsonPropertyName("QUARTZ")]
        public bool QUARTZ { get; set; }
    }

    public class TalkToGuber4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheEndRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToMelody
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGustave3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheWoodsRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGustave4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheWoodsRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuber5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGustave5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNoPearlsWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNoAbilitiesWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNothingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNoPearlsWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNoAbilitiesWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNothingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoAbilitiesWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNothingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNoPearlsNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNoAbilitiesNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNothingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNoPearlsNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNoAbilitiesNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNothingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoAbilitiesNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNothingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordGiantMushroomAnythingNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordGiantMushroomAnythingNoReturn2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingNoReturnRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordGiantMushroomAnythingNoReturn3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingNoReturnRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordGiantMushroomAnythingNoReturn4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordPrecursorRuinsAnythingNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordPrecursorRuinsAnythingNoReturn2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingNoReturnRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordPrecursorRuinsAnythingNoReturn3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingNoReturnRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordPrecursorRuinsAnythingNoReturn4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreAnythingNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreAnythingNoReturn2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingNoReturnRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreAnythingNoReturn3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingNoReturnRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoPearlsNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoPearlsNoReturn2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsNoReturnRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoPearlsNoReturn3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsNoReturnRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoPearlsNoReturn4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoAbilitiesNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoAbilitiesNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur261
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur271
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur281
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur12
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur22
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur32
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur42
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur52
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur62
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur72
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToArchaeologist
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToShaggy
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindRelics
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindUberRelics
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur182
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur192
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur232
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur262
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur272
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur292
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur43
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur63
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur83
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur133
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur163
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur193
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur233
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur293
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur303
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur64
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur104
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur114
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur124
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur134
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur154
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur184
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur214
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur224
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur45
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur265
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGwendolyn
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToBraum
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class VisitGreaterMines
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToTheGoblinKing
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class KillAutomatons
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class EnterDivanMines
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class FindAJungleKey
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public int ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class MineRuby
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToProfessorRobot
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindFourMissingPieces
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineJade
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineSapphire
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindTheGoblinQueen
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineAmber
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTrialsOfJungleTemple
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineAmethyst
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur158
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur208
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur218
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur39
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur69
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur79
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur109
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur199
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur219
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FastestTimeS
    {
        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("4")]
        public int _4 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }
    }

    public class FastestTimeSPlus
    {
        [JsonPropertyName("1")]
        public int _1 { get; set; }

        [JsonPropertyName("2")]
        public int _2 { get; set; }

        [JsonPropertyName("3")]
        public int _3 { get; set; }

        [JsonPropertyName("5")]
        public int _5 { get; set; }

        [JsonPropertyName("6")]
        public int _6 { get; set; }

        [JsonPropertyName("7")]
        public int _7 { get; set; }
    }

    public class MostDamageBerserk
    {
        [JsonPropertyName("0")]
        public double _0 { get; set; }

        [JsonPropertyName("1")]
        public double _1 { get; set; }

        [JsonPropertyName("2")]
        public double _2 { get; set; }

        [JsonPropertyName("3")]
        public double _3 { get; set; }

        [JsonPropertyName("5")]
        public double _5 { get; set; }
    }

    public class Burrow
    {
        [JsonPropertyName("ts")]
        public object Ts { get; set; }

        [JsonPropertyName("x")]
        public int X { get; set; }

        [JsonPropertyName("y")]
        public int Y { get; set; }

        [JsonPropertyName("z")]
        public int Z { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("chain")]
        public int Chain { get; set; }

        [JsonPropertyName("dug_next")]
        public DugNext DugNext { get; set; }

        [JsonPropertyName("dug_combat")]
        public DugCombat DugCombat { get; set; }

        [JsonPropertyName("dug_treasure")]
        public DugTreasure DugTreasure { get; set; }

        [JsonPropertyName("chains_complete")]
        public ChainsComplete ChainsComplete { get; set; }
    }

    public class _105831POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _105915PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _105915SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1051110PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1051122NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1051122WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1051125SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _106117SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _106414SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _106423WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _106612CACTUS
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _107117SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _10745PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _10745CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _107612SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _107612CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1071029POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _107114POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _108414NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1081017NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1081017SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1081215NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _10915NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _109321CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _109828NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _109927POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1091212CACTUS
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1091212WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1091221PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _110222MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _110312PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _110516CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _110921POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _112321PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _11312WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _11312SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _113123PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _113126SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1131026NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1131026MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _113111SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1131215PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114213SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _11433PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114315WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114318PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _114318SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114321PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114525SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _114528PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _11554SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _125330PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1251227CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _131123POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _131312PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _131321CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13142POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13142WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _13145NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13187SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13187WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _131816SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1311014CACTUS
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1311017MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _13215MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _13348MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13354MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _133519POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _133525MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _133525CACTUS
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _134927SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _134930PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1341128POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _135426WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13572SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13593NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1351119SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1351119WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1351230SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13627SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _13627WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _136321SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _136411SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _136414CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13669SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _136615PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _136630SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _136723SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13712PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _137123WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _137327PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _137330SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1371026PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13866MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13869PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _13887PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _139312WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _139510NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _139513PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _139729POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1391122POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1391215POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _140429SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _141918POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _141921SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _142417NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _142420WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _14293PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _143810PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _143813POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _14412CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _144315PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _144102SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1441224CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _145510SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _145129MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _14657POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _147120SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _147426NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _147426CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _147711MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _14796WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _147915CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1471119NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _14845NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _149117POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _149111CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1501221POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1501224CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _15254POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _153213PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _15581PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _15687POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1561221CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1571212POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _158717NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _158918WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1581128POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1581131WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _159210PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _159711PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1591017POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _16039PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _160411CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _160414CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _160414NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1601230WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _161330MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _1611023SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _162516NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _162729SUGARCANE
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _162813MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _16336PUMPKIN
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _16339POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _163510MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _163717POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _1631212MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _16451POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _16599NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _166129MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _16693POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _167114NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _167813NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _168315MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _168921POTATOITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class HarpQuest
    {
        [JsonPropertyName("selected_song")]
        public string SelectedSong { get; set; }

        [JsonPropertyName("selected_song_epoch")]
        public long SelectedSongEpoch { get; set; }

        [JsonPropertyName("song_hymn_joy_best_completion")]
        public double SongHymnJoyBestCompletion { get; set; }

        [JsonPropertyName("song_hymn_joy_completions")]
        public double SongHymnJoyCompletions { get; set; }

        [JsonPropertyName("song_hymn_joy_perfect_completions")]
        public double SongHymnJoyPerfectCompletions { get; set; }

        [JsonPropertyName("song_frere_jacques_best_completion")]
        public double SongFrereJacquesBestCompletion { get; set; }

        [JsonPropertyName("song_frere_jacques_completions")]
        public double SongFrereJacquesCompletions { get; set; }

        [JsonPropertyName("song_amazing_grace_completions")]
        public double SongAmazingGraceCompletions { get; set; }

        [JsonPropertyName("song_amazing_grace_best_completion")]
        public double SongAmazingGraceBestCompletion { get; set; }

        [JsonPropertyName("song_amazing_grace_perfect_completions")]
        public double SongAmazingGracePerfectCompletions { get; set; }

        [JsonPropertyName("s")]
        public double SongBrahmsBestCompletion { get; set; }

        [JsonPropertyName("song_brahms_completions")]
        public double SongBrahmsCompletions { get; set; }

        [JsonPropertyName("song_brahms_perfect_completions")]
        public double SongBrahmsPerfectCompletions { get; set; }

        [JsonPropertyName("song_happy_birthday_best_completion")]
        public double SongHappyBirthdayBestCompletion { get; set; }

        [JsonPropertyName("song_happy_birthday_completions")]
        public double SongHappyBirthdayCompletions { get; set; }

        [JsonPropertyName("song_happy_birthday_perfect_completions")]
        public double SongHappyBirthdayPerfectCompletions { get; set; }

        [JsonPropertyName("song_greensleeves_best_completion")]
        public double SongGreensleevesBestCompletion { get; set; }

        [JsonPropertyName("song_greensleeves_completions")]
        public double SongGreensleevesCompletions { get; set; }
    }

    public class JadeCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public int TotalPlaced { get; set; }
    }

    public class AmberCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public int TotalPlaced { get; set; }
    }

    public class TopazCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public int TotalPlaced { get; set; }
    }

    public class SapphireCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public int TotalPlaced { get; set; }
    }

    public class AmethystCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public int TotalPlaced { get; set; }
    }

    public class JasperCrystal
    {
    }

    public class RubyCrystal
    {
    }

    public class Dwarven
    {
        [JsonPropertyName("statues_placed")]
        public List<string> StatuesPlaced { get; set; }
    }

    public class Precursor
    {
        [JsonPropertyName("parts_delivered")]
        public List<object> PartsDelivered { get; set; }
    }

    public class Goblin
    {
        [JsonPropertyName("king_quest_active")]
        public bool KingQuestActive { get; set; }

        [JsonPropertyName("king_quests_completed")]
        public int KingQuestsCompleted { get; set; }
    }

    public class Biomes
    {
        [JsonPropertyName("dwarven")]
        public Dwarven Dwarven { get; set; }

        [JsonPropertyName("precursor")]
        public Precursor Precursor { get; set; }

        [JsonPropertyName("goblin")]
        public Goblin Goblin { get; set; }
    }

    public class Forge1
    {
        // removed
    }

    public class _8
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _9
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _10
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _122
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _13
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _16
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _17
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class BackpackContents
    {
        // removed
    }

    public class FishingBag
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class CandyInventoryContents
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class Gems
    {
        [JsonPropertyName("COMBAT_0")]
        public string COMBAT0 { get; set; }

        [JsonPropertyName("COMBAT_0_gem")]
        public string COMBAT0Gem { get; set; }

        [JsonPropertyName("RUBY_0")]
        public string RUBY0 { get; set; }

        [JsonPropertyName("SAPPHIRE_0")]
        public string SAPPHIRE0 { get; set; }

        [JsonPropertyName("RUBY_3")]
        public string RUBY3 { get; set; }

        [JsonPropertyName("RUBY_1")]
        public string RUBY1 { get; set; }

        [JsonPropertyName("RUBY_2")]
        public string RUBY2 { get; set; }

        [JsonPropertyName("JADE_0")]
        public string JADE0 { get; set; }

        [JsonPropertyName("UNIVERSAL_0")]
        public string UNIVERSAL0 { get; set; }

        [JsonPropertyName("AMBER_0")]
        public string AMBER0 { get; set; }

        [JsonPropertyName("UNIVERSAL_0_gem")]
        public string UNIVERSAL0Gem { get; set; }

        [JsonPropertyName("JASPER_0")]
        public string JASPER0 { get; set; }

        [JsonPropertyName("AMETHYST_2")]
        public string AMETHYST2 { get; set; }

        [JsonPropertyName("AMETHYST_1")]
        public string AMETHYST1 { get; set; }

        [JsonPropertyName("AMETHYST_0")]
        public string AMETHYST0 { get; set; }

        [JsonPropertyName("RUBY_4")]
        public string RUBY4 { get; set; }

        [JsonPropertyName("JASPER_1")]
        public string JASPER1 { get; set; }

        [JsonPropertyName("TOPAZ_0")]
        public string TOPAZ0 { get; set; }
    }

    public class ContainsItem
    {
        [JsonPropertyName("isInactive")]
        public bool IsInactive { get; set; }

        [JsonPropertyName("inBackpack")]
        public bool InBackpack { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("backpackIndex")]
        public int BackpackIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("Count")]
        public int? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int? Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("breaking_power")]
        public string BreakingPower { get; set; }
    }

    public class Storage
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("containsItems")]
        public List<ContainsItem> ContainsItems { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class NecromancerSoul
    {
        [JsonPropertyName("mob_id")]
        public string MobId { get; set; }
    }

    public class Rod
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class HighestRarityRod
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public int Damage { get; set; }

        [JsonPropertyName("extra")]
        public Extra Extra { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_print")]
        public string DisplayNamePrint { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("equipmentType")]
        public string EquipmentType { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("item_index")]
        public int ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class _1ecf4f14F74d497aBd1dA6a565b84471
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _65157459Dc6a4914Bd6eCe994305451c
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _98cc7e5350de4e97819e8e487b4c059b
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class D24731f9E64b4efaA6a4Dece489e8cd6
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class A0989e023eb2460fBdca22747b9c8930
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class B6b360d9Ea97413b9cfe927ee9d5dde0
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _59b87a214ecc47c8B4750a7c92dc2e52
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class F736618b39424d2797c2994f0512e3a4
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class D04997d11fed4825A028C6386e6ca312
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _0f2b0ac1792f4c30Af94D6916546615c
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _85cb923651e94c86Ad90D17fefb62ec6
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _189317b9D6f24604803e7ffeaad5b6c5
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _5427e50cC6f24f4285e9F47a380f03ec
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class F2a964c201cb4630A2406109c9218827
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _8fa16ff93de74b26A5d219d3d013613f
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Ff4238de4409441d88c57e296c37633d
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class E75df7aa9b9c4e7cB159E63aa3bfb8fd
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class A6684ecb3b8d42e5Beb88b82d021b548
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _9ebf73e140254583B4884f93f06049f7
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Cb0071ec23d9472792a2D997a92d9722
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _1654321527a64072Bbf7F4c229cdad3f
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class E89aa6c0D4a84b0e8caf6696412044f5
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class B4b0876e629d43f4B0e28165ccf3daa4
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class C4449b2348f948a69a16488080d8ac98
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _70d063bc133b40c09efcA8b4801700f2
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class E83a3f42D7de467c979e3b540c85f063
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Bcffd8813f744d479db1811600094860
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Eb81f67fC10f47918e75Fc7c0dbaad42
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Fb3d5307441f495aB4edE0a06c96d272
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _13654f31044541088bc8Fab31f801294
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Fa1ad1aa4ea14cad9840A400d2c013a0
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class _9fd60c4e86b84dc0827b3bdc9dcc0ae2
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Fd738d10466b44e197fbDb46744d05d0
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class D1e4aa8b5abf4ffbB3abBc3e0d942e74
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Catacombs22
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("texture")]
        public string Texture { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public int Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public int Unclaimed { get; set; }

        [JsonPropertyName("claimed")]
        public List<string> Claimed { get; set; }
    }

    public class Catacombs32
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("texture")]
        public string Texture { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public int Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public int Unclaimed { get; set; }

        [JsonPropertyName("claimed")]
        public List<object> Claimed { get; set; }
    }

    public class Catacombs42
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("texture")]
        public string Texture { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public int Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public int Unclaimed { get; set; }

        [JsonPropertyName("claimed")]
        public List<object> Claimed { get; set; }
    }

    public class Catacombs52
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("texture")]
        public string Texture { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public int Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public int Unclaimed { get; set; }

        [JsonPropertyName("claimed")]
        public List<string> Claimed { get; set; }
    }

    public class Catacombs62
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("texture")]
        public string Texture { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public int Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public int Unclaimed { get; set; }

        [JsonPropertyName("claimed")]
        public List<object> Claimed { get; set; }
    }

    public class Catacombs7
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("texture")]
        public string Texture { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public int Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public int Unclaimed { get; set; }

        [JsonPropertyName("claimed")]
        public List<object> Claimed { get; set; }
    }

    public class Winter
    {
        [JsonPropertyName("most_winter_snowballs_hit")]
        public int MostWinterSnowballsHit { get; set; }

        [JsonPropertyName("most_winter_damage_dealt")]
        public int MostWinterDamageDealt { get; set; }

        [JsonPropertyName("most_winter_magma_damage_dealt")]
        public int MostWinterMagmaDamageDealt { get; set; }

        [JsonPropertyName("most_winter_cannonballs_hit")]
        public int MostWinterCannonballsHit { get; set; }
    }

    public class Dragons
    {
        [JsonPropertyName("ender_crystals_destroyed")]
        public int EnderCrystalsDestroyed { get; set; }

        [JsonPropertyName("last_hits")]
        public int LastHits { get; set; }

        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }
    }

    public class Protector
    {
        [JsonPropertyName("last_hits")]
        public int LastHits { get; set; }
    }

    public class DugNext
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("null")]
        public int Null { get; set; }

        [JsonPropertyName("common")]
        public int Common { get; set; }

        [JsonPropertyName("uncommon")]
        public int Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public int Rare { get; set; }

        [JsonPropertyName("epic")]
        public int Epic { get; set; }

        [JsonPropertyName("legendary")]
        public int Legendary { get; set; }
    }

    public class DugCombat
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("null")]
        public int Null { get; set; }

        [JsonPropertyName("common")]
        public int Common { get; set; }

        [JsonPropertyName("uncommon")]
        public int Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public int Rare { get; set; }

        [JsonPropertyName("epic")]
        public int Epic { get; set; }

        [JsonPropertyName("legendary")]
        public int Legendary { get; set; }
    }

    public class DugTreasure
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("null")]
        public int Null { get; set; }

        [JsonPropertyName("common")]
        public int Common { get; set; }

        [JsonPropertyName("uncommon")]
        public int Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public int Rare { get; set; }

        [JsonPropertyName("epic")]
        public int Epic { get; set; }
    }

    public class ChainsComplete
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("null")]
        public int Null { get; set; }

        [JsonPropertyName("common")]
        public int Common { get; set; }

        [JsonPropertyName("uncommon")]
        public int Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public int Rare { get; set; }

        [JsonPropertyName("epic")]
        public int Epic { get; set; }
    }

    public class _154411MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _154414CARROTITEM
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public int ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public int ClaimedParticipants { get; set; }
    }

    public class _155129MELON
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _15566MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _162810WHEAT
    {
        [JsonPropertyName("collected")]
        public int Collected { get; set; }
    }

    public class _95d1bd526a184eb2Ac71C71c548d9487
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Cfdca33623ad4a2bAacfF0e64f8909f3
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class F79bbad82da54fdaA9a68a0d77eef4c0
    {
        [JsonPropertyName("health")]
        public int Health { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public int EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public int Strength { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public int CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public int BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public int Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public int SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public int MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public int PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public int Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public int AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public int MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public int MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public int FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public int ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public int Pristine { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public int DamageIncrease { get; set; }
    }

    public class Process
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("slot")]
        public int Slot { get; set; }

        [JsonPropertyName("timeFinished")]
        public object TimeFinished { get; set; }

        [JsonPropertyName("timeFinishedText")]
        public string TimeFinishedText { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("profiles")]
        public Dictionary<string,Profile> Profiles { get; set; }
    }
}
