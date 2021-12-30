namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IOperationResult<T>
    {
        public T Result { get; }

        public bool IsSuccessful => !HasErrors();

        public IEnumerable<string> Errors { get; }

        public bool HasErrors() => Errors != null && Errors.Any();
    }
}
