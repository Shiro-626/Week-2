using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean restart = true;

            do
            {

                Console.WriteLine("Please choose which task you want to execute");
                Console.WriteLine("For task 1 push 1");
                Console.WriteLine("For task 2 push 2");
                Console.WriteLine("For task 3 push 3");
                Console.WriteLine("For task 4 push 4");
                Console.WriteLine("For task 5 push 5");
                Console.WriteLine("For task 6 push 6");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Task1();
                }
                else if (choice == 2)
                {
                    Task2();
                }
                else if (choice == 3)
                {
                    Task3();
                }
                else if (choice == 4)
                {
                    Task4();
                }
                else if (choice == 5)
                {
                    Task5();
                }
                else
                {
                    Task6();
                }

                Console.WriteLine("Do you want to run another task, Y/N");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }
                Console.Clear();
            } while (restart);





        }

        public static void Task1()
        {
            //Task 1 - Comparing Integers

            Console.WriteLine("Please enter your first number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            int num2 = Int32.Parse(Console.ReadLine());

            if ( num1 == num2)
            {
                Console.WriteLine("These numbers are equal");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1}", num2, num1);
            }

        }

        public static void Task2()
        {
            //Task 2 - Guess my number

            int userNum = 0, myNum = 6;

            while (userNum != myNum) {

                Console.WriteLine("\nGuess my number between 1-10, please enter a number");
                userNum = Int32.Parse(Console.ReadLine());

                if (userNum == myNum) {
                    Console.WriteLine("You guessed my number");
                }
                else if (userNum > myNum) {
                    Console.WriteLine("Your guessed number is too high");
                }
                else if (userNum < myNum)
                {
                    Console.WriteLine("Your guessed number is too low");
                }
            }

        }

        public static void Task3()
        {
            //Task 3 - Grade

            int finalMark = 100;

            Console.WriteLine("Please enter in your final mark");
            finalMark = Int32.Parse(Console.ReadLine());

           // while (finalMark >= 101 || < 0) {
                if (finalMark > 100)
                {
                    Console.WriteLine("Warning: The mark you entered is greater than 100");
                }
                else if (finalMark == 100)
                {
                    Console.WriteLine("Your final mark is A+");
                }
                else if (finalMark >= 90)
                {
                    Console.WriteLine("Your final mark is A+");
                }
                else if (finalMark >= 80)
                {
                    Console.WriteLine("Your final mark is A");
                }
                else if (finalMark >= 70)
                {
                    Console.WriteLine("Your final mark is B+");
                }
                else if (finalMark >= 60)
                {
                    Console.WriteLine("Your final mark is B");
                }
                else if (finalMark >= 50)
                {
                    Console.WriteLine("Your final mark is C");
                }
                else if (finalMark >= 40)
                {
                    Console.WriteLine("Your final mark is D");
                }
                else if (finalMark >= 0)
                {
                    Console.WriteLine("Your final mark is F");
                }
                else
                {
                    Console.WriteLine("Warning: The mark you entered is less than 0");
                }
          //  }

        }

        public static void Task4()
        {
            //Task 4 - Odd or Even

        /*    int userNum =  ;

            Console.WriteLine("Please enter a number");
            userNum = int.Parse(Console.ReadLine());

            if (userNum = )
            {
                Console.WriteLine("");
            }
            */
        }

        public static void Task5()
        {
            //Task 5 - New PIN Number program

            Console.WriteLine("Please enter a 4 digit pin number");
            int pin = Int32.Parse(Console.ReadLine());



        }
        public static void Task6()
        {

        }
    }
}
