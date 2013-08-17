using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class AuthorMap:ClassMap<Author>
    {
        public AuthorMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.MiddleName);
            Map(x => x.LastName);
            Map(x => x.UserId);
            Map(x => x.Points);
            Map(x => x.ProfileDisplayPath);
            
        }
    }
}
