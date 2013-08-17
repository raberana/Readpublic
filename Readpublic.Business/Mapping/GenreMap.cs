using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class GenreMap:ClassMap<Genre>
    {
        public GenreMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Code);
            Map(x => x.Description);
        }
    }
}
