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
    public partial class frmstore : UserControl
    {
        public frmstore()
        {
            InitializeComponent();
            myLibrary.currentParent = pnllist;
        }
        Database db1 = new Database();
        private void UserControl1_Load(object sender, EventArgs e)
        {
            DataTable d1 = db1.SelectRecord("SELECT * FROM tbl_product ORDER BY sID DESC");
            fillData(d1);
        }

        void fillData(DataTable d1)
        {
            int j = 0;
            double total = 0;
            int sTop = 0;
            for (int i = 0; i <= d1.Rows.Count - 1; i++)
            {
                frmItem f1 = new frmItem();
                pnllist.Controls.Add(f1);
                f1.Top = sTop;
                f1.Controls["txtnumber"].Text = (i + 1).ToString();
                f1.Controls["txtname"].Text = d1.Rows[i]["sName"].ToString();
                f1.Controls["txtprice"].Text = myLibrary.Number2Curreny(d1.Rows[i]["sPrice"].ToString());
                f1.Controls["txtcount"].Text = d1.Rows[i]["sCount"].ToString();
                f1.Controls["txtcount"].Tag = d1.Rows[i]["sID"].ToString();
                total += (Convert.ToDouble(d1.Rows[i]["sCount"]) * Convert.ToDouble(d1.Rows[i]["sPrice"]));
                f1.Tag = d1.Rows[i]["sID"].ToString();
                f1.Controls["imgdelete"].Tag = f1;
                sTop += 44;
                pnllist.Height = pnllist.Height + 44;
                j = i;
                lbltotal.Text = myLibrary.Number2Curreny(total.ToString()) + " ريال";
                Application.DoEvents();
            }
        }
        private void sb1_Scroll(object sender, ScrollEventArgs e)
        {
            pnllist.Top = -(e.NewValue * 10);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Length < 2)
            {
                DataTable d2 = db1.SelectRecord("SELECT * FROM tbl_product ORDER BY sID DESC");
                pnllist.Controls.Clear();
                fillData(d2);
                return;
            }
            DataTable d1 = db1.SelectRecord(String.Format("SELECT * FROM tbl_product WHERE sName LIKE '%{0}%'",txtsearch.Text));
            pnllist.Controls.Clear();
            fillData(d1);
        }
    }
}
