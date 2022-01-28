﻿namespace KixPlay_Backend.DTOs.Responses.Implementations
{
    public class UserGetResponseDto : BaseResponse
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
