﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using System.Linq.Expressions;

namespace MovieApi.WebApi.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CastList()
        {
            var value = await _mediator.Send(new GetCastQuery());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCast(int id)
        {
           await _mediator.Send(new RemoveCategoryCommand(id));
            return Ok("Silme İşlemni Başarılı");
        }
        [HttpGet("GetCastById")]
        public async Task<IActionResult> GetCastById(int id)
        {
            var value =await _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
        {
           await _mediator.Send(command);
            return Ok("Güncelleme İşlemi Başarılı");
        }
    }
}
