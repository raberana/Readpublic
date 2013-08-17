using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Repository
{
	public class NHibernateRepository<TEntity, TKey> where TEntity : class
	{
		ISession _session;
		protected Configuration config;
		protected ISessionFactory sessionFactory;

		public NHibernateRepository()
		{
			try
			{
				config = Fluently.Configure()
						  .Database(
							  MsSqlConfiguration
							  .MsSql2008
							  .ConnectionString("Data Source=localhost;Initial Catalog=rpdb;Integrated Security=True;User ID=rp;Password=rp123"))
							  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TEntity>())
							  .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
						  .BuildConfiguration();

				sessionFactory = config.BuildSessionFactory();
				if (_session == null)
					_session = sessionFactory.OpenSession();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


		public NHibernateRepository(ISession session)
		{
			_session = session;
		}

		protected ISession Session
		{
			get
			{
				return _session;
			}
		}

		public TEntity GetById(string id)
		{
			return _session.Get<TEntity>(id);
		}

		public void Create(TEntity entity)
		{
			NHibernateUnitOfWork unitOfWork = new NHibernateUnitOfWork(_session);
			unitOfWork.Session.SaveOrUpdate(entity);
			unitOfWork.SaveChanges();
		}

		public void Update(TEntity entity)
		{
			NHibernateUnitOfWork unitOfWork = new NHibernateUnitOfWork(_session);
			unitOfWork.Session.SaveOrUpdate(entity);
			unitOfWork.SaveChanges();
		}

		public void Delete(TEntity entity)
		{
			NHibernateUnitOfWork unitOfWork = new NHibernateUnitOfWork(_session);
			unitOfWork.Session.Delete(entity);
			unitOfWork.SaveChanges();
		}


	}
}
