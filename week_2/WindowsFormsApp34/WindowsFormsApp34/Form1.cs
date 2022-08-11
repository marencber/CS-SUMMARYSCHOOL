using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class Form1 : Form
    {
        public Form1()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int üretilen_sayi = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i <10; i++)
                {
                    üretilen_sayi= rastgele.Next(1,100);
                    if (üretilen_sayi % 2 == 0)
                    {
                        listBox1.Items.Add(üretilen_sayi);

                    }
                    else
                        i--;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int adet = 0;
                while (adet<10)
                {
                    üretilen_sayi=rastgele.Next(1,100);
                    if (üretilen_sayi %2 == 1)
                    {
                        listBox1.Items.Add(üretilen_sayi);
                        adet++;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                int number = 0;
                int asal = 0;
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    asal = 0;
                    number = random.Next(1, 100);
                    for (int a = 2; a < number; a++)
                    {
                        if (number % a == 0)
                        {
                            asal++;

                        }
                    }
                    if (asal == 0)
                    {
                        listBox1.Items.Add(number);
                    }

                    else
                    {
                        asal--;
                    }
                } 

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
