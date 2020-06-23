using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using NoteApp;
using NUnit.Framework;
namespace UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private ProjectManager _projectManager;
        private string _testfilename = "NoteAppTest.json";
        private string _serializeTestFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestData\SerializeTestNoteApp.json";
        private string _testFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\DataTest";
        private Project _project;
        private Note _note;

        public void InitProjectManager()
        {
            _projectManager = new ProjectManager();
            _project = new Project();
            _project.Notes = new List<Note>();
            _note = new Note();
            _note.Name = "No name";
            _note.Category = NoteCategory.Other;
            _note.Text = "Some text";
            _project.Notes.Add(_note);
        }

       [TearDown]
        public void RemoveFile()
        {
            if (File.Exists(_testFilePath + _testfilename))
            {
                File.Delete(_testFilePath + _testfilename);
            }
        }

        [TestCase(TestName = "Тест сериализации проекта")]
        public void SaveToFileTest()
        {
            InitProjectManager();
            _projectManager.SaveToFile(_project, _testFilePath, _testfilename);
            var actual = File.ReadAllText(_testFilePath + _testfilename);
            var expected = File.ReadAllText(_serializeTestFilePath);
            Assert.True(File.Exists(_testFilePath + _testfilename));
            Assert.AreEqual(expected, actual);
        }

        [TestCase("No name", "Some text", NoteCategory.Other,
            TestName = "Тест дессериализации проекта")]
        public void LoadFromFileTest(string expectedName, string expectedText, NoteCategory expectedNoteCategory)
        {
            InitProjectManager();
            _projectManager.SaveToFile(_project, _testFilePath, _testfilename);
            var actual = _projectManager.LoadFromFile(_testFilePath, _testfilename);
            Assert.AreEqual(expectedName, actual.Notes[0].Name);
            Assert.AreEqual(expectedText, actual.Notes[0].Text);
            Assert.AreEqual(expectedNoteCategory, actual.Notes[0].Category);
        }
    }
}