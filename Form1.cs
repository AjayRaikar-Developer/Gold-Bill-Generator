using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Changes the window state to Maximized.
            WindowState = FormWindowState.Maximized;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            salesMenu.Show(SALES, SALES.Width, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            purchaseMenu.Show(PURCHASE, PURCHASE.Width,0);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void GoldPurchaseItemClick(object sender, EventArgs e)
        {
            this.Hide(); 
            GoldPurchase goldPurchase = new GoldPurchase();
            goldPurchase.Show();
        }

        private void SilverPurchaseItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }
        private void GoldSaleItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }

        private void SilverSaleItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }
    }
}
