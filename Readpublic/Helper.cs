using Readpublic.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readpublic
{
    public static class Helper
    {
        public static IDictionary<Activities, string> ActivityDescription = new Dictionary<Activities, string>();

        public static string GenerateActivityDescription(User user, 
            Activities activity, 
            Book book = null, 
            Shelf shelf = null, 
            Group group = null)
        {
            var description = string.Empty;

            switch (activity)
            {
                case Activities.AddedBookToShelf:
                    description = string.Format("Added book {0} to shelf {1}", book.Title);
                    break;
                case Activities.BookAlreadyRead: 
                    break;
                case Activities.BookNowReading:
                    break;
                case Activities.BookShared: 
                    break;
                case Activities.BookWantToRead: 
                    break;
                case Activities.CreatedShelf: 
                    break;
                case Activities.DeletedShelf: 
                    break;
                case Activities.Joined:
                    description = string.Format("Joined READPUBLIC on {0}", user.JoinDate);
                    break;
                case Activities.Login: 
                    break;
                case Activities.Logout: 
                    break;
                case Activities.Unwishlisted: 
                    break;
                case Activities.Wishlisted: 
                    break;
                default: 
                    break;
            }


            return description;

        }
    }
}