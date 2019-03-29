using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p2
{
    class Read
    {
        static void Main(String[] ar) {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your City:");
            string city = Console.ReadLine();
            Console.WriteLine("Hello {0} from city {1}",name,city);
        }
    }
}
