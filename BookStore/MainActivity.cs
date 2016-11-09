using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace BookStore
{
	[Activity(Label = "BookStore", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : ListActivity
	{


		List<Book> bookList;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			//SetContentView(Resource.Layout.Main);

			bookList = new List<Book>();

			bookList.Add(new Book()
			{
				Id = 1,
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Sorcerer's Stone",
				Publisher = "Bloomsbury",
				Year = 1997,
				ImageId = Resource.Drawable.HP1
			});
			bookList.Add(new Book()
			{
				Id = 2,
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Chamber of Secrets",
				Publisher = "Bloomsbury",
				Year = 1998,
				ImageId = Resource.Drawable.HP2
			});
			bookList.Add(new Book()
			{
				Id = 3,
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Prisoner of Azkaban",
				Publisher = "Bloomsbury",
				Year = 1999,
				ImageId = Resource.Drawable.HP3
			});

			//ListAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, new string[] {"Google", "Facebook", "Twitter", "Microsoft"} );

			//var listAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, bookList);
			//ListAdapter = listAdapter;
			var listAdapter = new BooksAdapter(this);
			listAdapter.books = bookList;
			ListAdapter = listAdapter;

			this.ListView.ItemClick+= ListView_ItemClick;

		}

		void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{

			if (e == null) {
				return;
			}

			var selectedBook = bookList[e.Position];
			var intent = new Android.Content.Intent(this, typeof(DetailsActivity));

			Bundle bundle = new Bundle();
			bundle.PutString("book_name", selectedBook.Name);
			bundle.PutInt("book_image", selectedBook.ImageId);

			intent.PutExtras(bundle);

			StartActivity(intent);

		}
	}
}

