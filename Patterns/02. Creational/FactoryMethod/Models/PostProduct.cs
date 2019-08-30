using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns._02._Creational.FactoryMethod.Models
{
    public class PostProduct
    {
        public string From { get; set; }
        public string To { get; set; }

        public virtual void Deliver()
        {
            Console.WriteLine("New post product!");
            Console.WriteLine($"From: {From}");
            Console.WriteLine($"To: {To}");
        }
    }
}
