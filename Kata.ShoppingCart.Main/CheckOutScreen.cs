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

        Dictionary<CartItem, int> itemDictionary { get; set; }

        public decimal SubTotal { get; set; }
        public decimal Discounts { get; set; }
        public decimal Total { get; set; }

        public CheckOutScreen()
        {
            InitializeComponent();

            CartItemList = new List<CartItem>();
            CartItems = new List<CartItemView>();
            itemDictionary = new Dictionary<CartItem, int>();
            dgvCart.DataSource = CartItems;
            SubTotal = 0;
            Discounts = 0;
            Total = 0;
        }

        private void UpdateCartItem(string sku)
        {
           
        }

        private void UpdateTotals()
        {
            ClearShoppingCart();

            decimal totalPrice = 0;
            decimal discountPrice = 0;
            foreach (CartItemView item in CartItems)
            {
                totalPrice += item.Qty * item.Price;

                if(CartItemList.Find(x => x.Name == item.Name).SpecialValue > 0 && 
                    (CartItems.Find(x => x.Name == item.Name).Qty % CartItemList.Find(x => x.Name == item.Name).SpecialQty == 0))
                        discountPrice -= (item.Qty / CartItemList.Find(x => x.Name == item.Name).SpecialQty) * CartItemList.Find(x => x.Name == item.Name).SpecialValue;
            }

            decimal differece = totalPrice + discountPrice;
            lblDiscounts.Text = differece.ToString("C");
            lblSubtotal.Text = totalPrice.ToString("C");

            lblTotal.Text = (totalPrice - differece).ToString("C");
        }

        private CartItem GetCartItem(string sku)
        {
            return CartItemList.Find(x => x.Name == sku);
        }

        private bool CheckExists(CartItem item)
        {
            return CartItems.Exists(x => x.Name == item.Name);
        }

        private void btnItemA_Click(object sender, EventArgs e)
        {
            CartItem item = new CartItem();
            item.SpecialQty = 3;
            item.SpecialValue = 130;
            item.Name = "A";
            item.Price = 50;

            //Check if the item already exists in the list
            if(!CheckExists(item))
            {
                //Add to the Item List
                CartItemList.Add(item);

                //Create the view for the data grid
                CartItemView civ = new CartItemView();
                civ.Name = item.Name;
                civ.Price = item.Price;
                civ.Qty = 1;
                
                CartItems.Add(civ);
            }
            else
            {
                //Update the item in the view
                CartItems.Find(x => x.Name == item.Name).Qty++;
            }

            //Check if item has a special rule and update if applicable
            CheckSpecial();

            UpdateTotals();
            
        }

        private void btnItemB_Click(object sender, EventArgs e)
        {
            CartItem item = new CartItem();
            item.SpecialQty = 2;
            item.SpecialValue = 45;
            item.Name = "B";
            item.Price = 30;

            //Check if the item already exists in the list
            if (!CheckExists(item))
            {
                //Add to the Item List
                CartItemList.Add(item);

                //Create the view for the data grid
                CartItemView civ = new CartItemView();
                civ.Name = item.Name;
                civ.Price = item.Price;
                civ.Qty = 1;

                CartItems.Add(civ);
            }
            else
            {
                //Update the item in the view
                CartItems.Find(x => x.Name == item.Name).Qty++;
            }

            //Check if item has a special rule and update if applicable
            CheckSpecial();

            UpdateTotals();
        }

        private void btnItemC_Click(object sender, EventArgs e)
        {
            CartItem item = new CartItem();
            item.SpecialQty = 0;
            item.SpecialValue = 0;
            item.Name = "C";
            item.Price = 20;

            //Check if the item already exists in the list
            if (!CheckExists(item))
            {
                //Add to the Item List
                CartItemList.Add(item);

                //Create the view for the data grid
                CartItemView civ = new CartItemView();
                civ.Name = item.Name;
                civ.Price = item.Price;
                civ.Qty = 1;

                CartItems.Add(civ);
            }
            else
            {
                //Update the item in the view
                CartItems.Find(x => x.Name == item.Name).Qty++;
            }

            //Check if item has a special rule and update if applicable
            CheckSpecial();

            UpdateTotals();
        }

        private void btnItemD_Click(object sender, EventArgs e)
        {
            CartItem item = new CartItem();
            item.SpecialQty = 0;
            item.SpecialValue = 0;
            item.Name = "D";
            item.Price = 15;

            //Check if the item already exists in the list
            if (!CheckExists(item))
            {
                //Add to the Item List
                CartItemList.Add(item);

                //Create the view for the data grid
                CartItemView civ = new CartItemView();
                civ.Name = item.Name;
                civ.Price = item.Price;
                civ.Qty = 1;

                CartItems.Add(civ);
            }
            else
            {
                //Update the item in the view
                CartItems.Find(x => x.Name == item.Name).Qty++;
            }

            //Check if item has a special rule and update if applicable
            CheckSpecial();

            UpdateTotals();
        }

        private void CheckSpecial()
        {
            foreach(CartItemView item in CartItems)
            {

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
