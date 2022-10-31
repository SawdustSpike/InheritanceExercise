using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Birds : Animal
    {
        public Birds()
        {
        }
        public int FlockSize { get; set; }
        public bool IsReal { get; set; }
        public string NestLoc { get; set; }
        public string SongSound { get; set; }

        public void BirdSong()
        {
            Console.WriteLine($"{SongSound}");
        }

    }
}
// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class