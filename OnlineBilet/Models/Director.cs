using OnlineBilet.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace OnlineBilet.Models
{
    public class Director:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profil Fotoğrafı Eksik")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "İsim Eksik")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="İsim en az 3 en fazla 50 karakter olmalıdır.")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Bio Eksik")]
        public string Bio { get; set; }

        //Relationship

        public List<Movie>? Movies { get; set; }
    }
}
