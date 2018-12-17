using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Factor.UC;
using System.Net.NetworkInformation;

namespace Factor
{
    public partial class frmmain : Form
    {
        

        public frmmain()
        {
            InitializeComponent();
        }
        string action;

        #region Item State
        private void pnlproduct_MouseHover(object sender, EventArgs e)
        {
            Panel p1;
            p1 = sender as Panel;
            if (action != p1.Tag.ToString())
            {
                p1.BackColor = Color.FromArgb(38, 177, 189);
                p1.Invalidate();
            }
        }

        private void pnlproduct_MouseLeave(object sender, EventArgs e)
        {
            Panel p1;
            p1 = sender as Panel;
            Application.DoEvents();
            if (action != p1.Tag.ToString())
                p1.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void picproduct_MouseHover(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (action != "product")
                pnlproduct.BackColor = Color.FromArgb(38, 177, 189);
        }

        private void picproduct_MouseLeave(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (action != "product")
                pnlproduct.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void picstore_MouseHover(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (action != "store")
                pnlstore.BackColor = Color.FromArgb(38, 177, 189);
        }

        private void picstore_MouseLeave(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (action != "store")
                pnlstore.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void picfactor_MouseHover(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (action != "factor")
                pnlfactor.BackColor = Color.FromArgb(38, 177, 189);
        }

        private void picfactor_MouseLeave(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (action != "factor")
                pnlfactor.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void picnewfactor_MouseHover(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (action != "newfactor")
                pnlnewfactor.BackColor = Color.FromArgb(38, 177, 189);
        }

        private void picnewfactor_MouseLeave(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (action != "newfactor")
                pnlnewfactor.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void pnlproduct_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            action = "product";
            pnlstore.BackColor = Color.FromArgb(51, 51, 51);
            pnlfactor.BackColor = Color.FromArgb(51, 51, 51);
            pnlnewfactor.BackColor = Color.FromArgb(51, 51, 51);
            pnlproduct.BackColor = Color.FromArgb(24, 136, 146);
            product p1 = new product();
            pnlparent.Controls.Clear();
            pnlparent.Controls.Add(p1);
            
        }

        private void picstore_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            action = "store";
            pnlstore.BackColor = Color.FromArgb(24, 136, 146);
            pnlproduct.BackColor = Color.FromArgb(51, 51, 51);
            pnlfactor.BackColor = Color.FromArgb(51, 51, 51);
            pnlnewfactor.BackColor = Color.FromArgb(51, 51, 51);
            frmstore p1 = new frmstore();
            pnlparent.Controls.Clear();
            pnlparent.Controls.Add(p1);
        }

        private void picfactor_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            action = "factor";
            pnlfactor.BackColor = Color.FromArgb(24, 136, 146);
            pnlproduct.BackColor = Color.FromArgb(51, 51, 51);
            pnlstore.BackColor = Color.FromArgb(51, 51, 51);
            pnlnewfactor.BackColor = Color.FromArgb(51, 51, 51);
            factor p1 = new factor();
            myLibrary.Currentfactor = p1;
            pnlparent.Controls.Clear();
            pnlparent.Controls.Add(p1);
        }

        private void picnewfactor_Click(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable() == false)
            {
                MessageBox.Show("لطفا اينترنت را فعال کنيد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            action = "newfactor";
            pnlfactor.BackColor = Color.FromArgb(51, 51, 51);
            pnlproduct.BackColor = Color.FromArgb(51, 51, 51);
            pnlstore.BackColor = Color.FromArgb(51, 51, 51);
            pnlnewfactor.BackColor = Color.FromArgb(24, 136, 146);
            newFactor p1 = new newFactor();
            pnlparent.Controls.Clear();
            pnlparent.Controls.Add(p1);
        }

        #endregion

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آيا مايل به خروج از حساب کاربري خود هستيد؟","خروج",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            pnlproduct_Click(null, null);
            NetworkChange.NetworkAvailabilityChanged
                  += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);
            if (NetworkInterface.GetIsNetworkAvailable() == true)
                timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable() == false)
                timer1.Enabled = false;
            string res = myLibrary.ExecuteRequest("action=check&type=numbers&username=" + myLibrary.myUsername, myLibrary.BaseUrl + "check_new_factor.php").ToString();
            try
            {
                double count = Convert.ToInt64(res);
                if (count > 0)
                {
                    txtfactorcount.Visible = true;
                    picnewfactor.Image = Factor.Properties.Resources.new_factor_on;
                    txtfactorcount.Text = res;
                }
                else
                {
                    txtfactorcount.Visible = false;
                    picnewfactor.Image = Factor.Properties.Resources.new_factor;
                }
            }
            catch (System.Exception ex)
            {
                txtfactorcount.Visible = false;
                picnewfactor.Image = Factor.Properties.Resources.new_factor;
            }
        }

        void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable == true)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

    }
}
