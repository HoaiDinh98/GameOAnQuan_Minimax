using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBaoCao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_PVP_Click(object sender, EventArgs e)
        {
            PVP frm2 = new PVP();
            frm2.ShowDialog();
        }

        private void btn_PVC_Click(object sender, EventArgs e)
        {
            PVC frm1 = new PVC();
            frm1.ShowDialog();
        }

    }
}
