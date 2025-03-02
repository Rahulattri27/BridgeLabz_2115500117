using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using ModelLayer.DTO;

namespace HelloApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloAppController : ControllerBase
{
    IRegisterHelloBL _registerHelloBL;
    ResponseBody<LoginDTO> response;

    public HelloAppController(IRegisterHelloBL registerHelloBL)
    {
        _registerHelloBL = registerHelloBL;

    }
    [HttpGet]
    public string Get()
    {
        return _registerHelloBL.Registeration("Value from controller");
    }
    [HttpPost]
    public ResponseBody<LoginDTO> LoginUser(LoginDTO loginDTO)
    {
        bool result=_registerHelloBL.LoginUser(loginDTO);
        response = new ResponseBody<LoginDTO>();
        if (result)
        {
            response.Success = true;
            response.Message = "Registered Successfully";
            response.Data = loginDTO;
            return response;
        }
        response.Success = false;
        response.Message = "Not Registered Successfully";
        response.Data = new LoginDTO();
        return response;

    }
}

