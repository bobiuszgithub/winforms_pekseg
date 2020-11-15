namespace pekseg
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lbox_pekaruja = new System.Windows.Forms.ListBox();
            this.lbox_peksegek = new System.Windows.Forms.ListBox();
            this.btn_pekletrehoz = new System.Windows.Forms.Button();
            this.tbox_peksegnev = new System.Windows.Forms.TextBox();
            this.gbox_pekaruk = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.lbox_pekaruk = new System.Windows.Forms.ListBox();
            this.chbox_laktoz = new System.Windows.Forms.CheckBox();
            this.tbox_ar = new System.Windows.Forms.TextBox();
            this.tbox_pekarunev = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_statpeksegek = new System.Windows.Forms.ListBox();
            this.stat_alapitva = new System.Windows.Forms.DateTimePicker();
            this.stat_db = new System.Windows.Forms.NumericUpDown();
            this.stat_avgar = new System.Windows.Forms.NumericUpDown();
            this.stat_peknev = new System.Windows.Forms.TextBox();
            this.stat_legolcsobb = new System.Windows.Forms.TextBox();
            this.stat_legdragabb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.stat_laktozmentes = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbox_pekaruk.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stat_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_avgar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_laktozmentes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 448);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gbox_pekaruk);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adatok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lbox_pekaruja);
            this.groupBox2.Controls.Add(this.lbox_peksegek);
            this.groupBox2.Controls.Add(this.btn_pekletrehoz);
            this.groupBox2.Controls.Add(this.tbox_peksegnev);
            this.groupBox2.Location = new System.Drawing.Point(6, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pékségek";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(466, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbox_pekaruja
            // 
            this.lbox_pekaruja.FormattingEnabled = true;
            this.lbox_pekaruja.Location = new System.Drawing.Point(406, 19);
            this.lbox_pekaruja.Name = "lbox_pekaruja";
            this.lbox_pekaruja.Size = new System.Drawing.Size(197, 173);
            this.lbox_pekaruja.TabIndex = 6;
            // 
            // lbox_peksegek
            // 
            this.lbox_peksegek.FormattingEnabled = true;
            this.lbox_peksegek.Location = new System.Drawing.Point(148, 19);
            this.lbox_peksegek.Name = "lbox_peksegek";
            this.lbox_peksegek.Size = new System.Drawing.Size(252, 238);
            this.lbox_peksegek.TabIndex = 5;
            this.lbox_peksegek.SelectedIndexChanged += new System.EventHandler(this.lbox_peksegek_SelectedIndexChanged);
            // 
            // btn_pekletrehoz
            // 
            this.btn_pekletrehoz.Location = new System.Drawing.Point(7, 45);
            this.btn_pekletrehoz.Name = "btn_pekletrehoz";
            this.btn_pekletrehoz.Size = new System.Drawing.Size(88, 23);
            this.btn_pekletrehoz.TabIndex = 5;
            this.btn_pekletrehoz.Text = "Hozzáadás";
            this.btn_pekletrehoz.UseVisualStyleBackColor = true;
            this.btn_pekletrehoz.Click += new System.EventHandler(this.btn_pekletrehoz_Click);
            // 
            // tbox_peksegnev
            // 
            this.tbox_peksegnev.Location = new System.Drawing.Point(7, 19);
            this.tbox_peksegnev.Name = "tbox_peksegnev";
            this.tbox_peksegnev.Size = new System.Drawing.Size(117, 20);
            this.tbox_peksegnev.TabIndex = 5;
            // 
            // gbox_pekaruk
            // 
            this.gbox_pekaruk.Controls.Add(this.btn_edit);
            this.gbox_pekaruk.Controls.Add(this.btn_del);
            this.gbox_pekaruk.Controls.Add(this.btn_hozzaad);
            this.gbox_pekaruk.Controls.Add(this.lbox_pekaruk);
            this.gbox_pekaruk.Controls.Add(this.chbox_laktoz);
            this.gbox_pekaruk.Controls.Add(this.tbox_ar);
            this.gbox_pekaruk.Controls.Add(this.tbox_pekarunev);
            this.gbox_pekaruk.Location = new System.Drawing.Point(6, 6);
            this.gbox_pekaruk.Name = "gbox_pekaruk";
            this.gbox_pekaruk.Size = new System.Drawing.Size(609, 130);
            this.gbox_pekaruk.TabIndex = 0;
            this.gbox_pekaruk.TabStop = false;
            this.gbox_pekaruk.Text = "Pékáruk";
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_edit.Location = new System.Drawing.Point(90, 72);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(52, 23);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Módosít";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Visible = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(90, 101);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(52, 23);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "Törlés";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Visible = false;
            this.btn_del.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(6, 101);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(88, 23);
            this.btn_hozzaad.TabIndex = 4;
            this.btn_hozzaad.Text = "Hozzáadás";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // lbox_pekaruk
            // 
            this.lbox_pekaruk.FormattingEnabled = true;
            this.lbox_pekaruk.Location = new System.Drawing.Point(148, 19);
            this.lbox_pekaruk.Name = "lbox_pekaruk";
            this.lbox_pekaruk.Size = new System.Drawing.Size(450, 108);
            this.lbox_pekaruk.TabIndex = 3;
            this.lbox_pekaruk.SelectedIndexChanged += new System.EventHandler(this.lbox_pekaruk_SelectedIndexChanged);
            // 
            // chbox_laktoz
            // 
            this.chbox_laktoz.AutoSize = true;
            this.chbox_laktoz.Location = new System.Drawing.Point(7, 72);
            this.chbox_laktoz.Name = "chbox_laktoz";
            this.chbox_laktoz.Size = new System.Drawing.Size(88, 17);
            this.chbox_laktoz.TabIndex = 2;
            this.chbox_laktoz.Text = "laktózmentes";
            this.chbox_laktoz.UseVisualStyleBackColor = true;
            // 
            // tbox_ar
            // 
            this.tbox_ar.Location = new System.Drawing.Point(6, 45);
            this.tbox_ar.Name = "tbox_ar";
            this.tbox_ar.Size = new System.Drawing.Size(100, 20);
            this.tbox_ar.TabIndex = 1;
            // 
            // tbox_pekarunev
            // 
            this.tbox_pekarunev.Location = new System.Drawing.Point(6, 19);
            this.tbox_pekarunev.Name = "tbox_pekarunev";
            this.tbox_pekarunev.Size = new System.Drawing.Size(100, 20);
            this.tbox_pekarunev.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.stat_laktozmentes);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.stat_legdragabb);
            this.tabPage2.Controls.Add(this.stat_legolcsobb);
            this.tabPage2.Controls.Add(this.stat_peknev);
            this.tabPage2.Controls.Add(this.stat_avgar);
            this.tabPage2.Controls.Add(this.stat_db);
            this.tabPage2.Controls.Add(this.stat_alapitva);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbox_statpeksegek);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statisztikák";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Laktózmentes termékek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Legolcsóbb termék:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Legdrágább termék:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Átlagos ár:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pékáruk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alapítva:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "péknév";
            // 
            // lbox_statpeksegek
            // 
            this.lbox_statpeksegek.FormattingEnabled = true;
            this.lbox_statpeksegek.Location = new System.Drawing.Point(6, 6);
            this.lbox_statpeksegek.Name = "lbox_statpeksegek";
            this.lbox_statpeksegek.Size = new System.Drawing.Size(197, 173);
            this.lbox_statpeksegek.TabIndex = 7;
            this.lbox_statpeksegek.SelectedIndexChanged += new System.EventHandler(this.lbox_statpeksegek_SelectedIndexChanged);
            // 
            // stat_alapitva
            // 
            this.stat_alapitva.Enabled = false;
            this.stat_alapitva.Location = new System.Drawing.Point(332, 31);
            this.stat_alapitva.Name = "stat_alapitva";
            this.stat_alapitva.Size = new System.Drawing.Size(200, 20);
            this.stat_alapitva.TabIndex = 16;
            // 
            // stat_db
            // 
            this.stat_db.Enabled = false;
            this.stat_db.Location = new System.Drawing.Point(332, 57);
            this.stat_db.Name = "stat_db";
            this.stat_db.Size = new System.Drawing.Size(67, 20);
            this.stat_db.TabIndex = 18;
            // 
            // stat_avgar
            // 
            this.stat_avgar.Enabled = false;
            this.stat_avgar.Location = new System.Drawing.Point(332, 82);
            this.stat_avgar.Name = "stat_avgar";
            this.stat_avgar.Size = new System.Drawing.Size(67, 20);
            this.stat_avgar.TabIndex = 19;
            // 
            // stat_peknev
            // 
            this.stat_peknev.Enabled = false;
            this.stat_peknev.Location = new System.Drawing.Point(332, 6);
            this.stat_peknev.Name = "stat_peknev";
            this.stat_peknev.Size = new System.Drawing.Size(100, 20);
            this.stat_peknev.TabIndex = 20;
            // 
            // stat_legolcsobb
            // 
            this.stat_legolcsobb.Enabled = false;
            this.stat_legolcsobb.Location = new System.Drawing.Point(332, 108);
            this.stat_legolcsobb.Name = "stat_legolcsobb";
            this.stat_legolcsobb.Size = new System.Drawing.Size(100, 20);
            this.stat_legolcsobb.TabIndex = 21;
            // 
            // stat_legdragabb
            // 
            this.stat_legdragabb.Enabled = false;
            this.stat_legdragabb.Location = new System.Drawing.Point(332, 134);
            this.stat_legdragabb.Name = "stat_legdragabb";
            this.stat_legdragabb.Size = new System.Drawing.Size(100, 20);
            this.stat_legdragabb.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "db";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ft";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "db";
            // 
            // stat_laktozmentes
            // 
            this.stat_laktozmentes.Enabled = false;
            this.stat_laktozmentes.Location = new System.Drawing.Point(332, 164);
            this.stat_laktozmentes.Name = "stat_laktozmentes";
            this.stat_laktozmentes.Size = new System.Drawing.Size(67, 20);
            this.stat_laktozmentes.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Pékség";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbox_pekaruk.ResumeLayout(false);
            this.gbox_pekaruk.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stat_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_avgar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_laktozmentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbox_pekaruk;
        private System.Windows.Forms.CheckBox chbox_laktoz;
        private System.Windows.Forms.TextBox tbox_ar;
        private System.Windows.Forms.TextBox tbox_pekarunev;
        private System.Windows.Forms.ListBox lbox_pekaruk;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbox_pekaruja;
        private System.Windows.Forms.ListBox lbox_peksegek;
        private System.Windows.Forms.Button btn_pekletrehoz;
        private System.Windows.Forms.TextBox tbox_peksegnev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox_statpeksegek;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DateTimePicker stat_alapitva;
        private System.Windows.Forms.NumericUpDown stat_avgar;
        private System.Windows.Forms.NumericUpDown stat_db;
        private System.Windows.Forms.TextBox stat_legdragabb;
        private System.Windows.Forms.TextBox stat_legolcsobb;
        private System.Windows.Forms.TextBox stat_peknev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown stat_laktozmentes;
    }
}

