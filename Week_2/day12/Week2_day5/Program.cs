using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day5
{
    class bike:Program {

        public int speed = 5;
        public bike()
        {
            Iamdelegate ig = new Iamdelegate(mul);
            ig(2, 5);
        }
    }
    public delegate int Iamdelegate(int a, int b);
    internal class Program
    {
        class vehical {

            public int distance = 50;
        
        }

        static void Main(string[] args)
        {
            //int a = 2;
            //string name;
            //Dictionary<int, string> dic = new Dictionary<int,string>();
            //dic.Add(1, "Jeet");
            //dic.Add(2, "Adnan");
            //dic.Add(3, "Bilal");
            //dic.Add(4, "Adnan");

            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item);
            //}
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //List<int> list1 = new List<int>();
            //list.Add(1);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //List<int> list2 = new List<int>();
            //list.Add(1);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //List<dynamic> main = new List<dynamic>();
            //main.Add(list);
            //main.Add(list1);
            //main.Add(list2);



            //foreach (var item in main)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < main.Count; i++)
            //{
            //    for (int j = 0; j<main[i].Count; j++)
            //    { 
            //    }
            //}

            //for (var i = 0; i < main.Count; i++)
            //{

            //    for (var j = 0; j < main[i].Count; j++)
            //    {
            //        Console.Write(main[i][j] + " ");

            //    }
            //    Console.WriteLine();
            //}
            Iamdelegate ig = mul;
          //  Console.WriteLine(ig.Invoke(2,3));

            //ig = ig + mul;
            //ig(2, 3);
             ig.Invoke(2, 4);

            //bike bike = new bike();

            //int[] a = new int[5]
            //{ 1,4,3,7,2};

            //SortedSet<int> ints = new SortedSet<int>(a);
            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}
            Debug.WriteLine("Hey");







        }
        
        public static void add(int a,int b) {
        
        int c = a + b;
            Console.WriteLine(c);
        }
        public static int mul(int a,int b) {

            int d = a * b;
            Console.WriteLine(d);
            return d;
        }


    }
}

