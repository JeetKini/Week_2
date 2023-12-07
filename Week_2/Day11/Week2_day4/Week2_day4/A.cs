using System;

namespace Week2_day4
{
    class A {
        public int a ;
        public float f = 34f;
        public decimal d = 342m;
        public  bool b = true;
        //default
        //public A()
        //{
            
        //}
        //paramerterized 
        //public A(int a)
        //{
        //      this.a = a;
        //   // Console.WriteLine(a);
        //}


        //static
        //static A()
        //{
        //    Console.WriteLine("I am Static Constructor");
        //}

        //Copy Constructor
        //public A(A val) {
        //    a = val.a;
        //}

        //Private 
        //private A(int a) {
        //    Console.WriteLine("I am Private Constructor");
        //}

        
        public static void Print()
        {
            Console.WriteLine("I am Static Method");
        }
       
    }
}
