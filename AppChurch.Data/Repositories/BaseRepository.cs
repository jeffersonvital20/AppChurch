﻿using AppChurch.Data.Context;
using AppChurch.Domain.Repositories.Interfaces;

namespace AppChurch.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public BaseRepository(AppDbContext context) => _context = context;

        public async Task Create(T create)
        {
            await _context.Set<T>().AddAsync(create);
            Save();
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
            Save();
        }

        public IQueryable<T> GetAll() => _context.Set<T>();

        public T GetById(Guid id) => _context.Set<T>().Find(id);

        public void Save() => _context.SaveChanges();

        public void Update(T update)
        {
            _context.Set<T>().Update(update);
            Save();
        }
    }
}
