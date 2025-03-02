using System;
using RepositoryLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using Microsoft.Extensions.Logging;
namespace RepositoryLayer.Service
{
	public class EmployeeRegisterationRL:IEmployeeRegisterationRL
	{
		private readonly EmployeeRegisterationContext _context;
		private readonly ILogger<EmployeeRegisterationRL> _logger;
		public EmployeeRegisterationRL(EmployeeRegisterationContext context,ILogger<EmployeeRegisterationRL> logger)
		{
			_context = context;
			_logger = logger;
		}
		public void AddEmployee(Entity.EmployeeEntity employee)
		{
			try
			{
				_logger.LogInformation("Attempting to add Employee {employeeName}",employee.Name);
				_context.Employees.Add(employee);
				_context.SaveChanges();
				_logger.LogInformation("Employee Added Successfully {employeeName}", employee.Name);

            }
			catch(Exception ex)
			{
				_logger.LogError(ex, "Unexpected error while adding employee {employeeName}", employee.Name);

                throw new Exception(ex.Message);
			}
		}
        public IEnumerable<Entity.EmployeeEntity> GetAllEmployees()
        {
			try
			{
                _logger.LogInformation("Fetching all employees from the database.");
				var employees= _context.Employees.ToList();
                _logger.LogInformation("Successfully retrieved {Count} employees.", employees.Count);
				return employees;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error while fetching employees");

				throw;
            }


        }
    }
}

