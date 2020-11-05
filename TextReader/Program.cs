using System;

namespace TextReader
{
    class Program
    {
        static int Main(string[] args)
        {
            bool noFile = true;
            string filePath = "";
            Statistics statistics = new Statistics();
            while ( noFile )
            {
                filePath = Console.ReadLine(); 
                if ( System.IO.File.Exists( filePath ) && System.IO.Path.GetExtension( filePath ) == "txt" )
                {
                    noFile = false;
                }
            }
            try
            {
                statistics.Load(filePath);
            }
            catch (System.IO.IOException exception)
            {
                Console.WriteLine(exception.Message);
                return -1;
            }
            return 0;
        }
    }
}
