﻿namespace ProyekACS
{
    partial class Registeruser
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.emailReg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.namaReg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(341, 398);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(331, 39);
            this.btnRegister.TabIndex = 25;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // emailReg
            // 
            this.emailReg.Location = new System.Drawing.Point(434, 356);
            this.emailReg.Name = "emailReg";
            this.emailReg.Size = new System.Drawing.Size(238, 20);
            this.emailReg.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email";
            // 
            // namaReg
            // 
            this.namaReg.Location = new System.Drawing.Point(434, 303);
            this.namaReg.Name = "namaReg";
            this.namaReg.Size = new System.Drawing.Size(238, 20);
            this.namaReg.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nama";
            // 
            // passReg
            // 
            this.passReg.Location = new System.Drawing.Point(434, 248);
            this.passReg.Name = "passReg";
            this.passReg.PasswordChar = '*';
            this.passReg.Size = new System.Drawing.Size(238, 20);
            this.passReg.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // userReg
            // 
            this.userReg.Location = new System.Drawing.Point(434, 195);
            this.userReg.Name = "userReg";
            this.userReg.Size = new System.Drawing.Size(238, 20);
            this.userReg.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 42);
            this.label5.TabIndex = 16;
            this.label5.Text = "REGISTER";
            // 
            // Registeruser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.emailReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.namaReg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "Registeruser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registeruser";
            this.Load += new System.EventHandler(this.Registeruser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox emailReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox namaReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}