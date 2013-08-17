using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class BookActivityMap: ClassMap<BookActivity>
    {
        public BookActivityMap()
        {
            Table("BookActivity");

            CompositeId<BookActivityId>(x => x.Id)
                .KeyProperty(x => x.UserId, "UserId")
                .KeyProperty(x => x.BookId, "BookId");

            Map(x => x.Description);
            Map(x => x.TimeStamp);
            Map(x => x.Activity);
        }
    }
}
