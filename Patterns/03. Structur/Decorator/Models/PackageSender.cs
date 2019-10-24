using Patterns._03._Structur.Decorator.Interfaces;
using System;

namespace Patterns._03._Structur.Decorator.Models
{
    public sealed class PackageSender : IPostSender
    {
        #region Public Constructors

        public PackageSender(string address, string reciever)
        {
            Address = address;
            Reciever = reciever;
            NameOfSendedObject = "Package";
        }

        #endregion Public Constructors

        #region Public Properties

        public string Address { get; private set; }

        public string NameOfSendedObject { get; private set; }
        public string Reciever { get; private set; }

        #endregion Public Properties

        #region Public Methods

        public void Send()
        {
            Console.WriteLine($"Package is sent to {Address} for {Reciever}.");
        }

        #endregion Public Methods
    }
}