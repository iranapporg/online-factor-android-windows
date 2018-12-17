using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Factor.Template
{
    class MYButton : Button
    {
        public MYButton()
        {
            this.BackColor = Color.FromArgb(24, 136, 146);
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("B Nazanin",this.Font.Size);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.ForeColor = Color.White;
            this.FlatAppearance.BorderSize = 0;
            this.MouseHover += new EventHandler(Mouseenter1);
            this.MouseLeave += new EventHandler(Mouseleave1);
        }

        private void Mouseenter1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(56, 187, 199);
        }
        private void Mouseleave1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(24, 136, 146);
        }
    }
}
