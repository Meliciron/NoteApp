using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{
    /// <summary>
    ///  Реализует метод для сохранения объекта «Проект» в файл и метод загрузки проекта из файла.
    /// </summary>
    public class ProjectManager
    {//TODO: поправить табуляцию
    /// <summary>
    /// переменная, содеражащая имя файла (де)сериализации.
    /// </summary>
        private string _filename;
    /// <summary>
    /// метод, получающий путь к папке appdata.
    /// </summary>
        private string _noteAppPath = Environment.ExpandEnvironmentVariables(@"%appdata%\NoteApp");
        /// <summary>
        /// метод, устанавливающий имя файла для работы с (де)сериализации.
        /// </summary>
        public void SetWorkFileName() //TODO: вместо этих двух методов должно быть два константных текстовых поля. А в точке вызова сохранения/загрузки проекта в метод в качестве аргумента будет передаваться одна из этих константных строк
        {
            _filename = "Work.json"; 
        }
        /// <summary>
        /// метод, устанавливающий имя файла для тестов (де)сериализации.
        /// </summary>
        public void SetTestFileName()
        {
            _filename = "Test.json";
        }
        /// <summary>
        /// метод, сохраняющий данные о заметке в файл.
        /// </summary>
        /// <param name="project"></param>
        public void SaveToFile(Project project) //TODO: путь до файла должен передаваться в метод аргументом, а не храниться в поле
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(_noteAppPath + _filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }
        /// <summary>
        /// метод, возвращающий данные о заметке из файла.
        /// </summary>
        /// <returns></returns>
        public Project LoadFromFile() //TODO:  путь до файла должен передаваться аргументом в метод
        {
            Project project = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(_noteAppPath + _filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project) serializer.Deserialize<Project>(reader);
            }
            return project;
        }
    }

}

