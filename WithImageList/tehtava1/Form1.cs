using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtava1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = -1;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count < 19)
            {
                count++;
            }
            lblCount.Text = (count + 1).ToString();
            pb1.Image = imageList1.Images[count];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            lblCount.Text = (count + 1).ToString();
            pb1.Image = imageList1.Images[count];
        }
    }
}
