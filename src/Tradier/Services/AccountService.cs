using System.ComponentModel.DataAnnotations;
using Tradier.Model;
using Tradier.Request;
using Tradier.Response;

namespace Tradier.Services
{
    public class AccountService : TradierService
    {
        public AccountService() : base()
        {
            if (this.client is TradierSandboxClient)
                throw new NotSupportedException("Account information can only be used in the production client.");
        }
        public AccountService(ITradierClient tradierClient) : base(tradierClient)
        {
            if (tradierClient is TradierSandboxClient)
                throw new NotSupportedException("Account information can only be used in the production client.");
        }

        public Task<AccountProfileResponse> GetUserProfile(CancellationToken token = default)
        {
            return client.GetResponse<AccountProfileResponse>("user/profile", token);
        }

        public Task<AccountBalancesResponse> GetBalances(string accountId, CancellationToken token = default)
        {
            return client.GetResponse<AccountBalancesResponse>($"accounts/{accountId}/balances", token);
        }

        public Task<AccountPositionsResponse> GetPositions(string accountId, CancellationToken token = default)
        {
            return client.GetResponse<AccountPositionsResponse>($"accounts/{accountId}/positions", token);
        }

        public Task<AccountHistoryResponse> GetHistory(string accountId, GetHistoryRequestOptions? query = null, CancellationToken token = default)
        {
            query ??= new GetHistoryRequestOptions();
            return client.GetResponse<AccountHistoryResponse>($"accounts/{accountId}/history?{query.ParseQueryString()}", token);
        }

        public Task<AccountGainLossResponse> GetGainLoss(string accountId, GainLossOptions? query = null, CancellationToken token = default)
        {
            query ??= new GainLossOptions();
            return client.GetResponse<AccountGainLossResponse>($"accounts/{accountId}/gainloss?{query.ParseQueryString()}", token);
        }

        public Task<AccountOrdersResponse> GetOrders(string accountId, bool includeTags = false, int? page = null, CancellationToken token = default)
        {
            return client.GetResponse<AccountOrdersResponse>($"accounts/{accountId}/orders?include_tags={includeTags.ToString().ToLowerInvariant()}{(page.HasValue ? $"&page={page.Value}" : "")}", token);
        }

        public Task<AccountOrderResponse> GetOrder(string accountId, string id, bool includeTags = false, CancellationToken token = default)
        {
            return client.GetResponse<AccountOrderResponse>($"accounts/{accountId}/orders/{id}?include_tags={includeTags.ToString().ToLowerInvariant()}", token);
        }
    }
}