using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerAddressController(ICustomerAddressService customerAddressService) : ControllerBase
{
    private readonly ICustomerAddressService _customerAddressService = customerAddressService;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var customeraddresses = await _customerAddressService.GetCustomerAddressAsync();
        return Ok(customeraddresses);
    }
}
