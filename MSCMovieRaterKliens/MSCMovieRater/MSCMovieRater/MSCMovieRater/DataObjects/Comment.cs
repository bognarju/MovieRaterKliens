namespace MSCMovieRaterBackend.DataObjects
{
    using System;
    using System.Collections.Generic;

    
    public partial class Comment
    {
        public string id { get; set; }

        public string movieId { get; set; }

        public string createdAt { get; set; }

        public string deleted { get; set; }

        public string comment { get; set; }
    }
}
