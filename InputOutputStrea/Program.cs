using System;
using InputOutputStrea;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("                >>>>>>>>>>>>>>>>>>>> WELCOME IN THE I/O STREAM <<<<<<<<<<<<<<<<<<<<<<");
        bool check=true;
        IOStreamOperation operation = new IOStreamOperation();
        while (check)
        { 
        Console.WriteLine(" Checking File is Exists or not 1\n Reading Line by Line From File 2\n Reading Text From File 3\n");
            Console.WriteLine("$$$$$$$$$$$$$ Enter the Above Option $$$$$$$$$$$$$");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            { 
                case 1:
                    operation.FileExists();
                break;
                case 0:
                    check=false;
                    break;
                case 2:
                   operation.ReadAllLines();
                    break;
                case 3:
                    operation.ReadAllText();
                    break;
                default:
                    Console.WriteLine("Enter the Valid Number to Perform the Specific Operation");
                    break;
            }
        }
        operation.FileExists();
    }
}
