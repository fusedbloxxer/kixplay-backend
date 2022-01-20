using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace KixPlay_Backend.Controllers
{
    public class MoviesController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<MoviesController> _logger;

        public MoviesController(IUnitOfWork unitOfWork, ILogger<MoviesController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            try
            {
                var movies = await _unitOfWork.MovieRepository.GetMoviesWithGenresAsync();

                var response = JsonConvert.SerializeObject(movies, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore,
                });

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve all movies. Exception: {Message}", ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error occurred"));
            }
        }
    }
}
