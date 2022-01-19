using ConsoleApp1.Math;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum ShippingMethods 
    {
        RegularAirMail=1,
        RegisteredAirMai=2,
        Express=3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Data types in c#
            Integer - int var1; 4bytes
            Long- long var1; 8bytes
            floating point number- float var2 4bytes
            Double- double var2; 8bytes
            character- char a=A; 2bytes
            Boolean - bool isGreat=true; 1bit
            String - string inp="Tanish"; 2bytes

            char->int->long->float->double


            float var12=35.6;
            int a=(int) va312;
            or
            int a=Convert.ToInt32(var12);
            String name1="Hello world is here";
            Console.WriteLine(name1[0]);
            Console.WriteLine(name1.IndexOf("is"));
            Console.WriteLine(name1.SubString(5));

             */

            int var1 = 34;
            float var2 = 34.4F;
            byte num1 = 255;
            num1 += 2;
            //Console.WriteLine(num1);

            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            //john.Introduce();

            Calculator calc = new Calculator();
            //Console.WriteLine(calc.add(10,20));
            //Console.WriteLine("Hello World "+var1+", "+var2);

            //String name = Console.ReadLine();

            //String candies= Console.ReadLine();

            //Console.WriteLine($"Your name is: {name}. You will get {candies} candies");

            int[] numbers = new int[3];

            //or var numbers=new int[3];
            //object initialization syntax
            var names = new String[3] {"john","MArry","Roger"};

            foreach(var name in names)
        {
                //Console.WriteLine(name);
        }

            // varbarian String is used to get rid  of ecape characters

            string normal_string = "path is:\n c:\\system32";
            string varbarian_string = @"path is:
 c:\system32";

            //Console.WriteLine(normal_string);

            //Console.WriteLine(varbarian_string);

            //Console.WriteLine(string.Join(",",names));

            string FirstName = "Tanish";
            string LastName = "Singh";

            //Console.WriteLine(string.Format("{0} {1}",FirstName,LastName));




            // Enums
            var method = ShippingMethods.Express;

            
            //Console.WriteLine((int)method);
            var methodId = 3;
            //Console.WriteLine((ShippingMethods)methodId);

            //converting enum to String
            //Console.WriteLine(method.ToString());
            //here if we pass not use toSting thw writeline by default use to string with every value pass

            // now converting Sting to the enum
            var methodName = "Express";
            var shippingMethod=(ShippingMethods) Enum.Parse(typeof(ShippingMethods), methodName);
            //Console.WriteLine(shippingMethod);


            //conditional operator and if else

            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            //or
            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;

            //NumberValidate.ValidateNumber();
            //NumberValidate.MaxOfTwoNumbers();
            //NumberValidate.ImageOrientation();
            //NumberValidate.SpeedLimit();
            //NumberValidate.loopPrint();
            //NumberValidate.randomPassword();
            //LoopExercise.divisible_by3();
            //LoopExercise.OkNumber();
            //LoopExercise.Factorial();
            //LoopExercise.GuessNumber();
            //LoopExercise.MaxNumber();
            //ArrayPractice.ArrayDemo();
            //ArrayPractice.ListDemo();
            //ArrayPractice.ArrayExercise1();
            //ArrayPractice.ReverseName();
            //ArrayPractice.UniqueNumbers();
            //ArrayPractice.CommaSeperatedNumbers();
            //NumberValidate.DateTimeExample();
            //NumberValidate.TimeSpanExample();
            //NumberValidate.SummarisingText();
            //NumberValidate.StringBuilderDemo();
            //NumberValidate.TextExercise1();
            //NumberValidate.TextExercise2();
            //NumberValidate.TextExercise4();
            //NumberValidate.TextExercise5();
            //NumberValidate.ReadTextFromFile();
            NumberValidate.ReadLongestTextFromFile();
            //Console.ReadLine();
        }
    }

}

