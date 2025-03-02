using System;
using ModelLayer.DTO;
namespace RepositoryLayer.Interface
{
	public interface IRegisterHelloRL
	{
		string GetHello(string value);
		LoginDTO GetUsernamePassword(LoginDTO loginDTO);

	}
}

