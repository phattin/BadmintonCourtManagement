using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;
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
        private static StorageDAO dao = new StorageDAO();

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
                StorageList.Add(new StorageDTO()
                {
                    StorageId = "KH" + (random.Next(0, 1000) + 1),
                    ImportBillId = "NH" + (random.Next(0, 1000) + 1),
                    ProductId = "SP" + (random.Next(0, 1000) + 1),
                    Quantity = random.Next(0, 100) + 1,
                    Price = random.Next(0, 1000) + 1,
                    Status = StorageDTO.Option.active
                });
            }
        }


        public static StorageDTO GetStorageById(string id)
        {
            //return dao.GetStorageListByStorageId(id);

            foreach (StorageDTO storage in StorageList)
            {
                if(storage.StorageId == id) return storage;
            }
            return null;
        }

        public static List<StorageDTO> GetAllStorages()
        {
            //return dao.GetAllStorage();

            return StorageBUS.StorageList;
        }

        public static bool InsertStorage(StorageDTO storage)
        {
            // Kiểm tra xem storage đã tồn tại chưa
            //var existing = dao.GetStorageListByStorageId(storage.StorageId);
            //if (existing != null)
            //    throw new Exception("Storage đã tồn tại!");

            //return dao.InsertStorage(storage);

            var existing = StorageBUS.GetStorageById(storage.StorageId);
            if(existing != null)
            {
                throw new Exception("Storage đã tồn tại");
            }
            StorageBUS.StorageList.Add(storage);
            return true;
        }

        public static bool UpdateStorage(StorageDTO storage)
        {
            //var existing = dao.GetStorageListByStorageId(storage.StorageId);
            //if (existing == null)
            //    throw new Exception("Storage không tồn tại!");

            //return dao.UpdateStorage(storage);

            for(int i = 0; i < StorageList.Count; i++)
            {
                if (StorageList[i].StorageId == storage.StorageId)
                {
                    StorageList[i] = storage;
                    return true;
                }
            }

            return false;
        }

        public static bool DeleteStorage(string id)
        {
            //var existing = dao.GetStorageListByStorageId(id);
            //if (existing == null)
            //    throw new Exception("Storage không tồn tại!");

            //return dao.DeleteStorage(id);

            for (int i = 0; i < StorageList.Count; i++)
            {
                if (StorageList[i].StorageId == id)
                {
                    StorageList.Remove(StorageList[i]);
                    return true;
                }
            }

            return false;
        }
    }
}
