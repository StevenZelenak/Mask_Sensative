using System;

namespace Mask_Sensative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a secret message! I won't tell anyone I promise? ;)");
            string secretMess = Console.ReadLine();

            for(int i = 0; i < secretMess.Length; i++)
            {
                if(i >= secretMess.Length - 4)
                {
                    Console.Write(secretMess[i]);
                }
                else
                {
                    Console.Write("*");
                }
                
            }
        }
    }
}
