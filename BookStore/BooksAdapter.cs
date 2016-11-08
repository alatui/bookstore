using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;

namespace BookStore
{
	public class BooksAdapter : BaseAdapter
	{

		public List<Book> books;
		Activity activity;

		public BooksAdapter(Activity activity)
		{
			books = new List<Book>();
			this.activity = activity;
		}


		public override int Count
		{
			get
			{
				return this.books.Count;
			}
		}


		public override Android.Views.View GetView(int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			var view = convertView ?? this.activity.LayoutInflater.Inflate(
				Resource.Layout.BookCell, parent, false
			);

			TextView nameTextView = view.FindViewById<TextView>(Resource.Id.nameTextView);
			TextView yearTextView = view.FindViewById<TextView>(Resource.Id.yearTextView);
			TextView authorTextView = view.FindViewById<TextView>(Resource.Id.authorTextView);
			TextView publisherTextView = view.FindViewById<TextView>(Resource.Id.publisherTextView);

			var data = books[position];

			nameTextView.Text = data.Name;
			yearTextView.Text = data.Year.ToString();
			authorTextView.Text = data.Author;
			publisherTextView.Text = data.Publisher;

			return view;
		}

		public override Java.Lang.Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return books[position].Id;
		}

	}
}
