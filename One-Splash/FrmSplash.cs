using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace One_Splash
{
    public partial class frm_Splash : Form
    {
        public frm_Splash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                timer.Start();
                progressBar.Value += 1;
            }
            else {
                timer.Enabled = false;
                this.Close();
            }
        }
    }
}
