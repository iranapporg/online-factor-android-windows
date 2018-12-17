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
    public partial class Factors : Form
    {
        string id;
        int rowIndex;

        public Factors()
        {
            InitializeComponent();
        }

        Database db1 = new Database();

        private void Factors_Load(object sender, EventArgs e)
        {
          dg1.DataSource = db1.SelectRecord("SELECT sID,sShopName,sPhone,sDate,(CASE WHEN sType = '0' THEN 'ارسالی' ELSE 'دریافتی' END) AS sType FROM tbl_factor GROUP BY sID");
          dg1.Columns[0].Width = 135;
          dg1.Columns[0].HeaderText = "کد فاکتور";
          dg1.Columns[1].Width = 192;
          dg1.Columns[1].HeaderText = "نام فروشگاه";
          dg1.Columns[2].Width = 125;
          dg1.Columns[2].HeaderText = "شماره تماس";
          dg1.Columns[3].Width = 105;
          dg1.Columns[3].HeaderText = "تاريخ صدور";
          dg1.Columns[4].Width = 145;
          dg1.Columns[4].HeaderText = "نوع فاکتور";
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToString(dg1.Rows[e.RowIndex].Cells[0].Value);
                rowIndex = e.RowIndex;
            }
            catch(Exception)
            {

            }  
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void mnudelete_Click(object sender, EventArgs e)
        {
            db1.DeleteRecord("sID", id, "tbl_factor");
            db1.DeleteRecord("sFactorID", id, "tbl_factorlist");
            dg1.Rows.RemoveAt(rowIndex);
            frmToast t1 = new frmToast();
            t1.setComment = "فاکتور انتخاب شده حذف شد";
            t1.Show();
        }

        private void mnupreview_Click(object sender, EventArgs e)
        {
    
        }

    }
}
