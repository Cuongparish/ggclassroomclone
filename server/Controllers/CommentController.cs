using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Dtos.Comment;
using server.Interfaces;
using server.Mappers;
using server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepo;
        private readonly IStockRepository _stockRepo;
        public CommentController(ICommentRepository commentRepo,
        IStockRepository stockRepo)
        {
            _commentRepo = commentRepo;
            _stockRepo = stockRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _commentRepo.GetAllAsync();

            var commentDto = comments.Select(s => s.ToCommentDto());

            return Ok(commentDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {


            var comment = await _commentRepo.GetByIdAsync(id);

            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment.ToCommentDto());
        }


        // [HttpPost]
        // [Route("{symbol:alpha}")]
        // public async Task<IActionResult> Create([FromRoute] string symbol, CreateCommentDto commentDto)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState);

        //     var stock = await _stockRepo.GetBySymbolAsync(symbol);

        //     if (stock == null)
        //     {
        //         stock = await _fmpService.FindStockBySymbolAsync(symbol);
        //         if (stock == null)
        //         {
        //             return BadRequest("Stock does not exists");
        //         }
        //         else
        //         {
        //             await _stockRepo.CreateAsync(stock);
        //         }
        //     }

        //     var username = User.GetUsername();
        //     var appUser = await _userManager.FindByNameAsync(username);

        //     var commentModel = commentDto.ToCommentFromCreate(stock.Id);
        //     commentModel.AppUserId = appUser.Id;
        //     await _commentRepo.CreateAsync(commentModel);
        //     return CreatedAtAction(nameof(GetById), new { id = commentModel.Id }, commentModel.ToCommentDto());
        // }

        // [HttpPut]
        // [Route("{id:int}")]
        // public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCommentRequestDto updateDto)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState);

        //     var comment = await _commentRepo.UpdateAsync(id, updateDto.ToCommentFromUpdate(id));

        //     if (comment == null)
        //     {
        //         return NotFound("Comment not found");
        //     }

        //     return Ok(comment.ToCommentDto());
        // }

        // [HttpDelete]
        // [Route("{id:int}")]
        // public async Task<IActionResult> Delete([FromRoute] int id)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState);

        //     var commentModel = await _commentRepo.DeleteAsync(id);

        //     if (commentModel == null)
        //     {
        //         return NotFound("Comment does not exist");
        //     }

        //     return Ok(commentModel);
        // }
    }
}