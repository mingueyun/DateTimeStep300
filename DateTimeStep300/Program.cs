using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeStep300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("give me number in hours you want to be reminded?");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(x));

            Console.ReadLine();
        }
    }
    
}
