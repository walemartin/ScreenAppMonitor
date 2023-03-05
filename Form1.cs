using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScreenAppMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isSecondaryFormOpen = false;
        private Screen2 secondaryForm;






        private void button2_Click(object sender, EventArgs e)
        {
            // Get the secondary screen
            Screen secondaryScreen = Screen.AllScreens.FirstOrDefault(s => !s.Primary);

            // Create the form to be displayed on the secondary screen
             secondaryForm = new Screen2();
            secondaryForm.Text = "Secondary Screen Form";

            // Set the form's location and size to match the secondary screen
            secondaryForm.StartPosition = FormStartPosition.Manual;
            //secondaryForm.Location = secondaryScreen.WorkingArea.Location;
            //secondaryForm.Size = secondaryScreen.WorkingArea.Size;

            // Create a label control and add it to the form
            Label label = new Label();
            label.Text = "Dynamic data";
            label.Location = new Point(10, 10); // Set the label's position on the form
            secondaryForm.Controls.Add(label);

            // Set the label's text to the current value of the textbox
            label.Text = textBox2.Text;


            // Show the forms on their respective screens
            secondaryForm.FormClosed += (s, args) => isSecondaryFormOpen = false;
            secondaryForm.Show();
            isSecondaryFormOpen = true;
            //this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isSecondaryFormOpen)
            {
                secondaryForm.Close();
                isSecondaryFormOpen = false;
            }
        }
    }
}
