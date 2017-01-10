using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КУРСАЧ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public long h = new int();
        public long m = new int();
        public long s = new int();
        public long hmsc1 = new int();
        public long mmsc2 = new int();
        public long smsc3 = new int();
        public long h1 = new int();
        public long m1 = new int();
        public long s1 = new int();
       

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            label19.Text = "".ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox4.Text == "")
                {
                    h = 0;

                }
                else
                {
                    h = Convert.ToInt64(maskedTextBox4.Text);
                }
                if (maskedTextBox5.Text == "")
                {
                    m = 0;

                }
                else
                {
                    m = Convert.ToInt64(maskedTextBox5.Text);
                }
                if (maskedTextBox6.Text == "")
                {
                    s = 0;

                }
                else
                {
                    s = Convert.ToInt64(maskedTextBox6.Text);
                }
                if (h < 0 || m < 0 || s < 0)
                {
                    label19.Text = "Некорректно введены параметры".ToString();
                    h = 0;
                    m = 0;
                    s = 0;
                }
            }
            catch 
            { label19.Text = "Некорректно введены параметры".ToString(); };
            time T = new time(s,m,h);
           
            maskedTextBox1.Text = T.get_hour().ToString();
            maskedTextBox2.Text = T.get_min().ToString();
            maskedTextBox3.Text = T.get_sec().ToString();
            hmsc1 = T.get_hour();
            mmsc2 = T.get_min();
            smsc3 = T.get_sec();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox9.Text = "";
            maskedTextBox8.Text = "";
            maskedTextBox7.Text = "";
            label19.Text = "".ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
           
                if (maskedTextBox9.Text == "" )
                {
                    h = 0;

                }
                else
                {
                    h = Convert.ToInt64(maskedTextBox9.Text);
                }
                if (maskedTextBox8.Text == "")
                {
                    m = 0;

                }
                else
                {
                    m = Convert.ToInt64(maskedTextBox8.Text);
                }
                if (maskedTextBox7.Text == "")
                {
                    s = 0;

                }
                else
                {
                    s = Convert.ToInt64(maskedTextBox7.Text);
                }
                if (h < 0 || m < 0 || s < 0)
                {
                    label19.Text = "Некорректно введены параметры".ToString();
                    h = 0;
                    m = 0;
                    s = 0;
                }
            }
            catch { label19.Text = "Некорректно введены параметры".ToString(); }
            time T = new time(smsc3, mmsc2, hmsc1);
            time T1 = new time(s, m, h);
             T = T + T1;
             T1.normalize();
             maskedTextBox1.Text = T.get_hour().ToString();
             maskedTextBox2.Text = T.get_min().ToString();
             maskedTextBox3.Text = T.get_sec().ToString();
           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox12.Text = "";
            maskedTextBox11.Text = "";
            maskedTextBox10.Text = "";
            label19.Text = "".ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox12.Text == "")
                {
                    h = 0;

                }
                else
                {
                    h = Convert.ToInt64(maskedTextBox12.Text);
                }
                if (maskedTextBox11.Text == "")
                {
                    m = 0;

                }
                else
                {
                    m = Convert.ToInt64(maskedTextBox11.Text);
                }
                if (maskedTextBox10.Text == "")
                {
                    s = 0;

                }
                else
                {
                    s = Convert.ToInt64(maskedTextBox10.Text);
                }
                if (h < 0 || m < 0 || s < 0)
                {
                    label19.Text = "Некорректно введены параметры".ToString();
                    h = 0;
                    m = 0;
                    s = 0;
                }
            }
            catch { label19.Text = "Некорректно введены параметры".ToString(); }
            time T = new time(smsc3, mmsc2, hmsc1);
            time T1 = new time(s, m, h);            
            T1.normalize();
            T = T - T1;
            maskedTextBox1.Text = T.get_hour().ToString();
            maskedTextBox2.Text = T.get_min().ToString();
            maskedTextBox3.Text = T.get_sec().ToString();
            
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            maskedTextBox15.Text = "";
            maskedTextBox14.Text = "";
            maskedTextBox13.Text = "";
            maskedTextBox16.Text = "";
            maskedTextBox17.Text = "";
            maskedTextBox18.Text = "";
            label19.Text = "".ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox15.Text == "")
                {
                    h = 0;

                }
                else
                {
                    h = Convert.ToInt64(maskedTextBox15.Text);
                }
                if (maskedTextBox14.Text == "")
                {
                    m = 0;

                }
                else
                {
                    m = Convert.ToInt64(maskedTextBox14.Text);
                }
                if (maskedTextBox13.Text == "")
                {
                    s = 0;

                }
                else
                {
                    s = Convert.ToInt64(maskedTextBox13.Text);
                }
                if (maskedTextBox16.Text == "")
                {
                    h1 = 0;
                }
                else
                {
                    h1 = Convert.ToInt64(maskedTextBox16.Text);
                }
                if (maskedTextBox17.Text == "")
                {
                    m1 = 0;
                }
                else
                {
                    m1 = Convert.ToInt64(maskedTextBox17.Text);
                }
                if (maskedTextBox18.Text == "")
                {
                    s1 = 0;
                }
                else
                {
                    s1 = Convert.ToInt64(maskedTextBox18.Text);
                }
                if (h < 0 || m < 0 || s < 0)
                {
                    label19.Text = "Некорректно введены параметры".ToString();
                    h = 0;
                    m = 0;
                    s = 0;
                }
                else
                    if (h1 < 0 || m1 < 0 || s1 < 0)
                    {
                        label19.Text = "Некорректно введены параметры".ToString();
                        h1 = 0;
                        m1 = 0;
                        s1 = 0;
                    }
                    else
                    {

                        time T = new time(smsc3, mmsc2, hmsc1);
                        time T1 = new time(s, m, h);
                        time T2 = new time(s1, m1, h1);

                        if (T1 == T2)
                        {
                            T = T1;
                            label19.Text = "T1=T2".ToString();
                        }
                        if (T1 < T2)
                        {
                            T = T2;
                            label19.Text = "T2>T1".ToString();
                        }
                        else
                        {
                            T = T1;
                        }

                        if (T1 > T2)
                        {
                            T = T1;
                            label19.Text = "T1>T2".ToString();
                        }
                        else
                        {
                            T = T2;
                        }

                        maskedTextBox1.Text = T.get_hour().ToString();
                        maskedTextBox2.Text = T.get_min().ToString();
                        maskedTextBox3.Text = T.get_sec().ToString();
                    }
            }
            catch { label19.Text = "Некорректно введены параметры".ToString(); }
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = Convert.ToString(0);
            maskedTextBox2.Text = Convert.ToString(0);
            maskedTextBox3.Text = Convert.ToString(0);
        }

        

        
    }
}