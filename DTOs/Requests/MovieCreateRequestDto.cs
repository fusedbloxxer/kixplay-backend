using System.ComponentModel.DataAnnotations;
using static KixPlay_Backend.Data.Entities.Movie;

namespace KixPlay_Backend.DTOs.Requests
{
    public class MovieCreateRequestDto : MediaCreateRequestDto
    {
        public int WonAwards { get; set; }

        [Required]
        public string MetreageType { get; set; }
    }
}
