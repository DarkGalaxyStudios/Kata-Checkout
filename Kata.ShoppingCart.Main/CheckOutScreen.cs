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
        List<CartItem> CartItems { get; set; }

        public CheckOutScreen()
        {
            InitializeComponent();

            CartItems = new List<CartItem>();
            dgvCart.DataSource = CartItems;
        }

        private void btnItemA_Click(object sender, EventArgs e)
        {
            

            if(CheckExists("A"))
            {
                UpdateCartItem("A");
                
            }
            else
            {
                CartItem ci = new CartItem("A", 50, 1, true, 3, 150);
                CartItems.Add(ci);
            }
        }

        private void UpdateCartItem(string sku)
        {
            CartItems.Find(x => x.Name == sku).Qty++;
            CartItems.Find(x => x.Name == sku).ApplySpecial();
        }

        private bool CheckExists(string name)
        {
            return CartItems.Exists(x => x.Name == name);
        }

        private void btnItemB_Click(object sender, EventArgs e)
        {

        }

        private void btnItemC_Click(object sender, EventArgs e)
        {

        }

        private void btnItemD_Click(object sender, EventArgs e)
        {

        }

        private void ClearShoppingCart()
        {
            dgvCart.DataSource = null;

            dgvCart.Rows.Clear();

            dgvCart.DataSource = CartItems;
        }
    }
}
