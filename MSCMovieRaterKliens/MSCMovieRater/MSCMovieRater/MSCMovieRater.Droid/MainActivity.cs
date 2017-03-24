using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using MSCMovieRaterBackend.DataObjects;
using System.Threading.Tasks;

namespace MSCMovieRater.Droid
{
	[Activity (Label = "MovieRater", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            ListView movieList;

            // lista lekérés a szervertől
            List<MovieItem> movieItems = new List<MovieItem>();

            for (int i=0; i<5; i++)
            {
                MovieItem item = new MovieItem();
                item.Title = "cím " + i;
                item.Rate = "rate " + i;
                movieItems.Add(item);
            }

            SetContentView(Resource.Layout.Main);
            movieList = FindViewById<ListView>(Resource.Id.list);
            movieList.Adapter = new MSCMovieRater.Droid.ListScreenAdapter(this, movieItems);
            
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "MSC Movie Rater";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.MovieMenu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            Toast.MakeText(this, "hello", ToastLength.Long).Show();
            switch (item.GroupId)
            {
                case 1:
                    RefreshList();
                    return true;
                
                case 2:
                    SearchMovie();
                    return true;
                default:
                    return OnOptionsItemSelected(item);
            }

            
        }

        private void SearchMovie()
        {
            throw new NotImplementedException();
        }

        private void RefreshList()
        {
            throw new NotImplementedException();
        }


    }
}


