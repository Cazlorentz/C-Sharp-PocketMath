namespace Pocket_Math
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.QES_Button = new System.Windows.Forms.Button();
            this.PMTitle = new System.Windows.Forms.Label();
            this.Summation_Button = new System.Windows.Forms.Button();
            this.Product_Button = new System.Windows.Forms.Button();
            this.Regression_Button = new System.Windows.Forms.Button();
            this.Vector_Button = new System.Windows.Forms.Button();
            this.error_Window1 = new Pocket_Math.Error_Window();
            this.qeS_Frame1 = new Pocket_Math.QES_Frame();
            this.suM_frame1 = new Pocket_Math.SUM_frame();
            this.SuspendLayout();
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            resources.ApplyResources(this.Minimize_Button, "Minimize_Button");
            this.Minimize_Button.ForeColor = System.Drawing.Color.White;
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Close_Button, "Close_Button");
            this.Close_Button.ForeColor = System.Drawing.Color.White;
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // QES_Button
            // 
            this.QES_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.QES_Button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.QES_Button, "QES_Button");
            this.QES_Button.ForeColor = System.Drawing.Color.White;
            this.QES_Button.Name = "QES_Button";
            this.QES_Button.UseVisualStyleBackColor = false;
            this.QES_Button.Click += new System.EventHandler(this.QES_Button_Click_1);
            this.QES_Button.MouseLeave += new System.EventHandler(this.QES_Button_MouseLeave);
            this.QES_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QES_Button_MouseMove);
            // 
            // PMTitle
            // 
            this.PMTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            resources.ApplyResources(this.PMTitle, "PMTitle");
            this.PMTitle.ForeColor = System.Drawing.Color.Blue;
            this.PMTitle.Name = "PMTitle";
            this.PMTitle.Click += new System.EventHandler(this.label1_Click_1);
            this.PMTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PMTitle_MouseDown);
            this.PMTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PMTitle_MouseMove);
            // 
            // Summation_Button
            // 
            this.Summation_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Summation_Button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.Summation_Button, "Summation_Button");
            this.Summation_Button.ForeColor = System.Drawing.Color.White;
            this.Summation_Button.Name = "Summation_Button";
            this.Summation_Button.UseVisualStyleBackColor = false;
            this.Summation_Button.Click += new System.EventHandler(this.Summation_Button_Click);
            this.Summation_Button.MouseLeave += new System.EventHandler(this.Summation_Button_MouseLeave);
            this.Summation_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Summation_Button_MouseMove);
            // 
            // Product_Button
            // 
            this.Product_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Product_Button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.Product_Button, "Product_Button");
            this.Product_Button.ForeColor = System.Drawing.Color.White;
            this.Product_Button.Name = "Product_Button";
            this.Product_Button.UseVisualStyleBackColor = false;
            this.Product_Button.MouseLeave += new System.EventHandler(this.Product_Button_MouseLeave);
            this.Product_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Product_Button_MouseMove);
            // 
            // Regression_Button
            // 
            this.Regression_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Regression_Button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.Regression_Button, "Regression_Button");
            this.Regression_Button.ForeColor = System.Drawing.Color.White;
            this.Regression_Button.Name = "Regression_Button";
            this.Regression_Button.UseVisualStyleBackColor = false;
            this.Regression_Button.MouseLeave += new System.EventHandler(this.Regression_Button_MouseLeave);
            this.Regression_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Regression_Button_MouseMove);
            // 
            // Vector_Button
            // 
            this.Vector_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Vector_Button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.Vector_Button, "Vector_Button");
            this.Vector_Button.ForeColor = System.Drawing.Color.White;
            this.Vector_Button.Name = "Vector_Button";
            this.Vector_Button.UseVisualStyleBackColor = false;
            this.Vector_Button.MouseLeave += new System.EventHandler(this.Vector_Button_MouseLeave);
            this.Vector_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vector_Button_MouseMove);
            // 
            // error_Window1
            // 
            resources.ApplyResources(this.error_Window1, "error_Window1");
            this.error_Window1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.error_Window1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.error_Window1.ForeColor = System.Drawing.Color.Blue;
            this.error_Window1.Name = "error_Window1";
            // 
            // qeS_Frame1
            // 
            this.qeS_Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.qeS_Frame1.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.qeS_Frame1, "qeS_Frame1");
            this.qeS_Frame1.Name = "qeS_Frame1";
            // 
            // suM_frame1
            // 
            this.suM_frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            resources.ApplyResources(this.suM_frame1, "suM_frame1");
            this.suM_frame1.Name = "suM_frame1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.PMTitle);
            this.Controls.Add(this.Vector_Button);
            this.Controls.Add(this.Regression_Button);
            this.Controls.Add(this.Product_Button);
            this.Controls.Add(this.Summation_Button);
            this.Controls.Add(this.QES_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.error_Window1);
            this.Controls.Add(this.qeS_Frame1);
            this.Controls.Add(this.suM_frame1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button QES_Button;
        private System.Windows.Forms.Button Summation_Button;
        private System.Windows.Forms.Button Product_Button;
        private System.Windows.Forms.Button Regression_Button;
        private System.Windows.Forms.Button Vector_Button;
        private Error_Window error_Window1;
        public System.Windows.Forms.Label PMTitle;
        private QES_Frame qeS_Frame1;
        private SUM_frame suM_frame1;
    }
}

