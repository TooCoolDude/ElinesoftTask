using Binance.Net.Clients;
using Bybit.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElinesoftTask
{
    public class BybitExchange : IExchange
    {
        public decimal Price { get; private set; }

        public void Subscribe(string pair)
        {
            var socketClient = new BybitSocketClient();
            var tickerSubscriptionResult = socketClient.V5SpotApi.SubscribeToTickerUpdatesAsync(pair, (update) =>
            {
                Price = update.Data.LastPrice;
            });
        }
    }
}
