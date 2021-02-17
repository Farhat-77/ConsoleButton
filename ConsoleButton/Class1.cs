using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConsoleButton
{
    class Class1 : Button
    {
        public void CreateMyButtons(Button btn, Form frm, string str, int x, int y, int w, int h, EventMandler evh)
        {
            btn = new Button();
            btn.Text = str;
            btn.Location = new Point(x, y);
            btn.Size = new Size(w, h);
            btn.Click += evh;

            frm.Controls.Add(btn);
        }
    }
}
