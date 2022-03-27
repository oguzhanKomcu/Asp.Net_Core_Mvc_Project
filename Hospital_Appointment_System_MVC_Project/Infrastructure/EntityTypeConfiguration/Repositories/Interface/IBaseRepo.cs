using Hospital_Appointment_System_MVC_Project.Models.Entities;
using System.Linq.Expressions;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);

        T Get(Expression<Func<T, bool>> exp);

        List<T> Gets();
        List<T> Gets(Expression<Func<T, bool>> exp);


    }
}
