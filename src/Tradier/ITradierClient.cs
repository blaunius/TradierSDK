
using Tradier.Response;

namespace Tradier
{
    public interface ITradierClient
    {
        public Task<TData> Get<TData>(
              string endpoint, 
              CancellationToken token = default) where TData : TradierResponse, new();

        public Task<TData> Post<TData>(
              string endpoint, 
              Dictionary<string, string>? body = null, 
              CancellationToken token = default) where TData : TradierResponse, new();

        public Task<TData> Put<TData>(
              string endpoint,
              Dictionary<string, string>? body = null,
              CancellationToken token = default) where TData : TradierResponse, new();

        public Task<TData> Delete<TData>(
              string endpoint,
              CancellationToken token = default) where TData : TradierResponse, new();

    }
}