using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.CoreInterfaces;


namespace Project.MAP.Configurations
{
    public abstract class BaseConfiguration<T>:IEntityTypeConfiguration<T> where T: class,IEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).HasColumnName("Oluşturulma Tarihi");
        }
    }
}
