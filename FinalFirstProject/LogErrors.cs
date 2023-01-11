using System;
using System.IO;
using System.Text;

namespace FinalFirstProject;

public class LogErrors
{
    public static void ErrorFileRead(string readError, string exeptionError)
    {
        using (FileStream fileStream = new FileStream(readError, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            
            byte[] writeText = Encoding.Default.GetBytes(exeptionError);
            
            
            fileStream.Write(writeText, 0, writeText.Length);
            Console.WriteLine("Информация записана!");
        }
    }
}