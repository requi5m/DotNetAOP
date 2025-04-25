
using AspectInjector.Broker;
using System;

namespace DotNetAOP_Tutorial
{
    [Aspect(Scope.PerInstance)]
    [Injection(typeof(LogAspect))]
    public class LogAspect : Attribute
    {
        [Advice(Kind.Before, Target = Target.Method)]
        public void OnEnter([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"[LOG] Methoda girildi: {name}");
        }

        [Advice(Kind.After, Target = Target.Method)]
        public void OnExit([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"[LOG] Methoddan çıkıldı: {name}");
        }
    }
}
