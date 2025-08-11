using System.ComponentModel.DataAnnotations;
using Tradier.Model;
using Tradier.Request;

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

        public Task<Profile> GetUserProfile()
        {
            return client.GetDataAsync<Profile>("user/profile");
        }
         
        public Task<Balance> GetBalances([Required] string accountId)
        {
            throw new NotImplementedException(nameof(GetBalances));
        }

        public Task<List<Position>> GetPositions([Required] string accountId)
        {
            throw new NotImplementedException(nameof(GetPositions));
        }

        public Task<List<Event>> GetHistory([Required] string accountId, GetHistoryRequestOptions? query = null)
        {
            throw new NotImplementedException(nameof(GetHistory));
        }

        public Task<List<ClosedPosition>> GetGainLoss([Required] string accountId, GainLossOptions? query = null)
        {
            throw new NotImplementedException(nameof(GetGainLoss));
        }

        public Task<List<Order>> GetOrders([Required] string accountId, bool includeTags = false, int? page = null)
        {
            throw new NotImplementedException(nameof(GetOrders));
        }

        public Task<Order> GetOrder([Required] string accountId, [Required] string id, bool includeTags = false)
        {
            throw new NotImplementedException(nameof(GetOrder));
        }
    }
}