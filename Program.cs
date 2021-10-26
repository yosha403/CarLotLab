using System;

//DevBuild Lab : Used Car Lot
//Author: Yosha Kunnummal
//Date: 10/25/2021

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot cLot = new CarLot();
            Console.WriteLine("Welcome to Grant Chirpus’ Used Car Emporium!");
            Console.WriteLine();
            bool goOn = true;
            while (goOn)
            {
                Console.Write("1. List Car\n2. Add a Car to the list\n3. Buy Car\n4. Quit\n");
                Console.Write("Please select your option:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        cLot.ListCars();
                        break;
                    case "2":
                        cLot.AddCar();
                        cLot.ListCars();
                        break;
                    case "3":
                        Console.Write("Which car would you like?(Select the index number): ");
                        int index = int.Parse(Console.ReadLine());
                        cLot.SelectedCar(index);
                        Console.Write("\nWould you like to buy this car? Enter 'y' or'n':");
                        string userSelection = Console.ReadLine();
                        if (userSelection.ToLower() == "y")
                        {
                            cLot.RemoveCar(index);
                        }
                        else if (userSelection.ToLower() == "n")
                        {
                            Console.WriteLine("Thank you for visiting!");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid selection");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Thank you for visiting!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }
                goOn = Continue();
            }
        }
        //A method to check whether the user agrees to continue the application
        public static bool Continue()
        {
            Console.Write("\nWould you like to continue? (y/n):");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Thank you,Bye!");
                return false;
            }
            else
            {
                Console.WriteLine("\nPlease enter 'y' or 'n'");
                //This is recursion, calling a method inside itself
                return Continue();
            }
        }
    }
}
