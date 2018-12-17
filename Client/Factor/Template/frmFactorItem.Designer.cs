namespace Factor
{
    partial class frmFactorItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.imgdelete = new System.Windows.Forms.PictureBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgdelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcount
            // 
            this.txtcount.BackColor = System.Drawing.Color.White;
            this.txtcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcount.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcount.Location = new System.Drawing.Point(217, 10);
            this.txtcount.Name = "txtcount";
            this.txtcount.ReadOnly = true;
            this.txtcount.Size = new System.Drawing.Size(62, 22);
            this.txtcount.TabIndex = 44;
            this.txtcount.Text = "0";
            this.txtcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcount.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtcount.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtprice.Location = new System.Drawing.Point(291, 10);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(150, 22);
            this.txtprice.TabIndex = 43;
            this.txtprice.Text = "0";
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprice.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtprice.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("B Nazanin", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(447, 10);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(130, 23);
            this.txtname.TabIndex = 42;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtname.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txtname.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // imgdelete
            // 
            this.imgdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgdelete.Image = global::Factor.Properties.Resources.delete;
            this.imgdelete.Location = new System.Drawing.Point(8, 10);
            this.imgdelete.Name = "imgdelete";
            this.imgdelete.Size = new System.Drawing.Size(22, 22);
            this.imgdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgdelete.TabIndex = 45;
            this.imgdelete.TabStop = false;
            this.imgdelete.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.imgdelete.Click += new System.EventHandler(this.imgdelete_Click);
            this.imgdelete.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttotal.Location = new System.Drawing.Point(71, 10);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(134, 22);
            this.txttotal.TabIndex = 43;
            this.txttotal.Text = "0";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotal.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.txttotal.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            // 
            // frmFactorItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgdelete);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Name = "frmFactorItem";
            this.Size = new System.Drawing.Size(601, 42);
            this.MouseLeave += new System.EventHandler(this.frmItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.frmItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.imgdelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgdelete;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotal;
    }
}
