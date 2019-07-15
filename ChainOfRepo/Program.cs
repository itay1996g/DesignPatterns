using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerHandler fatalLogger = new FatalHandler();
            LoggerHandler errorLogger = new ErrorHandler();
            LoggerHandler infoLogger = new InfoHandler();
            LoggerHandler debugLogger = new DebugHandler();

            LoggerHandler chainRoot = fatalLogger;
            fatalLogger.SetNext(errorLogger);
            errorLogger.SetNext(infoLogger);
            infoLogger.SetNext(debugLogger);

            chainRoot.Handle("Fatal error occured!", 1);
            chainRoot.Handle("Error occured!", 2);
            chainRoot.Handle("Info occured!", 3);
            chainRoot.Handle("Debug occured!", 4);

            Console.WriteLine();
            Console.WriteLine("[*] Log Messages -->  ");
            chainRoot.Read();

            Console.WriteLine();
            Console.WriteLine("Now in reverse");

            LoggerHandler fatalLogger2 = new FatalHandler();
            LoggerHandler errorLogger2 = new ErrorHandler();
            LoggerHandler infoLogger2 = new InfoHandler();
            LoggerHandler debugLogger2 = new DebugHandler();
            LoggerHandler chainRoot2 = debugLogger2;

            debugLogger2.SetNext(infoLogger2);
            infoLogger2.SetNext(errorLogger2);
            errorLogger2.SetNext(fatalLogger2);

            chainRoot2.Handle("Debug occured!", 4);
            chainRoot2.Handle("Info occured!", 3);
            chainRoot2.Handle("Error occured!", 2);
            chainRoot2.Handle("Fatal error occured!", 1);
            
            


        }
    }
}
