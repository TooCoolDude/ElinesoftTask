namespace ElinesoftTask
{
    public partial class Form1 : Form
    {
        BinanceExchange binance;
        BitgetExchange bitget;
        BybitExchange bybit;
        KucoinExchange kucoin;

        object lockObj = new object();

        public Form1()
        {
            InitializeComponent();
            pairSelectionBox.Items.AddRange(new object[] { "BTCUSDT", "ETHUSDT" });
            binance = new BinanceExchange();
            bitget = new BitgetExchange();
            bybit = new BybitExchange();
            kucoin = new KucoinExchange();
        }

        void UpdatePrice()
        {
            binancePrice.Invoke(()=> binancePrice.Text = binance.Price.ToString());
            bitgetPrice.Invoke(() => bitgetPrice.Text = bitget.Price.ToString());
            bybitPrice.Invoke(() => bybitPrice.Text = bybit.Price.ToString());
            kucoinPrice.Invoke(() => kucoinPrice.Text = kucoin.Price.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var p = pairSelectionBox.SelectedItem.ToString();
            binance.Subscribe(p);
            //bitget.Subscribe(p);
            //bybit.Subscribe(p);
            //kucoin.Subscribe(p);

            var timer = new System.Threading.Timer(new TimerCallback((obj) => UpdatePrice()), 0, 0, 5000);
            
        }
    }
}
