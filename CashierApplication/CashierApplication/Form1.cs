using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Cashier cashier;
        private void button1_Click(object sender, EventArgs e)
        {
            cashier = new Cashier(" Lee Plata " , "Finance" ,  textBox2.Text, textBox1.Text);
            if(cashier.validateLogin(textBox2.Text, textBox1.Text))
            {
                frmPurchaseDiscountedItem form = new frmPurchaseDiscountedItem();
                MessageBox.Show("Welcome" + cashier.getFullName() + " of "  + cashier.getDepartment(), "success",  MessageBoxButtons.OK);
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("LOGIN FAILED.", "FAILED", MessageBoxButtons.OK);
            }
        }
    }   
}
