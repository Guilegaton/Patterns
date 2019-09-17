using System;
using System.Xml;

namespace Patterns._03._Structur.Adapter
{
    public class XmlProcessService
    {
        #region Public Constructors

        public XmlProcessService(string filePath)
        {
            _filePath = filePath;
        }

        #endregion Public Constructors

        #region Private Properties

        private string _filePath { get; set; }

        #endregion Private Properties

        #region Public Methods

        public void Print(string textBeforeXml = "")
        {
            Console.WriteLine(textBeforeXml);
            var document = new XmlDocument();
            document.Load(_filePath);
            document.Save(Console.Out);
        }

        #endregion Public Methods
    }
}