
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

namespace BookStore
{
	[Activity(Label = "DetailsActivity")]
	public class DetailsActivity : Activity
	{

		private TextView nameTextView2;
		private ImageView bookImageView2;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Details);

			nameTextView2 = FindViewById<TextView>(Resource.Id.nameTextView2);
			bookImageView2 = FindViewById<ImageView>(Resource.Id.bookImageView2);

			var selectedBook = new Book();
			selectedBook.Name = Intent.Extras.GetString("book_name");
			selectedBook.ImageId = Intent.Extras.GetInt("book_image");

			nameTextView2.Text = selectedBook.Name;
			bookImageView2.SetImageResource(selectedBook.ImageId);

		}
	}
}
