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
    public partial class frmlistFactor : UserControl
    {
        Database d1 = new Database();


        public frmlistFactor()
        {
            InitializeComponent();
        }

        private void frmItem_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50,198,210);
            txtcount.BackColor = Color.FromArgb(50, 198, 210);
            txtname.BackColor = Color.FromArgb(50, 198, 210);
            txtnumber.BackColor = Color.FromArgb(50, 198, 210);
            txtprice.BackColor = Color.FromArgb(50, 198, 210);
        }

        private void frmItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            txtcount.BackColor = Color.White;
            txtname.BackColor = Color.White;
            txtnumber.BackColor = Color.White;
            txtprice.BackColor = Color.White;
        }

        private void imgdelete_Click(object sender, EventArgs e)
        {
            PictureBox pic1;
            pic1 = sender as PictureBox;
            frmItem u1 = pic1.Tag as frmItem;
            if (MessageBox.Show("آيا مايل به حذف اين کالا هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                d1.DeleteRecord("sID", u1.Tag.ToString());
                myLibrary.currentParent.Controls.Remove(u1);
                frmToast t1 = new frmToast();
                t1.setComment = "کالاي انتخاب شده حذف شد و از انبار کالا خارج شد";
                t1.Show();
            }
        }
    }
}
