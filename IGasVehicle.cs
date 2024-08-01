namespace Garage
{
    public interface IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        void RefuelTank();
    }

}