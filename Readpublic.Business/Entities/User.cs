using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class User
	{
		public virtual int Id { get; set; }
		public virtual string FirstName { get; set; }
		public virtual string MiddleName { get; set; }
		public virtual string LastName { get; set; }
        public virtual IList<int> Favorites { get; set; }
		public virtual IList<int> Shelve { get; set; }
		public virtual IList<int> Friends { get; set; }
		public virtual IList<int> BooksRead { get; set; }
		public virtual IList<int> BooksToRead { get; set; }
		public virtual IList<int> Wishlist { get; set; }
		public virtual Country Country { get; set; }
		public virtual Language Language { get; set; }

	}
}
