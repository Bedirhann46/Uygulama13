using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Uygulama13
{
    public partial class Form1 : Form
    {
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNesneEkle_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(txtNumaraN.Text);
            ogrenci.AdiSoyadi = txtAdSoyadN.Text;
            if (radioButton2.Checked) ogrenci.Cinsiyet = true;
            else ogrenci.Cinsiyet = false;
            ogrencilerList.Add(ogrenci);
            listBox1.Items.Clear();
            foreach (var item in ogrencilerList)
            {
                if ((item.Cinsiyet)) cinsiyet = "Bay";
                else cinsiyet = "Bayan";
                listBox1.Items.Add(item.Numara + " " + item.AdiSoyadi + " " + cinsiyet);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
