using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class BookMap: ClassMap<Book>
    {
        public BookMap()
        {
            Id(x => x.Id);
            Map(x => x.Description);
            Map(x => x.ISBN);
            Map(x => x.Pages);
            Map(x => x.Title);
            Map(x => x.Rating);
            Map(x => x.PublicationDate);
            References(x => x.Country);
            References(x => x.Language);
            HasOne(x => x.Prequel);
            HasOne(x => x.Sequel);
            References(x => x.Author);
            References(x => x.Publisher);
            References(x => x.Series);
            HasManyToMany(x => x.Genres).Table("BookGenre");
            HasManyToMany(x => x.MediaTypes).Table("BookMediaType");
        }
    }
}
