using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruisingFlightStand
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string error)
        {
            InitializeComponent();

            errorTxt.Text = error;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
