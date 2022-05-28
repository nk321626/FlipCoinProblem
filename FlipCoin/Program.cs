using System;

namespace FlipCoinProblem;

class Program
{
    static void Main(string[] args)
    {
        string[] coin = { "head", "tails" };
        int user;
        int heads = 0;
        int tails = 0;
        var random = new Random();
        const int faces = 2;

        Console.WriteLine("Enter 1 to flip a coin or 2 to leave: ");
        user = Convert.ToInt32(Console.ReadLine());

        while (user == 1)
        {
            int second = random.Next(faces);
            if (second == 1)
            {
                Console.WriteLine("Coin landed on heads");
                heads += 1;
                Console.WriteLine($"you have landed on head: {heads} time(s)");
                Console.WriteLine($"yoy have lanched on tails: {tails} time(s)");
            }
            else
            {
                Console.WriteLine("Coin landed on tails");
                tails += 1;
                Console.WriteLine($"you have landed on head: {heads} time(s)");
                Console.WriteLine($"you have lanched on tails: {tails} time(s) ");
            }
            Console.Write("enter 1 to flip again , or 2 to leave:");
            user = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("==========Bye==========");
    }
}
