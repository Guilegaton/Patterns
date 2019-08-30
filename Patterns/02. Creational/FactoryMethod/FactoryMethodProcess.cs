using Patterns._02._Creational.FactoryMethod.Factories;
using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns._02._Creational.FactoryMethod
{
    public class FactoryMethodProcess : IExampleService
    {
        public void StartExample()
        {
            var mailFactory = new MailFactory();
            var mail = mailFactory.CreateProduct("Hilda Ultz", "Jeff Corvin");
            mail.Deliver();
            var packageFactory = new PackageFactory();
            var package = packageFactory.CreateProduct("Rendom Amb", "Merl Corvin");
            package.Deliver();
        }
    }
}
