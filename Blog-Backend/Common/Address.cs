using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common
{
    public class Address
    {
        private string firstName;
        private string lastName;
        private string email;
        private string flatOrHouseNo;
        private string streetOrLocality;
        private string city;
        private string state;
        private string zipCode;
        private string district;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id
        {
            get;
            set;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string FlatOrHouseNo
        {
            get
            {
                return this.flatOrHouseNo;
            }
            set
            {
                this.flatOrHouseNo = value;
            }
        }
        public string StreetOrLocality
        {
            get
            {
                return this.streetOrLocality;
            }
            set
            {
                this.streetOrLocality = value;
            }
        }
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }
        public string ZipCode
        {
            get
            {
                return this.zipCode;
            }
            set
            {
                this.zipCode = value;
            }
        }
        public string District
        {
            get
            {
                return this.district;
            }
            set
            {
                this.district = value;
            }
        }
    }
}
