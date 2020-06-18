using System;
using NoteApp;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;
        //TODO: именование метода
        public void initNote()
        {
           _note = new Note();
        }
        #region Name testing
        [TestCase("Новая заметка", "Должно возвращаться название Новая заметка",
            TestName = "Возвращение корректного названия заметки")]
        public void TestNameGet_CorrectValue(string expected, string message)
        {
            initNote();
            _note.Name = "Новая заметка";
            Assert.AreEqual(expected, _note.Name, message);
        }

        [TestCase("Новая-заметка-новая-замтка-новая-заметка-новая-заметка-новая-заметка",
            "Должно возникать исключение, если в названии заметки больше 50 символов",
            TestName = "Присвоение неправильного названия больше 50 символов")]
        public void TestNameSet_ArgumentExeption(string setupData, string message)
        {
            initNote();
            Assert.Throws<ArgumentException>(() => { _note.Name = setupData; }, message);
        }

        [TestCase("", "Untitled", "Если в названии 0 символов, тогда присваиваем название: Untitled",
            TestName = "Присваивание пустого названия заметки")]
        public void TestNameSet_EmptyName(string setupData, string expected, string message)
        {
            initNote();
            _note.Name = setupData;
            Assert.AreEqual(expected, _note.Name, message);
        }
        #endregion
        #region Category testing
        [TestCase(NoteCategory.Other, NoteCategory.Other, "Должна присваиваться категория заметки: All",
            TestName = "Присваивание категории заметки")]
        public void TestCategorySet(NoteCategory setupData, NoteCategory expected, string message)
        {
            initNote();
            _note.Category = setupData;
            Assert.AreEqual(_note.Category, expected, message);
        }

        [TestCase(NoteCategory.Other, "Должна возвращаться категория заметки All",
            TestName = "Возвращение категории заметки")]
        public void TestCategoryGet(NoteCategory expected, string message)
        {
            initNote();
            _note.Category = expected;
            Assert.AreEqual(expected, _note.Category, message);
        }
        #endregion
        #region Text testing
        [TestCase("Текст", "Должен возвращать текст заметки: Текст",
            TestName = "Возвращение текста заметки")]
        public void TestTextGet(string expected, string message)
        {
            initNote();
            _note.Text = "Текст";
            Assert.AreEqual(_note.Text, expected, message);
        }

        [TestCase("Текст", "Текст", "Должен присваиваивать текст заметки: Текст",
            TestName = "Присваивание текста заметки")]
        public void TestTextSet(string setupData, string expected, string message)
        {
            initNote();
            _note.Text = setupData;
            Assert.AreEqual(expected, _note.Text, message);
        }
        #endregion
        #region CreatureDate testing
        [TestCase("Должен возвращать время создания заметки",
            TestName = "Возвращение времени создания заметки")]
        public void TestDateOfCreatureGet(string message)
        {
            initNote();
            var expected = DateTime.Now;
            _note.CreatureDate = DateTime.Now;
            Assert.AreEqual(expected, _note.CreatureDate, message);
        }

        [TestCase("Должен присваивать время создания заметки",
            TestName = "Присваивание времени создания заметки")]
        public void TestDateOfCreatureSet(string message)
        {
            initNote();
            var expected = DateTime.Now;
            _note.CreatureDate = DateTime.Now;
            Assert.AreEqual(expected, _note.CreatureDate, message);
        }
        #endregion
        #region LastChangeDate testing
        [TestCase("Должен возвращать время последнего изменения заметки",
            TestName = "Возвращение времени последнего изменения заметки")]
        public void TestLastChangeDateGet(string message)
        {
            initNote();
            var expected = DateTime.Now;
            _note.LastChangeDate = DateTime.Now;
            Assert.AreEqual(expected, _note.LastChangeDate, message);
        }

        [TestCase("Должен присваивать время последнего изменения заметки",
            TestName = "Присваивание времени последнего изменения заметки")]
        public void TestLastChangeDateSet(string message)
        {
            initNote();
            var expected = DateTime.Now;
            _note.LastChangeDate = DateTime.Now;
            Assert.AreEqual(expected, _note.LastChangeDate, message);
        }
        #endregion
    }
}