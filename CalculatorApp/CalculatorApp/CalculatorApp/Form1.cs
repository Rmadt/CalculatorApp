using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form2_Perhitungan(int nilaiA, int nilaiB, int index)
        {
            int hasil;

            if (index == 0)
            {
                hasil = nilaiA + nilaiB;
                listBox1.Items.Add(string.Format("Hasil penjumlahan {0} + {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 1)
            {
                hasil = nilaiA - nilaiB;
                listBox1.Items.Add(string.Format("Hasil pengurangan {0} - {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 2)
            {
                hasil = nilaiA * nilaiB;
                listBox1.Items.Add(string.Format("Hasil perkalian {0} * {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 3)
            {
                hasil = nilaiA / nilaiB;
                listBox1.Items.Add(string.Format("Hasil pembagian {0} / {1} = {2}", nilaiA, nilaiB, hasil));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Perhitungan += Form2_Perhitungan;

            frm.ShowDialog();
        }
    }
}
