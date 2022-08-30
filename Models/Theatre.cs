using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_GiselleF_301215601.Models
{
    class Theatre
    {
        //Fields
        private List<Show> shows;

        //Properties
        public string Name { get; }
       

        //Methods
        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        public void PrintShows()
        {

        }
        

        public void PrintShows(Genre genre)
        {
                        
            foreach(Show show in shows)
            {
                if(show.Movie.Genre.Equals(genre))

                Console.WriteLine(show.Movie.Genre.HasFlag(genre));

            }

        }

        public void PrintShows(Day day)
        {
            foreach(Show show in shows)
            {
                if(show.Day == day)
                {
                    Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(string actor)
        {
            foreach(Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor))
                    Console.WriteLine(show);
                
            }
        }

        public void PrintShows(Day day, Time time)
        {
            foreach(Show show in shows)
                if(show.Time == time)
                {
                    Console.WriteLine(show);
                }
        }

       public void PrintShows(Time time)
        {

        }

        public Theatre(string name)
        {
            this.Name = name;
            shows = new List<Show>();
        }


    }
}
