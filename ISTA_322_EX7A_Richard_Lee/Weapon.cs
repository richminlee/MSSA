using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA_322_EX7A_Richard_Lee
{
    class Weapon
    {
        private double _caliber;
        private string _name;
        public double Caliber
        {
            get => this._caliber;
            set => this._caliber = value;
        }
        public string Name
        {
            get => this._name;
            set => this._name = value;
        }
        public virtual void Shoot()
        {
            Console.WriteLine("Ratatat Ratatat from any Weapon!");
        }
    }
    class SmallCaliberWeapon : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Pew Pew from my Small Weapon!");
        }
    }
    class IndirectFireWeapon : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Boom Boom from my IDF Weapon!");
        }
    }
    class DirectFireWeapon : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Bang from my Direct Weapon!");
        }
    }
}
