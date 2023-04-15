using Newtonsoft.Json;
using System.IO;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает менеджер проекта
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Адрес для сохранения данных проекта
        /// </summary>
        private const string FILE_PATH = @".\Roaming\ShatyloNikita\ContactsApp\ContactsApp.notes";

        /// <summary>
        /// Сохраняет проект в указанный файл
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            string jsonData = JsonConvert.SerializeObject(project);

            using (StreamWriter writer = new StreamWriter(FILE_PATH))
            {
                writer.Write(jsonData);
            }
        }

    }
}
