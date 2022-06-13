using System;

namespace Garage
{

public interface IElectric
{
    void ChargeBattery();

    double CurrentChargePercentage {get;}
}

public interface IGas : IVehicle
{
    void RefuelTank();

    double CurrentTankPercentage {get;}
}

public interface IVehicle 
{
    void Drive();
}


}