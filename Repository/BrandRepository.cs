using System;
using Domain;
using Application.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class BrandRepository : IRepository<BrandEntity>
    {
        private StoreContext _Context;
        public BrandRepository(StoreContext context) //para entity framework
        {
            _Context = context;
        }
        public async Task <BrandEntity> GetByIdAsync(int id)
        {
            var brand = await _Context.Brands.FirstOrDefaultAsync(b => b.Id == id);
            if(brand == null)
            {
                throw new KeyNotFoundException($"La marca no existe");
            }
            return MapToEntity(brand);
        }
        #region Mappers
        private static BrandEntity MapToEntity(Brand model)
        {
            return new BrandEntity(model.Id, model.Name);

        }
        private static Brand MapToModel(BrandEntity entity)
        {
            return new Brand(entity.Id, entity.Name);
        }
        #endregion
    }
}
