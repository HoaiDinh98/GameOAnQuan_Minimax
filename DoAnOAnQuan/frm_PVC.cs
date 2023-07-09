using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ThuVienClass;
namespace DoAnOAnQuan
{
    public partial class frm_PVC : Form
    {
        public frm_PVC()
        {
            InitializeComponent();
        }
        BanCo banCo = new BanCo();
        Minimax MNM = new Minimax();
        int player = 2;
        int index = 0;
        int ViTri;
        public int action = 0;
        private void frm_PVC_Load(object sender, EventArgs e)
        {
            btn_return.Hide();
            Turn_BatDau(player);
            Update_Text_Btn();
        }
        private void Turn_BatDau(int player)
        {
            //gán player = 2 là player, player = 1 là máy
            if (player == 1)
            {
                lbl_Start_B.Hide();
                lbl_Start_A.Show();
                grb_PlayerA.Focus();
            }
            if (player == 2)
            {
                lbl_Start_A.Hide();
                lbl_Start_B.Show();
                grb_PlayerB.Focus();
            }
        }
        private void Update_Text_Btn()
        {
            btn_0.Text = banCo.OQuanBanCo[0].GetValue().ToString();
            btn_1.Text = banCo.OQuanBanCo[1].GetValue().ToString();
            btn_2.Text = banCo.OQuanBanCo[2].GetValue().ToString();
            btn_3.Text = banCo.OQuanBanCo[3].GetValue().ToString();
            btn_4.Text = banCo.OQuanBanCo[4].GetValue().ToString();
            btn_5.Text = banCo.OQuanBanCo[5].GetValue().ToString();
            btn_6.Text = banCo.OQuanBanCo[6].GetValue().ToString();
            btn_7.Text = banCo.OQuanBanCo[7].GetValue().ToString();
            btn_8.Text = banCo.OQuanBanCo[8].GetValue().ToString();
            btn_9.Text = banCo.OQuanBanCo[9].GetValue().ToString();
            btn_10.Text = banCo.OQuanBanCo[10].GetValue().ToString();
            btn_11.Text = banCo.OQuanBanCo[11].GetValue().ToString();
            txt_Result_A.Text = banCo.OQuanBanCo[12].GetValue().ToString();  // máy
            txt_Result_B.Text = banCo.OQuanBanCo[13].GetValue().ToString();  // người
        }
        public void Enable_Button()
        {
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
            btn_10.Enabled = false;
            btn_11.Enabled = false;
        }

        private bool Check_Win()
        {
            if (banCo.finish())
            {
                if (banCo.OQuanBanCo[12].GetValue() < banCo.OQuanBanCo[13].GetValue())
                {
                    lbl_Result_B.Text = "WIN"; // B là player
                    lbl_Result_B.ForeColor = Color.Red;
                    lbl_Result_A.Text = "LOST"; // A là máy
                    lbl_Result_A.ForeColor = Color.Black;
                    Enable_Button();
                    MessageBox.Show("Game đã kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_return.Show();
                }
                else
                {
                    lbl_Result_A.Text = "WIN";
                    lbl_Result_A.ForeColor = Color.Red;
                    lbl_Result_B.Text = "LOST";
                    lbl_Result_B.ForeColor = Color.Black;
                    Enable_Button();
                    MessageBox.Show("Game đã kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_return.Show();
                }
                return true;
            }
            return false;
        }
        private void btn_Trai_Click(object sender, EventArgs e)
        {
            int score = 0;
            action = 1;
            score = banCo.eatLeft(banCo.left(ViTri));
            banCo.setScorePlayer(score);
            // gán text của form = giá trị tại 
            txt_Result_B.Text = banCo.OQuanBanCo[13].GetValue().ToString();

            // lượt của máy 
            player = 1;
            Turn_BatDau(player);
            Update_Text_Btn();
            if (Check_Win())
                return;

            MessageBox.Show("Đến Lượt Máy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grb_DieuHuong.Enabled = false;
            Computer();
        }

        private void btn_Phai_Click(object sender, EventArgs e)
        {
            int score = 0;
            action = 2;
            score = banCo.eatRight(banCo.right(ViTri));
            banCo.setScorePlayer(score);
            txt_Result_B.Text = banCo.OQuanBanCo[13].ToString();

            // lượt của máy
            player = 1;
            Turn_BatDau(player);
            Update_Text_Btn();
            if (Check_Win())
                return;

            MessageBox.Show("Đến Lượt Máy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grb_DieuHuong.Enabled = false;
            Computer();
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            grb_DieuHuong.Enabled = true;
            Button btn = (Button)sender;
            if (btn.Name == "btn_7")
            {
                ViTri = 7;
            }
            else if (btn.Name == "btn_8")
            {
                ViTri = 8;
            }
            else if (btn.Name == "btn_9")
            {
                ViTri = 9;
            }
            else if (btn.Name == "btn_10")
            {
                ViTri = 10;
            }
            else if (btn.Name == "btn_11")
            {
                ViTri = 11;
            }
        }
      


        public void Computer()
        {
            index = 0;
            banCo.setResults(new List<Result>());
            if (Check_Win())
                return;

            // nếu bàn cờ hết quân tiến hành rải quân cho máy
            if (banCo.kiemTraHetQuan(player))
            {
                banCo.raiQuan(player);
                Turn_BatDau(player);
                Update_Text_Btn();
                return;
            }
            else
            {
                int[] a = MNM.minimax(banCo, 1, player);
                int ViTri = a[1];
                int action = a[2];
                int score = 0;
                if (action == 1)
                {
                    score = banCo.eatLeft(banCo.left(ViTri));
                }
                else
                {
                    score = banCo.eatRight(banCo.right(ViTri));
                }
                banCo.setScoreComputer(score);
                txt_Result_A.Text = banCo.OQuanBanCo[12].ToString();

                // sau khi xong lượt của máy thì gán lại player = 2 để đến lượt của player
                player = 2;

                Turn_BatDau(player);
                Update_Text_Btn();
            }

            if (Check_Win())
                return;

            // Kiem tra quan cua nguoi choi
            if (banCo.kiemTraHetQuan(player) && !banCo.finish())
            {
                banCo.raiQuan(player);
                Turn_BatDau(player);
                MessageBox.Show("Người Chơi Rải Quân => Qua Lượt !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Update_Text_Btn();
                grb_DieuHuong.Enabled = false;
                Computer();
            }
        }



        // hàm set các nút mũi tên trên bàn phím
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
                       
            if (keyData == Keys.Left)
            {
                btn_Trai.PerformClick();
                return true;
            }
            if (keyData == Keys.Right)
            {
                btn_Phai.PerformClick();
                return true;
            }
            if (keyData == Keys.Escape)
            {
                Close();
                frm_Menu menu = new frm_Menu();
                menu.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
            frm_Menu menu = new frm_Menu();
            menu.Show();
        }




     

    }
}
