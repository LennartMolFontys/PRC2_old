namespace opdracht_4
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddSquareBtn = new System.Windows.Forms.Button();
            this.SquareTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddCircleBtn = new System.Windows.Forms.Button();
            this.CircleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShapeListBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DrawCircle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddSquareBtn);
            this.groupBox2.Controls.Add(this.SquareTextBox);
            this.groupBox2.Location = new System.Drawing.Point(41, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 136);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Square";
            // 
            // AddSquareBtn
            // 
            this.AddSquareBtn.Location = new System.Drawing.Point(29, 75);
            this.AddSquareBtn.Name = "AddSquareBtn";
            this.AddSquareBtn.Size = new System.Drawing.Size(100, 33);
            this.AddSquareBtn.TabIndex = 3;
            this.AddSquareBtn.Text = "New Square";
            this.AddSquareBtn.UseVisualStyleBackColor = true;
            this.AddSquareBtn.Click += new System.EventHandler(this.AddSquareBtn_Click);
            // 
            // SquareTextBox
            // 
            this.SquareTextBox.Location = new System.Drawing.Point(29, 37);
            this.SquareTextBox.Name = "SquareTextBox";
            this.SquareTextBox.Size = new System.Drawing.Size(100, 22);
            this.SquareTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCircleBtn);
            this.groupBox1.Controls.Add(this.CircleTextBox);
            this.groupBox1.Location = new System.Drawing.Point(41, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 136);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circle";
            // 
            // AddCircleBtn
            // 
            this.AddCircleBtn.Location = new System.Drawing.Point(25, 75);
            this.AddCircleBtn.Name = "AddCircleBtn";
            this.AddCircleBtn.Size = new System.Drawing.Size(100, 33);
            this.AddCircleBtn.TabIndex = 2;
            this.AddCircleBtn.Text = "New Circle";
            this.AddCircleBtn.UseVisualStyleBackColor = true;
            this.AddCircleBtn.Click += new System.EventHandler(this.AddCircleBtn_Click);
            // 
            // CircleTextBox
            // 
            this.CircleTextBox.Location = new System.Drawing.Point(25, 37);
            this.CircleTextBox.Name = "CircleTextBox";
            this.CircleTextBox.Size = new System.Drawing.Size(100, 22);
            this.CircleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Shapes";
            // 
            // ShapeListBox
            // 
            this.ShapeListBox.FormattingEnabled = true;
            this.ShapeListBox.ItemHeight = 16;
            this.ShapeListBox.Location = new System.Drawing.Point(261, 48);
            this.ShapeListBox.Name = "ShapeListBox";
            this.ShapeListBox.Size = new System.Drawing.Size(268, 372);
            this.ShapeListBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // DrawCircle
            // 
            this.DrawCircle.Location = new System.Drawing.Point(39, 54);
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(121, 31);
            this.DrawCircle.TabIndex = 13;
            this.DrawCircle.Text = "Draw";
            this.DrawCircle.UseVisualStyleBackColor = true;
            this.DrawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DrawCircle);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(585, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 106);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Draw Shape";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShapeListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddSquareBtn;
        private System.Windows.Forms.TextBox SquareTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddCircleBtn;
        private System.Windows.Forms.TextBox CircleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ShapeListBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button DrawCircle;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

