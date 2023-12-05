using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace isim_yazma
{
    public partial class Form1 : Form
    {
        List<string> kisiler = new List<string>();
        int indexsira =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiler.Add("irem");
            kisiler.Add("ela");
            kisiler.Add("kumsal");

            lbIsim.DataSource = kisiler.ToList();
        }

        private void lbIsim_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIsim.Text = lbIsim.SelectedValue.ToString();
            indexsira = lbIsim.SelectedIndex;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtIsim.Text);
            lbIsim.DataSource = kisiler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtIsim.Text);
            if (durum)
            {
                MessageBox.Show("Aradığınız kişi mevcut"); 
               
            
                
            }
            else
            {
                MessageBox.Show("Aradığınız kişi mevcut değil");
            }
        }

        private void btnSira_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtIsim.Text);
            if (sira > -1)
            {
                MessageBox.Show(txtIsim.Text + " " + sira + ". sırasındadır.");
            }
            else
            {
                MessageBox.Show("aradığın kişi yoktur");

            }


                
               

                
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtIsim.Text);
            if (sira >-1)
            {
                kisiler.RemoveAt(sira);
            }
            lbIsim.DataSource = kisiler.ToList();
        }

        private void btngüncel_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtIsim.Text);
            if (durum)
            {
                kisiler.Remove (txtIsim.Text);
                
            }
            lbIsim.DataSource = kisiler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(indexsira.ToString());
            indexsira = lbIsim.SelectedIndex;
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            kisiler[indexsira] = txtIsim.Text;

            lbIsim.DataSource = kisiler.ToList ();
        }

        private void btnArtan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            lbIsim.DataSource =kisiler.ToList ();
        }

        private void btnAzalan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            kisiler.Reverse();
            lbIsim.DataSource=kisiler.ToList ();
        }

        private void btnHarf_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Length == 5)
                {
                    sayac++;
                }
                MessageBox.Show("5 Karakterli :" + sayac + "tane öğrenci mevcut");
            }   
        }

        private void btnMharf_Click(object sender, EventArgs e)
        {
            int sayac =0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                MessageBox.Show(kisiler[i]);
                if (kisiler[i][0] == 'm')
                if (kisiler[i].Length == 5)
                {
                    sayac++;
                }
                MessageBox.Show("m karakterli:" + " +sayac+ tane ögrenci mevcut"); 
            }

        }

        private void btnTemizleme_Click(object sender, EventArgs e)
        {
            kisiler.Clear();
        }
    }
}
    