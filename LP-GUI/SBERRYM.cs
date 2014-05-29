﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP50Touch
{
    public partial class SBERRYM : Form
    {



        public SBERRYM()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void SBERRYM_Load_1(object sender, EventArgs e)
        {
            try
            {
                string price = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrymPrice.txt");
                string barcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrymBarcode.txt");
                string name = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrymName.txt");
                label12.Text = name.ToString();
                label7.Text = barcode.ToString();
                label8.Text = price.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Има грешка в базата!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                File.WriteAllText(@"C:\LP-50Touch\PriceList\sberrymName.txt", String.Empty);
                string name = textBox3.Text.ToString();
                System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\sberrymName.txt", name, Encoding.UTF8);
            }
            if (textBox2.Text != "")
            {
                File.WriteAllText(@"C:\LP-50Touch\PriceList\sberrymPrice.txt", String.Empty);
                string price = textBox2.Text.ToString();
                System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\sberrymPrice.txt", price, Encoding.UTF8);
            }
            if (textBox1.Text != "")
            {
                File.WriteAllText(@"C:\LP-50Touch\PriceList\sberrymBarcode.txt", String.Empty);
                string barcode = textBox1.Text.ToString();
                System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\sberrymBarcode.txt", barcode, Encoding.UTF8);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
