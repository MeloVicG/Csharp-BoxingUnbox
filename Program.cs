using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box some string data into a variable
            List<object> BoxedData = new List<object>();
            BoxedData.Add(7);
            BoxedData.Add(28);
            BoxedData.Add(-1);
            BoxedData.Add(true);
            BoxedData.Add("chair");
            Console.WriteLine("we are here");



            int Sum = 0;
            foreach (object Box in BoxedData)
            {
                if (Box is int)
                {
                    Console.WriteLine("-" + Box);
                    Sum += (int)Box;
                    // Console.WriteLine("*sum = " + Sum);
                    
                }
                else if (Box is bool)
                {
                    Console.WriteLine("-" + Box);
                }
                else if (Box is string)
                {
                    Console.WriteLine("-" + Box);
                }
            }
                Console.WriteLine("*sum = " + Sum);


        }
    }
}