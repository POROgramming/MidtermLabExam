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
    public partial class MainForm : Form
    {
        MaintenanceForm mainteForm = new MaintenanceForm();
        public MainForm()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            mainteForm.Show();
            this.Hide();
        }

        private void btnPOF_Click(object sender, EventArgs e)
        {
            PointOfSalesForm salesForm = new PointOfSalesForm();
            salesForm.Show();
            this.Hide();
        }
    }
}
