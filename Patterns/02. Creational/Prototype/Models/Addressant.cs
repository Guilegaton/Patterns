using Patterns.Utility;
using System;

namespace Patterns._02._Creational.Prototype.Models
{
    [Serializable]
    public class Addressant
    {
        #region Public Properties

        public Person Person { get; set; }
        public PostOffice PostOffice { get; set; }

        #endregion Public Properties

        public override string ToString()
        {
            return $@"{StringUtility.AnyContains("Person: {0}", Person.ToString())}
                     {StringUtility.AnyContains(@"Post Office: 
                        {0}", PostOffice.ToString())}";
        }
    }
}