using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class HistoryMap:ClassMap<History>
    {
        public HistoryMap()
        {
            Id(x => x.Id);
            Map(x => x.Activity);
            Map(x => x.Description);
            Map(x => x.Timestamp);
            Map(x => x.UserId);
        }
    }
}
