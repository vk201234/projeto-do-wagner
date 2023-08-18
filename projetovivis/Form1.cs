using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetovivis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DateTime data = DateTime.Now;


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            float total = float.Parse(textBox2.Text);
            int parcelas = int.Parse(textBox4.Text);

            DateTime dataatual = DateTime.Parse(textBox1.Text);



            label2.Text = dataatual.ToString("dd-MM-yyyy");

            label1.Text = total.ToString();


            for (int c=0; c <= parcelas; c++)
            {

                float valorparcela = total / parcelas;

                textBox3.AppendText(valorparcela + Environment.NewLine);

            }















            data = dataatual;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
