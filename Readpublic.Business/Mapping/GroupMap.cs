using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business.Mapping
{
    public class GroupMap : ClassMap<Group>
    {
        public GroupMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.DateCreated);
            Map(x => x.Description);
        }
    }
}
