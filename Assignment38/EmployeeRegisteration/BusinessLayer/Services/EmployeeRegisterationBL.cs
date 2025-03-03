using System;
using BusinessLayer.Interface;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
namespace BusinessLayer.Services
{
	public class EmployeeRegisterationBL:IEmployeeRegisterationBL
	{
		private readonly IEmployeeRegisterationRL _employeeRegisterationRL;
		private readonly ILogger<EmployeeRegisterationBL> _logger;

		public EmployeeRegisterationBL(IEmployeeRegisterationRL employeeRegisterationRL, ILogger<EmployeeRegisterationBL> logger)
		{
			_logger = logger;
			_employeeRegisterationRL = employeeRegisterationRL;

		}
		public void AddEmployee(EmployeeEntity employeeEntity )
			{
				if(string.IsNullOrEmpty(employeeEntity.Name)|| string.IsNullOrEmpty(employeeEntity.Email))
				{
				_logger.LogError("Name and Email is not Provided");
					throw new ArgumentException("Name and Email are Required");
				}
			_logger.LogInformation("Business Layer Giving Employees to Repository Layer");
				_employeeRegisterationRL.AddEmployee(employeeEntity);
			_logger.LogInformation("Business Layer Provided the employees");
			}
		public IEnumerable<EmployeeEntity> GetAllEmployees()
		{
            try
            {
                _logger.LogInformation("Business Layer: Fetching all employees.");
                var employees = _employeeRegisterationRL.GetAllEmployees();
                _logger.LogInformation("Business Layer: Retrieved {Count} employees.", employees.Count());
                return employees;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Business Layer while fetching employees.");
                throw;
            }
        }
	 
	}
}

