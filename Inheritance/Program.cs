using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var eagle = new Birds() {
             SongSound = "AmeriCAW CAW CAW",
            FlockSize = 1,
            EatsMeat = true,
            Color = "Red White and Blue",
            IsReal= true,
            NestLoc = "Ontop of a flagpole, I assume",
            Limbs = 4,
            Size = "Large",
            };
            var godzilla = new Reptiles()
            {
                EatsMeat = true,
                Color = "Green",
                Limbs = 4,
                Size = "Kaiju",
                IsAmphibious = false,
                IsGodzilla = true,
                SpeedMPH = 4,
                MoveType = "Stomp",
            };

            eagle.BirdSong();
            Console.WriteLine($"That's the sound when this {eagle.Size} {eagle.Color} flock of {eagle.FlockSize} Eagle is on his way to his nest located {eagle.NestLoc}.");
            Console.WriteLine($"The only thing more B.A.? GODZILLA! What are you going to do when this {godzilla.Color} {godzilla.Size} decides to {godzilla.MoveType} it's way at a bruising {godzilla.SpeedMPH} MPH towards your city?");


            // TODO Be sure to follow best practice when creating your classes

           


           





            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
