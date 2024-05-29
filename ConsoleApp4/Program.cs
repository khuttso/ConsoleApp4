using System;
namespace Run;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a range:");
            Console.Write("From: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("To: ");
            int y = Convert.ToInt32(Console.ReadLine());

            while (x >= y)
            {
                Console.WriteLine("Invalid Range, Please enter again");
                Console.Write("From: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("To: ");
                y = Convert.ToInt32(Console.ReadLine());
            }

            while (true)
            {
                int middle = (x + y) / 2;
                Console.WriteLine("Is your number " + middle + " ?");
                Console.WriteLine("Type '=' if your number is " + middle + ", '>' if your number is greater, '<' otherwise");
                string response = Console.ReadLine().Trim();
                while (response != "=" && response != ">" && response != "<")
                {
                    response = Console.ReadLine().Trim();
                }
                if (response == "=")
                {
                    Console.WriteLine("The program guessed your number!\n"+middle);
                    break;
                }

                if (response == ">")
                {
                    if (middle == y)
                    {
                        while (response != "=")
                        {
                            Console.WriteLine("Wrong Input, try again");
                            response = Console.ReadLine();
                        }
                        Console.WriteLine("The program guessed your number!\n"+middle);
                        break;
                    }
                    x = middle + 1;
                }
                else
                {
                    if (middle == x)
                    {
                        while (response != "=")
                        {
                            Console.WriteLine("Wrong Input, try again");
                            response = Console.ReadLine();
                        }
                        Console.WriteLine("The program guessed your number!\n"+middle);
                        break;
                    }
                    y = middle - 1;
                }
            }
            Console.WriteLine("Do u want to continue? \nif yes then type '1', otherwise type any integer");
            int game = int.Parse(Console.ReadLine());
            if (game != 1)
            {
                Console.WriteLine("Game over thanks for playing with me");
                Console.WriteLine(game);
                break;
            }
        }
    }
}