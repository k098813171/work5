using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLightSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetRedLight(); // 預設為紅燈
        }

        private void SetRedLight()
        {
            lblTrafficLight.BackColor = Color.Red;
            lblTrafficLight.Text = "紅燈";
        }

        private void SetYellowLight()
        {
            lblTrafficLight.BackColor = Color.Yellow;
            lblTrafficLight.Text = "黃燈";
        }

        private void SetGreenLight()
        {
            lblTrafficLight.BackColor = Color.Green;
            lblTrafficLight.Text = "綠燈";
        }

        private void lblTrafficLight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetYellowLight();
            }
            else if (e.Button == MouseButtons.Right)
            {
                SetGreenLight();
            }
        }

        private void lblTrafficLight_MouseUp(object sender, MouseEventArgs e)
        {
            SetRedLight(); // 放開滑鼠按鍵時恢復紅燈
        }
    }
}