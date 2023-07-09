namespace DoAnOAnQuan
{
    partial class frm_HuongDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HuongDan));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Trai = new System.Windows.Forms.Button();
            this.btn_Phai = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hướng DẪn Chơi";
            // 
            // btn_Trai
            // 
            this.btn_Trai.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold);
            this.btn_Trai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Trai.Location = new System.Drawing.Point(394, 252);
            this.btn_Trai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Trai.Name = "btn_Trai";
            this.btn_Trai.Size = new System.Drawing.Size(67, 52);
            this.btn_Trai.TabIndex = 8;
            this.btn_Trai.Text = "⇦";
            this.btn_Trai.UseVisualStyleBackColor = true;
            this.btn_Trai.Click += new System.EventHandler(this.btn_Trai_Click);
            // 
            // btn_Phai
            // 
            this.btn_Phai.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Phai.Location = new System.Drawing.Point(478, 252);
            this.btn_Phai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Phai.Name = "btn_Phai";
            this.btn_Phai.Size = new System.Drawing.Size(64, 52);
            this.btn_Phai.TabIndex = 7;
            this.btn_Phai.Text = "⇨";
            this.btn_Phai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Phai.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            this.btn_return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_return.BackgroundImage")));
            this.btn_return.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Location = new System.Drawing.Point(798, 474);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(170, 53);
            this.btn_return.TabIndex = 13;
            this.btn_return.Text = "Trở Về";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(304, 132);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(678, 87);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Người chơi bấm vào một trong 5 ô  thuộc bên mình để bắt đầu bốc quân ở một ô tùy " +
    "thích";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(304, 265);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(654, 78);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Nhấn                      Trên cửa số game hoặc nút mũi tên trái hoặc phải trên b" +
    "àn phím để chọn hướng đi cho quân ";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(304, 349);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(654, 34);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Trò Chơi kết thúc khi hai ô quan bị ăn hết";
            // 
            // frm_HuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 539);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_Phai);
            this.Controls.Add(this.btn_Trai);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.label1);
            this.Name = "frm_HuongDan";
            this.Text = "frm_HuongDan";
            this.Load += new System.EventHandler(this.frm_HuongDan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Trai;
        private System.Windows.Forms.Button btn_Phai;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}