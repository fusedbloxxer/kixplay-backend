using KixPlay_Backend.Services.Repositories.Interfaces;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class OperationResult<T> : IOperationResult<T>
    {
        private readonly T _result;

        private readonly IEnumerable<string> _errors;

        public OperationResult(T result) 
            : this(result, null) { }

        public OperationResult(IEnumerable<string> errors)
            : this(default, errors) { }

        public OperationResult(string errorMessage)
            : this(default, new List<string>() { errorMessage }) { }

        private OperationResult(T result, IEnumerable<string> errors)
        {
            _result = result;
            _errors = errors;
        }

        public IEnumerable<string> Errors => _errors;

        public T Result
        {
            get
            {
                var _this = (IOperationResult<T>)this;
                
                if (!_this.IsSuccessful)
                    throw new InvalidOperationException("Cannot retrieve the result because some errors occurred.");

                return _result;
            }
        }
    }
}
