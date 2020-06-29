using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrescriptioOnline.Database
{
    public abstract class BaseRepository<Entity> where Entity : class
    {
        protected PrescriptionOnlineDbContext _DbContext;
        protected abstract DbSet<Entity> DbSet { get; }
        public BaseRepository(PrescriptionOnlineDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public List<Entity> GetAll()
        {
            var list = new List<Entity>();
            var entities = DbSet;
            foreach (var entity in entities)
            {
                list.Add(entity);
            }

            return list;
        }
        public void SaveChanges()
        {
            _DbContext.SaveChanges();
        }
    }
}
