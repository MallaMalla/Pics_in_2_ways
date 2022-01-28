using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tehtava2
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count < 23)
            {
                count++;
            }
            pbxPic.Image = Image.FromFile(@"d:\img\" + count + ".jpg");

            Haku haku = new Haku();
            haku.haeNimi(count);

            DataRow row = haku.Dt.Rows[0];
            lblName.Text = row["nimi"].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count--;
            }
            pbxPic.Image = Image.FromFile(@"d:\img\" + count + ".jpg");

            Haku haku = new Haku();
            haku.haeNimi(count);

            DataRow row = haku.Dt.Rows[0];
            lblName.Text = row["nimi"].ToString();
        }
    }
}
