using OnlineBilet.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace OnlineBilet.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Görsel Eklenmelidir")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "İsim Eklenmelidir")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "İsim en az 3 karakter olabilir.")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Hakkında Eklenmelidir'")]
        public string Bio { get; set; }

        //Relations

        public List<Actor_Movie>? Actors_Movies { get; set; } ///BURAYA BAK
    }
}
