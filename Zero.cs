namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric car
    {
        public double CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }
         public Zero()
        {
            MainColor = "Gold";
            Random rand = new Random();
            CurrentChargePercentage = rand.Next(1,100);
            BatteryKWh = 100;
        }

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives into you. SkkuuuurrrrrrrtBOOOM!");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle is already stopped");
        }
    }
}