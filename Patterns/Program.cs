using Patterns._02._Creational.Builder;
using Patterns._02._Creational.FactoryMethod;
using Patterns._02._Creational.Prototype;
using Patterns._02._Creational.Singleton;
using Patterns._03._Structur.Adapter;
using Patterns.Creational.AbstractFactory;
using Patterns.Interfaces;

namespace Patterns
{
    internal class Program
    {
        #region Private Properties

        private static IExampleService exampleService { get; set; }

        #endregion Private Properties

        #region Private Methods

        private static void DefineExampleService()
        {
            exampleService = new AdapterProcess(); //new SingletonProcess();//new PrototypeProcess();//new FactoryMethodProcess(); //new BuilderProcess(); //new FactoryProcess();
        }

        private static void Main(string[] args)
        {
            DefineExampleService();
            exampleService.StartExample();
        }

        #endregion Private Methods
    }
}