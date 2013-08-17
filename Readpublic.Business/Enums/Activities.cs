using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public enum Activities
	{
		NotSet = 0,
		Joined,
		Login,
		Logout,
		BookWantToRead,
		BookAlreadyRead,
		BookNowReading,
        BookShared,
		CreatedShelf,
		DeletedShelf,
		AddedBookToShelf,
		Wishlisted,
		Unwishlisted
	}
}
