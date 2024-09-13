using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Najm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TraingForSender(object sender, EventArgs e)
        {
            if (sender == btnBlack)
                label1.ForeColor = Color.Black;
            else if (sender == btnBlue)
                label1.ForeColor = Color.Blue;
            else if (sender == btnGreen)
                label1.ForeColor = Color.Green;
            else if (sender == btnOrange)
                label1.ForeColor = Color.Orange;
            else if (sender == btnRed)
                label1.ForeColor = Color.Red;
            else if (sender == btnYellow)
                label1.ForeColor = Color.Yellow;
            else if (((Button)sender).Text == btnGreen.Text)
                button1.BackColor = Color.Green;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
