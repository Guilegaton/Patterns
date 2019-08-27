using Patterns._02._Creational.Builder.Models;

namespace Patterns._02._Creational.Builder.Builders
{
    public class MailBuilder
    {
        #region Protected Fields

        protected Mail mail = new Mail();

        #endregion Protected Fields

        #region Public Methods

        public static implicit operator Mail(MailBuilder mailBuilder)
        {
            return mailBuilder.mail;
        }

        public MailBuilder WithAddress(Address address)
        {
            mail.Address = address;
            return this;
        }

        public MailBuilder WithFrom(Addressant addressant)
        {
            mail.From = addressant;
            return this;
        }

        public MailBuilder WithTo(Addressant addressant)
        {
            mail.To = addressant;
            return this;
        }

        #endregion Public Methods
    }
}