namespace ProyekACS
{
    partial class Homekaryawan
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.dgvAddon = new System.Windows.Forms.DataGridView();
            this.txtNota = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.Label();
            this.txtAddons = new System.Windows.Forms.Label();
            this.txtGrandtotal = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtcustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(12, 9);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(134, 16);
            this.txtWelcome.TabIndex = 1;
            this.txtWelcome.Text = "Welcome, {nama}!";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(877, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 44);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(752, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "MASTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(627, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "TRANSAKSI";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dgvNota
            // 
            this.dgvNota.AllowUserToAddRows = false;
            this.dgvNota.AllowUserToDeleteRows = false;
            this.dgvNota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Location = new System.Drawing.Point(15, 93);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.ReadOnly = true;
            this.dgvNota.Size = new System.Drawing.Size(157, 382);
            this.dgvNota.TabIndex = 13;
            this.dgvNota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNota_CellClick);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(178, 93);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(386, 267);
            this.dgvDetail.TabIndex = 14;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            // 
            // dgvAddon
            // 
            this.dgvAddon.AllowUserToAddRows = false;
            this.dgvAddon.AllowUserToDeleteRows = false;
            this.dgvAddon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddon.Location = new System.Drawing.Point(178, 382);
            this.dgvAddon.Name = "dgvAddon";
            this.dgvAddon.ReadOnly = true;
            this.dgvAddon.Size = new System.Drawing.Size(386, 143);
            this.dgvAddon.TabIndex = 15;
            // 
            // txtNota
            // 
            this.txtNota.AutoSize = true;
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(570, 74);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(181, 31);
            this.txtNota.TabIndex = 16;
            this.txtNota.Text = "Nomor Urut: ";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AutoSize = true;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(572, 214);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(142, 20);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.Text = "Subtotal Layanan: ";
            // 
            // txtAddons
            // 
            this.txtAddons.AutoSize = true;
            this.txtAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddons.Location = new System.Drawing.Point(572, 267);
            this.txtAddons.Name = "txtAddons";
            this.txtAddons.Size = new System.Drawing.Size(143, 20);
            this.txtAddons.TabIndex = 18;
            this.txtAddons.Text = "Subtotal Add Ons: ";
            // 
            // txtGrandtotal
            // 
            this.txtGrandtotal.AutoSize = true;
            this.txtGrandtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandtotal.Location = new System.Drawing.Point(572, 356);
            this.txtGrandtotal.Name = "txtGrandtotal";
            this.txtGrandtotal.Size = new System.Drawing.Size(105, 20);
            this.txtGrandtotal.TabIndex = 19;
            this.txtGrandtotal.Text = "Grandtotal: ";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.LightGreen;
            this.btnAccept.Enabled = false;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(576, 432);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(420, 44);
            this.btnAccept.TabIndex = 20;
            this.btnAccept.Text = "SELESAIKAN TRANSAKSI";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Antrian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Detail Pesanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Detail Add Ons Layanan";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(502, 12);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(119, 44);
            this.btnHistory.TabIndex = 24;
            this.btnHistory.Text = "HISTORY";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(15, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 44);
            this.button3.TabIndex = 25;
            this.button3.Text = "HAPUS NOTA TIDAK VALID";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(377, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 44);
            this.btnReport.TabIndex = 26;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtcustomer
            // 
            this.txtcustomer.AutoSize = true;
            this.txtcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomer.Location = new System.Drawing.Point(572, 161);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(82, 20);
            this.txtcustomer.TabIndex = 27;
            this.txtcustomer.Text = "Customer:";
            // 
            // Homekaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtGrandtotal);
            this.Controls.Add(this.txtAddons);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.dgvAddon);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtWelcome);
            this.Name = "Homekaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homekaryawan";
            this.Load += new System.EventHandler(this.Homekaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvNota;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridView dgvAddon;
        private System.Windows.Forms.Label txtNota;
        private System.Windows.Forms.Label txtSubtotal;
        private System.Windows.Forms.Label txtAddons;
        private System.Windows.Forms.Label txtGrandtotal;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label txtcustomer;
    }
}