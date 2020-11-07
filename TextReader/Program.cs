using System;
using System.Linq;

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
            statistics.CountWords();
            var pairs = statistics.WordCount.OrderByDescending(p => p.Value);
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            return 0;
        }
    }
}

// A Dictionary egy rendezetlen típus, ezért a kiírás elott rendeznünk kell az adatokat az elofordulások száma szerint. 
// Rendezzük az értékek szerint WordCount-ot az OrderByDescending() metódussal, amelynek a rendezés feltételét egy lambdakifejezésként
// adjuk át, majd az eredmény IEnumerable-t mentsük el egy lokális változóba.
// A rendezést LINQ lekérdezéssel, többféle szintaxissal is végezhetjük.

//1) Method Syntax:
//var pairs = statistics.WordCount.OrderByDescending(p => p.Value);

//2) Query Syntax:
//var pairs = from pair in WordCount
//            orderby pair.Value descending
//            select pair;

//A két módszer ugyanazt az eredményt adja. Ezután a pairs-en végigiterálhatunk
//egy foreach ciklussal, hogy kiírjuk a kulcs-érték párokat.

//foreach (var pair in pairs)
//{
//    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
//}
