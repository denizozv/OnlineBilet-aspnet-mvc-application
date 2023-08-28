using OnlineBilet.Models;

namespace OnlineBilet.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Directors = new List<Director>();
            Actors = new List<Actor>();
        }

        public List<Director> Directors { get; set; }
        public List<Actor> Actors { get; set; }
    }
}

