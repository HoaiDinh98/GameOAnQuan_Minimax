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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_PVC pvc = new frm_PVC();
            pvc.Show();
            this.Hide();
            
        }

        private void btn_pvp_Click_1(object sender, EventArgs e)
        {
            frm_PVP pvp = new frm_PVP();
            pvp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            frm_ThongTin tt = new frm_ThongTin();
            tt.Show();
            this.Hide();
        }

        private void btn_HuongDan_Click(object sender, EventArgs e)
        {
            frm_HuongDan hd = new frm_HuongDan();
            hd.Show();
            this.Hide();
        }
    }
}
