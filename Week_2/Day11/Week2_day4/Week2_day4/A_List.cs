using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Week2_day4
{
    public class A_List {
     
        public void Plist()
        {
            var list=new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(20);
            list.Add(30);
            list.Contains(10);
            list.Add((50)) ;
            Console.WriteLine(list.Count);
            Console.WriteLine(list.IndexOf(10));
         //   list.RemoveAt(0);
           // list.ToArray();
           
            list.Sort();
            var list2 = new HashSet<int>(list);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }


        }
    
    }
}
