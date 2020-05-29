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
        public List<Note> Notes { get; set; }
    }
}
