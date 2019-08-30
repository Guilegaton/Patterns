using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patterns._02._Creational.Prototype
{
    public static class PrototypeExtention
    {
        #region Public Methods

        public static T DeepCopy<T>(this T obj)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            stream.Seek(0, SeekOrigin.Begin);
            var copy = formatter.Deserialize(stream);
            stream.Close();
            return (T)copy;
        }

        #endregion Public Methods
    }
}