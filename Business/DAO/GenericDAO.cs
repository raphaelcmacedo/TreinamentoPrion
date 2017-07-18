﻿using Business.Contexts;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DAO
{
    public class GenericDAO<T> : IDisposable where T : GenericModel
    {
        private CadastroContext context;

        public GenericDAO()
        {
            context = new CadastroContext();
        }

        public void Add (T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.SaveChanges();
        }

        public T Find(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
