using Binance.Net.Clients;
using Bitget.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElinesoftTask
{
    public class BitgetExchange : IExchange
    {
        public decimal Price { get; private set; }

        public void Subscribe(string pair)
        {
            var socketClient = new BitgetSocketClient();
            var tickerSubscriptionResult = socketClient.SpotApi.SubscribeToTickerUpdatesAsync(pair, (update) =>
            {
                Price = update.Data.LastPrice;
            });

        }
    }
}
