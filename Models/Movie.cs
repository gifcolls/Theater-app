using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_GiselleF_301215601.Models
{
    class Movie
    {
        //Properties
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast {get;}

        //Constructors

        public Movie(string title, int year, int lenght )
        {
            this.Title = title;
            this.Year = year;
            this.Length = lenght;
            Cast = new List<string>();

        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }


        public void SetGenre(Genre genre)
        { 
            Genre = genre;

        }

        public override string ToString()
        {
            return $"Title: {Title}\n" +
                   $"Cast: {string.Join(",", Cast)}\n" +
                   $"Genre: {string.Join("|", Genre)}\n"+
                   $"Duration: {Length} mins\n" +
                   $"Year: {Year}";
        }


    }
}
