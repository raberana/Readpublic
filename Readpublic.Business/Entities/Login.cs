using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class Login
	{
		public virtual int Id { get; set; }
		public virtual int UserId { get; set; }
		public virtual string UserName { get; set; }
		public virtual string Password { get; set; }
		public virtual string Email { get; set; }
	}
}
