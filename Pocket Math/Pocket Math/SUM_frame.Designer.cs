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
            this.iLine = new System.Windows.Forms.Label();
            this.i_input = new System.Windows.Forms.TextBox();
            this.inputLine = new System.Windows.Forms.Label();
            this.inputSum = new System.Windows.Forms.TextBox();
            this.SumResult = new System.Windows.Forms.Label();
            this.SumButton = new System.Windows.Forms.Button();
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
            this.Back_arrow_Button.Location = new System.Drawing.Point(847, 692);
            this.Back_arrow_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Back_arrow_Button.Name = "Back_arrow_Button";
            this.Back_arrow_Button.Size = new System.Drawing.Size(81, 113);
            this.Back_arrow_Button.TabIndex = 6;
            this.Back_arrow_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Back_arrow_Button.UseVisualStyleBackColor = false;
            this.Back_arrow_Button.Click += new System.EventHandler(this.Back_arrow_Button_Click);
            // 
            // SumLabel
            // 
            this.SumLabel.Font = new System.Drawing.Font("Gravity Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumLabel.ForeColor = System.Drawing.Color.Blue;
            this.SumLabel.Location = new System.Drawing.Point(231, 4);
            this.SumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(488, 58);
            this.SumLabel.TabIndex = 36;
            this.SumLabel.Text = "(Summation Notation Calculator)";
            this.SumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlueSigma
            // 
            this.BlueSigma.Image = ((System.Drawing.Image)(resources.GetObject("BlueSigma.Image")));
            this.BlueSigma.Location = new System.Drawing.Point(67, 210);
            this.BlueSigma.Margin = new System.Windows.Forms.Padding(4);
            this.BlueSigma.Name = "BlueSigma";
            this.BlueSigma.Size = new System.Drawing.Size(327, 363);
            this.BlueSigma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlueSigma.TabIndex = 37;
            this.BlueSigma.TabStop = false;
            // 
            // nLine
            // 
            this.nLine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nLine.ForeColor = System.Drawing.Color.White;
            this.nLine.Location = new System.Drawing.Point(77, 199);
            this.nLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nLine.Name = "nLine";
            this.nLine.Size = new System.Drawing.Size(304, 2);
            this.nLine.TabIndex = 39;
            // 
            // n_input
            // 
            this.n_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.n_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.n_input.Font = new System.Drawing.Font("TYPOGRAPH PRO", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_input.ForeColor = System.Drawing.Color.DodgerBlue;
            this.n_input.Location = new System.Drawing.Point(80, 138);
            this.n_input.Margin = new System.Windows.Forms.Padding(4);
            this.n_input.Name = "n_input";
            this.n_input.Size = new System.Drawing.Size(303, 58);
            this.n_input.TabIndex = 38;
            this.n_input.Text = "...";
            this.n_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.n_input.Enter += new System.EventHandler(this.n_input_Enter);
            this.n_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_input_KeyPress);
            this.n_input.Leave += new System.EventHandler(this.n_input_Leave);
            // 
            // iLine
            // 
            this.iLine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iLine.ForeColor = System.Drawing.Color.White;
            this.iLine.Location = new System.Drawing.Point(80, 636);
            this.iLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iLine.Name = "iLine";
            this.iLine.Size = new System.Drawing.Size(304, 2);
            this.iLine.TabIndex = 41;
            // 
            // i_input
            // 
            this.i_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.i_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.i_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.i_input.Font = new System.Drawing.Font("TYPOGRAPH PRO", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_input.ForeColor = System.Drawing.Color.DodgerBlue;
            this.i_input.Location = new System.Drawing.Point(83, 575);
            this.i_input.Margin = new System.Windows.Forms.Padding(4);
            this.i_input.Name = "i_input";
            this.i_input.Size = new System.Drawing.Size(303, 58);
            this.i_input.TabIndex = 40;
            this.i_input.Text = "...";
            this.i_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.i_input.Enter += new System.EventHandler(this.i_input_Enter);
            this.i_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.i_input_KeyPress);
            this.i_input.Leave += new System.EventHandler(this.i_input_Leave);
            // 
            // inputLine
            // 
            this.inputLine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.inputLine.ForeColor = System.Drawing.Color.White;
            this.inputLine.Location = new System.Drawing.Point(413, 433);
            this.inputLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLine.Name = "inputLine";
            this.inputLine.Size = new System.Drawing.Size(452, 2);
            this.inputLine.TabIndex = 43;
            // 
            // inputSum
            // 
            this.inputSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSum.Font = new System.Drawing.Font("TYPOGRAPH PRO", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.inputSum.Location = new System.Drawing.Point(416, 372);
            this.inputSum.Margin = new System.Windows.Forms.Padding(4);
            this.inputSum.Name = "inputSum";
            this.inputSum.Size = new System.Drawing.Size(451, 58);
            this.inputSum.TabIndex = 42;
            this.inputSum.Text = "...";
            this.inputSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSum.Enter += new System.EventHandler(this.InputSum_Enter);
            this.inputSum.Leave += new System.EventHandler(this.InputSum_Leave);
            // 
            // SumResult
            // 
            this.SumResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SumResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SumResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumResult.Font = new System.Drawing.Font("TYPOGRAPH PRO", 27.75F);
            this.SumResult.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SumResult.Location = new System.Drawing.Point(490, 492);
            this.SumResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumResult.Name = "SumResult";
            this.SumResult.Size = new System.Drawing.Size(313, 81);
            this.SumResult.TabIndex = 44;
            this.SumResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SumResult.Paint += new System.Windows.Forms.PaintEventHandler(this.SumResult_Paint);
            // 
            // SumButton
            // 
            this.SumButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SumButton.FlatAppearance.BorderSize = 3;
            this.SumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumButton.Font = new System.Drawing.Font("TYPOGRAPH PRO", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumButton.ForeColor = System.Drawing.Color.White;
            this.SumButton.Location = new System.Drawing.Point(115, 692);
            this.SumButton.Margin = new System.Windows.Forms.Padding(4);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(239, 70);
            this.SumButton.TabIndex = 45;
            this.SumButton.Text = "SUM";
            this.SumButton.UseVisualStyleBackColor = false;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // SUM_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.SumResult);
            this.Controls.Add(this.inputLine);
            this.Controls.Add(this.inputSum);
            this.Controls.Add(this.nLine);
            this.Controls.Add(this.n_input);
            this.Controls.Add(this.BlueSigma);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.Back_arrow_Button);
            this.Controls.Add(this.iLine);
            this.Controls.Add(this.i_input);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SUM_frame";
            this.Size = new System.Drawing.Size(949, 826);
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
        private System.Windows.Forms.Label iLine;
        private System.Windows.Forms.TextBox i_input;
        private System.Windows.Forms.Label inputLine;
        private System.Windows.Forms.TextBox inputSum;
        private System.Windows.Forms.Label SumResult;
        private System.Windows.Forms.Button SumButton;
    }
}
