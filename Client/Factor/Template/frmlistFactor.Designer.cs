namespace Factor
{
    partial class frmlistFactor
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
            this.SuspendLayout();
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.White;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumber.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtnumber.Location = new System.Drawing.Point(535, 9);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.ReadOnly = true;
            this.txtnumber.Size = new System.Drawing.Size(63, 24);
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
            this.txtname.Font = new System.Drawing.Font("B Nazanin", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(349, 9);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(167, 25);
            this.txtname.TabIndex = 39;
            this.txtname.Text = "0";
            this.txtname.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtname.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtprice.Location = new System.Drawing.Point(176, 9);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtprice.Size = new System.Drawing.Size(147, 24);
            this.txtprice.TabIndex = 39;
            this.txtprice.Text = "0";
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprice.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtprice.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // txtcount
            // 
            this.txtcount.BackColor = System.Drawing.Color.White;
            this.txtcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcount.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcount.Location = new System.Drawing.Point(83, 9);
            this.txtcount.Name = "txtcount";
            this.txtcount.ReadOnly = true;
            this.txtcount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcount.Size = new System.Drawing.Size(62, 24);
            this.txtcount.TabIndex = 39;
            this.txtcount.Text = "0";
            this.txtcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcount.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtcount.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // frmlistFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtnumber);
            this.Name = "frmlistFactor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(601, 42);
            this.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcount;
	}
}