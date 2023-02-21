using System.ComponentModel.DataAnnotations;

namespace ModelValidation.API.Models
{
    public class Users
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^[+]?[(]?[0-9]{3}[)]?[-s.]?[0-9]{3}[-s.]?[0-9]{4,6}$")] //Note remove the excape charaters afer copying from site e.g "\\"
        public string Phone { get; set; }
        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$")] 
        public string Password { get; set; } // note because of the regex password must be a minimun of 8 character, one upper case, one lower case, 
        // one number & one special character.
    }
}

//so to have more control over model validation you can make use of regular expresion to get More regular expression you can go to   "iHateRegex"
