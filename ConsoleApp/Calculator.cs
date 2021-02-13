namespace ConsoleApp
{
    public class Calculator:IApplicationController
    {
        public string ApplicationName { get; set; }

        public Calculator(dynamic name)
        {
            ApplicationName = name.ToString();
        }
        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void Pause()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}