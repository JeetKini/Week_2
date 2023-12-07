using System;

namespace Week2_day4
{
    public class B {
      
        //Constructor Overloading
        public B()
        {
           // Console.WriteLine("I am Default Constructor");

        }

        public B(int a)
        {
            Console.WriteLine("I am Parameterized Constructor ",a);
        }
        public B(int a,string b)
        {
            Console.WriteLine(a+" "+b);
        }

 //Method Overloading
        public  float test(float a,int b)
        {
           return a + 1;
        }
        public  double test(int a,float b)
        {
           return a + 1;
        }

        //Method Overloading
        public virtual void Test()
        {
            Console.WriteLine("I am B class Method");
        }
    }
}
