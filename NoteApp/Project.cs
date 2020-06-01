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
    {   //TODO: xml
        //TODO: нужен конструктор, в котором будет сразу создаваться пустой список заметок
        public List<Note> Notes { get; set; }
    }
}
