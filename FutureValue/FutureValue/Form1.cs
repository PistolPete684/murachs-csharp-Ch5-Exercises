using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            decimal futureValue = 0;

            decimal monthlyInterestRate = yearlyInterestRate / 12;
            int numberOfMonths = numberOfYears / 12;

            for (int i = 0; i < numberOfMonths; i++)
            { 
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);

            }

            txtFutureValue.Text = futureValue.ToString();
        }
    }
}
