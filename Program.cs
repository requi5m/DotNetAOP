
using System;

namespace DotNetAOP_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new TestService();
            service.PrintMessage("Merhaba AOP!");
        }
    }
}
