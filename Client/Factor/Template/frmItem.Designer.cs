namespace Factor
{
	partial class frmItem
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
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.imgdelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgdelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.White;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumber.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtnumber.Location = new System.Drawing.Point(535, 13);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.ReadOnly = true;
            this.txtnumber.Size = new System.Drawing.Size(63, 22);
            this.txtnumber.TabIndex = 39;
            this.txtnumber.Text = "0";
            this.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumber.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtnumber.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(349, 10);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(167, 26);
            this.txtname.TabIndex = 39;
            this.txtname.Text = "0";
            this.txtname.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtname.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtprice.Location = new System.Drawing.Point(172, 13);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtprice.Size = new System.Drawing.Size(147, 22);
            this.txtprice.TabIndex = 39;
            this.txtprice.Text = "0";
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprice.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtprice.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // txtcount
            // 
            this.txtcount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcount.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcount.Location = new System.Drawing.Point(86, 8);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(62, 29);
            this.txtcount.TabIndex = 39;
            this.txtcount.Text = "0";
            this.txtcount.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtcount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcount_KeyDown);
            this.txtcount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcount_KeyPress);
            this.txtcount.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // imgdelete
            // 
            this.imgdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgdelete.Image = global::Factor.Properties.Resources.delete;
            this.imgdelete.Location = new System.Drawing.Point(14, 13);
            this.imgdelete.Name = "imgdelete";
            this.imgdelete.Size = new System.Drawing.Size(22, 22);
            this.imgdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgdelete.TabIndex = 40;
            this.imgdelete.TabStop = false;
            this.imgdelete.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.imgdelete.Click += new System.EventHandler(this.imgdelete_Click);
            this.imgdelete.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgdelete);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtnumber);
            this.Name = "frmItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(601, 42);
            this.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.imgdelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.PictureBox imgdelete;
	}
}