using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rnd;
        int tahminSayisi = 0;
        Random r;
        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();
            rnd = r.Next(1, 101);
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            tahminSayisi++;

            int tahmin = int.Parse(txtTahmin.Text);

            if (tahmin == rnd)
            {
                var cevap = MessageBox.Show($"Doğru tahmin ettin kerata {tahminSayisi} denemede bildin. tekrar oyna la", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.No)
                {
                    this.Close();
                }
                else if (cevap == DialogResult.Yes)
                {
                    rnd = r.Next(1, 101);
                    tahminSayisi = 0;
                }
            }
            else if (tahmin > rnd)
            {
                MessageBox.Show("daha küçük sayı gir");

            }
            else if (tahmin < rnd)
            {
                MessageBox.Show("Daha büyük sayı gir");
            }
            txtTahmin.Text = "";
            txtTahmin.Focus();

        }

        private void txtTahmin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTahmin.PerformClick();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtTahmin.Focus();
        }
    }
}
