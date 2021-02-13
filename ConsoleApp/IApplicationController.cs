namespace ConsoleApp
{
    public interface IApplicationController
    {
        string ApplicationName { get; set; }
        void Run();
        void Pause();
        void Stop();
    }
}