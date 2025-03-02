using System;
using ModelLayer.DTO;
namespace BusinessLayer.Interface
{
	public interface IRegisterHelloBL
	{
		string Registeration(string value);
		bool LoginUser(LoginDTO loginDTO);
	}
}

