using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            vvod.Text = vvod.Text + "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vvod.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
         if(vvod.Text.Length>0)
                vvod.Text=vvod.Text.Remove(vvod.Text.Length-1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
