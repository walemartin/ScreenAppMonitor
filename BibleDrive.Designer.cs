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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bibleDataSetKJv = new ScreenAppMonitor.bibleDataSetKJv();
            this.bibleDataSetKJvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kJVDataSet = new ScreenAppMonitor.KJVDataSet();
            this.spGetBiblePassageKJVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetBiblePassageKJVTableAdapter = new ScreenAppMonitor.KJVDataSetTableAdapters.sp_GetBiblePassageKJVTableAdapter();
            this.biblepassageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibletextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.passageToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.passageToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.chapterToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.chapterToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.verseToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.verseToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibleDataSetKJv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibleDataSetKJvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kJVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetBiblePassageKJVBindingSource)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biblepassageDataGridViewTextBoxColumn,
            this.chapterDataGridViewTextBoxColumn,
            this.verseDataGridViewTextBoxColumn,
            this.bibletextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spGetBiblePassageKJVBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(834, 115);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // kJVDataSet
            // 
            this.kJVDataSet.DataSetName = "KJVDataSet";
            this.kJVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetBiblePassageKJVBindingSource
            // 
            this.spGetBiblePassageKJVBindingSource.DataMember = "sp_GetBiblePassageKJV";
            this.spGetBiblePassageKJVBindingSource.DataSource = this.kJVDataSet;
            // 
            // sp_GetBiblePassageKJVTableAdapter
            // 
            this.sp_GetBiblePassageKJVTableAdapter.ClearBeforeFill = true;
            // 
            // biblepassageDataGridViewTextBoxColumn
            // 
            this.biblepassageDataGridViewTextBoxColumn.DataPropertyName = "biblepassage";
            this.biblepassageDataGridViewTextBoxColumn.HeaderText = "biblepassage";
            this.biblepassageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biblepassageDataGridViewTextBoxColumn.Name = "biblepassageDataGridViewTextBoxColumn";
            this.biblepassageDataGridViewTextBoxColumn.ReadOnly = true;
            this.biblepassageDataGridViewTextBoxColumn.Width = 125;
            // 
            // chapterDataGridViewTextBoxColumn
            // 
            this.chapterDataGridViewTextBoxColumn.DataPropertyName = "chapter";
            this.chapterDataGridViewTextBoxColumn.HeaderText = "chapter";
            this.chapterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chapterDataGridViewTextBoxColumn.Name = "chapterDataGridViewTextBoxColumn";
            this.chapterDataGridViewTextBoxColumn.ReadOnly = true;
            this.chapterDataGridViewTextBoxColumn.Width = 125;
            // 
            // verseDataGridViewTextBoxColumn
            // 
            this.verseDataGridViewTextBoxColumn.DataPropertyName = "verse";
            this.verseDataGridViewTextBoxColumn.HeaderText = "verse";
            this.verseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.verseDataGridViewTextBoxColumn.Name = "verseDataGridViewTextBoxColumn";
            this.verseDataGridViewTextBoxColumn.ReadOnly = true;
            this.verseDataGridViewTextBoxColumn.Width = 125;
            // 
            // bibletextDataGridViewTextBoxColumn
            // 
            this.bibletextDataGridViewTextBoxColumn.DataPropertyName = "bibletext";
            this.bibletextDataGridViewTextBoxColumn.HeaderText = "bibletext";
            this.bibletextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bibletextDataGridViewTextBoxColumn.Name = "bibletextDataGridViewTextBoxColumn";
            this.bibletextDataGridViewTextBoxColumn.ReadOnly = true;
            this.bibletextDataGridViewTextBoxColumn.Width = 125;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(852, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 532);
            this.listBox1.TabIndex = 2;
            // 
            // fillToolStrip1
            // 
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
            this.fillToolStrip1.Size = new System.Drawing.Size(1358, 35);
            this.fillToolStrip1.TabIndex = 3;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // passageToolStripLabel1
            // 
            this.passageToolStripLabel1.Name = "passageToolStripLabel1";
            this.passageToolStripLabel1.Size = new System.Drawing.Size(64, 22);
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
            this.passageToolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.passageToolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.passageToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passageToolStripTextBox1.Name = "passageToolStripTextBox1";
            this.passageToolStripTextBox1.Size = new System.Drawing.Size(100, 35);
            // 
            // chapterToolStripLabel1
            // 
            this.chapterToolStripLabel1.Name = "chapterToolStripLabel1";
            this.chapterToolStripLabel1.Size = new System.Drawing.Size(64, 20);
            this.chapterToolStripLabel1.Text = "Chapter:";
            // 
            // chapterToolStripTextBox1
            // 
            this.chapterToolStripTextBox1.Name = "chapterToolStripTextBox1";
            this.chapterToolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // verseToolStripLabel1
            // 
            this.verseToolStripLabel1.Name = "verseToolStripLabel1";
            this.verseToolStripLabel1.Size = new System.Drawing.Size(47, 20);
            this.verseToolStripLabel1.Text = "Verse:";
            // 
            // verseToolStripTextBox1
            // 
            this.verseToolStripTextBox1.Name = "verseToolStripTextBox1";
            this.verseToolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillToolStripButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(47, 32);
            this.fillToolStripButton1.Text = "Get";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // BibleDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 713);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BibleDrive";
            this.Text = "BibleDrive";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibleDataSetKJv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibleDataSetKJvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kJVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetBiblePassageKJVBindingSource)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn biblepassageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibletextDataGridViewTextBoxColumn;
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
    }
}