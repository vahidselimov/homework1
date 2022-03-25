using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Isodd(12));
            Console.WriteLine(Iseven(13));

        }
        public static bool Isodd(int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;

            }



        }
    }
    public static bool Iseven (int num2)
    {
        if (num2%2==0)
        {
            return true;

        }
        else
        {
            return false;
        }
    }


}







