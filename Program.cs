using System;

namespace Converting_Decimal_to_Octal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converting Decimal Numbers to Octal
            int x, y, z;
            int oc = 0, de;
            Console.WriteLine("Convert decimal to octal\n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Number to convert =");
            x = Convert.ToInt32(Console.ReadLine());
            de = x;
            y = 1;
            for (z = x; z > 0; z = z / 8) 
            {
                oc = oc + (z % 8) * y;
                y = y * 10;
                x = x / 8;
            }
            Console.Write("\nThe Octal of {0} is {1} \n\n", de, oc);
            Console.ReadLine();
            
        }
    }
}
