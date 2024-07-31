namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public Cessna()
        {
            MainColor = "Blue";
        }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"\nThe {MainColor} Cessna flies beside you. Mmmmmmmmmmm!");
        }

        public override void Stop()
        {
            Console.WriteLine("Unexpectedly, the plane has wheels on the top. The Cessna comes to a perfect landing on a near-by runway");
        }
    }
}