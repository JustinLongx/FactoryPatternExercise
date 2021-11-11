using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class car : IVehicle
    {
        public string Color { get; set; }
        public bool IsDrivable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Sorry cant text im driving in my {Color} car");
        }
    }
}
