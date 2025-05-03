using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;
namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly MoviContext _context;
        public UpdateTagCommandHandler(MoviContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.tags.FindAsync(request.TagId);
            values.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
