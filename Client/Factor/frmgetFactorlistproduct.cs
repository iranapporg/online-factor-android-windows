using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factor
{
    public partial class frmgetFactorlistproduct : Form
    {
        public string FactorID;
        public string sDate, sShopName,sPhone;

        public frmgetFactorlistproduct()
        {
            InitializeComponent();
        }

        public bool blnAccept = false;
        FactorItem[] d3 ;

        public void fillData(object[] oj1)
        {
            int j = 0;
            double total = 0;
            int sTop = 0;
            FactorItem[] d2 = oj1[0] as FactorItem[];
            d3 = d2;

            for (int i = 0; i <= d2.Length- 1; i++)
            {
                frmItem1 f1 = new frmItem1();
                FactorItem d1 = d2[i];
                if (d1 != null)
                {
                    pnlist.Controls.Add(f1);
                    f1.Top = sTop;
                    f1.Controls["txtnumber"].Text = (i + 1).ToString();
                    f1.Controls["txtname"].Text = d1.sName;
                    f1.Controls["txtprice"].Text = myLibrary.Number2Curreny(d1.sPrice);
                    f1.Controls["txtcount"].Text = d1.sCount;
                    total += (Convert.ToDouble(d1.sCount) * Convert.ToDouble(d1.sPrice));
                    f1.Tag = d1.sID;
                    sTop += 44;
                    pnlist.Height = pnlist.Height + 44;
                    j = i;
                    lbltotal.Text = myLibrary.Number2Curreny(total.ToString()) + " ريال";
                    Application.DoEvents();
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void sb1_Scroll(object sender, ScrollEventArgs e)
        {
            pnlist.Top = -(e.NewValue * 10);
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            Database db1 = new Database();
            for (int i = 0; i <= d3.Length - 1; i++)
            {
                FactorItem d1 = d3[i];
                if (d1 != null)
                {
                    if (db1.RecordCount("sName", d1.sName) == 0)
                    {
                        db1.NewProduct(d1.sName, d1.sCount, d1.sPrice,d1.sID);
                    }
                    else
                    {
                        db1.ExecuteQuery(String.Format("UPDATE tbl_product SET sCount = sCount + {0},sPrice = {1} WHERE sID = '{2}'", d1.sCount, d1.sPrice, d1.sID));
                    }
                    db1.ExecuteQuery(String.Format("INSERT INTO tbl_factor(sID,sDate,sShopName,sPhone,sType) VALUES('{0}','{1}','{2}','{3}','1')",FactorID,sDate,sShopName,sPhone));
                    db1.NewProduct2(d1.sID, FactorID);
                }
            }
            string res = myLibrary.ExecuteRequest("action=verify&username=" + myLibrary.myUsername + "&factor_id=" + FactorID, myLibrary.BaseUrl + "verify.php").ToString();
            blnAccept = true;
            Hide();
        }

    }
}
