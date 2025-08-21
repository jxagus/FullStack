using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions;

namespace Application.Brand.UseCases
{
    public  class BrandUseCase : IUseCase<BrandEntity> //orquestador - caso de uso - servicio
    {
        private IRepository<BrandEntity> _repository;
        public BrandUseCase(IRepository<BrandEntity> repository) //Inyeccion de dependencias   
           => _repository = repository;
        public async Task<IEnumerable<BrandEntity>> GetAllAsync()
            => await _repository.GetAllAsync(); 
        public async Task<BrandEntity> GetByIdAsync(int id)
            => await _repository.GetByIdAsync(id);
        public async Task AddAsync(BrandEntity entity)
            => await _repository.AddAsync(entity);
        public async Task UpdateAsync(BrandEntity entity)
            => await _repository.UpdateAsync(entity);
        public async Task DeleteAsync(int id)
            => await _repository.DeleteAsync(id);
    }
}
