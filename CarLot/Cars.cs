using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotLab
{
    class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Cars()
        {
            this.Make = "";
            this.Model = "";
            this.Year = 0;
            this.Price = 0;
        }
        public Cars(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        public override string ToString()
        {
            string output = $"Make: {Make}\t";
            output += $"Model: {Model}\t";
            output += $"Year: {Year}\t";
            output += $"Price: {Price}\t";
            return output;
        }
    }
}
