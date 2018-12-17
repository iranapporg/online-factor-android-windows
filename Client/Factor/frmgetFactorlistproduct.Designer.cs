namespace Factor
{
    partial class frmgetFactorlistproduct
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
            this.pnlparent = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sb1 = new System.Windows.Forms.VScrollBar();
            this.pnlist = new System.Windows.Forms.Panel();
            this.btnback = new Factor.Template.MYButton();
            this.btnaccept = new Factor.Template.MYButton();
            this.pnlparent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlparent
            // 
            this.pnlparent.Controls.Add(this.pnlist);
            this.pnlparent.Location = new System.Drawing.Point(0, 103);
            this.pnlparent.Name = "pnlparent";
            this.pnlparent.Size = new System.Drawing.Size(734, 363);
            this.pnlparent.TabIndex = 7;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.White;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbltotal.Font = new System.Drawing.Font("B Nazanin", 13F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.lbltotal.Location = new System.Drawing.Point(408, 485);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotal.Size = new System.Drawing.Size(178, 28);
            this.lbltotal.TabIndex = 102;
            this.lbltotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(594, 485);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(122, 29);
            this.label9.TabIndex = 101;
            this.label9.Text = " کل فاکتور(ریال):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(93, 57);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(38, 24);
            this.label6.TabIndex = 106;
            this.label6.Text = "تعداد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(299, 57);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 108;
            this.label4.Text = "قیمت ( ریال)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(586, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 104;
            this.label3.Text = "نام کالا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(689, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 105;
            this.label2.Text = "ردیف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.label7.Location = new System.Drawing.Point(-1, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(745, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "_________________________________________________________________________________" +
                "__________________________________________";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Factor.Properties.Resources.folder_invoices;
            this.pictureBox2.Location = new System.Drawing.Point(712, 485);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factor.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sb1
            // 
            this.sb1.LargeChange = 30;
            this.sb1.Location = new System.Drawing.Point(731, 103);
            this.sb1.Name = "sb1";
            this.sb1.Size = new System.Drawing.Size(17, 363);
            this.sb1.TabIndex = 111;
            this.sb1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sb1_Scroll);
            // 
            // pnlist
            // 
            this.pnlist.Location = new System.Drawing.Point(0, 2);
            this.pnlist.Name = "pnlist";
            this.pnlist.Size = new System.Drawing.Size(734, 363);
            this.pnlist.TabIndex = 9;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(128, 489);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 34);
            this.btnback.TabIndex = 109;
            this.btnback.Text = "برگشت";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnaccept
            // 
            this.btnaccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.btnaccept.FlatAppearance.BorderSize = 0;
            this.btnaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccept.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btnaccept.ForeColor = System.Drawing.Color.White;
            this.btnaccept.Location = new System.Drawing.Point(15, 489);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(107, 34);
            this.btnaccept.TabIndex = 109;
            this.btnaccept.Text = "قبول میکنم";
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // frmgetFactorlistproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 535);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sb1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlparent);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(750, 535);
            this.Name = "frmgetFactorlistproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmgetFactorlistproduct";
            this.pnlparent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlparent;
        private System.Windows.Forms.TextBox lbltotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Factor.Template.MYButton btnaccept;
        private Factor.Template.MYButton btnback;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlist;
        private System.Windows.Forms.VScrollBar sb1;
    }
}