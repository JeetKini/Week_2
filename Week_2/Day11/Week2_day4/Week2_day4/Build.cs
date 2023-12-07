using System;
using System.Text;

namespace Week2_day4
{
    class Build {

        public void Builders() {

            StringBuilder sb = new StringBuilder("Jeet ");
            //sb.Append("Kini");//To add another string
            //sb.AppendLine();//To go to the next Line
            Console.WriteLine(sb.Capacity);//Default capacity is 16.
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.EnsureCapacity(sb.Capacity));
            Console.WriteLine(sb.Replace('J','M'));
            char[] charArray = new char[sb.Length];
            sb.CopyTo(0, charArray, 0, sb.Length);
            Console.WriteLine(charArray[0]);
            Console.WriteLine(sb.Insert(5, "Kini", 1));
            sb.Clear();
            Console.WriteLine(sb);

        } 
    }
}
