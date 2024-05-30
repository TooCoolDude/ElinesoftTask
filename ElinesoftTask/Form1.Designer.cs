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
            label1.Location = new Point(238, 92);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Пара:";
            // 
            // pairSelectionBox
            // 
            pairSelectionBox.FormattingEnabled = true;
            pairSelectionBox.Location = new Point(321, 92);
            pairSelectionBox.Name = "pairSelectionBox";
            pairSelectionBox.Size = new Size(182, 33);
            pairSelectionBox.TabIndex = 1;
            pairSelectionBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 144);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 2;
            label2.Text = "Binance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 196);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 3;
            label3.Text = "Bybit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 244);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 4;
            label4.Text = "Kucoin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 298);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 5;
            label5.Text = "Bitget:";
            // 
            // binancePrice
            // 
            binancePrice.AutoSize = true;
            binancePrice.Location = new Point(321, 144);
            binancePrice.Name = "binancePrice";
            binancePrice.Size = new Size(22, 25);
            binancePrice.TabIndex = 6;
            binancePrice.Text = "1";
            // 
            // bybitPrice
            // 
            bybitPrice.AutoSize = true;
            bybitPrice.Location = new Point(321, 196);
            bybitPrice.Name = "bybitPrice";
            bybitPrice.Size = new Size(22, 25);
            bybitPrice.TabIndex = 7;
            bybitPrice.Text = "1";
            // 
            // kucoinPrice
            // 
            kucoinPrice.AutoSize = true;
            kucoinPrice.Location = new Point(321, 244);
            kucoinPrice.Name = "kucoinPrice";
            kucoinPrice.Size = new Size(22, 25);
            kucoinPrice.TabIndex = 8;
            kucoinPrice.Text = "1";
            // 
            // bitgetPrice
            // 
            bitgetPrice.AutoSize = true;
            bitgetPrice.Location = new Point(321, 298);
            bitgetPrice.Name = "bitgetPrice";
            bitgetPrice.Size = new Size(22, 25);
            bitgetPrice.TabIndex = 9;
            bitgetPrice.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 435);
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
