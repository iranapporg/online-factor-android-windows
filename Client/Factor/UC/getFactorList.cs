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
    public partial class getFactorList : UserControl
    {
        public DataTable d1;
        public getFactorList()
        {
            InitializeComponent();
            myLibrary.currentParent = pnllist;
        }

        void fillData()
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
                total += (Convert.ToDouble(d1.Rows[i]["sCount"]) * Convert.ToDouble(d1.Rows[i]["sPrice"]));
                f1.Tag = d1.Rows[i]["sID"].ToString();
                f1.Controls["imgdelete"].Visible = false;
                sTop += 44;
                pnllist.Height = pnllist.Height + 44;
                j = i;
                lbltotal.Text = myLibrary.Number2Curreny(total.ToString()) + " ريال";
                Application.DoEvents();
            }
        }
    }
}
