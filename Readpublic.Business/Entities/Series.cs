using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class Series
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual IList<Book> Books { get; set; }
		public virtual Author Author { get; set; }
		public virtual DateTime StartDate { get; set; }
		public virtual DateTime EndDate { get; set; }
		public virtual string Description { get; set; }
		public virtual string SeriesCoverPath { get; set; }
	}
}
