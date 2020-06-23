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
    {
        /// <summary>
        /// метод, сохраняющий данные о заметке в файл.
        /// </summary>
        /// <param name="project"></param>
        public void SaveToFile(Project project , string path , string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(path + fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// метод, возвращающий данные о заметке из файла.
        /// </summary>
        /// <returns></returns>
        public Project LoadFromFile(string path, string filename)
        {
            Project project = null;
            if (!File.Exists(path + filename))
                return project = new Project();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(path + filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = serializer.Deserialize<Project>(reader);
            }
            return project;
        }
    }
}

