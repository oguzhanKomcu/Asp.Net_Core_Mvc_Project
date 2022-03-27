using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories
{
    public abstract class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {

        private readonly AppDbContext _appDbContext;
        protected DbSet<T> table;


        public BaseRepo(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
            table = _appDbContext.Set<T>();

        }



        public void Create(T entity)
        {
            table.Add(entity);
            _appDbContext.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> exp)
        {
            return table.FirstOrDefault(exp);
        }

        public List<T> Gets()
        {
            return table.ToList();
        }

        public List<T> Gets(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        public void Remove(T entity)
        {
            _appDbContext.Entry<T>(entity).State = EntityState.Deleted;
            _appDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _appDbContext.Entry<T>(entity).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }
    }
}
