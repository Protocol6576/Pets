using System;
using WorldInteraction;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldIntecaction make = new WorldIntecaction();

            make.RandCreation();
            make.ShowMap();

            int bruh = 0;

            while (bruh == 0)
            {
                make.Stepment();
                bruh = make.Move();
            }

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("((Вставить экран победы))");
        }
    }
}
