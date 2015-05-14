using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchBillApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int riceUnit;
        int fishUnit;
        int meatUnit;
        int totalGross;
        double discount;

        private void showButton_Click(object sender, EventArgs e)
        {
            if (riceTextBox.Text == "" || fishTextBox.Text == "" || meatTextBox.Text == "")
            {
                MessageBox.Show("pls enter the amount");
            }
            else
            {
                riceUnit = Convert.ToInt32(riceTextBox.Text);
                fishUnit = Convert.ToInt32(fishTextBox.Text);
                meatUnit = Convert.ToInt32(meatTextBox.Text);
                totalGross = riceUnit * 20 + fishUnit * 80 + meatUnit * 100;
                grossTextBox.Text = Convert.ToString(totalGross);


                riceTextBox.Text = null;
                fishTextBox.Text = null;
                meatTextBox.Text = null;
            }

        }

        private void netBillButton_Click(object sender, EventArgs e)
        {
            double vatAmount;
            double netBill;

            totalGross=Convert.ToInt32(grossTextBox.Text);
            discount = Convert.ToDouble(discountTextBox.Text);
            vatAmount = (totalGross*5)/100;

            netBill = (totalGross - discount) + vatAmount;
            MessageBox.Show("your net bill is :" + netBill);

            grossTextBox.Clear();
            discountTextBox.Clear();

        }
    }
}
