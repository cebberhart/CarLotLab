
using System;

namespace CarLotLab
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot cars = new CarLot();
            cars.PrintCars();
            cars.UserMenu();
        }
    }
}
