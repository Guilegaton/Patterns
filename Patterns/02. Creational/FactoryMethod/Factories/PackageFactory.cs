using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns._02._Creational.FactoryMethod.Models;

namespace Patterns._02._Creational.FactoryMethod.Factories
{
    public class PackageFactory: PostProductFactory
    {
        public override PostProduct CreateProduct(string from, string to)
        {
            return new PackagePost
            {
                From = from,
                To = to,
                BoxType = "Some box type",
                Weight = "100ft"
            };
        }
    }
}
