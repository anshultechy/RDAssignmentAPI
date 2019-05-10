using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
   public interface IDepartmentService
    {
        List<DepartmentDto> GetAllDepartments();

    }
}



