using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new car() { Color = "Blue", IsDrivable = true };
                   
                case "motorcycle":
                    return new Motorcycle();
                default:
                    return new car();
                    
            }
        }
    }
}
