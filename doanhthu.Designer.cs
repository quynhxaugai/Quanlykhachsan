﻿namespace Qlks
{
    partial class doanhthu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tienphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rd_mp = new System.Windows.Forms.RadioButton();
            this.rd_ngay = new System.Windows.Forms.RadioButton();
            this.bt_tim = new System.Windows.Forms.Button();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.rd_thang = new System.Windows.Forms.RadioButton();
            this.txt_t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_dt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "From day";
            // 
            // txt_mp
            // 
            this.txt_mp.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_mp.Location = new System.Drawing.Point(192, 62);
            this.txt_mp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mp.Name = "txt_mp";
            this.txt_mp.Size = new System.Drawing.Size(159, 23);
            this.txt_mp.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(291, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Revenue";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Tienphong});
            this.dg.Location = new System.Drawing.Point(416, 65);
            this.dg.Margin = new System.Windows.Forms.Padding(4);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(337, 273);
            this.dg.TabIndex = 20;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "MaPhong";
            this.Maphong.HeaderText = "Mã Phòng";
            this.Maphong.Name = "Maphong";
            // 
            // Tienphong
            // 
            this.Tienphong.DataPropertyName = "tt";
            this.Tienphong.HeaderText = "Tiền Phòng";
            this.Tienphong.Name = "Tienphong";
            this.Tienphong.Width = 200;
            // 
            // rd_mp
            // 
            this.rd_mp.AutoSize = true;
            this.rd_mp.BackColor = System.Drawing.Color.LightCoral;
            this.rd_mp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_mp.ForeColor = System.Drawing.Color.Black;
            this.rd_mp.Location = new System.Drawing.Point(19, 63);
            this.rd_mp.Margin = new System.Windows.Forms.Padding(4);
            this.rd_mp.Name = "rd_mp";
            this.rd_mp.Size = new System.Drawing.Size(158, 23);
            this.rd_mp.TabIndex = 30;
            this.rd_mp.TabStop = true;
            this.rd_mp.Text = "Search by  roomcode";
            this.rd_mp.UseVisualStyleBackColor = false;
            this.rd_mp.Click += new System.EventHandler(this.rd_mp_Click);
            // 
            // rd_ngay
            // 
            this.rd_ngay.AutoSize = true;
            this.rd_ngay.BackColor = System.Drawing.Color.LightCoral;
            this.rd_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_ngay.ForeColor = System.Drawing.Color.Black;
            this.rd_ngay.Location = new System.Drawing.Point(19, 113);
            this.rd_ngay.Margin = new System.Windows.Forms.Padding(4);
            this.rd_ngay.Name = "rd_ngay";
            this.rd_ngay.Size = new System.Drawing.Size(114, 23);
            this.rd_ngay.TabIndex = 40;
            this.rd_ngay.TabStop = true;
            this.rd_ngay.Text = "Search by day";
            this.rd_ngay.UseVisualStyleBackColor = false;
            this.rd_ngay.Click += new System.EventHandler(this.rd_ngay_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.ForeColor = System.Drawing.Color.LightCyan;
            this.bt_tim.Location = new System.Drawing.Point(239, 303);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(4);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(112, 32);
            this.bt_tim.TabIndex = 50;
            this.bt_tim.Text = "Search";
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // txt_n1
            // 
            this.txt_n1.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_n1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n1.Location = new System.Drawing.Point(126, 145);
            this.txt_n1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(65, 26);
            this.txt_n1.TabIndex = 0;
            this.txt_n1.Text = "21/11";
            // 
            // txt_n2
            // 
            this.txt_n2.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_n2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n2.Location = new System.Drawing.Point(285, 148);
            this.txt_n2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(66, 26);
            this.txt_n2.TabIndex = 1;
            this.txt_n2.Text = "21/11";
            // 
            // rd_thang
            // 
            this.rd_thang.AutoSize = true;
            this.rd_thang.BackColor = System.Drawing.Color.LightCoral;
            this.rd_thang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_thang.ForeColor = System.Drawing.Color.Black;
            this.rd_thang.Location = new System.Drawing.Point(19, 206);
            this.rd_thang.Margin = new System.Windows.Forms.Padding(4);
            this.rd_thang.Name = "rd_thang";
            this.rd_thang.Size = new System.Drawing.Size(129, 23);
            this.rd_thang.TabIndex = 40;
            this.rd_thang.TabStop = true;
            this.rd_thang.Text = "Search by month";
            this.rd_thang.UseVisualStyleBackColor = false;
            this.rd_thang.Click += new System.EventHandler(this.dr_thang_Click);
            // 
            // txt_t
            // 
            this.txt_t.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_t.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_t.Location = new System.Drawing.Point(192, 205);
            this.txt_t.Margin = new System.Windows.Forms.Padding(4);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(159, 26);
            this.txt_t.TabIndex = 80;
            this.txt_t.Text = "1/ or 12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(218, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "to day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total revenue";
            // 
            // lb_dt
            // 
            this.lb_dt.AutoSize = true;
            this.lb_dt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dt.ForeColor = System.Drawing.Color.Black;
            this.lb_dt.Location = new System.Drawing.Point(199, 261);
            this.lb_dt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_dt.Name = "lb_dt";
            this.lb_dt.Size = new System.Drawing.Size(46, 19);
            this.lb_dt.TabIndex = 11;
            this.lb_dt.Text = "empty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(315, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vnd";
            // 
            // doanhthu
            // 
            this.AcceptButton = this.bt_tim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Qlks.Properties.Resources.Beautiful_Background_Wallpaper_Copy4;
            this.ClientSize = new System.Drawing.Size(764, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_dt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_t);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.rd_thang);
            this.Controls.Add(this.rd_ngay);
            this.Controls.Add(this.rd_mp);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txt_mp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(780, 395);
            this.MinimumSize = new System.Drawing.Size(780, 395);
            this.Name = "doanhthu";
            this.Text = "doanhthu";
            this.Load += new System.EventHandler(this.doanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.RadioButton rd_mp;
        private System.Windows.Forms.RadioButton rd_ngay;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.RadioButton rd_thang;
        private System.Windows.Forms.TextBox txt_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_dt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tienphong;
    }
}