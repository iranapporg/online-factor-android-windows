namespace Factor.Template
{
    partial class newFactorItem
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
            this.txtshop = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.btnpreview = new Factor.Template.MYButton();
            this.SuspendLayout();
            // 
            // txtshop
            // 
            this.txtshop.BackColor = System.Drawing.Color.White;
            this.txtshop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtshop.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtshop.Location = new System.Drawing.Point(210, 7);
            this.txtshop.Name = "txtshop";
            this.txtshop.ReadOnly = true;
            this.txtshop.Size = new System.Drawing.Size(172, 24);
            this.txtshop.TabIndex = 77;
            this.txtshop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtshop.MouseLeave += new System.EventHandler(this.newFactorItem_MouseLeave);
            this.txtshop.MouseHover += new System.EventHandler(this.newFactorItem_MouseHover);
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.Color.White;
            this.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcode.Font = new System.Drawing.Font("B Nazanin", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcode.Location = new System.Drawing.Point(399, 7);
            this.txtcode.Name = "txtcode";
            this.txtcode.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(129, 25);
            this.txtcode.TabIndex = 76;
            this.txtcode.Text = "0";
            this.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcode.MouseLeave += new System.EventHandler(this.newFactorItem_MouseLeave);
            this.txtcode.MouseHover += new System.EventHandler(this.newFactorItem_MouseHover);
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.White;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumber.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtnumber.Location = new System.Drawing.Point(543, 7);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.ReadOnly = true;
            this.txtnumber.Size = new System.Drawing.Size(50, 24);
            this.txtnumber.TabIndex = 75;
            this.txtnumber.Text = "0";
            this.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumber.MouseLeave += new System.EventHandler(this.newFactorItem_MouseLeave);
            this.txtnumber.MouseHover += new System.EventHandler(this.newFactorItem_MouseHover);
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdate.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdate.Location = new System.Drawing.Point(89, 7);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(101, 24);
            this.txtdate.TabIndex = 78;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdate.MouseLeave += new System.EventHandler(this.newFactorItem_MouseLeave);
            this.txtdate.MouseHover += new System.EventHandler(this.newFactorItem_MouseHover);
            // 
            // btnpreview
            // 
            this.btnpreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.btnpreview.FlatAppearance.BorderSize = 0;
            this.btnpreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpreview.Font = new System.Drawing.Font("B Nazanin", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnpreview.ForeColor = System.Drawing.Color.White;
            this.btnpreview.Location = new System.Drawing.Point(11, 7);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(68, 24);
            this.btnpreview.TabIndex = 79;
            this.btnpreview.Text = "نمایش";
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // newFactorItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtshop);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.txtnumber);
            this.Name = "newFactorItem";
            this.Size = new System.Drawing.Size(601, 39);
            this.MouseLeave += new System.EventHandler(this.newFactorItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.newFactorItem_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtshop;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtdate;
        private MYButton btnpreview;

    }
}
