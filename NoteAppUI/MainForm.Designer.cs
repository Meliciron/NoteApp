namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DeleteNotePictureBox = new System.Windows.Forms.PictureBox();
            this.EditNotePictureBox = new System.Windows.Forms.PictureBox();
            this.NewNotePictureBox = new System.Windows.Forms.PictureBox();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.Pan1ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NoteTextTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateLabel = new System.Windows.Forms.Label();
            this.CreatedDateLabel = new System.Windows.Forms.Label();
            this.Pan2CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteNotePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNotePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewNotePictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteNotePictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.EditNotePictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.NewNotePictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.NoteListBox);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.Pan1ShowCategoryLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteTextTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.CreatureDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.Pan2CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1049, 553);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
            // 
            // DeleteNotePictureBox
            // 
            this.DeleteNotePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNotePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteNotePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DeleteNotePictureBox.Image")));
            this.DeleteNotePictureBox.Location = new System.Drawing.Point(104, 502);
            this.DeleteNotePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteNotePictureBox.Name = "DeleteNotePictureBox";
            this.DeleteNotePictureBox.Size = new System.Drawing.Size(40, 39);
            this.DeleteNotePictureBox.TabIndex = 5;
            this.DeleteNotePictureBox.TabStop = false;
            this.ToolTip.SetToolTip(this.DeleteNotePictureBox, "Remove current note");
            this.DeleteNotePictureBox.Click += new System.EventHandler(this.DeleteNotePictureBox_Click);
            // 
            // EditNotePictureBox
            // 
            this.EditNotePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNotePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNotePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EditNotePictureBox.Image")));
            this.EditNotePictureBox.Location = new System.Drawing.Point(59, 502);
            this.EditNotePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditNotePictureBox.Name = "EditNotePictureBox";
            this.EditNotePictureBox.Size = new System.Drawing.Size(40, 39);
            this.EditNotePictureBox.TabIndex = 4;
            this.EditNotePictureBox.TabStop = false;
            this.ToolTip.SetToolTip(this.EditNotePictureBox, "Edit current note");
            this.EditNotePictureBox.Click += new System.EventHandler(this.EditNotePictureBox_Click);
            // 
            // NewNotePictureBox
            // 
            this.NewNotePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewNotePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewNotePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NewNotePictureBox.Image")));
            this.NewNotePictureBox.Location = new System.Drawing.Point(12, 502);
            this.NewNotePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewNotePictureBox.Name = "NewNotePictureBox";
            this.NewNotePictureBox.Size = new System.Drawing.Size(40, 39);
            this.NewNotePictureBox.TabIndex = 3;
            this.NewNotePictureBox.TabStop = false;
            this.ToolTip.SetToolTip(this.NewNotePictureBox, "Add new note");
            this.NewNotePictureBox.Click += new System.EventHandler(this.NewNotePictureBox_Click);
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListBox.DisplayMember = "Note.Name";
            this.NoteListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.ItemHeight = 16;
            this.NoteListBox.Location = new System.Drawing.Point(12, 57);
            this.NoteListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(248, 404);
            this.NoteListBox.TabIndex = 2;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            this.NoteListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoteListBox_KeyDown);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(135, 17);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(126, 24);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // Pan1ShowCategoryLabel
            // 
            this.Pan1ShowCategoryLabel.AutoSize = true;
            this.Pan1ShowCategoryLabel.Location = new System.Drawing.Point(9, 20);
            this.Pan1ShowCategoryLabel.Name = "Pan1ShowCategoryLabel";
            this.Pan1ShowCategoryLabel.Size = new System.Drawing.Size(119, 17);
            this.Pan1ShowCategoryLabel.TabIndex = 0;
            this.Pan1ShowCategoryLabel.Text = "Choose category:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 57);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category:";
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextTextBox.Enabled = false;
            this.NoteTextTextBox.Location = new System.Drawing.Point(5, 122);
            this.NoteTextTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteTextTextBox.Multiline = true;
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.Size = new System.Drawing.Size(765, 429);
            this.NoteTextTextBox.TabIndex = 6;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(383, 82);
            this.ModifiedDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ModifiedDateTimePicker.TabIndex = 5;
            // 
            // CreatureDateTimePicker
            // 
            this.CreatureDateTimePicker.Enabled = false;
            this.CreatureDateTimePicker.Location = new System.Drawing.Point(73, 82);
            this.CreatureDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatureDateTimePicker.Name = "CreatureDateTimePicker";
            this.CreatureDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.CreatureDateTimePicker.TabIndex = 4;
            // 
            // ModifiedDateLabel
            // 
            this.ModifiedDateLabel.AutoSize = true;
            this.ModifiedDateLabel.Location = new System.Drawing.Point(312, 89);
            this.ModifiedDateLabel.Name = "ModifiedDateLabel";
            this.ModifiedDateLabel.Size = new System.Drawing.Size(65, 17);
            this.ModifiedDateLabel.TabIndex = 3;
            this.ModifiedDateLabel.Text = "Modified:";
            // 
            // CreatedDateLabel
            // 
            this.CreatedDateLabel.AutoSize = true;
            this.CreatedDateLabel.Location = new System.Drawing.Point(3, 89);
            this.CreatedDateLabel.Name = "CreatedDateLabel";
            this.CreatedDateLabel.Size = new System.Drawing.Size(62, 17);
            this.CreatedDateLabel.TabIndex = 2;
            this.CreatedDateLabel.Text = "Created:";
            // 
            // Pan2CategoryLabel
            // 
            this.Pan2CategoryLabel.AutoSize = true;
            this.Pan2CategoryLabel.Location = new System.Drawing.Point(69, 57);
            this.Pan2CategoryLabel.Name = "Pan2CategoryLabel";
            this.Pan2CategoryLabel.Size = new System.Drawing.Size(0, 17);
            this.Pan2CategoryLabel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(1, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(66, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1049, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addNoteToolStripMenuItem.Text = "Add note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.editNoteToolStripMenuItem.Text = "Edit note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 583);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteNotePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNotePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewNotePictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label Pan1ShowCategoryLabel;
        private System.Windows.Forms.TextBox NoteTextTextBox;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.DateTimePicker CreatureDateTimePicker;
        private System.Windows.Forms.Label ModifiedDateLabel;
        private System.Windows.Forms.Label CreatedDateLabel;
        private System.Windows.Forms.Label Pan2CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox DeleteNotePictureBox;
        private System.Windows.Forms.PictureBox EditNotePictureBox;
        private System.Windows.Forms.PictureBox NewNotePictureBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label CategoryLabel;
    }
}

