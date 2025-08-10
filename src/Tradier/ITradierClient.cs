
namespace Tradier
{
    public interface ITradierClient
    {
        public HttpRequestMessage BuildRequest(
            HttpMethod method,
            string endpoint);

    }
}
