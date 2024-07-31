namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

         public Tesla()
        {
            MainColor = "Metallic";
        }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"\nThe {MainColor} Tesla self-drives past by you. *Alien Noises*!");
        }
    }
}