using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common
{
    public class Items
    {
        private int itemId;
        private string itemName;
        private string itemBrandName;
        private double price;
        private string itemImage;
        private bool status;
        private string descriptions;
        private int quantity;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                this.itemId = value;
            }
        }
        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                this.itemName = value;
            }
        }
        public string ItemBrandName
        {
            get
            {
                return itemBrandName;
            }
            set
            {
                this.itemBrandName = value;
            }
        }
        public string ItemImage
        {
            get
            {
                return itemImage;
            }
            set
            {
                this.itemImage = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                this.status = value;
            }
        }
        public string Descriptions
        {
            get
            {
                return descriptions;
            }
            set
            {
                this.descriptions = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                this.quantity = value;
            }
        }
    }
}
