using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_GiselleF_301215601.Models
{
    class Show
    {
        //Properties
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        //Methods

        public Show(Movie movie, Day day, double price, Time time)
        {
            this.Movie = movie;
            this.Day = day;
            this.Price = price;
            this.Time = time;
        }

        public override string ToString()
        {
            return $"Title: {Movie}\n" +
                   $"Day: {Day} | {Time}"+
                   $"Price ${Price}\n";  
        }
    }
}
