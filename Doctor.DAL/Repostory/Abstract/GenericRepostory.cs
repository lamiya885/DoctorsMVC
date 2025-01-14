using Doctor.Core.Entities.Common;
using Doctor.DAL.Context;
using Doctor.DAL.Repostory.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.DAL.Repostory.Abstract
{
    public class GenericRepostory<T>(DoctorsDbContext _context):IGenericRepostory<T> where T : BaseEntity,new()
    {
        protected DbSet<T> Table => _context.Set<T>();

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);

        }

        public async  void DeleteAsync(Guid Id)
        {
            var entity=Table.Where(x => x.Id == Id);
          //  Table.Remove(entity);
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(Guid  id)
        =>await Table.FindAsync(id);

        public async  Task<int> SaveAsync()
         =>await _context.SaveChangesAsync();

      
    }
}
