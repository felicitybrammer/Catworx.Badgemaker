// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic; 

namespace CatWorx.Badgemaker 
{
    class Program 
    {
         static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            //collect user values until the value is an empty string
            while(true) 
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                //break if user hits ENTER without typing a name
                if (input == "") 
                {
                    break;
                }
                employees.Add(input);
            }
            return employees;
        }

        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++) {
                Console.WriteLine(employees[i]);
            }
        }

        static void Main(string[] args)
        {
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}




