using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CTDLGTFinal.WordsDict;
using System.Windows.Forms;
using System.IO;/////////// Cung cấp các lớp cho việc đọc và ghi dữ liệu từ các luồng và tệp tin.
using System.Reflection.Emit;

namespace CTDLGTFinal
{
    /// /////////////////những cái ToUpper là để thống nhất rằng key là 1 từ vựng in hoa để khi cho dù người nhập có nhập hoa hay thường thì search vẫn ra
    internal class AllDict
    {
        public List<string> mylist = new List<string>();//list lưu trữ những từ trong từ điển để đưa vào comboBox
        /// <summary>
        /// /////////////////////////////
        /// </summary>
        public List<string> listdict = new List<string>();//list lưu trữ những từ trong từ điển để đưa vào comboBox
        public void LoadDataFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int n = 0;
                foreach (string line in lines)
                {
                    string[] parts = line.Split('-');
                    if (parts.Length == 4)////đủ 4 phần được ngăn cách bởi dấu "-" tránh trường hợp thiếu cấu trúc
                    {
                        foreach (string a in listdict)
                        {
                            if (parts[0].Trim().ToUpper() == a.ToUpper())
                            {
                                n++;
                            }
                        }
                        if (n == 0)
                        {
                            listdict.Add(parts[0].Trim().ToUpper());
                        }
                        n = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// /////////////////////////////////
        /// </summary>
        public Setup.Dict dict = new Setup.Dict();//Dictionary lưu nghĩa của từ vựng
        public void LoadDataFromFileMean(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string word in listdict)//từng từ trong danh sách từ vựng
                {
                    List<string> listmean = new List<string>();
                    StringBuilder meaningsBuilder = new StringBuilder(); // Sử dụng StringBuilder để tích luỹ các nghĩa
                    foreach (string line in lines)//từng dòng trong từ điển nhập vào
                    {
                        string[] parts = line.Split('=');
                        string[] parts1 = line.Split('#');
                        if (parts.Length == 2)//nếu cấu trúc có =
                        {
                            string[] part1 = parts[0].Split('-');////đủ 4 phần được ngăn cách bởi dấu "-" tránh trường hợp thiếu cấu trúc
                            if (part1.Length == 4)
                            {
                                if (part1[0].Trim().ToUpper() == word)
                                {
                                    string temp = string.Empty;
                                    for (int i = 1; i < part1.Length; i++)
                                    {
                                        temp += "-" + part1[i].Trim();
                                    }
                                    listmean.Add(temp);
                                }
                            }
                        }
                        else if (parts1.Length == 2)//nếu cấu trúc không có = mà có #
                        {
                            string[] part1 = parts1[0].Split('-');////đủ 4 phần được ngăn cách bởi dấu "-" tránh trường hợp thiếu cấu trúc
                            if (part1.Length == 4)
                            {
                                if (part1[0].Trim().ToUpper() == word)
                                {
                                    string temp = string.Empty;
                                    for (int i = 1; i < part1.Length; i++)
                                    {
                                        temp += "-" + part1[i].Trim();
                                    }
                                    listmean.Add(temp);
                                }
                            }
                        }
                        else//cấu trúc không có = và không có #
                        {
                            string[] part1 = line.Split('-');////đủ 4 phần được ngăn cách bởi dấu "-" tránh trường hợp thiếu cấu trúc
                            if (part1.Length == 4)
                            {
                                if (part1[0].Trim().ToUpper() == word)
                                {
                                    string temp = string.Empty;
                                    for (int i = 1; i < part1.Length; i++)
                                    {
                                        temp += "-" + part1[i].Trim();
                                    }
                                    listmean.Add(temp);
                                }
                            }
                        }
                    }
                    foreach (string mean in listmean)
                    {
                        meaningsBuilder.AppendLine(mean); //AppendLine là một phương thức của lớp StringBuilder trong C#, được sử dụng để thêm một chuỗi và một dòng mới vào StringBuilder.
                    }
                    if (meaningsBuilder.Length > 0)
                    {
                        dict.Add(word, new Words(word, meaningsBuilder.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// ////////////////////////
        /// </summary>
        public Setup.DictSyn dictsyn = new Setup.DictSyn();//Dictionary lưu đồng nghĩa của từ vựng
        public void LoadDataFromFileSyn(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string word in listdict)
                {
                    List<string> listsyn = new List<string>();
                    StringBuilder synsBuilder = new StringBuilder(); // Sử dụng StringBuilder để tích luỹ các nghĩa
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string[] part1 = parts[0].Split('-');
                            if (part1.Length == 4)
                            {
                                string[] part2 = parts[1].Split('#');
                                if (part2.Length == 2)/////////nếu còn vế #
                                {
                                    if (part1[0].Trim().ToUpper() == word)
                                    {
                                        string temp = string.Empty;
                                        temp = "." + part1[1] + "=" + part2[0];
                                        listsyn.Add(temp);
                                    }
                                }
                                else//////nếu không có vế #
                                {
                                    if (part1[0].Trim().ToUpper() == word)
                                    {
                                        string temp = string.Empty;
                                        temp = "." + part1[1] + "=" + parts[1];
                                        listsyn.Add(temp);
                                    }
                                }
                            }
                        }
                    }
                    foreach (string mean in listsyn)
                    {
                        synsBuilder.AppendLine(mean);
                    }
                    if (synsBuilder.Length > 0)
                    {
                        dictsyn.Add(word, new WordsSyn(word, synsBuilder.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// ////////////////////////////////
        /// </summary>
        public Setup.DictAnt dictant = new Setup.DictAnt();//Dictionary lưu trái nghĩa của từ vựng
        public void LoadDataFromFileAnt(string filePath)
        {
            try
            {

                string[] lines = File.ReadAllLines(filePath);
                foreach (string word in listdict)
                {
                    List<string> listant = new List<string>();
                    StringBuilder antsBuilder = new StringBuilder(); // Sử dụng StringBuilder để tích luỹ các nghĩa
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('#');
                        if (parts.Length == 2)
                        {
                            string[] part1 = line.Split('-');
                            if (part1.Length == 4)
                            {
                                if (part1[0].Trim().ToUpper() == word)
                                {
                                    string temp = string.Empty;
                                    temp = "." + part1[1] + "#" + parts[1];
                                    listant.Add(temp);
                                }
                            }
                        }
                    }
                    foreach (string mean in listant)
                    {
                        antsBuilder.AppendLine(mean);
                    }
                    if (antsBuilder.Length > 0)
                    {
                        dictant.Add(word, new WordsAnt(word, antsBuilder.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// /////////////////////////
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public string SearchWord(string userInput)
        {
            string inputKey = userInput.Trim().ToUpper();
            if (dict.Contains(inputKey))
            {
                return dict.Item(inputKey);
            }
            else
            {
                return "Không có từ này";
            }
        }
        /// <summary>
        /// //////////////////////////////////
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public string SearchWordSyn(string userInput)
        {
            string inputKey = userInput.Trim().ToUpper();
            if (dictsyn.Contains(inputKey))
            {
                return dictsyn.Item(inputKey);
            }
            else
            {
                return "Không có đồng nghĩa từ này";
            }
        }
        /// <summary>
        /// ////////////////////////////////////
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public string SearchWordAnt(string userInput)
        {
            string inputKey = userInput.Trim().ToUpper();
            if (dictant.Contains(inputKey))
            {
                return dictant.Item(inputKey);
            }
            else
            {
                return "Không có trái nghĩa từ này";
            }
        }
    }
}
