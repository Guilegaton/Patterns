using Patterns._02._Creational.Prototype.Models;
using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns._02._Creational.Prototype
{
    public class PrototypeProcess : IExampleService
    {
        public void StartExample()
        {
            var mail1 = new Mail
            {
                Address = new Address
                {
                    City = "Boston",
                    Country = "USA",
                    Street = "Some Street1",
                    House = "222"
                },
                From = new Addressant
                {
                    Person = new Person
                    {
                        FirstName = "Hilda",
                        Surname = "Ultz"
                    },
                    PostOffice = new PostOffice
                    {
                        Name = "Post Office 1",
                        Address = new Address
                        {
                            City = "Berlin",
                            Country = "Germany",
                            Street = "Some street 2",
                            House = "3333"
                        }
                   }
               },
                To = new Addressant
                {
                    Person = new Person
                    {
                        FirstName = "Stephany",
                        Surname = "Dola"
                    },
                    PostOffice = new PostOffice
                    {
                        Name = "Post Office 2",
                        Address = new Address
                        {
                            City = "Elkia",
                            Country = "Elkia Federation",
                            Street = "Some street 3",
                            House = "44"
                        }
                    }
                }
            };

            var mail2 = mail1.DeepCopy();
            mail2.To.Person.FirstName = "Fil";
            mail2.To.Person.Surname = "Nilvalen";

            Console.WriteLine(mail1.ToString());
            Console.WriteLine(mail2.ToString());
        }
    }
}
