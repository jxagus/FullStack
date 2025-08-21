using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface iUserCase<TEntity> //Contrato
    {
        Task<TEntity> GetByIdAsync(int id); //Asincronia
        Task<IEnumerable<TEntity>> GetAllAsyncs(int id); 
        Task AddAsync(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
