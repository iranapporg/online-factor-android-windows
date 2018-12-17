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
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }
        public static frmmain f1 = new frmmain();
        frmLogin f2 = new frmLogin();
        private void frmfactor_Load(object sender, EventArgs e)
        {
            f1.MdiParent = this;
            frmMDI.f1.Show();
        }
    }
}
