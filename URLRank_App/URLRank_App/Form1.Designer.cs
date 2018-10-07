namespace URLRank_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_SearchString = new System.Windows.Forms.TextBox();
            this.tb_URLString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_ResultString = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(346, 280);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(218, 46);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search Google";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_SearchString
            // 
            this.tb_SearchString.Location = new System.Drawing.Point(261, 77);
            this.tb_SearchString.Name = "tb_SearchString";
            this.tb_SearchString.Size = new System.Drawing.Size(303, 31);
            this.tb_SearchString.TabIndex = 1;
            // 
            // tb_URLString
            // 
            this.tb_URLString.Location = new System.Drawing.Point(261, 169);
            this.tb_URLString.Name = "tb_URLString";
            this.tb_URLString.Size = new System.Drawing.Size(303, 31);
            this.tb_URLString.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "URL (to Search for)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_ResultString);
            this.groupBox1.Controls.Add(this.tb_URLString);
            this.groupBox1.Controls.Add(this.tb_SearchString);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 393);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL Rank Finder";
            // 
            // rtb_ResultString
            // 
            this.rtb_ResultString.Location = new System.Drawing.Point(640, 77);
            this.rtb_ResultString.Name = "rtb_ResultString";
            this.rtb_ResultString.Size = new System.Drawing.Size(610, 238);
            this.rtb_ResultString.TabIndex = 6;
            this.rtb_ResultString.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "URL Rank App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_SearchString;
        private System.Windows.Forms.TextBox tb_URLString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_ResultString;
    }
}

