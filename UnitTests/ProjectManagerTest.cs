using System;
using System.Collections.Generic;
using System.IO;
using NoteApp;
using NUnit.Framework;
namespace UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private ProjectManager _projectManager;
        private string _noteAppPath = Environment.ExpandEnvironmentVariables(@"%appdata%\NoteApp");
        private Project _project;
        private Note _note;

        [SetUp]
        public void InitProjectManager()
        {
            _projectManager = new ProjectManager();
            _project = new Project();
            _project.Notes = new List<Note>();
            _note = new Note();
            _note.Name = "No name";
            _note.Category = NoteCategory.All;
            _note.Text = "Some text";
            _project.Notes.Add(_note);
            _projectManager.SetTestFileName();

        }
        [TearDown]
        public void RemoveFile()
        {
            if (File.Exists(_noteAppPath + "Test.json"))
            {
                File.Delete(_noteAppPath + "Test.json");
            }
        }

        [TestCase(TestName = "Тест сериализации проекта")]
        public void SaveToFileTest()
        {
            _projectManager.SaveToFile(_project);
            Assert.True(File.Exists(_noteAppPath + "Test.json"));
        }

        [TestCase("No name", "Some text", NoteCategory.All,
            TestName = "Тест дессериализации проекта")]
        public void LaodFromFileTest(string expectedName, string expectedText, NoteCategory expectedNoteCategory)
        {
            _projectManager.SaveToFile(_project);
            var actual = _projectManager.LoadFromFile();
            Assert.AreEqual(expectedName, actual.Notes[0].Name);
            Assert.AreEqual(expectedText, actual.Notes[0].Text);
            Assert.AreEqual(expectedNoteCategory, actual.Notes[0].Category);
        }
    }
}