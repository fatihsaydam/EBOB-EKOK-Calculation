using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbobEkokHesaplamasi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEbob_Click(object sender, EventArgs e)
        {
            if (txtSayi1.Text == string.Empty || txtSayi2.Text == string.Empty)
                MessageBox.Show("Sayıları giriniz!", "Ebob - Ekok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int sayi1 = int.Parse(txtSayi1.Text);
                int sayi2 = int.Parse(txtSayi2.Text);
                int bolen = 2, obeb = 1;
                while (sayi1 > 1 || sayi2 > 1)
                {
                    if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                    {
                        obeb *= bolen;
                        sayi1 /= bolen;
                        sayi2 /= bolen;
                    }
                    else if (sayi1 % bolen == 0)
                    {
                        sayi1 /= bolen;
                    }
                    else if (sayi2 % bolen == 0)
                        sayi2 /= bolen;
                    else
                        bolen++;
                }
                lblEbobSonuc.Text += obeb;
            }
        }

        private void btnEkok_Click(object sender, EventArgs e)
        {
            if (txtSayi1.Text == string.Empty || txtSayi2.Text == string.Empty)
                MessageBox.Show("Sayıları giriniz!", "Ebob - Ekok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int sayi1 = int.Parse(txtSayi1.Text);
                int sayi2 = int.Parse(txtSayi2.Text);
                int bolen = 2, ekok = 1;
                while (sayi1 > 1 || sayi2 > 1)
                {
                    if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                    {
                        sayi1 /= bolen;
                        sayi2 /= bolen;
                        ekok *= bolen;
                    }
                    else if (sayi1 % bolen == 0)
                    {
                        sayi1 /= bolen;
                        ekok *= bolen;
                    }

                    else if (sayi2 % bolen == 0)
                    {
                        sayi2 /= bolen;
                        ekok *= bolen;
                    }
                    else
                        bolen++;
                }
                lblEkokSonuc.Text += ekok;
            }
        }

        private void txtTemizle_Click(object sender, EventArgs e)
        {
            txtSayi1.Text = txtSayi2.Text = "";
        }
    }
}
