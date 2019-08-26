using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using Pocket_Math;
using System.Windows.Media.Animation;

namespace Pocket_Math
{
    public partial class QES_Frame : UserControl
    {

        public QES_Frame()
        {
            InitializeComponent();
        }

        private void QES_Frame_Load(object sender, EventArgs e)
        {
            CopyX1.Visible = false;
            CopyX2.Visible = false;
            CopyD.Visible = false;
            CopyTx.Visible = false;
            CopyTy.Visible = false;
            Back_arrow_Button.TabStop = false;

        }

        private void Back_arrow_Button_Click(object sender, EventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                a_input.Text = "..."; a_input.ForeColor = Color.DodgerBlue;
                b_input.Text = "..."; b_input.ForeColor = Color.DodgerBlue;
                c_input.Text = "..."; c_input.ForeColor = Color.DodgerBlue;
                x1Result.Text = null;
                x2Result.Text = null;
                DResult.Text = null;
                TxResult.Text = null;
                TyResult.Text = null;
                Hide();
                this.ParentForm.ActiveControl = null;
            }
        }

        private void Back_arrow_Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (Error_Window.errorKey)
            {
                Back_arrow_Button.Cursor = Cursors.Default;
            }
            else
            {
                Back_arrow_Button.Cursor = Cursors.Hand;
            }
        }

        private void a_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            char ch = e.KeyChar;

            if (ch == '\x1')
            {
                a_input.SelectAll();
                e.Handled = true;
            }

            if (ch == 45 && (textBox.SelectionStart != 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
                return;
            }

            if (ch == 46 && a_input.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void b_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            char ch = e.KeyChar;

            if (ch == '\x1')
            {
                b_input.SelectAll();
                e.Handled = true;
            }

            if (ch == 45 && (textBox.SelectionStart != 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
                return;
            }

            if (ch == 46 && b_input.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void c_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            char ch = e.KeyChar;

            if (ch == '\x1')
            {
                c_input.SelectAll();
                e.Handled = true;
            }

            if (ch == 45 && (textBox.SelectionStart != 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
                return;
            }

            if (ch == 46 && c_input.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void SolveButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                SolveButton.BackColor = Color.White;
                SolveButton.ForeColor = Color.FromArgb(15, 15, 15);
            }
            
        }

        private void SolveButton_MouseLeave(object sender, EventArgs e)
        {
            SolveButton.BackColor = Color.FromArgb(15, 15, 15);
            SolveButton.ForeColor = Color.White;
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            if (b_input.Text == "...")
            {
                b_input.Text = "0";
                b_input.ForeColor = Color.White;
            }
            if (c_input.Text == "...")
            {
                c_input.Text = "0";
                c_input.ForeColor = Color.White;
            }
            bool success = false;
            try
            {
                double a1 = Double.Parse(a_input.Text);
                double b1 = Double.Parse(b_input.Text);
                double c1 = Double.Parse(c_input.Text);
                if (a_input.Text == "0")
                {
                    throw new Exception();
                }
                success = true;
            }
            catch (Exception)
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
            finally
            {
                if (success)
                {
                    double a_value = Double.Parse(a_input.Text, CultureInfo.InvariantCulture);
                    double b_value = Double.Parse(b_input.Text, CultureInfo.InvariantCulture);
                    double c_value = Double.Parse(c_input.Text, CultureInfo.InvariantCulture);
                    double D = QESSOLVER.Discriminant(a_value, b_value, c_value);
                    List<object> solutions = QESSOLVER.Solutions(a_value, b_value, c_value);
                    List<double> extrema = QESSOLVER.Extrema(a_value, b_value, c_value);
                    x1Result.Text = Convert.ToString(solutions[0]);
                    x2Result.Text = Convert.ToString(solutions[1]);
                    DResult.Text = Convert.ToString(D);
                    TxResult.Text = Convert.ToString(extrema[0]);
                    TyResult.Text = Convert.ToString(extrema[1]);

                }
            }
            this.ActiveControl = QESLabel;




        }

        private void a_input_Leave(object sender, EventArgs e)
        {
            if (a_input.Text == "")
            {
                a_input.Text = "...";
                a_input.ForeColor = Color.DodgerBlue;
                return;
            }
            else
            {

            }
        }

        private void a_input_Enter(object sender, EventArgs e)
        {
            if (a_input.Text == "...")
            {
                a_input.Text = "";
                a_input.ForeColor = Color.White;
                return;
            }
            else
            {
                a_input.SelectAll();
            }
        }

        private void b_input_Enter(object sender, EventArgs e)
        {
            if (b_input.Text == "...")
            {
                b_input.Text = "";
                b_input.ForeColor = Color.White;
                return;
            }
            else
            {
                b_input.SelectAll();
            }
        }

        private void b_input_Leave(object sender, EventArgs e)
        {
            if (b_input.Text == "")
            {
                b_input.Text = "...";
                b_input.ForeColor = Color.DodgerBlue;
                return;
            }
            else
            {

            }
        }

        private void c_input_Leave(object sender, EventArgs e)
        {
            if (c_input.Text == "")
            {
                c_input.Text = "...";
                c_input.ForeColor = Color.DodgerBlue;
                return;
            }
            else
            {

            }
        }

        private void c_input_Enter(object sender, EventArgs e)
        {
            if (c_input.Text == "...")
            {
                c_input.Text = "";
                c_input.ForeColor = Color.White;
                return;
            }
            else
            {
                c_input.SelectAll();
            }
        }

        private void QES_Frame_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = QESLabel;
        }

        private void x1Result_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, x1Result.DisplayRectangle, Color.DeepSkyBlue, ButtonBorderStyle.Solid);
        }

        private void x1Result_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                x1Result.Cursor = Cursors.Hand;
            }
            else
            {
                x1Result.Cursor = Cursors.Default;

            }
        }

        private void x1Result_Click(object sender, EventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                if (x1Result.Text != "")
                {
                    Clipboard.SetText(x1Result.Text);
                    CopyX1.Visible = true;
                    timer1.Start();
                }
            }
        }

        private void x2Result_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, x1Result.DisplayRectangle, Color.DeepSkyBlue, ButtonBorderStyle.Solid);

        }

        private void x2Result_Click(object sender, EventArgs e)
        {
            if (!Error_Window.errorKey && x2Result.Text != "")
            {
                Clipboard.SetText(x2Result.Text);
                CopyX2.Visible = true;
                timer2.Start();
            }
        }

        private void x2Result_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                x2Result.Cursor = Cursors.Hand;
            }
            else
            {
                x2Result.Cursor = Cursors.Default;

            }
        }

        private void DResult_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                DResult.Cursor = Cursors.Hand;
            }
            else
            {
                DResult.Cursor = Cursors.Default;

            }
        }

        private void DResult_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, DResult.DisplayRectangle, Color.DeepSkyBlue, ButtonBorderStyle.Solid);
        }

        private void DResult_Click(object sender, EventArgs e)
        {
            if (!Error_Window.errorKey && DResult.Text != "")
            {
                Clipboard.SetText(DResult.Text);
                CopyD.Visible = true;
                timer3.Start();
            }
        }

        private void TxResult_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                TxResult.Cursor = Cursors.Hand;
            }
            else
            {
                TxResult.Cursor = Cursors.Default;

            }
        }

        private void TxResult_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, TxResult.DisplayRectangle, Color.DeepSkyBlue, ButtonBorderStyle.Solid);
        }

        private void TxResult_Click(object sender, EventArgs e)
        {
            if (!Error_Window.errorKey && TxResult.Text != "")
            {
                Clipboard.SetText(TxResult.Text);
                CopyTx.Visible = true;
                timer4.Start();
            }
        }

        private void TyResult_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                TyResult.Cursor = Cursors.Hand;
            }
            else
            {
                TyResult.Cursor = Cursors.Default;

            }
        }

        private void TyResult_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, TyResult.DisplayRectangle, Color.DeepSkyBlue, ButtonBorderStyle.Solid);
        }

        private void TyResult_Click(object sender, EventArgs e)
        {
            if (!Error_Window.errorKey && TyResult.Text != "")
            {
                Clipboard.SetText(TyResult.Text);
                CopyTy.Visible = true;
                timer5.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CopyX1.Visible = false;
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CopyX2.Visible = false;
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            CopyD.Visible = false;
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            CopyTx.Visible = false;
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            CopyTy.Visible = false;
            timer5.Stop();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (!Error_Window.errorKey)
            {
                a_input.Text = "..."; a_input.ForeColor = Color.DodgerBlue;
                b_input.Text = "..."; b_input.ForeColor = Color.DodgerBlue;
                c_input.Text = "..."; c_input.ForeColor = Color.DodgerBlue;
                x1Result.Text = null;
                x2Result.Text = null;
                DResult.Text = null;
                TxResult.Text = null;
                TyResult.Text = null;
            }
            this.ActiveControl = QESLabel;
        }
    }
}
