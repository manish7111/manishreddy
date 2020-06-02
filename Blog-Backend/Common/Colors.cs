using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common
{
    public class Colors
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        private int itemId;
        private string color;
        [ForeignKey("Items")]
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
    }
}
