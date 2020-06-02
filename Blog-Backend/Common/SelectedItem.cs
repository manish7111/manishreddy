using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common
{
    public class SelectedItem
    {
        private int itemId;
        private string itemName;
        private double price;
        private string itemImage;
        private bool status;
        private string color;
        private string size;
        private int numberOfItems;
        private string email;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id
        {
            get; set;
        }
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
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;
            }
        }
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
            }
        }
        public int NumberOfItems
        {
            get
            {
                return numberOfItems;
            }
            set
            {
                this.numberOfItems = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                this.email = value;
            }
        }
    }
}
