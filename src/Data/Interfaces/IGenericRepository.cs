﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectNewName.Data.Interfaces
{
  public interface IGenericRepository<T> where T : class
  {
    Task<List<T>> Find(
      Expression<Func<T, bool>> where = null,
      List<Expression<Func<T, object>>> includes = null,
      //Expression<Func<object, object>>[] thenIncludes = null,
      Expression<Func<T, T>> selects = null,
      Expression<Func<T, object>> orderByDesc = null,
      Expression<Func<T, object>> orderByAsc = null,
      int pageNumber = 0,
      int itemsPerPage = 0
      );

    Task<T> AddOrUpdate(T entity);
    Task Delete(T entity);
    Task DeleteRange(List<T> entity);
  }
}
