using System;
using System.Collections.Generic;
namespace Week2_day4
{
    public class Stacks
    {
        public void stack() { 
        
            var x = new Stack<int>();
            x.Push(1);
            x.Push(2);
            x.Push(3);
            Console.WriteLine(x.Peek());
            x.Pop();
            x.Push(4);
           // x.TrimExcess();
            foreach (var i in x)
            {
                Console.WriteLine(i);
            }

        }
    }
}
