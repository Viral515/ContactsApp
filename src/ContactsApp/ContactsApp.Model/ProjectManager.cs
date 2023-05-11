using Newtonsoft.Json;
using System;
using System.IO;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает менеджер проекта
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Сохраняет проект в указанный файл
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = $@"{appData}\ShatyloNikita\ContactsApp\ContactsApp.notes";
            string jsonData = JsonConvert.SerializeObject(project);

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(jsonData);
            }
        }

    }
}
