using Patterns._03._Structur.Decorator.Interfaces;
using System;

namespace Patterns._03._Structur.Decorator.Models
{
    public sealed class MailSender : IPostSender
    {
        #region Public Constructors

        public MailSender(string addres, string reciever)
        {
            Address = addres;
            Reciever = reciever;
            NameOfSendedObject = "Mail";
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
            Console.WriteLine($"Mail is sent to {Address} for {Reciever}");
        }

        #endregion Public Methods
    }
}