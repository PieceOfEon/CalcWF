using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWF
{
    public partial class Form1 : Form
    {
        public string kop;
        public string[] mas;
        public int rezult=0;
        public int kol = 0;
        public string deistvie;
        public int umnoj = 0;
        public int del = 0;
        public string oh;
        public int q = 0;
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
            kop = vvod.Text;
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
            print.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
         if(vvod.Text.Length>0)
                vvod.Text=vvod.Text.Remove(vvod.Text.Length-1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
           
                mas = vvod.Text.Split('+', '-', '*', '/');
                if (mas[0].Length != 0)
                {
                    q = Convert.ToInt32(mas[0]);
                }
                for (int i = 0; i < vvod.Text.Length - 1; i++)
                {
                    if (vvod.Text[i] == '+')
                    {
                        deistvie += '+';
                    }
                    if (vvod.Text[i] == '-')
                    {
                        deistvie += '-';
                    }
                    if (vvod.Text[i] == '*')
                    {
                        deistvie += '*';
                    }
                    if (vvod.Text[i] == '/')
                    {
                        deistvie += '/';
                    }
                }
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                for (int i = 0; i < deistvie.Length; i++)
                {
                    if (deistvie[i] == '+')
                    {
                        //kol--;
                        if (i + 1 <= deistvie.Length - 1)
                        {
                            if (deistvie[i + 1] == '*')
                            {
                                kol++;
                                umnoj += Convert.ToInt32(mas[kol]) * Convert.ToInt32(mas[kol + 1]);
                                q += umnoj;
                                q -= Convert.ToInt32(mas[kol + 1]);
                                umnoj = 0;
                            }
                            if (deistvie[i + 1] == '/')
                            {
                                kol++;

                                del += Convert.ToInt32(mas[kol]) / Convert.ToInt32(mas[kol + 1]);
                                q += del;
                                q -= Convert.ToInt32(mas[kol + 1]);
                                del = 0;
                            }
                        }
                        kol++;
                        try
                        {
                            if (kol < mas.Length)
                                q += Convert.ToInt32(mas[kol]);
                            else
                            {
                                kol--;
                                q += Convert.ToInt32(mas[kol]);
                            }
                        }
                        catch (Exception) { }


                    }
                    if (deistvie[i] == '-')
                    {

                        if (i + 1 <= deistvie.Length - 1)
                        {

                            if (deistvie[i + 1] == '*')
                            {
                                kol++;
                                if (kol < mas.Length)
                                    umnoj += Convert.ToInt32(mas[kol]) * Convert.ToInt32(mas[kol + 1]);
                                q -= umnoj;
                                if (kol < mas.Length)
                                    q += Convert.ToInt32(mas[kol + 1]);
                                umnoj = 0;
                            }
                            if (deistvie[i + 1] == '/')
                            {
                                kol++;
                                if (kol < mas.Length - 1)
                                    del += Convert.ToInt32(mas[kol]) / Convert.ToInt32(mas[kol + 1]);
                                q -= del;
                                if (kol < mas.Length - 1)
                                    q += Convert.ToInt32(mas[kol + 1]);

                                del = 0;
                            }
                        }
                        kol++; try
                        {
                            if (kol < mas.Length)
                                q -= Convert.ToInt32(mas[kol]);

                        }
                        catch (Exception) { }


                    }
                    if (deistvie[i] == '*')
                    {
                        if (i + 1 <= deistvie.Length - 1)
                        {
                            if (deistvie[i + 1] == '*' || deistvie[i + 1] == '/')
                            {
                                if (i - 1 >= 0)
                                {
                                    if (deistvie[i - 1] == '-' || deistvie[i - 1] == '+')
                                    {
                                        oh = mas[kol - 2];
                                        q -= Convert.ToInt32(mas[kol - 2]);
                                    }
                                }
                            }
                        }

                        if (i - 1 >= 0)
                        {

                            if (deistvie[i - 1] == '/')
                            {
                                kol++;
                                if (kol < mas.Length - 1)
                                    q *= Convert.ToInt32(mas[kol]);
                            }
                        }
                        else
                        {

                            kol++;
                        try
                        {
                            if (kol < mas.Length)

                                q *= Convert.ToInt32(mas[kol]);
                        }catch(Exception ) { }

                    }
                    }
                    if (deistvie[i] == '/')
                    {
                        try
                        {
                            if (i + 1 <= deistvie.Length - 1)
                            {
                                if (deistvie[i + 1] == '*' || deistvie[i + 1] == '/')
                                {
                                    if (deistvie[i - 1] == '-' || deistvie[i - 1] == '+')
                                    {
                                        oh = mas[kol - 2];
                                        q -= Convert.ToInt32(mas[kol - 2]);
                                    }
                                }
                            }
                            if (i - 1 >= 0)
                            {
                                if (deistvie[i - 1] == '*')
                                {
                                    if (kol < mas.Length - 1)
                                        kol++;
                                    q /= Convert.ToInt32(mas[kol]);
                                }
                            }
                            else
                            {
                                kol++;
                                if (kol < mas.Length)
                                    q /= Convert.ToInt32(mas[kol]);
                            }
                        }
                        catch (Exception G) { q = 0; MessageBox.Show(G.Message); }

                    }
                    if (i < deistvie.Length - 1)
                    {
                        if (deistvie[i] == '*' || deistvie[i] == '/')
                        {
                            if (deistvie[i + 1] == '-' || deistvie[i + 1] == '+')
                            {
                                if (kol < deistvie.Length)
                                    if (oh.Length > 0)
                                        q += Convert.ToInt32(oh);
                            }
                        }
                    }
                }
                print.Text = Convert.ToString(q);
                q = 0;
                kol = 0;
                oh = "";
                deistvie = "";
         
        }
        private void print_Click(object sender, EventArgs e)
        {
            
        }

        private void vvod_Click(object sender, EventArgs e)
        {

        }
    }
}
