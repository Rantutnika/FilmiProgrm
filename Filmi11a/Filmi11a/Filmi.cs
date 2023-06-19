using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Filmi11a
{
    public class Filmi : Danni
    {
        private string name;
        private double price;
        private int durationDay;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Your name should be at least two letters long");
                }
                name = value;
            }


        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Your price should be more than 0");
                }
            }
        }
        public int DurationDay
        {
            get { return durationDay; }
            set { durationDay = value; }
        }
        public Filmi(string name, double price, int durationDay, string town, string cinemaName, string startDate) : base(town, cinemaName, startDate)
        {
            Name = name;
            Price = price;  
            DurationDay = durationDay;

        }

        public override void Print()
        {
            Console.WriteLine($"Kinoto e-- {this.CinemaName}. V grad-- {this.Town}" +
                 $"   ,Na data--{this.StartDate}," +
                 $"Filma e -- {this.Name}, Cena-- {this.Price}. Vremetraene-- {this.DurationDay} hours");
        }
    }
}
