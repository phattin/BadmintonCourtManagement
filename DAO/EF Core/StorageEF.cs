using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.EF_Core
{
    public class StorageEF
    {
        public List<StorageEntity.Storage> GetAll()
        {
            using var context = new AppDbContext();
            return context.Storages.ToList();
        }

        public StorageEntity.Storage GetById(string id)
        {
            using var context = new AppDbContext();
            return context.Storages.FirstOrDefault(x => x.StorageId == id);
        }

        public bool Insert(StorageEntity.Storage storage)
        {
            try {
                using var context = new AppDbContext();
                context.Storages.Add(storage);
                context.SaveChanges();
                return true;
            } catch(Exception e)
            {
                return false;
            }
        }

        public bool Update(StorageEntity.Storage storage)
        {
            using var context = new AppDbContext();
            context.Storages.Update(storage);
            context.SaveChanges();
            return true;
        }

        public bool Delete(string id)
        {
            using var context = new AppDbContext();
            var obj = context.Storages.FirstOrDefault(x => x.StorageId == id);
            if (obj == null) return false;

            context.Storages.Remove(obj);
            context.SaveChanges();
            return true;
        }
    }
}
