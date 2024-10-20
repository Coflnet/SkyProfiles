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
        public float? Type { get; set; }

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
        public float? PetMilestoneOresMined { get; set; }

        [JsonPropertyName("deaths")]
        public float? Deaths { get; set; }

        [JsonPropertyName("deaths_fire")]
        public float? DeathsFire { get; set; }

        [JsonPropertyName("highest_critical_damage")]
        public double? HighestCriticalDamage { get; set; }

        [JsonPropertyName("kills")]
        public float? Kills { get; set; }

        [JsonPropertyName("kills_lapis_zombie")]
        public float? KillsLapisZombie { get; set; }

        [JsonPropertyName("deaths_lapis_zombie")]
        public float? DeathsLapisZombie { get; set; }

        [JsonPropertyName("deaths_redstone_pigman")]
        public float? DeathsRedstonePigman { get; set; }

        [JsonPropertyName("kills_redstone_pigman")]
        public float? KillsRedstonePigman { get; set; }

        [JsonPropertyName("kills_emerald_slime")]
        public float? KillsEmeraldSlime { get; set; }

        [JsonPropertyName("deaths_emerald_slime")]
        public float? DeathsEmeraldSlime { get; set; }

        [JsonPropertyName("kills_invisible_creeper")]
        public float? KillsInvisibleCreeper { get; set; }

        [JsonPropertyName("kills_diamond_skeleton")]
        public float? KillsDiamondSkeleton { get; set; }

        [JsonPropertyName("deaths_diamond_zombie")]
        public float? DeathsDiamondZombie { get; set; }

        [JsonPropertyName("kills_diamond_zombie")]
        public float? KillsDiamondZombie { get; set; }

        [JsonPropertyName("deaths_diamond_skeleton")]
        public float? DeathsDiamondSkeleton { get; set; }

        [JsonPropertyName("auctions_bids")]
        public float? AuctionsBids { get; set; }

        [JsonPropertyName("auctions_highest_bid")]
        public float? AuctionsHighestBid { get; set; }

        [JsonPropertyName("foraging_race_best_time")]
        public float? ForagingRaceBestTime { get; set; }

        [JsonPropertyName("gifts_received")]
        public float? GiftsReceived { get; set; }

        [JsonPropertyName("kills_zombie")]
        public float? KillsZombie { get; set; }

        [JsonPropertyName("kills_skeleton")]
        public float? KillsSkeleton { get; set; }

        [JsonPropertyName("kills_spider")]
        public float? KillsSpider { get; set; }

        [JsonPropertyName("auctions_won")]
        public float? AuctionsWon { get; set; }

        [JsonPropertyName("auctions_bought_common")]
        public float? AuctionsBoughtCommon { get; set; }

        [JsonPropertyName("auctions_gold_spent")]
        public double? AuctionsGoldSpent { get; set; }

        [JsonPropertyName("deaths_zombie")]
        public float? DeathsZombie { get; set; }

        [JsonPropertyName("kills_witch")]
        public float? KillsWitch { get; set; }

        [JsonPropertyName("deaths_void")]
        public float? DeathsVoid { get; set; }

        [JsonPropertyName("deaths_fall")]
        public float? DeathsFall { get; set; }

        [JsonPropertyName("kills_magma_cube")]
        public float? KillsMagmaCube { get; set; }

        [JsonPropertyName("kills_wither_skeleton")]
        public float? KillsWitherSkeleton { get; set; }

        [JsonPropertyName("kills_pigman")]
        public float? KillsPigman { get; set; }

        [JsonPropertyName("kills_sheep")]
        public float? KillsSheep { get; set; }

        [JsonPropertyName("kills_slime")]
        public float? KillsSlime { get; set; }

        [JsonPropertyName("auctions_created")]
        public float? AuctionsCreated { get; set; }

        [JsonPropertyName("auctions_fees")]
        public float? AuctionsFees { get; set; }

        [JsonPropertyName("auctions_bought_epic")]
        public float? AuctionsBoughtEpic { get; set; }

        [JsonPropertyName("kills_fireball_magma_cube")]
        public float? KillsFireballMagmaCube { get; set; }

        [JsonPropertyName("kills_blaze")]
        public float? KillsBlaze { get; set; }

        [JsonPropertyName("kills_ruin_wolf")]
        public float? KillsRuinWolf { get; set; }

        [JsonPropertyName("kills_old_wolf")]
        public float? KillsOldWolf { get; set; }

        [JsonPropertyName("kills_zombie_villager")]
        public float? KillsZombieVillager { get; set; }

        [JsonPropertyName("auctions_completed")]
        public float? AuctionsCompleted { get; set; }

        [JsonPropertyName("auctions_sold_epic")]
        public float? AuctionsSoldEpic { get; set; }

        [JsonPropertyName("auctions_gold_earned")]
        public long AuctionsGoldEarned { get; set; }

        [JsonPropertyName("kills_splitter_spider")]
        public float? KillsSplitterSpider { get; set; }

        [JsonPropertyName("kills_splitter_spider_silverfish")]
        public float? KillsSplitterSpiderSilverfish { get; set; }

        [JsonPropertyName("kills_spider_jockey")]
        public float? KillsSpiderJockey { get; set; }

        [JsonPropertyName("kills_jockey_skeleton")]
        public float? KillsJockeySkeleton { get; set; }

        [JsonPropertyName("kills_dasher_spider")]
        public float? KillsDasherSpider { get; set; }

        [JsonPropertyName("kills_weaver_spider")]
        public float? KillsWeaverSpider { get; set; }

        [JsonPropertyName("kills_voracious_spider")]
        public float? KillsVoraciousSpider { get; set; }

        [JsonPropertyName("kills_jockey_shot_silverfish")]
        public float? KillsJockeyShotSilverfish { get; set; }

        [JsonPropertyName("kills_respawning_skeleton")]
        public float? KillsRespawningSkeleton { get; set; }

        [JsonPropertyName("deaths_endermite")]
        public float? DeathsEndermite { get; set; }

        [JsonPropertyName("kills_enderman")]
        public float? KillsEnderman { get; set; }

        [JsonPropertyName("deaths_enderman")]
        public float? DeathsEnderman { get; set; }

        [JsonPropertyName("auctions_sold_common")]
        public float? AuctionsSoldCommon { get; set; }

        [JsonPropertyName("auctions_no_bids")]
        public float? AuctionsNoBids { get; set; }

        [JsonPropertyName("auctions_bought_uncommon")]
        public float? AuctionsBoughtUncommon { get; set; }

        [JsonPropertyName("kills_pig")]
        public float? KillsPig { get; set; }

        [JsonPropertyName("kills_unburried_zombie")]
        public float? KillsUnburriedZombie { get; set; }

        [JsonPropertyName("kills_chicken")]
        public float? KillsChicken { get; set; }

        [JsonPropertyName("auctions_bought_rare")]
        public float? AuctionsBoughtRare { get; set; }

        [JsonPropertyName("gifts_given")]
        public float? GiftsGiven { get; set; }

        [JsonPropertyName("kills_mayor_jerry_green")]
        public float? KillsMayorJerryGreen { get; set; }

        [JsonPropertyName("deaths_old_wolf")]
        public float? DeathsOldWolf { get; set; }

        [JsonPropertyName("kills_goblin_knife_thrower")]
        public float? KillsGoblinKnifeThrower { get; set; }

        [JsonPropertyName("kills_goblin")]
        public float? KillsGoblin { get; set; }

        [JsonPropertyName("kills_goblin_weakling_melee")]
        public float? KillsGoblinWeaklingMelee { get; set; }

        [JsonPropertyName("kills_goblin_weakling_bow")]
        public float? KillsGoblinWeaklingBow { get; set; }

        [JsonPropertyName("kills_mushroom_cow")]
        public float? KillsMushroomCow { get; set; }

        [JsonPropertyName("kills_cow")]
        public float? KillsCow { get; set; }

        [JsonPropertyName("kills_trapper_pig")]
        public float? KillsTrapperPig { get; set; }

        [JsonPropertyName("kills_rabbit")]
        public float? KillsRabbit { get; set; }

        [JsonPropertyName("mythos_kills")]
        public float? MythosKills { get; set; }

        [JsonPropertyName("kills_minos_hunter")]
        public float? KillsMinosHunter { get; set; }

        [JsonPropertyName("kills_trapper_rabbit")]
        public float? KillsTrapperRabbit { get; set; }

        [JsonPropertyName("kills_trapper_chicken")]
        public float? KillsTrapperChicken { get; set; }

        [JsonPropertyName("kills_rat")]
        public float? KillsRat { get; set; }

        [JsonPropertyName("kills_crypt_tank_zombie")]
        public float? KillsCryptTankZombie { get; set; }

        [JsonPropertyName("kills_crypt_lurker")]
        public float? KillsCryptLurker { get; set; }

        [JsonPropertyName("kills_zombie_grunt")]
        public float? KillsZombieGrunt { get; set; }

        [JsonPropertyName("deaths_crypt_lurker")]
        public float? DeathsCryptLurker { get; set; }

        [JsonPropertyName("kills_scared_skeleton")]
        public float? KillsScaredSkeleton { get; set; }

        [JsonPropertyName("kills_dungeon_respawning_skeleton")]
        public float? KillsDungeonRespawningSkeleton { get; set; }

        [JsonPropertyName("deaths_sniper_skeleton")]
        public float? DeathsSniperSkeleton { get; set; }

        [JsonPropertyName("kills_skeleton_grunt")]
        public float? KillsSkeletonGrunt { get; set; }

        [JsonPropertyName("deaths_scared_skeleton")]
        public float? DeathsScaredSkeleton { get; set; }

        [JsonPropertyName("auctions_sold_legendary")]
        public float? AuctionsSoldLegendary { get; set; }

        [JsonPropertyName("auctions_bought_legendary")]
        public float? AuctionsBoughtLegendary { get; set; }

        [JsonPropertyName("kills_crypt_dreadlord")]
        public float? KillsCryptDreadlord { get; set; }

        [JsonPropertyName("deaths_skeleton_grunt")]
        public float? DeathsSkeletonGrunt { get; set; }

        [JsonPropertyName("deaths_crypt_dreadlord")]
        public float? DeathsCryptDreadlord { get; set; }

        [JsonPropertyName("deaths_zombie_grunt")]
        public float? DeathsZombieGrunt { get; set; }

        [JsonPropertyName("deaths_dungeon_respawning_skeleton")]
        public float? DeathsDungeonRespawningSkeleton { get; set; }

        [JsonPropertyName("kills_lost_adventurer")]
        public float? KillsLostAdventurer { get; set; }

        [JsonPropertyName("deaths_lost_adventurer")]
        public float? DeathsLostAdventurer { get; set; }

        [JsonPropertyName("kills_dungeon_secret_bat")]
        public float? KillsDungeonSecretBat { get; set; }

        [JsonPropertyName("deaths_crypt_souleater")]
        public float? DeathsCryptSouleater { get; set; }

        [JsonPropertyName("kills_lonely_spider")]
        public float? KillsLonelySpider { get; set; }

        [JsonPropertyName("deaths_trap")]
        public float? DeathsTrap { get; set; }

        [JsonPropertyName("kills_watcher_summon_undead")]
        public float? KillsWatcherSummonUndead { get; set; }

        [JsonPropertyName("deaths_skeleton_soldier")]
        public float? DeathsSkeletonSoldier { get; set; }

        [JsonPropertyName("deaths_crypt_undead")]
        public float? DeathsCryptUndead { get; set; }

        [JsonPropertyName("deaths_watcher_summon_undead")]
        public float? DeathsWatcherSummonUndead { get; set; }

        [JsonPropertyName("auctions_sold_uncommon")]
        public float? AuctionsSoldUncommon { get; set; }

        [JsonPropertyName("defense")]
        public double? Defense { get; set; }

        [JsonPropertyName("true_defense")]
        public double? TrueDefense { get; set; }

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
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public double? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public double? DamageIncrease { get; set; }

        [JsonPropertyName("times_played")]
        public float? TimesPlayed { get; set; }

        [JsonPropertyName("best_score")]
        public float? BestScore { get; set; }

        [JsonPropertyName("mobs_killed")]
        public float? MobsKilled { get; set; }

        [JsonPropertyName("most_mobs_killed")]
        public float? MostMobsKilled { get; set; }

        [JsonPropertyName("most_healing")]
        public double? MostHealing { get; set; }

        [JsonPropertyName("tier_completions")]
        public float? TierCompletions { get; set; }

        [JsonPropertyName("milestone_completions")]
        public float? MilestoneCompletions { get; set; }

        [JsonPropertyName("fastest_time")]
        public float? FastestTime { get; set; }

        [JsonPropertyName("watcher_kills")]
        public float? WatcherKills { get; set; }

        [JsonPropertyName("last_attempt")]
        public LastAttempt LastAttempt { get; set; }

        [JsonPropertyName("bonus_clicks")]
        public float? BonusClicks { get; set; }

        [JsonPropertyName("last_claimed")]
        public LastClaimed LastClaimed { get; set; }

        [JsonPropertyName("highest_crit_damage")]
        public double? HighestCritDamage { get; set; }

        [JsonPropertyName("deaths_spider")]
        public float? DeathsSpider { get; set; }

        [JsonPropertyName("deaths_skeleton")]
        public float? DeathsSkeleton { get; set; }

        [JsonPropertyName("auctions_sold_rare")]
        public float? AuctionsSoldRare { get; set; }

        [JsonPropertyName("true defense")]
        public object True_Defense { get; set; }

        [JsonPropertyName("deaths_invisible_creeper")]
        public float? DeathsInvisibleCreeper { get; set; }

        [JsonPropertyName("deaths_zombie_villager")]
        public float? DeathsZombieVillager { get; set; }

        [JsonPropertyName("deaths_ruin_wolf")]
        public float? DeathsRuinWolf { get; set; }

        [JsonPropertyName("deaths_splitter_spider")]
        public float? DeathsSplitterSpider { get; set; }

        [JsonPropertyName("kills_night_respawning_skeleton")]
        public float? KillsNightRespawningSkeleton { get; set; }

        [JsonPropertyName("kills_sea_archer")]
        public float? KillsSeaArcher { get; set; }

        [JsonPropertyName("items_fished")]
        public float? ItemsFished { get; set; }

        [JsonPropertyName("items_fished_normal")]
        public float? ItemsFishedNormal { get; set; }

        [JsonPropertyName("kills_sea_walker")]
        public float? KillsSeaWalker { get; set; }

        [JsonPropertyName("deaths_wither_skeleton")]
        public float? DeathsWitherSkeleton { get; set; }

        [JsonPropertyName("end_race_best_time")]
        public float? EndRaceBestTime { get; set; }

        [JsonPropertyName("kills_random_slime")]
        public float? KillsRandomSlime { get; set; }

        [JsonPropertyName("deaths_suffocation")]
        public float? DeathsSuffocation { get; set; }

        [JsonPropertyName("deaths_spider_jockey")]
        public float? DeathsSpiderJockey { get; set; }

        [JsonPropertyName("deaths_blaze")]
        public float? DeathsBlaze { get; set; }

        [JsonPropertyName("deaths_obsidian_wither")]
        public float? DeathsObsidianWither { get; set; }

        [JsonPropertyName("kills_forest_island_bat")]
        public float? KillsForestIslandBat { get; set; }

        [JsonPropertyName("kills_ghast")]
        public float? KillsGhast { get; set; }

        [JsonPropertyName("kills_generator_magma_cube")]
        public float? KillsGeneratorMagmaCube { get; set; }

        [JsonPropertyName("deaths_zealot_enderman")]
        public float? DeathsZealotEnderman { get; set; }

        [JsonPropertyName("items_fished_treasure")]
        public float? ItemsFishedTreasure { get; set; }

        [JsonPropertyName("kills_pond_squid")]
        public float? KillsPondSquid { get; set; }

        [JsonPropertyName("kills_sea_guardian")]
        public float? KillsSeaGuardian { get; set; }

        [JsonPropertyName("kills_endermite")]
        public float? KillsEndermite { get; set; }

        [JsonPropertyName("kills_watcher")]
        public float? KillsWatcher { get; set; }

        [JsonPropertyName("kills_obsidian_wither")]
        public float? KillsObsidianWither { get; set; }

        [JsonPropertyName("deaths_magma_cube_boss")]
        public float? DeathsMagmaCubeBoss { get; set; }

        [JsonPropertyName("kills_magma_cube_boss")]
        public float? KillsMagmaCubeBoss { get; set; }

        [JsonPropertyName("deaths_fireball_magma_cube")]
        public float? DeathsFireballMagmaCube { get; set; }

        [JsonPropertyName("kills_zealot_enderman")]
        public float? KillsZealotEnderman { get; set; }

        [JsonPropertyName("deaths_unburried_zombie")]
        public float? DeathsUnburriedZombie { get; set; }

        [JsonPropertyName("deaths_wolf")]
        public float? DeathsWolf { get; set; }

        [JsonPropertyName("kills_bat_pinata")]
        public float? KillsBatPinata { get; set; }

        [JsonPropertyName("kills_horseman_zombie")]
        public float? KillsHorsemanZombie { get; set; }

        [JsonPropertyName("kills_howling_spirit")]
        public float? KillsHowlingSpirit { get; set; }

        [JsonPropertyName("kills_soul_of_the_alpha")]
        public float? KillsSoulOfTheAlpha { get; set; }

        [JsonPropertyName("kills_pack_spirit")]
        public float? KillsPackSpirit { get; set; }

        [JsonPropertyName("deaths_soul_of_the_alpha")]
        public float? DeathsSoulOfTheAlpha { get; set; }

        [JsonPropertyName("deaths_unknown")]
        public float? DeathsUnknown { get; set; }

        [JsonPropertyName("kills_creeper")]
        public float? KillsCreeper { get; set; }

        [JsonPropertyName("deaths_wise_dragon")]
        public float? DeathsWiseDragon { get; set; }

        [JsonPropertyName("ender_crystals_destroyed")]
        public float? EnderCrystalsDestroyed { get; set; }

        [JsonPropertyName("deaths_watcher")]
        public float? DeathsWatcher { get; set; }

        [JsonPropertyName("kills_horseman_bat")]
        public float? KillsHorsemanBat { get; set; }

        [JsonPropertyName("kills_zombie_deep")]
        public float? KillsZombieDeep { get; set; }

        [JsonPropertyName("deaths_young_dragon")]
        public float? DeathsYoungDragon { get; set; }

        [JsonPropertyName("deaths_unstable_dragon")]
        public float? DeathsUnstableDragon { get; set; }

        [JsonPropertyName("kills_liquid_hot_magma")]
        public float? KillsLiquidHotMagma { get; set; }

        [JsonPropertyName("most_winter_snowballs_hit")]
        public float? MostWinterSnowballsHit { get; set; }

        [JsonPropertyName("most_winter_damage_dealt")]
        public float? MostWinterDamageDealt { get; set; }

        [JsonPropertyName("most_winter_magma_damage_dealt")]
        public float? MostWinterMagmaDamageDealt { get; set; }

        [JsonPropertyName("deaths_player")]
        public float? DeathsPlayer { get; set; }

        [JsonPropertyName("kills_strong_dragon")]
        public float? KillsStrongDragon { get; set; }

        [JsonPropertyName("kills_generator_ghast")]
        public float? KillsGeneratorGhast { get; set; }

        [JsonPropertyName("kills_player")]
        public float? KillsPlayer { get; set; }

        [JsonPropertyName("most_winter_cannonballs_hit")]
        public float? MostWinterCannonballsHit { get; set; }

        [JsonPropertyName("items_fished_large_treasure")]
        public float? ItemsFishedLargeTreasure { get; set; }

        [JsonPropertyName("kills_catfish")]
        public float? KillsCatfish { get; set; }

        [JsonPropertyName("kills_guardian_defender")]
        public float? KillsGuardianDefender { get; set; }

        [JsonPropertyName("kills_deep_sea_protector")]
        public float? KillsDeepSeaProtector { get; set; }

        [JsonPropertyName("kills_frosty_the_snowman")]
        public float? KillsFrostyTheSnowman { get; set; }

        [JsonPropertyName("kills_sea_leech")]
        public float? KillsSeaLeech { get; set; }

        [JsonPropertyName("kills_frozen_steve")]
        public float? KillsFrozenSteve { get; set; }

        [JsonPropertyName("kills_chicken_deep")]
        public float? KillsChickenDeep { get; set; }

        [JsonPropertyName("kills_night_squid")]
        public float? KillsNightSquid { get; set; }

        [JsonPropertyName("kills_horseman_horse")]
        public float? KillsHorsemanHorse { get; set; }

        [JsonPropertyName("kills_revenant_zombie")]
        public float? KillsRevenantZombie { get; set; }

        [JsonPropertyName("deaths_magma_cube")]
        public float? DeathsMagmaCube { get; set; }

        [JsonPropertyName("pet_milestone_sea_creatures_killed")]
        public float? PetMilestoneSeaCreaturesKilled { get; set; }

        [JsonPropertyName("kills_water_hydra")]
        public float? KillsWaterHydra { get; set; }

        [JsonPropertyName("kills_generator_slime")]
        public float? KillsGeneratorSlime { get; set; }

        [JsonPropertyName("deaths_liquid_hot_magma")]
        public float? DeathsLiquidHotMagma { get; set; }

        [JsonPropertyName("kills_cave_spider")]
        public float? KillsCaveSpider { get; set; }

        [JsonPropertyName("deaths_revenant_zombie")]
        public float? DeathsRevenantZombie { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_anything_no_return_best_time")]
        public float? DungeonHubCrystalCoreAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_giant_mushroom_anything_no_return_best_time")]
        public float? DungeonHubGiantMushroomAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_precursor_ruins_anything_no_return_best_time")]
        public float? DungeonHubPrecursorRuinsAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_no_pearls_no_return_best_time")]
        public float? DungeonHubCrystalCoreNoPearlsNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_no_abilities_no_return_best_time")]
        public float? DungeonHubCrystalCoreNoAbilitiesNoReturnBestTime { get; set; }

        [JsonPropertyName("kills_tarantula_spider")]
        public float? KillsTarantulaSpider { get; set; }

        [JsonPropertyName("kills_skeleton_soldier")]
        public float? KillsSkeletonSoldier { get; set; }

        [JsonPropertyName("kills_crypt_undead")]
        public float? KillsCryptUndead { get; set; }

        [JsonPropertyName("kills_crypt_souleater")]
        public float? KillsCryptSouleater { get; set; }

        [JsonPropertyName("kills_diamond_guy")]
        public float? KillsDiamondGuy { get; set; }

        [JsonPropertyName("kills_sniper_skeleton")]
        public float? KillsSniperSkeleton { get; set; }

        [JsonPropertyName("kills_bonzo_summon_undead")]
        public float? KillsBonzoSummonUndead { get; set; }

        [JsonPropertyName("kills_skeleton_master")]
        public float? KillsSkeletonMaster { get; set; }

        [JsonPropertyName("deaths_skeleton_master")]
        public float? DeathsSkeletonMaster { get; set; }

        [JsonPropertyName("kills_parasite")]
        public float? KillsParasite { get; set; }

        [JsonPropertyName("deaths_scarf_mage")]
        public float? DeathsScarfMage { get; set; }

        [JsonPropertyName("kills_cellar_spider")]
        public float? KillsCellarSpider { get; set; }

        [JsonPropertyName("deaths_bonzo")]
        public float? DeathsBonzo { get; set; }

        [JsonPropertyName("kills_crypt_undead_nicholas")]
        public float? KillsCryptUndeadNicholas { get; set; }

        [JsonPropertyName("deaths_drowning")]
        public float? DeathsDrowning { get; set; }

        [JsonPropertyName("kills_crypt_undead_alexander")]
        public float? KillsCryptUndeadAlexander { get; set; }

        [JsonPropertyName("kills_crypt_undead_friedrich")]
        public float? KillsCryptUndeadFriedrich { get; set; }

        [JsonPropertyName("kills_headless_horseman")]
        public float? KillsHeadlessHorseman { get; set; }

        [JsonPropertyName("kills_crypt_undead_marius")]
        public float? KillsCryptUndeadMarius { get; set; }

        [JsonPropertyName("kills_carrot_king")]
        public float? KillsCarrotKing { get; set; }

        [JsonPropertyName("deaths_tarantula_spider")]
        public float? DeathsTarantulaSpider { get; set; }

        [JsonPropertyName("kills_crypt_undead_christian")]
        public float? KillsCryptUndeadChristian { get; set; }

        [JsonPropertyName("kills_skeleton_emperor")]
        public float? KillsSkeletonEmperor { get; set; }

        [JsonPropertyName("kills_sea_witch")]
        public float? KillsSeaWitch { get; set; }

        [JsonPropertyName("kills_crypt_undead_valentin")]
        public float? KillsCryptUndeadValentin { get; set; }

        [JsonPropertyName("kills_grinch")]
        public float? KillsGrinch { get; set; }

        [JsonPropertyName("kills_guardian_emperor")]
        public float? KillsGuardianEmperor { get; set; }

        [JsonPropertyName("deaths_superior_dragon")]
        public float? DeathsSuperiorDragon { get; set; }

        [JsonPropertyName("kills_blaze_higher_or_lower")]
        public float? KillsBlazeHigherOrLower { get; set; }

        [JsonPropertyName("deaths_scarf_warrior")]
        public float? DeathsScarfWarrior { get; set; }

        [JsonPropertyName("deaths_scarf")]
        public float? DeathsScarf { get; set; }

        [JsonPropertyName("kills_scarf_mage")]
        public float? KillsScarfMage { get; set; }

        [JsonPropertyName("kills_crypt_undead_bernhard")]
        public float? KillsCryptUndeadBernhard { get; set; }

        [JsonPropertyName("kills_scary_jerry")]
        public float? KillsScaryJerry { get; set; }

        [JsonPropertyName("kills_batty_witch")]
        public float? KillsBattyWitch { get; set; }

        [JsonPropertyName("kills_wither_gourd")]
        public float? KillsWitherGourd { get; set; }

        [JsonPropertyName("kills_trick_or_treater")]
        public float? KillsTrickOrTreater { get; set; }

        [JsonPropertyName("kills_phantom_spirit")]
        public float? KillsPhantomSpirit { get; set; }

        [JsonPropertyName("kills_wraith")]
        public float? KillsWraith { get; set; }

        [JsonPropertyName("auctions_bought_special")]
        public float? AuctionsBoughtSpecial { get; set; }

        [JsonPropertyName("shredder_bait")]
        public float? ShredderBait { get; set; }

        [JsonPropertyName("shredder_fished")]
        public float? ShredderFished { get; set; }

        [JsonPropertyName("kills_nurse_shark")]
        public float? KillsNurseShark { get; set; }

        [JsonPropertyName("kills_blue_shark")]
        public float? KillsBlueShark { get; set; }

        [JsonPropertyName("kills_tiger_shark")]
        public float? KillsTigerShark { get; set; }

        [JsonPropertyName("kills_crypt_undead_pieter")]
        public float? KillsCryptUndeadPieter { get; set; }

        [JsonPropertyName("kills_bat_spooky")]
        public float? KillsBatSpooky { get; set; }

        [JsonPropertyName("kills_scarecrow")]
        public float? KillsScarecrow { get; set; }

        [JsonPropertyName("kills_werewolf")]
        public float? KillsWerewolf { get; set; }

        [JsonPropertyName("kills_nightmare")]
        public float? KillsNightmare { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next")]
        public float? MythosBurrowsDugNext { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_null")]
        public float? MythosBurrowsDugNextNull { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat")]
        public float? MythosBurrowsDugCombat { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_null")]
        public float? MythosBurrowsDugCombatNull { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure")]
        public float? MythosBurrowsDugTreasure { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_null")]
        public float? MythosBurrowsDugTreasureNull { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete")]
        public float? MythosBurrowsChainsComplete { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_null")]
        public float? MythosBurrowsChainsCompleteNull { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_COMMON")]
        public float? MythosBurrowsDugNextCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_COMMON")]
        public float? MythosBurrowsDugCombatCOMMON { get; set; }

        [JsonPropertyName("kills_siamese_lynx")]
        public float? KillsSiameseLynx { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_COMMON")]
        public float? MythosBurrowsDugTreasureCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_COMMON")]
        public float? MythosBurrowsChainsCompleteCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_UNCOMMON")]
        public float? MythosBurrowsDugNextUNCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_UNCOMMON")]
        public float? MythosBurrowsDugCombatUNCOMMON { get; set; }

        [JsonPropertyName("kills_minotaur")]
        public float? KillsMinotaur { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_UNCOMMON")]
        public float? MythosBurrowsDugTreasureUNCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_UNCOMMON")]
        public float? MythosBurrowsChainsCompleteUNCOMMON { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_RARE")]
        public float? MythosBurrowsDugNextRARE { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_RARE")]
        public float? MythosBurrowsDugCombatRARE { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_RARE")]
        public float? MythosBurrowsDugTreasureRARE { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_RARE")]
        public float? MythosBurrowsChainsCompleteRARE { get; set; }

        [JsonPropertyName("kills_gaia_construct")]
        public float? KillsGaiaConstruct { get; set; }

        [JsonPropertyName("deaths_minotaur")]
        public float? DeathsMinotaur { get; set; }

        [JsonPropertyName("deaths_gaia_construct")]
        public float? DeathsGaiaConstruct { get; set; }

        [JsonPropertyName("kills_mayor_jerry_blue")]
        public float? KillsMayorJerryBlue { get; set; }

        [JsonPropertyName("kills_mayor_jerry_golden")]
        public float? KillsMayorJerryGolden { get; set; }

        [JsonPropertyName("kills_mayor_jerry_purple")]
        public float? KillsMayorJerryPurple { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_EPIC")]
        public float? MythosBurrowsDugNextEPIC { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_EPIC")]
        public float? MythosBurrowsDugCombatEPIC { get; set; }

        [JsonPropertyName("kills_minos_champion")]
        public float? KillsMinosChampion { get; set; }

        [JsonPropertyName("mythos_burrows_dug_treasure_EPIC")]
        public float? MythosBurrowsDugTreasureEPIC { get; set; }

        [JsonPropertyName("mythos_burrows_chains_complete_EPIC")]
        public float? MythosBurrowsChainsCompleteEPIC { get; set; }

        [JsonPropertyName("kills_ice_walker")]
        public float? KillsIceWalker { get; set; }

        [JsonPropertyName("kills_treasure_hoarder")]
        public float? KillsTreasureHoarder { get; set; }

        [JsonPropertyName("kills_goblin_golem")]
        public float? KillsGoblinGolem { get; set; }

        [JsonPropertyName("kills_goblin_battler")]
        public float? KillsGoblinBattler { get; set; }

        [JsonPropertyName("kills_goblin_creepertamer")]
        public float? KillsGoblinCreepertamer { get; set; }

        [JsonPropertyName("kills_goblin_creeper")]
        public float? KillsGoblinCreeper { get; set; }

        [JsonPropertyName("deaths_caverns_ghost")]
        public float? DeathsCavernsGhost { get; set; }

        [JsonPropertyName("kills_zombie_soldier")]
        public float? KillsZombieSoldier { get; set; }

        [JsonPropertyName("kills_zombie_knight")]
        public float? KillsZombieKnight { get; set; }

        [JsonPropertyName("kills_skeletor")]
        public float? KillsSkeletor { get; set; }

        [JsonPropertyName("deaths_deathmite")]
        public float? DeathsDeathmite { get; set; }

        [JsonPropertyName("deaths_diamond_guy")]
        public float? DeathsDiamondGuy { get; set; }

        [JsonPropertyName("kills_scarf_warrior")]
        public float? KillsScarfWarrior { get; set; }

        [JsonPropertyName("kills_shadow_assassin")]
        public float? KillsShadowAssassin { get; set; }

        [JsonPropertyName("kills_professor_guardian_summon")]
        public float? KillsProfessorGuardianSummon { get; set; }

        [JsonPropertyName("deaths_tiger_shark")]
        public float? DeathsTigerShark { get; set; }

        [JsonPropertyName("kills_goblin_murderlover")]
        public float? KillsGoblinMurderlover { get; set; }

        [JsonPropertyName("kills_crystal_sentry")]
        public float? KillsCrystalSentry { get; set; }

        [JsonPropertyName("kills_powder_ghast")]
        public float? KillsPowderGhast { get; set; }

        [JsonPropertyName("deaths_wither_gourd")]
        public float? DeathsWitherGourd { get; set; }

        [JsonPropertyName("deaths_goblin_murderlover")]
        public float? DeathsGoblinMurderlover { get; set; }

        [JsonPropertyName("kills_caverns_ghost")]
        public float? KillsCavernsGhost { get; set; }

        [JsonPropertyName("deaths_ice_walker")]
        public float? DeathsIceWalker { get; set; }

        [JsonPropertyName("deaths_treasure_hoarder")]
        public float? DeathsTreasureHoarder { get; set; }

        [JsonPropertyName("kills_arachne_brood")]
        public float? KillsArachneBrood { get; set; }

        [JsonPropertyName("deaths_arachne_keeper")]
        public float? DeathsArachneKeeper { get; set; }

        [JsonPropertyName("deaths_arachne_brood")]
        public float? DeathsArachneBrood { get; set; }

        [JsonPropertyName("deaths_arachne")]
        public float? DeathsArachne { get; set; }

        [JsonPropertyName("kills_arachne_keeper")]
        public float? KillsArachneKeeper { get; set; }

        [JsonPropertyName("deaths_witch_bat")]
        public float? DeathsWitchBat { get; set; }

        [JsonPropertyName("deaths_phantom_spirit")]
        public float? DeathsPhantomSpirit { get; set; }

        [JsonPropertyName("kills_dante_goon")]
        public float? KillsDanteGoon { get; set; }

        [JsonPropertyName("kills_dante_slime_goon")]
        public float? KillsDanteSlimeGoon { get; set; }

        [JsonPropertyName("kills_trapper_sheep")]
        public float? KillsTrapperSheep { get; set; }

        [JsonPropertyName("kills_trapper_cow")]
        public float? KillsTrapperCow { get; set; }

        [JsonPropertyName("deaths_watcher_bonzo")]
        public float? DeathsWatcherBonzo { get; set; }

        [JsonPropertyName("kills_watcher_bonzo")]
        public float? KillsWatcherBonzo { get; set; }

        [JsonPropertyName("deaths_professor_mage_guardian")]
        public float? DeathsProfessorMageGuardian { get; set; }

        [JsonPropertyName("kills_yeti")]
        public float? KillsYeti { get; set; }

        [JsonPropertyName("kills_oasis_sheep")]
        public float? KillsOasisSheep { get; set; }

        [JsonPropertyName("kills_shrine_charged_creeper")]
        public float? KillsShrineChargedCreeper { get; set; }

        [JsonPropertyName("kills_oasis_rabbit")]
        public float? KillsOasisRabbit { get; set; }

        [JsonPropertyName("kills_arachne")]
        public float? KillsArachne { get; set; }

        [JsonPropertyName("deaths_scary_jerry")]
        public float? DeathsScaryJerry { get; set; }

        [JsonPropertyName("kills_scarf_archer")]
        public float? KillsScarfArcher { get; set; }

        [JsonPropertyName("kills_scarf_priest")]
        public float? KillsScarfPriest { get; set; }

        [JsonPropertyName("deaths_shadow_assassin")]
        public float? DeathsShadowAssassin { get; set; }

        [JsonPropertyName("kills_voidling_fanatic")]
        public float? KillsVoidlingFanatic { get; set; }

        [JsonPropertyName("deaths_lonely_spider")]
        public float? DeathsLonelySpider { get; set; }

        [JsonPropertyName("kills_super_tank_zombie")]
        public float? KillsSuperTankZombie { get; set; }

        [JsonPropertyName("kills_spirit_bull")]
        public float? KillsSpiritBull { get; set; }

        [JsonPropertyName("kills_spirit_bat")]
        public float? KillsSpiritBat { get; set; }

        [JsonPropertyName("kills_spirit_sheep")]
        public float? KillsSpiritSheep { get; set; }

        [JsonPropertyName("kills_spirit_wolf")]
        public float? KillsSpiritWolf { get; set; }

        [JsonPropertyName("kills_spirit_rabbit")]
        public float? KillsSpiritRabbit { get; set; }

        [JsonPropertyName("kills_spirit_miniboss")]
        public float? KillsSpiritMiniboss { get; set; }

        [JsonPropertyName("deaths_spirit_rabbit")]
        public float? DeathsSpiritRabbit { get; set; }

        [JsonPropertyName("kills_tentaclees")]
        public float? KillsTentaclees { get; set; }

        [JsonPropertyName("deaths_livid_clone")]
        public float? DeathsLividClone { get; set; }

        [JsonPropertyName("deaths_skeletor")]
        public float? DeathsSkeletor { get; set; }

        [JsonPropertyName("kills_super_archer")]
        public float? KillsSuperArcher { get; set; }

        [JsonPropertyName("deaths_spirit_bat")]
        public float? DeathsSpiritBat { get; set; }

        [JsonPropertyName("deaths_spirit_chicken")]
        public float? DeathsSpiritChicken { get; set; }

        [JsonPropertyName("kills_spirit_chicken")]
        public float? KillsSpiritChicken { get; set; }

        [JsonPropertyName("kills_crypt_witherskeleton")]
        public float? KillsCryptWitherskeleton { get; set; }

        [JsonPropertyName("deaths_spirit_bull")]
        public float? DeathsSpiritBull { get; set; }

        [JsonPropertyName("deaths_watcher_guardian")]
        public float? DeathsWatcherGuardian { get; set; }

        [JsonPropertyName("kills_zombie_commander")]
        public float? KillsZombieCommander { get; set; }

        [JsonPropertyName("kills_mimic")]
        public float? KillsMimic { get; set; }

        [JsonPropertyName("deaths_sadan_golem")]
        public float? DeathsSadanGolem { get; set; }

        [JsonPropertyName("deaths_tentaclees")]
        public float? DeathsTentaclees { get; set; }

        [JsonPropertyName("deaths_sadan_statue")]
        public float? DeathsSadanStatue { get; set; }

        [JsonPropertyName("kills_skeletor_prime")]
        public float? KillsSkeletorPrime { get; set; }

        [JsonPropertyName("kills_sadan_statue")]
        public float? KillsSadanStatue { get; set; }

        [JsonPropertyName("kills_sadan_golem")]
        public float? KillsSadanGolem { get; set; }

        [JsonPropertyName("deaths_mimic")]
        public float? DeathsMimic { get; set; }

        [JsonPropertyName("kills_watcher_scarf")]
        public float? KillsWatcherScarf { get; set; }

        [JsonPropertyName("kills_king_midas")]
        public float? KillsKingMidas { get; set; }

        [JsonPropertyName("deaths_professor_guardian_summon")]
        public float? DeathsProfessorGuardianSummon { get; set; }

        [JsonPropertyName("kills_protector_dragon")]
        public float? KillsProtectorDragon { get; set; }

        [JsonPropertyName("kills_corrupted_protector")]
        public float? KillsCorruptedProtector { get; set; }

        [JsonPropertyName("kills_voidling_extremist")]
        public float? KillsVoidlingExtremist { get; set; }

        [JsonPropertyName("auctions_sold_special")]
        public float? AuctionsSoldSpecial { get; set; }

        [JsonPropertyName("deaths_professor")]
        public float? DeathsProfessor { get; set; }

        [JsonPropertyName("deaths_kalhuiki_tribe_man")]
        public float? DeathsKalhuikiTribeMan { get; set; }

        [JsonPropertyName("kills_sludge")]
        public float? KillsSludge { get; set; }

        [JsonPropertyName("deaths_yog")]
        public float? DeathsYog { get; set; }

        [JsonPropertyName("kills_yog")]
        public float? KillsYog { get; set; }

        [JsonPropertyName("kills_trapped_sludge")]
        public float? KillsTrappedSludge { get; set; }

        [JsonPropertyName("kills_team_treasurite_viper")]
        public float? KillsTeamTreasuriteViper { get; set; }

        [JsonPropertyName("kills_team_treasurite_grunt")]
        public float? KillsTeamTreasuriteGrunt { get; set; }

        [JsonPropertyName("kills_team_treasurite_sebastian")]
        public float? KillsTeamTreasuriteSebastian { get; set; }

        [JsonPropertyName("kills_automaton")]
        public float? KillsAutomaton { get; set; }

        [JsonPropertyName("kills_team_treasurite_wendy")]
        public float? KillsTeamTreasuriteWendy { get; set; }

        [JsonPropertyName("kills_belle")]
        public float? KillsBelle { get; set; }

        [JsonPropertyName("kills_cavitak")]
        public float? KillsCavitak { get; set; }

        [JsonPropertyName("kills_goblin_flamethrower")]
        public float? KillsGoblinFlamethrower { get; set; }

        [JsonPropertyName("kills_vittomite")]
        public float? KillsVittomite { get; set; }

        [JsonPropertyName("kills_fire_bat")]
        public float? KillsFireBat { get; set; }

        [JsonPropertyName("kills_butterfly")]
        public float? KillsButterfly { get; set; }

        [JsonPropertyName("kills_sadan_giant")]
        public float? KillsSadanGiant { get; set; }

        [JsonPropertyName("deaths_sadan_giant")]
        public float? DeathsSadanGiant { get; set; }

        [JsonPropertyName("kills_silvo")]
        public float? KillsSilvo { get; set; }

        [JsonPropertyName("kills_thyst")]
        public float? KillsThyst { get; set; }

        [JsonPropertyName("kills_key_guardian")]
        public float? KillsKeyGuardian { get; set; }

        [JsonPropertyName("deaths_wraith")]
        public float? DeathsWraith { get; set; }

        [JsonPropertyName("deaths_livid")]
        public float? DeathsLivid { get; set; }

        [JsonPropertyName("kills_kalhuiki_tribe_woman")]
        public float? KillsKalhuikiTribeWoman { get; set; }

        [JsonPropertyName("kills_kalhuiki_tribe_man")]
        public float? KillsKalhuikiTribeMan { get; set; }

        [JsonPropertyName("kills_worm")]
        public float? KillsWorm { get; set; }

        [JsonPropertyName("kills_skeleton_lord")]
        public float? KillsSkeletonLord { get; set; }

        [JsonPropertyName("kills_zombie_lord")]
        public float? KillsZombieLord { get; set; }

        [JsonPropertyName("kills_wither_miner")]
        public float? KillsWitherMiner { get; set; }

        [JsonPropertyName("deaths_maxor")]
        public float? DeathsMaxor { get; set; }

        [JsonPropertyName("kills_wither_guard")]
        public float? KillsWitherGuard { get; set; }

        [JsonPropertyName("deaths_wither_miner")]
        public float? DeathsWitherMiner { get; set; }

        [JsonPropertyName("kills_smog")]
        public float? KillsSmog { get; set; }

        [JsonPropertyName("kills_team_treasurite_corleone")]
        public float? KillsTeamTreasuriteCorleone { get; set; }

        [JsonPropertyName("deaths_cellar_spider")]
        public float? DeathsCellarSpider { get; set; }

        [JsonPropertyName("kills_lava_blaze")]
        public float? KillsLavaBlaze { get; set; }

        [JsonPropertyName("kills_lava_pigman")]
        public float? KillsLavaPigman { get; set; }

        [JsonPropertyName("deaths_watcher_scarf")]
        public float? DeathsWatcherScarf { get; set; }

        [JsonPropertyName("deaths_kalhuiki_tribe_woman")]
        public float? DeathsKalhuikiTribeWoman { get; set; }

        [JsonPropertyName("deaths_voidling_extremist")]
        public float? DeathsVoidlingExtremist { get; set; }

        [JsonPropertyName("kills_flaming_worm")]
        public float? KillsFlamingWorm { get; set; }

        [JsonPropertyName("deaths_automaton")]
        public float? DeathsAutomaton { get; set; }

        [JsonPropertyName("kills_great_white_shark")]
        public float? KillsGreatWhiteShark { get; set; }

        [JsonPropertyName("deaths_entity")]
        public float? DeathsEntity { get; set; }

        [JsonPropertyName("kills_young_dragon")]
        public float? KillsYoungDragon { get; set; }

        [JsonPropertyName("kills_watcher_livid")]
        public float? KillsWatcherLivid { get; set; }

        [JsonPropertyName("deaths_sadan")]
        public float? DeathsSadan { get; set; }

        [JsonPropertyName("deaths_dasher_spider")]
        public float? DeathsDasherSpider { get; set; }

        [JsonPropertyName("mythos_burrows_dug_next_LEGENDARY")]
        public float? MythosBurrowsDugNextLEGENDARY { get; set; }

        [JsonPropertyName("mythos_burrows_dug_combat_LEGENDARY")]
        public float? MythosBurrowsDugCombatLEGENDARY { get; set; }

        [JsonPropertyName("deaths_minos_inquisitor")]
        public float? DeathsMinosInquisitor { get; set; }

        [JsonPropertyName("deaths_minos_champion")]
        public float? DeathsMinosChampion { get; set; }

        [JsonPropertyName("kills_watcher_giant_laser")]
        public float? KillsWatcherGiantLaser { get; set; }

        [JsonPropertyName("kills_watcher_giant_boulder")]
        public float? KillsWatcherGiantBoulder { get; set; }

        [JsonPropertyName("kills_watcher_giant_bigfoot")]
        public float? KillsWatcherGiantBigfoot { get; set; }

        [JsonPropertyName("kills_watcher_giant_diamond")]
        public float? KillsWatcherGiantDiamond { get; set; }

        [JsonPropertyName("kills_scatha")]
        public float? KillsScatha { get; set; }

        [JsonPropertyName("kills_master_crypt_tank_zombie")]
        public float? KillsMasterCryptTankZombie { get; set; }

        [JsonPropertyName("kills_master_zombie_grunt")]
        public float? KillsMasterZombieGrunt { get; set; }

        [JsonPropertyName("kills_master_crypt_lurker")]
        public float? KillsMasterCryptLurker { get; set; }

        [JsonPropertyName("kills_master_skeleton_soldier")]
        public float? KillsMasterSkeletonSoldier { get; set; }

        [JsonPropertyName("kills_master_dungeon_respawning_skeleton")]
        public float? KillsMasterDungeonRespawningSkeleton { get; set; }

        [JsonPropertyName("kills_master_crypt_dreadlord")]
        public float? KillsMasterCryptDreadlord { get; set; }

        [JsonPropertyName("kills_master_scared_skeleton")]
        public float? KillsMasterScaredSkeleton { get; set; }

        [JsonPropertyName("kills_master_skeleton_grunt")]
        public float? KillsMasterSkeletonGrunt { get; set; }

        [JsonPropertyName("deaths_master_crypt_lurker")]
        public float? DeathsMasterCryptLurker { get; set; }

        [JsonPropertyName("kills_master_sniper_skeleton")]
        public float? KillsMasterSniperSkeleton { get; set; }

        [JsonPropertyName("kills_master_crypt_souleater")]
        public float? KillsMasterCryptSouleater { get; set; }

        [JsonPropertyName("deaths_master_dungeon_respawning_skeleton")]
        public float? DeathsMasterDungeonRespawningSkeleton { get; set; }

        [JsonPropertyName("kills_master_lost_adventurer")]
        public float? KillsMasterLostAdventurer { get; set; }

        [JsonPropertyName("kills_master_crypt_undead")]
        public float? KillsMasterCryptUndead { get; set; }

        [JsonPropertyName("kills_master_crypt_undead_nicholas")]
        public float? KillsMasterCryptUndeadNicholas { get; set; }

        [JsonPropertyName("kills_master_watcher_summon_undead")]
        public float? KillsMasterWatcherSummonUndead { get; set; }

        [JsonPropertyName("deaths_master_bonzo_summon_undead")]
        public float? DeathsMasterBonzoSummonUndead { get; set; }

        [JsonPropertyName("kills_master_diamond_guy")]
        public float? KillsMasterDiamondGuy { get; set; }

        [JsonPropertyName("deaths_master_crypt_dreadlord")]
        public float? DeathsMasterCryptDreadlord { get; set; }

        [JsonPropertyName("kills_master_cellar_spider")]
        public float? KillsMasterCellarSpider { get; set; }

        [JsonPropertyName("deaths_master_diamond_guy")]
        public float? DeathsMasterDiamondGuy { get; set; }

        [JsonPropertyName("deaths_master_sniper_skeleton")]
        public float? DeathsMasterSniperSkeleton { get; set; }

        [JsonPropertyName("deaths_master_watcher_summon_undead")]
        public float? DeathsMasterWatcherSummonUndead { get; set; }

        [JsonPropertyName("deaths_master_bonzo")]
        public float? DeathsMasterBonzo { get; set; }

        [JsonPropertyName("deaths_master_crypt_souleater")]
        public float? DeathsMasterCryptSouleater { get; set; }

        [JsonPropertyName("deaths_master_scared_skeleton")]
        public float? DeathsMasterScaredSkeleton { get; set; }

        [JsonPropertyName("deaths_master_zombie_grunt")]
        public float? DeathsMasterZombieGrunt { get; set; }

        [JsonPropertyName("deaths_master_scarf_warrior")]
        public float? DeathsMasterScarfWarrior { get; set; }

        [JsonPropertyName("deaths_master_scarf")]
        public float? DeathsMasterScarf { get; set; }

        [JsonPropertyName("deaths_skeletor_prime")]
        public float? DeathsSkeletorPrime { get; set; }

        [JsonPropertyName("deaths_super_archer")]
        public float? DeathsSuperArcher { get; set; }

        [JsonPropertyName("kills_master_crypt_undead_alexander")]
        public float? KillsMasterCryptUndeadAlexander { get; set; }

        [JsonPropertyName("deaths_master_lost_adventurer")]
        public float? DeathsMasterLostAdventurer { get; set; }

        [JsonPropertyName("kills_master_lonely_spider")]
        public float? KillsMasterLonelySpider { get; set; }

        [JsonPropertyName("kills_master_bonzo_summon_undead")]
        public float? KillsMasterBonzoSummonUndead { get; set; }

        [JsonPropertyName("deaths_crypt_witherskeleton")]
        public float? DeathsCryptWitherskeleton { get; set; }

        [JsonPropertyName("fastest_time_s")]
        public float? FastestTimeS { get; set; }

        [JsonPropertyName("fastest_time_s_plus")]
        public float? FastestTimeSPlus { get; set; }

        [JsonPropertyName("deaths_siamese_lynx")]
        public float? DeathsSiameseLynx { get; set; }

        [JsonPropertyName("deaths_goblin_weakling_melee")]
        public float? DeathsGoblinWeaklingMelee { get; set; }

        [JsonPropertyName("deaths_crystal_sentry")]
        public float? DeathsCrystalSentry { get; set; }

        [JsonPropertyName("deaths_respawning_skeleton")]
        public float? DeathsRespawningSkeleton { get; set; }

        [JsonPropertyName("deaths_sea_walker")]
        public float? DeathsSeaWalker { get; set; }

        [JsonPropertyName("deaths_sea_witch")]
        public float? DeathsSeaWitch { get; set; }

        [JsonPropertyName("deaths_sea_archer")]
        public float? DeathsSeaArcher { get; set; }
    }

    public class CollectLog
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToGuide
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class PublicIsland
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CraftWorkbench
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ExploreHub
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class ExploreVillage
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToLibrarian
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToFarmer
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToBlacksmith
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToLumberjack
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToEventMaster
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToAuctionMaster
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToBanker
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToFairy
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFisherman1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToCarpenter
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToArtist1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class PaintCanvas
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToPetCollector
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToPetSitter
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CraftWoodPickaxe
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class DepositCoins
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ChopTree
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToLumberjack2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToLazyMiner
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class IncreaseMiningSkill5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToTelekinesisApplier
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindPickaxe
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectIngots
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToLapisMiner
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class EnchantItem
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class GiveFairySouls
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseForagingSkill5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToGustave1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class CollectDarkOakLogs
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheWoodsRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGustave2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheWoodsRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFarmhand1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class IncreaseFarmingSkill5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class WarpMushroomDesert
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CraftWheatMinion
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectFarmingResources2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ReachLapisQuarry
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectLapis
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectRedstone
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectEmerald
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectDiamond
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectObsidian
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineCoal
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToBlacksmith2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseMiningSkill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ReforgeItem
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class WarpGoldMine
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToArtist2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectWoolCarpenter
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToCharlie2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFrosty
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGulliver1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class CompleteTheChickenRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGulliver2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheChickenRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGulliver3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheChickenRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseCombatSkill5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToRick
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class WarpTheEnd
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class WarpBlazingFortress
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuber1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToEndDealer
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class CollectEndStone
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheEndRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FightDragon
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class GiveRickIngots
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectFarmAnimalResources2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToRhys
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class IncreaseMining12
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class HotmGiveMaterials
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("started")]
        public bool Started { get; set; }

        [JsonPropertyName("ENCHANTED_REDSTONE")]
        public float? ENCHANTEDREDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_LAPIS_LAZULI")]
        public float? ENCHANTEDLAPISLAZULI { get; set; }

        [JsonPropertyName("ENCHANTED_EMERALD")]
        public float? ENCHANTEDEMERALD { get; set; }

        [JsonPropertyName("ENCHANTED_COAL")]
        public float? ENCHANTEDCOAL { get; set; }
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
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("kills")]
        public Kills Kills { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public float? BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public float? BossKillsTier1 { get; set; }

        [JsonPropertyName("boss_kills_tier_2")]
        public float? BossKillsTier2 { get; set; }

        [JsonPropertyName("boss_kills_tier_3")]
        public float? BossKillsTier3 { get; set; }
    }

    public class Wolf
    {
        [JsonPropertyName("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("kills")]
        public Kills Kills { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public float? BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public float? BossKillsTier1 { get; set; }

        [JsonPropertyName("boss_kills_tier_2")]
        public float? BossKillsTier2 { get; set; }

        [JsonPropertyName("boss_kills_tier_3")]
        public float? BossKillsTier3 { get; set; }
    }

    public class Zombie
    {
        [JsonPropertyName("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("kills")]
        public Kills Kills { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public float? BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public float? BossKillsTier1 { get; set; }

        [JsonPropertyName("boss_kills_tier_2")]
        public float? BossKillsTier2 { get; set; }

        [JsonPropertyName("boss_kills_tier_3")]
        public float? BossKillsTier3 { get; set; }
    }

    public class Enderman
    {
        [JsonPropertyName("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }

        [JsonPropertyName("level")]
        public Level Level { get; set; }

        [JsonPropertyName("kills")]
        public Kills Kills { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public float? BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public float? BossKillsTier1 { get; set; }
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
        public double? LevelProperty { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("xpMaxLevel")]
        public double? XpMaxLevel { get; set; }

        [JsonPropertyName("currentLevel")]
        public float? CurrentLevel { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("weight")]
        public Weight Weight { get; set; }

        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("level_cap")]
        public double? Level_Cap { get; set; }

        [JsonPropertyName("uncapped_level")]
        public float? Uncapped_Level { get; set; }
    }

    public class Ref
    {
        [JsonPropertyName("rarity")]
        public float? Rarity { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }
    }

    public class Pet
    {
        [JsonPropertyName("uuid")]
        public object Uuid { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("exp")]
        public double? Exp { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("tier")]
        public string Tier { get; set; }

        [JsonPropertyName("heldItem")]
        public string HeldItem { get; set; }

        [JsonPropertyName("candyUsed")]
        public float? CandyUsed { get; set; }

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
        public float? _0 { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }

    public class BestScore
    {
        [JsonPropertyName("0")]
        public float? _0 { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }

    public class MobsKilled
    {
        [JsonPropertyName("0")]
        public float? _0 { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }

    public class MostMobsKilled
    {
        [JsonPropertyName("0")]
        public float? _0 { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }

    public class MostDamageTank
    {
        [JsonPropertyName("0")]
        public double? _0 { get; set; }

        [JsonPropertyName("1")]
        public double? _1 { get; set; }

        [JsonPropertyName("2")]
        public double? _2 { get; set; }

        [JsonPropertyName("3")]
        public double? _3 { get; set; }

        [JsonPropertyName("4")]
        public double? _4 { get; set; }

        [JsonPropertyName("5")]
        public double? _5 { get; set; }

        [JsonPropertyName("6")]
        public double? _6 { get; set; }

        [JsonPropertyName("7")]
        public double? _7 { get; set; }
    }

    public class MostHealing
    {
        [JsonPropertyName("0")]
        public double? _0 { get; set; }

        [JsonPropertyName("1")]
        public double? _1 { get; set; }

        [JsonPropertyName("2")]
        public double? _2 { get; set; }

        [JsonPropertyName("3")]
        public double? _3 { get; set; }

        [JsonPropertyName("4")]
        public double? _4 { get; set; }

        [JsonPropertyName("5")]
        public double? _5 { get; set; }

        [JsonPropertyName("6")]
        public double? _6 { get; set; }

        [JsonPropertyName("7")]
        public double? _7 { get; set; }
    }

    public class MostDamageArcher
    {
        [JsonPropertyName("0")]
        public double? _0 { get; set; }

        [JsonPropertyName("1")]
        public double? _1 { get; set; }

        [JsonPropertyName("2")]
        public double? _2 { get; set; }

        [JsonPropertyName("3")]
        public double? _3 { get; set; }

        [JsonPropertyName("4")]
        public double? _4 { get; set; }

        [JsonPropertyName("5")]
        public double? _5 { get; set; }

        [JsonPropertyName("6")]
        public double? _6 { get; set; }

        [JsonPropertyName("7")]
        public double? _7 { get; set; }
    }

    public class MostDamageMage
    {
        [JsonPropertyName("0")]
        public double? _0 { get; set; }

        [JsonPropertyName("1")]
        public double? _1 { get; set; }

        [JsonPropertyName("2")]
        public double? _2 { get; set; }

        [JsonPropertyName("3")]
        public double? _3 { get; set; }

        [JsonPropertyName("4")]
        public double? _4 { get; set; }

        [JsonPropertyName("5")]
        public double? _5 { get; set; }

        [JsonPropertyName("6")]
        public double? _6 { get; set; }

        [JsonPropertyName("7")]
        public double? _7 { get; set; }
    }

    public class MostDamageHealer
    {
        [JsonPropertyName("0")]
        public double? _0 { get; set; }

        [JsonPropertyName("1")]
        public double? _1 { get; set; }

        [JsonPropertyName("2")]
        public double? _2 { get; set; }

        [JsonPropertyName("3")]
        public double? _3 { get; set; }

        [JsonPropertyName("4")]
        public double? _4 { get; set; }

        [JsonPropertyName("5")]
        public double? _5 { get; set; }

        [JsonPropertyName("6")]
        public double? _6 { get; set; }

        [JsonPropertyName("7")]
        public double? _7 { get; set; }
    }

    public class TierCompletions
    {
        [JsonPropertyName("0")]
        public float? _0 { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }

    public class MilestoneCompletions
    {
        [JsonPropertyName("0")]
        public float? _0 { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }

    public class FastestTime
    {
        [JsonPropertyName("0")]
        public float? _0 { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }


    public class BestRuns
    {
        [JsonPropertyName("timestamp")]
        public object Timestamp { get; set; }

        [JsonPropertyName("score_exploration")]
        public float? ScoreExploration { get; set; }

        [JsonPropertyName("score_speed")]
        public float? ScoreSpeed { get; set; }

        [JsonPropertyName("score_skill")]
        public float? ScoreSkill { get; set; }

        [JsonPropertyName("score_bonus")]
        public float? ScoreBonus { get; set; }

        [JsonPropertyName("dungeon_class")]
        public string DungeonClass { get; set; }

        [JsonPropertyName("teammates")]
        public List<string> Teammates { get; set; }

        [JsonPropertyName("elapsed_time")]
        public float? ElapsedTime { get; set; }

        [JsonPropertyName("damage_dealt")]
        public double? DamageDealt { get; set; }

        [JsonPropertyName("deaths")]
        public float? Deaths { get; set; }

        [JsonPropertyName("mobs_killed")]
        public float? MobsKilled { get; set; }

        [JsonPropertyName("secrets_found")]
        public float? SecretsFound { get; set; }

        [JsonPropertyName("damage_mitigated")]
        public double? DamageMitigated { get; set; }

        [JsonPropertyName("ally_healing")]
        public double? AllyHealing { get; set; }
    }

    public class WatcherKills
    {
        [JsonPropertyName("0")]
        public float? _0 { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }

    public class Catacombs
    {
        [JsonPropertyName("times_played")]
        public TimesPlayed TimesPlayed { get; set; }

        [JsonPropertyName("experience")]
        public double? Experience { get; set; }

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
        public float? HighestTierCompleted { get; set; }

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
        public float? HighestTierCompleted { get; set; }

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
        public double? Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class Mage
    {
        [JsonPropertyName("experience")]
        public double? Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class Berserk
    {
        [JsonPropertyName("experience")]
        public double? Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class Archer
    {
        [JsonPropertyName("experience")]
        public double? Experience { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }
    }

    public class Tank
    {
        [JsonPropertyName("experience")]
        public double? Experience { get; set; }

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
        public float? PagesCollected { get; set; }

        [JsonPropertyName("total_pages")]
        public float? TotalPages { get; set; }

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
        public double? DungeonsWeight { get; set; }

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
        public float? SecretsFound { get; set; }

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
        public float? Bronze { get; set; }

        [JsonPropertyName("silver")]
        public float? Silver { get; set; }

        [JsonPropertyName("gold")]
        public float? Gold { get; set; }
    }

    public class Perks
    {
        [JsonPropertyName("double_drops")]
        public float? DoubleDrops { get; set; }

        [JsonPropertyName("farming_level_cap")]
        public float? FarmingLevelCap { get; set; }

        [JsonPropertyName("forbidden_blessing")]
        public float? ForbiddenBlessing { get; set; }

        [JsonPropertyName("permanent_health")]
        public float? PermanentHealth { get; set; }

        [JsonPropertyName("permanent_speed")]
        public float? PermanentSpeed { get; set; }

        [JsonPropertyName("permanent_intelligence")]
        public float? PermanentIntelligence { get; set; }

        [JsonPropertyName("permanent_defense")]
        public float? PermanentDefense { get; set; }

        [JsonPropertyName("catacombs_boss_luck")]
        public float? CatacombsBossLuck { get; set; }

        [JsonPropertyName("catacombs_health")]
        public float? CatacombsHealth { get; set; }

        [JsonPropertyName("catacombs_intelligence")]
        public float? CatacombsIntelligence { get; set; }

        [JsonPropertyName("catacombs_looting")]
        public float? CatacombsLooting { get; set; }
    }

    public class _108219POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _108219SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _108219MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _108228NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _108231WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _108531WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _110129INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _111129NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _111210INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _111216INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _111222NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _111420SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _111429INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _11151NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _111711INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _11199NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _111912INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1111128INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _11263SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _112624INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1131029INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _11412INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114210INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _11436INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114513INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114531INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _11463SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114714INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1151212INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _117330INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13184NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13184INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _132531MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13263INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _135420INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _135924INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13624INKSACK3
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _144813WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
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
        public float? Claims0 { get; set; }

        [JsonPropertyName("best_score_0")]
        public float? BestScore0 { get; set; }

        [JsonPropertyName("claims_1")]
        public float? Claims1 { get; set; }

        [JsonPropertyName("best_score_1")]
        public float? BestScore1 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("tiers")]
        public Tiers Tiers { get; set; }

        [JsonPropertyName("claims_2")]
        public float? Claims2 { get; set; }

        [JsonPropertyName("best_score_2")]
        public float? BestScore2 { get; set; }

        [JsonPropertyName("claims_3")]
        public float? Claims3 { get; set; }

        [JsonPropertyName("best_score_3")]
        public float? BestScore3 { get; set; }

        [JsonPropertyName("claims_4")]
        public float? Claims4 { get; set; }

        [JsonPropertyName("best_score_4")]
        public float? BestScore4 { get; set; }

        [JsonPropertyName("last_attempt")]
        public float? LastAttempt { get; set; }

        [JsonPropertyName("claims_5")]
        public float? Claims5 { get; set; }

        [JsonPropertyName("best_score_5")]
        public float? BestScore5 { get; set; }
    }

    public class Simon
    {
        [JsonPropertyName("last_attempt")]
        public long LastAttempt { get; set; }

        [JsonPropertyName("attempts_0")]
        public float? Attempts0 { get; set; }

        [JsonPropertyName("bonus_clicks")]
        public float? BonusClicks { get; set; }

        [JsonPropertyName("last_claimed")]
        public long LastClaimed { get; set; }

        [JsonPropertyName("claims_0")]
        public float? Claims0 { get; set; }

        [JsonPropertyName("best_score_0")]
        public float? BestScore0 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("tiers")]
        public Tiers Tiers { get; set; }

        [JsonPropertyName("attempts_1")]
        public float? Attempts1 { get; set; }

        [JsonPropertyName("claims_1")]
        public float? Claims1 { get; set; }

        [JsonPropertyName("best_score_1")]
        public float? BestScore1 { get; set; }

        [JsonPropertyName("attempts_2")]
        public float? Attempts2 { get; set; }

        [JsonPropertyName("claims_2")]
        public float? Claims2 { get; set; }

        [JsonPropertyName("best_score_2")]
        public float? BestScore2 { get; set; }

        [JsonPropertyName("attempts_3")]
        public float? Attempts3 { get; set; }

        [JsonPropertyName("claims_3")]
        public float? Claims3 { get; set; }

        [JsonPropertyName("best_score_3")]
        public float? BestScore3 { get; set; }

        [JsonPropertyName("attempts_5")]
        public float? Attempts5 { get; set; }

        [JsonPropertyName("claims_5")]
        public float? Claims5 { get; set; }

        [JsonPropertyName("best_score_5")]
        public float? BestScore5 { get; set; }
    }

    public class Numbers
    {
        [JsonPropertyName("last_attempt")]
        public long LastAttempt { get; set; }

        [JsonPropertyName("attempts_1")]
        public float? Attempts1 { get; set; }

        [JsonPropertyName("bonus_clicks")]
        public float? BonusClicks { get; set; }

        [JsonPropertyName("last_claimed")]
        public long LastClaimed { get; set; }

        [JsonPropertyName("claims_1")]
        public float? Claims1 { get; set; }

        [JsonPropertyName("best_score_1")]
        public float? BestScore1 { get; set; }

        [JsonPropertyName("attempts_2")]
        public float? Attempts2 { get; set; }

        [JsonPropertyName("claims_2")]
        public float? Claims2 { get; set; }

        [JsonPropertyName("best_score_2")]
        public float? BestScore2 { get; set; }

        [JsonPropertyName("attempts_3")]
        public float? Attempts3 { get; set; }

        [JsonPropertyName("claims_3")]
        public float? Claims3 { get; set; }

        [JsonPropertyName("best_score_3")]
        public float? BestScore3 { get; set; }

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
        public float? ClaimsResets { get; set; }

        [JsonPropertyName("claims_resets_timestamp")]
        public long ClaimsResetsTimestamp { get; set; }
    }

    public class TempStatBuff
    {
        [JsonPropertyName("stat")]
        public float? Stat { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("expire_at")]
        public object ExpireAt { get; set; }
    }

    public class Nodes
    {
        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("titanium_insanium")]
        public float? TitaniumInsanium { get; set; }

        [JsonPropertyName("mining_speed_boost")]
        public float? MiningSpeedBoost { get; set; }

        [JsonPropertyName("random_event")]
        public float? RandomEvent { get; set; }

        [JsonPropertyName("mining_madness")]
        public float? MiningMadness { get; set; }

        [JsonPropertyName("mining_experience")]
        public float? MiningExperience { get; set; }

        [JsonPropertyName("special_0")]
        public float? Special0 { get; set; }

        [JsonPropertyName("efficient_miner")]
        public float? EfficientMiner { get; set; }

        [JsonPropertyName("goblin_killer")]
        public float? GoblinKiller { get; set; }

        [JsonPropertyName("daily_effect")]
        public float? DailyEffect { get; set; }

        [JsonPropertyName("toggle_mining_speed")]
        public bool ToggleMiningSpeed { get; set; }

        [JsonPropertyName("toggle_efficient_miner")]
        public bool ToggleEfficientMiner { get; set; }

        [JsonPropertyName("mole")]
        public float? Mole { get; set; }

        [JsonPropertyName("lonesome_miner")]
        public float? LonesomeMiner { get; set; }

        [JsonPropertyName("professional")]
        public float? Professional { get; set; }
    }

    public class MiningCore
    {
        [JsonPropertyName("nodes")]
        public Nodes Nodes { get; set; }

        [JsonPropertyName("received_free_tier")]
        public bool ReceivedFreeTier { get; set; }

        [JsonPropertyName("tokens")]
        public float? Tokens { get; set; }

        [JsonPropertyName("tokens_spent")]
        public float? TokensSpent { get; set; }

        [JsonPropertyName("powder_mithril")]
        public float? PowderMithril { get; set; }

        [JsonPropertyName("powder_mithril_total")]
        public float? PowderMithrilTotal { get; set; }

        [JsonPropertyName("powder_spent_mithril")]
        public float? PowderSpentMithril { get; set; }

        [JsonPropertyName("experience")]
        public float? Experience { get; set; }

        [JsonPropertyName("retroactive_tier2_token")]
        public bool RetroactiveTier2Token { get; set; }

        [JsonPropertyName("selected_pickaxe_ability")]
        public string SelectedPickaxeAbility { get; set; }

        [JsonPropertyName("current_daily_effect")]
        public string CurrentDailyEffect { get; set; }

        [JsonPropertyName("current_daily_effect_last_changed")]
        public float? CurrentDailyEffectLastChanged { get; set; }

        [JsonPropertyName("greater_mines_last_access")]
        public long GreaterMinesLastAccess { get; set; }

        [JsonPropertyName("crystals")]
        public Crystals Crystals { get; set; }

        [JsonPropertyName("biomes")]
        public Biomes Biomes { get; set; }

        [JsonPropertyName("powder_gemstone")]
        public float? PowderGemstone { get; set; }

        [JsonPropertyName("powder_gemstone_total")]
        public float? PowderGemstoneTotal { get; set; }

        [JsonPropertyName("powder_spent_gemstone")]
        public float? PowderSpentGemstone { get; set; }
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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class SacksCounts
    {
        [JsonPropertyName("SEEDS")]
        public float? SEEDS { get; set; }

        [JsonPropertyName("WHEAT")]
        public float? WHEAT { get; set; }

        [JsonPropertyName("POTATO_ITEM")]
        public float? POTATOITEM { get; set; }

        [JsonPropertyName("CARROT_ITEM")]
        public float? CARROTITEM { get; set; }

        [JsonPropertyName("BROWN_MUSHROOM")]
        public float? BROWNMUSHROOM { get; set; }

        [JsonPropertyName("RED_MUSHROOM")]
        public float? REDMUSHROOM { get; set; }

        [JsonPropertyName("ROTTEN_FLESH")]
        public float? ROTTENFLESH { get; set; }

        [JsonPropertyName("BONE")]
        public float? BONE { get; set; }

        [JsonPropertyName("STRING")]
        public float? STRING { get; set; }

        [JsonPropertyName("SPIDER_EYE")]
        public float? SPIDEREYE { get; set; }

        [JsonPropertyName("MAGMA_CREAM")]
        public float? MAGMACREAM { get; set; }

        [JsonPropertyName("LOG_2:1")]
        public float? LOG21 { get; set; }

        [JsonPropertyName("LOG")]
        public float? LOG { get; set; }

        [JsonPropertyName("LOG:2")]
        public float? LOG2 { get; set; }

        [JsonPropertyName("IRON_INGOT")]
        public float? IRONINGOT { get; set; }

        [JsonPropertyName("INK_SACK:4")]
        public float? INKSACK4 { get; set; }

        [JsonPropertyName("QUARTZ")]
        public float? QUARTZ { get; set; }

        [JsonPropertyName("COBBLESTONE")]
        public float? COBBLESTONE { get; set; }

        [JsonPropertyName("REDSTONE")]
        public float? REDSTONE { get; set; }

        [JsonPropertyName("COAL")]
        public float? COAL { get; set; }

        [JsonPropertyName("PUMPKIN")]
        public float? PUMPKIN { get; set; }

        [JsonPropertyName("SUGAR_CANE")]
        public float? SUGARCANE { get; set; }

        [JsonPropertyName("MELON")]
        public float? MELON { get; set; }

        [JsonPropertyName("MUSHROOM_COLLECTION")]
        public float? MUSHROOMCOLLECTION { get; set; }

        [JsonPropertyName("INK_SACK:3")]
        public float? INKSACK3 { get; set; }

        [JsonPropertyName("CACTUS")]
        public float? CACTUS { get; set; }

        [JsonPropertyName("NETHER_STALK")]
        public float? NETHERSTALK { get; set; }

        [JsonPropertyName("DIAMOND")]
        public float? DIAMOND { get; set; }

        [JsonPropertyName("EMERALD")]
        public float? EMERALD { get; set; }

        [JsonPropertyName("PRISMARINE_CRYSTALS")]
        public float? PRISMARINECRYSTALS { get; set; }

        [JsonPropertyName("PRISMARINE_SHARD")]
        public float? PRISMARINESHARD { get; set; }

        [JsonPropertyName("RAW_FISH:2")]
        public float? RAWFISH2 { get; set; }

        [JsonPropertyName("RAW_FISH:3")]
        public float? RAWFISH3 { get; set; }

        [JsonPropertyName("RAW_FISH:1")]
        public float? RAWFISH1 { get; set; }

        [JsonPropertyName("SPONGE")]
        public float? SPONGE { get; set; }

        [JsonPropertyName("RAW_FISH")]
        public float? RAWFISH { get; set; }

        [JsonPropertyName("LOG:1")]
        public float? LOG1 { get; set; }

        [JsonPropertyName("LOG_2")]
        public float? LOG_2 { get; set; }

        [JsonPropertyName("LOG:3")]
        public float? LOG3 { get; set; }

        [JsonPropertyName("SAND")]
        public float? SAND { get; set; }

        [JsonPropertyName("BLAZE_ROD")]
        public float? BLAZEROD { get; set; }

        [JsonPropertyName("GHAST_TEAR")]
        public float? GHASTTEAR { get; set; }

        [JsonPropertyName("RABBIT")]
        public float? RABBIT { get; set; }

        [JsonPropertyName("SLIME_BALL")]
        public float? SLIMEBALL { get; set; }

        [JsonPropertyName("NETHERRACK")]
        public float? NETHERRACK { get; set; }

        [JsonPropertyName("WATER_LILY")]
        public float? WATERLILY { get; set; }

        [JsonPropertyName("ICE")]
        public float? ICE { get; set; }

        [JsonPropertyName("LEATHER")]
        public float? LEATHER { get; set; }

        [JsonPropertyName("FEATHER")]
        public float? FEATHER { get; set; }

        [JsonPropertyName("RAW_CHICKEN")]
        public float? RAWCHICKEN { get; set; }

        [JsonPropertyName("ENDER_PEARL")]
        public float? ENDERPEARL { get; set; }

        [JsonPropertyName("OBSIDIAN")]
        public float? OBSIDIAN { get; set; }

        [JsonPropertyName("GOLD_INGOT")]
        public float? GOLDINGOT { get; set; }

        [JsonPropertyName("INK_SACK")]
        public float? INKSACK { get; set; }

        [JsonPropertyName("CLAY_BALL")]
        public float? CLAYBALL { get; set; }

        [JsonPropertyName("SULPHUR")]
        public float? SULPHUR { get; set; }

        [JsonPropertyName("GLOWSTONE_DUST")]
        public float? GLOWSTONEDUST { get; set; }

        [JsonPropertyName("MUTTON")]
        public float? MUTTON { get; set; }

        [JsonPropertyName("GRAVEL")]
        public float? GRAVEL { get; set; }

        [JsonPropertyName("REVENANT_FLESH")]
        public float? REVENANTFLESH { get; set; }

        [JsonPropertyName("WOLF_TOOTH")]
        public float? WOLFTOOTH { get; set; }

        [JsonPropertyName("TARANTULA_WEB")]
        public float? TARANTULAWEB { get; set; }

        [JsonPropertyName("PORK")]
        public float? PORK { get; set; }

        [JsonPropertyName("ENDER_STONE")]
        public float? ENDERSTONE { get; set; }

        [JsonPropertyName("GREEN_CANDY")]
        public float? GREENCANDY { get; set; }

        [JsonPropertyName("PURPLE_CANDY")]
        public float? PURPLECANDY { get; set; }

        [JsonPropertyName("MITHRIL_ORE")]
        public float? MITHRILORE { get; set; }

        [JsonPropertyName("STARFALL")]
        public float? STARFALL { get; set; }

        [JsonPropertyName("TITANIUM_ORE")]
        public float? TITANIUMORE { get; set; }

        [JsonPropertyName("TREASURITE")]
        public float? TREASURITE { get; set; }

        [JsonPropertyName("RABBIT_FOOT")]
        public float? RABBITFOOT { get; set; }

        [JsonPropertyName("RAW_BEEF")]
        public float? RAWBEEF { get; set; }

        [JsonPropertyName("RABBIT_HIDE")]
        public float? RABBITHIDE { get; set; }

        [JsonPropertyName("RUNE_SPARKLING_1")]
        public float? RUNESPARKLING1 { get; set; }

        [JsonPropertyName("RUNE_BLOOD_2_1")]
        public float? RUNEBLOOD21 { get; set; }

        [JsonPropertyName("RUNE_HOT_1")]
        public float? RUNEHOT1 { get; set; }

        [JsonPropertyName("RUNE_SNOW_1")]
        public float? RUNESNOW1 { get; set; }

        [JsonPropertyName("RUNE_LAVA_1")]
        public float? RUNELAVA1 { get; set; }

        [JsonPropertyName("RUNE_WAKE_1")]
        public float? RUNEWAKE1 { get; set; }

        [JsonPropertyName("RUNE_ICE_3")]
        public float? RUNEICE3 { get; set; }

        [JsonPropertyName("RUNE_ICE_1")]
        public float? RUNEICE1 { get; set; }

        [JsonPropertyName("RUNE_GEM_1")]
        public float? RUNEGEM1 { get; set; }

        [JsonPropertyName("RUNE_WHITE_SPIRAL_2")]
        public float? RUNEWHITESPIRAL2 { get; set; }

        [JsonPropertyName("RUNE_WHITE_SPIRAL_1")]
        public float? RUNEWHITESPIRAL1 { get; set; }

        [JsonPropertyName("RUNE_SNOW_3")]
        public float? RUNESNOW3 { get; set; }

        [JsonPropertyName("RUNE_HEARTS_1")]
        public float? RUNEHEARTS1 { get; set; }

        [JsonPropertyName("RUNE_HEARTS_2")]
        public float? RUNEHEARTS2 { get; set; }

        [JsonPropertyName("RUNE_ZOMBIE_SLAYER_1")]
        public float? RUNEZOMBIESLAYER1 { get; set; }

        [JsonPropertyName("RUNE_HEARTS_3")]
        public float? RUNEHEARTS3 { get; set; }

        [JsonPropertyName("RUNE_GEM_3")]
        public float? RUNEGEM3 { get; set; }

        [JsonPropertyName("RUNE_ICE_2")]
        public float? RUNEICE2 { get; set; }

        [JsonPropertyName("RUNE_GEM_2")]
        public float? RUNEGEM2 { get; set; }

        [JsonPropertyName("RUNE_CLOUDS_1")]
        public float? RUNECLOUDS1 { get; set; }

        [JsonPropertyName("RUNE_MAGIC_1")]
        public float? RUNEMAGIC1 { get; set; }

        [JsonPropertyName("RUNE_MAGIC_3")]
        public float? RUNEMAGIC3 { get; set; }

        [JsonPropertyName("RUNE_SNOW_2")]
        public float? RUNESNOW2 { get; set; }

        [JsonPropertyName("RUNE_ZAP_1")]
        public float? RUNEZAP1 { get; set; }

        [JsonPropertyName("RUNE_ZAP_2")]
        public float? RUNEZAP2 { get; set; }

        [JsonPropertyName("RUNE_SPIRIT_1")]
        public float? RUNESPIRIT1 { get; set; }

        [JsonPropertyName("RUNE_BLOOD_2_2")]
        public float? RUNEBLOOD22 { get; set; }

        [JsonPropertyName("RUNE_BLOOD_2_3")]
        public float? RUNEBLOOD23 { get; set; }

        [JsonPropertyName("RUNE_LAVA_3")]
        public float? RUNELAVA3 { get; set; }

        [JsonPropertyName("RUNE_SMOKEY_2")]
        public float? RUNESMOKEY2 { get; set; }

        [JsonPropertyName("RUNE_WHITE_SPIRAL_3")]
        public float? RUNEWHITESPIRAL3 { get; set; }

        [JsonPropertyName("RUNE_SPARKLING_2")]
        public float? RUNESPARKLING2 { get; set; }

        [JsonPropertyName("RUNE_BITE_1")]
        public float? RUNEBITE1 { get; set; }

        [JsonPropertyName("RUNE_HOT_3")]
        public float? RUNEHOT3 { get; set; }

        [JsonPropertyName("RUNE_HOT_2")]
        public float? RUNEHOT2 { get; set; }

        [JsonPropertyName("RUNE_LAVA_2")]
        public float? RUNELAVA2 { get; set; }

        [JsonPropertyName("RUNE_SPARKLING_3")]
        public float? RUNESPARKLING3 { get; set; }

        [JsonPropertyName("RUNE_FIRE_SPIRAL_1")]
        public float? RUNEFIRESPIRAL1 { get; set; }

        [JsonPropertyName("RUNE_FIRE_SPIRAL_2")]
        public float? RUNEFIRESPIRAL2 { get; set; }

        [JsonPropertyName("RUNE_REDSTONE_1")]
        public float? RUNEREDSTONE1 { get; set; }

        [JsonPropertyName("RUNE_SNAKE_1")]
        public float? RUNESNAKE1 { get; set; }

        [JsonPropertyName("RUNE_GOLDEN_1")]
        public float? RUNEGOLDEN1 { get; set; }

        [JsonPropertyName("RUNE_GOLDEN_2")]
        public float? RUNEGOLDEN2 { get; set; }

        [JsonPropertyName("RUNE_MUSIC_1")]
        public float? RUNEMUSIC1 { get; set; }

        [JsonPropertyName("RUNE_LIGHTNING_1")]
        public float? RUNELIGHTNING1 { get; set; }

        [JsonPropertyName("RUNE_RAINBOW_1")]
        public float? RUNERAINBOW1 { get; set; }

        [JsonPropertyName("ECTOPLASM")]
        public float? ECTOPLASM { get; set; }

        [JsonPropertyName("PUMPKIN_GUTS")]
        public float? PUMPKINGUTS { get; set; }

        [JsonPropertyName("WEREWOLF_SKIN")]
        public float? WEREWOLFSKIN { get; set; }

        [JsonPropertyName("NULL_SPHERE")]
        public float? NULLSPHERE { get; set; }

        [JsonPropertyName("HARD_STONE")]
        public float? HARDSTONE { get; set; }

        [JsonPropertyName("ROUGH_SAPPHIRE_GEM")]
        public float? ROUGHSAPPHIREGEM { get; set; }

        [JsonPropertyName("FLAWED_SAPPHIRE_GEM")]
        public float? FLAWEDSAPPHIREGEM { get; set; }

        [JsonPropertyName("ROUGH_RUBY_GEM")]
        public float? ROUGHRUBYGEM { get; set; }

        [JsonPropertyName("ROUGH_JADE_GEM")]
        public float? ROUGHJADEGEM { get; set; }

        [JsonPropertyName("FLAWED_JADE_GEM")]
        public float? FLAWEDJADEGEM { get; set; }

        [JsonPropertyName("ROUGH_TOPAZ_GEM")]
        public float? ROUGHTOPAZGEM { get; set; }

        [JsonPropertyName("FLAWED_AMBER_GEM")]
        public float? FLAWEDAMBERGEM { get; set; }

        [JsonPropertyName("FLAWED_TOPAZ_GEM")]
        public float? FLAWEDTOPAZGEM { get; set; }

        [JsonPropertyName("ROUGH_AMBER_GEM")]
        public float? ROUGHAMBERGEM { get; set; }

        [JsonPropertyName("ROUGH_AMETHYST_GEM")]
        public float? ROUGHAMETHYSTGEM { get; set; }

        [JsonPropertyName("FLAWED_AMETHYST_GEM")]
        public float? FLAWEDAMETHYSTGEM { get; set; }

        [JsonPropertyName("FINE_AMETHYST_GEM")]
        public float? FINEAMETHYSTGEM { get; set; }

        [JsonPropertyName("FLAWLESS_AMETHYST_GEM")]
        public float? FLAWLESSAMETHYSTGEM { get; set; }

        [JsonPropertyName("PERFECT_AMETHYST_GEM")]
        public float? PERFECTAMETHYSTGEM { get; set; }

        [JsonPropertyName("FLAWED_RUBY_GEM")]
        public float? FLAWEDRUBYGEM { get; set; }

        [JsonPropertyName("ROUGH_JASPER_GEM")]
        public float? ROUGHJASPERGEM { get; set; }

        [JsonPropertyName("FLAWED_JASPER_GEM")]
        public float? FLAWEDJASPERGEM { get; set; }

        [JsonPropertyName("FINE_JASPER_GEM")]
        public float? FINEJASPERGEM { get; set; }

        [JsonPropertyName("FLAWLESS_JASPER_GEM")]
        public float? FLAWLESSJASPERGEM { get; set; }

        [JsonPropertyName("PERFECT_JASPER_GEM")]
        public float? PERFECTJASPERGEM { get; set; }

        [JsonPropertyName("FINE_JADE_GEM")]
        public float? FINEJADEGEM { get; set; }

        [JsonPropertyName("FINE_RUBY_GEM")]
        public float? FINERUBYGEM { get; set; }

        [JsonPropertyName("FLAWLESS_RUBY_GEM")]
        public float? FLAWLESSRUBYGEM { get; set; }

        [JsonPropertyName("PERFECT_RUBY_GEM")]
        public float? PERFECTRUBYGEM { get; set; }

        [JsonPropertyName("FINE_SAPPHIRE_GEM")]
        public float? FINESAPPHIREGEM { get; set; }

        [JsonPropertyName("FLAWLESS_SAPPHIRE_GEM")]
        public float? FLAWLESSSAPPHIREGEM { get; set; }

        [JsonPropertyName("PERFECT_SAPPHIRE_GEM")]
        public float? PERFECTSAPPHIREGEM { get; set; }

        [JsonPropertyName("FINE_TOPAZ_GEM")]
        public float? FINETOPAZGEM { get; set; }

        [JsonPropertyName("FLAWLESS_TOPAZ_GEM")]
        public float? FLAWLESSTOPAZGEM { get; set; }

        [JsonPropertyName("PERFECT_TOPAZ_GEM")]
        public float? PERFECTTOPAZGEM { get; set; }

        [JsonPropertyName("FINE_AMBER_GEM")]
        public float? FINEAMBERGEM { get; set; }

        [JsonPropertyName("FLAWLESS_AMBER_GEM")]
        public float? FLAWLESSAMBERGEM { get; set; }

        [JsonPropertyName("PERFECT_AMBER_GEM")]
        public float? PERFECTAMBERGEM { get; set; }

        [JsonPropertyName("ENCHANTED_REDSTONE")]
        public float? ENCHANTEDREDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_COAL")]
        public float? ENCHANTEDCOAL { get; set; }

        [JsonPropertyName("ENCHANTED_IRON")]
        public float? ENCHANTEDIRON { get; set; }

        [JsonPropertyName("ENCHANTED_HARD_STONE")]
        public float? ENCHANTEDHARDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_GOLD")]
        public float? ENCHANTEDGOLD { get; set; }

        [JsonPropertyName("ENCHANTED_COBBLESTONE")]
        public float? ENCHANTEDCOBBLESTONE { get; set; }

        [JsonPropertyName("ENCHANTED_MITHRIL")]
        public float? ENCHANTEDMITHRIL { get; set; }

        [JsonPropertyName("ENCHANTED_DIAMOND")]
        public float? ENCHANTEDDIAMOND { get; set; }

        [JsonPropertyName("ENCHANTED_ICE")]
        public float? ENCHANTEDICE { get; set; }

        [JsonPropertyName("ENCHANTED_EMERALD")]
        public float? ENCHANTEDEMERALD { get; set; }

        [JsonPropertyName("ENCHANTED_QUARTZ")]
        public float? ENCHANTEDQUARTZ { get; set; }

        [JsonPropertyName("ENCHANTED_LAPIS_LAZULI")]
        public float? ENCHANTEDLAPISLAZULI { get; set; }

        [JsonPropertyName("ENCHANTED_FLINT")]
        public float? ENCHANTEDFLINT { get; set; }

        [JsonPropertyName("ENCHANTED_OBSIDIAN")]
        public float? ENCHANTEDOBSIDIAN { get; set; }

        [JsonPropertyName("ENCHANTED_ENDSTONE")]
        public float? ENCHANTEDENDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_CARROT")]
        public float? ENCHANTEDCARROT { get; set; }

        [JsonPropertyName("ENCHANTED_MELON")]
        public float? ENCHANTEDMELON { get; set; }

        [JsonPropertyName("ENCHANTED_SUGAR")]
        public float? ENCHANTEDSUGAR { get; set; }

        [JsonPropertyName("ENCHANTED_PUMPKIN")]
        public float? ENCHANTEDPUMPKIN { get; set; }

        [JsonPropertyName("ENCHANTED_NETHER_STALK")]
        public float? ENCHANTEDNETHERSTALK { get; set; }

        [JsonPropertyName("ENCHANTED_SEEDS")]
        public float? ENCHANTEDSEEDS { get; set; }

        [JsonPropertyName("ENCHANTED_POTATO")]
        public float? ENCHANTEDPOTATO { get; set; }

        [JsonPropertyName("ENCHANTED_TITANIUM")]
        public float? ENCHANTEDTITANIUM { get; set; }

        [JsonPropertyName("FLAWLESS_JADE_GEM")]
        public float? FLAWLESSJADEGEM { get; set; }

        [JsonPropertyName("PERFECT_JADE_GEM")]
        public float? PERFECTJADEGEM { get; set; }

        [JsonPropertyName("PACKED_ICE")]
        public float? PACKEDICE { get; set; }

        [JsonPropertyName("ICE_HUNK")]
        public float? ICEHUNK { get; set; }
    }

    public class TalismanBag
    {
        [JsonPropertyName("type")]
        public object Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? LOG { get; set; }

        [JsonPropertyName("COAL")]
        public float? COAL { get; set; }

        [JsonPropertyName("COBBLESTONE")]
        public float? COBBLESTONE { get; set; }

        [JsonPropertyName("GOLD_INGOT")]
        public float? GOLDINGOT { get; set; }

        [JsonPropertyName("IRON_INGOT")]
        public float? IRONINGOT { get; set; }

        [JsonPropertyName("WHEAT")]
        public float? WHEAT { get; set; }

        [JsonPropertyName("SEEDS")]
        public float? SEEDS { get; set; }

        [JsonPropertyName("SULPHUR")]
        public float? SULPHUR { get; set; }

        [JsonPropertyName("INK_SACK:4")]
        public float? INKSACK4 { get; set; }

        [JsonPropertyName("ROTTEN_FLESH")]
        public float? ROTTENFLESH { get; set; }

        [JsonPropertyName("POTATO_ITEM")]
        public float? POTATOITEM { get; set; }

        [JsonPropertyName("REDSTONE")]
        public float? REDSTONE { get; set; }

        [JsonPropertyName("EMERALD")]
        public float? EMERALD { get; set; }

        [JsonPropertyName("SLIME_BALL")]
        public float? SLIMEBALL { get; set; }

        [JsonPropertyName("DIAMOND")]
        public float? DIAMOND { get; set; }

        [JsonPropertyName("BONE")]
        public float? BONE { get; set; }

        [JsonPropertyName("NETHER_STALK")]
        public float? NETHERSTALK { get; set; }

        [JsonPropertyName("LOG:3")]
        public float? LOG3 { get; set; }

        [JsonPropertyName("CARROT_ITEM")]
        public float? CARROTITEM { get; set; }

        [JsonPropertyName("SUGAR_CANE")]
        public float? SUGARCANE { get; set; }

        [JsonPropertyName("MUSHROOM_COLLECTION")]
        public float? MUSHROOMCOLLECTION { get; set; }

        [JsonPropertyName("STRING")]
        public float? STRING { get; set; }

        [JsonPropertyName("IRON_BLOCK")]
        public float? IRONBLOCK { get; set; }

        [JsonPropertyName("LOG:2")]
        public float? LOG2 { get; set; }

        [JsonPropertyName("SPIDER_EYE")]
        public float? SPIDEREYE { get; set; }

        [JsonPropertyName("QUARTZ")]
        public float? QUARTZ { get; set; }

        [JsonPropertyName("NETHERRACK")]
        public float? NETHERRACK { get; set; }

        [JsonPropertyName("MAGMA_CREAM")]
        public float? MAGMACREAM { get; set; }

        [JsonPropertyName("GLOWSTONE_DUST")]
        public float? GLOWSTONEDUST { get; set; }

        [JsonPropertyName("MUTTON")]
        public float? MUTTON { get; set; }

        [JsonPropertyName("LOG_2:1")]
        public float? LOG21 { get; set; }

        [JsonPropertyName("OBSIDIAN")]
        public float? OBSIDIAN { get; set; }

        [JsonPropertyName("BLAZE_ROD")]
        public float? BLAZEROD { get; set; }

        [JsonPropertyName("ENDER_STONE")]
        public float? ENDERSTONE { get; set; }

        [JsonPropertyName("ENDER_PEARL")]
        public float? ENDERPEARL { get; set; }

        [JsonPropertyName("GRAVEL")]
        public float? GRAVEL { get; set; }

        [JsonPropertyName("PORK")]
        public float? PORK { get; set; }

        [JsonPropertyName("CACTUS")]
        public float? CACTUS { get; set; }

        [JsonPropertyName("INK_SACK:3")]
        public float? INKSACK3 { get; set; }

        [JsonPropertyName("FEATHER")]
        public float? FEATHER { get; set; }

        [JsonPropertyName("RAW_CHICKEN")]
        public float? RAWCHICKEN { get; set; }

        [JsonPropertyName("SAND")]
        public float? SAND { get; set; }

        [JsonPropertyName("MELON")]
        public float? MELON { get; set; }

        [JsonPropertyName("ENCHANTED_ENDER_PEARL")]
        public float? ENCHANTEDENDERPEARL { get; set; }

        [JsonPropertyName("MITHRIL_ORE")]
        public float? MITHRILORE { get; set; }

        [JsonPropertyName("LEATHER")]
        public float? LEATHER { get; set; }

        [JsonPropertyName("RABBIT")]
        public float? RABBIT { get; set; }

        [JsonPropertyName("ENCHANTED_QUARTZ")]
        public float? ENCHANTEDQUARTZ { get; set; }

        [JsonPropertyName("LOG:1")]
        public float? LOG1 { get; set; }

        [JsonPropertyName("LOG_2")]
        public float? LOG_2 { get; set; }

        [JsonPropertyName("ENCHANTED_SPRUCE_LOG")]
        public float? ENCHANTEDSPRUCELOG { get; set; }

        [JsonPropertyName("ENCHANTED_DIAMOND")]
        public float? ENCHANTEDDIAMOND { get; set; }

        [JsonPropertyName("ENCHANTED_GOLD")]
        public float? ENCHANTEDGOLD { get; set; }

        [JsonPropertyName("PUMPKIN")]
        public float? PUMPKIN { get; set; }

        [JsonPropertyName("RAW_FISH:3")]
        public float? RAWFISH3 { get; set; }

        [JsonPropertyName("RAW_FISH")]
        public float? RAWFISH { get; set; }

        [JsonPropertyName("WATER_LILY")]
        public float? WATERLILY { get; set; }

        [JsonPropertyName("CLAY_BALL")]
        public float? CLAYBALL { get; set; }

        [JsonPropertyName("GHAST_TEAR")]
        public float? GHASTTEAR { get; set; }

        [JsonPropertyName("RAW_FISH:2")]
        public float? RAWFISH2 { get; set; }

        [JsonPropertyName("RAW_FISH:1")]
        public float? RAWFISH1 { get; set; }

        [JsonPropertyName("INK_SACK")]
        public float? INKSACK { get; set; }

        [JsonPropertyName("PRISMARINE_SHARD")]
        public float? PRISMARINESHARD { get; set; }

        [JsonPropertyName("PRISMARINE_CRYSTALS")]
        public float? PRISMARINECRYSTALS { get; set; }

        [JsonPropertyName("SPONGE")]
        public float? SPONGE { get; set; }

        [JsonPropertyName("ICE")]
        public float? ICE { get; set; }

        [JsonPropertyName("ENCHANTED_LAPIS_LAZULI")]
        public float? ENCHANTEDLAPISLAZULI { get; set; }

        [JsonPropertyName("ENCHANTED_ROTTEN_FLESH")]
        public float? ENCHANTEDROTTENFLESH { get; set; }

        [JsonPropertyName("ENCHANTED_GHAST_TEAR")]
        public float? ENCHANTEDGHASTTEAR { get; set; }

        [JsonPropertyName("ENCHANTED_EGG")]
        public float? ENCHANTEDEGG { get; set; }

        [JsonPropertyName("EGG")]
        public float? EGG { get; set; }

        [JsonPropertyName("RAW_BEEF")]
        public float? RAWBEEF { get; set; }

        [JsonPropertyName("ENCHANTED_SUGAR")]
        public float? ENCHANTEDSUGAR { get; set; }

        [JsonPropertyName("ENCHANTED_MELON")]
        public float? ENCHANTEDMELON { get; set; }

        [JsonPropertyName("ENCHANTED_STRING")]
        public float? ENCHANTEDSTRING { get; set; }

        [JsonPropertyName("WOOL")]
        public float? WOOL { get; set; }

        [JsonPropertyName("ENCHANTED_EMERALD")]
        public float? ENCHANTEDEMERALD { get; set; }

        [JsonPropertyName("ENCHANTED_REDSTONE")]
        public float? ENCHANTEDREDSTONE { get; set; }

        [JsonPropertyName("ENCHANTED_SNOW_BLOCK")]
        public float? ENCHANTEDSNOWBLOCK { get; set; }

        [JsonPropertyName("SNOW_BALL")]
        public float? SNOWBALL { get; set; }

        [JsonPropertyName("ENCHANTED_COAL")]
        public float? ENCHANTEDCOAL { get; set; }

        [JsonPropertyName("ENCHANTED_CLAY_BALL")]
        public float? ENCHANTEDCLAYBALL { get; set; }

        [JsonPropertyName("ENCHANTED_ACACIA_LOG")]
        public float? ENCHANTEDACACIALOG { get; set; }

        [JsonPropertyName("ENCHANTED_MITHRIL")]
        public float? ENCHANTEDMITHRIL { get; set; }

        [JsonPropertyName("ENCHANTED_RABBIT")]
        public float? ENCHANTEDRABBIT { get; set; }

        [JsonPropertyName("RABBIT_HIDE")]
        public float? RABBITHIDE { get; set; }

        [JsonPropertyName("RABBIT_FOOT")]
        public float? RABBITFOOT { get; set; }

        [JsonPropertyName("ENCHANTED_GLOWSTONE_DUST")]
        public float? ENCHANTEDGLOWSTONEDUST { get; set; }

        [JsonPropertyName("ENCHANTED_SAND")]
        public float? ENCHANTEDSAND { get; set; }

        [JsonPropertyName("HARD_STONE")]
        public float? HARDSTONE { get; set; }

        [JsonPropertyName("GEMSTONE_COLLECTION")]
        public float? GEMSTONECOLLECTION { get; set; }

        [JsonPropertyName("DIAMOND_BLOCK")]
        public float? DIAMONDBLOCK { get; set; }
    }

    public class EnderChestContents
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class WardrobeContents
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class PotionBag
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class PersonalVaultContents
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class InvContents
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

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
        public float? FirstJoinHub { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

//        [JsonPropertyName("objectives")]
//        public Objectives Objectives { get; set; }

        [JsonPropertyName("tutorial")]
        public List<string> Tutorial { get; set; }

        [JsonPropertyName("quests")]
        public Quests Quests { get; set; }

        [JsonPropertyName("coin_purse")]
        public double? CoinPurse { get; set; }

        [JsonPropertyName("last_death")]
        public float? LastDeath { get; set; }

        [JsonPropertyName("crafted_generators")]
        public List<string> CraftedGenerators { get; set; }

        [JsonPropertyName("visited_zones")]
        public List<string> VisitedZones { get; set; }

        [JsonPropertyName("fairy_souls_collected")]
        public float? FairySoulsCollected { get; set; }

        [JsonPropertyName("fairy_souls")]
        public float? FairySouls { get; set; }

        [JsonPropertyName("fairy_exchanges")]
        public float? FairyExchanges { get; set; }

        [JsonPropertyName("death_count")]
        public float? DeathCount { get; set; }

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
        public double? ExperienceSkillRunecrafting { get; set; }

        [JsonPropertyName("experience_skill_mining")]
        public double? ExperienceSkillMining { get; set; }

        [JsonPropertyName("unlocked_coll_tiers")]
        public List<string> UnlockedCollTiers { get; set; }

        [JsonPropertyName("experience_skill_alchemy")]
        public double? ExperienceSkillAlchemy { get; set; }

        [JsonPropertyName("quiver")]
        public Quiver Quiver { get; set; }

        [JsonPropertyName("experience_skill_taming")]
        public double? ExperienceSkillTaming { get; set; }

        [JsonPropertyName("sacks_counts")]
        public SacksCounts SacksCounts { get; set; }

        [JsonPropertyName("essence_undead")]
        public float? EssenceUndead { get; set; }

        [JsonPropertyName("talisman_bag")]
        public TalismanBag TalismanBag { get; set; }

        [JsonPropertyName("backpack_icons")]
        public BackpackIcons BackpackIcons { get; set; }

        [JsonPropertyName("experience_skill_combat")]
        public double? ExperienceSkillCombat { get; set; }

        [JsonPropertyName("essence_diamond")]
        public float? EssenceDiamond { get; set; }

        [JsonPropertyName("experience_skill_farming")]
        public double? ExperienceSkillFarming { get; set; }

        [JsonPropertyName("wardrobe_equipped_slot")]
        public float? WardrobeEquippedSlot { get; set; }

        [JsonPropertyName("collection")]
        public Collection Collection { get; set; }

        [JsonPropertyName("essence_dragon")]
        public float? EssenceDragon { get; set; }

        [JsonPropertyName("ender_chest_contents")]
        public EnderChestContents EnderChestContents { get; set; }

        [JsonPropertyName("wardrobe_contents")]
        public WardrobeContents WardrobeContents { get; set; }

        [JsonPropertyName("potion_bag")]
        public PotionBag PotionBag { get; set; }

        [JsonPropertyName("experience_skill_enchanting")]
        public double? ExperienceSkillEnchanting { get; set; }

        [JsonPropertyName("personal_vault_contents")]
        public PersonalVaultContents PersonalVaultContents { get; set; }

        [JsonPropertyName("inv_contents")]
        public InvContents InvContents { get; set; }

        [JsonPropertyName("essence_wither")]
        public float? EssenceWither { get; set; }

        [JsonPropertyName("essence_spider")]
        public float? EssenceSpider { get; set; }

        [JsonPropertyName("experience_skill_foraging")]
        public double? ExperienceSkillForaging { get; set; }

        [JsonPropertyName("experience_skill_carpentry")]
        public double? ExperienceSkillCarpentry { get; set; }

        [JsonPropertyName("fishing_treasure_caught")]
        public float? FishingTreasureCaught { get; set; }

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
        public float? EssenceGold { get; set; }

        [JsonPropertyName("experience_skill_fishing")]
        public double? ExperienceSkillFishing { get; set; }

        [JsonPropertyName("essence_ice")]
        public float? EssenceIce { get; set; }

        [JsonPropertyName("candy_inventory_contents")]
        public CandyInventoryContents CandyInventoryContents { get; set; }

        [JsonPropertyName("current_area")]
        public string CurrentArea { get; set; }
    }

    public class Ench
    {
        [JsonPropertyName("lvl")]
        public float? Lvl { get; set; }

        [JsonPropertyName("id")]
        public float? Id { get; set; }
    }

    public class Display
    {
        [JsonPropertyName("Lore")]
        public List<string> Lore { get; set; }

        [JsonPropertyName("color")]
        public float? Color { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }

    public class Enchantments
    {
        [JsonPropertyName("depth_strider")]
        public float? DepthStrider { get; set; }

        [JsonPropertyName("thorns")]
        public float? Thorns { get; set; }

        [JsonPropertyName("feather_falling")]
        public float? FeatherFalling { get; set; }

        [JsonPropertyName("protection")]
        public float? Protection { get; set; }

        [JsonPropertyName("growth")]
        public float? Growth { get; set; }

        [JsonPropertyName("fire_protection")]
        public float? FireProtection { get; set; }

        [JsonPropertyName("syphon")]
        public float? Syphon { get; set; }

        [JsonPropertyName("sharpness")]
        public float? Sharpness { get; set; }

        [JsonPropertyName("telekinesis")]
        public float? Telekinesis { get; set; }

        [JsonPropertyName("vampirism")]
        public float? Vampirism { get; set; }

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
        public float? Efficiency { get; set; }

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
        public float? Harvesting { get; set; }

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
        public float? Impaling { get; set; }

        [JsonPropertyName("cleave")]
        public float? Cleave { get; set; }

        [JsonPropertyName("thunderbolt")]
        public float? Thunderbolt { get; set; }

        [JsonPropertyName("fire_aspect")]
        public float? FireAspect { get; set; }

        [JsonPropertyName("venomous")]
        public float? Venomous { get; set; }

        [JsonPropertyName("cubism")]
        public float? Cubism { get; set; }

        [JsonPropertyName("PROSECUTE")]
        public float? PROSECUTE { get; set; }

        [JsonPropertyName("lethality")]
        public float? Lethality { get; set; }

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
        public float? BaseStatBoostPercentage { get; set; }

        [JsonPropertyName("modifier")]
        public string Modifier { get; set; }

        [JsonPropertyName("originTag")]
        public string OriginTag { get; set; }

        [JsonPropertyName("item_durability")]
        public float? ItemDurability { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("enchantments")]
        public Enchantments Enchantments { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("item_tier")]
        public float? ItemTier { get; set; }

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
        public float? PotionLevel { get; set; }

        [JsonPropertyName("enhanced")]
        public float? Enhanced { get; set; }

        [JsonPropertyName("potion")]
        public string Potion { get; set; }

        [JsonPropertyName("effects")]
        public List<Effect> Effects { get; set; }

        [JsonPropertyName("potion_type")]
        public string PotionType { get; set; }

        [JsonPropertyName("extended")]
        public float? Extended { get; set; }

        [JsonPropertyName("anvil_uses")]
        public int? AnvilUses { get; set; }

        [JsonPropertyName("zombie_kills")]
        public float? ZombieKills { get; set; }

        [JsonPropertyName("gems")]
        public Gems Gems { get; set; }

        [JsonPropertyName("edition")]
        public int? Edition { get; set; }

        [JsonPropertyName("dungeon_item_level")]
        public float? DungeonItemLevel { get; set; }

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
        public float? HideFlags { get; set; }

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
        public float? Hpbs { get; set; }

        [JsonPropertyName("anvil_uses")]
        public float? AnvilUses { get; set; }

        [JsonPropertyName("timestamp")]
        public object Timestamp { get; set; }

        [JsonPropertyName("base_stat_boost")]
        public float? BaseStatBoost { get; set; }

        [JsonPropertyName("floor")]
        public float? Floor { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("texture_path")]
        public string TexturePath { get; set; }
    }

    public class Inventory
    {
        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? Ambient { get; set; }

        [JsonPropertyName("Duration")]
        public float? Duration { get; set; }

        [JsonPropertyName("Id")]
        public float? Id { get; set; }

        [JsonPropertyName("Amplifier")]
        public float? Amplifier { get; set; }
    }

    public class Modifiers
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("amp")]
        public float? Amp { get; set; }

        [JsonPropertyName("caffeinated")]
        public int? Caffeinated { get; set; }
    }

    public class Effect
    {
        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("effect")]
        public string EffectProperty { get; set; }

        [JsonPropertyName("duration_ticks")]
        public float? DurationTicks { get; set; }

        [JsonPropertyName("modifiers")]
        public Modifiers Modifiers { get; set; }
    }

    public class PersonalVault
    {
        [JsonPropertyName("item_index")]
        public float? ItemIndex { get; set; }

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
        public float? Count { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("glowing")]
        public bool Glowing { get; set; }

        [JsonPropertyName("position")]
        public float? Position { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class HighestRarityBow
    {
        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class HighestRarityPickaxe
    {
        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class FairySouls
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }
    }

    public class Taming
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Farming
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }

        [JsonPropertyName("talked")]
        public bool Talked { get; set; }

        [JsonPropertyName("current_badges")]
        public CurrentBadges CurrentBadges { get; set; }

        [JsonPropertyName("total_badges")]
        public TotalBadges TotalBadges { get; set; }

        [JsonPropertyName("perks")]
        public Perks Perks { get; set; }

        [JsonPropertyName("unique_golds")]
        public float? UniqueGolds { get; set; }

        [JsonPropertyName("crops")]
        public Crops Crops { get; set; }
    }

    public class Mining
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }

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
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public double? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public double? DamageIncrease { get; set; }
    }

    public class Foraging
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Fishing
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("treasure")]
        public float? Treasure { get; set; }

        [JsonPropertyName("treasure_large")]
        public float? TreasureLarge { get; set; }

        [JsonPropertyName("shredder_fished")]
        public float? ShredderFished { get; set; }

        [JsonPropertyName("shredder_bait")]
        public float? ShredderBait { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Enchanting
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public double? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }

        [JsonPropertyName("experimented")]
        public bool Experimented { get; set; }

        [JsonPropertyName("experiments")]
        public Experiments Experiments { get; set; }
    }

    public class Alchemy
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Carpentry
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Runecrafting
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("rank")]
        public float? Rank { get; set; }

        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
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
        public float? Farming { get; set; }
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
        public float? Total { get; set; }

        [JsonPropertyName("zombie")]
        public float? Zombie { get; set; }

        [JsonPropertyName("spider")]
        public float? Spider { get; set; }

        [JsonPropertyName("wolf")]
        public float? Wolf { get; set; }

        [JsonPropertyName("enderman")]
        public float? Enderman { get; set; }
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
        public float? WeightProperty { get; set; }

        [JsonPropertyName("weight_overflow")]
        public float? WeightOverflow { get; set; }
    }

    public class Kills
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("entityName")]
        public string EntityName { get; set; }

        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }
    }

    public class Slayers
    {
        [JsonPropertyName("spider")]
        public Slayer Spider { get; set; }

        [JsonPropertyName("wolf")]
        public Slayer Wolf { get; set; }

        [JsonPropertyName("zombie")]
        public Slayer Zombie { get; set; }

        [JsonPropertyName("enderman")]
        public Slayer Enderman { get; set; }
    }

    public class SlayerLevel
    {
        [JsonPropertyName("currentLevel")]
        public int CurrentLevel { get; set; }

        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }
    }

    public class SlayerKills
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
    }


    public class Slayer
    {
        [JsonPropertyName("level")]
        public SlayerLevel Level { get; set; }

        [JsonPropertyName("kills")]
        public SlayerKills Kills { get; set; }

        [JsonPropertyName("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonPropertyName("boss_kills_tier_0")]
        public int BossKillsTier0 { get; set; }

        [JsonPropertyName("xp")]
        public int Xp { get; set; }

        [JsonPropertyName("boss_kills_tier_1")]
        public int BossKillsTier1 { get; set; }

        [JsonPropertyName("boss_kills_tier_2")]
        public int BossKillsTier2 { get; set; }

        [JsonPropertyName("boss_kills_tier_3")]
        public int BossKillsTier3 { get; set; }

        [JsonPropertyName("boss_kills_tier_4")]
        public int BossKillsTier4 { get; set; }
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
        public float? Exp { get; set; }

        [JsonPropertyName("tier")]
        public string Tier { get; set; }

        [JsonPropertyName("candyUsed")]
        public float? CandyUsed { get; set; }

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
        public double? Strength { get; set; }

        [JsonPropertyName("crit_chance")]
        public double? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("intelligence")]
        public double? Intelligence { get; set; }

        [JsonPropertyName("magic_find")]
        public double? MagicFind { get; set; }

        [JsonPropertyName("defense")]
        public double? Defense { get; set; }

        [JsonPropertyName("health")]
        public double? Health { get; set; }
    }

    public class PetScoreBonus
    {
        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }
    }

    public class BaseStats
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public double? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public double? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public double? DamageIncrease { get; set; }
    }

    public class _6b3b90c23cbb45789657E05377f26858
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class F05348d31cb44db598b01eabeca24944
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Aadef92c635a4d8eAcfdF8c3bfa6a817
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _15a2792029344178898703eb78f5bbaa
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _22eba515F39047f18b7a50643b290707
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _4830b3e8Ae554ef7A90e1adb2a24c5c2
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class B474b8116acf4cb6Afed7f67ecfa20a4
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
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
        public float? Amount { get; set; }

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
        public float? Exp { get; set; }

        [JsonPropertyName("gm")]
        public string Gm { get; set; }

        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonPropertyName("members")]
        public float? Members { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

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
        public float? MaxLevel { get; set; }

        [JsonPropertyName("levels")]
        public List<int> Levels { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("head")]
        public string Head { get; set; }

        [JsonPropertyName("tiers")]
        public float? Tiers { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class MinionSlots
    {
        [JsonPropertyName("currentSlots")]
        public float? CurrentSlots { get; set; }

        [JsonPropertyName("toNext")]
        public float? ToNext { get; set; }

        [JsonPropertyName("toNextSlot")]
        public float? ToNextSlot { get; set; }
    }

    public class Amount
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("amount")]
        public float? AmountPropery { get; set; }
    }

    public class INKSACK3
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class MELON
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class MUSHROOMCOLLECTION
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }


    public class CACTUS
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class CARROTITEM
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class POTATOITEM
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class NETHERSTALK
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class WHEAT
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class SUGARCANE
    {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }

    public class CollectionItem
        {
        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public double? Value { get; set; }
    }

    public class Floors
    {
        [JsonPropertyName("catacombs_1")]
        public float? Catacombs1 { get; set; }

        [JsonPropertyName("master_catacombs_1")]
        public float? MasterCatacombs1 { get; set; }

        [JsonPropertyName("catacombs_2")]
        public float? Catacombs2 { get; set; }

        [JsonPropertyName("catacombs_3")]
        public float? Catacombs3 { get; set; }

        [JsonPropertyName("catacombs_4")]
        public float? Catacombs4 { get; set; }

        [JsonPropertyName("catacombs_5")]
        public float? Catacombs5 { get; set; }

        [JsonPropertyName("catacombs_6")]
        public float? Catacombs6 { get; set; }

        [JsonPropertyName("catacombs_7")]
        public float? Catacombs7 { get; set; }
    }

    public class Bonuses
    {
        [JsonPropertyName("item_boost")]
        public float? ItemBoost { get; set; }
    }

    public class Experience
    {
        [JsonPropertyName("xp")]
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }
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
        public float? Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public float? Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public float? Unclaimed { get; set; }

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
        public float? PagesCollected { get; set; }

        [JsonPropertyName("journals_completed")]
        public float? JournalsCompleted { get; set; }

        [JsonPropertyName("total_pages")]
        public float? TotalPages { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }
    }

    public class CurrentBadges
    {
        [JsonPropertyName("bronze")]
        public float? Bronze { get; set; }

        [JsonPropertyName("silver")]
        public float? Silver { get; set; }

        [JsonPropertyName("gold")]
        public float? Gold { get; set; }
    }

    public class TotalBadges
    {
        [JsonPropertyName("bronze")]
        public float? Bronze { get; set; }

        [JsonPropertyName("silver")]
        public float? Silver { get; set; }

        [JsonPropertyName("gold")]
        public float? Gold { get; set; }
    }

    public class Badges
    {
        [JsonPropertyName("gold")]
        public float? Gold { get; set; }

        [JsonPropertyName("silver")]
        public float? Silver { get; set; }

        [JsonPropertyName("bronze")]
        public float? Bronze { get; set; }
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
        public float? Contests { get; set; }

        [JsonPropertyName("personal_best")]
        public float? PersonalBest { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }

        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("totalAmount")]
        public float? TotalAmount { get; set; }

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
        public float? Collected { get; set; }

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
        public double? Xp { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public float? MaxLevel { get; set; }

        [JsonPropertyName("xpCurrent")]
        public double? XpCurrent { get; set; }

        [JsonPropertyName("xpForNext")]
        public double? XpForNext { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("levelCap")]
        public double? LevelCap { get; set; }

        [JsonPropertyName("uncappedLevel")]
        public float? UncappedLevel { get; set; }

        [JsonPropertyName("levelWithProgress")]
        public double? LevelWithProgress { get; set; }

        [JsonPropertyName("level_cap")]
        public double? Level_Cap { get; set; }

        [JsonPropertyName("uncapped_level")]
        public float? Uncapped_Level { get; set; }
    }

    public class Tokens
    {
        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("spent")]
        public float? Spent { get; set; }

        [JsonPropertyName("available")]
        public float? Available { get; set; }
    }

    public class Mithril
    {
        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("spent")]
        public float? Spent { get; set; }

        [JsonPropertyName("available")]
        public float? Available { get; set; }
    }

    public class Gemstone
    {
        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("spent")]
        public float? Spent { get; set; }

        [JsonPropertyName("available")]
        public float? Available { get; set; }
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
        public float? TimesCompleted { get; set; }

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
        public float? OresMined { get; set; }

        [JsonPropertyName("sea_creatures_killed")]
        public float? SeaCreaturesKilled { get; set; }
    }

    public class Races
    {
        [JsonPropertyName("foraging_race_best_time")]
        public float? ForagingRaceBestTime { get; set; }

        [JsonPropertyName("end_race_best_time")]
        public float? EndRaceBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_anything_no_return_best_time")]
        public float? DungeonHubCrystalCoreAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_giant_mushroom_anything_no_return_best_time")]
        public float? DungeonHubGiantMushroomAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_precursor_ruins_anything_no_return_best_time")]
        public float? DungeonHubPrecursorRuinsAnythingNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_no_pearls_no_return_best_time")]
        public float? DungeonHubCrystalCoreNoPearlsNoReturnBestTime { get; set; }

        [JsonPropertyName("dungeon_hub_crystal_core_no_abilities_no_return_best_time")]
        public float? DungeonHubCrystalCoreNoAbilitiesNoReturnBestTime { get; set; }
    }

    public class Gifts
    {
        [JsonPropertyName("gifts_received")]
        public float? GiftsReceived { get; set; }

        [JsonPropertyName("gifts_given")]
        public float? GiftsGiven { get; set; }
    }

    public class Damage
    {
        [JsonPropertyName("highest_critical_damage")]
        public double? HighestCriticalDamage { get; set; }
    }

    public class ProfileUpgrades
    {
        [JsonPropertyName("island_size")]
        public float? IslandSize { get; set; }

        [JsonPropertyName("minion_slots")]
        public float? MinionSlots { get; set; }

        [JsonPropertyName("guests_count")]
        public float? GuestsCount { get; set; }

        [JsonPropertyName("coop_slots")]
        public float? CoopSlots { get; set; }

        [JsonPropertyName("coins_allowance")]
        public float? CoinsAllowance { get; set; }
    }

    public class AuctionsSell
    {
        [JsonPropertyName("fees")]
        public double? Fees { get; set; }

        [JsonPropertyName("gold_earned")]
        public double? GoldEarned { get; set; }

        [JsonPropertyName("items_sold")]
        public float? ItemsSold { get; set; }
    }

    public class AuctionsBuy
    {
        [JsonPropertyName("bids")]
        public float? Bids { get; set; }

        [JsonPropertyName("highest_bid")]
        public long HighestBid { get; set; }

        [JsonPropertyName("won")]
        public float? Won { get; set; }

        [JsonPropertyName("gold_spent")]
        public double? GoldSpent { get; set; }

        [JsonPropertyName("items_bought")]
        public float? ItemsBought { get; set; }
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
        public float? Common { get; set; }

        [JsonPropertyName("epic")]
        public float? Epic { get; set; }

        [JsonPropertyName("uncommon")]
        public float? Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public float? Rare { get; set; }

        [JsonPropertyName("legendary")]
        public float? Legendary { get; set; }

        [JsonPropertyName("special")]
        public float? Special { get; set; }
    }

    public class AuctionsSold
    {
        [JsonPropertyName("epic")]
        public float? Epic { get; set; }

        [JsonPropertyName("common")]
        public float? Common { get; set; }

        [JsonPropertyName("legendary")]
        public float? Legendary { get; set; }

        [JsonPropertyName("uncommon")]
        public float? Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public float? Rare { get; set; }

        [JsonPropertyName("special")]
        public float? Special { get; set; }
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
        public double? AverageLevel { get; set; }

        [JsonPropertyName("average_level_no_progress")]
        public double? AverageLevelNoProgress { get; set; }

        [JsonPropertyName("total_skill_xp")]
        public double? TotalSkillXp { get; set; }

        [JsonPropertyName("average_level_rank")]
        public float? AverageLevelRank { get; set; }

        [JsonPropertyName("level_caps")]
        public LevelCaps LevelCaps { get; set; }

        [JsonPropertyName("skill_bonus")]
        public SkillBonus SkillBonus { get; set; }

        [JsonPropertyName("slayer_coins_spent")]
        public SlayerCoinsSpent SlayerCoinsSpent { get; set; }

        [JsonPropertyName("slayer_bonus")]
        public SlayerBonus SlayerBonus { get; set; }

        [JsonPropertyName("slayer_xp")]
        public float? SlayerXp { get; set; }

        [JsonPropertyName("slayers")]
        public Slayers Slayers { get; set; }

        [JsonPropertyName("missingTalismans")]
        public MissingTalismans MissingTalismans { get; set; }

        [JsonPropertyName("talismanCount")]
        public float? TalismanCount { get; set; }

        [JsonPropertyName("pets")]
        public List<Pet> Pets { get; set; }

        [JsonPropertyName("missingPets")]
        public List<MissingPet> MissingPets { get; set; }

        [JsonPropertyName("petScore")]
        public float? PetScore { get; set; }

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
        public float? WardrobeEquippedSlot { get; set; }

        [JsonPropertyName("bank")]
        public double? Bank { get; set; }

        [JsonPropertyName("guild")]
        public Guild Guild { get; set; }

        [JsonPropertyName("rank_prefix")]
        public string RankPrefix { get; set; }

        [JsonPropertyName("purse")]
        public double? Purse { get; set; }

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
        public double? DungeonsWeight { get; set; }

        [JsonPropertyName("skillWeight")]
        public double? SkillWeight { get; set; }

        [JsonPropertyName("slayerWeight")]
        public double? SlayerWeight { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFarmer2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseFarmingSkill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class WarpBarnIsland
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class ActiveEffect
    {
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("level")]
        public double? Level { get; set; }

        [JsonPropertyName("modifiers")]
        public List<object> Modifiers { get; set; }

        [JsonPropertyName("ticks_remaining")]
        public float? TicksRemaining { get; set; }

        [JsonPropertyName("infinite")]
        public bool Infinite { get; set; }
    }

    public class Ho
    {
        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }

        [JsonPropertyName("isInactive")]
        public bool IsInactive { get; set; }

        [JsonPropertyName("inBackpack")]
        public bool InBackpack { get; set; }

        [JsonPropertyName("backpackIndex")]
        public float? BackpackIndex { get; set; }
    }

    public class HighestRarityHoe
    {
        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class _586ce947A73c4f6dBec525436f57940c
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }

        [JsonPropertyName("true defense")]
        public object TrueDefense { get; set; }
    }

    public class IncreaseForagingSkill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class WarpForagingIslands
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectBirchLogs
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFarmhand2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectFarmingResources
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToBartender
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class IncreaseCombatSkill
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class WarpSpidersDen
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectClay
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToCharlie
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToHaymitch
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectSpider
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToFisherman2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuber2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheEndRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuber3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheEndRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CollectNetherResources
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

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
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheEndRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToMelody
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGustave3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheWoodsRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGustave4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheWoodsRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuber5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGustave5
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNoPearlsWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNoAbilitiesWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNothingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNoPearlsWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNoAbilitiesWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNothingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoAbilitiesWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNothingWithReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNoPearlsNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNoAbilitiesNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomNothingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNoPearlsNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNoAbilitiesNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsNothingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoAbilitiesNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNothingNoReturnRace1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordGiantMushroomAnythingNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordGiantMushroomAnythingNoReturn2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingNoReturnRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordGiantMushroomAnythingNoReturn3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheGiantMushroomAnythingNoReturnRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordGiantMushroomAnythingNoReturn4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordPrecursorRuinsAnythingNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordPrecursorRuinsAnythingNoReturn2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingNoReturnRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordPrecursorRuinsAnythingNoReturn3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteThePrecursorRuinsAnythingNoReturnRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordPrecursorRuinsAnythingNoReturn4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreAnythingNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreAnythingNoReturn2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingNoReturnRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreAnythingNoReturn3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreAnythingNoReturnRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoPearlsNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoPearlsNoReturn2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsNoReturnRace3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoPearlsNoReturn3
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoPearlsNoReturnRace4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoPearlsNoReturn4
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGuildfordCrystalCoreNoAbilitiesNoReturn1
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTheCrystalCoreNoAbilitiesNoReturnRace2
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur261
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur271
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur281
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur12
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur22
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur32
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur42
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur52
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur62
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur72
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToArchaeologist
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToShaggy
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindRelics
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindUberRelics
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur182
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur192
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur232
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur262
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur272
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur292
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur43
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur63
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur83
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur133
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur163
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur193
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur233
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur293
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur303
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur64
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur104
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur114
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur124
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur134
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur154
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur184
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur214
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur224
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur45
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur265
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToGwendolyn
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class TalkToBraum
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class VisitGreaterMines
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToTheGoblinKing
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class KillAutomatons
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class EnterDivanMines
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class FindAJungleKey
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }

        [JsonPropertyName("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonPropertyName("activated_at_sb")]
        public float? ActivatedAtSb { get; set; }

        [JsonPropertyName("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public class MineRuby
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class TalkToProfessorRobot
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindFourMissingPieces
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineJade
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineSapphire
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FindTheGoblinQueen
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineAmber
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class CompleteTrialsOfJungleTemple
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class MineAmethyst
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur158
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur208
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur218
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur39
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur69
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur79
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur109
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur199
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class Fetchur219
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("completed_at")]
        public long CompletedAt { get; set; }
    }

    public class FastestTimeS
    {
        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("4")]
        public float? _4 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }
    }

    public class FastestTimeSPlus
    {
        [JsonPropertyName("1")]
        public float? _1 { get; set; }

        [JsonPropertyName("2")]
        public float? _2 { get; set; }

        [JsonPropertyName("3")]
        public float? _3 { get; set; }

        [JsonPropertyName("5")]
        public float? _5 { get; set; }

        [JsonPropertyName("6")]
        public float? _6 { get; set; }

        [JsonPropertyName("7")]
        public float? _7 { get; set; }
    }

    public class MostDamageBerserk
    {
        [JsonPropertyName("0")]
        public double? _0 { get; set; }

        [JsonPropertyName("1")]
        public double? _1 { get; set; }

        [JsonPropertyName("2")]
        public double? _2 { get; set; }

        [JsonPropertyName("3")]
        public double? _3 { get; set; }

        [JsonPropertyName("5")]
        public double? _5 { get; set; }
    }

    public class Burrow
    {
        [JsonPropertyName("ts")]
        public object Ts { get; set; }

        [JsonPropertyName("x")]
        public float? X { get; set; }

        [JsonPropertyName("y")]
        public float? Y { get; set; }

        [JsonPropertyName("z")]
        public float? Z { get; set; }

        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("chain")]
        public float? Chain { get; set; }

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
        public float? Collected { get; set; }
    }

    public class _105915PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _105915SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1051110PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1051122NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1051122WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1051125SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _106117SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _106414SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _106423WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _106612CACTUS
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _107117SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _10745PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _10745CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _107612SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _107612CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1071029POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _107114POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _108414NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1081017NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1081017SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1081215NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _10915NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _109321CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _109828NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _109927POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1091212CACTUS
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1091212WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1091221PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _110222MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _110312PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _110516CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _110921POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _112321PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _11312WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _11312SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _113123PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _113126SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1131026NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1131026MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _113111SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1131215PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114213SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _11433PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114315WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114318PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _114318SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114321PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114525SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _114528PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _11554SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _125330PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1251227CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _131123POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _131312PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _131321CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13142POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13142WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _13145NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13187SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13187WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _131816SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1311014CACTUS
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1311017MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _13215MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _13348MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13354MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _133519POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _133525MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _133525CACTUS
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _134927SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _134930PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1341128POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _135426WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13572SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13593NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1351119SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1351119WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1351230SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13627SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _13627WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _136321SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _136411SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _136414CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13669SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _136615PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _136630SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _136723SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13712PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _137123WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _137327PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _137330SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1371026PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13866MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13869PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _13887PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _139312WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _139510NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _139513PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _139729POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1391122POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1391215POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _140429SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _141918POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _141921SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _142417NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _142420WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _14293PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _143810PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _143813POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _14412CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _144315PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _144102SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1441224CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _145510SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _145129MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _14657POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _147120SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _147426NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _147426CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _147711MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _14796WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _147915CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1471119NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _14845NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _149117POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _149111CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1501221POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1501224CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _15254POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _153213PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _15581PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _15687POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1561221CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1571212POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _158717NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _158918WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1581128POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1581131WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _159210PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _159711PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1591017POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _16039PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _160411CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _160414CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _160414NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1601230WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _161330MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _1611023SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _162516NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _162729SUGARCANE
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _162813MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _16336PUMPKIN
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _16339POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _163510MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _163717POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _1631212MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _16451POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _16599NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _166129MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _16693POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _167114NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _167813NETHERSTALK
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _168315MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _168921POTATOITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class HarpQuest
    {
        [JsonPropertyName("selected_song")]
        public string SelectedSong { get; set; }

        [JsonPropertyName("selected_song_epoch")]
        public long SelectedSongEpoch { get; set; }

        [JsonPropertyName("song_hymn_joy_best_completion")]
        public double? SongHymnJoyBestCompletion { get; set; }

        [JsonPropertyName("song_hymn_joy_completions")]
        public double? SongHymnJoyCompletions { get; set; }

        [JsonPropertyName("song_hymn_joy_perfect_completions")]
        public double? SongHymnJoyPerfectCompletions { get; set; }

        [JsonPropertyName("song_frere_jacques_best_completion")]
        public double? SongFrereJacquesBestCompletion { get; set; }

        [JsonPropertyName("song_frere_jacques_completions")]
        public double? SongFrereJacquesCompletions { get; set; }

        [JsonPropertyName("song_amazing_grace_completions")]
        public double? SongAmazingGraceCompletions { get; set; }

        [JsonPropertyName("song_amazing_grace_best_completion")]
        public double? SongAmazingGraceBestCompletion { get; set; }

        [JsonPropertyName("song_amazing_grace_perfect_completions")]
        public double? SongAmazingGracePerfectCompletions { get; set; }

        [JsonPropertyName("s")]
        public double? SongBrahmsBestCompletion { get; set; }

        [JsonPropertyName("song_brahms_completions")]
        public double? SongBrahmsCompletions { get; set; }

        [JsonPropertyName("song_brahms_perfect_completions")]
        public double? SongBrahmsPerfectCompletions { get; set; }

        [JsonPropertyName("song_happy_birthday_best_completion")]
        public double? SongHappyBirthdayBestCompletion { get; set; }

        [JsonPropertyName("song_happy_birthday_completions")]
        public double? SongHappyBirthdayCompletions { get; set; }

        [JsonPropertyName("song_happy_birthday_perfect_completions")]
        public double? SongHappyBirthdayPerfectCompletions { get; set; }

        [JsonPropertyName("song_greensleeves_best_completion")]
        public double? SongGreensleevesBestCompletion { get; set; }

        [JsonPropertyName("song_greensleeves_completions")]
        public double? SongGreensleevesCompletions { get; set; }
    }

    public class JadeCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public float? TotalPlaced { get; set; }
    }

    public class AmberCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public float? TotalPlaced { get; set; }
    }

    public class TopazCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public float? TotalPlaced { get; set; }
    }

    public class SapphireCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public float? TotalPlaced { get; set; }
    }

    public class AmethystCrystal
    {
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("total_placed")]
        public float? TotalPlaced { get; set; }
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
        public float? KingQuestsCompleted { get; set; }
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
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _9
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _10
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _122
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _13
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _16
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class _17
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

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
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class CandyInventoryContents
    {
        [JsonPropertyName("type")]
        public float? Type { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }

    public class Gems
    {
        [JsonPropertyName("COMBAT_0")]
        public object COMBAT0 { get; set; }

        [JsonPropertyName("COMBAT_0_gem")]
        public object COMBAT0Gem { get; set; }

        [JsonPropertyName("RUBY_0")]
        public object RUBY0 { get; set; }

        [JsonPropertyName("SAPPHIRE_0")]
        public object SAPPHIRE0 { get; set; }

        [JsonPropertyName("RUBY_3")]
        public object RUBY3 { get; set; }

        [JsonPropertyName("RUBY_1")]
        public object RUBY1 { get; set; }

        [JsonPropertyName("RUBY_2")]
        public object RUBY2 { get; set; }

        [JsonPropertyName("JADE_0")]
        public object JADE0 { get; set; }

        [JsonPropertyName("UNIVERSAL_0")]
        public object UNIVERSAL0 { get; set; }

        [JsonPropertyName("AMBER_0")]
        public object AMBER0 { get; set; }

        [JsonPropertyName("UNIVERSAL_0_gem")]
        public object UNIVERSAL0Gem { get; set; }

        [JsonPropertyName("JASPER_0")]
        public object JASPER0 { get; set; }

        [JsonPropertyName("AMETHYST_2")]
        public object AMETHYST2 { get; set; }

        [JsonPropertyName("AMETHYST_1")]
        public object AMETHYST1 { get; set; }

        [JsonPropertyName("AMETHYST_0")]
        public object AMETHYST0 { get; set; }

        [JsonPropertyName("RUBY_4")]
        public object RUBY4 { get; set; }

        [JsonPropertyName("JASPER_1")]
        public object JASPER1 { get; set; }

        [JsonPropertyName("TOPAZ_0")]
        public object TOPAZ0 { get; set; }
    }

    public class ContainsItem
    {
        [JsonPropertyName("isInactive")]
        public bool IsInactive { get; set; }

        [JsonPropertyName("inBackpack")]
        public bool InBackpack { get; set; }

        [JsonPropertyName("item_index")]
        public float? ItemIndex { get; set; }

        [JsonPropertyName("backpackIndex")]
        public float? BackpackIndex { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

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
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class HighestRarityRod
    {
        [JsonPropertyName("id")]
        public float? Id { get; set; }

        [JsonPropertyName("Count")]
        public float? Count { get; set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        [JsonPropertyName("Damage")]
        public float? Damage { get; set; }

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
        public float? ItemIndex { get; set; }

        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    }

    public class _1ecf4f14F74d497aBd1dA6a565b84471
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _65157459Dc6a4914Bd6eCe994305451c
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _98cc7e5350de4e97819e8e487b4c059b
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class D24731f9E64b4efaA6a4Dece489e8cd6
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class A0989e023eb2460fBdca22747b9c8930
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class B6b360d9Ea97413b9cfe927ee9d5dde0
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _59b87a214ecc47c8B4750a7c92dc2e52
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class F736618b39424d2797c2994f0512e3a4
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class D04997d11fed4825A028C6386e6ca312
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _0f2b0ac1792f4c30Af94D6916546615c
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _85cb923651e94c86Ad90D17fefb62ec6
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _189317b9D6f24604803e7ffeaad5b6c5
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _5427e50cC6f24f4285e9F47a380f03ec
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class F2a964c201cb4630A2406109c9218827
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _8fa16ff93de74b26A5d219d3d013613f
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Ff4238de4409441d88c57e296c37633d
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class E75df7aa9b9c4e7cB159E63aa3bfb8fd
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class A6684ecb3b8d42e5Beb88b82d021b548
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _9ebf73e140254583B4884f93f06049f7
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Cb0071ec23d9472792a2D997a92d9722
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _1654321527a64072Bbf7F4c229cdad3f
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class E89aa6c0D4a84b0e8caf6696412044f5
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class B4b0876e629d43f4B0e28165ccf3daa4
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class C4449b2348f948a69a16488080d8ac98
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _70d063bc133b40c09efcA8b4801700f2
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class E83a3f42D7de467c979e3b540c85f063
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Bcffd8813f744d479db1811600094860
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Eb81f67fC10f47918e75Fc7c0dbaad42
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Fb3d5307441f495aB4edE0a06c96d272
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _13654f31044541088bc8Fab31f801294
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Fa1ad1aa4ea14cad9840A400d2c013a0
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class _9fd60c4e86b84dc0827b3bdc9dcc0ae2
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Fd738d10466b44e197fbDb46744d05d0
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class D1e4aa8b5abf4ffbB3abBc3e0d942e74
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Catacombs22
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("texture")]
        public string Texture { get; set; }

        [JsonPropertyName("tier")]
        public float? Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public float? Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public float? Unclaimed { get; set; }

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
        public float? Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public float? Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public float? Unclaimed { get; set; }

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
        public float? Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public float? Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public float? Unclaimed { get; set; }

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
        public float? Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public float? Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public float? Unclaimed { get; set; }

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
        public float? Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public float? Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public float? Unclaimed { get; set; }

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
        public float? Tier { get; set; }

        [JsonPropertyName("maxed")]
        public bool Maxed { get; set; }

        [JsonPropertyName("killed")]
        public float? Killed { get; set; }

        [JsonPropertyName("floors")]
        public Floors Floors { get; set; }

        [JsonPropertyName("unclaimed")]
        public float? Unclaimed { get; set; }

        [JsonPropertyName("claimed")]
        public List<object> Claimed { get; set; }
    }

    public class Winter
    {
        [JsonPropertyName("most_winter_snowballs_hit")]
        public float? MostWinterSnowballsHit { get; set; }

        [JsonPropertyName("most_winter_damage_dealt")]
        public float? MostWinterDamageDealt { get; set; }

        [JsonPropertyName("most_winter_magma_damage_dealt")]
        public float? MostWinterMagmaDamageDealt { get; set; }

        [JsonPropertyName("most_winter_cannonballs_hit")]
        public float? MostWinterCannonballsHit { get; set; }
    }

    public class Dragons
    {
        [JsonPropertyName("ender_crystals_destroyed")]
        public float? EnderCrystalsDestroyed { get; set; }

        [JsonPropertyName("last_hits")]
        public float? LastHits { get; set; }

        [JsonPropertyName("deaths")]
        public float? Deaths { get; set; }
    }

    public class Protector
    {
        [JsonPropertyName("last_hits")]
        public float? LastHits { get; set; }
    }

    public class DugNext
    {
        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("null")]
        public float? Null { get; set; }

        [JsonPropertyName("common")]
        public float? Common { get; set; }

        [JsonPropertyName("uncommon")]
        public float? Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public float? Rare { get; set; }

        [JsonPropertyName("epic")]
        public float? Epic { get; set; }

        [JsonPropertyName("legendary")]
        public float? Legendary { get; set; }
    }

    public class DugCombat
    {
        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("null")]
        public float? Null { get; set; }

        [JsonPropertyName("common")]
        public float? Common { get; set; }

        [JsonPropertyName("uncommon")]
        public float? Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public float? Rare { get; set; }

        [JsonPropertyName("epic")]
        public float? Epic { get; set; }

        [JsonPropertyName("legendary")]
        public float? Legendary { get; set; }
    }

    public class DugTreasure
    {
        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("null")]
        public float? Null { get; set; }

        [JsonPropertyName("common")]
        public float? Common { get; set; }

        [JsonPropertyName("uncommon")]
        public float? Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public float? Rare { get; set; }

        [JsonPropertyName("epic")]
        public float? Epic { get; set; }
    }

    public class ChainsComplete
    {
        [JsonPropertyName("total")]
        public float? Total { get; set; }

        [JsonPropertyName("null")]
        public float? Null { get; set; }

        [JsonPropertyName("common")]
        public float? Common { get; set; }

        [JsonPropertyName("uncommon")]
        public float? Uncommon { get; set; }

        [JsonPropertyName("rare")]
        public float? Rare { get; set; }

        [JsonPropertyName("epic")]
        public float? Epic { get; set; }
    }

    public class _154411MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _154414CARROTITEM
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }

        [JsonPropertyName("claimed_rewards")]
        public bool ClaimedRewards { get; set; }

        [JsonPropertyName("claimed_position")]
        public float? ClaimedPosition { get; set; }

        [JsonPropertyName("claimed_participants")]
        public float? ClaimedParticipants { get; set; }
    }

    public class _155129MELON
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _15566MUSHROOMCOLLECTION
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _162810WHEAT
    {
        [JsonPropertyName("collected")]
        public float? Collected { get; set; }
    }

    public class _95d1bd526a184eb2Ac71C71c548d9487
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Cfdca33623ad4a2bAacfF0e64f8909f3
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class F79bbad82da54fdaA9a68a0d77eef4c0
    {
        [JsonPropertyName("health")]
        public float? Health { get; set; }

        [JsonPropertyName("defense")]
        public float? Defense { get; set; }

        [JsonPropertyName("effective_health")]
        public float? EffectiveHealth { get; set; }

        [JsonPropertyName("strength")]
        public float? Strength { get; set; }

        [JsonPropertyName("speed")]
        public float? Speed { get; set; }

        [JsonPropertyName("crit_chance")]
        public float? CritChance { get; set; }

        [JsonPropertyName("crit_damage")]
        public double? CritDamage { get; set; }

        [JsonPropertyName("bonus_attack_speed")]
        public double? BonusAttackSpeed { get; set; }

        [JsonPropertyName("intelligence")]
        public float? Intelligence { get; set; }

        [JsonPropertyName("sea_creature_chance")]
        public float? SeaCreatureChance { get; set; }

        [JsonPropertyName("magic_find")]
        public float? MagicFind { get; set; }

        [JsonPropertyName("pet_luck")]
        public float? PetLuck { get; set; }

        [JsonPropertyName("ferocity")]
        public float? Ferocity { get; set; }

        [JsonPropertyName("ability_damage")]
        public float? AbilityDamage { get; set; }

        [JsonPropertyName("mining_speed")]
        public float? MiningSpeed { get; set; }

        [JsonPropertyName("mining_fortune")]
        public float? MiningFortune { get; set; }

        [JsonPropertyName("farming_fortune")]
        public float? FarmingFortune { get; set; }

        [JsonPropertyName("foraging_fortune")]
        public float? ForagingFortune { get; set; }

        [JsonPropertyName("pristine")]
        public float? Pristine { get; set; }

        [JsonPropertyName("damage")]
        public float? Damage { get; set; }

        [JsonPropertyName("damage_increase")]
        public float? DamageIncrease { get; set; }
    }

    public class Process
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("slot")]
        public float? Slot { get; set; }

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

    public class ProfileRoot
    {

        [JsonPropertyName("profiles")]
        public Dictionary<string, string> Profiles { get; set; } = new();
    }
}
