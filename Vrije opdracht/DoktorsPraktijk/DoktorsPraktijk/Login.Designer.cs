namespace DoktorsPraktijk
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Docter = new System.Windows.Forms.GroupBox();
            this.Docter.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(38, 20);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(128, 20);
            this.UserName.TabIndex = 2;
            // 
            // PassWord
            // 
            this.PassWord.Location = new System.Drawing.Point(38, 48);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(128, 20);
            this.PassWord.TabIndex = 3;
            // 
            // Docter
            // 
            this.Docter.Controls.Add(this.PassWord);
            this.Docter.Controls.Add(this.UserName);
            this.Docter.Controls.Add(this.button2);
            this.Docter.Location = new System.Drawing.Point(10, 16);
            this.Docter.Name = "Docter";
            this.Docter.Size = new System.Drawing.Size(217, 168);
            this.Docter.TabIndex = 4;
            this.Docter.TabStop = false;
            this.Docter.Text = "Docter\'s Assistant";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Docter);
            this.Name = "Login";
            this.Text = "Login";
            this.Docter.ResumeLayout(false);
            this.Docter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.GroupBox Docter;
    }
}