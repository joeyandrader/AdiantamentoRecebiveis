using AdiantamentoRecebiveis.Infrastructure.Enums;

namespace AdiantamentoRecebiveis.API.Requests
{
    /// <summary>
    /// Represents a standard API response.
    /// </summary>
    /// <returns></returns>
    public class APIDataResponse
    {
        public bool Success { get; set; }
        public EnResultCode Code { get; set; }
        public string? Message { get; set; }
        public int Results { get; set; }
    }

    /// <summary>
    /// Represents a standard API response that includes data of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of data included in the response.</typeparam>
    /// <returns></returns>
    public class APIDataResponse<T> : APIDataResponse
    {
        public T? Data { get; set; }
    }
}
