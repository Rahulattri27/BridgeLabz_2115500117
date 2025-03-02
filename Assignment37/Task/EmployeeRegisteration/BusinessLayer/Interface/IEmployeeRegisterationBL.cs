using System;
using RepositoryLayer.Entity;
namespace BusinessLayer.Interface
{
	public interface IEmployeeRegisterationBL
	{
		void AddEmployee(EmployeeEntity employeeEntity);
		IEnumerable<EmployeeEntity> GetAllEmployees();
	}
}

