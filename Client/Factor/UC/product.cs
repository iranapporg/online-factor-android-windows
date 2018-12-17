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
    public partial class product : UserControl
    {
        Database d1 = new Database();
        public product()
        {
            InitializeComponent();
            d1.GetSourceText("SELECT sName FROM tbl_product", txtname, "sName");
            txtname.Focus();
            
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                long c1 = Convert.ToInt64(txtcode.Text);
                if (existCode() == false)
                {
                    picode.Image = Factor.Properties.Resources.correct;
                    picode.Visible = true;
                }
                else
                    return;
            }
            catch (Exception)
            {
                picode.Image = Factor.Properties.Resources.incorrect;
                picode.Visible = true;
                return;
            }

            if (txtname.Text.Trim().Length < 2)
            {
                picname.Visible = true;
                picname.Image = Factor.Properties.Resources.incorrect;
                return;
            }
            else
            {
                picname.Image = Factor.Properties.Resources.correct;
                picname.Visible = true;
            }
            try 
            {
                long i = Convert.ToInt64(txtcount.Text);
                piccount.Image = Factor.Properties.Resources.correct;
                piccount.Visible = true;
            }
            catch(Exception)
            {
                piccount.Image = Factor.Properties.Resources.incorrect;
                piccount.Visible = true;
                return;
            }

            try
            {
                double i = Convert.ToUInt64(txtprice.Text.Replace(",",""));
                picprice.Image = Factor.Properties.Resources.correct;
                picprice.Visible = true;
            }
            catch (Exception)
            {
                picprice.Image = Factor.Properties.Resources.incorrect;
                picprice.Visible = true;
                return;
            }
   
            if (d1.RecordCount("sName", txtname.Text) == 0)
            {
                d1.NewProduct(txtname.Text, txtcount.Text.Replace(",", ""), txtprice.Text.Replace(",", ""),txtcode.Text);
                frmToast t1 = new frmToast();
                t1.setComment = "کالاي جديد با موفقيت در انبار ذخيره شد";
                t1.Show();
            }
            else
            {
                if (MessageBox.Show("اين کالا قبلا در انبار وجود داشته است\r\nآيا مايل به اضافه کردن موجودي و اعمال تغيرات هستيد?", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    d1.ModifyProduct(txtcount.Text, txtprice.Text.Replace(",", ""), txtname.Text);
                    MessageBox.Show("موجودي انبار تغيير داده شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtname.Text = txtprice.Text = txtcount.Text = txtcode.Text = "";
            piccount.Visible = false;
            picname.Visible = false;
            picprice.Visible = false;
            picode.Visible = false;
            txtname.Focus();
            frmToast Toast = new frmToast();
            Toast.setComment = "کالا به انبار اضافه شد";
            Toast.Show();
        }

        private void txtcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '')
                e.Handled = true;
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '')
                e.Handled = true;
        }

        private void txtprice_Leave(object sender, EventArgs e)
        {
            txtprice.Text = myLibrary.Number2Curreny(txtprice.Text.Replace(",", ""));
        }

        private void txtcode_Leave(object sender, EventArgs e)
        {
            existCode();
        }

        private bool existCode()
        {
            if (txtcode.Text.Length > 0)
            {
                int count = d1.RecordCount("sID", txtcode.Text);
                if (count > 0)
                {
                    txtcode.Text = "";
                    MessageBox.Show("کالايي با اين کد از قبل در انبار وجود دارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
            
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txtname.Focus();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txtcount.Focus();
        }

        private void txtcount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txtprice.Focus();
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                btninsert.Focus();
        }
    }
}
