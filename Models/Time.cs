using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_GiselleF_301215601.Models
{
    struct Time
    {
        //Fields
        private int hours;
        private int minutes;
        private int seconds;

        //Properties
     // public int Hours { get; }
     // public int Minutes { get; }
      // public int Seconds { get; }

        //Constructor
        public Time(int hours, int minutes, int seconds = 0)

        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public override string ToString()
        {

            return $"{this.hours}:{this.minutes} pm\n";
        }

        static public bool operator == (Time lhs, Time rhs)
            {
            int duration1 = lhs.hours*60 +lhs.minutes;
            int duration2 = rhs.hours * 60 + rhs.minutes;
            
            
            int differenceOfTime = duration1 - duration2;
            
            return Math.Abs(differenceOfTime) <= 15;

            }

        static public bool operator != (Time lhs, Time rhs)
        {

            int duration1 = lhs.hours * 60 + lhs.minutes;
            int duration2 = rhs.hours * 60 + rhs.minutes;
            return (duration1 - duration2) > 15;
            
        }
    }
}
