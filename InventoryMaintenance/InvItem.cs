using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;
        public InvItem()
        {
        }
        // Constructor that initializes the object

        public InvItem(int itemNo, string description, decimal price)
        {
            this.itemNo = itemNo;
            this.description = description;
            this.price = price;
        }
        // properties
        public int ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public decimal Price  // property
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
            public string GetDisplayText() => itemNo + "    " + description + " (" + price.ToString("c") + ")";
        }

    }          

