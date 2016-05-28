using System;
using System.IO;

namespace Log
{
    public class Logger
    {
        private static readonly Lazy<Logger> logger = new Lazy<Logger>(() => new Logger());

        public static Logger Instance { get { return logger.Value; } }

        private Logger()
        {

        }
        private string fileName = "Log.txt";

        public void Info(string msg)
        {
            File.AppendAllText(fileName, "Info: " + msg + " " + DateTime.Now + "\n");

            Console.WriteLine("Info: " + msg + " " + DateTime.Now + "\n");
        }

        public void Debug(string msg)
        {
            File.AppendAllText(fileName, "Debug: " + msg + " " + DateTime.Now + "\n");

            Console.WriteLine("Debug: " + msg + " " + DateTime.Now + "\n");
        }

        public void Warning(string msg)
        {
            File.AppendAllText(fileName, "Warning: " + msg + " " + DateTime.Now + "\n");

            Console.WriteLine("Warning: " + msg + " " + DateTime.Now + "\n");
        }

        public void Error(string msg)
        {
            File.AppendAllText(fileName, "Error: " + msg + " " + DateTime.Now + "\n");

            Console.WriteLine("Error: " + msg + " " + DateTime.Now + "\n");
        }
    }
}
