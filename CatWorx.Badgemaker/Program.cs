// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic; 

namespace CatWorx.Badgemaker 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string greeting = "Hello";
            greeting = greeting + " World";
            //Console.WriteLine("greeting: " + greeting);
            //Console.WriteLine($"greeting: {greeting}");
            //Console.WriteLine("greeting: {0}", greeting);

            // How do you find the area of a square? Area = side * side
            double side = 3.14;

            double area = side * side;
            //Console.WriteLine("Area: {0}", area);
            //Console.WriteLine("Area is a {0}", area.GetType());

            // Console.WriteLine(2 * 3);
            // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
            // Console.WriteLine(1 + 2 * 3);     // order of operations
            // Console.WriteLine(10 / 3.0);      // int's and doubles
            // Console.WriteLine(10 / 3);        // int's 
            // Console.WriteLine("12" + "3");    // What happens here?
            // int num = 10;
            // num += 100;
            // Console.WriteLine(num);
            // num ++;
            // Console.WriteLine(num);
            // bool isCold = true;
            // Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
            // Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice
            
            // string stringNum = "2";
            // int intNum = Convert.ToInt16(stringNum);
            // Console.WriteLine(intNum);
            // Console.WriteLine(intNum.GetType());

            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
                { "firstInning", 10 },
                { "secondInning", 20 },
                { "thirdInning", 30 },
                { "fourthInning", 40 },
                { "fifthInning", 50 },
            };
            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

        }
    }
}




