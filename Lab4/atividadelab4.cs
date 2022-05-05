using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class atividadelab4 : Form
    {
        public atividadelab4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxNum.Text == "")
            {
                MessageBox.Show("Digite um número");
            }
            else
            {
                int numero = 0;
                int quadrado = 0;

                numero = Convert.ToInt32(tbxNum.Text);

                quadrado = numero * numero;

                lblResultado.Text = "O número " + numero + " ,ao quadrado, é " + quadrado.ToString();

                tbxNum.Focus();
                tbxNum.SelectAll();
            }
        }
    }
}
