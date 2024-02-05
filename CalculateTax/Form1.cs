using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Tax, salary, psalary;
            salary=Convert.ToDouble(txtSalary.Text);
            if (salary < 500000)
                Tax = 0;
            else if (salary < 1000000)
                Tax = 0.05 * salary;
            else if (salary < 2000000)
                Tax = 0.1 * salary;
            else if (salary < 3000000)
                Tax = 0.15 * salary;
            else 
                Tax = 0.2 * salary;

            psalary = salary - Tax;
            lblResult.Text = txtName.Text + " مالیات شما هست: " + Tax.ToString() + 
                "تومان" + "\nحقوق خالص شما برابر است با: : " + psalary.ToString() + "تومان";
            //string s;
            //s = txtName.Text + " مالیات شما هست: " + Tax.ToString() + "تومان" + "\nحقوق خالص شما برابر است با: : " + psalary.ToString() + "تومان";
            //MessageBox.Show(s);
            //txtName.Focus();
            //txtName.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x=MessageBox.Show("آیا می خواهید از برنامه خارج شوید؟?","خروچ.....",MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
                Application.Exit();
        }

        private void lblEnterYourName_Click(object sender, EventArgs e)
        {

        }

        private void lblEnterYourSalary_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtSalary.Text = string.Empty;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = Convert.ToBoolean(txtSalary.Text.Length);
            btnCalculate.Enabled=Convert.ToBoolean(txtSalary.Text.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSalary_TextChanged(null,null);
        }
    }
}
