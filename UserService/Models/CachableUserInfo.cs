using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace UserService.Models
{
   

    public class ChangePasswordBindingMode
    {
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
    }

   
}
