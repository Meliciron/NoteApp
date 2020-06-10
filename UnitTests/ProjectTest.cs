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

        public void InitProject()
        {
            _project = new Project();
            _project.Notes = new List<Note>();
            _note = new Note();
        }
        [TestCase(TestName = "Добавление новой заметки в список")]
        public void TestProject()
        {
            InitProject();
            _note.Name = "Name";
            _note.Category = NoteCategory.Other;
            _note.Text = "Text";
            _project.Notes.Add(_note);
            Assert.AreEqual(_project.Notes[0].Name, "Name");
            Assert.AreEqual(_project.Notes[0].Category, NoteCategory.Other);
            Assert.AreEqual(_project.Notes[0].Text, "Text");
        }
    }
}