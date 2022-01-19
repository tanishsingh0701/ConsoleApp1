using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayPractice
    {
        public static void ArrayDemo() 
        {
            var numbers = new int[] { 1,4,5,3,7};

            //or var numbers=new[]{1,2,5,3,6}

            Console.WriteLine("Length: "+numbers.Length);

            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3 is: "+index);

            Array.Clear(numbers, 0, 2);

            foreach(var num in numbers) 
            {
                Console.Write("["+num+"]");
            }
            Console.WriteLine();

            int[] second_array = new int[3];
            Array.Copy(numbers, second_array, 3);

            foreach(var num in second_array)
                Console.Write("[" + num + "]");

            Console.WriteLine();

            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.Write("[" + num + "]");
            }


        }

        public static void ListDemo() 
        {
            var numbers = new List<int>() {1,5,2,87,65 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 43, 45, 65 });

            foreach (var num in numbers) 
            {
                Console.Write("["+num+"]");
            }
            Console.WriteLine();

            Console.WriteLine("The index of 65 is: "+numbers.IndexOf(65));
            Console.WriteLine("The Last index of 65 is: " + numbers.LastIndexOf(65));

            Console.WriteLine("The length of list: "+numbers.Count);

            for (var i = 0; i < numbers.Count; i++) 
            {
                if (numbers[i] == 65) 
                {
                    numbers.Remove(65);
                }
            }
            Console.WriteLine("After remove");
            foreach (var num in numbers)
            {
                Console.Write("[" + num + "]");
            }

            // for remove all element use numbers.Clear();
        }

        public static void ArrayExercise1() 
        {
            var names = new List<string>();
            while (true) 
            {
                Console.WriteLine("Enter the name");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input)) 
                {
                    names.Add(input);
                    continue;

                }
                break;
                

            }
            if (names.Count == 0) { }
            else if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " likes your post");
            }
            else if (names.Count == 2) 
            {
                Console.WriteLine(names[0] +" and "+names[1] +" likes your post");

            }
            else 
            {
                Console.WriteLine(names[0] +", " + names[1] +" and "+(names.Count-2)+ " others likes your post");

            }
        }

        public static void ReverseName() 
        {
            Console.WriteLine("Please enter your name");
            
            var input = Console.ReadLine();
            //Console.WriteLine(input.Length);
            var name_array = new char[input.Length];
            
            var j = 0;
            for (var i = input.Length - 1; i >= 0; i--) 
            {
                //Console.Write(input[i]);
                
                name_array[j] = input[i];
                j++;
            }

            var reverse_value = new string(name_array);
            Console.WriteLine("The reverse string is: "+reverse_value);

        }

        public static void FiveUniqueNumbers() 
        {
            var numbers = new List<int>();
            var count = 0;
            while (count<5) 
            {
                Console.WriteLine("Enter Unique numbers");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.IndexOf(input) == -1)
                {
                    numbers.Add(input);
                    count++;
                }
                else 
                {
                    Console.WriteLine("The number is already entered please retry");
                }

            }
            Console.WriteLine("The numbers you entered");

            foreach (var num in numbers) 
            {
                Console.Write(num+" ");
            }
        }

        public static void UniqueNumbers() 
        {
            var numbers = new List<int>();
            var unique_nos = new List<int>();
            while (true) 
            {
                Console.WriteLine("Enter the number");
                var input = Console.ReadLine();
                if (input == "Quit")
                    break;

                numbers.Add(Convert.ToInt32(input));

            }
            
            for (var i = 0; i < numbers.Count; i++) 
            {
                if (unique_nos.IndexOf(numbers[i]) == -1)
                {
                    unique_nos.Add(numbers[i]);
                    
                }

            }

            foreach (var num in unique_nos) 
            {
                Console.WriteLine(num);
            }

        }

        public static void CommaSeperatedNumbers() 
        {
            Console.WriteLine("Enter the numbers with comma seperated");
            while (true) 
            {
               
                var input = Console.ReadLine();
                var numbers_string = input.Split(',');
                var numbers = new int[numbers_string.Length];
                for(int i = 0; i < numbers_string.Length; i++) 
                {
                    numbers[i] = Convert.ToInt32(numbers_string[i]);

                }
                if (numbers.Length < 5) 
                {
                    Console.WriteLine("Please re-enter the numbers(minimum 5) with comma seperated");
                    continue;
                }
                Array.Sort(numbers);
                
                Console.WriteLine($"The three smallest nos the list are: {numbers[0]},{numbers[1]},{numbers[2]}");
                break;  
            }
        }
    }
}
