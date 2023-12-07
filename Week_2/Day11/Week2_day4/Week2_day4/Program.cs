using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Week2_day4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //var class1 = new A();
            //  var class2 = new A(100);
            //Console.WriteLine(class2);
            //Console.WriteLine(class1.a);
            //Console.WriteLine(class1.f);
            // Console.WriteLine(class2.a);
            //class1.b = false;
            //Console.WriteLine(class1.b);

            //  A.Print();

            // var class3 = new A(class2);
            // Console.WriteLine(class3.a);

            // var v = new A(5);

            //var v = new B();
            //Console.WriteLine(v.GetHashCode());
            //var v1=new B(5);
            //Console.WriteLine(v1);
            // var v2=new B(6,"Jeet");
            //Console.WriteLine(v2);

            //var b = new B();
            //b.test(20);

            //var build=new Build();
            //build.Builders();

            //var stak = new Stacks();
            //stak.stack();



            // Console.WriteLine((int)ABC.high);

            //var stopwatch = new StopWatch();
            //while (true)
            //{
            //    Console.WriteLine("Enter 'start' to start and 'stop' to stop");
            //    var user = Console.ReadLine();
            //    if (user == "start")
            //    { 
            //    stopwatch.Start();
            //    }
            //    if (user == "stop")
            //    { 
            //    stopwatch.Stop();
            //        break;
            //    }

            //}


            //var s = TimeSpan.Zero;
            //Console.WriteLine(s);
            //var ss=DateTime.Now;
            //Console.WriteLine(ss);
            //var sss = ss.Add(s);
            //Console.WriteLine(sss.AddDays(4));
            //Console.WriteLine(s);

            var l = new A_List();
            l.Plist();



        }
        public static int test(int a)
        {

            return a + 1;
        }
        public static float test(float a)
        {

            return a + 1;
        }


    }
}
