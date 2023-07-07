using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Remoting.Channels;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Service<T> where T : new() // es partadruma vor T n unena parametherless canstructor 
    {
        T GetEntity()
        {
            return new T(); // nor T tipi object a return anum 
        }

    }
    // task 2
    class Person : IComparable
    {
        public string name { get; set; }
        public int age { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Person otherPersonn))
            {
                throw new NotImplementedException();
            }
            return age.CompareTo(otherPersonn.age);
        }

    }
    //task 
    public static class StringEx
    {
        public static string TrimSpaces(this string input)
        {
            if (input == null)
            {
                return null;

            }
            return input.Trim();
        }
    }
    // task
    public static class StringExtension
    {
        public static bool isValid(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(nameof(str));
            }
            // string pattern = @"^[a-zA-Z0-9_.+-]+ @[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"; //regular exception

            string pattern1 = @"\A(?:[a-z 0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isMatch = Regex.IsMatch(str, pattern1);
            return isMatch;
        }
    }
    //task
    public static class DoubleExtension
    {
        public static double Round(this double number)
        {
            double d = Math.Round(number, 2);
            return d;

        }
    }
    //task
    public static class DateTimeExtension
    {
        public static string ToFriendlyDate(this DateTime date)
        {
            date = DateTime.Now;
            return date.ToString("MMMM d, yyyy");
        }
    }

    //task 8
    public static class StringExtension2
    {

        public static bool FileExists(this string filePath)
        {
            return File.Exists(filePath);

        }
    }
    //task 13
    public static class StringExtensions
    {
        public static string FormatPhoneNumber(this string str)
        {

            string str2 = "+" + str.Substring(0, 3) + "-" + str.Substring(3, 2) + "-" + str.Substring(5, 2) + "-" + str.Substring(7, 2);

            return str2;
        }
    }
    //task 
    /*public static class objExt
     {
         public static string SerializeToJson(this object ob)
         {


             return JsonSerializer.Serialize(ob);
         }

     }*/
    /* //task 9
      public static class stringExtension 
      {
          public static T ParseEnum<T>(this string str) where T : Enum
          {
              T color=(T)Enum.Parse(typeof(T), str);
              return color; 
          }
      }
          enum Color
      {
          Red,
          Yellow,
          Green,
          Blue,
          pink

      }*/
    class Person1
    {
        public int age { get; set; }
        public string name { get; set; }
        public char gender { get; set; }
    }
    /*// task 10
   public static class IEnumerableExtension
   {

       public static  IEnumerable<T> Filter<T>(this IEnumerable<T> values, Func<T,bool> predicate) // vor stanum en inch vor ban u veradardznum en bool predicat en 
       {
           values=values.Where(predicate);
           return values;
       }
   }
    */


    /* // task 12
     public static class IEnumerableExtansion 
     { 
         public static IEnumerable<T> FilterSMS<T>(this IEnumerable<T> value, Func<T, bool> predicate)
         {
             return value.Where(predicate);
         }
     }
     class SMS
     {
         public string sender { get; set; }
         public string specifiedKeyWord { get; set;}
     }
    */



    /* //task 14
   public class DataUsage
     {
         public DateTime date { get; set; } // tvyalneri ogtagorcumy es jamanakahatvacum 
         public int Used { get; set; } //tvyalneri ogtagorcumy 
     }
     public static class IEnumerableExtansion
     {
         public static int CalculateTotalUsage(this IEnumerable<DataUsage> value, DateTime startDate, DateTime endDate)

         {
             return value.Where(v=>v.date >=startDate && v.date<endDate).Select(l=>l.Used).Sum();
         }
     }*/
    /*//task 16
   public class NetworkSpeed
     {
         public DateTime time { get; set; }
         public double speed { get; set; }

     }
     public static class IEnumerableExtansion
     {
         public static double CalculateAverageSpeed(this IEnumerable<NetworkSpeed> value, DateTime startDate, DateTime endDate)
         {
             var totalTime = value.Where(x => x.time >= startDate && x.time < endDate);
             double averageSpeed = value.Select(x => x.speed).Average(); 
             return averageSpeed;        
         }

     }*/
    //task 17 
    /* public class CallRecord
     {

         public string MCC { get; set; }
         public string MNC { get; set; }
          //MCC - ERKRI KOD 283 MNC- OPERATORI KOD 
     }
     public static class IEnumerableExtansion
     {
         public static IEnumerable<CallRecord> isRoaming(this IEnumerable<CallRecord> value, string CountryMCC,string CountryMNC)
         {
             return value.Where(s => s.MCC.Equals(CountryMCC) && s.MNC.Equals(CountryMNC)); 
         }
     }
    */



    /* //task 18 
  public class CallRecord
     {
         public int Duration { get; set; }
     }
     public class DataUsage
     {
         public int Used { get; set; } // inchqan tv ogt 
     }
    public  class TarifPlan
     {
         public string Name{ get; set; }
         public int Minuites { get; set; }
         public int Price { get; set; }
         public int Data { get; set; }
     }
     public static class IEnumerableExtansion
     {
         private static List<TarifPlan> plans = new List<TarifPlan>()
         {
             new TarifPlan() {Name="Start",Data=5120,Minuites=300,Price=2000},
             new TarifPlan() {Name="Y",Data=10240,Minuites=800,Price=30000},
             new TarifPlan() {Name="X",Data=20480,Minuites=3000,Price=5000}
         };

         public static TarifPlan CallRecords (this IEnumerable<CallRecord> calles, IEnumerable<DataUsage> dataUsages)
         {
             int totalcalles=calles.Sum(c => c.Duration);
             int totalData = dataUsages.Sum(d => d.Used);
             return plans.Where(p => p.Data >= totalData && p.Minuites >= totalcalles).OrderBy(p => p.Price).FirstOrDefault();
         }
     }*/



    //new Task 1    ?

    delegate void PrintDelegate(string str);
    internal class Program
    {
        static void Foo(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            PrintDelegate printDelegate = Foo;
            printDelegate("Hello");
           /* //Task 17
            IEnumerable<CallRecord> call = new List<CallRecord>()
            {
                new CallRecord(){MCC="285",MNC="523",},
                new CallRecord(){MCC="283",MNC="374"},
                new CallRecord(){MCC="354",MNC="745"},
                new CallRecord(){MCC="952",MNC="147"}
            };
            string CountryMCC = "283";
            string CountryMNC = "374";

           var callRecords=call.isRoaming(CountryMCC,CountryMNC);
            foreach(var item in  callRecords)
            {
                Console.WriteLine(item.MCC);
            }
            
            */






            /*//Task 16

            IEnumerable<NetworkSpeed> networkSpeed = new List<NetworkSpeed>()
            {
                new NetworkSpeed(){time=new DateTime(2020, 07,11), speed=20},
                new NetworkSpeed(){time=new DateTime(2022, 05, 12), speed=80},
                new NetworkSpeed(){time=new DateTime(2023,04,12), speed=90}
            };

            DateTime startDate = new DateTime(2017, 05, 12);
            DateTime endDate = new DateTime(2023, 12, 10);

            double calculate = networkSpeed.CalculateAverageSpeed(startDate, endDate);
            Console.WriteLine(calculate);

            */

            /*  //TASK 14 
              IEnumerable<DataUsage> dataUsages = new List<DataUsage>()
              {
                  new DataUsage(){date=new DateTime(2023, 01, 12),Used=2},
                  new DataUsage(){date=new DateTime(2023, 07, 1), Used=3},
                  new DataUsage(){date=new DateTime(2022, 05, 2), Used=5},
                  new DataUsage(){date=new DateTime(2020, 08, 10), Used=4},


              };
              DateTime startDate = new DateTime(2017, 05, 14);
              DateTime endDate = new DateTime(2023, 12, 10);
              int calculate = dataUsages.CalculateTotalUsage(startDate, endDate);
              Console.WriteLine(calculate); */




            /*  // task 12
              IEnumerable<SMS> sms = new List<SMS>()
              {
                  new SMS() {sender="Viva-MTS", specifiedKeyWord="Super Bit" },
                  new SMS() {sender="User", specifiedKeyWord="Hi" },
                  new SMS() {sender="DigitalBank", specifiedKeyWord="Warning " },
                   new SMS() {sender="Viva-MTS", specifiedKeyWord="internet" }



              };

              var smsFilter = sms.FilterSMS(s => s.sender == "Viva-MTS" && s.specifiedKeyWord == "internet");
              foreach(var item in smsFilter)
              {
                  Console.WriteLine(item.sender);
              }

              */

            /*  //task 10

              IEnumerable<Person1> person = new List<Person1>()
             {
                 new Person1() {age=15, name="Arman", gender='f'},
                 new Person1() {age=20, name="Vera", gender='m'},
                 new Person1() {age=30, name="Alvard", gender='m'}

             };

              var filterlist = person.Filter(p => p.age > 17);
              foreach(var item in  filterlist)
              {
                  Console.WriteLine(item.name);
              }
            */

            /* //task 9
             string color1 = "pink";
           Color enumcolor=  color1.ParseEnum<Color>();
             Console.WriteLine(enumcolor);*/





            /*   //task 13
             string number = "37494600445";
             string formatedNumber=number.FormatPhoneNumber();
             Console.WriteLine(formatedNumber);
            */



            /*   //task 8
               string file = "C:\\Temp\\csc.txt"; // or Console.ReadLine(); 
               bool isExists = file.FileExists();
               Console.WriteLine(isExists);
            */

        }
    }
}
