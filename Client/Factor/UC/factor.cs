using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factor.UC
{
    public partial class factor : UserControl
    {
        Database db1 = new Database();
        DataTable d1;
        double total = 0;
        int sTop = 0;

        public factor()
        {
            InitializeComponent();
            txtname1.Focus();
            db1.GetSourceComboBox("SELECT sName FROM tbl_product", txtname, "sName");
            db1.GetSourceText("SELECT sPhone FROM tbl_factor GROUP BY sPhone", txtphone, "sPhone");
            myLibrary.currentParent = pnllist;
        }

        public void changeTotal(double minusPrice)
        {
            try
            {
                double d1 = Convert.ToDouble(txttotalall.Text.Replace(",", ""));
                d1 = d1 - minusPrice;
                txttotalall.Text = myLibrary.Number2Curreny(d1.ToString());
                if (myLibrary.l1.Count - 1 == 0)
                    sTop = 0;
            }
            catch(Exception)
            {

            }
        }

        private void txtcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '')
                e.Handled = true;
        }


        private void txtcount_TextChanged(object sender, EventArgs e)
        {
            if (txtprice.Text != "0" && d1.Rows.Count > 0)
            {
                try
                {
                    if (Convert.ToInt64(txtcount.Text) > Convert.ToInt64(d1.Rows[0]["sCount"]))
                    {
                        MessageBox.Show("تعداد اقلام انتخابي بيشتر از موجودي است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        txtcount.Text = "0";
                        return;
                    }

                    txttotal.Text = myLibrary.Number2Curreny((Convert.ToInt64(txtcount.Text) * Convert.ToDouble(txtprice.Text.Replace(",",""))).ToString());
                }
                catch(Exception)
                {
                    txttotal.Text = txtcount.Text = "";
                }
            }
        }

        private void txtcount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcount_TextChanged(null, null);
                btninsert.Focus();
            }
        }

        private void addNewItem()
        {
            if (txttotal.Text == "0")
            {
                MessageBox.Show("لطفا اطلاعات کالا را وارد و سپس اضافه کنيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmFactorItem f1 = new frmFactorItem();
            pnllist.Controls.Add(f1);
            f1.Top = sTop;
            f1.Controls["txtname"].Text = txtname1.Text;
            f1.Controls["txtprice"].Text = txtprice.Text;
            f1.Controls["txtcount"].Text = txtcount.Text;
            f1.Controls["txttotal"].Text = txttotal.Text;
            f1.Tag = d1.Rows[0]["sID"].ToString();
            total += Convert.ToDouble(txttotal.Text);
            f1.Controls["imgdelete"].Tag = f1;
            sTop += 44;
            pnllist.Height = pnllist.Height + 44;
            Application.DoEvents();
            txttotalall.Text = myLibrary.Number2Curreny((Convert.ToDouble(txttotalall.Text.Replace(",", "")) + Convert.ToDouble(txttotal.Text)).ToString());
            //FactorItem fi1 = new FactorItem();
            //fi1.sCount = txtcount.Text;
            //fi1.sName = txtname.Text;
            //fi1.sID   = d1.Rows[0]["sID"].ToString();
            //fi1.sPrice = txtprice.Text.Replace(",", "");
            myLibrary.factorList.AddNewProduct(txtname1.Text, txtprice.Text.Replace(",", ""), txtcount.Text, txttotal.Text.Replace(",", ""), d1.Rows[0]["sID"].ToString());
            txtcount.Text = txtprice.Text = txttotal.Text = "0";
            txtname1.Text = "";
            d1.Clear();
            txtname1.Focus();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                getPriceProduct();
            }
        }

        private void getPriceProduct()
        {
            d1 = db1.SelectRecord("SELECT sCount,sPrice,sID FROM tbl_product WHERE sName = '" + txtname.Text + "'");
            if (d1.Rows.Count != 0)
            {
                txtprice.Text = myLibrary.Number2Curreny(d1.Rows[0]["sPrice"].ToString());
                txtcount.Focus();
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            addNewItem();
        }

        private void btnfactor_Click(object sender, EventArgs e)
        {
            if (myLibrary.l1.Count == 0)
            {
                MessageBox.Show("لطفا فاکتور را کامل سپس صادر کنيد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtname1.Focus();
                return;
            }
            if (txtphone.Text.Length != 11)
            {
                MessageBox.Show("لطفا شماره تماس مشتري را وارد کنيد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtphone.Focus();
                return;
            }
            //if (txtshop.Text.Length < 4)
            //{
            //    MessageBox.Show("لطفا نام فروشگاه را وارد کنيد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtshop.Focus();
            //    return;
            //}
            string id = db1.NewFactor(txtphone.Text);
            myLibrary.ExecuteRequest("action=newfactor&phone=" + txtphone.Text + "&username=" + myLibrary.myUsername + "&date=" + myLibrary.getDate() + "&factor_id=" + id + "&factor=" + myLibrary.factorList.List2Json(), myLibrary.BaseUrl + "factor.php");
            frmToast t1 = new frmToast();
            t1.setComment = "فاکتور با موفقيت صادر شد";
            t1.Show();
            pnllist.Controls.Clear();
            sTop = 0;
            myLibrary.l1.Clear();
            txttotalall.Text = "0";
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
    
        }

        private void btnfactors_Click(object sender, EventArgs e)
        {
            Factors fact1 = new Factors();
            fact1.Show();
        }

        private void sb1_Scroll(object sender, ScrollEventArgs e)
        {
            pnllist.Top = -(e.NewValue * 10);
        }

        private void txttotalall_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPriceProduct();
        }
    }
}
