using System;

namespace Patterns._02._Creational.Singleton.Models
{
    public class LazyRealisation
    {
        #region Private Fields

        private static Lazy<LazyRealisation> _lazyInstance = new Lazy<LazyRealisation>(() => new LazyRealisation());

        #endregion Private Fields

        #region Private Constructors

        private LazyRealisation()
        {
            Console.WriteLine($"Constructor time {DateTime.Now}");
            CreatingDate = DateTime.Now.ToString();
        }

        #endregion Private Constructors

        #region Public Properties

        public string CreatingDate { get; set; }

        #endregion Public Properties

        #region Public Methods

        public static LazyRealisation GetInstance()
        {
            Console.WriteLine($"Get instance {DateTime.Now}");
            return _lazyInstance.Value;
        }

        #endregion Public Methods
    }
}