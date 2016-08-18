﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> All();

        IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Detach(T entity);
    }
}
