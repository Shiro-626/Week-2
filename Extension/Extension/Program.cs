using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1A Extension



            Console.WriteLine("Please choose which task you want to execute");
            Console.WriteLine("For task 1 push 1");
            Console.WriteLine("For task 2 push 2");
            Console.WriteLine("For task 3 push 3");
            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 1){
                Task1();
            }
            else if (choice == 2) {
                Task2(); }
            else {
                Task3();
            }

            

        }

        public static void Task1()
        {
            //Task 1 


            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            String age = Console.ReadLine();

            Console.WriteLine("Please enter your gender");
            String gender = Console.ReadLine();

            Console.WriteLine("Please enter your address");
            String address = Console.ReadLine();

            Console.Write("\nHello {0}, your age is {1}, your gender is {2}, and your adress is {3}", name, age, gender, address);
            Console.ReadLine();
        }

        public static void Task2()
        {
            //Task 2


            Console.WriteLine("\nPlease enter your first number");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please choose which calculation you want to perform");
            Console.WriteLine("");
            


            float add = num1 + num2;
            float multiply = num1 * num2;
            float divide = num1 / num2;
            float subtract = num1 - num2;


            Console.WriteLine("Calculations");

            Console.WriteLine("{0} + {1} = {2}", num1, num2, add);

            Console.WriteLine("{0} * {1} = {2}", num1, num2, multiply);

            Console.WriteLine("{0} / {1} = {2}", num1, num2, divide);

            Console.WriteLine("{0} - {1} = {2}", num1, num2, subtract);

            Console.ReadLine();
        }

        public static void Task3()
        {
            //Task 3


            Console.WriteLine("\nPlease enter your first name");
            string firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            string lastname = Console.ReadLine();

            Console.WriteLine("Your name is {0} {1}", firstname, lastname);
            //or Console.WriteLine("Your name is {0} " + "{1}", firstname, lastname);
            Console.ReadLine();

        }
    }
}
