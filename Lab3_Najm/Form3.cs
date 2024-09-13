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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            listBox1.Items.Add("+");
            listBox1.Items.Add("-");
            listBox1.Items.Add("*");
            listBox1.Items.Add("/");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text = txtResult.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Number1 = 0;
            Number1 = Convert.ToDouble(txtNum1.Text);
            double Number2 = 0;
            Number2 = Convert.ToDouble(txtNum2.Text);
            double Result = 0;
            switch (listBox1.SelectedItem.ToString())
            {
                case "+":
                    //txtResult.Text = (Number1 + Number2).ToString();
                    Result = Number1 + Number2;
                    break;
                case "-":
                    //txtResult.Text = (Number1 - Number2).ToString();
                    Result = Number1 - Number2;
                    break;
                case "*":
                    //txtResult.Text = (Number1 * Number2).ToString();
                    Result = Number1 * Number2;
                    break;
                case "/":
                    if (Number2 != 0)
                        //txtResult.Text = (Number1 / Number2).ToString();
                        Result = Number1 / Number2;
                    else
                        MessageBox.Show("خطأ", "قسمة على صفر", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    break;
                default:
                    MessageBox.Show("تحذير", "خطأ في العملية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    break;
            }
            txtResult.Text = Result.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Enabled = (txtNum1.Text != "" && txtNum2.Text != "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
