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
    public partial class Form2 : Form
    {
        public delegate void CreateUpdateEventHandler(int nilaiA, int nilaiB, int index);

        public event CreateUpdateEventHandler Perhitungan;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(textBox1.Text);
            var b = Convert.ToInt32(textBox2.Text);

            Perhitungan(a, b, comboBox1.SelectedIndex);
        }
    }
}
