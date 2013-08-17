using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class BookActivity
    {
        public virtual BookActivityId Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int BookId { get; set; }
        public virtual Activities Activity { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime TimeStamp { get; set; }
    }
}
