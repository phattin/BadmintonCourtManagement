using BadmintonCourtManagement.DTO;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUS.EF_Core
{
    public class StorageMapper
    {
        public static StorageEntity.Storage ToEntity(StorageDTO dto)
        {
            return new StorageEntity.Storage
            {
                StorageId = dto.StorageId,
                ImportBillDetailId = dto.ImportBillDetailId,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                Price = dto.Price,
                CreatedAt = dto.CreatedAt,
                Status = dto.Status == StorageDTO.Option.active
                            ? StorageEntity.Storage.Option.active
                            : StorageEntity.Storage.Option.inactive
            };
        }

        public static StorageDTO ToDTO(StorageEntity.Storage entity)
        {
            return new StorageDTO
            {
                StorageId = entity.StorageId,
                ImportBillDetailId = entity.ImportBillDetailId,
                ProductId = entity.ProductId,
                Quantity = entity.Quantity,
                Price = entity.Price,
                CreatedAt = entity.CreatedAt,
                Status = entity.Status == StorageEntity.Storage.Option.active
                            ? StorageDTO.Option.active
                            : StorageDTO.Option.inactive
            };
        }
    }
}
