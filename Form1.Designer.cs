
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Q4 = new System.Windows.Forms.Button();
            this.btn_Q5 = new System.Windows.Forms.Button();
            this.btn_Q6 = new System.Windows.Forms.Button();
            this.btn_Identification_Test = new System.Windows.Forms.Button();
            this.btn_Password_Test = new System.Windows.Forms.Button();
            this.btn_Email_Test = new System.Windows.Forms.Button();
            this.dGV_Q5 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Q5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.Location = new System.Drawing.Point(13, 12);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(131, 15);
            this.lbl_Identification.TabIndex = 0;
            this.lbl_Identification.Text = "請輸入身份證字號:";
            // 
            // txt_Identification
            // 
            this.txt_Identification.Location = new System.Drawing.Point(13, 46);
            this.txt_Identification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Identification.Name = "txt_Identification";
            this.txt_Identification.Size = new System.Drawing.Size(432, 25);
            this.txt_Identification.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(13, 89);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(435, 30);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "請輸入密碼:\r\n(輸入密碼必須是8個字元以上，不得為+-*/.!@#$%^&*()等特殊字元)";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(13, 138);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(432, 25);
            this.txt_Password.TabIndex = 3;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(13, 180);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(125, 15);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "請輸入E-mail帳號:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(13, 212);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(432, 25);
            this.txt_Email.TabIndex = 5;
            // 
            // btn_Q4
            // 
            this.btn_Q4.Location = new System.Drawing.Point(13, 256);
            this.btn_Q4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Q4.Name = "btn_Q4";
            this.btn_Q4.Size = new System.Drawing.Size(125, 22);
            this.btn_Q4.TabIndex = 6;
            this.btn_Q4.Text = "btn_Q4";
            this.btn_Q4.UseVisualStyleBackColor = true;
            this.btn_Q4.Click += new System.EventHandler(this.btn_Q4_Click);
            // 
            // btn_Q5
            // 
            this.btn_Q5.Location = new System.Drawing.Point(13, 298);
            this.btn_Q5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Q5.Name = "btn_Q5";
            this.btn_Q5.Size = new System.Drawing.Size(125, 22);
            this.btn_Q5.TabIndex = 7;
            this.btn_Q5.Text = "btn_Q5 (DataTable)";
            this.btn_Q5.UseVisualStyleBackColor = true;
            this.btn_Q5.Click += new System.EventHandler(this.btn_Q5_Click);
            // 
            // btn_Q6
            // 
            this.btn_Q6.Location = new System.Drawing.Point(13, 338);
            this.btn_Q6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Q6.Name = "btn_Q6";
            this.btn_Q6.Size = new System.Drawing.Size(125, 22);
            this.btn_Q6.TabIndex = 8;
            this.btn_Q6.Text = "btn_Q6 (Sort)";
            this.btn_Q6.UseVisualStyleBackColor = true;
            this.btn_Q6.Click += new System.EventHandler(this.btn_Q6_Click);
            // 
            // btn_Identification_Test
            // 
            this.btn_Identification_Test.Location = new System.Drawing.Point(467, 46);
            this.btn_Identification_Test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Identification_Test.Name = "btn_Identification_Test";
            this.btn_Identification_Test.Size = new System.Drawing.Size(75, 22);
            this.btn_Identification_Test.TabIndex = 9;
            this.btn_Identification_Test.Text = "測試";
            this.btn_Identification_Test.UseVisualStyleBackColor = true;
            this.btn_Identification_Test.Click += new System.EventHandler(this.btn_Identification_Test_Click);
            // 
            // btn_Password_Test
            // 
            this.btn_Password_Test.Location = new System.Drawing.Point(467, 136);
            this.btn_Password_Test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Password_Test.Name = "btn_Password_Test";
            this.btn_Password_Test.Size = new System.Drawing.Size(75, 22);
            this.btn_Password_Test.TabIndex = 10;
            this.btn_Password_Test.Text = "測試";
            this.btn_Password_Test.UseVisualStyleBackColor = true;
            this.btn_Password_Test.Click += new System.EventHandler(this.btn_Password_Test_Click);
            // 
            // btn_Email_Test
            // 
            this.btn_Email_Test.Location = new System.Drawing.Point(467, 214);
            this.btn_Email_Test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Email_Test.Name = "btn_Email_Test";
            this.btn_Email_Test.Size = new System.Drawing.Size(75, 22);
            this.btn_Email_Test.TabIndex = 11;
            this.btn_Email_Test.Text = "測試";
            this.btn_Email_Test.UseVisualStyleBackColor = true;
            this.btn_Email_Test.Click += new System.EventHandler(this.btn_Email_Test_Click);
            // 
            // dGV_Q5
            // 
            this.dGV_Q5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Q5.Location = new System.Drawing.Point(548, 12);
            this.dGV_Q5.Name = "dGV_Q5";
            this.dGV_Q5.RowHeadersWidth = 51;
            this.dGV_Q5.RowTemplate.Height = 27;
            this.dGV_Q5.Size = new System.Drawing.Size(727, 426);
            this.dGV_Q5.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 450);
            this.Controls.Add(this.dGV_Q5);
            this.Controls.Add(this.btn_Email_Test);
            this.Controls.Add(this.btn_Password_Test);
            this.Controls.Add(this.btn_Identification_Test);
            this.Controls.Add(this.btn_Q6);
            this.Controls.Add(this.btn_Q5);
            this.Controls.Add(this.btn_Q4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Identification);
            this.Controls.Add(this.lbl_Identification);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Q5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.TextBox txt_Identification;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Q4;
        private System.Windows.Forms.Button btn_Q5;
        private System.Windows.Forms.Button btn_Q6;
        private System.Windows.Forms.Button btn_Identification_Test;
        private System.Windows.Forms.Button btn_Password_Test;
        private System.Windows.Forms.Button btn_Email_Test;
        private System.Windows.Forms.DataGridView dGV_Q5;
    }
}

