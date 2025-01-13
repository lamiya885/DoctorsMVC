using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.DAL.Repostory.Interface
{
    public interface IGenericRepostory<T>
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
         void DeleteAsync(int id);
        Task<int> SaveAsync();
    }
}
