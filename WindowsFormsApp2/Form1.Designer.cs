namespace WindowsFormsApp2
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
            this.buttondelete = new System.Windows.Forms.Button();
            this.richTextBox紀錄 = new System.Windows.Forms.RichTextBox();
            this.button等於 = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            this.buttonN3 = new System.Windows.Forms.Button();
            this.buttonN6 = new System.Windows.Forms.Button();
            this.button除 = new System.Windows.Forms.Button();
            this.button乘 = new System.Windows.Forms.Button();
            this.button減 = new System.Windows.Forms.Button();
            this.button加 = new System.Windows.Forms.Button();
            this.buttonN9 = new System.Windows.Forms.Button();
            this.buttonN0 = new System.Windows.Forms.Button();
            this.buttonN2 = new System.Windows.Forms.Button();
            this.buttonN5 = new System.Windows.Forms.Button();
            this.buttonN8 = new System.Windows.Forms.Button();
            this.button點 = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonN1 = new System.Windows.Forms.Button();
            this.buttonN4 = new System.Windows.Forms.Button();
            this.buttonN7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(20, 362);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(67, 29);
            this.buttondelete.TabIndex = 24;
            this.buttondelete.Text = "delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            // 
            // richTextBox紀錄
            // 
            this.richTextBox紀錄.Location = new System.Drawing.Point(381, 114);
            this.richTextBox紀錄.Name = "richTextBox紀錄";
            this.richTextBox紀錄.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox紀錄.Size = new System.Drawing.Size(613, 231);
            this.richTextBox紀錄.TabIndex = 23;
            this.richTextBox紀錄.Text = "";
            // 
            // button等於
            // 
            this.button等於.Location = new System.Drawing.Point(381, 362);
            this.button等於.Name = "button等於";
            this.button等於.Size = new System.Drawing.Size(119, 66);
            this.button等於.TabIndex = 22;
            this.button等於.Text = "等於";
            this.button等於.UseVisualStyleBackColor = true;
            this.button等於.Click += new System.EventHandler(this.button等於_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelresult.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelresult.Location = new System.Drawing.Point(26, 43);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(89, 30);
            this.labelresult.TabIndex = 21;
            this.labelresult.Text = "label1";
            // 
            // buttonN3
            // 
            this.buttonN3.Location = new System.Drawing.Point(193, 279);
            this.buttonN3.Name = "buttonN3";
            this.buttonN3.Size = new System.Drawing.Size(67, 66);
            this.buttonN3.TabIndex = 19;
            this.buttonN3.Text = "3";
            this.buttonN3.UseVisualStyleBackColor = true;
            this.buttonN3.Click += new System.EventHandler(this.buttonN3_Click);
            // 
            // buttonN6
            // 
            this.buttonN6.Location = new System.Drawing.Point(193, 197);
            this.buttonN6.Name = "buttonN6";
            this.buttonN6.Size = new System.Drawing.Size(67, 66);
            this.buttonN6.TabIndex = 18;
            this.buttonN6.Text = "6";
            this.buttonN6.UseVisualStyleBackColor = true;
            this.buttonN6.Click += new System.EventHandler(this.buttonN6_Click);
            // 
            // button除
            // 
            this.button除.Location = new System.Drawing.Point(283, 362);
            this.button除.Name = "button除";
            this.button除.Size = new System.Drawing.Size(67, 66);
            this.button除.TabIndex = 17;
            this.button除.Text = "除";
            this.button除.UseVisualStyleBackColor = true;
            this.button除.Click += new System.EventHandler(this.button除_Click);
            // 
            // button乘
            // 
            this.button乘.Location = new System.Drawing.Point(283, 279);
            this.button乘.Name = "button乘";
            this.button乘.Size = new System.Drawing.Size(67, 66);
            this.button乘.TabIndex = 16;
            this.button乘.Text = "乘";
            this.button乘.UseVisualStyleBackColor = true;
            this.button乘.Click += new System.EventHandler(this.button乘_Click);
            // 
            // button減
            // 
            this.button減.Location = new System.Drawing.Point(283, 197);
            this.button減.Name = "button減";
            this.button減.Size = new System.Drawing.Size(67, 66);
            this.button減.TabIndex = 15;
            this.button減.Text = "減";
            this.button減.UseVisualStyleBackColor = true;
            this.button減.Click += new System.EventHandler(this.button減_Click);
            // 
            // button加
            // 
            this.button加.Location = new System.Drawing.Point(283, 114);
            this.button加.Name = "button加";
            this.button加.Size = new System.Drawing.Size(67, 66);
            this.button加.TabIndex = 5;
            this.button加.Text = "加";
            this.button加.UseVisualStyleBackColor = true;
            this.button加.Click += new System.EventHandler(this.button加_Click);
            // 
            // buttonN9
            // 
            this.buttonN9.Location = new System.Drawing.Point(193, 114);
            this.buttonN9.Name = "buttonN9";
            this.buttonN9.Size = new System.Drawing.Size(67, 66);
            this.buttonN9.TabIndex = 13;
            this.buttonN9.Text = "9";
            this.buttonN9.UseVisualStyleBackColor = true;
            this.buttonN9.Click += new System.EventHandler(this.buttonN9_Click);
            // 
            // buttonN0
            // 
            this.buttonN0.Location = new System.Drawing.Point(106, 362);
            this.buttonN0.Name = "buttonN0";
            this.buttonN0.Size = new System.Drawing.Size(67, 66);
            this.buttonN0.TabIndex = 12;
            this.buttonN0.Text = "0";
            this.buttonN0.UseVisualStyleBackColor = true;
            this.buttonN0.Click += new System.EventHandler(this.buttonN0_Click);
            // 
            // buttonN2
            // 
            this.buttonN2.Location = new System.Drawing.Point(106, 279);
            this.buttonN2.Name = "buttonN2";
            this.buttonN2.Size = new System.Drawing.Size(67, 66);
            this.buttonN2.TabIndex = 11;
            this.buttonN2.Text = "2";
            this.buttonN2.UseVisualStyleBackColor = true;
            this.buttonN2.Click += new System.EventHandler(this.buttonN2_Click);
            // 
            // buttonN5
            // 
            this.buttonN5.Location = new System.Drawing.Point(106, 197);
            this.buttonN5.Name = "buttonN5";
            this.buttonN5.Size = new System.Drawing.Size(67, 66);
            this.buttonN5.TabIndex = 10;
            this.buttonN5.Text = "5";
            this.buttonN5.UseVisualStyleBackColor = true;
            this.buttonN5.Click += new System.EventHandler(this.buttonN5_Click);
            // 
            // buttonN8
            // 
            this.buttonN8.Location = new System.Drawing.Point(106, 114);
            this.buttonN8.Name = "buttonN8";
            this.buttonN8.Size = new System.Drawing.Size(67, 66);
            this.buttonN8.TabIndex = 9;
            this.buttonN8.Text = "8";
            this.buttonN8.UseVisualStyleBackColor = true;
            this.buttonN8.Click += new System.EventHandler(this.buttonN8_Click);
            // 
            // button點
            // 
            this.button點.Location = new System.Drawing.Point(193, 377);
            this.button點.Name = "button點";
            this.button點.Size = new System.Drawing.Size(67, 51);
            this.button點.TabIndex = 8;
            this.button點.Text = "小數點";
            this.button點.UseVisualStyleBackColor = true;
            this.button點.Click += new System.EventHandler(this.button點_Click);
            // 
            // buttonAC
            // 
            this.buttonAC.Location = new System.Drawing.Point(20, 397);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(67, 31);
            this.buttonAC.TabIndex = 7;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = true;
            // 
            // buttonN1
            // 
            this.buttonN1.Location = new System.Drawing.Point(20, 279);
            this.buttonN1.Name = "buttonN1";
            this.buttonN1.Size = new System.Drawing.Size(67, 66);
            this.buttonN1.TabIndex = 6;
            this.buttonN1.Text = "1";
            this.buttonN1.UseVisualStyleBackColor = true;
            this.buttonN1.Click += new System.EventHandler(this.buttonN1_Click);
            // 
            // buttonN4
            // 
            this.buttonN4.Location = new System.Drawing.Point(20, 197);
            this.buttonN4.Name = "buttonN4";
            this.buttonN4.Size = new System.Drawing.Size(67, 66);
            this.buttonN4.TabIndex = 20;
            this.buttonN4.Text = "4";
            this.buttonN4.UseVisualStyleBackColor = true;
            this.buttonN4.Click += new System.EventHandler(this.buttonN4_Click);
            // 
            // buttonN7
            // 
            this.buttonN7.Location = new System.Drawing.Point(20, 114);
            this.buttonN7.Name = "buttonN7";
            this.buttonN7.Size = new System.Drawing.Size(67, 66);
            this.buttonN7.TabIndex = 14;
            this.buttonN7.Text = "7";
            this.buttonN7.UseVisualStyleBackColor = true;
            this.buttonN7.Click += new System.EventHandler(this.buttonN7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 456);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.richTextBox紀錄);
            this.Controls.Add(this.button等於);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.buttonN3);
            this.Controls.Add(this.buttonN6);
            this.Controls.Add(this.button除);
            this.Controls.Add(this.button乘);
            this.Controls.Add(this.button減);
            this.Controls.Add(this.button加);
            this.Controls.Add(this.buttonN9);
            this.Controls.Add(this.buttonN0);
            this.Controls.Add(this.buttonN2);
            this.Controls.Add(this.buttonN5);
            this.Controls.Add(this.buttonN8);
            this.Controls.Add(this.button點);
            this.Controls.Add(this.buttonAC);
            this.Controls.Add(this.buttonN1);
            this.Controls.Add(this.buttonN4);
            this.Controls.Add(this.buttonN7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.RichTextBox richTextBox紀錄;
        private System.Windows.Forms.Button button等於;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Button buttonN3;
        private System.Windows.Forms.Button buttonN6;
        private System.Windows.Forms.Button button除;
        private System.Windows.Forms.Button button乘;
        private System.Windows.Forms.Button button減;
        private System.Windows.Forms.Button button加;
        private System.Windows.Forms.Button buttonN9;
        private System.Windows.Forms.Button buttonN0;
        private System.Windows.Forms.Button buttonN2;
        private System.Windows.Forms.Button buttonN5;
        private System.Windows.Forms.Button buttonN8;
        private System.Windows.Forms.Button button點;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonN1;
        private System.Windows.Forms.Button buttonN4;
        private System.Windows.Forms.Button buttonN7;
    }
}

