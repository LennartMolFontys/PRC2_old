namespace Readexportfile
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
            this.listBoxDog = new System.Windows.Forms.ListBox();
            this.listBoxCat = new System.Windows.Forms.ListBox();
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDog
            // 
            this.listBoxDog.FormattingEnabled = true;
            this.listBoxDog.ItemHeight = 16;
            this.listBoxDog.Location = new System.Drawing.Point(30, 53);
            this.listBoxDog.Name = "listBoxDog";
            this.listBoxDog.Size = new System.Drawing.Size(341, 292);
            this.listBoxDog.TabIndex = 0;
            // 
            // listBoxCat
            // 
            this.listBoxCat.FormattingEnabled = true;
            this.listBoxCat.ItemHeight = 16;
            this.listBoxCat.Location = new System.Drawing.Point(417, 53);
            this.listBoxCat.Name = "listBoxCat";
            this.listBoxCat.Size = new System.Drawing.Size(341, 292);
            this.listBoxCat.TabIndex = 1;
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Location = new System.Drawing.Point(339, 387);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(92, 34);
            this.SelectFileBtn.TabIndex = 2;
            this.SelectFileBtn.Text = "Select File";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectFileBtn);
            this.Controls.Add(this.listBoxCat);
            this.Controls.Add(this.listBoxDog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDog;
        private System.Windows.Forms.ListBox listBoxCat;
        private System.Windows.Forms.Button SelectFileBtn;
    }
}

