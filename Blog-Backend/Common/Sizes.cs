using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common
{
    public class Sizes
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        private int itemId;
        private string size;
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
    }
}
