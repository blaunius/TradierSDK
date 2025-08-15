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

        public Task<UserProfileResponse> GetUserProfile()
        {
            return client.GetResponse<UserProfileResponse>("user/profile");
        }

        public Task<BalanceResponse> GetBalances(string accountId)
        {
            return client.GetResponse<BalanceResponse>($"accounts/{accountId}/balances");
        }

        public Task<PositionsResponse> GetPositions(string accountId)
        {
            return client.GetResponse<PositionsResponse>($"accounts/{accountId}/positions");
        }

        public Task<AccountHistoryResponse> GetHistory(string accountId, GetHistoryRequestOptions? query = null)
        {
            query ??= new GetHistoryRequestOptions();
            return client.GetResponse<AccountHistoryResponse>($"accounts/{accountId}/history?{query.ParseQueryString()}");
        }

        public Task<AccountGainLossResponse> GetGainLoss(string accountId, GainLossOptions? query = null)
        {
            query ??= new GainLossOptions();
            return client.GetResponse<AccountGainLossResponse>($"accounts/{accountId}/gainloss?{query.ParseQueryString()}");
        }

        public Task<OrdersResponse> GetOrders(string accountId, bool includeTags = false, int? page = null)
        {
            return client.GetResponse<OrdersResponse>($"accounts/{accountId}/orders?include_tags={includeTags.ToString().ToLowerInvariant()}{(page.HasValue ? $"&page={page.Value}" : "")}");
        }

        public Task<OrderResponse> GetOrder(string accountId, string id, bool includeTags = false)
        {
            return client.GetResponse<OrderResponse>($"accounts/{accountId}/orders/{id}?include_tags={includeTags.ToString().ToLowerInvariant()}");
            throw new NotImplementedException(nameof(GetOrder));
        }
    }
}