namespace ProyekACS
{
    partial class Loginkaryawan
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.passLogin = new System.Windows.Forms.TextBox();
            this.Passwords = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnswitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(337, 347);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(335, 46);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // passLogin
            // 
            this.passLogin.Location = new System.Drawing.Point(434, 292);
            this.passLogin.Name = "passLogin";
            this.passLogin.Size = new System.Drawing.Size(238, 20);
            this.passLogin.TabIndex = 19;
            // 
            // Passwords
            // 
            this.Passwords.AutoSize = true;
            this.Passwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwords.Location = new System.Drawing.Point(337, 290);
            this.Passwords.Name = "Passwords";
            this.Passwords.Size = new System.Drawing.Size(86, 20);
            this.Passwords.TabIndex = 18;
            this.Passwords.Text = "Password";
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(434, 239);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(238, 20);
            this.userLogin.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "LOGIN KARYAWAN";
            // 
            // btnswitch
            // 
            this.btnswitch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnswitch.Location = new System.Drawing.Point(824, 12);
            this.btnswitch.Name = "btnswitch";
            this.btnswitch.Size = new System.Drawing.Size(172, 37);
            this.btnswitch.TabIndex = 21;
            this.btnswitch.Text = "LOGIN CUSTOMER";
            this.btnswitch.UseVisualStyleBackColor = false;
            this.btnswitch.Click += new System.EventHandler(this.btnswitch_Click);
            // 
            // Loginkaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.btnswitch);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passLogin);
            this.Controls.Add(this.Passwords);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Loginkaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginkaryawan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox passLogin;
        private System.Windows.Forms.Label Passwords;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnswitch;
    }
}