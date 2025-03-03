using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using RepositoryLayer.Entity;
using ModelLayer.DTO;

namespace EmployeeRegisteration.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeRegisterationController : ControllerBase
{
    IEmployeeRegisterationBL _employeeRegisterationBL;
    public EmployeeRegisterationController(IEmployeeRegisterationBL employeeRegisterationBL)
    {
        _employeeRegisterationBL = employeeRegisterationBL;
    }
    [HttpPost]
    public IActionResult AddEmployee([FromBody] EmployeeEntity employeeEntity)
    {
        try
        {
            _employeeRegisterationBL.AddEmployee(employeeEntity);
            return Ok("Employee Added successfully");
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<EmployeeEntity>> Get()
    {
        return Ok(_employeeRegisterationBL.GetAllEmployees());
    }
}

