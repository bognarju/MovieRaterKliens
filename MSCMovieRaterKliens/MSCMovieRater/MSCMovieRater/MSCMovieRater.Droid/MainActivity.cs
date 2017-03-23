using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MSCMovieRater.Droid
{
	[Activity (Label = "MovieRater", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "MSC Movie Rater";

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu, menu);
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


