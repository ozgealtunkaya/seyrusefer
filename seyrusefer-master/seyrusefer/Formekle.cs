using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyrusefer
{
    public partial class Formekle : Form
    {
        public Formekle()
        {
            InitializeComponent();
        }

        private void Formekle_Load(object sender, EventArgs e)
        {

        }

        private void EKLE_Click(object sender, EventArgs e)
        {   
            /*
            dataGridView1.ColumnCount = 9;

            dataGridView1.Columns[0].Name = "Sefer No";
            dataGridView1.Columns[1].Name = "Nereden";
            dataGridView1.Columns[2].Name = "Nereye";
            dataGridView1.Columns[3].Name = "Tarih";
            dataGridView1.Columns[4].Name = "Saat";
            dataGridView1.Columns[5].Name = "Kapasite";
            dataGridView1.Columns[6].Name = "Kaptan";
            dataGridView1.Columns[7].Name = "Plaka";
            dataGridView1.Columns[8].Name = "Bilet Fiyatı";


            string seferno = textBox1.Text;
            string nereden = textBox2.Text;
            string nereye = textBox3.Text;
            string tarih = textBox4.Text;
            string saat = textBox5.Text;
            string kapasite = textBox6.Text;
            string kaptan = textBox7.Text;
            string plaka = textBox8.Text;
            string biletfiyat = textBox9.Text;


            dataGridView1.Rows.Add(seferno, nereden, nereye, tarih, saat, kapasite, kaptan, plaka, biletfiyat);
            */


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
