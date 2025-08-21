using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IUseCase<TEntity> //Contrato
    {
        Task<TEntity> GetByIdAsync(int id); //Asincronia
        Task<IEnumerable<TEntity>> GetAllAsync(); 
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
    }
}
