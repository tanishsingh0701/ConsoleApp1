using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAssociation
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            //text.Copy();
            var dbmigrator = new DBMigrater(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            //dbmigrator.Migrate();
            //installer.Install();

            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            var derivedobj = new DerivedClass1();
            VirtualTest virtualTestObj = derivedobj;
            derivedobj.run();
            derivedobj.sleep();

            virtualTestObj.run();
            virtualTestObj.sleep();
        }   
    }
}
