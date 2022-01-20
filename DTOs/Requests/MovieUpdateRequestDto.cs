using System.ComponentModel.DataAnnotations;
using static KixPlay_Backend.Data.Entities.Movie;

namespace KixPlay_Backend.DTOs.Requests
{
    public class MovieUpdateRequestDto : MediaUpdateRequestDto
    {
        public int WonAwards { get; set; }

        public string MetreageType { get; set; }
    }
}
