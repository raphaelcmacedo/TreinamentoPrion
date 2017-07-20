using Business.DAO;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class GenericService<TEntity> where TEntity : GenericModel
    {

        protected readonly GenericDAO<TEntity> dao;

        public GenericService(GenericDAO<TEntity> dao)
        {
            this.dao = dao;
        }

        public virtual void Add(TEntity entity)
        {
            Validate(entity);
            dao.Add(entity);
        }
        public void Update(TEntity entity)
        {
            Validate(entity);
            dao.Update(entity);
        }
        public virtual void Validate(TEntity entity)
        {

        }
        public TEntity Find(int id)
        {
            return dao.Find(id);
        }
        public IEnumerable<TEntity> ListAll()
        {
            return dao.ListAll();
        }
        public void Delete(TEntity entity)
        {
            dao.Delete(entity);
        }

        public void Dispose()
        {
            dao.Dispose();
        }
    }
}
