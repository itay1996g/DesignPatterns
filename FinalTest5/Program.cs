using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest5
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerHandler fatalLogger = new FatalHandler();
            LoggerHandler errorLogger = new ErrorHandler();
            LoggerHandler infoLogger = new InfoHandler();

            LoggerHandler chainRoot = fatalLogger;
            fatalLogger.SetNext(errorLogger);
            errorLogger.SetNext(infoLogger);

            chainRoot.Handle("Fatal error occured!", 1);
            chainRoot.Handle("Error occured!", 2);
            chainRoot.Handle("Info occured!", 3);

            Console.WriteLine();
            Console.WriteLine("[*] Log Messages -->  ");
            chainRoot.Read();

        }
    }
}
