using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOAnQuan
{
    public partial class frm_ThongTin : Form
    {
        public frm_ThongTin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
            frm_Menu menu = new frm_Menu();
            menu.Show();
        }
    }
}
