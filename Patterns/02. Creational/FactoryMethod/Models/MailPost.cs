using System;

namespace Patterns._02._Creational.FactoryMethod.Models
{
    public class MailPost : PostProduct
    {
        #region Public Properties

        public string PostMarks { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override void Deliver()
        {
            Console.WriteLine("New Mail!");
            Console.WriteLine($"From: {From}");
            Console.WriteLine($"To: {To}");
            Console.WriteLine($"Postmarks: {PostMarks}");
        }

        #endregion Public Methods
    }
}