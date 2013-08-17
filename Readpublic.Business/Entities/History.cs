using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class History
	{
		public virtual int Id { get; set; }
		public virtual int UserId { get; set; }
		public virtual DateTime Timestamp { get; set; }
		public virtual Activities Activity { get; set; }
		public virtual string Description { get; set; }
	}
}
