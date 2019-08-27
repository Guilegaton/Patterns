using Patterns._02._Creational.Builder.Models;

namespace Patterns._02._Creational.Builder.Builders
{
    public class PostOfficeBuilder : AddressantBuilder
    {
        #region Protected Fields

        protected PostOffice postOffice = new PostOffice();

        #endregion Protected Fields

        #region Public Methods

        public static implicit operator PostOffice(PostOfficeBuilder postOfficeBuilder)
        {
            return postOfficeBuilder.postOffice;
        }

        public new PostOfficeBuilder WithAddress(Address address)
        {
            postOffice.Address = address;
            return this;
        }

        public PostOfficeBuilder WithName(string name)
        {
            postOffice.Name = name;
            return this;
        }

        #endregion Public Methods
    }
}