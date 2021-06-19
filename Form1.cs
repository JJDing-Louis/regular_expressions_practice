using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regular_expressions_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// E-mail設定規則確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Email_Test_Click(object sender, EventArgs e)
        {
            string input = txt_Email.Text;
            MatchCollection matchCollection = Regex.Matches(input, @"([a-z]*_[a-z]*)@cmoney.com.tw|([a-z]*_[a-z]*)@cmoney.asia");

            if (matchCollection != null) //解決空白輸入的問題
            {
                MessageBox.Show(matchCollection[0].ToString().Split('@')[0]);
            }
            else
            {
                MessageBox.Show("輸入錯誤，請重新輸入!");
            }
        }

        /// <summary>
        /// 身份證字號確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Identification_Test_Click(object sender, EventArgs e)
        {
            bool matchCollection = Regex.IsMatch(txt_Identification.Text, @"\A[A-Z]\d{9}$");
            if (matchCollection)
            {
                MessageBox.Show("正確");
            }
            else
            {
                MessageBox.Show("身份證字號有誤，請重新輸入!");
            }
        }

        /// <summary>
        /// 密碼設定規則確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Password_Test_Click(object sender, EventArgs e)
        {
            bool matchCollection = Regex.IsMatch(txt_Password.Text, @"\A\w{8}$");
            if (matchCollection)
            {
                MessageBox.Show("正確");
            }
            else
            {
                MessageBox.Show("密碼設定錯誤，請重新輸入!");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Q4_Click(object sender, EventArgs e)
        {
            string content;
            string path = @"D:\Personal-Work-Space\C# Project\regular_expressions_practice\Q4.htm";
            string write_path = @"D:\Personal-Work-Space\C# Project\regular_expressions_practice\ans4.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("檔案不存在!");
            }
            else
            {
                using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
                {
                    content = streamReader.ReadToEnd();
                }
                string[] line = content.Split('\n');
                using (StreamWriter streamWriter = new StreamWriter(write_path))
                {
                    foreach (string item in line)
                    {
                        streamWriter.WriteLine(item);
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Q5_Click(object sender, EventArgs e)
        {
            string content;
            string path = @"D:\Personal-Work-Space\C# Project\regular_expressions_practice\Q5.htm";
            string write_path = @"D:\Personal-Work-Space\C# Project\regular_expressions_practice\ans5.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("檔案不存在!");
            }
            else
            {
                using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
                {
                    content = streamReader.ReadToEnd();
                }
                string[] line = content.Split('\n');
                using (StreamWriter streamWriter = new StreamWriter(write_path))
                {
                    foreach (string item in line)
                    {
                        streamWriter.WriteLine(item);
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Q6_Click(object sender, EventArgs e)
        {
            string content;
            string path = @"D:\Personal-Work-Space\C# Project\regular_expressions_practice\Q6.htm";
            string write_path = @"D:\Personal-Work-Space\C# Project\regular_expressions_practice\ans6.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("檔案不存在!");
            }
            else
            {
                using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
                {
                    content = streamReader.ReadToEnd();
                }
                string[] line = content.Split('\n');
                using (StreamWriter streamWriter = new StreamWriter(write_path))
                {
                    foreach (string item in line)
                    {
                        streamWriter.WriteLine(item);
                    }
                }
            }
        }
    }
}