using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses.Abstractions;
using KixPlay_Backend.DTOs.Responses.Implementations;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace KixPlay_Backend.Controllers
{
    public class MoviesController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<MoviesController> _logger;

        public MoviesController(
            ILogger<MoviesController> logger,
            IUnitOfWork unitOfWork,
            IMapper mapper
        ){
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<MovieResponseDto>))]
        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<IActionResult> GetAllMovies()
        {
            try
            {
                var movies = await _unitOfWork.MovieRepository.GetAllAsync();

                var moviesDto = _mapper.ProjectTo<MovieResponseDto>(movies.AsQueryable());

                return Ok(moviesDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve all movies. Exception: {Message}", ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error occurred"));
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<MovieDetailsResponseDto>))]
        [AllowAnonymous]
        [HttpGet("all/details")]
        public async Task<IActionResult> GetAllMoviesWithDetails()
        {
            try
            {
                var moviesDetails = await _unitOfWork.MovieRepository.GetAllDetailsAsync();

                var moviesDetailsDto = _mapper.ProjectTo<MovieDetailsResponseDto>(moviesDetails.AsQueryable());

                return Ok(moviesDetailsDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve all movies. Exception: {Message}", ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error occurred"));
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MovieResponseDto))]
        [AllowAnonymous]
        [HttpGet("find/{movieId}")]
        public async Task<IActionResult> GetMovieById([FromRoute] Guid movieId)
        {
            try
            {
                var movie = await _unitOfWork.MovieRepository.GetByIdAsync(movieId);

                if (movie == null)
                {
                    return NotFound(new ErrorResponse($"Could not find movie {movieId}."));
                }

                var movieDto = _mapper.Map<MovieResponseDto>(movie);

                return Ok(movieDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve movie with id {MovieId}. Exception: {Message}", movieId, ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error occurred"));
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MovieDetailsResponseDto))]
        [Authorize(Roles = "Contributor")]
        [HttpGet("find/{movieId}/details")]
        public async Task<IActionResult> GetMovieByIdWithDetails([FromRoute] Guid movieId)
        {
            try
            {
                var movieExists = await _unitOfWork.MovieRepository.ExistsAsync(movieId);

                if (!movieExists)
                {
                    return NotFound(new ErrorResponse($"Could not find movie {movieId}."));
                }

                var movieDetails = await _unitOfWork.MovieRepository.GetByIdWithDetailsAsync(movieId);

                if (movieDetails == null)
                {
                    return NotFound(new ErrorResponse($"Could not find movie {movieId}."));
                }

                var movieDetailsDto = _mapper.Map<MovieDetailsResponseDto>(movieDetails);

                return Ok(movieDetailsDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve movie with id {MovieId}. Exception: {Message}", movieId, ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error occurred"));
            }
        }

        [Authorize(Roles = "Admin,Contributor")]
        [HttpPost("create")]
        public async Task<IActionResult> CreateMovie([FromBody] MovieCreateRequestDto movieDto)
        {
            try
            {
                var movie = _mapper.Map<Movie>(movieDto);

                bool movieCreateRequest = await _unitOfWork.MovieRepository.CreateAsync(movie);

                if (!movieCreateRequest)
                {
                    return BadRequest(new ErrorResponse($"Invalid movie create request."));
                }

                await _unitOfWork.CompleteAsync();

                return NoContent();
            }
            catch (AutoMapperMappingException ex)
            {
                _logger.LogError("Could not create movie from {Request}. Exception: {Message}", movieDto, ex.Message);
                return BadRequest(new ErrorResponse("Invalid movie create values."));
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not create movie from {Request}. Exception: {Message}", movieDto, ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error occurred"));
            }
        }

        [Authorize(Roles = "Admin,Contributor")]
        [HttpPut("update/{movieId}")]
        public async Task<IActionResult> UpdateMovie([FromRoute] Guid movieId, [FromBody] MovieUpdateRequestDto movieDto)
        {
            try
            {
                var movie = _mapper.Map<Movie>(movieDto);

                var movieExists = await _unitOfWork.MovieRepository.ExistsAsync(movieId);

                if (!movieExists)
                {
                    return BadRequest(new ErrorResponse($"Movie {movieId} does not exist."));
                }

                movie.Id = movieId;

                bool movieUpdateResult = await _unitOfWork.MovieRepository.UpdateAsync(movie);

                if (!movieUpdateResult)
                {
                    return BadRequest(new ErrorResponse($"Invalid movie update request."));
                }

                await _unitOfWork.CompleteAsync();

                return NoContent();
            }
            catch (AutoMapperMappingException ex)
            {
                _logger.LogError("Could not update movie from {Request}. Exception: {Message}", movieDto, ex.Message);
                return BadRequest(new ErrorResponse("Invalid movie update values."));
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not update movie from {Request}. Exception: {Message}", movieDto, ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error occurred"));
            }
        }

        [Authorize(Roles = "Admin,Contributor")]
        [HttpDelete("delete/{movieId}")]
        public async Task<IActionResult> DeleteMovie([FromRoute] Guid movieId)
        {
            try
            {
                bool movieDeleteResult = await _unitOfWork.MovieRepository.DeleteAsync(movieId);

                if (!movieDeleteResult)
                {
                    return BadRequest(new ErrorResponse($"Invalid movie delete request."));
                }

                await _unitOfWork.CompleteAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not delete movie {MovieId}. Exception: {Message}", movieId, ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error occurred"));
            }
        }
    }
}
