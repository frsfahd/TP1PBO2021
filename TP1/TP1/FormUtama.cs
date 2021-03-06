using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP1
{
    public partial class FormUtama : Form
    {       
        Barang b1 = new Barang();
        Barang b2 = new Barang();
        Barang b3 = new Barang();
        Barang b4 = new Barang();
        Barang b5 = new Barang();
        public FormUtama()
        {
            InitializeComponent();
            panel3.Visible = false;



            b1.set_jenisBarang("elektronik");
            b1.set_harga(500000);
            b1.set_namaBarang("Acer Nitro Gaming Mouse");

            b2.set_jenisBarang("elektronik");
            b2.set_harga(300000);
            b2.set_namaBarang("HP Gaming Mouse");

            b3.set_jenisBarang("pakaian");
            b3.set_harga(1000000);
            b3.set_namaBarang("Bulletproof Vest");

            b4.set_jenisBarang("pakaian");
            b4.set_harga(750000);
            b4.set_namaBarang("M36 Wehrmacht Jacket");

            b5.set_jenisBarang("makanan");
            b5.set_harga(190000);
            b5.set_namaBarang("US Military Ration");
        }
       
        

        
        

        private void btnCari_Click(object sender, EventArgs e)
        {
            Pencarian p = new Pencarian();
            p.set_jenisBarang(cbJenisBarang.Items[cbJenisBarang.SelectedIndex].ToString());
            p.set_harga(cbHarga.Items[cbHarga.SelectedIndex].ToString());
            
            panelB1.Visible = false;
            panelB2.Visible = false;
            panelB3.Visible = false;
            panelB4.Visible = false;
            panelB5.Visible = false;

           

            if (b1.get_jenisBarang() == p.get_jenisBarang() && p.get_harga()== "200rb - 500rb")
            {
                panelB1.Visible = true;
            }
            if(b2.get_jenisBarang() == p.get_jenisBarang() && p.get_harga() == "200rb - 500rb")
            {
                panelB2.Visible = true;
            }
            if(b3.get_jenisBarang() == p.get_jenisBarang() && p.get_harga() == "500rb - 1jt")
            {
                panelB3.Visible = true;
            }
            if(b4.get_jenisBarang() == p.get_jenisBarang() && p.get_harga() == "500rb - 1jt")
            {
                panelB4.Visible = true;
            }
            if(b5.get_jenisBarang() == p.get_jenisBarang() && p.get_harga() == "100rb - 200rb")
            {
                panelB5.Visible = true;
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panelB1.Visible = true;
            panelB2.Visible = true;
            panelB3.Visible = true;
            panelB4.Visible = true;
            panelB5.Visible = true;
        }

       

      
        private void btnBeliB4_Click_1(object sender, EventArgs e)
        {

            panelB1.Visible = false;
            panelB2.Visible = false;
            panelB3.Visible = false;
            panelB4.Visible = false;
            panelB5.Visible = false;
            panel3.Visible = true;
            panelBeliB1.Visible = false;
            panelBeliB2.Visible = false;
            panelBeliB3.Visible = false;
            panelBeliB5.Visible = false;
            panelBeliB4.Visible = true;
        }

        private void btnBeliB1_Click(object sender, EventArgs e)
        {

            panelB1.Visible = false;
            panelB2.Visible = false;
            panelB3.Visible = false;
            panelB4.Visible = false;
            panelB5.Visible = false;
            panel3.Visible = true;
            panelBeliB4.Visible = false;
            panelBeliB2.Visible = false;
            panelBeliB5.Visible = false;
            panelBeliB3.Visible = false;
            panelBeliB1.Visible = true;
        }

        private void btnBeliB2_Click(object sender, EventArgs e)
        {
            panelB1.Visible = false;
            panelB2.Visible = false;
            panelB3.Visible = false;
            panelB4.Visible = false;
            panelB5.Visible = false;
            panel3.Visible = true;
            panelBeliB4.Visible = false;
            panelBeliB1.Visible = false;
            panelBeliB5.Visible = false;
            panelBeliB3.Visible = false;
            panelBeliB2.Visible = true;
        }

        private void btnBeliB3_Click(object sender, EventArgs e)
        {
            panelB1.Visible = false;
            panelB2.Visible = false;
            panelB3.Visible = false;
            panelB4.Visible = false;
            panelB5.Visible = false;
            panel3.Visible = true;
            panelBeliB4.Visible = false;
            panelBeliB1.Visible = false;
            panelBeliB5.Visible = false;
            panelBeliB2.Visible = false;
            panelBeliB3.Visible = true;
        }

        private void btnBeliB5_Click(object sender, EventArgs e)
        {

            panelB1.Visible = false;
            panelB2.Visible = false;
            panelB3.Visible = false;
            panelB4.Visible = false;
            panelB5.Visible = false;
            panel3.Visible = true;
            panelBeliB4.Visible = false;
            panelBeliB1.Visible = false;
            panelBeliB2.Visible = false;
            panelBeliB3.Visible = false;
            panelBeliB5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }
        
       
    }
 
}
