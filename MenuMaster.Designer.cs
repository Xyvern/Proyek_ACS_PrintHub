namespace ProyekACS
{
    partial class MenuMaster
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
            this.txtWelcome = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnAddon = new System.Windows.Forms.Button();
            this.btnLayanan = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(12, 9);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(134, 16);
            this.txtWelcome.TabIndex = 2;
            this.txtWelcome.Text = "Welcome, {nama}!";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(627, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "TRANSAKSI";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(752, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "MASTER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(877, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 44);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvMaster
            // 
            this.dgvMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Location = new System.Drawing.Point(175, 100);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.Size = new System.Drawing.Size(452, 425);
            this.dgvMaster.TabIndex = 17;
            this.dgvMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaster_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(243, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(318, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "SEARCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Form Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Username :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(728, 158);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(268, 20);
            this.txtUser.TabIndex = 22;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(728, 262);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(268, 20);
            this.txtNama.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(636, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(728, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(268, 20);
            this.txtPassword.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(636, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nama :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(728, 314);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(636, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(669, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 44);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "BATAL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(851, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 44);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "SIMPAN";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.LightGreen;
            this.btnCustomer.Enabled = false;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(12, 74);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(157, 39);
            this.btnCustomer.TabIndex = 32;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnAddon
            // 
            this.btnAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddon.Location = new System.Drawing.Point(12, 119);
            this.btnAddon.Name = "btnAddon";
            this.btnAddon.Size = new System.Drawing.Size(157, 39);
            this.btnAddon.TabIndex = 33;
            this.btnAddon.Text = "ADD ON";
            this.btnAddon.UseVisualStyleBackColor = true;
            this.btnAddon.Click += new System.EventHandler(this.btnAddon_Click);
            // 
            // btnLayanan
            // 
            this.btnLayanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayanan.Location = new System.Drawing.Point(12, 164);
            this.btnLayanan.Name = "btnLayanan";
            this.btnLayanan.Size = new System.Drawing.Size(157, 39);
            this.btnLayanan.TabIndex = 34;
            this.btnLayanan.Text = "LAYANAN";
            this.btnLayanan.UseVisualStyleBackColor = true;
            this.btnLayanan.Click += new System.EventHandler(this.btnLayanan_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategori.Location = new System.Drawing.Point(12, 209);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(157, 39);
            this.btnKategori.TabIndex = 35;
            this.btnKategori.Text = "KATEGORI";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaryawan.Location = new System.Drawing.Point(12, 254);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(157, 39);
            this.btnKaryawan.TabIndex = 36;
            this.btnKaryawan.Text = "KARYAWAN";
            this.btnKaryawan.UseVisualStyleBackColor = true;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // MenuMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.btnKaryawan);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnLayanan);
            this.Controls.Add(this.btnAddon);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvMaster);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtWelcome);
            this.Name = "MenuMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuMaster";
            this.Load += new System.EventHandler(this.MenuMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnAddon;
        private System.Windows.Forms.Button btnLayanan;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnKaryawan;
    }
}