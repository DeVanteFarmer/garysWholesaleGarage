
namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public Ram()
        {
            MainColor = "Silver";
            Random rand = new Random();
            CurrentTankPercentage = rand.Next(1,100);
            FuelCapacity = 100;
        }

        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"\nThe {MainColor} Ram drives over you. RRrrrrrummbbble!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Ram tries to stop but rams into another Ram");
        }
    }
}