namespace ElinesoftTask
{
    public partial class Form1 : Form
    {
        BinanceExchange binance;
        BitgetExchange bitget;
        BybitExchange bybit;
        KucoinExchange kucoin;

        public Form1()
        {
            InitializeComponent();
            pairSelectionBox.Items.AddRange(AllPairs.Pairs);

            binance = new BinanceExchange();
            bitget = new BitgetExchange();
            bybit = new BybitExchange();
            kucoin = new KucoinExchange();

            InitTimer();
        }

        void UpdatePrice(object s, EventArgs e)
        {
            binancePrice.Invoke(()=> binancePrice.Text = binance.Price.ToString());
            bitgetPrice.Invoke(() => bitgetPrice.Text = bitget.Price.ToString());
            bybitPrice.Invoke(() => bybitPrice.Text = bybit.Price.ToString());
            kucoinPrice.Invoke(() => kucoinPrice.Text = kucoin.Price.ToString());
        }

        private void InitTimer()
        {
            var timer1 = new System.Timers.Timer();
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(UpdatePrice);
            timer1.Interval = 100;
            timer1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            binance = new BinanceExchange();
            bitget = new BitgetExchange();
            bybit = new BybitExchange();
            kucoin = new KucoinExchange();

            var p = pairSelectionBox.SelectedItem.ToString();

            binance.Subscribe(p.Replace("-",""));
            bitget.Subscribe(p.Replace("-", ""));
            bybit.Subscribe(p.Replace("-", ""));
            kucoin.Subscribe(p);
        }
    }
}
