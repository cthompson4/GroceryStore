using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class Form1 : Form
    {
        private ItemController itemController;
        public Form1(ItemController itemController)
        {
            InitializeComponent();
            this.itemController = itemController;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int qty = Convert.ToInt32(txtQty.Text);
            int luxury;
            if (!chkLuxury.Checked)
            {
                luxury = 0;
            }
            else
            {
                luxury = 1;
            }
            itemController.AddItem(name, price, qty, luxury);
            MessageBox.Show(itemController.GetItemsAsString());
        }
        private void btnRemove(object sender, EventArgs e)
        {
            int place = 0;
            itemController.RemoveItem(place);
        }
        private void updateTextList()
        {

        }
    }
}
