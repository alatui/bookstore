using System;
namespace BookStore
{
	public class Book
	{
		public long Id;
		public string Name;
		public string Author;
		public string Publisher;
		public int Year;
		public int ImageId;


		public override string ToString()
		{
			return string.Format("{0}-{1}-{2}-{3}",Name,Author,Publisher,Year);
		}

	}
}
