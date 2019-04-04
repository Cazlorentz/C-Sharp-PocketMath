using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pocket_Math
{
    public partial class Error_Window : UserControl
    {
        public static bool errorKey = false;

        public Error_Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorKey = false;
            this.Hide();
        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void Error_Window_Leave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(15, 15, 15);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(15, 15, 15);
        }
    }
}
