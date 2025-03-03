using System;
using ModelLayer.DTO;
namespace RepositoryLayer.Interface
{
	public interface IEmployeeRegisterationRL
	{
		void AddEmployee(Entity.EmployeeEntity employeeEntity);
		IEnumerable<Entity.EmployeeEntity> GetAllEmployees();
	}
}

