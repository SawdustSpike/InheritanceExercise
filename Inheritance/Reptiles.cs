using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptiles : Animal
    {
        public Reptiles()
        {                
        }
        public bool IsAmphibious { get; set; }
        public int SpeedMPH { get; set; }
        public string MoveType { get; set; }
        public bool IsGodzilla { get; set; }


    }
}

// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class