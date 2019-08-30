namespace Patterns._02._Creational.Singleton.Models
{
    public class ThreadSafeRealisation
    {
        #region Private Fields

        private static object _syncRoot = new object();

        #endregion Private Fields

        #region Private Constructors

        private ThreadSafeRealisation()
        {
        }

        #endregion Private Constructors

        #region Public Properties

        public string Name { get; set; }

        #endregion Public Properties

        #region Private Properties

        private static ThreadSafeRealisation _instance { get; set; }

        #endregion Private Properties

        #region Public Methods

        public static ThreadSafeRealisation GetInstatnce(string name)
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeRealisation
                        {
                            Name = name
                        };
                    }
                }
            }

            return _instance;
        }

        #endregion Public Methods
    }
}