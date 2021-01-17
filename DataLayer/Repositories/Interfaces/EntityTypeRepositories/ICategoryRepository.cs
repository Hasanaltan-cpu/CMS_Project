using DataLayer.Repositories.Interfaces.Base;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories.Interfaces.EntityTypeRepositories
{
   public interface ICategoryRepository:IKernelRepository<Category>
    {
    }
}
