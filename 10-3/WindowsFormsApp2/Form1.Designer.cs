namespace CarPriceDisplay
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnShowPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPrice
            // 
            this.btnShowPrice.Location = new System.Drawing.Point(100, 100);
            this.btnShowPrice.Name = "btnShowPrice";
            this.btnShowPrice.Size = new System.Drawing.Size(150, 50);
            this.btnShowPrice.TabIndex = 0;
            this.btnShowPrice.Text = "顯示車輛價格";
            this.btnShowPrice.UseVisualStyleBackColor = true;
            this.btnShowPrice.Click += new System.EventHandler(this.btnShowPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnShowPrice);
            this.Name = "Form1";
            this.Text = "車輛價格顯示系統";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnShowPrice;
    }
}