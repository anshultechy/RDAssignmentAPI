using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RDAssignmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentBuisnessLogic;
        public DepartmentController(IDepartmentService departmentBuisnessLogic)
        {
            this._departmentBuisnessLogic = departmentBuisnessLogic;
        }
        [HttpGet("get")]
        public IActionResult GetDepartment()
        {
            return Ok(this._departmentBuisnessLogic.GetAllDepartments());
        }
    }
}