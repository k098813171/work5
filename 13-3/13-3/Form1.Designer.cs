namespace TrafficLightSimulator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTrafficLight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTrafficLight
            // 
            this.lblTrafficLight.AutoSize = true;
            this.lblTrafficLight.BackColor = System.Drawing.Color.Red;
            this.lblTrafficLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrafficLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrafficLight.Location = new System.Drawing.Point(108, 111);
            this.lblTrafficLight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrafficLight.Name = "lblTrafficLight";
            this.lblTrafficLight.Size = new System.Drawing.Size(85, 39);
            this.lblTrafficLight.TabIndex = 0;
            this.lblTrafficLight.Text = "紅燈";
            this.lblTrafficLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrafficLight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTrafficLight_MouseDown);
            this.lblTrafficLight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTrafficLight_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lblTrafficLight);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "紅綠燈模擬器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrafficLight;
    }
}