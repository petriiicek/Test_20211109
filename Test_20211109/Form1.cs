using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Banka banka;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banka = new Banka("Vítek Němec" ,10000, 150000 );
            labelJmeno.Text = banka.Jmeno;
            label_limit_platba.Text = "Limit pro platbu je " + banka.LimitPlatba.ToString();
            label_limit_vklad.Text = "Limit pro vklad je " + banka.LimitVklad.ToString();

        }
        private void vklad_Click(object sender, EventArgs e)
        {
            try
            {
                int castka = int.Parse(texbox_castka.Text);
                banka.Vklad(castka);
                label_
            }
            
            
        }

        private void vyber_Click(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void stav_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxJmeno_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
