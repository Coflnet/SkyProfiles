using System.Text.Json;
using AwesomeAssertions;
using Coflnet.Sky.PlayerInfo.Models.Hypixel;
using NUnit.Framework;

namespace Sky.PlayerInfo.Service;

public class ProfileServieHotMTests
{
    [TestCase(null, 1)]
    [TestCase(0d, 1)]
    [TestCase(2999d, 1)]
    [TestCase(3000d, 2)]
    [TestCase(11999d, 2)]
    [TestCase(12000d, 3)]
    [TestCase(96999d, 4)]
    [TestCase(97000d, 5)]
    [TestCase(132494d, 5)]
    [TestCase(196999d, 5)]
    [TestCase(197000d, 6)]
    [TestCase(1_246_999d, 9)]
    [TestCase(1_247_000d, 10)]
    [TestCase(99_000_000d, 10)]
    public void LevelFromExperience(double? xp, int expected)
    {
        ProfileServie.GetHotMLevel(xp).Should().Be(expected);
    }

    private static int LevelOf(string json) => ProfileServie.GetHotMLevel(JsonSerializer.Deserialize<Member>(json));

    [Test]
    public void ReadsSkillTreeExperience()
    {
        LevelOf("""{"skill_tree":{"experience":{"mining":132494.0,"foraging":547000.0}},"mining_core":{"tokens":0}}""").Should().Be(5);
    }

    [Test]
    public void FallsBackToLegacyMiningCore()
    {
        LevelOf("""{"mining_core":{"experience":132494.0}}""").Should().Be(5);
    }

    [Test]
    public void PrefersSkillTreeOverMiningCore()
    {
        LevelOf("""{"skill_tree":{"experience":{"mining":132494.0}},"mining_core":{"experience":3000.0}}""").Should().Be(5);
    }

    [Test]
    public void MissingDataIsLevelOne()
    {
        LevelOf("{}").Should().Be(1);
        LevelOf("""{"skill_tree":{"experience":{"foraging":5.0}}}""").Should().Be(1);
    }
}
