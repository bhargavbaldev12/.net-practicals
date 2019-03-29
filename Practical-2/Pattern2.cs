using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p2
{
    class Pattern2
    {
        static void Main(String[] ar){
            for(int i=1;i<5;i++){
                for(int j=1;j<=i;j++){
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
