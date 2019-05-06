using System.ComponentModel.DataAnnotations;

namespace DatingApp.DTOs
{
    public class UserForRegistrationDto
    {
        [Required]
        public string Username{get;set;}
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="You must specify a password between 4 & 8 characters long.")]
        public string Password { get; set; }
    }
}