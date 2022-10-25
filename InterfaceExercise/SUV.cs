using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string Make { get; set; } = "Subaru";
        public string Model { get; set; } = "Forester";
        public int SeatCount { get; set; } = 6;
        public double EngineSize { get; set; } = 6;
        public string CompanyName { get; set; } = "Subaru";
        public string Motto { get; set; } = "Confidence In Motion";
        public bool HasChangedGears { get; set; }
        public double CargoHoldSize { get; set; } = 6.5;
        public bool CanItOffroad { get; set; } = true;

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
