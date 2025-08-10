using System.ComponentModel.DataAnnotations;
using Tradier.Model;
using Tradier.Request;

namespace Tradier.Services
{
    public class AccountService : TradierService
    {
        public AccountService(ITradierClient client) : base(client) { }

        public Profile GetUserProfile()
        {
            var rq = client.BuildRequest(HttpMethod.Get, "user/profile");
            throw new NotImplementedException(nameof(GetUserProfile));
        }
         
        public Balance GetBalances([Required] string accountId)
        {
            throw new NotImplementedException(nameof(GetBalances));
        }

        public List<Position> GetPositions([Required] string accountId)
        {
            throw new NotImplementedException(nameof(GetPositions));
        }

        public List<Event> GetHistory([Required] string accountId, QueryHistoryRequestParameters? query = null)
        {
            throw new NotImplementedException(nameof(GetHistory));
        }

        public List<ClosedPosition> GetGainLoss([Required] string accountId, QueryGainLossParameters? query = null)
        {
            throw new NotImplementedException(nameof(GetGainLoss));
        }

        public List<Order> GetOrders([Required] string accountId, bool includeTags = false, int? page = null)
        {
            throw new NotImplementedException(nameof(GetOrders));
        }

        public Order GetOrder([Required] string accountId, [Required] string id, bool includeTags = false)
        {
            throw new NotImplementedException(nameof(GetOrder));
        }
    }
}