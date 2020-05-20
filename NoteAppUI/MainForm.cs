using System;
using NoteApp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        private Project _project = new Project();
        private ProjectManager _projectManager = new ProjectManager();
        public MainForm()
        {
            InitializeComponent();
            FillCombobox();
            _projectManager.SetWorkFileName();
            NoteListBox.DisplayMember = "Name";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _project = _projectManager.LoadFromFile();
            if (_project != null)
            {
                foreach (Note note in _project.Notes)
                {
                    NoteListBox.Items.Add(note);
                }
            }
            else
            {
                _project = new Project();
                _project.Notes = new List<Note>();
            }
            CategoryComboBox.SelectedIndex = 0;
            NoteListBox.SelectedIndex = -1;
        }
        /// <summary>
        /// Заполнение комбобокса категориями заметок
        /// </summary>
        private void
            FillCombobox()
        {
            foreach (NoteCategory noteCategory in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(noteCategory.ToString());
            }
        }
        /// <summary>
        /// Создание новой заметки
        /// </summary>
        private void AddNote()
        {
            var newNoteForm = new NoteForm();
            newNoteForm.ShowDialog();
            var newNote = newNoteForm.Note;
            if (newNote != null)
            {
                _project.Notes.Add(newNote);
                NoteListBox.Items.Add(newNote);
                _projectManager.SaveToFile(_project);
                _projectManager.LoadFromFile();
            }
        }
        /// <summary>
        /// Редактирование выбранной заметки
        /// </summary>
       private void EditNote()
        {
            int currentNoteIndex = NoteListBox.SelectedIndex;
            if (NoteListBox.SelectedIndex != -1)
            {
                var selectedNote = (Note) NoteListBox.SelectedItem;
                var editNoteForm = new NoteForm();
                editNoteForm.Note = selectedNote;
                editNoteForm.Text = "Edit note";
                /* editNoteForm.Icon = 
                     Icon.ExtractAssociatedIcon( Environment.ExpandEnvironmentVariables(@"Icons\edit-note.ico"));*/
                editNoteForm.ShowDialog();
                var editNote = editNoteForm.Note;
                if (editNote != null)
                {
                    NoteListBox.Items.RemoveAt(currentNoteIndex);
                    _project.Notes.RemoveAt(currentNoteIndex);
                    NoteListBox.Items.Add(editNote);
                    _project.Notes.Add(editNote);
                    _projectManager.SaveToFile(_project);
                    _projectManager.LoadFromFile();
                }
            }
            else
            {
                MessageBox.Show("Please choose note");
            }
        }
        /// <summary>
        /// Удаление выбранной заметки
        /// </summary>
        private void RemoveNote()
        {
            if (NoteListBox.SelectedIndex != -1)
            {
                var deleteItem = NoteListBox.SelectedItem;
                DialogResult result = MessageBox.Show("Do you want to remove this note?", "Note removing",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (NoteListBox.SelectedIndex >= 0)
                    {
                        NoteListBox.SelectedIndex = NoteListBox.SelectedIndex - 1;
                    }
                    else
                    {
                        NoteListBox.SelectedIndex = -1;
                    }
                    NoteListBox.Items.Remove(deleteItem);
                    _project.Notes.Remove((Note) deleteItem);
                    _projectManager.SaveToFile(_project);
                    _projectManager.LoadFromFile();
                }
            }
            else
            {
                MessageBox.Show("Please choose note");
            }
        }
        /// <summary>
        /// Сортировка заметок по категориям
        /// </summary>
        private void Sorting()
        {
            NoteListBox.Items.Clear();
            if (CategoryComboBox.SelectedIndex == 0)
            {
                foreach (Note note in _project.Notes)
                {
                    NoteListBox.Items.Add(note);
                }
            }
            else
            {
                var currentCategory =(NoteCategory) Enum.GetValues(typeof(NoteCategory)).GetValue(CategoryComboBox.SelectedIndex);
                foreach (Note note in _project.Notes)
                {
                    if (note.Category == currentCategory)
                    {
                        NoteListBox.Items.Add(note);
                    }
                }
            }
        }
        /// <summary>
        /// Заполнение информации (название, содержание и т.д.) заметки
        /// </summary>
        void FillNoteInfo()
        {
            Note note = (Note)NoteListBox.SelectedItem;
            TitleLabel.Text = note.Name;
            Pan2CategoryLabel.Text = note.Category.ToString();
            ModifiedDateTimePicker.Value = note.LastChangeDate;
            CreatureDateTimePicker.Value = note.CreatureDate;
            NoteTextTextBox.Text = note.Text;
        }
        /// <summary>
        /// Сообщение при выходе из программы
        /// </summary>
        private void CloseAppMessage() 
        {
            DialogResult result = MessageBox.Show("Exit NoteApp?", "NoteApp", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorting();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAppMessage();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedItem != null)
            {
                FillNoteInfo();
            }
        }

        private void DeleteNotePictureBox_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAboutForm = new AboutForm();
            newAboutForm.ShowDialog();
        }

        private void NewNotePictureBox_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditNotePictureBox_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }
    }
}
