using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSystemManagement
{
    public partial class TestAccount : Form
    {
        // ###################################################################################
        // Constructor
        // ###################################################################################
        public TestAccount()
        {
            InitializeComponent();
        }

        // ###################################################################################
        // Close Button Function
        // ###################################################################################
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ###################################################################################
        // Window Closing Function
        // ###################################################################################
        private void TestAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if there are any other open forms left.
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
