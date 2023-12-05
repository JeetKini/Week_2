using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day_2
{
   
     interface IA {
        string Name { get; }
         void play();
    }
     interface IB {
        
          void play();
       
    }
    public class C  {

        public virtual void play()
        {
            Console.WriteLine("I am Class C");
        }
    }
        public  class  D :C,IA,IB{


        public string Name => "jeet";

        

        public override void play()
        {
            Console.WriteLine("I am Class D");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //int j = 20;
            //string s = string.Format("The  Sum of {0} and {1} is :{2}",i,j,(i+j));
            //Console.WriteLine(s);
            //string s1 = "The  Sum of " + i+" and "+j+" is : "+(i+j);
            //Console.WriteLine(s1);
            //string s2 = $"The sum of {i} and {j} is : {i+j}";
            //Console.WriteLine(s2);


            //IA over=new D();
            //over.play();
            //Console.WriteLine(over.Name);

            //IEnumerable<int> list = new List<int>
            //{
            //    1,2,3,4,5,6,7,7
            //    //"Jeet",
            //    //"Adnan",
            //    //"Bilal",
            //    //"Arjun".ToLower(),
            //    //"Arif".ToUpper(),
            //};

            //foreach (var item in list) {
            //    Console.WriteLine(item);
            //}


            //List<int> ints = new List<int>();
            //while (true)
            //{
            //    Console.WriteLine("Enter the number");
            //    var user =Console.ReadLine();
            //    if (String.IsNullOrEmpty(user))
            //    {
            //        break;
            //    }
            //    ints.Add(Convert.ToInt32(user));
            //}


            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //HashSet<int> set = new HashSet<int>(ints);
            //foreach (int i in set) {
            //    Console.WriteLine(i);
            //}
            List<string> list = new List<string>();
            list.Add("Jeet");
            list.Add("Adnan");
            list.Add("Bilal");
            list.Add("Arjun");
            list.Add("Arif");
            list.Add("Sachin");

            //IEnumerator<string> enumerator =list.GetEnumerator() ;
            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //IQueryable<string> query = list.AsQueryable();

            //foreach (string item in query)
            //{

            //    Console.WriteLine(item);
            //}



            //int a = 10;
            //For_ref(ref a);
            //Console.WriteLine(a);

            //int b = 10;
            //For_out(out b);
            //Console.WriteLine(b);

           
        
        
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                // Parallelize the loop using Parallel.For
                Parallel.For(0, numbers.Length, i =>
                {
                    Console.WriteLine($"Square of {numbers[i]} is {numbers[i] * numbers[i]}");
                });
            }
        public static void For_ref(ref int a) {
            a= a + 10;
        }
        public static void For_out(out int a)
        {
             a = 1;
            a = a + 10;
        }
    }
}
