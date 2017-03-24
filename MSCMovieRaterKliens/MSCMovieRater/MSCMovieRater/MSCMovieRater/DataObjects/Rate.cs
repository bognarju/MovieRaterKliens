namespace MSCMovieRaterBackend.DataObjects
{
    using System;
    using System.Collections.Generic;

    public partial class Rate
    {
        public string id { get; set; }

        public string movieId { get; set; }

        public string value { get; set; }
    }
}
