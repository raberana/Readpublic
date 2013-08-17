using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.MiddleName);
            Map(x => x.LastName);
            Map(x => x.JoinDate);
            Map(x => x.LastSeen);
            Map(x => x.Points);
            Map(x => x.ProfileDisplayPath);
            Map(x => x.Tag);
            Map(x => x.AuthorId);
            References(x => x.Country);
            References(x => x.Language);
            HasManyToMany(x => x.Shelve).Table("UserShelve");
        }
    }
}
