namespace KixPlay_Backend.Settings.Application
{
    public class JwtSettings
    {
        public const string SECTION_NAME = "JwtSettings";

        public TimeSpan ClockSkew { get; init; } = TimeSpan.Zero;

        public bool ValidateIssuerSigningKey { get; init; } = true;

        public bool ValidateLifetime { get; init; } = false;

        public bool RequireExpirationTime { get; init; } = false;

        public bool ValidateAudience { get; init; } = false;

        public string ValidAudience { get; init; }

        public bool ValidateIssuer { get;  init; } = false;

        public string ValidIssuer { get; init; }
    }
}
