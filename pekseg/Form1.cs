using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pekseg
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {
            lbox_pekaruk.Items.Add(new Pekaru(tbox_pekarunev.Text, Convert.ToInt32(tbox_ar.Text), chbox_laktoz.Checked));
        }

        private void lbox_pekaruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_pekaruk.SelectedItem == null)
            {

            }
            else
            {
                Pekaru p = (Pekaru)lbox_pekaruk.SelectedItem;
                tbox_pekarunev.Text = p.Nev;
                tbox_ar.Text = Convert.ToString(p.Ar);
                chbox_laktoz.Checked = p.Laktozmentes;
                btn_del.Visible = true;
                btn_edit.Visible = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbox_peksegek.Items.Count; i++)
            {
                Pekseg p = (Pekseg)lbox_peksegek.Items[i];
                for (int j = 0; j < p.Termekek.Count; j++)
                {
                    if (p.Termekek[i].Equals(lbox_pekaruk.SelectedItem))
                    {
                        p.Termekek.Remove(p.Termekek[i]);
                    }
                }
            }
            lbox_pekaruk.Items.RemoveAt(lbox_pekaruk.SelectedIndex);

            tbox_pekarunev.Text = "";
            tbox_ar.Text = "";
            chbox_laktoz.Checked = false;
            btn_del.Visible = false;
            btn_edit.Visible = false;

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            Pekaru p2 = new Pekaru(tbox_pekarunev.Text, Convert.ToInt32(tbox_ar.Text), chbox_laktoz.Checked);

            lbox_pekaruk.Items[lbox_pekaruk.SelectedIndex] = p2;
            btn_del.Visible = false;
            btn_edit.Visible = false;

        }

        private void btn_pekletrehoz_Click(object sender, EventArgs e)
        {
            List<Pekaru> pekaruk = new List<Pekaru>();
            Pekseg pek = new Pekseg(tbox_peksegnev.Text, pekaruk, DateTime.Now);
            lbox_peksegek.Items.Add(pek);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pekseg pekseg = (Pekseg)lbox_peksegek.SelectedItem;
            Pekaru pekaru = (Pekaru)lbox_pekaruk.SelectedItem;
            pekseg.Termekek.Add(pekaru);
            lbox_pekaruja.Items.Add(pekaru);
        }

        private void lbox_peksegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbox_pekaruja.Items.Clear();
            Pekseg pekseg = (Pekseg)lbox_peksegek.SelectedItem;
            if (pekseg != null)
            {
                for (int i = 0; i < pekseg.Termekek.Count; i++)
                {
                    lbox_pekaruja.Items.Add(pekseg.Termekek[i]);
                }
            }
           

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbox_statpeksegek.Items.Clear();
            for (int i = 0; i < lbox_peksegek.Items.Count; i++)
            {
                lbox_statpeksegek.Items.Add(lbox_peksegek.Items[i]);
            }

        }

        private void lbox_statpeksegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pekseg pek = (Pekseg)lbox_statpeksegek.SelectedItem;

            stat_peknev.Text = pek.Nev;
            stat_alapitva.Value = pek.Alapitva;
            if (pek.Termekek.Count > 0)
            {
                stat_db.Value = pek.Termekek.Count;
                double osszar = 0;
                for (int i = 0; i < pek.Termekek.Count; i++)
                {
                    osszar += pek.Termekek[i].Ar;
                }
                double atlag = Math.Round((osszar / pek.Termekek.Count), 2);
                stat_atlagar.Text = Convert.ToString(atlag);
                Pekaru legolcsobb = pek.Termekek[0];
                for (int i = 0; i < pek.Termekek.Count; i++)
                {
                    if (legolcsobb.Ar < pek.Termekek[i].Ar)
                    {
                        legolcsobb = pek.Termekek[i];
                    }
                }
                string olcsobb = string.Format("{0} ({1}Ft / db)", legolcsobb.Nev, legolcsobb.Ar);
                stat_legolcsobb.Text = olcsobb;

                Pekaru legdragabb = pek.Termekek[0];
                for (int i = 0; i < pek.Termekek.Count; i++)
                {
                    if (legdragabb.Ar > pek.Termekek[i].Ar)
                        legdragabb = pek.Termekek[i];
                }
                string dragabb = string.Format("{0} ({1}Ft / db)", legdragabb.Nev, legdragabb.Ar);
                stat_legdragabb.Text = dragabb;

                double laktozmentes = 0;
                double db = pek.Termekek.Count;
                for (int i = 0; i < pek.Termekek.Count; i++)
                {
                    if (pek.Termekek[i].Laktozmentes == true)
                    {
                        laktozmentes++;
                    }
                }
                String laktozmentesszoveg = string.Format("{0} db laktozmentes, {1}%", laktozmentes, (laktozmentes / db) * 100);
                stat_laktozmentes.Text = laktozmentesszoveg;
            }
            else
            {
                stat_db.Value = 0;
                stat_atlagar.Text = " ";
                stat_legolcsobb.Text = " ";
                stat_legdragabb.Text = " ";
                stat_laktozmentes.Text = "";
                
            }
          
           
           
            
        }
        }
}

