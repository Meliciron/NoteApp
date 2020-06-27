namespace NoteAppUI
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CreatureDateLabel = new System.Windows.Forms.Label();
            this.ModifiedDateLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CreatureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(9, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 17);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(9, 48);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // CreatureDateLabel
            // 
            this.CreatureDateLabel.AutoSize = true;
            this.CreatureDateLabel.Location = new System.Drawing.Point(9, 83);
            this.CreatureDateLabel.Name = "CreatureDateLabel";
            this.CreatureDateLabel.Size = new System.Drawing.Size(62, 17);
            this.CreatureDateLabel.TabIndex = 2;
            this.CreatureDateLabel.Text = "Created:";
            // 
            // ModifiedDateLabel
            // 
            this.ModifiedDateLabel.AutoSize = true;
            this.ModifiedDateLabel.Location = new System.Drawing.Point(321, 83);
            this.ModifiedDateLabel.Name = "ModifiedDateLabel";
            this.ModifiedDateLabel.Size = new System.Drawing.Size(65, 17);
            this.ModifiedDateLabel.TabIndex = 3;
            this.ModifiedDateLabel.Text = "Modified:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(91, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(501, 22);
            this.TitleTextBox.TabIndex = 4;
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextTextBox.Location = new System.Drawing.Point(12, 114);
            this.NoteTextTextBox.Multiline = true;
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextTextBox.Size = new System.Drawing.Size(723, 362);
            this.NoteTextTextBox.TabIndex = 5;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(91, 45);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.CategoryComboBox.TabIndex = 6;
            // 
            // CreatureDateTimePicker
            // 
            this.CreatureDateTimePicker.Enabled = false;
            this.CreatureDateTimePicker.Location = new System.Drawing.Point(91, 80);
            this.CreatureDateTimePicker.Name = "CreatureDateTimePicker";
            this.CreatureDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.CreatureDateTimePicker.TabIndex = 7;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(392, 80);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ModifiedDateTimePicker.TabIndex = 8;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(531, 489);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 28);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(637, 489);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 522);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreatureDateTimePicker);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.NoteTextTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ModifiedDateLabel);
            this.Controls.Add(this.CreatureDateLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteForm";
            this.Text = "Add note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CreatureDateLabel;
        private System.Windows.Forms.Label ModifiedDateLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox NoteTextTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DateTimePicker CreatureDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.Button OkButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}