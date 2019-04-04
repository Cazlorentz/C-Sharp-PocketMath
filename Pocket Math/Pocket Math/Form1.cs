using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Pocket_Math
{
    
    public partial class Form1 : Form
    {

        public static List<UserControl> Frames = new List<UserControl>();

        public Form1()
        {
            this.ActiveControl = PMTitle;
            InitializeComponent();
            //Application.EnableVisualStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames.Add(qeS_Frame1);
            Frames.Add(error_Window1);
            this.ActiveControl = PMTitle;
            qeS_Frame1.Hide();
            error_Window1.Hide();
            suM_frame1.Hide();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = PMTitle;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = PMTitle;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = PMTitle;
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PMTitle_Click(object sender, EventArgs e)
        {

        }

        private void QES_Button_Click(object sender, EventArgs e)
        {

        }

        // Point created to make the window move when PMTitle is moved with mouse
        Point newPoint;

        private void PMTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left){
                this.Left += e.X - newPoint.X;
                this.Top += e.Y - newPoint.Y;
            }
        }

        private void PMTitle_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = PMTitle;
            newPoint = new Point(e.X, e.Y);
        }

        private void QES_Button_MouseLeave(object sender, EventArgs e)
        {
            QES_Button.BackColor = Color.FromArgb(15, 15, 15);
            QES_Button.ForeColor = Color.White;
        }

        private void QES_Button_MouseMove(object sender, MouseEventArgs e)
        {
            QES_Button.BackColor = Color.White;
            QES_Button.ForeColor = Color.FromArgb(15, 15, 15);
            
        }

        private void Summation_Button_MouseMove(object sender, MouseEventArgs e)
        {
            Summation_Button.BackColor = Color.White;
            Summation_Button.ForeColor = Color.FromArgb(15, 15, 15);
            
        }

        private void Summation_Button_MouseLeave(object sender, EventArgs e)
        {
            Summation_Button.BackColor = Color.FromArgb(15, 15, 15);
            Summation_Button.ForeColor = Color.White;
        }

        private void Product_Button_MouseMove(object sender, MouseEventArgs e)
        {
            Product_Button.BackColor = Color.White;
            Product_Button.ForeColor = Color.FromArgb(15, 15, 15);
            
        }

        private void Product_Button_MouseLeave(object sender, EventArgs e)
        {
            Product_Button.BackColor = Color.FromArgb(15, 15, 15);
            Product_Button.ForeColor = Color.White;

        }

        private void Regression_Button_MouseMove(object sender, MouseEventArgs e)
        {
            Regression_Button.BackColor = Color.White;
            Regression_Button.ForeColor = Color.FromArgb(15, 15, 15);
            
        }

        private void Regression_Button_MouseLeave(object sender, EventArgs e)
        {
            Regression_Button.ForeColor = Color.White;
            Regression_Button.BackColor = Color.FromArgb(15, 15, 15);
        }

        private void Vector_Button_MouseMove(object sender, MouseEventArgs e)
        {
            Vector_Button.BackColor = Color.White;
            Vector_Button.ForeColor = Color.FromArgb(15, 15, 15);
            
        }

        private void Vector_Button_MouseLeave(object sender, EventArgs e)
        {
            Vector_Button.ForeColor = Color.White;
            Vector_Button.BackColor = Color.FromArgb(15, 15, 15);
        }

        private void QES_Button_Click_1(object sender, EventArgs e)
        {
            qeS_Frame1.Show();
            qeS_Frame1.BringToFront();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Summation_Button_Click(object sender, EventArgs e)
        {
            suM_frame1.Show();
            suM_frame1.BringToFront();
        }
    }
}
