namespace DoAnOAnQuan
{
    partial class frm_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.btn_pvc = new System.Windows.Forms.Button();
            this.btn_pvp = new System.Windows.Forms.Button();
            this.btn_HuongDan = new System.Windows.Forms.Button();
            this.btn_ThongTin = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Nhom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pvc
            // 
            this.btn_pvc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pvc.BackgroundImage")));
            this.btn_pvc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pvc.Location = new System.Drawing.Point(31, 293);
            this.btn_pvc.Name = "btn_pvc";
            this.btn_pvc.Size = new System.Drawing.Size(253, 53);
            this.btn_pvc.TabIndex = 7;
            this.btn_pvc.Text = "Player VS Computer";
            this.btn_pvc.UseVisualStyleBackColor = true;
            this.btn_pvc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pvp
            // 
            this.btn_pvp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pvp.BackgroundImage")));
            this.btn_pvp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pvp.Location = new System.Drawing.Point(30, 352);
            this.btn_pvp.Name = "btn_pvp";
            this.btn_pvp.Size = new System.Drawing.Size(254, 55);
            this.btn_pvp.TabIndex = 8;
            this.btn_pvp.Text = "Player VS Player";
            this.btn_pvp.UseVisualStyleBackColor = true;
            this.btn_pvp.Click += new System.EventHandler(this.btn_pvp_Click_1);
            // 
            // btn_HuongDan
            // 
            this.btn_HuongDan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HuongDan.BackgroundImage")));
            this.btn_HuongDan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuongDan.Location = new System.Drawing.Point(290, 289);
            this.btn_HuongDan.Name = "btn_HuongDan";
            this.btn_HuongDan.Size = new System.Drawing.Size(170, 53);
            this.btn_HuongDan.TabIndex = 9;
            this.btn_HuongDan.Text = "Hướng Dẫn";
            this.btn_HuongDan.UseVisualStyleBackColor = true;
            this.btn_HuongDan.Click += new System.EventHandler(this.btn_HuongDan_Click);
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ThongTin.BackgroundImage")));
            this.btn_ThongTin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTin.Location = new System.Drawing.Point(290, 344);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.Size = new System.Drawing.Size(170, 53);
            this.btn_ThongTin.TabIndex = 10;
            this.btn_ThongTin.Text = "Thông Tin";
            this.btn_ThongTin.UseVisualStyleBackColor = true;
            this.btn_ThongTin.Click += new System.EventHandler(this.btn_ThongTin_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(290, 399);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(170, 53);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Nhom
            // 
            this.btn_Nhom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Nhom.BackgroundImage")));
            this.btn_Nhom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhom.Location = new System.Drawing.Point(535, 373);
            this.btn_Nhom.Name = "btn_Nhom";
            this.btn_Nhom.Size = new System.Drawing.Size(182, 53);
            this.btn_Nhom.TabIndex = 12;
            this.btn_Nhom.Text = "NHÓM: 19";
            this.btn_Nhom.UseVisualStyleBackColor = true;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 454);
            this.Controls.Add(this.btn_Nhom);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThongTin);
            this.Controls.Add(this.btn_HuongDan);
            this.Controls.Add(this.btn_pvp);
            this.Controls.Add(this.btn_pvc);
            this.Name = "frm_Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pvc;
        private System.Windows.Forms.Button btn_pvp;
        private System.Windows.Forms.Button btn_HuongDan;
        private System.Windows.Forms.Button btn_ThongTin;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Nhom;



    }
}

