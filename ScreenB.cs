using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenAppMonitor
{
    public partial class ScreenB : Form
    {
        private Timer timer;
        //private Label scrollingLabel;
        public ScreenB()
        {
            InitializeComponent();
        }
        public void UpdateData(string newData)
        {
            //label1.Text = newData;
            richTextBox1.Text = newData;
            richTextBox1.ReadOnly = true;
            richTextBox1.WordWrap = true;
            richTextBox1.BackColor = Color.Navy;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Cursor = Cursors.No;
          
            // Increase text size
            // richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size + 2);

            // Adjust text justification (alignment)
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Center; // Replace 'Center' with your desired justification (Left, Right, or Center)
           
        }

        public void UpdateScrollData(string newData)
        {
            
            label1.AutoSize = true;
            label1.Text += newData +"   *******    ";
            label1.BackColor = Color.Transparent;
            Controls.Add(label1);

            timer = new Timer();
            timer.Interval = 50; // Adjust the interval to control the scrolling speed
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void ScreenB_Load(object sender, EventArgs e)
        {
           
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Left -= 1; // Adjust the value to control the scrolling speed

            if (label1.Right < 0)
            {
                label1.Left = Width; // Reset the label's position to start scrolling from the right edge
            }
        }
    }
}
