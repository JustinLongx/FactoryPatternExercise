using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Motorcycle : IVehicle
    {
        public string Color { get; set; }
        public bool HasHandBrake { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving a motorcycle.");
        }
    }
}
