using System.Collections.Generic;
using Player;

namespace NewbiePlayer {
    public interface INewbie : IPlayer {
        List<string> StoryGames { get; set; }
    }
}