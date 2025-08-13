
using Tradier.Response;

namespace Tradier
{
    public interface ITradierClient
    {
        public Task<TData> GetResponse<TData>(
              string endpoint) where TData : TradierResponse, new();

    }
}
