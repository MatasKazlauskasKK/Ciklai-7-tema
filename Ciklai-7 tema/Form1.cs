using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciklai_7_tema
{
    public partial class Form1 : Form
    {
        public int[] Arrayy = new int[10];
        public int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // sumavimas
        {
            if (n < 10) //sumavimo klaida kai nera 10 elementu
            {
                errorsum frm = new errorsum(this);
                frm.Show();
            }
            else //sumavimo spausdinimas
            {
                int i = 0;
                int sum = 0;
                while (true)
                {
                    sum += Arrayy[i];
                    i++;
                    if (i == n) break;
                }
                richTextBox4.Text = "suma = " + sum;
            }
        }



        private void button2_Click(object sender, EventArgs e) // Ivestis
        {
            try
            {
                if (Int32.TryParse(textBox1.Text, out Arrayy[n]))
                {
                    n++;
                    richTextBox2.Text = 1 + ". " + Arrayy[0] + "\n";
                    for (int i = 1; i < n; i++)
                    {
                        richTextBox2.AppendText(i + 1 + ". " + Arrayy[i] + "\n");
                    }
                    if (n == 10)
                    {
                        button2.Text = "Masyvo isvalymas";
                    }
                    
                }
            }
            catch (IndexOutOfRangeException) { n = 0; richTextBox2.Clear(); richTextBox1.Clear(); button2.Text = "Prideti"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = 0;
            int star = 1; //zvaigzdes
            int size;    //Eglutes dydis
            int spaces; 
            if (Int32.TryParse(textBox2.Text, out size) && size > 0)
            {
                richTextBox1.Text = "Eglute sudaroma is: " + size + " zvaigzduciu "+'\n';
                spaces = size;
                do
                {
                    for (int i = 1; i < spaces; i++)
                    {
                        richTextBox1.AppendText(" ");
                    }
                    for (int i = 0; i < star; i++)
                    {
                        richTextBox1.AppendText("* ");
                    }
                    richTextBox1.AppendText("\n");
                    spaces--;
                    star++;
                    k++;
                } while (k < size);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
