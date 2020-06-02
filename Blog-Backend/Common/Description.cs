using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common
{
    public class Description
    {
        private string description1;
        private string description2;
        private string advantage;
        private int itemId;
        private int id;
        [Key]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }
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
        public string Description1
        {
            get
            {
                return description1;
            }
            set
            {
                this.description1 = value;
            }
        }
        public string Description2
        {
            get
            {
                return description2;
            }
            set
            {
                this.description2 = value;
            }
        }
        public string Advantage
        {
            get
            {
                return advantage;
            }
            set
            {
                this.advantage = value;
            }
        }
    }
}
