using Patterns._03._Structur.Decorator.Interfaces;
using System;

namespace Patterns._03._Structur.Decorator.Models
{
    public class PostProcessingSenderDecorator
    {
        #region Public Properties

        public string Address => _sender.Address;
        public string NameOfSendedObject => _sender.NameOfSendedObject;
        public string Reciever => _sender.Reciever;

        #endregion Public Properties

        #region Private Fields

        private IPostSender _sender;

        #endregion Private Fields

        #region Public Constructors

        public PostProcessingSenderDecorator(IPostSender sender)
        {
            _sender = sender;
        }

        #endregion Public Constructors

        #region Public Methods

        public void Process()
        {
            Console.WriteLine($"{_sender.NameOfSendedObject} is processed");
        }

        public void Send()
        {
            _sender.Send();
        }

        #endregion Public Methods
    }
}