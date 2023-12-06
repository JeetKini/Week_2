using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week2_day3
{
    internal class Program
    {
       

        static  void Main(string[] args)
        {
          
            
            //task1();
            //task2();
            //task3();
            //task4();

            //var a = 1;
            //var b = 2;
            //a = a + b;

            //object a =Convert.ToInt32( 1);
            //object b = Convert.ToInt32(2);
            //object c = Convert.ToInt32(a) + Convert.ToInt32(b);
            //Console.WriteLine(c);

            //dynamic a = 1;
            //dynamic b = 2;
            //a = a + b;

            //object a = 10;
            //var b = 10;
            //dynamic d = 10;
            //string sd = (string)d;
            //Console.WriteLine(sd);
            //string ss = b;
            //string s = a;

            //var r = new A();
            //r.play();
            //I1 i = new A();
            //i.play();
            //I2 i2 = new A();
            //i2.play();

            //var ak;
            //dynamic asd;
            //object ob;

            // Console.WriteLine(Thread.CurrentThread.Name.Length);

            Thread t = Thread.CurrentThread;
            t.Name = "Hello";
            //    t.Priority = (ThreadPriority)2;
            //Thread th = Thread.CurrentThread;
            //Console.WriteLine((int)th.Priority);
            //Console.WriteLine(Thread.CurrentThread.IsAlive);
            //Console.WriteLine(Convert.ToInt64(har.a));
            //Console.WriteLine(Convert.ToDouble(har.b));
            //  Thread thread = new Thread(new ThreadStart(task1));
            // // Console.WriteLine(thread.Start());
            //var abc=har.a;
            //  Console.WriteLine((int)abc);
            //  Console.WriteLine(abc);
          //  string s = "";
            AA c = new AA();
            int o = Marshal.SizeOf(c);
           // Console.WriteLine(o);

            //MyClass myObject = new MyClass();
            //int size= Marshal.SizeOf(myObject);
            //Console.WriteLine(size);


            // Console.WriteLine(sizeof( int));
            //Console.WriteLine(Marshal.SizeOf(o));




        }
        public enum har {
        a=5,
        b=34,
        c
        
        } 
        public   static void task1() {
          
            Console.WriteLine("Task 1 is Starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 1 is Stoped");
        }
        public async static void task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 is Starting");
                Thread.Sleep(7000);
                Console.WriteLine("Task 2 is Stoped");
            });
            

        }
        public  static void task3()
        {
            Console.WriteLine("Task 3 is Starting");
            Thread.Sleep(5000);
            Console.WriteLine("Task 3 is Stoped");

        }
        public  static void task4()
        {
            Console.WriteLine("Task 4 is Starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 4 is Stoped");

        }

    }
}
