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
            this.btn_peknev = new System.Windows.Forms.Button();
            this.tbox_peksegnev = new System.Windows.Forms.TextBox();
            this.gbox_pekaruk = new System.Windows.Forms.GroupBox();
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
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbox_pekaruk.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.btn_peknev);
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
            // 
            // btn_peknev
            // 
            this.btn_peknev.Location = new System.Drawing.Point(7, 45);
            this.btn_peknev.Name = "btn_peknev";
            this.btn_peknev.Size = new System.Drawing.Size(88, 23);
            this.btn_peknev.TabIndex = 5;
            this.btn_peknev.Text = "Hozzáadás";
            this.btn_peknev.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBox4);
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
            this.label7.Location = new System.Drawing.Point(209, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Laktózmentes termékek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Legolcsóbb termék:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Legdrágább termék:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Átlagos ár:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pékáruk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alapítva:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "péknév";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(6, 6);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(197, 173);
            this.listBox4.TabIndex = 7;
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
        private System.Windows.Forms.Button btn_peknev;
        private System.Windows.Forms.TextBox tbox_peksegnev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
    }
}

