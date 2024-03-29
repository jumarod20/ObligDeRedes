using System;
using System.IO;

namespace Common.FileHandler
{
    public class FileStreamHandler
    {
        public static byte[] Read(string path, long offset, int length)
        {
            var data = new byte[length];

            using (var fs = new FileStream(path, FileMode.Open))
            {
                fs.Position = offset;
                var bytesRead = 0;
                while (bytesRead < length)
                {
                    var read = fs.Read(data, bytesRead, length - bytesRead);
                    if (read == 0)
                    {
                        throw new Exception("Couldn't not read file");
                    }
                    bytesRead += read;
                }
            }

            return data;
        }

        public static void Write(string fileName, byte[] data)
        {
            if (File.Exists(fileName))
            {
                using (var fs = new FileStream(fileName, FileMode.Append))
                {
                    fs.Write(data, 0, data.Length);
                }
            }
            else
            {
                using (var fs = new FileStream(fileName, FileMode.Create))
                {
                    fs.Write(data, 0, data.Length);
                }
            }
        }
    }
}