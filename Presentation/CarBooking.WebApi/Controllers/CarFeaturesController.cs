using CarBooking.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBooking.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBooking.Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetCarFeatureByCarIdList")]
        public async Task<IActionResult> GetCarFeatureByCarIdList(int id)
        {
            var values = await _mediator.Send(new GetCarFeatureByCarIdQuery(id));
            return Ok(values);
        }
        [HttpGet("UpdateCarFeatureAvailableChangeToFalse")]
        public async Task<IActionResult> UpdateCarFeatureAvailableChangeToFalse(int id)
        {
             _mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id));
            return Ok("Güncelleme başarılı.");
        }
        [HttpGet("UpdateCarFeatureAvailableChangeToTrue")]
        public async Task<IActionResult> UpdateCarFeatureAvailableChangeToTrue(int id)
        {
            _mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id));
            return Ok("Güncelleme başarılı.");
        }
        [HttpPost]
        public async Task<IActionResult> CreateCarFeatureByCar(CreateCarFeatureByCarCommand command)
        {
            _mediator.Send(command);
            return Ok("Ekleme başarılı.");
        }
    }
}
