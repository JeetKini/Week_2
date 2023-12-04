using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{

    public class YouTubeException : Exception {

        public YouTubeException(string msg,Exception exp)
            :base(msg,exp) 
        {
            Console.WriteLine(msg);
        }
    }
    public class Video{
    
    }
    public class YouTubeApi {
        public List<Video> GetVideos(string user) {

            try
            {

            }
            catch (Exception ex)
            {

                throw new YouTubeException("Could Not Find !!!",ex);
            }

            return new List<Video>();
        }
    
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> ResultMS = numbers.Take(5).ToList();
            //Console.WriteLine(ResultMS);
            //string s = "Hello My name is jeet Kini I am an DotNet Developer";
            //var shorts = s.Shorten(5);
            //Console.WriteLine(shorts);

            //IEnumerable<int> numbers=new List<int>() {1,2,3,4,5,6,4,8};

            //var max=numbers.Max();
            //Console.WriteLine(max);

            var books=new BookRepository().GetBooks();

            //var checkBook=new List<Book>();
            //foreach(var bk in books)
            //{
            //    if (bk.Price < 10)
            //    { 
            //    checkBook.Add(bk);
            //    }

            //}
            //LINQ Operators

            //var cheperBooks=from b in books
            //                where b.Price <10
            //                orderby b.Title
            //                select b;
            //Console.WriteLine(cheperBooks.ToString());


            //LINQ Extension Methods
            //var checkBook = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b=>b.Title);


            //foreach (var cb in checkBook) {
            //    Console.WriteLine(cb);
            //  Console.WriteLine(cb.Title+"  "+cb.Price);


            //var book = books.SingleOrDefault(b=>b.Title=="Abc");
            //var book1 = books.Single(b => b.Title == "Abc");
            //var book2 = books.First(b => b.Title == "C# Advanced Topic");
            //var book3 = books.FirstOrDefault(b => b.Title == "C# Advanced Topic");
            //var book4 = books.Last(b => b.Title == "C# Advanced Topic");
            //var book5 = books.LastOrDefault(b => b.Title == "C# Advanced Topic");

            //Console.WriteLine(book1.Title +" "+book1.Price);

            //    Console.WriteLine(book == null);
            // Console.WriteLine(book2.Title+" "+book2.Price);
            // Console.WriteLine(book.Title);
            // Console.WriteLine(book3.Price);
            // Console.WriteLine(book4.Price);
            //Console.WriteLine(book5);

            // var book6 = books.Skip(2);

            //var book7 = books.Take(2);
            //foreach (var b in book7)
            //{
            //    Console.WriteLine(b.Title);
            //}
            //var book8 = books.Count();
            //Console.WriteLine(book8);
            //var book9 = books.Max(b=>b.Price);
            //Console.WriteLine(book9);
            //var book10 = books.Min(b => b.Price);
            //Console.WriteLine(book10);

            //var book9 = books.Sum(b => b.Price);
            //Console.WriteLine(book9);

            //  Nullable<DateTime> date = null;
            //DateTime? date = new DateTime(2014,1,1);
            //DateTime date1= date.GetValueOrDefault();
            //Console.WriteLine(date1);

            //Console.WriteLine(date.HasValue);//return false
            //Console.WriteLine(date.GetValueOrDefault());//return default value if the value is not present
            //Console.WriteLine(date.Value);

            //DateTime? date = null;
            //DateTime date2 = date ?? DateTime.Now;

            //DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Now;
            //Console.WriteLine(date3);

            //Console.WriteLine(date2);

            //DateTime date= DateTime.Now;
            //DateTime date1 = DateTime.Today;
            //Console.WriteLine("Now: "+date);
            //Console.WriteLine("Today: "+date1);

            // int a = 5;
            // dynamic d = a;

            // var v = d;
            // dynamic dv = v;

            // var vr = new Book();
            // object obj = "Jeet";
            // dynamic j = "Kini";
            //// Console.WriteLine(j.Optimize());
            // j = 10;
            // ++j;
            // Console.WriteLine(j);

            //var any = "Hiee";
            //any = 10;

            //int a1 = 300;
            //dynamic d2= a1;
            //byte b1 =(byte) d2;
            //Console.WriteLine(b1);
            //int a=Convert.ToInt32(Console.ReadLine());

            // int b= int.Parse(Console.ReadLine());

            // Console.WriteLine("0/5 :"+b/a);

            //try
            //{

            //    Console.WriteLine("5 /0 :" + a / b);

            //    int[] arr = new int[5];
            //    while (true)
            //    {

            //        arr[6] = 2;
            //    }
            //}
            //catch (ArithmeticException ar)
            //{

            //    Console.WriteLine("Invalid Input");
            //    Console.WriteLine(ar.Message);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("PLEASE TRY AGAIN ");
            //}
            //finally {
            //    GC.Collect();
            //    Console.WriteLine("THANK YOU");
            //   // GC.Collect();
            //}

            //var c=Console.ReadKey();
            //try
            //{

            //    call();
            //}
            //catch (StackOverflowException st)
            //{
            //    Console.WriteLine("Handled");
            //  //  Console.WriteLine(st.Message);
            //}
            //try
            //{
            //    string S1 = "Tom";
            //    string S2 = "Maths";
            //    StringBuilder sBuilder = new StringBuilder(S1.Length, S2.Length);
            //    // Append initial value
            //    sBuilder.Append(S1);
            //    sBuilder.Insert(value: S1, index: S2.Length - 1, count: 1);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine("Handled");
            //}
            //try
            //{
            //    var yt = new YouTubeApi();
            //    var videos = yt.GetVideos("Jeet");
            //    Console.WriteLine(videos);
            //}
            //catch(Exception e) {
            //    Console.WriteLine(e.Message);
            //}

            
            Method1();
            Method2();
            Console.ReadKey();




        }
        public static void call() {
            call();
        }

        public static  async Task Method1() {
            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Method 1 is running!!");
                }
            });
        }
        public static async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Method 2 is running!!");
                }
            });
        }

    }
       
    }

