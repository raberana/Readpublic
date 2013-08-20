using NHibernate;
using Readpublic.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Repository
{
    public class UserManager : NHibernateRepository<User, string>
    {
        ISession _session;
        public UserManager()
            : base()
        {
        }

      
        public User FindUserById(int id)
        {
            return Session.QueryOver<User>().Where(x => x.Id == id).SingleOrDefault();
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }

        public void SaveOrUpdateUser(User user)
        {
            Update(user);
        }

        public void AddUser(User user)
        {
            Create(user);
        }

        public IEnumerable<User> FindUsers()
        {
            return Session.QueryOver<User>().Where(user => user.Id != 0).List().AsEnumerable();
        }

        public IEnumerable<User> Find(string text)
        {
            throw new NotImplementedException();
        }
    }
}
