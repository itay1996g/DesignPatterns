using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    class Singleton
    {
        private static Singleton INSTANCE;

        private static object key = new object();

        protected Singleton()
        {
        }

        public void printTime()
        {
            Console.WriteLine(DateTime.Now);
        }

        public static Singleton Create()
        {
            if (INSTANCE == null)
            {
                lock (key)
                {
                    if (INSTANCE == null)
                        INSTANCE = new Singleton();
                }
            }

            return INSTANCE;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Create();
            Singleton s2 = Singleton.Create();
            Singleton s3 = Singleton.Create();

            s1.printTime();
            s2.printTime();
            s3.printTime();

        }
    }
}
