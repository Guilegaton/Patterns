using Patterns._02._Creational.Builder.Models;

namespace Patterns._02._Creational.Builder.Builders
{
    public class AddressantBuilder : MailBuilder
    {
        #region Protected Fields

        protected Addressant addressant = new Addressant();

        #endregion Protected Fields

        #region Public Methods

        public static implicit operator Addressant(AddressantBuilder addressantBuilder)
        {
            return addressantBuilder.addressant;
        }

        public AddressantBuilder WithPerson(Person person)
        {
            addressant.Person = person;
            return this;
        }

        public AddressantBuilder WithPostOffice(PostOffice postOffice)
        {
            addressant.PostOffice = postOffice;
            return this;
        }

        #endregion Public Methods
    }
}