namespace InheritanceAndAssociation
{
    public class Installer 
    {
        //concept of compition
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install() 
        {
            _logger.Log("Installing bah blah blah");
        }
    }
}
