namespace Pocket_Math
{
    partial class SUM_frame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUM_frame));
            this.Back_arrow_Button = new System.Windows.Forms.Button();
            this.SumLabel = new System.Windows.Forms.Label();
            this.BlueSigma = new System.Windows.Forms.PictureBox();
            this.nLine = new System.Windows.Forms.Label();
            this.n_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSigma)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_arrow_Button
            // 
            this.Back_arrow_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Back_arrow_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_arrow_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_arrow_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back_arrow_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back_arrow_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_arrow_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Back_arrow_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_arrow_Button.Image")));
            this.Back_arrow_Button.Location = new System.Drawing.Point(635, 562);
            this.Back_arrow_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Back_arrow_Button.Name = "Back_arrow_Button";
            this.Back_arrow_Button.Size = new System.Drawing.Size(61, 92);
            this.Back_arrow_Button.TabIndex = 6;
            this.Back_arrow_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Back_arrow_Button.UseVisualStyleBackColor = false;
            this.Back_arrow_Button.Click += new System.EventHandler(this.Back_arrow_Button_Click);
            // 
            // SumLabel
            // 
            this.SumLabel.Font = new System.Drawing.Font("Gravity Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumLabel.ForeColor = System.Drawing.Color.Blue;
            this.SumLabel.Location = new System.Drawing.Point(173, 3);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(366, 47);
            this.SumLabel.TabIndex = 36;
            this.SumLabel.Text = "(Summation Notation Calculator)";
            this.SumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlueSigma
            // 
            this.BlueSigma.Image = ((System.Drawing.Image)(resources.GetObject("BlueSigma.Image")));
            this.BlueSigma.Location = new System.Drawing.Point(50, 171);
            this.BlueSigma.Name = "BlueSigma";
            this.BlueSigma.Size = new System.Drawing.Size(245, 295);
            this.BlueSigma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlueSigma.TabIndex = 37;
            this.BlueSigma.TabStop = false;
            // 
            // nLine
            // 
            this.nLine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nLine.ForeColor = System.Drawing.Color.White;
            this.nLine.Location = new System.Drawing.Point(58, 162);
            this.nLine.Name = "nLine";
            this.nLine.Size = new System.Drawing.Size(228, 2);
            this.nLine.TabIndex = 39;
            // 
            // n_input
            // 
            this.n_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.n_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.n_input.Font = new System.Drawing.Font("TYPOGRAPH PRO", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_input.ForeColor = System.Drawing.Color.DodgerBlue;
            this.n_input.Location = new System.Drawing.Point(60, 112);
            this.n_input.Name = "n_input";
            this.n_input.Size = new System.Drawing.Size(227, 47);
            this.n_input.TabIndex = 38;
            this.n_input.Text = "...";
            this.n_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.n_input.Enter += new System.EventHandler(this.n_input_Enter);
            this.n_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_input_KeyPress);
            this.n_input.Leave += new System.EventHandler(this.n_input_Leave);
            // 
            // SUM_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.nLine);
            this.Controls.Add(this.n_input);
            this.Controls.Add(this.BlueSigma);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.Back_arrow_Button);
            this.Name = "SUM_frame";
            this.Size = new System.Drawing.Size(712, 671);
            this.Load += new System.EventHandler(this.SUM_frame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SUM_frame_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.BlueSigma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_arrow_Button;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.PictureBox BlueSigma;
        private System.Windows.Forms.Label nLine;
        private System.Windows.Forms.TextBox n_input;
    }
}
