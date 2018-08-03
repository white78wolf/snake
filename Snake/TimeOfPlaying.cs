using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class TimeOfPlaying
    {
        private DateTime start;        

        public TimeOfPlaying(DateTime _start)
        {
            this.start = _start;            
        }

        public string StopGame(DateTime finish)
        {
            string time = Convert.ToString(finish - start);            
            return time.Substring(3, time.Length - 8);
        }
    }
}
