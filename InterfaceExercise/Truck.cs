using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F-150";
        public int SeatCount { get; set; } = 4;
        public double EngineSize { get; set; } = 6.5;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;
        public double BedSize { get; set; } = 6;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} is now driving forward...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving forward...");
            }
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
