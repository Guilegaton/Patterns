using Patterns._02._Creational.Builder.Builders;
using Patterns._02._Creational.Builder.Models;
using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns._02._Creational.Builder
{
    public class BuilderProcess : IExampleService
    {
        public void StartExample()
        {
            Mail mail = new MailBuilder()
                .WithAddress( new AddressBuilder()
                    .WithCity("New York")
                    .WithCountry("USA")
                    .WithHouse("34")
                    .WithStreet("Brooklyn St."))
                .WithFrom( new AddressantBuilder()
                    .WithPostOffice( new PostOfficeBuilder()
                        .WithName("Post Office 1")
                        .WithAddress( new AddressBuilder()
                            .WithCountry("Germany")
                            .WithCity("Berlin")
                            .WithHouse("22e")
                            .WithStreet("Reinhardtstraße")))
                    .WithPerson( new PersonBuilder()
                        .WithFirstName("Frida")
                        .WithSurname("Ultz")))
                .WithTo( new AddressantBuilder()
                    .WithPostOffice( new PostOfficeBuilder()
                        .WithName("Post Office 2")
                        .WithAddress( new AddressBuilder()
                            .WithCountry("USA")
                            .WithCity("New York")
                            .WithHouse("15")
                            .WithStreet("Broome St.")))
                    .WithPerson( new PersonBuilder()
                        .WithFirstName("James")
                        .WithSecondName("Raph")
                        .WithSurname("Steevenson")));

            Console.WriteLine(mail.ToString());
        }
    }
}
