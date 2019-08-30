using Patterns._02._Creational.Singleton.Models;
using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns._02._Creational.Singleton
{
    public class SingletonProcess : IExampleService
    {
        public void StartExample()
        {
            Console.WriteLine("Default Realisation");
            var obj1 = DefaultRealisation.GetInstance();
            var obj2 = DefaultRealisation.GetInstance();
            Console.WriteLine($"Object 1: {obj1.CreatingDate}");
            Console.WriteLine($"Object 2: {obj2.CreatingDate}");
            Console.WriteLine($"Object 1 == Object 2: {obj1.Equals(obj2)}");

            Console.WriteLine("Thread safe realisation");
            (new Thread(() =>
            {
                Console.WriteLine($"Thread {ThreadSafeRealisation.GetInstatnce("Windows 10").Name}");

            })).Start();
            Console.WriteLine(ThreadSafeRealisation.GetInstatnce("Windows 8.1").Name);
            Thread.Sleep(1000);

            Console.WriteLine("Lazy realisation");
            var lObj1 = LazyRealisation.GetInstance();
            var lObj2 = LazyRealisation.GetInstance();
            Console.WriteLine($"Object 1: {lObj1.CreatingDate}");
            Console.WriteLine($"Object 2: {lObj2.CreatingDate}");
            Console.WriteLine($"Object 1 == Object 2: {lObj1.Equals(lObj2)}");
        }
    }
}
