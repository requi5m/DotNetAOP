
namespace DotNetAOP_Tutorial
{
    public class TestService
    {
        [LogAspect]
        public void PrintMessage(string message)
        {
            Console.WriteLine($"Mesaj: {message}");
        }
    }
}
