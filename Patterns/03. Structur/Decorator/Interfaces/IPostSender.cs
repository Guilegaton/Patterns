namespace Patterns._03._Structur.Decorator.Interfaces
{
    public interface IPostSender
    {
        #region Public Properties

        string Address { get; }
        string NameOfSendedObject { get; }
        string Reciever { get; }

        #endregion Public Properties

        #region Public Methods

        void Send();

        #endregion Public Methods
    }
}