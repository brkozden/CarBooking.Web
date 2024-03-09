using CarBooking.Application.Features.Mediator.Commands.CommentCommands;
using CarBooking.Application.Features.Mediator.Queries.CommentQueries;
using CarBooking.Application.Interfaces.CommentInterfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICommentRepository _commentRepository;
        public CommentsController(IMediator mediator, ICommentRepository commentRepository)
        {
            _mediator = mediator;
            _commentRepository = commentRepository;
        }
        [HttpGet]
        public async Task<IActionResult> CommentList()
        {
            var values = await _mediator.Send(new GetCommentQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            var value = await _mediator.Send(new GetCommentByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("GetCommentByBlogId")]
        public async Task<IActionResult> GetCommentByBlogId(int id)
        {
            var value = await _mediator.Send(new GetCommentByBlogIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum Başarıyla Eklendi.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveComment(int id)
        {
            await _mediator.Send(new RemoveCommentCommand(id));
            return Ok("Yorum Başarıyla Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum Başarıyla Güncellendi.");
        }
        [HttpGet("GetCountCommentByBlog")]
        public  IActionResult GetCountCommentByBlog(int id)
        {
            var value =  _commentRepository.GetCountCommentByBlog(id);
            return Ok(value);
        }
    }
}
