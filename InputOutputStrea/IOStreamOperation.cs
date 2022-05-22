using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputStrea
{
    public class IOStreamOperation
    {
        string filePath =@"D:\InputOutputProblem\InputOutPutStream\InputOutputStrea\ContentsFile.txt";
        string copyFile = @"D:\InputOutputProblem\InputOutPutStream\InputOutputStrea\CopiedContents.txt";
        public void FileExists()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File is Exists");
                return;
            }
            File.Create(filePath);
        }
        public void ReadAllLines()
        {
            string[] array = File.ReadAllLines(filePath);
            foreach (string line in array)
            {
                Console.WriteLine("All lines are:->" + line);
            }
        }
        public void ReadAllText()
        {
            string text = File.ReadAllText(filePath);
            Console.WriteLine("Text are Presen in the File:->" + text);
        }
        public void CopyFile()
        {
            File.Copy(filePath, copyFile);
        }
        public void DeleteFile()
        {
            File.Delete(copyFile);
        }
    }
}
