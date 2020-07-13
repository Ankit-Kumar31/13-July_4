using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_no._check
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,i=0;
            Console.WriteLine("Enter the number to be checked for prime");
            a = Convert.ToInt16(Console.ReadLine());
            for(b=1;b<=a;b++)
            {
                if(a%b==0)
                {
                    i++;
                }
            }
            if (i == 2)
            {
                Console.WriteLine("No. entered is prime");
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("No. entered is not prime");
            }

        }

    }
}
