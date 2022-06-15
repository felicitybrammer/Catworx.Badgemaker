// See https://aka.ms/new-console-template for more information
using System;

namespace CatWorx.Badgemaker 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string greeting = "Hello";
            greeting = greeting + " World";
            Console.WriteLine("greeting: " + greeting);
            Console.WriteLine($"greeting: {greeting}");
            Console.WriteLine("greeting: {0}", greeting);
        }
    }
}




