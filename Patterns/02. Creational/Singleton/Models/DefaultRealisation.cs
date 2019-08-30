using System;

namespace Patterns._02._Creational.Singleton.Models
{
    public class DefaultRealisation
    {
        #region Private Fields

        private static DefaultRealisation _instance;

        #endregion Private Fields

        #region Private Constructors

        private DefaultRealisation()
        {
            CreatingDate = DateTime.Now.ToString();
        }

        #endregion Private Constructors

        #region Public Properties

        public string CreatingDate { get; set; }

        #endregion Public Properties

        #region Public Methods

        public static DefaultRealisation GetInstance() => _instance ?? (_instance = new DefaultRealisation());

        #endregion Public Methods
    }
}