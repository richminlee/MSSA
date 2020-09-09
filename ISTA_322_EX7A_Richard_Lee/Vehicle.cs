using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA_322_EX7A_Richard_Lee
{
    class Vehicle
    {
        private bool _armored;
        private int _numOfSeats;
        public bool Armored 
        { 
            get => this._armored; 
            set => this._armored = value; 
        }
        public int NumOfSeats 
        {
            get => this._numOfSeats;
            set => this._numOfSeats = value;
        }
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
