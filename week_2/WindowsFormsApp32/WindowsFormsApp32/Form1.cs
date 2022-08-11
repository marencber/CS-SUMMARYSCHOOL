using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            Random rastgele = new Random();
            sayi1 = Convert.ToInt32

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++) ;
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.SelectedItems ; i++) ;
            {
                listBox2.Items.Add(Listbox1.selecteditems[i]);
            }
        }
    }
}
