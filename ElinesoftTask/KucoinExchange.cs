using Bybit.Net.Clients;
using Kucoin.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElinesoftTask
{
    public class KucoinExchange : IExchange
    {
        public decimal Price { get; private set; }

        public void Subscribe(string pair)
        {
            var socketClient = new KucoinSocketClient();
            var tickerSubscriptionResult = socketClient.SpotApi.SubscribeToTickerUpdatesAsync(pair, (update) =>
            {
                Price = update.Data.LastPrice;
            });
        }
    }
}
