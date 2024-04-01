using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_01
{
    class Program
    {
        public static void AllocateMovie(string theatreName, out TimeSpan movieTiming,
         out string movieName)
        {
            if (theatreName.Equals("INOX") || theatreName.Equals("PVR"))
            {
                movieName = "Captain America:Civil War";
                movieTiming = new TimeSpan(9, 30, 00);
            }
            else
            {
                movieName = "The Jungle Book";
                movieTiming = new TimeSpan(10, 00, 00);
            }
        }
        static void Main(string[] args)
        {
            var obj = new RabbitMQConnectionChecker();
            obj.ConnectionChecker();

            string movieName;
            TimeSpan movieTiming;
            AllocateMovie("PVR", out movieTiming, out movieName);
            Console.WriteLine("Movie Timing :{0} ", movieTiming);
            Console.WriteLine("Movie Name : {0}", movieName);

            Console.ReadKey();
        }
    }
}
