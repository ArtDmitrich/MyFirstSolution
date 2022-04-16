namespace Lesson15Library.Models
{
    public class SearchEngine
    {        
        private FileInfo FindFileInDirectory(DirectoryInfo dirInfo, string fileName)
        {
            var files = dirInfo.GetFiles(fileName);
            
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    return file;
                }
            }
            return null;
        }
        public FileInfo FindFile (string path, string fileName)
        {
            var dirInfo = new DirectoryInfo(path);
            var result = FindFileInDirectory(dirInfo, fileName);
            if(result != null)
            {
                return result;
            }

            var folders = dirInfo.GetDirectories();
            if (folders != null)
            {
                foreach (var folder in folders)
                {                    
                    result = FindFile(folder.FullName, fileName);                    
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
            return null;
        }
    }
}
