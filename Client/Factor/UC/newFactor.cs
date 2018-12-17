using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Factor.Template;
using Newtonsoft.Json;

namespace Factor
{
    public partial class newFactor : UserControl
    {
        public newFactor()
        {
            InitializeComponent();
            myLibrary.currentParent = pnllist;
        }
        int sTop = 0;

        private void newFactor_Load(object sender, EventArgs e)
        {
            string res = myLibrary.ExecuteRequest("action=check&username=" + myLibrary.myUsername, myLibrary.BaseUrl + "check_new_factor.php").ToString();
            string[] s1 = res.Split(new string[] {"<p>"},StringSplitOptions.None);
            lblcount.Text = "به تعداد " + (s1.Length-1) + " فاکتور دريافت شده است";

            for (int i = 0; i < s1.Length -1; i++)
            {
                string[] inf1 = s1[i].Split(new string[] { "<!!!!>" }, StringSplitOptions.None);
                string[] int2 = inf1[0].Split(new string[] { "<!!>" }, StringSplitOptions.None);

                newFactorItem f1 = new newFactorItem();
                pnllist.Controls.Add(f1);
                f1.Top = sTop;
                f1.Controls["txtcode"].Text = int2[2];
                f1.Controls["txtshop"].Tag = int2[3];
                f1.Controls["txtshop"].Text = int2[1];
                f1.Controls["txtdate"].Text = int2[0];
                f1.Controls["txtnumber"].Text = (i + 1).ToString();
                f1.Tag = f1;
                f1.Controls["btnpreview"].Tag = getProductList(inf1[1]);
                sTop += 44;
                pnllist.Height = pnllist.Height + 44;
                Application.DoEvents();
            }
        }

        private FactorItem[] getProductList(string res)
        {
            

            string[] pr = res.Split(new string[] { "???" }, StringSplitOptions.None);
            FactorItem[] fi = new FactorItem[pr.Length];

              for (int i = 0; i < pr.Length -1; i++)
              {
                      string[] pr1 = pr[i].Split(new string[] { "!!!" }, StringSplitOptions.None);
                      if (pr1[0] != "")
                      {
                          fi[i] = new FactorItem();
                          fi[i].sID = pr1[3];
                          fi[i].sName = pr1[0];
                          fi[i].sCount = pr1[2];
                          fi[i].sPrice = pr1[1];
                      }
              }
              return fi;
        }
    }
}
