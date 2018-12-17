using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factor
{
    public partial class frmFactorItem : UserControl
    {
        Database d1 = new Database();
        public frmFactorItem()
        {
            InitializeComponent();
        }

        private void frmItem_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 198, 210);
            txtcount.BackColor = Color.FromArgb(50, 198, 210);
            txtname.BackColor = Color.FromArgb(50, 198, 210);
            txttotal.BackColor = Color.FromArgb(50, 198, 210);
            txtprice.BackColor = Color.FromArgb(50, 198, 210);
        }

        private void frmItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            txtcount.BackColor = Color.White;
            txtname.BackColor = Color.White;
            txttotal.BackColor = Color.White;
            txtprice.BackColor = Color.White;
        }

        private void imgdelete_Click(object sender, EventArgs e)
        {
            PictureBox pic1;
            pic1 = sender as PictureBox;
            frmFactorItem u1 = pic1.Tag as frmFactorItem;
            if (MessageBox.Show("آيا مايل به حذف اين کالا هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UC.factor f1 = myLibrary.Currentfactor;
                f1.changeTotal(myLibrary.factorList.getPriceID(u1.Tag.ToString()));
                myLibrary.currentParent.Controls.Remove(u1);
                myLibrary.factorList.RemoveProduct(u1.Tag.ToString());
                frmToast t1 = new frmToast();
                t1.setComment = "کالاي مورد نظر از ليست فاکتور خارج شد";
                t1.Show();
            }
        }
    }
}
