namespace Garage
{
    public interface IElectricVehicle
    {
        double CurrentChargePercentage { get; set; }
        double BatteryKWh { get; set; }

         void ChargeBattery();
    }

}