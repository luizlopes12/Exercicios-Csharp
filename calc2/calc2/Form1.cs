using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2
{
    public partial class Form1 : Form
    {
        double total;
        double ultimoNumero;
        string operador;
        private void limpar()
        {
            total = 0;
            ultimoNumero = 0;
            operador = "+";
            mskRes.Text = "";
        }
        private void calcular()
        {
            switch (operador)
            {
                case "+":
                    total = total + ultimoNumero;
                    break;
                case "-":
                    total = total - ultimoNumero;
                    break;
                case "/":
                    total = total / ultimoNumero;
                    break;
                case "x":
                    total = total * ultimoNumero;
                    break;
            }
            ultimoNumero = 0;
            mskRes.Text = total.ToString();
        }
        public Form1()
        {
            InitializeComponent();
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void gerarNum(object sender, EventArgs e)
        {   
            if(ultimoNumero == 0)
            {
                mskRes.Text = (sender as Button).Text;
            }
            else
            {
                mskRes.Text += (sender as Button).Text;
            }
            try
            {
                mskRes.Text += (sender as Button).Text;
            }
            catch
            {
                MessageBox.Show("Houve um erro no sistema");
            }
            
        }

        private void parametros(object sender, EventArgs e)
        {
            try
            {
                mskRes.Text += (sender as Button).Text;
            }
            catch
            {
                MessageBox.Show("Houve um erro no sistema");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                ultimoNumero = Convert.ToDouble(mskRes.Text);
                calcular();
                total = 0;
                operador = "+";
            }
            catch 
            {
                MessageBox.Show("Houve um erro no sistema");
            }
            
            
        }
    }
}
