namespace MSCMovieRaterBackend.DataObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
      
        public string id { get; set; }

        public string createdAt { get; set; }

        public string updatedAt { get; set; }

        public string version { get; set; }

        public string deleted { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string rate { get; set; }

        public string imdbUrl { get; set; }
    }
}
