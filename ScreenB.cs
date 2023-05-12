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
    public partial class ScreenB : Form
    {
        public ScreenB()
        {
            InitializeComponent();
        }
        public void UpdateData(string newData)
        {
            label1.Text = newData;
        }

        private void ScreenB_Load(object sender, EventArgs e)
        {
           
        }
    }
}
