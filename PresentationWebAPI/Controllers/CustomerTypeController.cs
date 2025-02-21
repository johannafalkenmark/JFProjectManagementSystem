using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerTypeController(ICustomerTypeService customerTypeService) : ControllerBase
{
    private readonly ICustomerTypeService _customerTypeService = customerTypeService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var customertypes = await _customerTypeService.GetCustomerTypesAsync();
        return Ok(customertypes);
    }

}
