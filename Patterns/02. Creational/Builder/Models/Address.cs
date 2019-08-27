using System.Linq;

namespace Patterns._02._Creational.Builder.Models
{
    public class Address
    {
        #region Public Properties

        public string City { get; set; }
        public string Country { get; set; }
        public string House { get; set; }
        public string Street { get; set; }

        #endregion Public Properties

        public override string ToString()
        {
            var arr = new string[] {
                Country,
                City,
                Street,
                House
            };
            return arr.Where(str => !string.IsNullOrEmpty(str))
                      .Aggregate((cur,next) => $"{cur}, {next}");
        }
    }
}