using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TextReader
{
    public class Statistics
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
                while (words[i].Length > 0 && !char.IsLetter(words[i][0]))
                {
                    words[i] = words[i].Remove(0, 1);
                }
                while (words[i].Length > 0 && !char.IsLetter(words[i][^1]))
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
    }
}
