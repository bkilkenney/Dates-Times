using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateTime = DateTime.Now;

            //ToString is the standard U.S.A. format of 12/4/2016 3:29:34 PM 
            //Console.WriteLine(myDateTime.ToString());
            //Console.ReadLine();

            //Console.WriteLine(myDateTime.ToShortDateString());
            //Console.WriteLine(myDateTime.ToShortTimeString());
            //Console.ReadLine();

            //Console.WriteLine(myDateTime.ToLongDateString());
            //Console.WriteLine(myDateTime.ToLongTimeString());
            //Console.ReadLine();

            //Console.WriteLine(myDateTime.AddDays(3).ToLongDateString());

            //Console.WriteLine(myDateTime.AddHours(3).ToLongTimeString());

            //Console.WriteLine(myDateTime.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myDateTime.Month);  Returns 12

            //DateTime myBirthday = new DateTime(1982, 1, 18);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBDay = DateTime.Parse("1/18/1982");
            Console.WriteLine(myBDay);

            //Can use timespan to see how many days you've been alive, hours, etc. 

            TimeSpan myAge = DateTime.Now.Subtract(myBDay);
            Console.WriteLine("I've been alive " + myAge.TotalDays + " days.");
            Console.WriteLine("I've been alive " + myAge.TotalHours + " hours.");
            Console.WriteLine("I've been alive " + myAge.TotalMinutes + " minutes.");
        }
    }
}
