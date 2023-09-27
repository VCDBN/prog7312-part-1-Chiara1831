namespace ST10083452_PROG7312_POE
{
    partial class ReplacingBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplacingBooks));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkOrderBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.generateCallNumBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(22, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 251);
            this.listBox1.TabIndex = 4;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // checkOrderBtn
            // 
            this.checkOrderBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.checkOrderBtn.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkOrderBtn.Image")));
            this.checkOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkOrderBtn.Location = new System.Drawing.Point(190, 375);
            this.checkOrderBtn.Name = "checkOrderBtn";
            this.checkOrderBtn.Size = new System.Drawing.Size(128, 43);
            this.checkOrderBtn.TabIndex = 9;
            this.checkOrderBtn.Text = "Check Order";
            this.checkOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOrderBtn.UseVisualStyleBackColor = false;
            this.checkOrderBtn.Click += new System.EventHandler(this.checkOrderBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.progressBar.ForeColor = System.Drawing.Color.DarkBlue;
            this.progressBar.Location = new System.Drawing.Point(435, 364);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(219, 54);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(302, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 251);
            this.listBox2.TabIndex = 11;
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // listBox3
            // 
            this.listBox3.AllowDrop = true;
            this.listBox3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Location = new System.Drawing.Point(573, 91);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(188, 251);
            this.listBox3.TabIndex = 12;
            // 
            // generateCallNumBtn
            // 
            this.generateCallNumBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.generateCallNumBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.generateCallNumBtn.Location = new System.Drawing.Point(22, 52);
            this.generateCallNumBtn.Name = "generateCallNumBtn";
            this.generateCallNumBtn.Size = new System.Drawing.Size(179, 33);
            this.generateCallNumBtn.TabIndex = 13;
            this.generateCallNumBtn.Text = "Generate Call Numbers";
            this.generateCallNumBtn.UseVisualStyleBackColor = false;
            this.generateCallNumBtn.Click += new System.EventHandler(this.generateCallNumBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(620, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Click on the items to move them to the second listbox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(597, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "SORT THE CALL NUMBERS IN ASCENDING ORDER";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(-1, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(84, 35);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "BACK";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateCallNumBtn);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkOrderBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "ReplacingBooks";
            this.Text = "ReplacingBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button sortAscendingBtn;
        private Button checkOrderBtn;
        private ProgressBar progressBar;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button generateCallNumBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button backBtn;
    }
}