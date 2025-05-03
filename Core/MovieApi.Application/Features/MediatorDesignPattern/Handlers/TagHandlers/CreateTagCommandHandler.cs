using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommant>
    {
        private readonly MoviContext _context;

        public CreateTagCommandHandler(MoviContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateTagCommant request, CancellationToken cancellationToken)
        {
           await _context.tags.AddAsync(new Tag
            {
                Title = request.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
