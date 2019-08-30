using System;

namespace Patterns._02._Creational.FactoryMethod.Models
{
    public class PackagePost : PostProduct
    {
        #region Public Properties

        public string BoxType { get; set; }
        public string Weight { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override void Deliver()
        {
            Console.WriteLine("New Package!");
            Console.WriteLine($"From: {From}");
            Console.WriteLine($"To: {To}");
            Console.WriteLine($"Box type: {BoxType}");
            Console.WriteLine($"Weight: {Weight}");
        }

        #endregion Public Methods
    }
}