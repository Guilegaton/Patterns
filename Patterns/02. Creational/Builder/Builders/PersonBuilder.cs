using Patterns._02._Creational.Builder.Models;

namespace Patterns._02._Creational.Builder.Builders
{
    public class PersonBuilder : AddressantBuilder
    {
        #region Protected Fields

        protected Person person = new Person();

        #endregion Protected Fields

        #region Public Methods

        public static implicit operator Person(PersonBuilder personBuilder)
        {
            return personBuilder.person;
        }

        public PersonBuilder WithFirstName(string firstName)
        {
            person.FirstName = firstName;
            return this;
        }

        public PersonBuilder WithSecondName(string seconName)
        {
            person.SecondName = seconName;
            return this;
        }

        public PersonBuilder WithSurname(string surname)
        {
            person.Surname = surname;
            return this;
        }

        #endregion Public Methods
    }
}