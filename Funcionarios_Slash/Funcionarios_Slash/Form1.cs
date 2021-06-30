using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios_Slash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pgbCarregar.Increment(10);
            if (pgbCarregar.Value == 100)
            {
                timer.Stop();
                frmLogin l = new frmLogin();
                l.Show();
                this.Hide();
            }
        }
    }
}
