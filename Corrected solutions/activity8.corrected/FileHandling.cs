using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CSharp.Activity.Collections;


namespace CSharp.Activity.CoreUtilities
{
    //public class FileHandling
    //{

    //    public static void Writefile(string fileName)
    //    {
    //        FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

    //        if (fs.CanWrite)
    //        {
    //            byte[] buffer = Encoding.ASCII.GetBytes("testing method text");

    //            fs.Write(buffer, 0, buffer.Length);
    //        }

    //        fs.Close();
    //    }

    //    public static void ReadFile(string fileName)
    //    {
    //        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

    //        if (fs.CanRead)
    //        {
    //            byte[] buffer = new byte[fs.Length];

    //            int bytesRead = fs.Read(buffer, 0, buffer.Length);

    //            Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, bytesRead));
    //        }

    //        fs.Close();
    //    }



    //}


    public class FileHandling
    {
        private string filePath;
        public FileHandling(string filepath)
        {
            this.filePath = filepath;
        }
        public void WriteToDisk(string content)
        {
            File.WriteAllText(this.filePath, content);
        }

        public string ReadFromDisk()
        {
            return File.ReadAllText(filePath);
        }

    }
}
