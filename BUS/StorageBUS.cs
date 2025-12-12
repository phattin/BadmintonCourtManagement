using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;
using BUS.EF_Core;
using DAO.EF_Core;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonCourtManagement.BUS
{
    public class StorageBUS
    {
        private static StorageEF dao = new StorageEF();

        // data test
        private static List<StorageDTO> StorageList = new List<StorageDTO>();

        static StorageBUS()
        {
            InitDataTest();
        }
        
        public static void InitDataTest()
        {
            Random random = new Random();
            StorageList.Clear();
            for (int i = 0; i < 20; i++)
            {
                // kho hàng
                StorageList.Add(new StorageDTO()
                {
                    StorageId = "KH" + (i + 1),
                    ImportBillDetailId = "NH" + (i + 1),
                    ProductId = "SP" + (i + 1),
                    Quantity = random.Next(0, 100) + 1,
                    Price = random.Next(0, 1000) + 1,
                    CreatedAt = new DateTime(2025, 1, i + 1, 8, 0, 0),
                    Status = StorageDTO.Option.active
                });
            }
        }

        public static StorageDTO GetStorageById(string id)
        {
            //return dao.GetStorageListByStorageId(id);

            //foreach (StorageDTO storage in StorageList)
            //{
            //    if(storage.StorageId == id) return storage;
            //}
            //return null;

            var entity = dao.GetById(id);
            return entity == null ? null : StorageMapper.ToDTO(entity);
        }

    

        public static List<StorageDTO> GetAllStorages()
        {
            //return dao.GetAllStorage();

            //return StorageBUS.StorageList;

            var entities = dao.GetAll();
            var list = new List<StorageDTO>();
            foreach (var item in entities)
                list.Add(StorageMapper.ToDTO(item));

            return list;
        }

        public static bool InsertStorage(StorageDTO storage)
        {
            // Kiểm tra xem storage đã tồn tại chưa
            //var existing = dao.GetStorageListByStorageId(storage.StorageId);
            //if (existing != null)
            //    throw new Exception("Storage đã tồn tại!");

            //return dao.InsertStorage(storage);

            //var existing = StorageBUS.GetStorageById(storage.StorageId);
            //if(existing != null)
            //{
            //    throw new Exception("Storage đã tồn tại");
            //}
            //StorageBUS.StorageList.Add(storage);
            //return true;

            var existing = dao.GetById(storage.StorageId);
            if (existing == null)
            {
                var entity = StorageMapper.ToEntity(storage);
                entity.CalcTotal();
                return dao.Insert(entity);
            }

            //throw new Exception("Storage đã tồn tại!");
            return false;
        }

        public static bool UpdateStorage(StorageDTO storage)
        {
            //var existing = dao.GetStorageListByStorageId(storage.StorageId);
            //if (existing == null)
            //    throw new Exception("Storage không tồn tại!");

            //return dao.UpdateStorage(storage);

            //for(int i = 0; i < StorageList.Count; i++)
            //{
            //    if (StorageList[i].StorageId == storage.StorageId)
            //    {
            //        StorageList[i] = storage;
            //        return true;
            //    }
            //}
            //return false;

            var existing = dao.GetById(storage.StorageId);
            if (existing == null)
                throw new Exception("Storage không tồn tại!");
            var entity = StorageMapper.ToEntity(storage);
            entity.CalcTotal();
            return dao.Update(entity);
        }

        public static bool DeleteStorage(string id)
        {
            //var existing = dao.GetStorageListByStorageId(id);
            //if (existing == null)
            //    throw new Exception("Storage không tồn tại!");

            //return dao.DeleteStorage(id);

            //for (int i = 0; i < StorageList.Count; i++)
            //{
            //    if (StorageList[i].StorageId == id)
            //    {
            //        StorageList.Remove(StorageList[i]);
            //        return true;
            //    }
            //}
            //return false;

            return dao.Delete(id);
        }
    }
}
