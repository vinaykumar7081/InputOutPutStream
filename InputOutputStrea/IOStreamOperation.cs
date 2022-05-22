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
        public void FileExists()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File is Exists");
                return;
            }
            File.Create(filePath);
        }
    }
}
