using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions;

namespace Application.Brand.UseCases
{
    public  class BrandUseCase : IUserCase<BrandEntity> //orquestador - caso de uso - servicio
    {
        private IRepositoryz<BrandEntity> _repository;
        public BrandUseCase(IRepositoryz<BrandEntity> repository) //Inyeccion de dependencias
        
           => _repository = repository;
        public async Task<BrandEntity> GetAllAsync()
            => await _repository.GetAllAsyncs(0); //0 porque no se usa id
        public async Task<BrandEntity> GetByIdAsync(int id)
            => await _repository.GetByIdAsync(id);
        public async Task AddAsync(BrandEntity entity)
            => await _repository.AddAsync(entity);
    }
}
