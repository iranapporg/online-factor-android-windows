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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            /*if (txtuser.Text.Length != 11)
            {
                MessageBox.Show("لطفا نام کاربري را به صورت درست وارد کنيد\r\nنام کاربري،شماره تماسي است که تعريف شده است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (txtpass.Text.Length < 3)
            {
                MessageBox.Show("لطفا رمز عبور را وارد کنيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Account acc = new Account(txtuser.Text, txtpass.Text);

            if (acc.Login() == true)
            {
                acc.saveLoginData();
                Hide();*/
                myLibrary.myUsername = txtuser.Text;
                frmMDI.f1.Show();
            /*}
            else {
                MessageBox.Show("کاربري با اين مشحصات وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
