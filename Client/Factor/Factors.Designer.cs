namespace Factor
{
    partial class Factors
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnudelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnupreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusend = new System.Windows.Forms.ToolStripMenuItem();
            this.chkdelete = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new Factor.Template.MYButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factor.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::Factor.Properties.Resources.title;
            this.label1.Location = new System.Drawing.Point(688, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "فاکتور ها";
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToResizeColumns = false;
            this.dg1.AllowUserToResizeRows = false;
            this.dg1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg1.ColumnHeadersHeight = 50;
            this.dg1.ContextMenuStrip = this.contextMenuStrip1;
            this.dg1.Location = new System.Drawing.Point(3, 42);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dg1.Size = new System.Drawing.Size(743, 422);
            this.dg1.TabIndex = 45;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudelete,
            this.mnupreview,
            this.mnusend});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // mnudelete
            // 
            this.mnudelete.Name = "mnudelete";
            this.mnudelete.Size = new System.Drawing.Size(152, 22);
            this.mnudelete.Text = "حذف این فاکتور";
            this.mnudelete.Click += new System.EventHandler(this.mnudelete_Click);
            // 
            // mnupreview
            // 
            this.mnupreview.Name = "mnupreview";
            this.mnupreview.Size = new System.Drawing.Size(152, 22);
            this.mnupreview.Text = "نمایش فاکتور";
            this.mnupreview.Click += new System.EventHandler(this.mnupreview_Click);
            // 
            // mnusend
            // 
            this.mnusend.Name = "mnusend";
            this.mnusend.Size = new System.Drawing.Size(152, 22);
            this.mnusend.Text = "صدور دوباره";
            // 
            // chkdelete
            // 
            this.chkdelete.AutoSize = true;
            this.chkdelete.Location = new System.Drawing.Point(465, 500);
            this.chkdelete.Name = "chkdelete";
            this.chkdelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkdelete.Size = new System.Drawing.Size(273, 17);
            this.chkdelete.TabIndex = 47;
            this.chkdelete.Text = "میخواهم بعد از کلیک بر روی گزینه مورد نظر حذف شود";
            this.chkdelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(4, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(745, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "_________________________________________________________________________________" +
                "__________________________________________";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(14, 490);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(110, 36);
            this.btnexit.TabIndex = 46;
            this.btnexit.Text = "برگشت";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // Factors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkdelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(750, 535);
            this.MinimumSize = new System.Drawing.Size(750, 535);
            this.Name = "Factors";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factors";
            this.Load += new System.EventHandler(this.Factors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg1;
        private Factor.Template.MYButton btnexit;
        private System.Windows.Forms.CheckBox chkdelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnudelete;
        private System.Windows.Forms.ToolStripMenuItem mnupreview;
        private System.Windows.Forms.ToolStripMenuItem mnusend;
    }
}