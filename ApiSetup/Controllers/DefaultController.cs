using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using TrackerService.Models.Api;

namespace TrackerService.Controllers;

[ApiController]
[ApiVersion("1.0")]
//[ApiVersion("1.2")]
[Route("api/v{version:apiVersion}/[controller]")]
public class DefaultController : ControllerBase
{
	private readonly ILogger<DefaultController> _logger;

	public DefaultController(ILogger<DefaultController> logger)
	{
		_logger = logger;
	}

#if !DEBUG_WITHOUT_AUTH
		[Authorize]
#endif
	[HttpPost]
	[Route("Method1")]
	[Consumes(MediaTypeNames.Application.Json)]
	[Produces(MediaTypeNames.Application.Json)]
	public ActionResult<Response> Method1([FromBody] string dataJson)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest($"invalid request data");
		}

		_logger.LogInformation($"Received request for data: {dataJson}");
		var response = new Response{IsSuccess = true, Message = "Api Works So Far!"};
		return Ok(response);
	}

	// For versioning, use the MapToApiVersion("1.2") attribute and use ApiVersion() attribute in the controller.
	// Can be used in multiple files for the same controller
	//[HttpPost]
	//[Route("Method1"), MapToApiVersion("1.2")]
	//[Consumes(MediaTypeNames.Application.Json)]
	//[Produces(MediaTypeNames.Application.Json)]
	//public RegisterLocationResponse Track12(RegisterLocationRequest? registerLocation)
	//{
	//    if (!ModelState.IsValid)
	//{
	// return BadRequest($"invalid request data");
	//}

	//_logger.LogInformation($"Received request for data: {dataJson}");
	//var response = new Response();
	// return Ok(response);
	//}



}