using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
    public class LoginMap:ClassMap<Login>
    {
        public LoginMap()
        {
            Id(x => x.Id);
            Map(x => x.UserId);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.Email);
           
        }
    }
}
