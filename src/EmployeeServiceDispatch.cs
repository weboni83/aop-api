using System;
using System.Reflection;

namespace Acme.AOP.Demo
{
    public class EmployeeServiceDispatch<T> : DispatchProxy
    {
        public T Target { get; set; }

        public static T Create<T>(T target) where T : class
        {
            var proxy = Create<T, EmployeeServiceDispatch<T>>() as EmployeeServiceDispatch<T>;
            proxy.Target = target;
            return proxy as T;
        }
        protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
        {
            Console.WriteLine("Invoke Call");
            
            return targetMethod.Invoke(Target, args);
        }
    }
}
