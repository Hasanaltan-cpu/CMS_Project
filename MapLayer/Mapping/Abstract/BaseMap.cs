using EntityLayer.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapLayer.Mapping.Abstract
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {
        //In this class we will use parent class for the other all concretes classes.
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x=>x.CreateDate).IsRequired(true);
            builder.Property(x => x.UpdateDate).IsRequired(false);//These 2 rows are false because they are nullable it means it can be null.When u create a first time it doesn't have Update&Delete Date.
            builder.Property(x => x.DeleteDate).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true);
        }
    }
}
