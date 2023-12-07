using System;

namespace Week2_day4
{
    public class StopWatch {
        DateTime start;
        DateTime end;
       // bool running;

        public void Start() { 
        
            start = DateTime.Now;
            Console.WriteLine(TimeSpan.Zero);

        }
        public void Stop()
        {
            end= DateTime.Now;
            Console.WriteLine("Time : "+ (end-start));
        }
    
    }
}
