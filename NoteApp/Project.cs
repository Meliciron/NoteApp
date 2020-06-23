using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс, содержащий список (или словарь) всех заметок.
    /// </summary>
    public class Project 
    {
        /// <summary>
        /// Текущая заметка
        /// </summary>
        private Note _currentNote;

        /// <summary>
        /// Задает и возвращает список заметок.
        /// </summary>
        public List<Note> Notes
        {
            get; 
            set;
        }

        /// <summary>
        /// Конструктор списка заметок
        /// </summary>
        public Project()
        {
            Notes = new List<Note>();
        }

        /// <summary>
        /// Сохраниение текущей заметки. Текущая заметка открыватся при запуске приложения
        /// </summary>
        public Note CurrentNote
        {
            get;
            set;
        }
        
        /// <summary>
        /// Сортировка списка заметок по дате изменения
        /// </summary>
        public List<Note> SortList(List<Note> notes)
        {
            return notes.OrderByDescending(a => a.LastChangeDate).ToList();
        } 

        /// <summary>
        /// Сортировка списка заметок по дате изменения и категории
        /// </summary>
        public List<Note> SortList(NoteCategory noteCategory, List<Note> notes)
        {
            List<Note> sortedNotes =new List<Note>();
            foreach (Note note in notes)
            {
                if (noteCategory == note.Category)
                    sortedNotes.Add(note);
            }
            return sortedNotes;
        }
    }
}
