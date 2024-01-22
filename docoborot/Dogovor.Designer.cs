namespace docoborot
{
    partial class Dogovor
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_txt = new System.Windows.Forms.Button();
            this.button_docx = new System.Windows.Forms.Button();
            this.cvitance = new System.Windows.Forms.Button();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите формат договора";
            // 
            // button_txt
            // 
            this.button_txt.BackColor = System.Drawing.Color.PowderBlue;
            this.button_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_txt.Location = new System.Drawing.Point(12, 102);
            this.button_txt.Name = "button_txt";
            this.button_txt.Size = new System.Drawing.Size(177, 56);
            this.button_txt.TabIndex = 7;
            this.button_txt.Text = "Формат TXT";
            this.button_txt.UseVisualStyleBackColor = false;
            this.button_txt.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_docx
            // 
            this.button_docx.BackColor = System.Drawing.Color.PowderBlue;
            this.button_docx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docx.Location = new System.Drawing.Point(9, 189);
            this.button_docx.Name = "button_docx";
            this.button_docx.Size = new System.Drawing.Size(180, 56);
            this.button_docx.TabIndex = 8;
            this.button_docx.Text = "Формат DOCX";
            this.button_docx.UseVisualStyleBackColor = false;
            this.button_docx.Click += new System.EventHandler(this.button2_Click);
            // 
            // cvitance
            // 
            this.cvitance.BackColor = System.Drawing.Color.PowderBlue;
            this.cvitance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvitance.Location = new System.Drawing.Point(12, 280);
            this.cvitance.Name = "cvitance";
            this.cvitance.Size = new System.Drawing.Size(180, 56);
            this.cvitance.TabIndex = 9;
            this.cvitance.Text = "Квитанция";
            this.cvitance.UseVisualStyleBackColor = false;
            this.cvitance.Click += new System.EventHandler(this.cvitance_Click);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(185, 360);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(221, 20);
            this.lblLoggedInUser.TabIndex = 10;
            this.lblLoggedInUser.Text = "Выберите формат договора";
            // 
            // Dogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(199)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(382, 389);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.cvitance);
            this.Controls.Add(this.button_docx);
            this.Controls.Add(this.button_txt);
            this.Controls.Add(this.label1);
            this.Name = "Dogovor";
            this.Text = "Dogovor";
            this.Load += new System.EventHandler(this.Dogovor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_txt;
        private System.Windows.Forms.Button button_docx;
        private System.Windows.Forms.Button cvitance;
        private System.Windows.Forms.Label lblLoggedInUser;
    }
}