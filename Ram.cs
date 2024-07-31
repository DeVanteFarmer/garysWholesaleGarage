
namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public Ram()
        {
            MainColor = "Silver";
        }

        public void RefuelTank()
        {
            // method definition omitted
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