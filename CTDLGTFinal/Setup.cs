using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGTFinal
{
    internal class Setup
    {
        public class Dict : DictionaryBase //Dictionary lưu nghĩa của từ vựng
        {
            public void Add(string Words, WordsDict.Words Meaning)
            {
                base.InnerHashtable.Add(Words, Meaning);
            }
            public bool Contains(string Words)/////////kiểm tra xem từ nhập vô có tồn tại trong từ điển không
            {
                return base.InnerHashtable.Contains(Words);
            }
            public string Item(string Words)////hàm in
            {
                if (base.InnerHashtable.Contains(Words))
                {
                    return ((WordsDict.Words)base.InnerHashtable[Words]).ToString();
                }
                else
                {
                    return "Không có từ này";
                }
            }
        }

        public class DictSyn : DictionaryBase  //Dictionary lưu đồng nghĩa của từ vựng
        {
            public void Add(string Words, WordsDict.WordsSyn Syn)
            {
                base.InnerHashtable.Add(Words, Syn);
            }
            public bool Contains(string Words)
            {
                return base.InnerHashtable.Contains(Words);
            }
            public string Item(string Words)
            {
                if (base.InnerHashtable.Contains(Words))
                {
                    return ((WordsDict.WordsSyn)base.InnerHashtable[Words]).ToString();
                }
                else
                {
                    return "Không có đồng nghĩa từ này";
                }
            }
        }

        public class DictAnt : DictionaryBase  //Dictionary lưu trái nghĩa của từ vựng
        {
            public void Add(string Words, WordsDict.WordsAnt Ant)
            {
                base.InnerHashtable.Add(Words, Ant);
            }
            public bool Contains(string Words)
            {
                return base.InnerHashtable.Contains(Words);
            }
            public string Item(string Words)
            {
                if (base.InnerHashtable.Contains(Words))
                {
                    return ((WordsDict.WordsAnt)base.InnerHashtable[Words]).ToString();
                }
                else
                {
                    return "Không có trái nghĩa từ này";
                }
            }
        }
    }
}
