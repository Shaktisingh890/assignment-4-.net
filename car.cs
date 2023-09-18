using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Car
    {
        public string make;
        public string model;
        public int year;

        public Car(String make,string model,int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public string Data
        {
            get {
                return $"Car Details is {make}, {model}, {year}";
            
            }
            
        
        
        }
       public static void Main(String[] args)
        {
            Car c1 = new Car("Tata", "Nexa", 2005);
            Console.WriteLine(c1.Data);
        }

    }

   
}
