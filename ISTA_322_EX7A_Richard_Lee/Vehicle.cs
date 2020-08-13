using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA_322_EX7A_Richard_Lee
{
    class Vehicle
    {
        public bool Armored { get; set; }
        public int NumOfSeats { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("I am Moving!");
        }
    }
    class AirVehicle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am Flying!");
        }
    }
    class WaterVehicle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am Boating!");
        }
    }
    class LandVehicle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am Rolling!");
        }
    }
}
