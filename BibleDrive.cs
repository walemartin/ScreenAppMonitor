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
    public partial class BibleDrive : Form
    {
        public BibleDrive()
        {
            InitializeComponent();
        }

       

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_GetBiblePassageKJVTableAdapter.Fill(this.kJVDataSet.sp_GetBiblePassageKJV, passageToolStripTextBox1.Text, new System.Nullable<byte>(((byte)(System.Convert.ChangeType(chapterToolStripTextBox1.Text, typeof(byte))))), new System.Nullable<byte>(((byte)(System.Convert.ChangeType(verseToolStripTextBox1.Text, typeof(byte))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a cell is selected and it's not a header row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Retrieve the data from the selected row
                //int id = Convert.ToInt32(row.Cells["ID"].Value);
                string bibletext = Convert.ToString(row.Cells[0].Value);
                string biblepassage = Convert.ToString(row.Cells[3].Value);

                // Create a new ListItem object and set its properties
                var item = bibletext  + Environment.NewLine + biblepassage + Environment.NewLine;

                // Add the new ListItem object to a ListBox or ComboBox control
                listBox1.Items.Add(item);
            }
        }
    }
}
