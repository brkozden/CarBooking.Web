using CarBooking.Application.Features.Mediator.Queries.AppUserQueries;
using CarBooking.Application.Tools;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class SignInController : ControllerBase
	{
		private readonly IMediator _mediator;

		public SignInController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpPost]
		public async Task<IActionResult> Login(CheckAppUserQuery query)
		{
			var values = await _mediator.Send(query);
			if (values.IsExist) 
			{
				return Created("", JwttokenGenerator.GenerateToken(values));
			}
			else
			{
				return BadRequest("Kullanıcı adı veya şifre hatalıdır.");
			}
				}
	}
}
