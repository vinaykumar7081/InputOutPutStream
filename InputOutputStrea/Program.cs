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
        Console.WriteLine(" Checking File is Exists or not 1\n");
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
                    default:
                    Console.WriteLine("Enter the Valid Number to Perform the Specific Operation");
                    break;
            }
        }
        operation.FileExists();
    }
}
