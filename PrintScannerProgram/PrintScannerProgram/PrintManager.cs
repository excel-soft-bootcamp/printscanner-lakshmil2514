using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram
{
    public class PrintManager : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print In Action");
        }
    }
}
