using Patterns._03._Structur.Facade.Models;
using Patterns.Interfaces;

namespace Patterns._03._Structur.Facade
{
    public class FacadeProcess : IExampleService
    {
        #region Public Methods

        public void StartExample()
        {
            var facade = new FileFacade("Sample.txt");
            facade.ReadFromFile();
            facade.WriteToFile();
        }

        #endregion Public Methods
    }
}