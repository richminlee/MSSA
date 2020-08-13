using System;

namespace ISTA_322_EX7A_Richard_Lee
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle BasicVehicle = new Vehicle();
            BasicVehicle.Move();
            AirVehicle Helicopter = new AirVehicle();
            Helicopter.Move();
            WaterVehicle Boat = new WaterVehicle();
            Boat.Move();
            LandVehicle Tank = new LandVehicle();
            Tank.Move();
            Weapon BasicWeapon = new Weapon();
            BasicWeapon.Shoot();
            SmallCaliberWeapon M9 = new SmallCaliberWeapon();
            M9.Shoot();
            IndirectFireWeapon M203 = new IndirectFireWeapon();
            M203.Shoot();
            DirectFireWeapon M82 = new DirectFireWeapon();
            M82.Shoot();

        }
    }
}
