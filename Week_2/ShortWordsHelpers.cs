using System;
using System.Data;
using System.Linq;

namespace Week_2
{
    internal static class ShortWordsHelpers
    {

        public static string Shorten(this string str, int num)//by using this we can use method without instance 
        {
            if (num < 0)
                throw new ArgumentOutOfRangeException("Not a Proper string Please use proper!!!");

            if (num == 0)
                return "";
            var words = str.Split(' ');
            if (words.Length <= num)
                return str;
            return string.Join(" ", words.Take(num))+"....";

        }
    }
}