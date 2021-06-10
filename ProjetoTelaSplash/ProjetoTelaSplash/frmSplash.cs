using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTelaSplash
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgbCarrega.Increment(1);
            if(pgbCarrega.Value == 100){
                timeSplash.Stop();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }
    }
}
