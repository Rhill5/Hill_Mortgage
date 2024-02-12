using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hill_Mortgage
{
    public partial class MainFrm : Form
    {
        double principal = 0D;
        int years = 0;
        double interest = 0D;
        const int months = 12;
        double total = 0D;
        double r = 0D;
        double n = 0D;
        double P = 0D;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            txtOtherYear.Visible = false;
            lblOutput.Visible = false;
            rad30year.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherYear.Visible = true;
        }

        private void rad15year_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherYear.Visible = false;
            years = 15;
        }

        private void rad30year_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherYear.Visible = false;
            years = 30;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            principal = 0D;
            years = 30;
            interest = 0D;
            total = 0D;
            r = 0D;
            n = 0D;
            P = 0D;
            txtPrincipal.Clear();
            cboInterest.SelectedItem = null;
            rad30year.Checked = true;
            lblOutput.Text = string.Empty;
            lblOutput.Visible = false;
        }

        private void cboInterest_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboInterest.SelectedIndex)
            {
                case 0:
                    interest = 0.03; 
                    break;
                case 1:
                    interest = 0.031;
                    break;
                case 2:
                    interest = 0.032;
                    break;
                case 3:
                    interest = 0.033;
                    break;
                case 4:
                    interest = 0.034;
                    break;
                case 5:
                    interest = 0.035;
                    break;
                case 6:
                    interest = 0.036;
                    break;
                case 7:
                    interest = 0.037;
                    break;
                case 8:
                    interest = 0.038;
                    break;
                case 9:
                    interest = 0.039;
                    break;
                case 10:
                    interest = 0.04;
                    break;
                case 11:
                    interest = 0.041;
                    break;
                case 12:
                    interest = 0.042;
                    break;
                case 13:
                    interest = 0.043;
                    break;
                case 14:
                    interest = 0.044;
                    break;
                case 15:
                    interest = 0.045;
                    break;
                default:
                    break;
            }
        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrincipal.Text))
            {
                principal = double.Parse(txtPrincipal.Text);
            };
        }

        private void txtOtherYear_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOtherYear.Text))
            {
                years = int.Parse(txtOtherYear.Text);
            };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            r = interest / months;
            n = years * months;
            P = principal;
            total = P * (r * Math.Pow((1 + r), n) / (Math.Pow((1 + r), n) - 1));
            lblOutput.Visible = true;
            lblOutput.Text = "Monthly payment is: " + total.ToString("C", CultureInfo.CurrentCulture);
        }

        private void txtPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOtherYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
