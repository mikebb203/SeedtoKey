using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeedtoKey
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int algo;
            UInt16 seed;

            algo = int.Parse(Algo.Text, System.Globalization.NumberStyles.HexNumber);
            seed = UInt16.Parse(Seed.Text, System.Globalization.NumberStyles.HexNumber);

            UInt16 key = KeyAlgorithm.GetKey(algo, seed);

            Key.Text = key.ToString("X"); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
