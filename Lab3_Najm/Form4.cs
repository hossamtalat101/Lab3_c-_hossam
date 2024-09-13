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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int Number;

        private void button1_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            Number = Convert.ToInt32(txtNumber.Text);
            for (int i = 1; i <= Number; i++)
                Sum += i;
            labResultOfSum.Text = Sum.ToString();
        }

        private void btnFacorial_Click(object sender, EventArgs e)
        {
            long Fact = 1;
            Number = Convert.ToInt32(txtNumber.Text);
            if (Number == 0)
                Fact = 1;
            else
            {
                for (int i = 1; i <= Number; i++)
                    Fact *= i;
            }
            labResultOfFact.Text = Fact.ToString();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            Number = Convert.ToInt32(txtNumber.Text);
            if (Number < 0)
            {
                MessageBox.Show("لا يوجد جذور للأعداد السالبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtNumber.Clear();
                txtNumber.Focus();
            }
            else
                labResultOfRoot.Text = Math.Sqrt(Number).ToString();

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')
                && ((e.KeyChar != '-') || ((TextBox)sender).Text.Length != 0))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
