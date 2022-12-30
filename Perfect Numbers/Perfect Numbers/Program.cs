using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N1 , N2 ");
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int i , s ;
            for( int x =N1;x <=N2; x++)
            { i = 1;
                s = 0;
            while(i < x )
                {
                    if (x % i == 0)
                        s += i;
                    i++;
                }
                if (s == x)
                    Console.WriteLine("{0}" ,x);
            
            
            }
            
            Console.ReadKey();


        }
    }
}
