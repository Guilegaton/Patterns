using Patterns.Utility;
using System;

namespace Patterns._02._Creational.Prototype.Models
{
    [Serializable]
    public class Mail
    {
        #region Public Properties

        public Address Address { get; set; }
        public Addressant From { get; set; }
        public Addressant To { get; set; }

        #endregion Public Properties

        public override string ToString()
        {
            return$@"New Mail!
                     
                     {StringUtility.AnyContains(@"Address: 
                     {0}", Address.ToString())}
                     
                     {StringUtility.AnyContains(@"From:
                     {0}", From.ToString())}
                     
                     {StringUtility.AnyContains(@"To:
                     {0}", To.ToString())}";
        }
    }
}