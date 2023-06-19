using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmi11a
{
    public abstract class Danni : Iinfo
    {
        private string town;
        private string cinemaName;
        private string startDate;

        public string Town
        {
            get { return town; }
            set { town = value; }
        }
        public string CinemaName
        {
            get { return cinemaName; }
            set { cinemaName = value; }
        }
        public string StartDate
        {
            get { return startDate; }
            set
            {
                if (value.Length < 0)
                {
                    throw new Exception("Your date should have at least day and month");
                }
                startDate = value;
            }
        }
        public Danni(string town, string cinemaName, string startDate)
        {
            this.Town = town;
            this.CinemaName = cinemaName;
            this.StartDate = startDate;
        }

        public virtual void Print()
        {

        }
    }
}
