using System;

namespace Tesonet20191011KasparasMociunas
{
    class Program
    {
        static void Main(string[] args)
        {
            prime(); //calculations will be made in a separate method
        }

        static void prime()
        {
            Console.WriteLine("Insert first number");

                int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number");
            int last = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (first > last)
            {
                Console.WriteLine("firs number is smaller than the second");
            }
            else
            {
                for (int i = first; i <= last; i++)
                {
                    int x = 1; //the number being checked
                    int z = 0; //dividers
                    while (x < i) //
                    {
                        if (i % x == 0) 
                        {
                            z = z + 1; 
                        }
                        x++;
                    }
                    if (z == 1)
                    {
                        sum++; //one more prime number found
                    }
                }
            }
            Console.WriteLine("Prime numbers in a range: ");
            Console.WriteLine(sum);
        }
    }
}


