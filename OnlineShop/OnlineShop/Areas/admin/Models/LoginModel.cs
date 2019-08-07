using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter your username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string PassWord { get; set; }

        public bool RememberMe { get; set; }

    }
}