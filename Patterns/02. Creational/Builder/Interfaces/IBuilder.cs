namespace Patterns._02._Creational.Builder.Interfaces
{
    public interface IPostBuilder<T>
    {
        #region Public Methods

        IPostBuilder<T> BuildAddress(string address);

        IPostBuilder<T> BuildDetails();

        IPostBuilder<T> BuildPostmarks();

        void Reset();

        T GetResult();

        #endregion Public Methods
    }
}