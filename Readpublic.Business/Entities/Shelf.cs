using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class Shelf
	{
		public virtual int Id { get; set; }
		public virtual int UserId { get; set; }
        public virtual string Name { get; set; }
		public virtual DateTime DateCreated { get; set; }
        public virtual IList<Book> Books { get; set; }
		public virtual IList<Genre> Genres { get; set; }
		public virtual string ShelfCoverPath { get; set; }
	}
}
