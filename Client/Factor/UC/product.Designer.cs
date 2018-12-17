namespace Factor
{
    partial class product
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.picprice = new System.Windows.Forms.PictureBox();
            this.piccount = new System.Windows.Forms.PictureBox();
            this.picname = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.picode = new System.Windows.Forms.PictureBox();
            this.btninsert = new Factor.Template.MYButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picode)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(528, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "2- نام کالا :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Location = new System.Drawing.Point(58, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 32);
            this.panel1.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.txtname.Location = new System.Drawing.Point(4, 1);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(526, 29);
            this.txtname.TabIndex = 1;
            this.txtname.TabStop = false;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(536, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "3-تعداد :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.txtcount);
            this.panel2.Location = new System.Drawing.Point(58, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 32);
            this.panel2.TabIndex = 10;
            // 
            // txtcount
            // 
            this.txtcount.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.txtcount.Location = new System.Drawing.Point(4, 1);
            this.txtcount.Name = "txtcount";
            this.txtcount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcount.Size = new System.Drawing.Size(526, 29);
            this.txtcount.TabIndex = 2;
            this.txtcount.TabStop = false;
            this.txtcount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcount_KeyDown);
            this.txtcount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(492, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "4- قیمت ( ریال ) :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Location = new System.Drawing.Point(58, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 32);
            this.panel3.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.txtprice.Location = new System.Drawing.Point(4, 1);
            this.txtprice.Name = "txtprice";
            this.txtprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtprice.Size = new System.Drawing.Size(526, 29);
            this.txtprice.TabIndex = 3;
            this.txtprice.TabStop = false;
            this.txtprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyDown);
            this.txtprice.Leave += new System.EventHandler(this.txtprice_Leave);
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // picprice
            // 
            this.picprice.Image = global::Factor.Properties.Resources.incorrect;
            this.picprice.Location = new System.Drawing.Point(24, 359);
            this.picprice.Name = "picprice";
            this.picprice.Size = new System.Drawing.Size(28, 28);
            this.picprice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picprice.TabIndex = 5;
            this.picprice.TabStop = false;
            this.picprice.Visible = false;
            // 
            // piccount
            // 
            this.piccount.Image = global::Factor.Properties.Resources.incorrect;
            this.piccount.Location = new System.Drawing.Point(24, 272);
            this.piccount.Name = "piccount";
            this.piccount.Size = new System.Drawing.Size(28, 28);
            this.piccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.piccount.TabIndex = 6;
            this.piccount.TabStop = false;
            this.piccount.Visible = false;
            // 
            // picname
            // 
            this.picname.Image = global::Factor.Properties.Resources.incorrect;
            this.picname.Location = new System.Drawing.Point(24, 190);
            this.picname.Name = "picname";
            this.picname.Size = new System.Drawing.Size(28, 28);
            this.picname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picname.TabIndex = 8;
            this.picname.TabStop = false;
            this.picname.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Factor.Properties.Resources.navbar;
            this.label1.Location = new System.Drawing.Point(552, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "ثبت کالا";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factor.Properties.Resources.navbar;
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(527, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "1- کد کالا :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.txtcode);
            this.panel4.Location = new System.Drawing.Point(58, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(532, 32);
            this.panel4.TabIndex = 11;
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.txtcode.Location = new System.Drawing.Point(4, 1);
            this.txtcode.Name = "txtcode";
            this.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcode.Size = new System.Drawing.Size(526, 29);
            this.txtcode.TabIndex = 0;
            this.txtcode.TabStop = false;
            this.txtcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcode_KeyDown);
            this.txtcode.Leave += new System.EventHandler(this.txtcode_Leave);
            this.txtcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcount_KeyPress);
            // 
            // picode
            // 
            this.picode.Image = global::Factor.Properties.Resources.incorrect;
            this.picode.Location = new System.Drawing.Point(24, 109);
            this.picode.Name = "picode";
            this.picode.Size = new System.Drawing.Size(28, 28);
            this.picode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picode.TabIndex = 7;
            this.picode.TabStop = false;
            this.picode.Visible = false;
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btninsert.ForeColor = System.Drawing.Color.White;
            this.btninsert.Location = new System.Drawing.Point(58, 426);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(109, 33);
            this.btninsert.TabIndex = 4;
            this.btninsert.Text = "ثبت کالای جدید";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.picprice);
            this.Controls.Add(this.piccount);
            this.Controls.Add(this.picode);
            this.Controls.Add(this.picname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(619, 462);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.PictureBox picname;
        private System.Windows.Forms.PictureBox piccount;
        private System.Windows.Forms.PictureBox picprice;
        private Factor.Template.MYButton btninsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.PictureBox picode;
    }
}
