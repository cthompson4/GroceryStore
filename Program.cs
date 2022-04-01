using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GroceryStore {
    internal class Item {
        private string name;
        private double price;
        private int qty;
        private int luxury;

    }
    public class ItemController {
        private List<Item> items;
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
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
