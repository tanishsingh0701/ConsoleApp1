using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumberValidate
    {
        public static void ValidateNumber()
        {
            Console.WriteLine("Please enter the number between 1 to 10");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((number >= 1 && number <= 10) ? "Valid" : "Invalid");

        }

        public static void MaxOfTwoNumbers() 
        {
            Console.WriteLine("Please enter first number:");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please second first number:");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The max number is: "+System.Math.Max(num1,num2));

        }

        public static void ImageOrientation() 
        {
            Console.WriteLine("Please enter height of image:");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter width of image:");
            var width = Convert.ToInt32(Console.ReadLine());

            if (height > width || height == width)
            {
                Console.WriteLine("The image orientation is portrait");
            }
            else 
            {
                Console.WriteLine("The image orientation is landscape");
            }

        }

        public static void SpeedLimit() 
        {
            Console.WriteLine("Please enter speed limit:");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter speed of car:");
            var car_speed = Convert.ToInt32(Console.ReadLine());

            var difference = car_speed - limit;

            if (difference < 0)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demerit_points = 1;
                if (difference < 5)
                {
                    Console.WriteLine("The demerit points is: " + demerit_points);
                }
                else 
                {
                    demerit_points = (difference / 5) * 1;

                    if (demerit_points <= 12)
                        Console.WriteLine("The demerit point is: "+demerit_points);
                    else
                        Console.WriteLine("Licence Suspended");
                }

            }



        }
        
        public static void loopPrint() 
        {
            while (true) 
            {
                Console.WriteLine("Enter your name");
                var input = Console.ReadLine();

                if (!(string.IsNullOrWhiteSpace(input))) 
                {
                    Console.WriteLine("@ECHO: " + input);
                    continue;

                }

                break;
                    



            }
        
        }

        public static void randomPassword() 
        {
            var random_obj = new Random();
            var password=new char[10];

            for(int i = 0; i < 10; i++) 
            {
                password[i] = (char)random_obj.Next(97,122);
            }
            string pass = new string(password);
            Console.WriteLine(pass);
            
        }

        public static void DateTimeExample() 
        {
            var datetime = new DateTime(2022, 1, 10);
            var now = DateTime.Now;
            var today = DateTime.Today;

            // for getting todays date time
            Console.WriteLine("Todays date time"+now);
            Console.WriteLine("Hour: "+now.Hour);
            Console.WriteLine("Minute: "+now.Minute);
            Console.WriteLine("Second: "+now.Second);

            //To go to past date
            Console.WriteLine("Past Dates: "+now.AddDays(-2));

            //To got to future Dates
            Console.WriteLine("Future Dates: "+now.AddDays(2));

            //Long date String with week name
            Console.WriteLine("Long Date String: "+now.ToLongDateString());

            //Short Date String
            Console.WriteLine("Short Date String: "+now.ToShortDateString());

            // Long Time String
            Console.WriteLine("Long Time String: " + now.ToLongTimeString());

            //Short Time String
            Console.WriteLine("Short Time String: " + now.ToShortTimeString());

            // Date String
            Console.WriteLine("Date String: "+now.ToString("yyyy-MM-dd HH:mm:ss"));


            // for getting todays Date only
            Console.WriteLine("Todays Date: "+today);



        }

        public static void TimeSpanExample() 
        {
            // here passing hour minute and seconds
            var timeSpan = new TimeSpan(1,2,3);

            // difference of two DateTime will give timespan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(10);
            var result_time_span = end - start;
            

            Console.WriteLine("The Differencce of {0}-{1} is: {2}",end,start,result_time_span);

            //Total minutes and minutes
            Console.WriteLine("Minutes in timespan: "+timeSpan.Minutes);
            Console.WriteLine("Total Minutes in timespan: "+timeSpan.TotalMinutes);

            // timespan to string
            Console.WriteLine("Timespan to String: "+timeSpan.ToString());

            //String to timeSpan
            Console.WriteLine("String to Timespan: "+TimeSpan.Parse("23:12:14"));

            //Adding minutes in timespan as timespan is also immutable like datetime so it can't change once defined
            Console.WriteLine("Adding minutes in timespan: "+timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Substracting Seconds
            Console.WriteLine("Substracting Seconds: "+timeSpan.Subtract(TimeSpan.FromSeconds(1)));
        }

        public static void SummarisingText() 
        {
            const int max_limit= 20;
            string Text = "This is really a very very very very big String Its exceeds 20 characters";

            if (Text.Length <= max_limit)
            {
                Console.WriteLine(Text);
            }
            else 
            {
                var words = Text.Split(' ');
                var total_words = 0;
                var word_list = new List<string>();

                foreach (var word in words) 
                {
                    word_list.Add(word);
                    total_words += word.Length+1;
                    if (total_words > max_limit) 
                    {
                        break;
                    }
                }
                var summary = String.Join(" ", word_list)+"..............";
                Console.WriteLine("The Summary Text is: "+summary);
            }


        }

        public static void StringBuilderDemo() 
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");

            Console.WriteLine(builder);

        }

        public static void TextExercise1() 
        {
            Console.WriteLine("Enter numbers seperated by hyphen like 5-7-6-7-8");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var num in input.Split('-')) 
            {
                numbers.Add(Convert.ToInt32(num));
            }
            numbers.Sort();

            var isconsecutive = true;
            for (int i = 1; i < numbers.Count; i++) 
            {
                if (numbers[i] != numbers[i - 1] + 1) 
                {
                    isconsecutive = false;
                    break;
                }
            }
            var message = (isconsecutive) ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        public static void TextExercise2() 
        {
            Console.WriteLine("Please enter the numbers seperate by hyphen like 1-2-4-5-6");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) 
            {
                return;
            }
            var numbers = new List<int>();
            foreach(var num in input.Split('-')) 
            {
                numbers.Add(Convert.ToInt32(num));
            }

            var uniques_values = new List<int>();

            var is_duplicate = false;
            foreach (var num in numbers) 
            {
                if (!uniques_values.Contains(num))
                {
                    uniques_values.Add(num);
                }
                else 
                {
                    is_duplicate = true;
                    break;

                }
            }
            if (is_duplicate) 
            {
                Console.WriteLine("Duplicate values Exists");
            }
        }

        public static void TimeExecise1() 
        {
            Console.WriteLine("Please enter the time in 24 hr format like 19:00");
            var input = Console.ReadLine();

            var time = input.Split(':');
            if (time.Length != 2)
            {
                Console.WriteLine("Invalid Time");
            }
            else 
            {
                try 
                {
                    var hours = Convert.ToInt32(time[0]);
                    var minutes = Convert.ToInt32(time[1]);

                    if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 60)
                    {
                        Console.WriteLine("Ok");
                    }
                    else 
                    {
                        Console.WriteLine("Invalid Time");
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Invalid Time");
                }
            }
        }

        public static void TextExercise4() 
        {
            Console.WriteLine("Enter the words seperated by space");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) 
            {
                Console.WriteLine("Error");
                return;   
            }

                var variable_name = "";
                foreach (var word in input.Split(' ')) 
                {
                
                var PascalCaseWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variable_name += PascalCaseWord;
                }
            Console.WriteLine(variable_name);
            
            
        }

        public static void TextExercise5() 
        {
            Console.WriteLine("Please enter the word");
            var input = Console.ReadLine();

            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var vowel_count = 0;
            foreach (var word in input) 
            {
                if (vowels.Contains(word)) 
                {
                    vowel_count++;
                }
            }
            Console.WriteLine("vowel Count: "+vowel_count);
        }

        public static void ReadTextFromFile()
        {
            var path = @"C:\Users\sing13242\Downloads\notes.txt";
            //Console.WriteLine(File.ReadAllText(path));
            var text = File.ReadAllText(path);
            var words = text.Split(' ');
            Console.WriteLine("The Word Count is: "+words.Length);

        }

        public static void ReadLongestTextFromFile()
        {
            var path = @"C:\Users\sing13242\Downloads\notes.txt";
            //Console.WriteLine(File.ReadAllText(path));
            var text = File.ReadAllText(path);
            var words = text.Split(' ');

            var max_index = 0;
            var max_value = words[0];
            for (var i = 0; i < words.Length; i++) 
            {
                if (words[i].Length > max_value.Length) 
                {
                    max_value = words[i];
                    max_index = i;

                }

            }
            Console.WriteLine("The Longest Word is: " + words[max_index]);

        }
    }
}

