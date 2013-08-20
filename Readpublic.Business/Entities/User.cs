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
		public virtual string Tag { get; set; }
		public virtual Country Country { get; set; }
		public virtual Language Language { get; set; }
		public virtual DateTime JoinDate { get; set; }
		public virtual DateTime LastSeen { get; set; }
        public virtual IList<Shelf> Shelve { get; set; }
		public virtual bool IsAuthor { get; set; }
        public virtual int AuthorId { get; set; }
		public virtual string ProfileDisplayPath { get; set; }
        public virtual int Points { get; set; }

        public User()
        {
            JoinDate = DateTime.Now.ToUniversalTime();
            Points = 100;
        }
	}
}
