using System.Collections.Generic;

namespace videostore.Models
{
    class Movie
    {
        /**Title
        Plot
        ReleaseYear
        Actors This is List of type Actor 
        */
        public string Title { get; set; }
        public string Plot { get; set; }
        public int ReleaseYear { get; set; }
        public List<Actor> Actors { get; set; }
        public bool Available { get; set; }

        public Movie(string title, string plot, int releaseyear, bool available = true) 
        {
            Title = title;
            Plot = plot;
            ReleaseYear = releaseyear;
            Actors = new List<Actor>();
            Available = available;

        }
    }
}               