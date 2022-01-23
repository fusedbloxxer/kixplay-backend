using System.ComponentModel.DataAnnotations;

namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public class MovieResponseDto : MediaResponseDto, IMovieResponseDto
    {
        public int WonAwards { get; set; }

        public string MetreageType { get; set; }
    }
}
