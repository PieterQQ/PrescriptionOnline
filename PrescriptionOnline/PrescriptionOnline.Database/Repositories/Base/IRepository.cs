﻿namespace PrescriptioOnline.Database
{
    public interface IRepository<Entity> where Entity:BaseEntity
    {
         bool AddNew(Entity entity);
         bool Delete(Entity entity);
        bool Edit(Entity entity);
    }
}
