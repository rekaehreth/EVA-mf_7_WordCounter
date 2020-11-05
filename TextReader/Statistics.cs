using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TextReader
{
    class Statistics
    {
        public string FileContent { get; private set; }     // auto property, private variable is automatically generated, can only be accessed by the property
        public Dictionary<string, int> WordCount { get; private set; }
        public Statistics()
        {
            WordCount = new Dictionary<string, int>();
        }
        public void Load(string filePath)
        {
            FileContent = System.IO.File.ReadAllText(filePath);
        }
        public void CountWords()
        {
            string[] words = FileContent.Split();
            words = words.Where(s => s.Length > 0).ToArray();
            for(int i = 0; i < words.Length; ++i)
            {
                while (words[i].Length > 0 && !Char.IsLetter(words[i][0]))
                {
                    words[i] = words[i].Remove(0, 1);
                }
                while (words[i].Length > 0 && !Char.IsLetter(words[i][-1]))
                {
                    words[i] = words[i].Remove(words[i].Length - 1, 1);
                }
                if (String.IsNullOrEmpty(words[i])) continue;
                words[i] = words[i].ToLower();
                if (WordCount.ContainsKey(words[i])) 
                    ++WordCount[words[i]];
                else 
                    WordCount.Add(words[i], 1);
            }
        }

        // A Main-ben ezután hívjuk meg CountWords függvényt. 
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
    }
}
