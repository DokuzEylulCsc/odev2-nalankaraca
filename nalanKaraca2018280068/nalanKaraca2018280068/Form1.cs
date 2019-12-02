using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nalanKaraca2018280068
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Roma_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int sayi = int.Parse(textBox1.Text);
            int birler=0, onlar=0, yuzler=0, binler=0;
            if (sayi<10)
            {
                birler = sayi;
            }
            else if (sayi>=10 && sayi<100)
            {
                birler=sayi%10;
                onlar = sayi / 10;
            }
            else if (sayi>=100 && sayi<1000)
            {
                birler = sayi % 10;
                onlar = (sayi % 100) / 10;
                yuzler = sayi / 100;
            }
            else
            {
                birler = sayi % 10;
                onlar = ((sayi % 1000) % 100) / 10;
                yuzler = (sayi % 1000) / 100;
                binler = sayi / 1000;
            }
            string[] birlerR = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] onlarR = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] yuzlerR = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] binlerR = { "", "M", "MM", "MMM" };
            textBox2.Text += binlerR[binler] + " ";
            textBox2.Text += yuzlerR[yuzler] + " ";
            textBox2.Text += onlarR[onlar];
            textBox2.Text += " " + birlerR[birler];

        }

        private void sayi_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            string roma = textBox3.Text.ToUpper();
            int sayi = 0, a1 = 0, a2 = 0, a3 = 0;
            for (int i = 0; i < roma.Length; i++)
            {
                a2 = a1;
                switch (roma[i])
                {
                    case 'I':a1 = 1;break;
                    case 'V': a1 = 5; break;
                    case 'X': a1 = 10; break;
                    case 'L': a1 = 50; break;
                    case 'C': a1 = 100; break;
                    case 'D': a1 = 500; break;
                    case 'M': a1 = 1000; break;

                }
                if (a1>a2)
                {
                    a3 = -2 * a2;
                }
                else
                {
                    a3 = 0;
                }
                sayi = sayi + a1 + a3;
            }
            if (sayi<3999)
            {
                textBox4.Text = sayi.ToString();
            }
            else
            {
                MessageBox.Show("Sayı geçerli aralıkta değil");
            }
            textBox3.Clear();
        }
        //https://mustafabukulmez.com/2019/01/05/c-girilen-sayiyi-roma-rakamina-cevirmek/
        //https://www.youtube.com/watch?v=Omwh5981X2c

    }
}
