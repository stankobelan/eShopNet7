using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.Web.Controllers;

[Route("[controller]")]
[ApiController]
public class ConfirmEmailController : ControllerBase
{
    private readonly ITokenClaimsService _tokenClaimsService;

    public ConfirmEmailController(ITokenClaimsService tokenClaimsService)
    {
        _tokenClaimsService = tokenClaimsService;
    }


    public IActionResult Get(string userid, string code)
    {
        //todo:ConfirmEmailController get
        throw new NotImplementedException();
    }
}
