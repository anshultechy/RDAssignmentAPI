using Business.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTOs;
using Repository.Interface;

namespace Business.Services
{
public  class DepartmentService : IDepartmentService

    {

        private readonly IUnitOfWork _unitOfWork;
        public DepartmentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;

        }

        public List<DepartmentDto> GetAllDepartments()
        {
            return _unitOfWork.departmentRepository.GetDepartment().Select(x => new DepartmentDto
            {
                Id = x.Id,
                Usernane = x.FirstName +" "+x.LastName,
                Description = x.Description
            }).ToList();
        }

    }
}

