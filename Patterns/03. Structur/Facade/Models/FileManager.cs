using System;

namespace Patterns._03._Structur.Facade.Models
{
    public class FileManager
    {
        #region Public Constructors

        public FileManager(string fileName)
        {
            FileName = fileName;
        }

        #endregion Public Constructors

        #region Public Properties

        public string FileName { get; private set; }

        #endregion Public Properties

        #region Public Methods

        public void CheckFileAvailability()
        {
            Console.WriteLine($"{FileName} file is available");
        }

        public void CloseFile()
        {
            Console.WriteLine($"{FileName} is closed");
        }

        public void OpenFile()
        {
            Console.WriteLine($"{FileName} is open");
        }

        public void ReadFile()
        {
            Console.WriteLine($"{FileName} is read");
        }

        public void WriteToFile()
        {
            Console.WriteLine($"Wrote to {FileName}");
        }

        #endregion Public Methods
    }
}