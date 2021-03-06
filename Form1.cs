using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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
            if (matchCollection.Count != 0)
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
        /// Q4 小數點移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Q4_Click(object sender, EventArgs e)
        {
            string content;
            string path = @"\Personal-Work-Space\C# Project\regular_expressions_practice\Q4.htm";

            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                content = streamReader.ReadToEnd();
            }
            MatchCollection matchCollection1 = Regex.Matches(content, @"<h4>.*<\/h4>");
            MatchCollection matchCollection2 = Regex.Matches(content, @"<div[^>]*?><p>.*<\/p><\/div>");

            rTB_Q4.Text = string.Empty;
            for (int i = 0; i < matchCollection1.Count; i++)
            {
                rTB_Q4.Text += $"{Regex.Replace(Regex.Replace(Regex.Replace(matchCollection1[i].ToString(), @"<h4>", string.Empty), @"<\/h4>", string.Empty), @"&nbsp;", " ").ToString()}" +
                    $"{Environment.NewLine}" +
                    $"{Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(matchCollection2[i + 1].ToString(), @"<div[^>]*?><p>", string.Empty), @"<\/p><\/div>", string.Empty), @"&nbsp;", " "), @",", string.Empty).ToString()}" +
                    $"{Environment.NewLine}";
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
                //建立DataTable
                DataTable dataTable = new DataTable("Q5_Data");

                //整理欄位 (還須修改)
                MatchCollection matchCollection_title = Regex.Matches(content, @"<th[^>]*?>(.*)<\/th>");
                string[] column = Regex.Replace(Regex.Replace(matchCollection_title[0].ToString(), @"<th[^>]*?>", " "), @"<\/th>", " ").Split(' ');

                foreach (var item in column)
                {
                    dataTable.Columns.Add(item);
                }

                ///內容整理 (還須修改)
                MatchCollection matchCollection_content = Regex.Matches(content, @"<td[^>]*?>[^<]*<\/td>");

                for (int i = 0; i < (matchCollection_content.Count) / 17; i++)
                {
                    List<string> content_list = new List<string>();
                    for (int j = 0; j < 17; j++)
                    {
                        content_list.Add(Regex.Replace(Regex.Replace(Regex.Replace(matchCollection_content[i * 17 + j].ToString(), @"<td[^>]*?>", string.Empty), @"<\/td>", string.Empty), @"&nbsp;", string.Empty));
                    }
                    dataTable.Rows.Add(content_list);
                }

                dGV_Q5.DataSource = dataTable;
            }
        }

        /// <summary>
        ///Q6取得所有分類
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Q6_Click(object sender, EventArgs e)
        {
            string content;
            string path = @"\Personal-Work-Space\C# Project\regular_expressions_practice\Q6.htm";

            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                content = streamReader.ReadToEnd();
            }
            MatchCollection matchCollection = Regex.Matches(content, @"<option[^>]*?>[^<]*<\/option>");
            rTB_Q4.Text = string.Empty;
            for (int i = 60; i < matchCollection.Count; i++)
            {
                rTB_Q4.Text += $"{Regex.Replace(Regex.Replace(matchCollection[i].ToString(), @"<option[^>]*?>", string.Empty), @"<\/option>", string.Empty)}{Environment.NewLine}";
            }
        }
    }
}