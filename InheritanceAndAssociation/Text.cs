namespace InheritanceAndAssociation
{
    partial class Program
    {
        public class Text : PresentationObject 
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }

            public void AddHyperlink(string url) 
            {
                System.Console.WriteLine("we added a link to "+url);
            }
        }
    }
}
