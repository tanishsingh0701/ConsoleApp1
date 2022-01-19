using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LoopExercise
    {
        public static void divisible_by3() 
        {
            var count = 0;
            for(var i = 1; i <= 100; i++) 
            {
                if (i % 3 == 0) 
                {
                    count++;
                }

            }
            Console.WriteLine($"There are {count} numbers divisible 3 in between 1 to 100");
        }

        public static void OkNumber() 
        {
            while (true) 
            {
                Console.WriteLine("Please enter number");
                var input =Console.ReadLine();
                if (input == "ok")
                    break;
            }
        }

        public static void Factorial() 
        {
            Console.WriteLine("Please enter the number");
            var number = Convert.ToInt32(Console.ReadLine());
            var fact=1;
            if (number == 0 || number == 1)
            {
                fact = 1;
            }
            else 
            {
                for (int i = 1; i <= number; i++) 
                {
                    fact *= i;
                }
            }
            Console.WriteLine($"The Factotial of {number} is: "+fact);
        }

        public static void GuessNumber() 
        {
            var random_obj = new Random();
            for (var i = 0; i < 4; i++) 
            {
                var secret_num = random_obj.Next(1,10);
                Console.WriteLine("Please enter the number for guess");
                var num = Convert.ToInt32(Console.ReadLine());
                if (secret_num == num)
                {
                    Console.WriteLine("Great Success");
                    return;
                }
                else 
                {
                    Console.WriteLine($"You loose the number is {secret_num}");
                }
            }
        }

        public static void MaxNumber() 
        {
            Console.WriteLine("Please enter the numbers seperated by ,");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            foreach (var str in numbers) 
            {
                var nums = Convert.ToInt32(str);
                if (nums > max) 
                {
                    max = nums;

                }
            }
            Console.WriteLine($"The Max number is: "+max);
        }
    }
}
