using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotLab
{
    class CarLot
    {
        public List<Cars> Car { get; set; } = new List<Cars>();

        public CarLot()
        {
            Car.Add(new Cars("Ford", "Mustang", 2021, 42000));
            Car.Add(new Cars("Honda", "Accord", 2021, 50000));
            Car.Add(new Cars("Nissan", "Rouge", 2021, 50000));

            Car.Add(new UsedCars("Chrysler", "Touring", 2009, 3900, 123213));
            Car.Add(new UsedCars("Hyundai", "Elantra SE", 2002, 9000, 98743));
            Car.Add(new UsedCars("Honda", "Civic", 2009, 7818, 238387));
        }
        public void AddNewCar(string Make, string Model, int Year, decimal Price)
        {
            Car.Add(new Cars(Make, Model, Year, Price));
        }
        public void AddUsedCar(string Make, string Model, int Year, decimal Price, double Mileage)
        {
            Car.Add(new UsedCars(Make, Model, Year, Price, Mileage));
        }
        public void PrintCars()
        {
            for (int i = 0; i < Car.Count; i++)
            {
                Console.WriteLine($"{i + 1}." + Car[i]);

            }
            Console.WriteLine();
        }
        public void RemoveCar(string Make, string Model, int Year)
        {
            for (int i = 0; i < Car.Count; i++)
            {
                if (Car[i].Make == Make && Car[i].Model == Model && Car[i].Year == Year)
                {
                    Car.RemoveAt(i);
                    break;
                }
            }
        }
        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public int GetInputInt(string prompt)
        {
           
            string response;
            int numResponse;
            while (true)
            {
                try
                {
                    response = GetInput(prompt);
                    numResponse = int.Parse(response);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an interger");
                    continue;
                }
                
            }
            return numResponse;
        }
        public void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the car lot");
                
                Console.WriteLine($"{Car.Count + 1}. Add a car");
                Console.WriteLine($"{Car.Count + 2}. Add a used car");
                Console.WriteLine($"{Car.Count + 3}. Quit");
                int choice = GetInputInt("Which car would you like?");
                if (choice > 0 && choice <= Car.Count)
                {
                    Console.WriteLine(Car[choice - 1]);
                    string response = GetInput("Would you like to buy this car?").ToLower();
                    if (response == "y")
                    {
                        Console.WriteLine("Excellent! Our fiance department will be touch short");
                    }
                    else if (response == "n")
                    {
                        Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine("Please enter only a y or an n");
                    }
                }
                else if (choice == Car.Count + 1)
                {
                    Console.WriteLine("Please enter the information needed for the car:");
                    string Make = GetInput("Make: ");
                    string Model = GetInput("Model: ");
                    int Year = GetInputInt("Year: ");
                    int Price = GetInputInt("Price: ");
                    AddNewCar(Make, Model, Year, Price);
                }
                else if (choice == Car.Count + 2)
                {
                    Console.WriteLine("Please enter the information needed for the car:");
                    string Make = GetInput("Make: ");
                    string Model = GetInput("Model: ");
                    int Year = GetInputInt("Year: ");
                    int Price = GetInputInt("Price: ");
                    int Mileage = GetInputInt("Mileage: ");
                    AddUsedCar(Make, Model, Year, Price, Mileage);
                }
                else if (choice == Car.Count + 3)
                {
                    break;
                }
            }
           
            
        }

                 
 
        

    }
}
