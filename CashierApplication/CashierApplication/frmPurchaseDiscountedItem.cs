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
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem discountedItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = itembox.Text;
            double price = Convert.ToDouble(pricebox.Text);
            int quantity = Convert.ToInt32(quantitybox.Text);
            double discount = Convert.ToDouble(discountbox.Text);
            
            discountedItem = new DiscountedItem(name, price, quantity, discount);
            double totalPrice = discountedItem.getTotalPrice();
            label9.Text = totalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double paymentAmount = Convert.ToDouble(paymentreceivedbox.Text);
            discountedItem.setPayment(paymentAmount);
            double change = discountedItem.getChange();
            changebox.Text = change.ToString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
