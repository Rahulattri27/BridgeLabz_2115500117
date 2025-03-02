using System;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
namespace RepositoryLayer.Services
{
	public class RegisterHelloRL:IRegisterHelloRL
	{
		private string username = "root";
		private string password = "root";
		public string GetHello(string value)
		{
			return value+" Hello from Repository Layer";
		}
		public LoginDTO GetUsernamePassword(LoginDTO loginDTO)
		{
			loginDTO.Username = username;
			loginDTO.Password = password;
			return loginDTO;
		}
	}
}

