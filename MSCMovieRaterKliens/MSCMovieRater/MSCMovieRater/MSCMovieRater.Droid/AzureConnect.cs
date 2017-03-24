using Microsoft.WindowsAzure.MobileServices;
using MSCMovieRaterBackend.DataObjects;
using System;
using System.Collections.Generic;

namespace MSCMovieRater
{
    public class AzureConnect
	{
        private static AzureConnect Instance;
        private static MobileServiceClient ServiceClient;

        public static AzureConnect getInstance()
        {
            if (Instance == null)
            {
                Instance = new AzureConnect();
            }

            return Instance;
        }
		private AzureConnect()
		{
            ServiceClient = new MobileServiceClient("http://mscmovierater.azurewebsites.net");
        }

        public async System.Threading.Tasks.Task<List<Movie>> getMovies()
        {
            IMobileServiceTable<Movie> movieTable = ServiceClient.GetTable<Movie>();
            return await movieTable.ToListAsync();
        }

        public async System.Threading.Tasks.Task<List<Comment>> getComments(String MovieID)
        {
            IMobileServiceTable<Comment> commentTable = ServiceClient.GetTable<Comment>();
            return await commentTable.Where(Comment => Comment.movieId == MovieID).ToListAsync();
        }

        public async System.Threading.Tasks.Task<Movie> getMovie(String id)
        {
            IMobileServiceTable<Movie> movieTable = ServiceClient.GetTable<Movie>();
            List<Movie> movies = await movieTable.Where(Movie => Movie.id == id).ToListAsync();
            return movies[0];
        }

        public async void insertComment(Comment comment)
        {
            IMobileServiceTable<Comment> commentTable = ServiceClient.GetTable<Comment>();
            await commentTable.InsertAsync(comment);
        }

        public async void insertRate(Rate rate)
        {
            IMobileServiceTable<Rate> rateTable = ServiceClient.GetTable<Rate>();
            await rateTable.InsertAsync(rate);
        }
    }
}

