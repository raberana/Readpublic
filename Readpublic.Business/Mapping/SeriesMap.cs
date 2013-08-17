using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class SeriesMap:ClassMap<Series>
    {
        public SeriesMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.SeriesCoverPath);
            Map(x => x.StartDate);
            Map(x => x.EndDate);
            HasOne(x => x.Author);
            Map(x => x.Description);
            HasMany(x => x.Books).Inverse().Cascade.All();
        
        }
    }
}
