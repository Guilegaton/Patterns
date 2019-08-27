using Patterns._02._Creational.Builder.Models;

namespace Patterns._02._Creational.Builder.Builders
{
    public class AddressBuilder : PostOfficeBuilder
    {
        #region Protected Fields

        private Address address = new Address();

        #endregion Protected Fields

        #region Public Methods

        public static implicit operator Address(AddressBuilder addressBuilder)
        {
            return addressBuilder.address;
        }

        public AddressBuilder WithCity(string city)
        {
            address.City = city;
            return this;
        }

        public AddressBuilder WithCountry(string country)
        {
            address.Country = country;
            return this;
        }

        public AddressBuilder WithHouse(string house)
        {
            address.House = house;
            return this;
        }

        public AddressBuilder WithStreet(string street)
        {
            address.Street = street;
            return this;
        }
        #endregion Public Methods
    }
}