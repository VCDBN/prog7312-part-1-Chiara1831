using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10083452_PROG7312_POE
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Show Form1 
            form1.Show();
            this.Hide();
        }

       
    }
}
