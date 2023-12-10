using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTDLGTFinal
{
    public partial class Form1 : Form
    {
        private AllDict allDict;
        public Form1()
        {
            InitializeComponent();
            allDict = new AllDict();
            allDict.dict.Clear();
            allDict.dictsyn.Clear();
            allDict.dictant.Clear();
            allDict.LoadDataFromFile(@"D:\Bài tập để nộp\dictfinal.txt");
            allDict.LoadDataFromFileMean(@"D:\Bài tập để nộp\dictfinal.txt");
            allDict.LoadDataFromFileSyn(@"D:\Bài tập để nộp\dictfinal.txt");
            allDict.LoadDataFromFileAnt(@"D:\Bài tập để nộp\dictfinal.txt");
            comboBox1.Items.Clear();
            List<string> words = new List<string>();
            words.Add("- Chào mừng đến với nhóm 3");
            foreach (string a in allDict.listdict)
            {
                words.Add(a);
            }
            comboBox1.DataSource = words;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            richTextBox1.Text = allDict.SearchWord(comboBox1.Text);
        }

        private void Meaning_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            richTextBox1.Text = allDict.SearchWord(comboBox1.Text);
        }

        private void Syn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            richTextBox1.Text = allDict.SearchWordSyn(comboBox1.Text);
        }

        private void Ant_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            richTextBox1.Text = allDict.SearchWordAnt(comboBox1.Text);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                string word = richTextBox1.Text;
                string worddict = comboBox1.Text;
                bool exists = allDict.mylist.Contains(word);
                bool existsdict = allDict.dict.Contains(worddict);
                if (!exists && existsdict)
                {
                    allDict.mylist.Add(richTextBox1.Text);
                    MessageBox.Show("Đã thêm từ vào danh sách!");
                }
                else
                {
                    MessageBox.Show("Từ này đã tồn tại trong danh sách hoặc không có nghĩa!");
                }
            }
        }

        private void MyDict_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            foreach (var pair in allDict.mylist)
            {
                richTextBox1.Text += pair + Environment.NewLine;
            }
        }
    }
}
