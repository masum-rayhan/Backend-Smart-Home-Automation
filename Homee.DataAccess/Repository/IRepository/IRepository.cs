﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homee.DataAccess.Repository.IRepository;

public interface IRepository<T> where T : class
{
    Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter);
    Task AddAsync(T entity);
    Task<T> GetDetailsAsync(int id);
    Task<IEnumerable<T>> GetAllAsync(string? includeProperties = null);
    Task UpdateAsync(T entity);
    void RemoveAsync(T entity);
    void RemoveRangeAsync(IEnumerable<T> entities);
    Task SaveAsync();
}
