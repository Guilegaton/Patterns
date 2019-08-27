using Patterns.Utility;

namespace Patterns._02._Creational.Builder.Models
{
    public class PostOffice
    {
        #region Public Properties

        public Address Address { get; set; }
        public string Name { get; set; }

        #endregion Public Properties

        public override string ToString()
        {
            return $@"{StringUtility.AnyContains("Name: {0}", Name)}
                        {StringUtility.AnyContains("Address: {0}", Address.ToString())}";
        }
    }
}