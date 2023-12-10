using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGTFinal
{
    internal class WordsDict
    {
        public class Words
        {
            public string Word { get; set; }
            public string Meaning { get; set; }
            public Words(string word, string mean)
            {
                Word = word;
                Meaning = mean;
            }
            public override string ToString()
            {
                return $"{Word}" + Environment.NewLine + $"{Meaning}";
            }
        }
        public class WordsSyn
        {
            public string Word { get; set; }
            public string WordSyn { get; set; }

            public WordsSyn(string word, string wordsyn)
            {
                Word = word;
                WordSyn = wordsyn;
            }
            public override string ToString()
            {
                return $"{Word}" + Environment.NewLine + $"{WordSyn}";
            }
        }
        public class WordsAnt
        {
            public string Word { get; set; }
            public string WordAnt { get; set; }

            public WordsAnt(string word, string wordant)
            {
                Word = word;
                WordAnt = wordant;
            }
            public override string ToString()
            {
                return $"{Word}" + Environment.NewLine + $"{WordAnt}";//ký tự $ được sử dụng để tạo chuỗi nội suy (interpolated string). Khi sử dụng dấu $ cùng với dấu nháy kép ", bạn có thể nhúng biểu thức hoặc biến trực tiếp vào chuỗi một cách thuận tiện.
            }
        }
    }
}
