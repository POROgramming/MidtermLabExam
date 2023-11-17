using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class PointOfSalesForm : Form
    {
        MainForm openMainForm = new MainForm();
        public PointOfSalesForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.openMainForm.Show();
            this.Hide();
        }
    }
}
