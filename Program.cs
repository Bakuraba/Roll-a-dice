using System;

namespace c__basics
{
    class Program
    {
        static void Main(string[] args)
        
        {
          Console.Title = "DICE GAME";
          Console.ForegroundColor = ConsoleColor.Red;
          Random numbergen = new Random();

          int roll01 = 0;
          int roll02 = 0;
          int attempts = 0;
          int result = 0;

          Console.WriteLine("Welcome to my game press any key to start");
          Console.ReadKey(true);

          Console.WriteLine("You have to roll a combination of 12.");
          Console.WriteLine("Press the SPACEBAR to roll the dice: ");

          while(result != 12){
                while(Console.ReadKey(true).Key == ConsoleKey.Spacebar && result != 12)
{
                roll01 = numbergen.Next(1, 7);
                Console.WriteLine("Roll 1: " +roll01);
                roll02 = numbergen.Next(1, 7);
                Console.WriteLine("Roll 2: " +roll02);
                result = roll01 + roll02;
                Console.WriteLine("You rolled: " +result);
                Console.WriteLine("--------------");
                attempts++;
                }
          }

          Console.WriteLine("It took you " +attempts+ " attempt to roll a 12");
          Console.WriteLine("Press ESCAPE to leave");
          while(Console.ReadKey(true).Key != ConsoleKey.Escape)
          {

          }
        }
    }
}
