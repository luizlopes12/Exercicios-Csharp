using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
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
        }
        public Form1()
        {
            limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            mskRes.Text = "0";
        }
    }
}
