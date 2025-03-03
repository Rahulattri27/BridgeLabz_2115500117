using System;
using RepositoryLayer.Entity;
using ModelLayer.DTO;
namespace BusinessLayer.Interface
{
	public interface IEmployeeRegisterationBL
	{
		void AddEmployee(EmployeeEntity employeeEntity);
		IEnumerable<EmployeeEntity> GetAllEmployees();
	}
}

