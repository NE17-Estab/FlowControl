﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }


        public static void MainMenu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("This is the main menu.");
                Console.WriteLine("Input a number to choose function");
                Console.WriteLine("1)Cinema");
                Console.WriteLine("2)Cinema");
                Console.WriteLine("3)Cinema");
                Console.WriteLine("0) Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AdolescentOrSenior();
                        break;
                    case "2":
                        RepeatTenTimes();
                        break;
                    case "3":
                        ThirdWord();
                        break;
                    case "0":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\nTry Again");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AdolescentOrSenior()
        {
            Console.Clear();
            Console.Write("What is your age?: ");
            string input = Console.ReadLine();
            int age = 0;
            int.TryParse(input, out age);
            if (age < 20)
            {
                Console.WriteLine("Kid deal: 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior Citizen Discount: 90kr");
            }
            else
            {
                Console.WriteLine("Standard Price: 120kr");
            }
            Console.ReadLine();
        }

        public static void RepeatTenTimes()
        {
            Console.Clear();
            Console.WriteLine("What do you want repeated?: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1)+". "+input+",");
            }
            Console.ReadLine();


        }

        public static void ThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Please enter a sentence with at least three words");
            string input = Console.ReadLine();            
            string[] arrayOfWords = input.Split(' ');
            if (arrayOfWords.Length < 3)
            {
                Console.WriteLine("The sentence needs to be at least three words long");
            }
            else
            {
                Console.WriteLine(arrayOfWords[2]);
                Console.ReadLine();
            }
        }
    }

}
