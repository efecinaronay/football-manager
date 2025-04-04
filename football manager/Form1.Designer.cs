namespace football_manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.takımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taktikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_taktik = new System.Windows.Forms.Panel();
            this.cont_taktik_oyuncu_listesi1 = new football_manager.controller.cont_taktik_oyuncu_listesi();
            this.pnl_Fixtur = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.fixtur1 = new football_manager.controller.Fixtur();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_mesaj = new System.Windows.Forms.Panel();
            this.pnl_lig_t = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Takim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Averaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_gol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_gol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_transfer = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iddd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OyuncuAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Takimd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_yeni_oyun = new System.Windows.Forms.Panel();
            this.combo_takim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_lig = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnl_taktik.SuspendLayout();
            this.pnl_lig_t.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_transfer.SuspendLayout();
            this.pnl_yeni_oyun.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takımToolStripMenuItem,
            this.ligToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // takımToolStripMenuItem
            // 
            this.takımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taktikToolStripMenuItem,
            this.fixturToolStripMenuItem,
            this.mesajlarToolStripMenuItem});
            this.takımToolStripMenuItem.Name = "takımToolStripMenuItem";
            this.takımToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.takımToolStripMenuItem.Text = "Takım";
            // 
            // taktikToolStripMenuItem
            // 
            this.taktikToolStripMenuItem.Name = "taktikToolStripMenuItem";
            this.taktikToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.taktikToolStripMenuItem.Text = "Taktik";
            this.taktikToolStripMenuItem.Click += new System.EventHandler(this.taktikToolStripMenuItem_Click);
            // 
            // fixturToolStripMenuItem
            // 
            this.fixturToolStripMenuItem.Name = "fixturToolStripMenuItem";
            this.fixturToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.fixturToolStripMenuItem.Text = "Fikstür";
            this.fixturToolStripMenuItem.Click += new System.EventHandler(this.fixturToolStripMenuItem_Click);
            // 
            // mesajlarToolStripMenuItem
            // 
            this.mesajlarToolStripMenuItem.Name = "mesajlarToolStripMenuItem";
            this.mesajlarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.mesajlarToolStripMenuItem.Text = "Mesajlar";
            this.mesajlarToolStripMenuItem.Click += new System.EventHandler(this.mesajlarToolStripMenuItem_Click);
            // 
            // ligToolStripMenuItem
            // 
            this.ligToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligTablosuToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.ligToolStripMenuItem.Name = "ligToolStripMenuItem";
            this.ligToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.ligToolStripMenuItem.Text = "Lig";
            // 
            // ligTablosuToolStripMenuItem
            // 
            this.ligTablosuToolStripMenuItem.Name = "ligTablosuToolStripMenuItem";
            this.ligTablosuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ligTablosuToolStripMenuItem.Text = "Lig Tablosu";
            this.ligTablosuToolStripMenuItem.Click += new System.EventHandler(this.ligTablosuToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // pnl_taktik
            // 
            this.pnl_taktik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnl_taktik.Location = new System.Drawing.Point(12, 192);
            this.pnl_taktik.Name = "pnl_taktik";
            this.pnl_taktik.Size = new System.Drawing.Size(20, 25);
            this.pnl_taktik.TabIndex = 1;
            this.pnl_taktik.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_taktik_Paint);
            // 
            // cont_taktik_oyuncu_listesi1
            // 
            this.cont_taktik_oyuncu_listesi1.AllowDrop = true;
            this.cont_taktik_oyuncu_listesi1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cont_taktik_oyuncu_listesi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cont_taktik_oyuncu_listesi1.Location = new System.Drawing.Point(20, 84);
            this.cont_taktik_oyuncu_listesi1.Name = "cont_taktik_oyuncu_listesi1";
            this.cont_taktik_oyuncu_listesi1.Size = new System.Drawing.Size(336, 518);
            this.cont_taktik_oyuncu_listesi1.TabIndex = 0;
            // 
            // pnl_Fixtur
            // 
            this.pnl_Fixtur.Location = new System.Drawing.Point(2, 152);
            this.pnl_Fixtur.Name = "pnl_Fixtur";
            this.pnl_Fixtur.Size = new System.Drawing.Size(32, 25);
            this.pnl_Fixtur.TabIndex = 2;
            this.pnl_Fixtur.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lbl_time.Location = new System.Drawing.Point(551, 23);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(13, 18);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "-";
            // 
            // fixtur1
            // 
            this.fixtur1.Location = new System.Drawing.Point(0, 0);
            this.fixtur1.Name = "fixtur1";
            this.fixtur1.Size = new System.Drawing.Size(864, 525);
            this.fixtur1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.button1.Location = new System.Drawing.Point(12, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Tag = "zaman";
            this.button1.Text = "İlerlet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_mesaj
            // 
            this.pnl_mesaj.AutoScroll = true;
            this.pnl_mesaj.Location = new System.Drawing.Point(2, 81);
            this.pnl_mesaj.Name = "pnl_mesaj";
            this.pnl_mesaj.Size = new System.Drawing.Size(33, 36);
            this.pnl_mesaj.TabIndex = 5;
            this.pnl_mesaj.Visible = false;
            // 
            // pnl_lig_t
            // 
            this.pnl_lig_t.Controls.Add(this.dataGridView1);
            this.pnl_lig_t.Location = new System.Drawing.Point(10, 223);
            this.pnl_lig_t.Name = "pnl_lig_t";
            this.pnl_lig_t.Size = new System.Drawing.Size(25, 22);
            this.pnl_lig_t.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Takim,
            this.Puan,
            this.Averaj,
            this.A_gol,
            this.Y_gol});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.Location = new System.Drawing.Point(291, 71);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(441, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.dataGridView1_RowDividerDoubleClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Sira
            // 
            this.Sira.HeaderText = "Sıra";
            this.Sira.Name = "Sira";
            this.Sira.ReadOnly = true;
            this.Sira.Width = 40;
            // 
            // Takim
            // 
            this.Takim.HeaderText = "Takım";
            this.Takim.Name = "Takim";
            this.Takim.ReadOnly = true;
            // 
            // Puan
            // 
            this.Puan.HeaderText = "Puan";
            this.Puan.Name = "Puan";
            this.Puan.ReadOnly = true;
            this.Puan.Width = 50;
            // 
            // Averaj
            // 
            this.Averaj.HeaderText = "Averaj";
            this.Averaj.Name = "Averaj";
            this.Averaj.ReadOnly = true;
            this.Averaj.Width = 50;
            // 
            // A_gol
            // 
            this.A_gol.HeaderText = "A.gol";
            this.A_gol.Name = "A_gol";
            this.A_gol.ReadOnly = true;
            this.A_gol.Width = 50;
            // 
            // Y_gol
            // 
            this.Y_gol.HeaderText = "Y.gol";
            this.Y_gol.Name = "Y_gol";
            this.Y_gol.ReadOnly = true;
            this.Y_gol.Width = 50;
            // 
            // pnl_transfer
            // 
            this.pnl_transfer.Controls.Add(this.listView1);
            this.pnl_transfer.Location = new System.Drawing.Point(10, 251);
            this.pnl_transfer.Name = "pnl_transfer";
            this.pnl_transfer.Size = new System.Drawing.Size(25, 20);
            this.pnl_transfer.TabIndex = 7;
            this.pnl_transfer.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.iddd,
            this.OyuncuAdi,
            this.Takimd});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(43, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(739, 323);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iddd
            // 
            this.iddd.Text = "id";
            this.iddd.Width = 30;
            // 
            // OyuncuAdi
            // 
            this.OyuncuAdi.Text = "Oyuncu Adı";
            this.OyuncuAdi.Width = 100;
            // 
            // Takimd
            // 
            this.Takimd.Text = "Takım";
            this.Takimd.Width = 120;
            // 
            // pnl_yeni_oyun
            // 
            this.pnl_yeni_oyun.Controls.Add(this.button2);
            this.pnl_yeni_oyun.Controls.Add(this.combo_takim);
            this.pnl_yeni_oyun.Controls.Add(this.label5);
            this.pnl_yeni_oyun.Controls.Add(this.combo_lig);
            this.pnl_yeni_oyun.Controls.Add(this.label3);
            this.pnl_yeni_oyun.Controls.Add(this.label2);
            this.pnl_yeni_oyun.Controls.Add(this.textBox2);
            this.pnl_yeni_oyun.Controls.Add(this.label1);
            this.pnl_yeni_oyun.Controls.Add(this.textBox1);
            this.pnl_yeni_oyun.Location = new System.Drawing.Point(107, 36);
            this.pnl_yeni_oyun.Name = "pnl_yeni_oyun";
            this.pnl_yeni_oyun.Size = new System.Drawing.Size(1145, 685);
            this.pnl_yeni_oyun.TabIndex = 8;
            // 
            // combo_takim
            // 
            this.combo_takim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_takim.FormattingEnabled = true;
            this.combo_takim.Location = new System.Drawing.Point(194, 156);
            this.combo_takim.Name = "combo_takim";
            this.combo_takim.Size = new System.Drawing.Size(116, 21);
            this.combo_takim.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(56, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "TAKIM :";
            // 
            // combo_lig
            // 
            this.combo_lig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_lig.FormattingEnabled = true;
            this.combo_lig.Location = new System.Drawing.Point(194, 116);
            this.combo_lig.Name = "combo_lig";
            this.combo_lig.Size = new System.Drawing.Size(116, 21);
            this.combo_lig.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(56, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "LİG :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(56, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYADINIZ :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 24);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADINIZ :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 24);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(60, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pnl_yeni_oyun);
            this.Controls.Add(this.pnl_transfer);
            this.Controls.Add(this.pnl_lig_t);
            this.Controls.Add(this.pnl_mesaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pnl_Fixtur);
            this.Controls.Add(this.pnl_taktik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_taktik.ResumeLayout(false);
            this.pnl_lig_t.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_transfer.ResumeLayout(false);
            this.pnl_yeni_oyun.ResumeLayout(false);
            this.pnl_yeni_oyun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taktikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_taktik;
        private controller.cont_taktik_oyuncu_listesi cont_taktik_oyuncu_listesi1;
        private controller.cont_taktik_pozisyon cont_taktik_pozisyon1;
        private System.Windows.Forms.Panel pnl_Fixtur;
        private controller.Fixtur fixtur1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_mesaj;
        private System.Windows.Forms.Panel pnl_lig_t;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Takim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Averaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_gol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_gol;
        private System.Windows.Forms.Panel pnl_transfer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader OyuncuAdi;
        private System.Windows.Forms.ColumnHeader Takimd;
        private System.Windows.Forms.ColumnHeader iddd;
        private System.Windows.Forms.Panel pnl_yeni_oyun;
        private System.Windows.Forms.ComboBox combo_takim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_lig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;

    }
}

