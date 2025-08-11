
namespace Tradier
{
    public interface ITradierClient
    {
        public Task<TData> GetDataAsync<TData>(
              string endpoint);

    }
}
