using System;
using NoteApp;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace NoteAppUI
{
    // TODO: если на форме выбрать категорию для отображения,
    // а затем в любой заметке изменить категорию на другую (не ту, которая выбрана для отображения),
    // то заметка исчезает из листбокса, но отображается на правой панели, хотя должна была исчезнуть
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Имя файла, в котором хранятся заметки
        /// </summary>
        private const string _workFileName = "Work.json";

        /// <summary>
        /// Путь к файлу, в котором хранятся заметки
        /// </summary>
        private string _filePath = Environment.ExpandEnvironmentVariables(@"%appdata%\NoteApp");

        /// <summary>
        /// Объект класса ProjectManager.
        /// Служит для сериализации и десериализации проекта
        /// </summary>
        private ProjectManager _projectManager = new ProjectManager();

        public MainForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.Add("All");
            FillCombobox();
            if (_project.CurrentNote != null)
                NoteListBox.SelectedItem = _project.CurrentNote;
        }

        /// <summary>
        /// Загрузка главной формы
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: проверка на существование файла должна проходить внутри менеджера, а не в форме - это же тоже часть бизнес-логики
            if (!File.Exists(_filePath + _workFileName))
            {
                _project = new Project();
                CategoryComboBox.SelectedIndex = 0;
            }
            else
            {
                _project = _projectManager.LoadFromFile(_filePath,
                    _workFileName);
                foreach (Note note in _project.Notes) NoteListBox.Items.Add(note);
                CategoryComboBox.SelectedIndex = 0;
                if (_project.CurrentNote != null)
                    FillNoteInfo(_project.CurrentNote);
                SortByDate();
            }
        }

        /// <summary>
        /// Заполнение комбобокса категориями заметок
        /// </summary>
        private void FillCombobox()
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
            if (newNoteForm.DialogResult != DialogResult.OK)
                NoteListBox.SelectedItem = -1;
            else
            {
                var newNote = newNoteForm.Note;
                if (newNote != null)
                {
                    newNote.CreatureDate = DateTime.Now;
                    _project.Notes.Add(newNote);
                    NoteListBox.Items.Add(newNote);
                    _projectManager.SaveToFile(_project, _filePath, _workFileName);
                    SortByDate();
                }
            }
        }

        /// <summary>
        /// Редактирование выбранной заметки
        /// </summary>
        private void EditNote()
        {
            var currentNote = NoteListBox.SelectedItem;
            if (NoteListBox.SelectedIndex == -1)
            {
                ErrorInditation();
            }
            else
            {
                var selectedNote = (Note) NoteListBox.SelectedItem;
                var editNoteForm = new NoteForm();
                editNoteForm.Note = selectedNote;
                editNoteForm.Text = "Edit note";
                /* editNoteForm.Icon = 
                     Icon.ExtractAssociatedIcon( Environment.ExpandEnvironmentVariables(@"Icons\edit-note.ico"));*/
                editNoteForm.ShowDialog();
                if (editNoteForm.DialogResult != DialogResult.OK)
                    NoteListBox.SelectedItem = -1;
                else
                {
                    var editNote = editNoteForm.Note;
                    if (editNote == null)
                        NoteListBox.SelectedItem = -1;
                    else
                    {
                        NoteListBox.Items.Remove(currentNote);
                        _project.Notes.Remove((Note) currentNote);
                        NoteListBox.Items.Add(editNote);
                        _project.Notes.Add(editNote);
                        _projectManager.SaveToFile(_project, _filePath, _workFileName);
                        FillNoteInfo(editNote);
                        Sorting();
                        SortByDate();
                    }
                }
            }
        }

        /// <summary>
        /// Удаление выбранной заметки
        /// </summary>
        private void RemoveNote()
        {
            if (NoteListBox.SelectedIndex == -1)
            {
                ErrorInditation();
            }
            else
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
                    _projectManager.SaveToFile(_project, _filePath, _workFileName);
                }
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
                var currentCategory =(NoteCategory) Enum.GetValues(typeof(NoteCategory)).GetValue(CategoryComboBox.SelectedIndex -1);
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
        private void FillNoteInfo(Note note)
        {
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
                _project.CurrentNote = (Note) NoteListBox.SelectedItem;
                _projectManager.SaveToFile(_project, _filePath, _workFileName);
                Application.Exit();
            }
        }

        /// <summary>
        /// Моргание фона листбокса, если не выбрана заметка для редактирования или удаления
        /// </summary>
        private void ErrorInditation()
        {
            for (int i = 0; i < 2; i++)
            {
                NoteListBox.BackColor = Color.IndianRed;
                Task.Delay(300).GetAwaiter().GetResult();
                NoteListBox.BackColor = Color.White;
                Task.Delay(300).GetAwaiter().GetResult();
            }
        }

        /// <summary>
        /// Сортировка по дате дате изменения
        /// </summary>
        private void SortByDate()
        {
            NoteListBox.Items.Clear();
            if (CategoryComboBox.SelectedIndex == 0)
            {
                foreach (Note note in _project.SortList(_project.Notes))
                    NoteListBox.Items.Add(note);
            }
            if (CategoryComboBox.SelectedIndex != 0)
            {
                var selectedCategory = (NoteCategory)Enum.GetValues(typeof(NoteCategory)).GetValue(CategoryComboBox.SelectedIndex - 1);
                foreach (Note note in _project.SortList(selectedCategory, _project.SortList(_project.Notes)))
                {
                    NoteListBox.Items.Add(note);
                }
            }
        }

        /// <summary>
        /// Событие при выборе категории заметки в комбобоксе
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorting();
            SortByDate();
        }

        /// <summary>
        /// Событие при закрытии приложения
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAppMessage();
        }

        /// <summary>
        /// Событие при выборе заметки в листбоксе
        /// </summary>
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedItem != null)
            {
                FillNoteInfo( (Note) NoteListBox.SelectedItem);
            }
        }

        /// <summary>
        /// Событие при нажатии на изображении с удалением заметки
        /// </summary>
        private void DeleteNotePictureBox_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Событие при нажатии на удаление заметки в меню
        /// </summary>
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Событие при нажатии на раздел about в меню
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAboutForm = new AboutForm();
            newAboutForm.ShowDialog();
        }

        /// <summary>
        /// Событие при нажатии на изображение с добавлением новой заметки
        /// </summary>
        private void NewNotePictureBox_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Событие при нажатии на изображение с редактированием заметки
        /// </summary>
        private void EditNotePictureBox_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Событие при выборе раздела Edit note в меню
        /// </summary>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Событие при выборе раздела Add note в меню
        /// </summary>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Событие при нажатии на клавишу Delete
        /// </summary>
        private void NoteListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                RemoveNote();
        }
    }
}
