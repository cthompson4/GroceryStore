using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
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
            updateTextList();
        }
        private void btnRemove(object sender, EventArgs e)
        {
            int place = 0;
            itemController.RemoveItem(place);
            updateTextList();
        }
        private void updateTextList()
        {
            txtDisplay1.Text = (itemController.GetItemsAsString());
        }

        private void btnSaved(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            string filePath = txtPath.Text;
            string path = filePath + "\\" + fileName + ".txt";
            MessageBox.Show("Saved to: " + path);
            File.WriteAllText(path, itemController.GetItemsAsString());
        }
        private void btnLoaded(object sender, EventArgs e)
        {
            string name = "";
            double price = 0;
            int qty = 0;
            int luxury = 0;
            string fileName = txtFileName.Text;
            string filePath = txtPath.Text;
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                int counter = 0;
                string[] words = line.Split(' ');
                foreach (string word in words)
                {
                    if (counter == 0)
                    {
                        string tempword = word;
                        tempword = tempword.Replace(":", "");
                        name = tempword;
                    }
                    else if (counter == 1)
                    {
                        string tempword = word;
                        tempword = tempword.Replace("$", "");
                        price = Convert.ToDouble(tempword);
                    } 
                    else if (counter == 2)
                    {

                    }
                    else if (counter == 3)
                    {

                    }
                    else if (counter == 4)
                    {
                        qty = Convert.ToInt32(word);
                    }
                    else if (counter == 5)
                    {
                        if (word.Equals("(Luxury)"))
                        {
                            luxury = 1;
                        }
                    }
                    else
                    {
                        luxury = 0;
                    }
                    counter++;
                }
                itemController.AddItem(name, price, qty, luxury);
            }
            updateTextList();
        }
    }
}
