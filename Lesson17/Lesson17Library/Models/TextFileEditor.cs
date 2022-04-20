using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17Library.Models
{
    public class TextFileEditor
    {
        Mutex mutex = new Mutex();
        public string PathToFileToWrite { get; set; }

        public void WriteTextToFile(string text, string path)
        {
            mutex.WaitOne();
            using (var stremWriter = new StreamWriter(path, true))
            {
                stremWriter.WriteLine(text);
            }
            mutex.ReleaseMutex();
        }
        public string ReadTextFromFile(string path)
        {
            using (var streamReader = new StreamReader(path))
            {                
                return streamReader.ReadToEnd();
            }            
        }
        public void ReadAndWriteForTask(object path)
        {
            WriteTextToFile(ReadTextFromFile((string)path), PathToFileToWrite);
        }
    }
}
