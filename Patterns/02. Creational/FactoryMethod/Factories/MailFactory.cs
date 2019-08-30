using Patterns._02._Creational.FactoryMethod.Models;

namespace Patterns._02._Creational.FactoryMethod.Factories
{
    public class MailFactory : PostProductFactory
    {
        #region Public Methods

        public override PostProduct CreateProduct(string from, string to)
        {
            return new MailPost
            {
                From = from,
                To = to,
                PostMarks = "some postmarks"
            };
        }

        #endregion Public Methods
    }
}