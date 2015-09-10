using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Kata.ShoppingCart;

namespace Kata.ShoppingCart.Main
{
    public partial class CheckOutScreen : Form
    {
        List<CartItemViewModel> CartItems { get; set; }

        public int? SubTotal { get; set; }
        public int? Discounts { get; set; }
        public int? Total { get; set; }

        public PriceRules PriceRules { get; set; }

        public CheckOutScreen()
        {
            InitializeComponent();

            CartItems = new List<CartItemViewModel>();

            ClearShoppingCart();

            SubTotal = 0;
            Discounts = 0;
            Total = 0;

            Dictionary<string, int> saleRules = new Dictionary<string, int>();
            saleRules.Add("A:3", 130);
            saleRules.Add("B:2", 45);
            PriceRules = new PriceRules(saleRules);
        }

        private void UpdateCartItem(string sku)
        {
           
        }

        private void UpdateTotals()
        {
            ClearShoppingCart();

            foreach(CartItemViewModel item in CartItems)
            {
                int? specialPrice = PriceRules.PriceCheck(item.SKU, item.Qty);

                if(specialPrice != null)
                {
                    Discounts += (int)(item.Qty * item.Price) - specialPrice;
                }

                SubTotal += item.Price;
            }

            lblSubtotal.Text = SubTotal.ToString();
            lblDiscounts.Text = Discounts.ToString();
            lblTotal.Text = (SubTotal - Discounts).ToString();
        }

        private void Scan(CartItemViewModel item)
        {
            if (!CheckExists(item))
            {
                item.Qty = 1;
                CartItems.Add(item);
            }
            else
            {
                CartItems.Find(x => x.SKU == item.SKU).Qty++;
            }

            ClearShoppingCart();

            UpdateTotals();
        }

        private bool CheckExists(CartItemViewModel item)
        {
            CartItemViewModel i = CartItems.Find(x => x.SKU == item.SKU);
            if (i != null)
                return true;
            else
                return false;
        }

        private void btnItemA_Click(object sender, EventArgs e)
        {
            CartItemViewModel item = new CartItemViewModel { SKU = "A", Price = 50 };
            Scan(item);
        }

        private void btnItemB_Click(object sender, EventArgs e)
        {
            CartItemViewModel item = new CartItemViewModel { SKU = "B", Price = 30 };
            Scan(item);
        }

        private void btnItemC_Click(object sender, EventArgs e)
        {
            CartItemViewModel item = new CartItemViewModel { SKU = "C", Price = 20 };
            Scan(item);
        }

        private void btnItemD_Click(object sender, EventArgs e)
        {
            CartItemViewModel item = new CartItemViewModel { SKU = "D", Price = 15 };
            Scan(item);
        }

        private void ClearShoppingCart()
        {
            dgvCart.DataSource = null;

            dgvCart.Rows.Clear();

            dgvCart.DataSource = CartItems;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CartItems.Clear();
            SubTotal = 0;
            Discounts = 0;
            Total = 0;
            lblDiscounts.Text = Discounts.ToString();
            lblSubtotal.Text = SubTotal.ToString();
            lblTotal.Text = Total.ToString();
            ClearShoppingCart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
