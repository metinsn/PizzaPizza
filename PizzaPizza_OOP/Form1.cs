using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPizza_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int siparisSayac = 1;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Siparis sp = new Siparis();
            Pizza pz = new Pizza();

            sp.SiparisID = siparisSayac;
            siparisSayac++;

            pz.Boyut = CBoxPizzaBoyut.SelectedItem.ToString();
            pz.KalinMi = RadioBtnKalinKenar.Checked == true ? true : false;
            pz.Isim = CBoxPizzaTuru.SelectedItem.ToString();
            pz.Adet = Convert.ToInt32(NumPizzaAdet.Value);

            foreach (Control item in GBoXMalzemeler.Controls)
            {
                CheckBox chbox = new CheckBox();
                if (item is CheckBox)
                {
                    chbox = (CheckBox)item;
                    if (chbox.Checked == true)
                    {
                        Malzeme ml = new Malzeme();
                        ml.Isim = chbox.Text;
                        pz.Malzemeler.Add(ml);
                    }
                }
            }

            sp.Pizzalar.Add(pz);
            sp.ToplamFiyat += pz.Fiyat;

            LstBoxSiparis.Items.Add(sp);

            TxtToplamTutar.Text = sp.ToplamFiyat.ToString();
        }

        private void LstBoxSiparis_DoubleClick(object sender, EventArgs e)
        {
            Siparis sp = (Siparis)LstBoxSiparis.SelectedItem;
            string cikti = "Malzemeler\n";

            for (int i = 0; i < sp.Pizzalar.Count; i++)
            {
                cikti += "\nPizza Adı : " + sp.Pizzalar[i].Isim;

                for (int j = 0; j < sp.Pizzalar[i].Malzemeler.Count; j++)
                {
                    cikti += "\n" + (j + 1) + ". " + sp.Pizzalar[i].Malzemeler[j].Isim;
                }
            }

            MessageBox.Show(cikti);
        }
    }
}
