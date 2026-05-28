using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace areatrainermodified
{
    class MainClass
    {
        
        static string passwordCreator(string ifo)
        {
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string password = "";

            for (int i = 0; i < 5; i++)
            {
                Random rand = new Random();
                int componentposition = rand.Next(0, 26);
                string component = alphabet[componentposition];
                password = password + component;
            }
            return password;

        }
        static string accountinfoFormating(string name, string password)
        {
            string details = name + "," + password;
            return details;
        }

        static string mainMenuInputValidation(string userchoice)
        {
            while (userchoice.ToLower() != "calculate area" && userchoice.ToLower() != "close")
            {
                Console.WriteLine("Invalid input please input one of the options presented in the main menu");
                userchoice = Console.ReadLine();
            }

            return userchoice;
        }

        static string userShapeFormating(string usershape)
        {
            while (usershape.ToLower() != "square" && usershape.ToLower() != "circle" && usershape.ToLower() != "trapezium" && usershape.ToLower() != "triangle")
            {
                Console.WriteLine("invalid shape input, please select a shape presented in the prior menu");
                usershape = Console.ReadLine();
            }
            return usershape;
        }

        static string mainMenu(string details)
        {
            Console.WriteLine("chose one of the following options: \n calculate area \n close");
            string userchoice = Console.ReadLine();

            userchoice = mainMenuInputValidation(userchoice); // calls validation subroutine

            if (userchoice.ToLower() == "calculate area")
            {
                Console.WriteLine("What shape do you wish to calculate? select one of the following options \n sqaure \n circle \n trapezium \n triangle");
                string usershape = Console.ReadLine();
                usershape = userShapeFormating(usershape);
                if (usershape.ToLower() == "square")
                {
                    square(usershape);
                }
                else if (usershape == "circle")
                {
                    circle(usershape);
                }
                else if (usershape == "trapezium")
                {
                    trapezium(usershape);
                }
                else // if input is triangle
                {
                    triangle(usershape);
                }

            }

            return userchoice;
        }

        static void square(string usershape)
        {
            Console.WriteLine("enter the length of side 1");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the dimensions of side 2");
            double side2 = Convert.ToDouble(Console.ReadLine());
            double area = side1 * side2;
            userAnswerChoice(area);
        }

        static void circle(string usershape)
        {
            const double pie = 3.142;
            Console.WriteLine("enter the radius, bare in mind the calcualted area will use 3.142 as pie");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = pie * (radius * radius);
            userAnswerChoice(area);
        }

        static void triangle(string usershape)
        {
            Console.WriteLine("what triangle dimensions do you have? Select an option: \n 1. 3 sides \n 2. base and height \n 3. 2 sides and an angle");
            int userResponse = Convert.ToInt32(Console.ReadLine());
            while(userResponse != 1 && userResponse != 2 && userResponse != 3)
            {
                Console.WriteLine("invalid input, please select one of the shown options");
                userResponse = Convert.ToInt32(Console.ReadLine());
            }

            if (userResponse == 1)
            {
                Console.WriteLine("what is the length of side 1?");
                double side1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("what is the length of side 2?");
                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("what is the length of side 3?");
                double side3 = Convert.ToDouble(Console.ReadLine());

                double area = herronsFormulafortrianglearea(side1, side2, side3);
                userAnswerChoice(area);
            }
            else if (userResponse == 2)
            {
                square(usershape); // this will effectively calculate base and height
            }
            else // if option is 3
            {
                Console.WriteLine("enter the length of side 1");
                double side1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter the length of side 2");
                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter the size of the angle");
                double angle = Convert.ToDouble(Console.ReadLine());

                double area = triangleAreaUsingSine(side1, side2, angle);
                userAnswerChoice(area);
            }
            
        }

        static double herronsFormulafortrianglearea(double side1, double side2, double side3)
        {
            double halfPerimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(halfPerimeter * ((halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3))); // this will square root internal sum providing the area as determined by herons formula

            return area;
        }

        static double triangleAreaUsingSine(double side1, double side2, double angle)
        {
            double area = 0.5 * side1 * side2 * (Math.Sin(angle));
            return area;
        }
        static void trapezium(string usershape)
        {
            Console.WriteLine("enter the length of the first parallel side");
            double parallelside1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what is the length of the second parallel side?");
            double parallelside2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the height?");
            double height = Convert.ToDouble(Console.ReadLine());


            double sumOfParallelSides = 0.5 * (parallelside1 + parallelside2);
            double area = sumOfParallelSides * height;
            userAnswerChoice(area);
        }

        static double NumberComparison(double ans, double area)
        {
            Random rand = new Random();

            while(ans ==  area)
            {
                ans = rand.Next(0, 1000);
            }
            return ans;
        }
        static void userAnswerChoice(double area)
        {
            int score = 0;
            Random rand = new Random();
            double ans1 = rand.Next(0, 1000);
            ans1 = NumberComparison(ans1, area);
            double ans2 = rand.Next(0, 1000);
            ans2 = NumberComparison(ans2, area);
            double ans3 = rand.Next(0, 1000);
            ans3 = NumberComparison(ans3, area);

            Console.WriteLine("{0}, {1}, {2}, {3}", ans1, area, ans2, ans3);

            Console.WriteLine("enter the value that you believe to be the answer");
            double userBelief = Convert.ToDouble(Console.ReadLine());

            while (userBelief != ans1 && userBelief != ans2 && userBelief != ans3 && userBelief != area)
            {
                Console.WriteLine("invalid input please select one of the numbers shown above");
                userBelief = Convert.ToDouble(Console.ReadLine());
            }
            if (userBelief == area)
            {
                Console.WriteLine("Correct! you have earnt 2 points");
                score =+ 2;
            }
            else
            {
                Console.WriteLine("incorrect please try again, the options are the same as before");
                userBelief = Convert.ToDouble(Console.ReadLine());
                if (userBelief == area)
                {
                    Console.WriteLine("Correct! you have earnt 1 point");
                    score =+ 1;
                }
                else
                {
                    Console.WriteLine("That is incorrect, the correct anser was {0}", area);
                }

            }
        }

        public static void Main(string[] args)
        {
            string name = "";
            string Password = "";
            string trigger = "";
            string userChoice = "";
            int score = 0;

            Console.WriteLine("welcome to area trainer! what is you name?");
            name = Console.ReadLine();

            Console.WriteLine("Your username is: {0}", name);
            Password = passwordCreator(name);
            Console.WriteLine("your password is: {0}", Password); // calls password subroutine
            string details = accountinfoFormating(name, Password); //stores user credentials for later use

            Console.WriteLine("to start type begin");
            trigger = Console.ReadLine();
            while (trigger == "begin")
            {
                userChoice = mainMenu(details);

                if (userChoice.ToLower() == "close")
                {
                    Console.WriteLine("Goodbye! To try another shape enter 'begin'");
                    trigger = Console.ReadLine();
                }
            }

            Console.Read();
        }
    }
}
