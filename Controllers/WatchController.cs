using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Responses.Implementations;
using KixPlay_Backend.Models.Implementations;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static KixPlay_Backend.Data.Entities.TrackedMedia;

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

        [Authorize(Roles = "Member", Policy = "IsSameUser")]
        [HttpDelete("/api/users/{userId}/watchlist/remove/{mediaId}")]
        public async Task<IActionResult> UpdateWatchListEntry([FromRoute] Guid userId, [FromRoute] Guid mediaId)
        {
            try
            {
                var trackedMedia = await _unitOfWork.WatchRepository.FindAsync(userId, mediaId);

                if (trackedMedia == null)
                {
                    return BadRequest(new ErrorResponse($"Could not find watchlist entry from {userId} userId and {mediaId} mediaId."));
                }

                var updateResult = await _unitOfWork.WatchRepository.DeleteAsync(trackedMedia.Id);

                await _unitOfWork.CompleteAsync();

                if (!updateResult)
                {
                    return BadRequest(new ErrorResponse($"Could not delete watchlist entry from {userId} userId and {mediaId} mediaId."));
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not delete watchlist entry with media {MediaId} from user {UserId}. Exception occurred: {Ex}", mediaId, userId, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [Authorize(Roles = "Member", Policy = "IsSameUser")]
        [HttpPut("/api/users/{userId}/watchlist/update/{mediaId}/set/{status}")]
        public async Task<IActionResult> UpdateWatchListEntry([FromRoute] Guid userId, [FromRoute] Guid mediaId, [FromRoute] string status)
        {
            try
            {
                var watchStatus = Enum.Parse<WatchStatus>(status);

                var trackedMedia = await _unitOfWork.WatchRepository.FindAsync(userId, mediaId);

                if (trackedMedia == null)
                {
                    return BadRequest(new ErrorResponse($"Could not find watchlist entry from {userId} userId and {mediaId} mediaId."));
                }

                trackedMedia.Status = watchStatus;

                var updateResult = await _unitOfWork.WatchRepository.UpdateAsync(trackedMedia);

                await _unitOfWork.CompleteAsync();

                if (!updateResult)
                {
                    return BadRequest(new ErrorResponse($"Could not update watchlist entry from {userId} userId and {mediaId} mediaId."));
                }

                var watchEntryDto = _mapper.Map<MediaWatchStatusResponseDto>(trackedMedia);

                return Ok(watchEntryDto);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError("Could not update media {MediaId} for user {UserId} with status {Status}. Exception occurred: {Ex}", mediaId, userId, status, ex);
                return BadRequest(new ErrorResponse("Invalid requested watch status type."));
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not update media {MediaId} for user {UserId} with status {Status}. Exception occurred: {Ex}", mediaId, userId, status, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [Authorize(Roles = "Member", Policy = "IsSameUser")]
        [HttpPost("/api/users/{userId}/watchlist/add/{mediaId}/set/{status}")]
        public async Task<IActionResult> AddToWatchList([FromRoute] Guid userId, [FromRoute] Guid mediaId, [FromRoute] string status)
        {
            try
            {
                var watchStatus = Enum.Parse<WatchStatus>(status);

                var addResult = await _unitOfWork.WatchRepository.CreateAsync(new TrackedMedia
                {
                    UserId = userId,
                    MediaId = mediaId,
                    Status = watchStatus,
                });

                await _unitOfWork.CompleteAsync();

                if (!addResult)
                {
                    return BadRequest(new ErrorResponse("Invalid UserId or MediaId."));
                }

                var watchList = await _unitOfWork.WatchRepository.GetWatchListAsync<Media, MediaWatchStatusModel>(userId, Enum.GetValues<WatchStatus>());

                var watchListDto = _mapper.ProjectTo<MediaWatchStatusResponseDto>(watchList.AsQueryable());

                return Ok(watchListDto);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                _logger.LogError("Could not add media {MediaId} to user {UserId} with status {Status}. Exception occurred: {Ex}", mediaId, userId, status, ex);
                return BadRequest(new ErrorResponse("Watchlist entry already exists."));
            }
            catch (ArgumentException ex)
            {
                _logger.LogError("Could not add media {MediaId} to user {UserId} with status {Status}. Exception occurred: {Ex}", mediaId, userId, status, ex);
                return BadRequest(new ErrorResponse("Invalid requested watch status type."));
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not add media {MediaId} to user {UserId} with status {Status}. Exception occurred: {Ex}", mediaId, userId, status, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [AllowAnonymous]
        [HttpGet("/api/users/{userId}/watchlist")]
        public async Task<IActionResult> GetWatchList([FromRoute] Guid userId, [FromQuery(Name = "status")] List<string> watchStatusQuery)
        {
            try
            {
                var watchStatuses = watchStatusQuery.Select(status => Enum.Parse<WatchStatus>(status, true));

                var watchList = await _unitOfWork.WatchRepository.GetWatchListAsync<Media, MediaWatchStatusModel>(userId, watchStatuses);

                var watchListDto = _mapper.ProjectTo<MediaWatchStatusResponseDto>(watchList.AsQueryable());

                return Ok(watchListDto);
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

        [AllowAnonymous]
        [HttpGet("/api/watchlist/types")]
        public async Task<IActionResult> GetWatchStatusTypes()
        {
            try
            {
                var types = Enum.GetValues<WatchStatus>().Select(x => x.ToString());

                return Ok(await Task.FromResult(types));
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve watchlist status types.", ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }
    }
}
