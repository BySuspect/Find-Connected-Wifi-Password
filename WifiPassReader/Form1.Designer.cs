namespace WifiPassReader
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
        /// <param name="disposing">true if managed resources should be
        ///     disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify the contents of
        /// this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmain = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnget
            // 
            this.btnget.Location = new System.Drawing.Point(15, 72);
            this.btnget.Margin = new System.Windows.Forms.Padding(4);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(169, 32);
            this.btnget.TabIndex = 0;
            this.btnget.Text = "Get";
            this.btnget.UseVisualStyleBackColor = true;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wifi name with spaces";
            // 
            // cbmain
            // 
            this.cbmain.FormattingEnabled = true;
            this.cbmain.Location = new System.Drawing.Point(15, 31);
            this.cbmain.Name = "cbmain";
            this.cbmain.Size = new System.Drawing.Size(169, 26);
            this.cbmain.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(15, 142);
            this.txtpass.Name = "txtpass";
            this.txtpass.ReadOnly = true;
            this.txtpass.Size = new System.Drawing.Size(169, 24);
            this.txtpass.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 175);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbmain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnget);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
    }
}

