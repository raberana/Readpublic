using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class ShelfMap:ClassMap<Shelf>
    {
        public ShelfMap()
        {
            Id(x => x.Id);
            Map(x => x.UserId);
            Map(x => x.ShelfCoverPath);
            Map(x => x.DateCreated);
            HasManyToMany(x => x.Genres).Table("ShelfGenre");
            HasManyToMany(x => x.Books).Table("ShelfBook");
        }
    }
}
