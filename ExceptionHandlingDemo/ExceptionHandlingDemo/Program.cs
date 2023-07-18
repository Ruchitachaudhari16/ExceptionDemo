using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1:-TryCatch");
                Console.WriteLine("2:-Custom Exception");
                Console.WriteLine("3:Null Exception");
                Console.WriteLine("4:Index Out of Range Exception");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        HandleException handleException = new HandleException();
                        handleException.Display();
                        break;
                        case 2:
                        DivideByZero_Exception divideByZeroException = new DivideByZero_Exception();
                        divideByZeroException.Custom();
                        break;

                        case 3:
                        NullException NullException = new NullException();
                        NullException.Display();
                        break;

                        case 4:
                        IndexOutOfRangeException indexOutOfRangeException = new IndexOutOfRangeException();
                        indexOutOfRangeException.Range();
                        break;

                        Console.ReadLine();
                }
            }
        }
    }
}
