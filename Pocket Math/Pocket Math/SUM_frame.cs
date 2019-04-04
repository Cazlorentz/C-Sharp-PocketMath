using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pocket_Math;

namespace Pocket_Math
{
    public partial class SUM_frame : UserControl
    {
        public SUM_frame()
        {
            InitializeComponent();
        }

        private void Back_arrow_Button_Click(object sender, EventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                n_input.Text = "...";
                n_input.ForeColor = Color.DodgerBlue;
                nLine.Visible = true;
                this.Hide();
                this.ParentForm.ActiveControl = null;
            }
        }

        private void SUM_frame_Load(object sender, EventArgs e)
        {

        }

        private void n_input_Enter(object sender, EventArgs e)
        {
            if (n_input.Text == "...")
            {
                n_input.Text = "";
                n_input.ForeColor = Color.White;
                nLine.Visible = false;
            }
            else
            {
                n_input.SelectAll();
            }
        }

        private void n_input_Leave(object sender, EventArgs e)
        {
            if (n_input.Text == "")
            {
                n_input.Text = "...";
                n_input.ForeColor = Color.DodgerBlue;
                nLine.Visible = true;
            }
        }

        private void n_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x1')
            {
                n_input.SelectAll();
                e.Handled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void SUM_frame_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = SumLabel;
        }
    }
}
