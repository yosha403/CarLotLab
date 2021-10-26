using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    class UsedCar: Car
    {
        public double Mileage { get; set; }

        public UsedCar(string Make, string Model, int Year, decimal Price,double Mileage): base(Make,Model,Year,Price)
        {
            this.Mileage = Mileage;
        }

        public override string ToString()
        {
            string outpout = $"{Make,-26}";
            outpout += $"{Model,-13}";
            outpout += $"{Year,-13}";
            outpout += $"{Price,-13:c}";
            outpout += $"(Used) {Mileage,-13}";
            return outpout;
        }
    }
}
