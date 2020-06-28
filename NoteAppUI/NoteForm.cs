using System;
using System.Collections.Generic;
using NoteApp;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        private Note _note = new Note();
        public NoteForm()
        {
            InitializeComponent();
            FillCombobox();
        }
        /// <summary>
        /// Новая заметка
        /// </summary>
        public Note Note 
        {
            get
            {
                return _note;
            }
            set
            {
                TitleTextBox.Text = value.Name;
                NoteTextTextBox.Text = value.Text;
                Note.CreatureDate  = value.CreatureDate;
                ModifiedDateTimePicker.Value = value.LastChangeDate;
                CategoryComboBox.SelectedItem = value.Category.ToString();
            }
        }
        /// <summary>
        /// Заполнение комбобокса
        /// </summary>
        private void FillCombobox()
        {
            foreach (NoteCategory noteCategory in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(noteCategory.ToString());
            }
        }
        /// <summary>
        /// Обновление данных в заметке
        /// </summary>
        private void UpdateNote()
        {
            try
            {
                _note.LastChangeDate = DateTime.Now;
                _note.Category = (NoteCategory)Enum.GetValues(typeof(NoteCategory)).GetValue(CategoryComboBox.SelectedIndex);
                _note.Text = NoteTextTextBox.Text;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            UpdateNote();
            DialogResult = DialogResult.OK;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                TitleTextBox.BackColor = Color.White;
                OkButton.Enabled = true;
                _note.Name = TitleTextBox.Text;
            }
            catch (ArgumentException exception)
            {
                ErrorLabel.Text = "Не более 50 символов";
                TitleTextBox.BackColor = Color.IndianRed;
                OkButton.Enabled = false;
            }
        }
    }
}
