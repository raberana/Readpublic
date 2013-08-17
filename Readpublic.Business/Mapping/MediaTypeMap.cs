using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class MediaTypeMap: ClassMap<MediaType>
    {
        public MediaTypeMap()
        {
            Id(x=>x.Id);
            Map(x=>x.Name);
            Map(x=>x.Code);
            Map(x=>x.Description);
        }
    }
}
