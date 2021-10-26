using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()
        {

        }
        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        public override string ToString()
        {
            string outpout = $"{Make,-26}";
            outpout += $"{Model,-13}";
            outpout += $"{Year,-13}";
            outpout += $"{Price,-13:c}";            
            return outpout;
        }
    }
}
