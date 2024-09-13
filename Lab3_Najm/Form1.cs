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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Number1, Number2, Number3;
            string Operation1 = txtOperation1.Text;
            string Operation2 = txtOperation2.Text;
            string FirstResult = "";
            string FinalResult = "";

            if (double.TryParse(txtNum1.Text, out Number1) &&
                double.TryParse(txtNum2.Text, out Number2) &&
                double.TryParse(txtNum3.Text, out Number3))
            {
                if (Operation1 == "*" || Operation1 == "/")
                    FirstResult =PerOperation(PerOperation(Number1, Number2, Operation1),Number3,Operation2).ToString();
                else
                    FirstResult = PerOperation(PerOperation(Number2, Number3, Operation2), Number1, Operation1).ToString();
                if (FirstResult == "NaN")
                {
                    MessageBox.Show("العملية الأولى غير صحيحة");
                    txtOperation1.Focus();
                    return;
                }

                if (FinalResult == "NaN")
                {
                    MessageBox.Show("العملية الثانية غير صحيحة");
                    txtOperation2.Focus();
                    return;
                }
                txtResult.Text = FirstResult.ToString();
            }
            else
                MessageBox.Show("ادخل قيم صحيحة");
        }
        private double PerOperation(double Num1, double Num2, string Operation)
        {
            switch(Operation)
            {
                case "+": return Num1 + Num2;
                case "-": return Num1 - Num2;
                case "*": return Num1 * Num2;
                case "/":
                    if (Num2 != 0)
                        return Num1 / Num2;
                    else
                        return double.NaN;
                default:
                    return double.NaN;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
