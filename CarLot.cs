using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    class CarLot
    {
        List<Car> Cars { get; set; } = new List<Car>();        
        public CarLot()
        {
            Cars.Add(new Car("Hyundai", "Model S", 2017, 17999));
            Cars.Add(new Car("Ford", "F150", 2017, 31999));
            Cars.Add(new Car("Chevi", "Impala", 2017, 21989));
            Cars.Add(new UsedCar("Honda", "CRV", 2015, 14795,35987.6));
            Cars.Add(new UsedCar("Jeep", "Cherokee", 2013, 15000,12345.0));
            Cars.Add(new UsedCar("Nissan", "Pathfinder", 2016,24450,3500.3));            
        }

        //A method to list all the cars
        public void ListCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {                
                Console.WriteLine($"{i}. {Cars[i]}");
            }
            Console.WriteLine();
        }

        //A method to add a car to the list
        public void AddCar()
        {
            Console.Write("Would you like to add a used car or new car to the list? Enter 'used' or'new':");
            string userChoice = Console.ReadLine();
            if (userChoice.ToLower() == "new" || userChoice.ToLower() == "used")
            {
                Console.Write("Enter the model: ");
                string model = Console.ReadLine();
                Console.Write("Enter the make: ");
                string make = Console.ReadLine();
                Console.Write("Enter the year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Enter the price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                if (userChoice.ToLower() == "new")
                {
                    Cars.Add(new Car(model, make, year, price));
                    Console.WriteLine("A car added to the list.\n");
                }
                else if (userChoice.ToLower() == "used")
                {
                    Console.Write("Enter the mileage: ");
                    double mileage = double.Parse(Console.ReadLine());
                    Cars.Add(new UsedCar(model, make, year, price, mileage));
                    Console.WriteLine("A car added to the list.\n");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid selection.");
            }            
        }

        //A method to view the details of a selected car
        public void SelectedCar(int index)
        {
            if(index<Cars.Count && index>=0)
            {
                Console.WriteLine(Cars[index]);
            }
            else
            {
                Console.WriteLine("Please enter a valid index.");
            }
        }

        //A method to buy/remove a car from the list
        public void RemoveCar(int index)
        {
            Cars.RemoveAt(index);
            Console.WriteLine("\nExcellent! Our finance department will be in touch shortly.");
            ListCars();
        }
    }
}
