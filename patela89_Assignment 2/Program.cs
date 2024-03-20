using System;

    class Program
    {
        static void Main(string[] args)
        {
            int Eventotal = 0;
            int Oddtotal = 0;

           
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even number");
                     Eventotal += i; 
                }
                else
                {
                    Console.WriteLine($"{i} is odd number");
                     Oddtotal += i; 
                }
            }

            
            Console.WriteLine($"Even number's total is: {Eventotal}");
            Console.WriteLine($"Odd number's Toatl is: {Oddtotal}");

          
            Console.ReadLine();
        }
    }

