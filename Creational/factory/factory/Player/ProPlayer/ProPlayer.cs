using System;
using System.Collections.Generic;

namespace ProPlayer {
    public class Proplayer : IProPlayer {

        public Proplayer()
        {
            Console.WriteLine("ProPlayer");
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> RankedMatchList { get; set; }
    }
}