
using Tradier.Response;

namespace Tradier
{
    public interface ITradierClient
    {
        public Task<TData> GetResponse<TData>(
              string endpoint, 
              CancellationToken token = default) where TData : TradierResponse, new();

    }
}
