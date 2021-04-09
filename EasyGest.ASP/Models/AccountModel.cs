using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EASYGEST.Models
{
    public class AccountModel
    {
        [Required]
        public RegisterModel register { get; set; }
        [Required]
        public LoginModel login { get; set; }
        public AccountModel()
        {

        }

        public AccountModel(RegisterModel register, LoginModel login)
        {
            this.register = register;
            this.login = login;
        }
    }
}