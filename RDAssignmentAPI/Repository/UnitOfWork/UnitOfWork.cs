using Repository.Interface;
using Repository.ManagerService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {

        private readonly AppDbContext DbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        private IDepartmentRepository _departmentRepository;
        public IDepartmentRepository departmentRepository
        {
            get
            {
                if (this._departmentRepository == null)
                {
                    this._departmentRepository = new DepartmentRepository(DbContext);
                }
                return this._departmentRepository;
            }
        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public Task<int> CompleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}


