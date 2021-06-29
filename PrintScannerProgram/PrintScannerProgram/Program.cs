using System;

namespace PrintScannerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintManager _printmanager = new PrintManager();
            ScanManager _scanmanager = new ScanManager();
            PrintScanner printScan = new PrintScanner(_printmanager, _scanmanager);
            printScan.PrintScan();
        }
    }
}
