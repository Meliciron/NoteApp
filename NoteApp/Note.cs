using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp                                                       
{
    /// <summary>
    /// Класс, содержащий все сведения о заметке.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Название заметки. Не более 50 символов.
        /// </summary>
        private string _name;
       
        /// <summary>
        /// Категория заметки (с.м. enum noteCategory).
        /// </summary>
        private NoteCategory _category;
       
        /// <summary>
        /// Текст, содержание заметки.
        /// </summary>
        private string _text;
        
        /// <summary>
        /// Дата создания заметки, инициализируется однажды - при создании.
        /// </summary>
        private DateTime _creatureDate;
       
        /// <summary>
        /// Время последнего изменения меняется автоматически при изменении названия, категории или текста заметки.
        /// </summary>
        private DateTime _lastChangeDate;
       
        /// <summary>
        /// Метод, возвращающий или устанавливающй значение имени заметки
        /// </summary>
        public string Name 
        {
            get {return _name;}
            set 
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("The name must not exceed 50 characters");
                }
                else
                {
                    if (value.Length == 0)
                    {
                        _name = "Untitled";
                    }
                    else
                    {
                        _name = value;
                    }

                }
            }
        }
        /// <summary>
        /// Метод, возвращающий или устанавливающй значение категории заметки.
        /// </summary>
        /// <returns></returns>
        public NoteCategory Category
        {
            get { return _category; }
            set
            {
                _category = value;
            }
        }
        /// <summary>
        /// Метод, возвращающий или устанавливающий значение текста заметки.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
            }
        }
        /// <summary>
        /// Метод, возвращающий или устанавливающй время создания заметки.
        /// </summary>
        /// <returns></returns>
        public DateTime CreatureDate
        {
           get{ return _creatureDate;} 
           set
           {
               _creatureDate = value;
           }
        }
        /// <summary>
        /// Метод, возвращающий или устанавливающй время изменения заметки.
        /// </summary>
        public DateTime LastChangeDate
        {
            get { return _lastChangeDate; }
            set { _lastChangeDate = value;}
        }
    }
}



