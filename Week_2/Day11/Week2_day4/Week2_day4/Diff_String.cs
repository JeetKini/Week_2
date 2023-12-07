using System;


namespace Week2_day4
{
    public class Diff_String
    {
        public void PlayWithStrings() {
       int a = 5;
         int b = 5;
        string s = "Hello " + "World";
            Console.WriteLine(s);
            string s1 = String.Format("{0} + {1} ={2}", a, b, (a + b));
            Console.WriteLine(s1);
            string s2 = $"Sum of {a}and {b} is {a+b}";
            Console.WriteLine(s2);


        }
    }
}
