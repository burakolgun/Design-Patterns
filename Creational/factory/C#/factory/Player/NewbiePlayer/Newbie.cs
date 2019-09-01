using System;
using System.Collections.Generic;

namespace NewbiePlayer
{
    public class Newbie : INewbie {

        public Newbie()
        {
            Console.WriteLine("Newbea");
        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> StoryGames { get; set; }
    }
}
