using Newtonsoft.Json;
using System.IO;

namespace Patterns._03._Structur.Adapter
{
    public class JsonToXmlAdapter
    {
        #region Public Fields

        public const string _xmlPath = "tempXmlFile";

        #endregion Public Fields

        #region Public Constructors

        public JsonToXmlAdapter(string pathToJsonFile)
        {
            _pathToJsonFile = pathToJsonFile;
        }

        #endregion Public Constructors

        #region Private Properties

        private string _pathToJsonFile { get; set; }

        #endregion Private Properties

        #region Public Methods

        public void PrintXml()
        {
            var jsonText = File.ReadAllText(_pathToJsonFile);
            var jsonObj = JsonConvert.DeserializeXmlNode(jsonText);
            jsonObj.Save(_xmlPath);
            var xmlService = new XmlProcessService(_xmlPath);
            xmlService.Print();
            File.Delete(_xmlPath);
        }

        #endregion Public Methods
    }
}