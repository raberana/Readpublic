using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class Author
	{
		public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
		public virtual int UserId { get; set; }
		public virtual string ProfileDisplayPath { get; set; }
        public virtual int Points { get; set; }
	}
}
