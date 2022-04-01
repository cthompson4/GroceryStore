using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GroceryStore {
    public class Item
    {
        private string name;
        private double price;
        private int qty;
        private int luxury;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public int Luxury
        {
            get { return luxury; }
            set
            {
                if (value < 0 || value > 1)
                {
                    luxury = 0;
                }
                else
                {
                    luxury = value;
                }
            }
        }
        public Item()
        {
            Name = "";
            Price = 0.0;
            Qty = 0;
            Luxury = 0;
        }
        public Item(string name, double price, int qty, int luxury)
        {
            Name = name;
            Price = price;
            Qty = qty;
            Luxury = luxury;
        }
        public string luxuryToString()
        {
            if (Luxury == 0)
            {
                return "";
            }
            else
            {
                return "(Luxury)";
            }
        }
        public override string ToString()
        {
            return String.Format("{0}: ${1} | Qty: {2} {3}", Name, Price, Qty, luxuryToString()) ;
        }
    }
    public class ItemController {
        public List<Item> items;
        public ItemController()
        {
            items = null;
        }
        public ItemController(List<Item> items)
        {
            this.items = items;
        }
        public void AddItem(string name, double price, int qty, int luxury)
        {
            Item item = new Item(name, price, qty, luxury);
            items.Add(item);
        }
        public void RemoveItem(int place)
        {
            items.RemoveAt(place);
        }
        public string GetItemsAsString()
        {
            string result = "";
            foreach (Item item in items)
            {
                result = result + item + "\r\n";
            }
            return result;
        }
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                List<Item> items = new List<Item>();
                ItemController itemController = new ItemController(items);
                Application.Run(new Form1(itemController));
            } catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Make sure you have entered a value for everything.");
                MessageBox.Show(Convert.ToString(ex));
            }

        }
    }
}
