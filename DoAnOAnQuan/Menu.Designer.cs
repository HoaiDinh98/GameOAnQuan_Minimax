namespace DoAnBaoCao
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.grb_Menu = new System.Windows.Forms.GroupBox();
            this.btn_PVP = new System.Windows.Forms.Button();
            this.btn_PVC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Menu
            // 
            this.grb_Menu.Controls.Add(this.btn_PVP);
            this.grb_Menu.Controls.Add(this.btn_PVC);
            this.grb_Menu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Menu.Location = new System.Drawing.Point(218, 115);
            this.grb_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Menu.Name = "grb_Menu";
            this.grb_Menu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_Menu.Size = new System.Drawing.Size(380, 160);
            this.grb_Menu.TabIndex = 1;
            this.grb_Menu.TabStop = false;
            this.grb_Menu.Text = "Chọn kiểu chơi";
            // 
            // btn_PVP
            // 
            this.btn_PVP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PVP.Location = new System.Drawing.Point(39, 101);
            this.btn_PVP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PVP.Name = "btn_PVP";
            this.btn_PVP.Size = new System.Drawing.Size(308, 43);
            this.btn_PVP.TabIndex = 1;
            this.btn_PVP.Text = "Player VS Player";
            this.btn_PVP.UseVisualStyleBackColor = true;
            this.btn_PVP.Click += new System.EventHandler(this.btn_PVP_Click);
            // 
            // btn_PVC
            // 
            this.btn_PVC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PVC.Location = new System.Drawing.Point(39, 50);
            this.btn_PVC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PVC.Name = "btn_PVC";
            this.btn_PVC.Size = new System.Drawing.Size(308, 43);
            this.btn_PVC.TabIndex = 0;
            this.btn_PVC.Text = "Player VS Computer";
            this.btn_PVC.UseVisualStyleBackColor = true;
            this.btn_PVC.Click += new System.EventHandler(this.btn_PVC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Ô Ăn Quan";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 350);
            this.Controls.Add(this.grb_Menu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.grb_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Menu;
        private System.Windows.Forms.Button btn_PVP;
        private System.Windows.Forms.Button btn_PVC;
        private System.Windows.Forms.Label label1;
    }
}