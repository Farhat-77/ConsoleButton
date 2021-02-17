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
    public partial class Form1 : Form
    {
        Class1 cli = new Class1();
        Button btn1;
        public Form1()
        {
            InitializeComponent();
            cli.CreateMyButtons(btn1, this, "example", 50, 50, 120, 50, Click_My_Button);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public void Click_My_Button(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }
    }
}
