namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public Cessna()
        {
            MainColor = "Blue";
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
            Console.WriteLine($"\nThe {MainColor} Cessna flies beside you. Mmmmmmmmmmm!");
        }

        public override void Stop()
        {
            Console.WriteLine("Unexpectedly, the plane has wheels on the top. The Cessna comes to a perfect landing on a near-by runway");
        }
    }
}