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
		public virtual Author Author { get; set; }
		public virtual Country Country { get; set; }
		public virtual Language Language { get; set; }
	
	}
}
