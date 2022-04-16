using System.IO.Compression;

namespace Lesson15Library.Models
{
    public class Archiver
    {
        public string PathToLastCompressedFile { get; set; }
        public string PathToLastDecompressedFile { get; set; }

        public void CompressFile(string path)
        {
            using FileStream originalFileStream = File.Open(path, FileMode.Open);
            using FileStream compressedFileStream = File.Create(path + "ZIP");
            using var compressor = new GZipStream(compressedFileStream, CompressionMode.Compress);
            originalFileStream.CopyTo(compressor);
            PathToLastCompressedFile = compressedFileStream.Name;
        }
        public void DecompressFile(string path)
        {
            using FileStream originalFileStream = File.Open(path, FileMode.Open);
            using FileStream decompressedFileStream = File.Create(path + "ZIP");
            using var compressor = new GZipStream(decompressedFileStream, CompressionMode.Decompress);
            originalFileStream.CopyTo(compressor);
            PathToLastDecompressedFile = decompressedFileStream.Name;
        }
    }
}
