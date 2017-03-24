using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MSCMovieRater.Droid
{
    public class MovieItem
    {
        private string title;

        public string Title { get { return title; } set { title = value; } }

        public string Rate { get; set; }
    }
}