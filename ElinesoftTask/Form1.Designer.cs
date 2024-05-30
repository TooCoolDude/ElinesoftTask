namespace ElinesoftTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pairSelectionBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            binancePrice = new Label();
            bybitPrice = new Label();
            kucoinPrice = new Label();
            bitgetPrice = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 0;
            label1.Text = "Пара:";
            // 
            // pairSelectionBox
            // 
            pairSelectionBox.AutoCompleteCustomSource.AddRange(new string[] { "ADA-USDT", "ATOM-USDT", "AVAX-USDT", "BCH-USDT", "BNB-USDT", "BTC-USDT", "BTC-BUSD", "BTC-EUR", "BTC-GBP", "BTC-TRY", "CAKE-USDT", "CHZ-USDT", "DOT-USDT", "EOS-USDT", "ETH-USDT", "ETH-BUSD", "ETH-EUR", "ETH-GBP", "ETH-TRY", "FIL-USDT", "FTT-USDT", "GMT-USDT", "LINK-USDT", "LTC-USDT", "MATIC-USDT", "NEAR-USDT", "RUNE-USDT", "SAND-USDT", "SHIB-USDT", "SOL-USDT", "TRX-USDT", "UNI-USDT", "XLM-USDT", "XRP-USDT" });
            pairSelectionBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            pairSelectionBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            pairSelectionBox.FormattingEnabled = true;
            pairSelectionBox.Location = new Point(417, 118);
            pairSelectionBox.Margin = new Padding(4);
            pairSelectionBox.Name = "pairSelectionBox";
            pairSelectionBox.Size = new Size(235, 40);
            pairSelectionBox.TabIndex = 1;
            pairSelectionBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 184);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 2;
            label2.Text = "Binance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 251);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 3;
            label3.Text = "Bybit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 312);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 4;
            label4.Text = "Kucoin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 381);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 5;
            label5.Text = "Bitget:";
            // 
            // binancePrice
            // 
            binancePrice.AutoSize = true;
            binancePrice.Location = new Point(417, 184);
            binancePrice.Margin = new Padding(4, 0, 4, 0);
            binancePrice.Name = "binancePrice";
            binancePrice.Size = new Size(27, 32);
            binancePrice.TabIndex = 6;
            binancePrice.Text = "1";
            // 
            // bybitPrice
            // 
            bybitPrice.AutoSize = true;
            bybitPrice.Location = new Point(417, 251);
            bybitPrice.Margin = new Padding(4, 0, 4, 0);
            bybitPrice.Name = "bybitPrice";
            bybitPrice.Size = new Size(27, 32);
            bybitPrice.TabIndex = 7;
            bybitPrice.Text = "1";
            // 
            // kucoinPrice
            // 
            kucoinPrice.AutoSize = true;
            kucoinPrice.Location = new Point(417, 312);
            kucoinPrice.Margin = new Padding(4, 0, 4, 0);
            kucoinPrice.Name = "kucoinPrice";
            kucoinPrice.Size = new Size(27, 32);
            kucoinPrice.TabIndex = 8;
            kucoinPrice.Text = "1";
            // 
            // bitgetPrice
            // 
            bitgetPrice.AutoSize = true;
            bitgetPrice.Location = new Point(417, 381);
            bitgetPrice.Margin = new Padding(4, 0, 4, 0);
            bitgetPrice.Name = "bitgetPrice";
            bitgetPrice.Size = new Size(27, 32);
            bitgetPrice.TabIndex = 9;
            bitgetPrice.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 557);
            Controls.Add(bitgetPrice);
            Controls.Add(kucoinPrice);
            Controls.Add(bybitPrice);
            Controls.Add(binancePrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pairSelectionBox);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox pairSelectionBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label binancePrice;
        private Label bybitPrice;
        private Label kucoinPrice;
        private Label bitgetPrice;
    }
}
