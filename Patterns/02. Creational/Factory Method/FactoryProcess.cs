using Patterns.Creational.Factory_Method.Factories;
using Patterns.Creational.Factory_Method.Interfaces;
using Patterns.Interfaces;

namespace Patterns.Creational.Factory_Method
{
    public class FactoryProcess : IExampleService
    {
        #region Private Properties

        private IPostFactory _factory { get; set; }

        #endregion Private Properties

        #region Public Methods

        public void StartExample()
        {
            _factory = new PackageFactory();
            IPostProduct product1 = _factory.CreateProduct();
            _factory = new MailFactory();
            IPostProduct product2 = _factory.CreateProduct();

            product1.Deliver();
            product2.Deliver();
        }

        #endregion Public Methods
    }
}