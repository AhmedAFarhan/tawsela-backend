using BuildingBlocks.Responses.Abstractions;

namespace BuildingBlocks.Responses
{
    public class TAResponse<T> : TAResponseBase
    {
        public T? Data { get; set; }
    }
}
