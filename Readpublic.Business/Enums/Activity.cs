using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public enum Activity
	{
		NotSet = 0,
		Joined,
		Login,
		Logout,
		WantToRead,
		AlreadyRead,
		NowReading,
		CreatedShelf,
		DeletedShelf,
		AddedBookToShelf,
		Wishlisted,
		Unwishlisted
	}
}
