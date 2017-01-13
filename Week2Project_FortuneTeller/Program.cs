using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Project_FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Madame Jen's!");
            Console.WriteLine("The answer to the mysteries of your future awaits.");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine(HelloMyNameIs(firstName, lastName));

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born? Use numerical value.");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color?");

            Console.WriteLine("Type Help for a definition of ROYGBIV");

            string colorAnswer = Console.ReadLine();
            colorAnswer = colorAnswer.ToLower();

            if (colorAnswer == "help")
            {

                Console.WriteLine("red, orange, yellow, green, blue, indigo, violet");
                Console.WriteLine("What color do you choose?");
                colorAnswer = Console.ReadLine();
                colorAnswer = colorAnswer.ToLower();
            }

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

        
            Console.WriteLine(firstName + " " + lastName + " will retire in " + YearToRetire(age) + " years" + " with $" + MoneyInBank(month) + " in the bank" + " with" + VacationHome(siblings) + " and " + ToTravel(colorAnswer) + ".");
            JudgeFortune();
        }
        //this is the end of static & beginning of class
        static string HelloMyNameIs(string firstName, string lastName)
        {
            string firstAndLastname = ("Greetings " + firstName + lastName + ". I will tell you your fortune!");
            return firstAndLastname;
        }

        static int YearToRetire(int age)
        {
            int YearToRetire = 0;

            if (age % 2 == 0)
            {
                YearToRetire = 20;
            }
            else
            {
                YearToRetire = 40;
            }

            return YearToRetire;
        }

        static string VacationHome(int siblings)
        {
            string vacationHome;
            switch (siblings)

            {
                case 0:
                    vacationHome = "a cabin in the Smoky Mountains";
                    break;
                case 1:
                    vacationHome = "a beach house at Venice Beach";
                    break;
                case 2:
                    vacationHome = "a boat house in Seattle";
                    break;
                case 3:
                    vacationHome = "a beach house in Key West";
                    break;
                case 4:
                    vacationHome = "a ranch in California";
                    break;
                default:
                    vacationHome = "a mobile home in Kansas";
                    break;
            }

            return vacationHome;
        }
        static string ToTravel(string colorAnswer)
        {
            string toTravel = " ";
            switch (colorAnswer.ToLower())

            {
                case "red":
                    toTravel = "a Mustang";
                    break;
                case "orange":
                    toTravel = "a Cruiser bike";
                    break;
                case "yellow":
                    toTravel = "a Subaru";
                    break;
                case "green":
                    toTravel = "a Prius";
                    break;
                case "blue":
                    toTravel = "a yacht";
                    break;
                case "indigo":
                    toTravel = "a private jet";
                    break;
                case "violet":
                    toTravel = "a convertible";
                    break;
                default:
                    toTravel = "a squeaky shopping cart";
                    break;
            }
            return toTravel;
        }

        static double MoneyInBank(int month)

            {            
                double money;
                if (month >= 1 && month <= 4)
                {
                    money = 300000d;
                }
                else if (month >= 5 &&  month <= 8)
                {
                    money = 400000d;
                }
                else if (month >=  9 && month <= 12)
                {
                    money = 500000d;
                }

                else
                {
                    money= 0.0d;
                }
                return money;

            }
        static void JudgeFortune()
        {
            string great = "What a great fortune!";
            Console.WriteLine(great);
                  
        }


        }



        }
    

