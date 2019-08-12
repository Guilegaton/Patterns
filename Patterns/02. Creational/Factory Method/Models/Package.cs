using Patterns.Creational.Factory_Method.Interfaces;
using System;

namespace Patterns.Creational.Factory_Method.Models
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