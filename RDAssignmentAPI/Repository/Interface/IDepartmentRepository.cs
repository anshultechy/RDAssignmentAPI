using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IDepartmentRepository
    {
        //IEnumerable<Department> Department { get; }

        //public int MyProperty { get; set; }
        //GetDepartment()
        IEnumerable<Department> GetDepartment();
    }
}


