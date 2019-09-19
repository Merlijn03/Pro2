using System;

namespace Ultra_Shooter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######################################################################################################");
            Console.WriteLine("##############                                                                         ###############");
            Console.WriteLine("##############                       Welcome to Ultra Shooter!!!                       ###############");
            Console.WriteLine("##############                                                                         ###############");
            Console.WriteLine("##############                            Press A to start                             ###############");
            Console.WriteLine("##############                                                                         ###############");
            Console.WriteLine("######################################################################################################");
            
            string enteredButton = Console.ReadLine().ToLower();

            if (enteredButton == "a")
            {
                Console.WriteLine("Game starting...");
            }

            Console.ReadLine();

            Console.Clear();
        }
    }
}
