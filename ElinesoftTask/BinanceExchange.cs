using Binance.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElinesoftTask
{
    public class BinanceExchange : IExchange
    {
        public decimal Price { get; private set; }

        public void Subscribe(string pair)
        {
            var socketClient = new BinanceSocketClient();
            var tickerSubscriptionResult = socketClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(pair, (update) =>
            {
                Price = update.Data.LastPrice;
            });
            //var tickets = await socketClient.SpotApi.ExchangeData.GetExchangeInfoAsync();
            //var list = tickets.Data.Result.Symbols.Select(s => s.Name).ToList();
        }
    }
}
