using System.ComponentModel.DataAnnotations;

namespace OnlineBilet.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "İsim Eksik")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "E-Mail adresi eksik")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [Required(ErrorMessage = "Şifre eksik")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
    }
}

