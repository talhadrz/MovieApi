using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MoviContext _context;

        public UpdateMovieCommandHandler(MoviContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            value.Rating = command.Rating;
            value.Status = command.Status;
            value.Title = command.Title;
            value.Duration = command.Duration;
            value.CoverImageUrl = command.CoverImageUrl;
            value.CreatedYear = command.CreatedYear;
            value.Description = command.Description; 
            value.ReleaseDate = command.ReleaseDate;
            await _context.SaveChangesAsync(); 
        }
    }
}
