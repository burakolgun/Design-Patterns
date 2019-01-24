using System.Collections.Generic;
using Player;

namespace ProPlayer {
    public interface IProPlayer : IPlayer
    {
        List<string> RankedMatchList { get; set; }
    }
}