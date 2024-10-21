using System.Collections.Generic;
namespace Sky.PlayerInfo.Models.Museum;
public record Player(
    long value,
    bool appraisal,
    Dictionary<string, DonatedItem> items
);

public record DonatedItem(
    long donated_time,
    string featured_slot,
    bool borrowing,
    Items items
);

public record Items(
    int type,
    string data
);

public record MuseumRoot(
    bool success,
    Dictionary<string, Player> members
);

