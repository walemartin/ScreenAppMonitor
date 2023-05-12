using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenAppMonitor
{
    public partial class ScreenA : Form
    {
        private ScreenB secondaryForm;
        private bool isSecondaryFormOpen = true;
        private Timer timer;
        private Label timeLabel;
        // Create a DateTime variable to store the start time of the timer
        private DateTime startTime;


        public ScreenA()
        {
            InitializeComponent();
            timer = new Timer
            {
                Interval = 1000
            };

            timeLabel = new Label();
            timeLabel.AutoSize = true;
            timeLabel.Text = "00:00:00";
            panel1.Controls.Add(timeLabel);
            // Set the start time of the timer to the current time
            startTime = DateTime.Now;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Calculate the elapsed time since the timer was started
            TimeSpan elapsedTime = DateTime.Now - startTime;
            timeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}",
                elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.secondaryForm == null || this.secondaryForm.IsDisposed)
            {
                // Get the secondary screen
                Screen secondaryScreen = Screen.AllScreens.FirstOrDefault(s => !s.Primary);

                // Create the form to be displayed on the secondary screen
                secondaryForm = new ScreenB();
                secondaryForm.Text = "Secondary Screen Form";

                // Set the form's location and size to match the secondary screen
                secondaryForm.StartPosition = FormStartPosition.Manual;
                //secondaryForm.Location = secondaryScreen.WorkingArea.Location;
                //secondaryForm.Size = secondaryScreen.WorkingArea.Size;
                // Create a new instance of the secondary form
                this.secondaryForm = new ScreenB();

                // Show the secondary form
                this.secondaryForm.Show();
            }

            // Update the data in the secondary form
            this.secondaryForm.UpdateData(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                if (isSecondaryFormOpen)
                {
                    secondaryForm.Close();
                //isSecondaryFormOpen = false;
                }
            
        }

        private void ScreenA_Load(object sender, EventArgs e)
        {
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textToAdd = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(textToAdd))
            {
                listBox1.Items.Add(textToAdd);
                textBox1.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                foreach (object selectedItem in listBox1.SelectedItems)
                {
                    string itemText = selectedItem.ToString();

                    if (this.secondaryForm == null || this.secondaryForm.IsDisposed)
                    {
                        // Get the secondary screen
                        Screen secondaryScreen = Screen.AllScreens.FirstOrDefault(s => !s.Primary);

                        // Create the form to be displayed on the secondary screen
                        secondaryForm = new ScreenB();
                        secondaryForm.Text = "Secondary Screen Form";

                        // Set the form's location and size to match the secondary screen
                        secondaryForm.StartPosition = FormStartPosition.Manual;
                        //secondaryForm.Location = secondaryScreen.WorkingArea.Location;
                        //secondaryForm.Size = secondaryScreen.WorkingArea.Size;
                        // Create a new instance of the secondary form
                        this.secondaryForm = new ScreenB();

                        // Show the secondary form
                        this.secondaryForm.Show();
                    }

                    // Update the data in the secondary form
                    this.secondaryForm.UpdateData(itemText);
                }
            }
        }
    }
}
