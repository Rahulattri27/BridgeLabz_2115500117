using System;
using RepositoryLayer.Interface;
using ModelLayer.DTO;
using BusinessLayer.Interface;
namespace BusinessLayer.Services
{
	public class RegisterHelloBL:IRegisterHelloBL
	{

		IRegisterHelloRL _registerHelloRL;
		public RegisterHelloBL(IRegisterHelloRL registerHelloRL)
		{
			_registerHelloRL = registerHelloRL;
		}
		public string Registeration(string value)
		{
			return "This is business layer= " + _registerHelloRL.GetHello(value);
		}
		public bool LoginUser(LoginDTO loginDTO)
		{
			string frontendUsername = loginDTO.Username;
			string frontendPassword = loginDTO.Password;
			LoginDTO database = _registerHelloRL.GetUsernamePassword(loginDTO);
			return CheckUsernamePassword(frontendUsername, frontendPassword, database);
			
			
		}
		public bool CheckUsernamePassword(string frontendusername,string frontendpassword,LoginDTO result)
		{
			if(frontendusername.Equals(result.Username)&& frontendpassword.Equals(result.Password))
			{
				return true;
			}
			return false;
		}
	}
}

