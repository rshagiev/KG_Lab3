namespace lab_3
{
    partial class Begining
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
            this.rad_imp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ok_but = new System.Windows.Forms.Button();
            this.Cancel_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rad_imp
            // 
            this.rad_imp.Location = new System.Drawing.Point(61, 47);
            this.rad_imp.Name = "rad_imp";
            this.rad_imp.Size = new System.Drawing.Size(100, 20);
            this.rad_imp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите радиус сферы:";
            // 
            // Ok_but
            // 
            this.Ok_but.Location = new System.Drawing.Point(15, 92);
            this.Ok_but.Name = "Ok_but";
            this.Ok_but.Size = new System.Drawing.Size(81, 31);
            this.Ok_but.TabIndex = 2;
            this.Ok_but.Text = "OK";
            this.Ok_but.UseVisualStyleBackColor = true;
            this.Ok_but.Click += new System.EventHandler(this.Ok_but_Click);
            // 
            // Cancel_but
            // 
            this.Cancel_but.Location = new System.Drawing.Point(149, 92);
            this.Cancel_but.Name = "Cancel_but";
            this.Cancel_but.Size = new System.Drawing.Size(84, 31);
            this.Cancel_but.TabIndex = 3;
            this.Cancel_but.Text = "Cancel";
            this.Cancel_but.UseVisualStyleBackColor = true;
            this.Cancel_but.Click += new System.EventHandler(this.Cancel_but_Click);
            // 
            // Begining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 149);
            this.Controls.Add(this.Cancel_but);
            this.Controls.Add(this.Ok_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rad_imp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Begining";
            this.Text = "Hi!";
            this.Load += new System.EventHandler(this.Begining_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rad_imp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ok_but;
        private System.Windows.Forms.Button Cancel_but;
    }
}