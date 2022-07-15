using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        bool HasChangedGears { get; set; }
        bool IVehicle.HasChangedGears { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {

            Console.WriteLine($"{GetType().Name} now driving forward...");

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
                Console.WriteLine("Can't reverse until we change gears");
            }

        }

        public void Park()

        {
            if(HasChangedGears == true)

            {

                Console.WriteLine($"{GetType().Name}");
                HasChangedGears = false;
            }
            else

            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
