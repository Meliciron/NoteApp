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
                //TODO: форма не должна проверять собственное значение dialogResult - его проверяют снаружи, кто использует эту форму. Внутри же этой формы результат должен только присваиваться
                if (DialogResult == DialogResult.OK)
                {
                    _note.CreatureDate = DateTime.Now;
                    return _note;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                TitleTextBox.Text = value.Name;
                NoteTextTextBox.Text = value.Text;
                CreatureDateTimePicker.Value = value.CreatureDate;
                ModifiedDateTimePicker.Value = value.LastChangeDate;
                CategoryComboBox.SelectedItem = value.Category.ToString();
            }
        }
        /// <summary>
        /// Заполнение комбобокса
        /// </summary>
        void FillCombobox() //TODO:  явно указать модификатор доступа
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
                _note.Category = (NoteCategory)Enum.GetValues(typeof(NoteCategory)).GetValue(CategoryComboBox.SelectedIndex);
                _note.Text = NoteTextTextBox.Text;
                _note.Name = TitleTextBox.Text;
                _note.LastChangeDate = DateTime.Now;
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
        //TODO: нет работы с кнопкой отмены и закрытием окна по крестику
    }
    //TODO: Замечания по верстке окна:
    //TODO: 1) элементы не выровнены между собой по направляющим (например лейблы относительно текстбоксов и т.д.)
    //TODO: 2) у элементов должны быть одинаковые отступы/расстояния между друг другом. Здесь же поля слева и права могут быть разных размеров, как и расстояния между элементами сверху и снизу
    //TODO: 3) грамматические ошибки
    //TODO: 4) для кнопок Ok и Cancel (как и для других однострочных элементов) нужно использовать стандартную высоту, никогда не уменьшая их по высоте (можно только по ширине)
    //TODO: 5) название формы не соответствует действию
}
