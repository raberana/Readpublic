using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class PublisherMap:ClassMap<Publisher>
    {
        public PublisherMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Country);
        }
    }
}
