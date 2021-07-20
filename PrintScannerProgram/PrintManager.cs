using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram
{
    public class PrintManager
    {
        public void PrintDocument(IPrinter printer)
        {
            printer.Print();
        }
    }
}
