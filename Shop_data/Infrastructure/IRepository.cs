﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Shop_data.Infrastructure
{
    public interface IRepository<T> where T  : class
    {
        //Marks an entity as new
        void Add(T entity);

        //Marks an entity as modified
        void Update(T entity);

        //Marks an entity to be removed
        void Delete(T entity);

        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        //get an entity by int ID
        T GetSingleByID(int id);

        T GetSingleByCodition(Expression<Func<T, bool>> expression,string[] include=null);

        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] include = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50,
            string[] include = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContain(Expression<Func<T, bool>> predicate);

    }
}