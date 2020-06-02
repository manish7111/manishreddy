using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common
{
    public class AuthUser
    {
        private string email;
        private string otp;
        [Key]
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
        [DataType(DataType.Password)]
        public string OTP
        {
            get
            {
                return otp;
            }
            set
            {
                this.otp = value;
            }
        }
    }
}
