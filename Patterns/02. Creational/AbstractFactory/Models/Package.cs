using Patterns.Creational.AbstractFactory.Interfaces;
using System;

namespace Patterns.Creational.AbstractFactory.Models
{
    public class Package : IPostProduct
    {
        #region Public Methods

        public void Deliver()
        {
            Console.WriteLine("You have received the package.");
        }

        #endregion Public Methods
    }
}