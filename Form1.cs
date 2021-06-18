using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btn_Identification_Test_Click(object sender, EventArgs e)
        {
            string ans = lbl_Identification.Text;

        }

        private void btn_Password_Test_Click(object sender, EventArgs e)
        {
            string ans = lbl_Password.Text;
        }

        private void btn_Email_Test_Click(object sender, EventArgs e)
        {
            string ans = lbl_Email.Text;
        }
    }
}