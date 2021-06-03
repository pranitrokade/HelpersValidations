using HelpersValidations.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpersValidations.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",ErrorMessage = "Please enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
        [Compare("Password",ErrorMessage ="Password does not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter contact")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Please enter valid contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        public string Address { get; set; }

        //[Required(ErrorMessage = "Please check terms")]
        [ValidateCheckBox(ErrorMessage = "Please check terms")]
        public bool Terms { get; set; }

        [Required(ErrorMessage = "Please enter gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select city")]

        [ValidateDropdown(ErrorMessage = "Please select city")]
        public string City { get; set; }
    }

    public enum Cities
    {
        Pune,
        Mumbai,
        Chennai,
        Bangalore
    }
}
