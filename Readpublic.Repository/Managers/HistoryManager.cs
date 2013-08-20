using Readpublic.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Repository
{
    public class HistoryManager : NHibernateRepository<History, string>
    {
        public HistoryManager()
            : base()
        {
        }

        public void AddHistory(History history)
        {
            Create(history);
        }
    }
}
