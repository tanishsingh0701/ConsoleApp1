using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            // Second way to create an object of class and initialising variabe without writing in contructor is "Object Initiaizers Syntax"

            var customer2 = new Customer
            {
                Id = 1,
                Name="Tanish2"

            };
            customer.Id = 1;
            customer.Name = "Tanish";

            var orders = new Order();
            customer.Orders.Add(orders);

            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            var person = new Person(new DateTime(1996, 01, 07));
            //person.Birthdate = new DateTime(1996, 01, 07);
            // now make set as private so that data will set from constructor only once
            //Console.WriteLine(person.age);

            var cookie = new HttpCookie();
            cookie["name"] = "Tanish";
            //Console.WriteLine(cookie["name"]);

            //var stackOverFlow = new StackOverflow("Safety", "Post related to safety", DateTime.Today);
            //stackOverFlow.UpVote();
            //stackOverFlow.UpVote();
            //stackOverFlow.UpVote();
            //stackOverFlow.UpVote();
            //stackOverFlow.DownVote();

            //Console.WriteLine(stackOverFlow.GetVote); 

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.GetDuration());
            

        }
    }
}
