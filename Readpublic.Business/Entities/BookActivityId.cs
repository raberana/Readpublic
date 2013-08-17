using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class BookActivityId
    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }

        public virtual int BookId { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as BookActivityId);
        }

        private bool Equals(BookActivityId other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;

            return UserId == other.UserId &&
                BookId == other.BookId;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 31) ^ UserId.GetHashCode();
                hash = (hash * 31) ^ BookId.GetHashCode();

                return hash;
            }
        }
    }
}
