using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string Make { get; set; } = "Chevrolet";
        public string Model { get; set; } = "Corvette";
        public int SeatCount { get; set; } = 2;
        public double EngineSize { get; set; } = 5.5;
        public string CompanyName { get; set; } = "Chevrolet";
        public string Motto { get; set; } = "Chevy Runs Deep";
        public bool HasChangedGears { get; set; }
        public double TrunkSize { get; set; } = 4;
        public string AutoOrManual { get; set; } = "Automatic";

        public void AutoorManual()
        {
            Console.WriteLine($"Automatic or manual: {AutoOrManual}");
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving forward...");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now parked...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"Unable to park without changing gears");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"Unable to reverse without changing gears");
            }
        }
        public void ChangeGears(bool IsChanged)
        {
            HasChangedGears = IsChanged;
        }
    }
}
