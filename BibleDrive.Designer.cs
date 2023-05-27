namespace ScreenAppMonitor
{
    partial class BibleDrive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biblepassageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibletextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGetBiblePassageKJVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kJVDataSet = new ScreenAppMonitor.KJVDataSet();
            this.sp_GetBiblePassageKJVTableAdapter = new ScreenAppMonitor.KJVDataSetTableAdapters.sp_GetBiblePassageKJVTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.passageToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.passageToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.chapterToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.chapterToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.verseToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.verseToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bibleDataSetKJv = new ScreenAppMonitor.bibleDataSetKJv();
            this.bibleDataSetKJvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetBiblePassageKJVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kJVDataSet)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibleDataSetKJv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibleDataSetKJvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biblepassageDataGridViewTextBoxColumn,
            this.chapterDataGridViewTextBoxColumn,
            this.verseDataGridViewTextBoxColumn,
            this.bibletextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spGetBiblePassageKJVBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 675);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // biblepassageDataGridViewTextBoxColumn
            // 
            this.biblepassageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.biblepassageDataGridViewTextBoxColumn.DataPropertyName = "biblepassage";
            this.biblepassageDataGridViewTextBoxColumn.HeaderText = "Bible passage";
            this.biblepassageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biblepassageDataGridViewTextBoxColumn.Name = "biblepassageDataGridViewTextBoxColumn";
            this.biblepassageDataGridViewTextBoxColumn.ReadOnly = true;
            this.biblepassageDataGridViewTextBoxColumn.Width = 124;
            // 
            // chapterDataGridViewTextBoxColumn
            // 
            this.chapterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chapterDataGridViewTextBoxColumn.DataPropertyName = "chapter";
            this.chapterDataGridViewTextBoxColumn.HeaderText = "Chapter";
            this.chapterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chapterDataGridViewTextBoxColumn.Name = "chapterDataGridViewTextBoxColumn";
            this.chapterDataGridViewTextBoxColumn.ReadOnly = true;
            this.chapterDataGridViewTextBoxColumn.Width = 83;
            // 
            // verseDataGridViewTextBoxColumn
            // 
            this.verseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.verseDataGridViewTextBoxColumn.DataPropertyName = "verse";
            this.verseDataGridViewTextBoxColumn.HeaderText = "Verse";
            this.verseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.verseDataGridViewTextBoxColumn.Name = "verseDataGridViewTextBoxColumn";
            this.verseDataGridViewTextBoxColumn.ReadOnly = true;
            this.verseDataGridViewTextBoxColumn.Width = 72;
            // 
            // bibletextDataGridViewTextBoxColumn
            // 
            this.bibletextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bibletextDataGridViewTextBoxColumn.DataPropertyName = "bibletext";
            this.bibletextDataGridViewTextBoxColumn.HeaderText = "Bible text";
            this.bibletextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bibletextDataGridViewTextBoxColumn.Name = "bibletextDataGridViewTextBoxColumn";
            this.bibletextDataGridViewTextBoxColumn.ReadOnly = true;
            this.bibletextDataGridViewTextBoxColumn.Width = 90;
            // 
            // spGetBiblePassageKJVBindingSource
            // 
            this.spGetBiblePassageKJVBindingSource.DataMember = "sp_GetBiblePassageKJV";
            this.spGetBiblePassageKJVBindingSource.DataSource = this.kJVDataSet;
            // 
            // kJVDataSet
            // 
            this.kJVDataSet.DataSetName = "KJVDataSet";
            this.kJVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetBiblePassageKJVTableAdapter
            // 
            this.sp_GetBiblePassageKJVTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(758, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(580, 674);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.fillToolStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passageToolStripLabel1,
            this.passageToolStripTextBox1,
            this.chapterToolStripLabel1,
            this.chapterToolStripTextBox1,
            this.verseToolStripLabel1,
            this.verseToolStripTextBox1,
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.fillToolStrip1.Size = new System.Drawing.Size(1358, 32);
            this.fillToolStrip1.TabIndex = 3;
            this.fillToolStrip1.Text = "fillToolStrip1";
            this.fillToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillToolStrip1_ItemClicked);
            // 
            // passageToolStripLabel1
            // 
            this.passageToolStripLabel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passageToolStripLabel1.Name = "passageToolStripLabel1";
            this.passageToolStripLabel1.Size = new System.Drawing.Size(93, 29);
            this.passageToolStripLabel1.Text = "Passage:";
            // 
            // passageToolStripTextBox1
            // 
            this.passageToolStripTextBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1 Chronicles",
            "1 Corinthians",
            "1 John",
            "1 Kings",
            "1 Peter",
            "1 Samuel",
            "1 Thessalonians",
            "1 Timothy",
            "2 Chronicles",
            "2 Corinthians",
            "2 John",
            "2 Kings",
            "2 Peter",
            "2 Samuel",
            "2 Thessalonians",
            "2 Timothy",
            "3 John",
            "Acts",
            "Amos",
            "Colossians",
            "Daniel",
            "Deuteronomy",
            "Ecclesiastes",
            "Ephesians",
            "Esther",
            "Exodus",
            "Ezekiel",
            "Ezra",
            "Galatians",
            "Genesis",
            "Habakkuk",
            "Haggai",
            "Hebrews",
            "Hosea",
            "Isaiah",
            "James",
            "Jeremiah",
            "Job",
            "Joel",
            "John",
            "Jonah",
            "Joshua",
            "Jude",
            "Judges",
            "Lamentations",
            "Leviticus",
            "Luke",
            "Malachi",
            "Mark",
            "Matthew",
            "Micah",
            "Nahum",
            "Nehemiah",
            "Numbers",
            "Obadiah",
            "Philemon",
            "Philippians",
            "Proverbs",
            "Psalms",
            "Revelation",
            "Romans",
            "Ruth",
            "Song of Solomon",
            "Titus",
            "Zechariah",
            "Zephaniah"});
            this.passageToolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.passageToolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.passageToolStripTextBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.passageToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passageToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passageToolStripTextBox1.Name = "passageToolStripTextBox1";
            this.passageToolStripTextBox1.Size = new System.Drawing.Size(100, 32);
            // 
            // chapterToolStripLabel1
            // 
            this.chapterToolStripLabel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterToolStripLabel1.Name = "chapterToolStripLabel1";
            this.chapterToolStripLabel1.Size = new System.Drawing.Size(90, 29);
            this.chapterToolStripLabel1.Text = "Chapter:";
            // 
            // chapterToolStripTextBox1
            // 
            this.chapterToolStripTextBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.chapterToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chapterToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chapterToolStripTextBox1.Name = "chapterToolStripTextBox1";
            this.chapterToolStripTextBox1.Size = new System.Drawing.Size(100, 32);
            // 
            // verseToolStripLabel1
            // 
            this.verseToolStripLabel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verseToolStripLabel1.Name = "verseToolStripLabel1";
            this.verseToolStripLabel1.Size = new System.Drawing.Size(69, 29);
            this.verseToolStripLabel1.Text = "Verse:";
            // 
            // verseToolStripTextBox1
            // 
            this.verseToolStripTextBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.verseToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verseToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.verseToolStripTextBox1.Name = "verseToolStripTextBox1";
            this.verseToolStripTextBox1.Size = new System.Drawing.Size(100, 32);
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.BackColor = System.Drawing.Color.Crimson;
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillToolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(92, 29);
            this.fillToolStripButton1.Text = "Search";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // bibleDataSetKJv
            // 
            this.bibleDataSetKJv.DataSetName = "bibleDataSetKJv";
            this.bibleDataSetKJv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibleDataSetKJvBindingSource
            // 
            this.bibleDataSetKJvBindingSource.DataSource = this.bibleDataSetKJv;
            this.bibleDataSetKJvBindingSource.Position = 0;
            // 
            // BibleDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1358, 713);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BibleDrive";
            this.Text = "Bible Drive";
            this.Load += new System.EventHandler(this.BibleDrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetBiblePassageKJVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kJVDataSet)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibleDataSetKJv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibleDataSetKJvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource spGetBiblePassageKJVBindingSource;
        private KJVDataSet kJVDataSet;
        private bibleDataSetKJv bibleDataSetKJv;
        private System.Windows.Forms.BindingSource bibleDataSetKJvBindingSource;
        private KJVDataSetTableAdapters.sp_GetBiblePassageKJVTableAdapter sp_GetBiblePassageKJVTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel passageToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox passageToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel chapterToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox chapterToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel verseToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox verseToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn biblepassageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibletextDataGridViewTextBoxColumn;
    }
}