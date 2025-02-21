using Business.Interfaces;
using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerReferenceControllerI(ICustomerReferenceService customerReferenceService) : ControllerBase
{
    private readonly ICustomerReferenceService _customerReferenceService = customerReferenceService;

[HttpGet]

public async Task<IActionResult> GetAll()
{
    var customerreferences = await _customerReferenceService.GetCustomerReferencesAsync();
    return Ok(customerreferences);
}
}
