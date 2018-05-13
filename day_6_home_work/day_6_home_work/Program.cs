using System;

namespace day_6_home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string y = Console.ReadLine();
            int z = Convert.ToInt32(y);
            
            
            for (int x = 1; x < 11; x++) 
            {
                Console.WriteLine(x * z);
                
            }



            Console.ReadLine();
        }
    }
}
