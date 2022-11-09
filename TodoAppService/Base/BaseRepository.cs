using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TodoAppDomain.Context;
using TodoAppDomain.Model.Base;
using TodoAppRepository.Repositories.Base;
using TodoAppDomain.Context;

namespace TodoAppService.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly TodoDbContext context;
        //private DbSet<T> entities;

        public BaseRepository(TodoDbContext context)
        {
            this.context = context;
            //entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            context.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            context.Add(entity);
        }

        public async Task AddAsyncRange(List<T> entites)
        {
            context.AddRange(entites);
        }

        public void AddRange(List<T> entities)
        {
            entities.AddRange(entities);
        }

        public IQueryable<T> All()
        {
            return context.Set<T>().Where(x => !x.IsDelete);
        }

        public IQueryable<T> All(params Expression<Func<T, object>>[] includeProperties)
        {
            //IQueryable<T> queryable = All();
            //foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            //{
            //    queryable = queryable.Include<T, object>(includeProperty);
            //}

            //return queryable;
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            return All().FirstOrDefault(x => x.Id == id);
        }

        public async Task<T> FindAsync(int id)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            entity.UpdatedDate = DateTime.Now;
            context.Entry(entity);
        }

        public void UpdateRange(List<T> entites)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            context.Set<T>().Remove(entity);
        }

        public Task DeleteAsyncRange(List<T> entites)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<T> entites)
        {
            if (entites == null)
            {
                throw new ArgumentNullException("entity");
            }

            context.Set<T>().RemoveRange(entites);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
