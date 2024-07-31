namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public Zero()
        {
            MainColor = "Gold";
        }

        public void ChargeBattery()
        {
            // method definition omitted
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