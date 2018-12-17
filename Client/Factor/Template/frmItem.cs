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
    public partial class frmItem : UserControl
    {
        Database d1 = new Database();
        public bool blnStore = true;

        public frmItem()
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
                t1.setComment = "کالا از انبار خارج شد";
                t1.Show();
            }
        }

        private void txtcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '')
                e.Handled = true;
        }

        private void txtcount_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox t1 = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Convert.ToDouble(txtcount.Text) > 0)
                    {
                        d1.ExecuteQuery(String.Format("UPDATE tbl_product SET sCount = {0} WHERE sID = {1}",txtcount.Text,t1.Tag.ToString()));
                        frmToast to1 = new frmToast();
                        to1.setComment = "عمليات با موفقيت انجام شد";
                        to1.Show();
                    }
                    else
                    {
                        MessageBox.Show("لطفا تعداد کالا را بيشتر از صفر بدهيد","اخطار",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        txtcount.Text = "0";
                        txtcount.Focus();
                        return;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("لطفا تعداد کالا را بيشتر از صفر بدهيد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcount.Text = "0";
                    txtcount.Focus();
                    return;
                }
            }
        }
    }
}
