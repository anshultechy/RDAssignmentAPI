using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.ManagerService
{
   public class DepartmentRepository : IDepartmentRepository

    {

        private readonly AppDbContext context;
        public DepartmentRepository(AppDbContext dbContext)
        {
            this.context = dbContext;
        }

        public IEnumerable<Department> Department => throw new NotImplementedException();

        public IEnumerable<Department> GetDepartment()
        {
            return context.Department.AsEnumerable();

        }

    }
}
