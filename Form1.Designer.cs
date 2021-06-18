
namespace regular_expressions_practice
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.txt_Identification = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Q4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Identification_Test = new System.Windows.Forms.Button();
            this.btn_Password_Test = new System.Windows.Forms.Button();
            this.btn_Email_Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.Location = new System.Drawing.Point(10, 10);
            this.lbl_Identification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(104, 12);
            this.lbl_Identification.TabIndex = 0;
            this.lbl_Identification.Text = "請輸入身份證字號:";
            // 
            // txt_Identification
            // 
            this.txt_Identification.Location = new System.Drawing.Point(10, 37);
            this.txt_Identification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Identification.Name = "txt_Identification";
            this.txt_Identification.Size = new System.Drawing.Size(325, 22);
            this.txt_Identification.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(10, 71);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(347, 24);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "請輸入密碼:\r\n(輸入密碼必須是8個字元以上，不得為+-*/.!@#$%^&*()等特殊字元)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(10, 144);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(99, 12);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "請輸入E-mail帳號:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(10, 170);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(325, 22);
            this.txt_Email.TabIndex = 5;
            // 
            // btn_Q4
            // 
            this.btn_Q4.Location = new System.Drawing.Point(10, 205);
            this.btn_Q4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Q4.Name = "btn_Q4";
            this.btn_Q4.Size = new System.Drawing.Size(94, 18);
            this.btn_Q4.TabIndex = 6;
            this.btn_Q4.Text = "btn_Q4";
            this.btn_Q4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 18);
            this.button1.TabIndex = 7;
            this.button1.Text = "btn_Q5 (DataTable)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 270);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 18);
            this.button2.TabIndex = 8;
            this.button2.Text = "btn_Q6 (Sort)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Identification_Test
            // 
            this.btn_Identification_Test.Location = new System.Drawing.Point(350, 37);
            this.btn_Identification_Test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Identification_Test.Name = "btn_Identification_Test";
            this.btn_Identification_Test.Size = new System.Drawing.Size(56, 18);
            this.btn_Identification_Test.TabIndex = 9;
            this.btn_Identification_Test.Text = "測試";
            this.btn_Identification_Test.UseVisualStyleBackColor = true;
            this.btn_Identification_Test.Click += new System.EventHandler(this.btn_Identification_Test_Click);
            // 
            // btn_Password_Test
            // 
            this.btn_Password_Test.Location = new System.Drawing.Point(350, 109);
            this.btn_Password_Test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Password_Test.Name = "btn_Password_Test";
            this.btn_Password_Test.Size = new System.Drawing.Size(56, 18);
            this.btn_Password_Test.TabIndex = 10;
            this.btn_Password_Test.Text = "測試";
            this.btn_Password_Test.UseVisualStyleBackColor = true;
            this.btn_Password_Test.Click += new System.EventHandler(this.btn_Password_Test_Click);
            // 
            // btn_Email_Test
            // 
            this.btn_Email_Test.Location = new System.Drawing.Point(350, 171);
            this.btn_Email_Test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Email_Test.Name = "btn_Email_Test";
            this.btn_Email_Test.Size = new System.Drawing.Size(56, 18);
            this.btn_Email_Test.TabIndex = 11;
            this.btn_Email_Test.Text = "測試";
            this.btn_Email_Test.UseVisualStyleBackColor = true;
            this.btn_Email_Test.Click += new System.EventHandler(this.btn_Email_Test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btn_Email_Test);
            this.Controls.Add(this.btn_Password_Test);
            this.Controls.Add(this.btn_Identification_Test);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Q4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Identification);
            this.Controls.Add(this.lbl_Identification);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.TextBox txt_Identification;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Q4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Identification_Test;
        private System.Windows.Forms.Button btn_Password_Test;
        private System.Windows.Forms.Button btn_Email_Test;
    }
}

