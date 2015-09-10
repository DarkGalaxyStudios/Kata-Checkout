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
        List<CartItem> CartItemList { get; set; }
        List<CartItemView> CartItems { get; set; }

        public decimal SubTotal { get; set; }
        public decimal Discounts { get; set; }
        public decimal Total { get; set; }

        public CheckOutScreen()
        {
            InitializeComponent();

            CartItemList = new List<CartItem>();
            CartItems = new List<CartItemView>();

            dgvCart.DataSource = CartItems;
            SubTotal = 0;
            Discounts = 0;
            Total = 0;
        }

        

        private void AddNewCartItem(CartItem ci)
        {
            CartItemView cv = new CartItemView();
            cv.Name = ci.Name;
            cv.Qty = ci.Qty;
            cv.Price = ci.Price;
            CartItemList.Add(ci);
            CartItems.Add(cv);

            UpdateTotals();
        }

        private void UpdateCartItem(string sku)
        {
            CartItem cartItem = GetCartItem(sku);

            if (cartItem != null)
            {
                CartItems.Find(x => x.Name == sku).Qty++;
                if (cartItem.HasSpecialPrice)
                    CartItems.Find(x => x.Name == sku).ApplySpecial(cartItem.MinQtySpecial, cartItem.SpecialPrice);
                dgvCart.DataSource = null;
                dgvCart.DataSource = CartItems;
            }

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            decimal sub = 0;
            decimal total = 0;

            for(int i=0; i < CartItems.Count; i++)
            {
                SubTotal += (CartItems[i].Qty * CartItems[i].Price);
            }

            Total = SubTotal - Discounts;

            lblSubtotal.Text = SubTotal.ToString("C");
            lblTotal.Text = Total.ToString("C");
        }

        private CartItem GetCartItem(string sku)
        {
            return CartItemList.Find(x => x.Name == sku);
        }

        private bool CheckExists(string name)
        {
            return CartItems.Exists(x => x.Name == name);
        }

        private void btnItemA_Click(object sender, EventArgs e)
        {
            if (CheckExists("A"))
            {
                UpdateCartItem("A");

            }
            else
            {
                CartItem ci = new CartItem("A", 50, 1, true, 3, 150);
                AddNewCartItem(ci);

                dgvCart.DataSource = null;
                dgvCart.DataSource = CartItems;
            }
        }

        private void btnItemB_Click(object sender, EventArgs e)
        {
            if (CheckExists("B"))
            {
                UpdateCartItem("B");

            }
            else
            {
                CartItem ci = new CartItem("B", 30, 1, true, 2, 45);
                AddNewCartItem(ci);

                dgvCart.DataSource = null;
                dgvCart.DataSource = CartItems;
            }
        }

        private void btnItemC_Click(object sender, EventArgs e)
        {
            if (CheckExists("C"))
            {
                UpdateCartItem("C");

            }
            else
            {
                CartItem ci = new CartItem("C", 20, 1, false, 0, 0);
                AddNewCartItem(ci);

                dgvCart.DataSource = null;
                dgvCart.DataSource = CartItems;
            }
        }

        private void btnItemD_Click(object sender, EventArgs e)
        {
            if (CheckExists("D"))
            {
                UpdateCartItem("D");

            }
            else
            {
                CartItem ci = new CartItem("D", 15, 1, false, 0, 0);
                AddNewCartItem(ci);

                dgvCart.DataSource = null;
                dgvCart.DataSource = CartItems;
            }
        }

        private void ClearShoppingCart()
        {
            dgvCart.DataSource = null;

            dgvCart.Rows.Clear();

            dgvCart.DataSource = CartItems;
        }
    }
}
