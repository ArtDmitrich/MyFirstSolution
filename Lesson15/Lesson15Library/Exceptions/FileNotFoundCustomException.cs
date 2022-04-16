using System.Runtime.Serialization;

namespace Lesson15Library.Exceptions
{
    [Serializable]
    public class FileNotFoundCustomException : SystemException
    {
        private string fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
        }
        public FileNotFoundCustomException() : base()
        {
        }
        public FileNotFoundCustomException(string value) :
            base(String.Format($"файл с названием {value} не найден"))
        {
            fileName = value;
        }
        public FileNotFoundCustomException(string value, string message) : base(message)
        {
            fileName = value;

        }
        public FileNotFoundCustomException(string value, string message, SystemException inner) : base(message, inner)
        {
            fileName = value;

        }
        protected FileNotFoundCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
