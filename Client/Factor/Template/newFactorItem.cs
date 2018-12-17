using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Factor.UC;

namespace Factor.Template
{
    public partial class newFactorItem : UserControl
    {
        public newFactorItem()
        {
            InitializeComponent();
        }

        private void newFactorItem_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 198, 210);
            txtcode.BackColor = Color.FromArgb(50, 198, 210);
            txtshop.BackColor = Color.FromArgb(50, 198, 210);
            txtnumber.BackColor = Color.FromArgb(50, 198, 210);
            txtdate.BackColor = Color.FromArgb(50, 198, 210);
        }

        private void newFactorItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            txtcode.BackColor = Color.White;
            txtshop.BackColor = Color.White;
            txtnumber.BackColor = Color.White;
            txtdate.BackColor = Color.White;
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            MYButton m1 = sender as MYButton;
            FactorItem[] dt1 = m1.Tag as FactorItem[];
            frmgetFactorlistproduct fgp = new frmgetFactorlistproduct();
            object[] oj1 = new object[1];
            oj1[0] = dt1;
            fgp.fillData(oj1);
            fgp.sDate = txtdate.Text;
            fgp.sShopName = txtshop.Text;
            fgp.sPhone = txtshop.Tag.ToString();
            fgp.FactorID = txtcode.Text;
            fgp.ShowDialog();
            if (fgp.blnAccept == true)
            {
                myLibrary.currentParent.Controls.Remove(this.Tag as newFactorItem);
                frmToast Toast = new frmToast();
                Toast.setComment = "اقلام موجود به انبار اضافه شد";
                Toast.Show();
            }
        }
    }
}
