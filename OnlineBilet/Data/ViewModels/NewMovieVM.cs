using OnlineBilet.Data.Base;
using OnlineBilet.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBilet.Models
{
    public class NewMovieVM 
    {
        public int Id { get; set; } 
        [Display(Name = "Film İsmi")]
        [Required(ErrorMessage = "İsim eksik")]
        public string MovieName { get; set; }

        [Display(Name = "Film Açıklaması")]
        [Required(ErrorMessage = "Açıklama Eksik")]
        public string Description { get; set; }

        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Fiyat Eksik")]
        public double Price { get; set; }

        [Display(Name = "Film Afiş Url")]
        [Required(ErrorMessage = "Film Afişi Eksik")]
        public string ImageUrl { get; set; }

        [Display(Name = "Başlangıç Tarihi")]
        [Required(ErrorMessage = "Başlangıç Tarihi Eksik")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Bitiş Tarihi")]
        [Required(ErrorMessage = "Bitiş Tarihi Eksik")]
        public DateTime EndDate { get; set; }

        [Display(Name = "IMDB")]
        [Required(ErrorMessage = "IMDB Eksik")]
        public double IMDB { get; set; }


        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "Kategori Eksik")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Aktör")]
        [Required(ErrorMessage = "Aktörler Eksik")]
        public List<int> ActorIds { get; set; }



        //Director
        [Display(Name = "Yönetmen")]
        [Required(ErrorMessage = "Yönetmen Eksik")]
        public int DirectorId { get; set; }

        //[Display(Name = "Yönetmen")]
        //[Required(ErrorMessage = "Yönetmen Eksik")]
        //public int HallId { get; set; }


        //[ForeignKey("DirectorId")]
        //public Director Director { get; set; } //director sınıfından bir director

    }

}
