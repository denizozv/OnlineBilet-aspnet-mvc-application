﻿namespace OnlineBilet.Models
{
    public class Actor_Movie
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
