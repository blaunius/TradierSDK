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

        public Task<List<ClosedPosition>> GetGainLoss(string accountId, GainLossOptions? query = null)
        {
            throw new NotImplementedException(nameof(GetGainLoss));
        }

        public Task<List<Order>> GetOrders(string accountId, bool includeTags = false, int? page = null)
        {
            throw new NotImplementedException(nameof(GetOrders));
        }

        public Task<Order> GetOrder(string accountId, string id, bool includeTags = false)
        {
            throw new NotImplementedException(nameof(GetOrder));
        }
    }
}