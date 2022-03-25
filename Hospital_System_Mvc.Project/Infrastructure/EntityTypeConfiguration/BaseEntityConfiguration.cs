using Hospital_System_Mvc.Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_System_Mvc.Project.Infrastructure.EntityTypeConfiguration
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(false);
            builder.Property(x=> x.CreatedIpAddress).IsRequired(false);
            builder.Property(x => x.CreatedMachineName).IsRequired(false);

            builder.Property(x => x.DeletedDate).IsRequired(false);
            builder.Property(x => x.DeletedIpAddress).IsRequired(false);
            builder.Property(x => x.DeletedMachineName).IsRequired(false);

            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.UpdateIpAddress).IsRequired(false);
            builder.Property(x => x.UpdateMachineName).IsRequired(false);



        }
    }
    



    
}
