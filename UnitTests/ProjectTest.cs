using System.Collections.Generic;
using System.Runtime.InteropServices;
using NoteApp;
using NUnit.Framework;

namespace UnitTests

{
    [TestFixture]
    public class ProjectTest
    {
        private Project _project;
        private Note _note;

        [SetUp]
        public void InitProject()
        {
            _project = new Project();
            _project.Notes = new List<Note>();
            _note = new Note();
        }

        [TestCase(TestName = "Добавление новой заметки в список")]
        public void TestProject()
        {
            _note.Name = "Name";
            _note.Category = NoteCategory.All;
            _note.Text = "Text";
            _project.Notes.Add(_note);
        }

        
    }
}