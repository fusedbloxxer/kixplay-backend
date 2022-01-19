namespace KixPlay_Backend.Data.Entities
{
    public partial class Movie : Media
    {
        public int WonAwards { get; set; }

        public Metreage MetreageType { get; set; }
    }

    public partial class Movie : Media
    {
        public enum Metreage
        {
            Short,
            Long,
        }
    }
}
