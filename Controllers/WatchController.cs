using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.Models;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KixPlay_Backend.Controllers
{
    public class WatchController : BaseApiController
    {
        private readonly ILogger<WatchController> _logger;
        
        private readonly IUnitOfWork _unitOfWork;
        
        private readonly IMapper _mapper;

        public WatchController(
            ILogger<WatchController> logger,
            IUnitOfWork unitOfWork,
            IMapper mapper
        ) {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        /*
        /users/{userId}/watchlist/{watchStatus}/add/movie/{movieId}
        /users/{userId}/watchlist/{watchStatus}/update/movie/{movieId}
        /users/{userId}/watchlist/{watchStatus}/remove/movie/{movieId}

        /movies/{movieId}/watchstatus/{watchStatus}/
        /movies/{movieId}/watchstatus/
        */

        [AllowAnonymous]
        [HttpGet("/api/users/{userId}/watchlist")]
        public async Task<IActionResult> GetWatchList([FromRoute] Guid userId, [FromQuery(Name = "status")] List<string> watchStatusQuery)
        {
            try
            {
                var watchStatuses = watchStatusQuery.Select(status => Enum.Parse<TrackedMedia.WatchStatus>(status, true));

                var watchList = await _unitOfWork.WatchRepository.GetWatchListAsync<Movie, MovieModel>(userId, watchStatuses);

                return Ok(watchList);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError("Could not retrieve the watchlist with for user {Id} with options {Options}. Exception: {Error}", userId, watchStatusQuery, ex);
                return BadRequest(new ErrorResponse("Invalid requested watch status type."));
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve the watchlist with for user {Id} with options {Options}. Exception: {Error}", userId, watchStatusQuery, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }
    }
}
