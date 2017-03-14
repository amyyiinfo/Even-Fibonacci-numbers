using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenSumFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int a = 1;
                int b = 2;
                int c = 0;
                int sum = 2;

                while (b < 4000000)
                {
                    c = a + b;
                    a = b;
                    b = c;


                    if (c % 2 == 0)
                    {
                        sum = sum + c;
                    }
                }
                Console.WriteLine(sum);
                Console.Read();
        }
         
        
    }
}
