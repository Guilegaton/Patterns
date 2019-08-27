using Patterns.Creational.AbstractFactory.Interfaces;
using System;

namespace Patterns.Creational.AbstractFactory.Models
{
    public class Mail : IPostProduct
    {
        #region Public Methods

        public void Deliver()
        {
            Console.WriteLine("You have received the mail.");
        }

        #endregion Public Methods
    }
}