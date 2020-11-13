using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Pekaru p = (Pekaru)lbox_pekaruk.SelectedItem;
            tbox_pekarunev.Text = p.Nev;
            tbox_ar.Text = Convert.ToString(p.Ar);
            chbox_laktoz.Checked = p.Laktozmentes;

        }
    }
}
