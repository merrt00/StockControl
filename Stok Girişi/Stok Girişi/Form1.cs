using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Girişi
{
    public partial class STOKGİRİŞ : Form
    {
        int i = 0;
        string[] dizi = new string[10034];
        public STOKGİRİŞ()
        {
            InitializeComponent();
        }

        private void STOKGİRİŞ_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 100)
            {
                dizi[i] = txtVeri.Text;
                lstBVeriler.Items.Add(dizi[i]);
                i++;
                txtVeri.Clear();
                txtVeri.Focus();
            }

        }
    }
}
