using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ler_3_valores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero1, numero2, numero3;

            numero1 = double.Parse(txtNumero1.Text);
            numero2 = double.Parse(txtNumero2.Text);
            numero3 = double.Parse(txtNumero3.Text);

            if (numero1 > numero2)
            {
                if (numero2 > numero3)
                {
                    MessageBox.Show("O número: " + numero1 + " é o maior de todos e o Menor é: " + numero3);
                }
                else
                {
                    MessageBox.Show("O número: " + numero1 + " é o maior de todos e o Menor é: " + numero2);
                }
            }

            if (numero2 > numero1)
            {
                if (numero1 > numero3)
                {
                    MessageBox.Show("O número: " + numero2 + " é o maior de todos e o Menor é: " + numero3);
                }
                else
                {
                    MessageBox.Show("O número: " + numero2 + " é o maior de todos e o Menor é: " + numero1);
                }
            }

            if (numero3 > numero2)
            {
                if (numero2 > numero1)
                {
                    MessageBox.Show("O número: " + numero3 + " é o maior de todos e o Menor é: " + numero1);
                }
                else
                {
                    MessageBox.Show("O número: " + numero3 + " é o maior de todos e o Menor é: " + numero2);
                }
            }
        }
    }
}