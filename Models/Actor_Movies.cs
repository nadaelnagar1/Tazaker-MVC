﻿namespace Tazaker.Models
{
    public class Actor_Movies
    {
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public Guid ActorId { get; set; }
        public Actor Actor { get; set; }


    }
}
