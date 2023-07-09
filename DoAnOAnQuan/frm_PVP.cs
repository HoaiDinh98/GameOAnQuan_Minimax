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
    public partial class frm_PVP : Form
    {
        public frm_PVP()
        {
            InitializeComponent();
        }
        BanCo banCo = new BanCo();
        int player = 1;
        int index = 0;
        int location;
        int score = 0;
        public int action = 0;
        private void frm_PVP_Load(object sender, EventArgs e)
        {
            btn_return.Hide();
            grb_DieuHuong1.Enabled = false;
            grb_DieuHuong2.Enabled = false;
            Turn_BatDau(player);
            BLock_Btn();
            Update_Text_Btn();
        }
        private void Turn_BatDau(int player)
        {
            if (player == 1)
            {
                lbl_Star_1.Show();
                lbl_Star_2.Hide();
                grb_Player1.Focus();
            }
            if (player == 2)
            {
                lbl_Star_2.Show();
                lbl_Star_1.Hide();
                grb_Player2.Focus();
            }
        }

        private void BLock_Btn()
        {
            if (player == 2)
            {
                btn_1.Enabled = true;
                btn_2.Enabled = true;
                btn_3.Enabled = true;
                btn_4.Enabled = true;
                btn_5.Enabled = true;

                btn_7.Enabled = false;
                btn_8.Enabled = false;
                btn_9.Enabled = false;
                btn_10.Enabled = false;
                btn_11.Enabled = false;
                grb_DieuHuong2.Enabled = true;
                grb_DieuHuong1.Enabled = false;
            }
            else
            {
                btn_1.Enabled = false;
                btn_2.Enabled = false;
                btn_3.Enabled = false;
                btn_4.Enabled = false;
                btn_5.Enabled = false;

                btn_7.Enabled = true;
                btn_8.Enabled = true;
                btn_9.Enabled = true;
                btn_10.Enabled = true;
                btn_11.Enabled = true;
                grb_DieuHuong2.Enabled = false;
                grb_DieuHuong1.Enabled = true;
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
            txt_Result_2.Text = banCo.OQuanBanCo[12].GetValue().ToString();
            txt_Result_1.Text = banCo.OQuanBanCo[13].GetValue().ToString();
        }

        private void btn_Trai_Click(object sender, EventArgs e)
        {
            int score = 0;
            action = 1;
            score = banCo.eatLeft(banCo.left(location));
            banCo.setScorePlayer(score);
            txt_Result_1.Text = banCo.OQuanBanCo[13].GetValue().ToString();
            player = 2;
            Turn_BatDau(player);
            Update_Text_Btn();
            if (Check_Win())
                return;

            MessageBox.Show("Đến Lượt player 2", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grb_DieuHuong1.Enabled = false;
            grb_DieuHuong2.Enabled = true;
            Player2();
        }

        private void btn_Phai_Click(object sender, EventArgs e)
        {
            int score = 0;
            action = 2;
            score = banCo.eatRight(banCo.right(location));
            banCo.setScorePlayer(score);
            txt_Result_1.Text = banCo.OQuanBanCo[13].ToString();
            player = 2;
            Turn_BatDau(player);
            Update_Text_Btn();
            if (Check_Win())
                return;

            MessageBox.Show("Đến Lượt player 2", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grb_DieuHuong1.Enabled = false;
            grb_DieuHuong2.Enabled = true;
            Player2();
        }

        private void btn_Trai2_Click(object sender, EventArgs e)
        {
            int score = 0;
            action = 1;
            score = banCo.eatLeft2(banCo.left2(location));
            banCo.setScorePlayer2(score);
            txt_Result_2.Text = banCo.OQuanBanCo[12].GetValue().ToString();
            player = 1;
            Turn_BatDau(player);
            Update_Text_Btn();
            if (Check_Win())
                return;

            MessageBox.Show("Đến Lượt player 1", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grb_DieuHuong2.Enabled = false;
            grb_DieuHuong1.Enabled = true;
            Player1();
        }

        private void btn_Phai2_Click(object sender, EventArgs e)
        {
            int score = 0;
            action = 2;
            score = banCo.eatRight2(banCo.right2(location));
            banCo.setScorePlayer2(score);
            txt_Result_2.Text = banCo.OQuanBanCo[12].ToString();
            player = 1;
            Turn_BatDau(player);
            Update_Text_Btn();
            if (Check_Win())
                return;

            MessageBox.Show("Đến Lượt player 1", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grb_DieuHuong2.Enabled = false;
            grb_DieuHuong1.Enabled = true;
            Player1();
        }

        public void Player2()
        {
            BLock_Btn();
            index = 0;
            banCo.setResults(new List<Result>());
            if (Check_Win())
                return;
            if (banCo.kiemTraHetQuan(player))
            {
                banCo.raiQuan(player);
                Turn_BatDau(player);
                Update_Text_Btn();
                return;
            }
            else
            {
                banCo.setScorePlayer2(score);

                txt_Result_2.Text = banCo.OQuanBanCo[12].ToString();
                player = 1;
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
                grb_DieuHuong2.Enabled = false;
                grb_DieuHuong1.Enabled = true;
                Player1();
            }
        }
        public void Player1()
        {
            BLock_Btn();
            index = 0;
            banCo.setResults(new List<Result>());
            if (Check_Win())
                return;
            if (banCo.kiemTraHetQuan(player))
            {
                banCo.raiQuan(player);
                Turn_BatDau(player);
                Update_Text_Btn();
                return;
            }
            else
            {
                banCo.setScorePlayer(score);

                txt_Result_1.Text = banCo.OQuanBanCo[13].ToString();
                player = 2;
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
                grb_DieuHuong1.Enabled = false;
                grb_DieuHuong2.Enabled = true;
                Player2();
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btn_0")
            {
                location = 0;
                grb_DieuHuong1.Enabled = false;
                grb_DieuHuong2.Enabled = true;
            }
            else if (btn.Name == "btn_1")
            {
                location = 1;
                grb_DieuHuong1.Enabled = false;
                grb_DieuHuong2.Enabled = true;
            }
            else if (btn.Name == "btn_2")
            {
                location = 2;
                grb_DieuHuong1.Enabled = false;
                grb_DieuHuong2.Enabled = true;
            }
            else if (btn.Name == "btn_3")
            {
                location = 3;
                grb_DieuHuong1.Enabled = false;
                grb_DieuHuong2.Enabled = true;
            }
            else if (btn.Name == "btn_4")
            {
                location = 4;
                grb_DieuHuong1.Enabled = false;
                grb_DieuHuong2.Enabled = true;
            }
            else if (btn.Name == "btn_5")
            {
                location = 5;
                grb_DieuHuong1.Enabled = false;
                grb_DieuHuong2.Enabled = true;
            }
            else if (btn.Name == "btn_6")
            {
                location = 6;
                grb_DieuHuong1.Enabled = false;
                grb_DieuHuong2.Enabled = true;
            }
            else if (btn.Name == "btn_7")
            {
                location = 7;
                grb_DieuHuong2.Enabled = false;
                grb_DieuHuong1.Enabled = true;
            }
            else if (btn.Name == "btn_8")
            {
                location = 8;
                grb_DieuHuong2.Enabled = false;
                grb_DieuHuong1.Enabled = true;
            }
            else if (btn.Name == "btn_9")
            {
                location = 9;
                grb_DieuHuong2.Enabled = false;
                grb_DieuHuong1.Enabled = true;
            }
            else if (btn.Name == "btn_10")
            {
                location = 10;
                grb_DieuHuong2.Enabled = false;
                grb_DieuHuong1.Enabled = true;
            }
            else if (btn.Name == "btn_11")
            {
                location = 11;
                grb_DieuHuong2.Enabled = false;
                grb_DieuHuong1.Enabled = true;
            }
        }

        public void Enable_Button()
        {
            btn_1.Enabled = false;
            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            grb_DieuHuong2.Enabled = false;
            grb_DieuHuong1.Enabled = false;
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
                    lbl_Result_1.Text = "WIN";
                    lbl_Result_1.ForeColor = Color.Red;
                    lbl_Result_2.Text = "LOST";
                    lbl_Result_2.ForeColor = Color.Black;
                    Enable_Button();
                    MessageBox.Show("Game đã kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_return.Show();
                }
                else
                {
                    lbl_Result_2.Text = "WIN";
                    lbl_Result_2.ForeColor = Color.Red;
                    lbl_Result_1.Text = "LOST";
                    lbl_Result_1.ForeColor = Color.Black;
                    Enable_Button();
                    MessageBox.Show("Game đã kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_return.Show();
                }
                return true;
            }
            return false;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Left)
            {
                btn_Trai.PerformClick();
                return true;
            }
            if (keyData == Keys.A)
            {
                btn_Trai2.PerformClick();
                return true;
            }
            if (keyData == Keys.D)
            {
                btn_Phai2.PerformClick();
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
