namespace ReadingMNISTDatabase
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
            this.Read = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chckBx_Threshold = new System.Windows.Forms.CheckBox();
            this.rdoBtn_TrainingSet = new System.Windows.Forms.RadioButton();
            this.rdoBtn_TestingSet = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(84, 27);
            this.Read.Margin = new System.Windows.Forms.Padding(2);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(122, 30);
            this.Read.TabIndex = 0;
            this.Read.Text = "Read Database";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(184, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(178, 120);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(86, 37);
            this.btn_Show.TabIndex = 2;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(37, 89);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // chckBx_Threshold
            // 
            this.chckBx_Threshold.AutoSize = true;
            this.chckBx_Threshold.Location = new System.Drawing.Point(37, 169);
            this.chckBx_Threshold.Margin = new System.Windows.Forms.Padding(2);
            this.chckBx_Threshold.Name = "chckBx_Threshold";
            this.chckBx_Threshold.Size = new System.Drawing.Size(96, 17);
            this.chckBx_Threshold.TabIndex = 5;
            this.chckBx_Threshold.Text = "With threshold";
            this.chckBx_Threshold.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_TrainingSet
            // 
            this.rdoBtn_TrainingSet.AutoSize = true;
            this.rdoBtn_TrainingSet.Checked = true;
            this.rdoBtn_TrainingSet.Location = new System.Drawing.Point(37, 119);
            this.rdoBtn_TrainingSet.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtn_TrainingSet.Name = "rdoBtn_TrainingSet";
            this.rdoBtn_TrainingSet.Size = new System.Drawing.Size(79, 17);
            this.rdoBtn_TrainingSet.TabIndex = 6;
            this.rdoBtn_TrainingSet.TabStop = true;
            this.rdoBtn_TrainingSet.Text = "TrainingSet";
            this.rdoBtn_TrainingSet.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_TestingSet
            // 
            this.rdoBtn_TestingSet.AutoSize = true;
            this.rdoBtn_TestingSet.Location = new System.Drawing.Point(38, 145);
            this.rdoBtn_TestingSet.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtn_TestingSet.Name = "rdoBtn_TestingSet";
            this.rdoBtn_TestingSet.Size = new System.Drawing.Size(76, 17);
            this.rdoBtn_TestingSet.TabIndex = 7;
            this.rdoBtn_TestingSet.Text = "TestingSet";
            this.rdoBtn_TestingSet.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdoBtn_TestingSet);
            this.Controls.Add(this.rdoBtn_TrainingSet);
            this.Controls.Add(this.chckBx_Threshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Read);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chckBx_Threshold;
        private System.Windows.Forms.RadioButton rdoBtn_TrainingSet;
        private System.Windows.Forms.RadioButton rdoBtn_TestingSet;
        private System.Windows.Forms.Button button1;
    }
}

