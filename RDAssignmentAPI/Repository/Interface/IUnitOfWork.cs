using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
   public interface IUnitOfWork
    {

        IDepartmentRepository departmentRepository { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}

