namespace InheritanceAndAssociation
{
    public class VirtualTest 
    {
        public virtual void run() 
        {
            System.Console.WriteLine("Someone is runnig in Virtual Test Class");
        }

        public void sleep() 
        {
            System.Console.WriteLine("Someone is sleeping in VirtualTest Class");
        }
    }

    public class DerivedClass1 : VirtualTest 
    {
        public override void run()
        {
            System.Console.WriteLine("Someone is runnig in DerivedClass1 Test Class");
        }

        public void sleep()
        {
            System.Console.WriteLine("Someone is sleeping in DerivedClass1 Class");
        }

    }
}
