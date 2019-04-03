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
            this.SigmaLabel = new System.Windows.Forms.Label();
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
            // SigmaLabel
            // 
            this.SigmaLabel.Font = new System.Drawing.Font("Times New Roman", 249.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigmaLabel.ForeColor = System.Drawing.Color.Blue;
            this.SigmaLabel.Location = new System.Drawing.Point(63, 139);
            this.SigmaLabel.Name = "SigmaLabel";
            this.SigmaLabel.Size = new System.Drawing.Size(227, 359);
            this.SigmaLabel.TabIndex = 37;
            this.SigmaLabel.Text = "Σ";
            this.SigmaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SUM_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.SigmaLabel);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.Back_arrow_Button);
            this.Name = "SUM_frame";
            this.Size = new System.Drawing.Size(712, 671);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_arrow_Button;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label SigmaLabel;
    }
}
