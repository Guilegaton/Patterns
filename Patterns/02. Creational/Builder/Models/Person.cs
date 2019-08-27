using System.Linq;

namespace Patterns._02._Creational.Builder.Models
{
    public class Person
    {
        #region Public Properties

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }

        #endregion Public Properties

        public override string ToString()
        {
            var arr = new string[]
            {
                FirstName,
                SecondName,
                Surname
            };

            return arr.Where(str => !string.IsNullOrEmpty(str))
                      .Aggregate((cur, next) => $"{cur} {next}");
        }
    }
}