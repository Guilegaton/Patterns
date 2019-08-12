using Patterns.Creational.Factory_Method;
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
            exampleService = new FactoryProcess();
        }

        private static void Main(string[] args)
        {
            DefineExampleService();
            exampleService.StartExample();
        }

        #endregion Private Methods
    }
}