using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System;

namespace MSCMovieRater.Droid
{
    public class ListScreenAdapter : BaseAdapter<MovieItem>
    {
        List<MovieItem> items;
        Activity context;
        public ListScreenAdapter(Activity context, List<MovieItem> items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count
        {
            get { return items.Count; }
        }

        public override MovieItem this[int position]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.RowItem, null);
            view.FindViewById<TextView>(Resource.Id.MovieTitle).Text = item.Title;
            view.FindViewById<TextView>(Resource.Id.MovieRate).Text = item.Rate;

            return view;
        }
    }
}