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
        {
           => _repository = repository;
        }
    }
}
