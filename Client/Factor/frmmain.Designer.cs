namespace Factor
{
    partial class frmmain
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
            this.components = new System.ComponentModel.Container();
            this.pnlproduct = new System.Windows.Forms.Panel();
            this.picproduct = new System.Windows.Forms.PictureBox();
            this.pnlstore = new System.Windows.Forms.Panel();
            this.picstore = new System.Windows.Forms.PictureBox();
            this.pnlfactor = new System.Windows.Forms.Panel();
            this.picfactor = new System.Windows.Forms.PictureBox();
            this.pnlnewfactor = new System.Windows.Forms.Panel();
            this.txtfactorcount = new System.Windows.Forms.TextBox();
            this.picnewfactor = new System.Windows.Forms.PictureBox();
            this.pnlparent = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myButton1 = new Factor.Template.MYButton();
            this.pnlproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picproduct)).BeginInit();
            this.pnlstore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstore)).BeginInit();
            this.pnlfactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfactor)).BeginInit();
            this.pnlnewfactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnewfactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlproduct
            // 
            this.pnlproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlproduct.Controls.Add(this.picproduct);
            this.pnlproduct.Location = new System.Drawing.Point(622, 43);
            this.pnlproduct.Name = "pnlproduct";
            this.pnlproduct.Size = new System.Drawing.Size(128, 115);
            this.pnlproduct.TabIndex = 5;
            this.pnlproduct.Tag = "product";
            this.pnlproduct.MouseLeave += new System.EventHandler(this.pnlproduct_MouseLeave);
            this.pnlproduct.Click += new System.EventHandler(this.pnlproduct_Click);
            this.pnlproduct.MouseHover += new System.EventHandler(this.pnlproduct_MouseHover);
            // 
            // picproduct
            // 
            this.picproduct.Image = global::Factor.Properties.Resources.product;
            this.picproduct.Location = new System.Drawing.Point(30, 19);
            this.picproduct.Name = "picproduct";
            this.picproduct.Size = new System.Drawing.Size(74, 74);
            this.picproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picproduct.TabIndex = 0;
            this.picproduct.TabStop = false;
            this.picproduct.MouseLeave += new System.EventHandler(this.picproduct_MouseLeave);
            this.picproduct.Click += new System.EventHandler(this.pnlproduct_Click);
            this.picproduct.MouseHover += new System.EventHandler(this.picproduct_MouseHover);
            // 
            // pnlstore
            // 
            this.pnlstore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlstore.Controls.Add(this.picstore);
            this.pnlstore.Location = new System.Drawing.Point(622, 158);
            this.pnlstore.Name = "pnlstore";
            this.pnlstore.Size = new System.Drawing.Size(128, 115);
            this.pnlstore.TabIndex = 4;
            this.pnlstore.Tag = "store";
            this.pnlstore.MouseLeave += new System.EventHandler(this.pnlproduct_MouseLeave);
            this.pnlstore.Click += new System.EventHandler(this.picstore_Click);
            this.pnlstore.MouseHover += new System.EventHandler(this.pnlproduct_MouseHover);
            // 
            // picstore
            // 
            this.picstore.Image = global::Factor.Properties.Resources.store;
            this.picstore.Location = new System.Drawing.Point(29, 19);
            this.picstore.Name = "picstore";
            this.picstore.Size = new System.Drawing.Size(80, 80);
            this.picstore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picstore.TabIndex = 0;
            this.picstore.TabStop = false;
            this.picstore.MouseLeave += new System.EventHandler(this.picstore_MouseLeave);
            this.picstore.Click += new System.EventHandler(this.picstore_Click);
            this.picstore.MouseHover += new System.EventHandler(this.picstore_MouseHover);
            // 
            // pnlfactor
            // 
            this.pnlfactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlfactor.Controls.Add(this.picfactor);
            this.pnlfactor.Location = new System.Drawing.Point(622, 273);
            this.pnlfactor.Name = "pnlfactor";
            this.pnlfactor.Size = new System.Drawing.Size(128, 115);
            this.pnlfactor.TabIndex = 3;
            this.pnlfactor.Tag = "factor";
            this.pnlfactor.MouseLeave += new System.EventHandler(this.pnlproduct_MouseLeave);
            this.pnlfactor.Click += new System.EventHandler(this.picfactor_Click);
            this.pnlfactor.MouseHover += new System.EventHandler(this.pnlproduct_MouseHover);
            // 
            // picfactor
            // 
            this.picfactor.Image = global::Factor.Properties.Resources.factor;
            this.picfactor.Location = new System.Drawing.Point(16, 8);
            this.picfactor.Name = "picfactor";
            this.picfactor.Size = new System.Drawing.Size(102, 102);
            this.picfactor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picfactor.TabIndex = 0;
            this.picfactor.TabStop = false;
            this.picfactor.MouseLeave += new System.EventHandler(this.picfactor_MouseLeave);
            this.picfactor.Click += new System.EventHandler(this.picfactor_Click);
            this.picfactor.MouseHover += new System.EventHandler(this.picfactor_MouseHover);
            // 
            // pnlnewfactor
            // 
            this.pnlnewfactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlnewfactor.Controls.Add(this.txtfactorcount);
            this.pnlnewfactor.Controls.Add(this.picnewfactor);
            this.pnlnewfactor.Location = new System.Drawing.Point(622, 388);
            this.pnlnewfactor.Name = "pnlnewfactor";
            this.pnlnewfactor.Size = new System.Drawing.Size(128, 115);
            this.pnlnewfactor.TabIndex = 2;
            this.pnlnewfactor.Tag = "newfactor";
            this.pnlnewfactor.MouseLeave += new System.EventHandler(this.pnlproduct_MouseLeave);
            this.pnlnewfactor.Click += new System.EventHandler(this.picnewfactor_Click);
            this.pnlnewfactor.MouseHover += new System.EventHandler(this.pnlproduct_MouseHover);
            // 
            // txtfactorcount
            // 
            this.txtfactorcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.txtfactorcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfactorcount.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfactorcount.ForeColor = System.Drawing.Color.White;
            this.txtfactorcount.Location = new System.Drawing.Point(31, 60);
            this.txtfactorcount.Name = "txtfactorcount";
            this.txtfactorcount.ReadOnly = true;
            this.txtfactorcount.Size = new System.Drawing.Size(20, 20);
            this.txtfactorcount.TabIndex = 0;
            this.txtfactorcount.TabStop = false;
            this.txtfactorcount.Text = "0";
            this.txtfactorcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfactorcount.Visible = false;
            // 
            // picnewfactor
            // 
            this.picnewfactor.Image = global::Factor.Properties.Resources.new_factor;
            this.picnewfactor.Location = new System.Drawing.Point(17, 13);
            this.picnewfactor.Name = "picnewfactor";
            this.picnewfactor.Size = new System.Drawing.Size(102, 102);
            this.picnewfactor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picnewfactor.TabIndex = 1;
            this.picnewfactor.TabStop = false;
            this.picnewfactor.MouseLeave += new System.EventHandler(this.picnewfactor_MouseLeave);
            this.picnewfactor.Click += new System.EventHandler(this.picnewfactor_Click);
            this.picnewfactor.MouseHover += new System.EventHandler(this.picnewfactor_MouseHover);
            // 
            // pnlparent
            // 
            this.pnlparent.Location = new System.Drawing.Point(1, 44);
            this.pnlparent.Name = "pnlparent";
            this.pnlparent.Size = new System.Drawing.Size(620, 492);
            this.pnlparent.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factor.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(622, 503);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(128, 32);
            this.myButton1.TabIndex = 0;
            this.myButton1.TabStop = false;
            this.myButton1.Text = "خروج";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 535);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.pnlparent);
            this.Controls.Add(this.pnlnewfactor);
            this.Controls.Add(this.pnlfactor);
            this.Controls.Add(this.pnlstore);
            this.Controls.Add(this.pnlproduct);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(750, 535);
            this.MinimumSize = new System.Drawing.Size(750, 535);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmfactor";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.pnlproduct.ResumeLayout(false);
            this.pnlproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picproduct)).EndInit();
            this.pnlstore.ResumeLayout(false);
            this.pnlstore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstore)).EndInit();
            this.pnlfactor.ResumeLayout(false);
            this.pnlfactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfactor)).EndInit();
            this.pnlnewfactor.ResumeLayout(false);
            this.pnlnewfactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnewfactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlproduct;
        private System.Windows.Forms.PictureBox picproduct;
        private System.Windows.Forms.Panel pnlstore;
        private System.Windows.Forms.PictureBox picstore;
        private System.Windows.Forms.Panel pnlfactor;
        private System.Windows.Forms.PictureBox picfactor;
        private System.Windows.Forms.Panel pnlnewfactor;
        private System.Windows.Forms.PictureBox picnewfactor;
        private System.Windows.Forms.Panel pnlparent;
        private Factor.Template.MYButton myButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtfactorcount;
    }
}