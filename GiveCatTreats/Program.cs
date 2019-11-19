using System;

namespace GiveCatTreats
{
    class Program
    {
        static void Main(string[] args)
        {
            CatGreeting();

            Console.WriteLine("\nI'm hungry. Please select a treat for me to eat!\nPlease select a treat: fish, chicken, catnip");
            string userChoice = Console.ReadLine();

            FeedCat(userChoice);

            CatGoodbye();

            Console.ReadLine();
        }

        //Cat greeting and welcome
        static void CatGreeting()
        {
            Console.WriteLine("Hi, my name is Rupert, the cat. Hear me meow!");
            Console.Write("MEEE");
            Console.Beep(1700, 800);
            Console.Write("OW");
            Console.Beep(1400, 500);
        }

        //options for feeding cat
        static void FeedCat(string treat)
        {
            if (treat == "fish")
                Console.WriteLine("Yum! I love fish! NOM NOM NOM");
            else if (treat == "chicken")
                Console.WriteLine("So good... Chicken yum in my tum.");
            else if (treat == "catnip")
                Console.WriteLine("Catnip pleases me!");
            else
            {
                Console.WriteLine($"{treat} is not an acceptable treat!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        // cat thank you and end
        static void CatGoodbye()
        {
            Console.Write("YUM");
            Console.Beep(1300, 350);
            Console.Write("MY");
            Console.Beep(1500, 400);
            Console.WriteLine("\nThank you for the treat!\nGood-bye!");
        }

    }
}
