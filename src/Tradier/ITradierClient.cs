
using Tradier.Response;

namespace Tradier
{
    public interface ITradierClient
    {
        public Task<TData> GetDataAsync<TData>(
              string endpoint) where TData : TradierResponse, new();

    }
}
