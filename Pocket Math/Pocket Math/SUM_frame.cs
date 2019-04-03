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
                this.Hide();
                this.ParentForm.ActiveControl = null;
            }
        }
    }
}
