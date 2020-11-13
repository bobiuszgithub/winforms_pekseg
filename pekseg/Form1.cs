using System;
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
            lbox_pekaruk.Items.RemoveAt(lbox_pekaruk.SelectedIndex);
            tbox_pekarunev.Text = "";
            tbox_ar.Text = "";
            chbox_laktoz.Checked = false;
            btn_del.Visible = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            Pekaru p2 = new Pekaru(tbox_pekarunev.Text, Convert.ToInt32(tbox_ar.Text), chbox_laktoz.Checked);

            lbox_pekaruk.Items[lbox_pekaruk.SelectedIndex] = p2;

        }
    }
}
