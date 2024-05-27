namespace ProyekACS
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
            this.btnswitch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passLogin = new System.Windows.Forms.TextBox();
            this.Passwords = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnswitch
            // 
            this.btnswitch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnswitch.Location = new System.Drawing.Point(824, 12);
            this.btnswitch.Name = "btnswitch";
            this.btnswitch.Size = new System.Drawing.Size(172, 37);
            this.btnswitch.TabIndex = 16;
            this.btnswitch.Text = "LOGIN KARYAWAN";
            this.btnswitch.UseVisualStyleBackColor = false;
            this.btnswitch.Click += new System.EventHandler(this.btnswitch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Don\'t have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(530, 329);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 15);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register here.";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(337, 347);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(335, 46);
            this.btnLogin.TabIndex = 32;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // passLogin
            // 
            this.passLogin.Location = new System.Drawing.Point(434, 292);
            this.passLogin.Name = "passLogin";
            this.passLogin.Size = new System.Drawing.Size(238, 20);
            this.passLogin.TabIndex = 31;
            // 
            // Passwords
            // 
            this.Passwords.AutoSize = true;
            this.Passwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwords.Location = new System.Drawing.Point(337, 290);
            this.Passwords.Name = "Passwords";
            this.Passwords.Size = new System.Drawing.Size(86, 20);
            this.Passwords.TabIndex = 30;
            this.Passwords.Text = "Password";
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(434, 239);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(238, 20);
            this.userLogin.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "LOGIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passLogin);
            this.Controls.Add(this.Passwords);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnswitch);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnswitch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox passLogin;
        private System.Windows.Forms.Label Passwords;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

