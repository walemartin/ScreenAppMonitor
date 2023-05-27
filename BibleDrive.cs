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
            //this.sp_GetBiblePassageKJVTableAdapter.Fill(this.kJVDataSet.sp_GetBiblePassageKJV,null,null,null);

        }

       

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_GetBiblePassageKJVTableAdapter.Fill(this.kJVDataSet.sp_GetBiblePassageKJV, passageToolStripTextBox1.Text.Trim(), Convert.ToByte(chapterToolStripTextBox1.Text.Trim()), Convert.ToByte(verseToolStripTextBox1.Text.Trim(null)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ex.Data);
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
                string chapter = Convert.ToString(row.Cells[1].Value);
                string verse = Convert.ToString(row.Cells[2].Value);
                string biblepassage = Convert.ToString(row.Cells[3].Value);

                // Create a new ListItem object and set its properties
                string item = bibletext  + "  " +chapter + " : "+verse;
                string itempassage = biblepassage.PadLeft(20).PadRight(10);

                // Add the new ListItem object to a ListBox or ComboBox control
                listBox1.Items.Add(item);
                listBox1.Items.Add(itempassage);
                listBox1.Items.Add("- - - - - - - - - - - - - -");
            }
        }

        private void fillToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BibleDrive_Load(object sender, EventArgs e)
        {
            //sp_GetBiblePassageKJVTableAdapter.Fill(this.kJVDataSet.sp_GetBiblePassageKJV, null, null, null);
        }
    }
}
