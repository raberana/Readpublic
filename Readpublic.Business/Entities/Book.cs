using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class Book
	{
		public virtual int Id { get; set; }
		public virtual string Title { get; set; }
		public virtual string Description { get; set; }
		public virtual Author Author { get; set; }
		public virtual Country Country { get; set; }
		public virtual Language Language { get; set; }
		public virtual Series Series { get; set; }
		public virtual Book Prequel { get; set; }
		public virtual Book Sequel { get; set; }
		public virtual IList<int> Genres { get; set; }
		public virtual Publisher Publisher { get; set; }
		public virtual DateTime PublicationDate { get; set; }
		public virtual IList<int> MediaTypes { get; set; }
		public virtual int Pages { get; set; }
		public virtual string ISBN { get; set; }
        public virtual decimal Rating { get; set; }
	}
}
