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
using DynamicExpresso;

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
                i_input.Text = "...";
                i_input.ForeColor = Color.DodgerBlue;
                iLine.Visible = true;
                inputSum.Text = "...";
                inputSum.ForeColor = Color.DodgerBlue;
                inputLine.Visible = true;
                SumResult.Text = null;
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

        private void i_input_Enter(object sender, EventArgs e)
        {
            if (i_input.Text == "...")
            {
                i_input.Text = "";
                i_input.ForeColor = Color.White;
                iLine.Visible = false;
            }
            else
            {
                i_input.SelectAll();
            }
        }

        private void i_input_Leave(object sender, EventArgs e)
        {
            if (i_input.Text == "")
            {
                i_input.Text = "...";
                i_input.ForeColor = Color.DodgerBlue;
                iLine.Visible = true;
            }
        }

        private void i_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x1')
            {
                i_input.SelectAll();
                e.Handled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void InputSum_Enter(object sender, EventArgs e)
        {
            if (inputSum.Text == "...")
            {
                inputSum.Text = "";
                inputSum.ForeColor = Color.White;
                inputLine.Visible = false;
            }
            else
            {
                inputSum.SelectAll();
            }
        }

        private void InputSum_Leave(object sender, EventArgs e)
        {
            if (inputSum.Text == "")
            {
                inputSum.Text = "...";
                inputSum.ForeColor = Color.DodgerBlue;
                inputLine.Visible = true;
            }
        }

        private void SumResult_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SumResult.DisplayRectangle, Color.DeepSkyBlue, ButtonBorderStyle.Solid);
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            if (n_input.Text == "..." || i_input.Text=="..." || inputSum.Text == "...")
            {
                CallErrorWindow();
            }
            else
            {
                try
                {
                    int upper = Convert.ToInt32(n_input.Text);
                    int lower = Convert.ToInt32(i_input.Text);
                    if (upper < lower)
                    {
                        throw new Exception();
                    }
                    Interpreter interpreter = new Interpreter();
                    double result = 0;
                    for (int i = lower; i < upper+1; i++)
                    {
                        result += Convert.ToDouble(interpreter.Eval(inputSum.Text, new Parameter("i", typeof(double),i)));
                    }
                    SumResult.Text = Convert.ToString(result);
                }
                catch (Exception)
                {
                    CallErrorWindow();
                   
                }
            }
        }

        public void CallErrorWindow()
        {
            if (!Error_Window.errorKey)
            {
                Error_Window error = new Error_Window();
                Error_Window.errorKey = true;
                this.Controls.Add(error);
                error.BringToFront();
                error.Left = (this.ClientSize.Width - error.Width) / 2;
                error.Top = (this.ClientSize.Height - error.Height) / 2 - 100;
                error.Focus();
            }
        }
    }
}
