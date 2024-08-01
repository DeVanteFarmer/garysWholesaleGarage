namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }
         public Tesla()
        {
            MainColor = "Metallic";
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
            Console.WriteLine($"\nThe {MainColor} Tesla self-drives past by you. *Alien Noises*!");
        }
    }
}