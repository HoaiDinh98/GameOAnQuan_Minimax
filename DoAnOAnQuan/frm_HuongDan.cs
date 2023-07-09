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
    public partial class frm_HuongDan : Form
    {
        public frm_HuongDan()
        {
            InitializeComponent();
        }

        private void frm_HuongDan_Load(object sender, EventArgs e)
        {

        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
            frm_Menu menu = new frm_Menu();
            menu.Show();
        }

        private void btn_Trai_Click(object sender, EventArgs e)
        {

        }
    }
}
