namespace Patterns._03._Structur.Facade.Models
{
    public class FileFacade
    {
        #region Public Constructors

        public FileFacade(string fileName)
        {
            FileName = fileName;
            _fileManager = new FileManager(FileName);
        }

        #endregion Public Constructors

        #region Public Properties

        public string FileName { get; private set; }

        #endregion Public Properties

        #region Private Properties

        private FileManager _fileManager { get; set; }

        #endregion Private Properties

        #region Public Methods

        public void ReadFromFile()
        {
            _fileManager.CheckFileAvailability();
            _fileManager.OpenFile();
            _fileManager.ReadFile();
            _fileManager.CloseFile();
        }

        public void WriteToFile()
        {
            _fileManager.CheckFileAvailability();
            _fileManager.OpenFile();
            _fileManager.WriteToFile();
            _fileManager.CloseFile();
        }

        #endregion Public Methods
    }
}