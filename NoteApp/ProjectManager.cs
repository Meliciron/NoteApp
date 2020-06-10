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
     
        
        //TODO: вместо этих двух методов должно быть два константных текстовых поля. А в точке вызова сохранения/загрузки проекта в метод в качестве аргумента будет передаваться одна из этих константных строк
       
        /// <summary>
        /// метод, сохраняющий данные о заметке в файл.
        /// </summary>
        /// <param name="project"></param>
        public void SaveToFile(Project project , string path , string fileName) //TODO: путь до файла должен передаваться в метод аргументом, а не храниться в поле
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
        public Project LoadFromFile(string path, string filename) //TODO:  путь до файла должен передаваться аргументом в метод
        {
            Project project = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(path + filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project) serializer.Deserialize<Project>(reader);
            }
            if (project == null)
            {
                project = new Project();
                project.Notes = new List<Note>();
            }
            return project;
        }
    }
}

