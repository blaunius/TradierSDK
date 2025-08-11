
namespace Tradier
{
    public interface ITradierClient
    {
        public Task<TData> GetResponseAsync<TData>(
              string endpoint);

    }
}
