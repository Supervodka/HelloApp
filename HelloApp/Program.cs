using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press smth");
            string selection= Console.ReadLine();
            switch (selection)
            {
                case "Boris":
                    Console.WriteLine("Blade");
                    break;
                case "Tone":
                    Console.WriteLine("Bullet Dodger");
                    break;                   
                case "Avi":
                    Console.WriteLine("Jew");
                    break;
                default:
                    Console.WriteLine("Snatch");
                    break;
            }
        }
    }
}
