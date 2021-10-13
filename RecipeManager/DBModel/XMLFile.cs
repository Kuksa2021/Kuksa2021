using CommonClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
//using System.Windows.Forms;


namespace ModelDB
{

    /// <summary>
    /// Работа с файлами
    /// </summary>
   public class XMLFile: ISaveAndLoadRecipies
    {
        /// <summary>
        /// Метод сохраняет список рецептов в файле
        /// </summary>
        /// <param name="recipies">Список рецептов</param>
        public void SaveRecipies(List<Recipe> recipies, string fileName)
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<Recipe>));

            try
            {
                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, recipies);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("При записи в файл произошла ошибка: " + ex.Message);
            }
        }


        /// <summary>
        /// Метод считывает данные (рецепты) из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public List<Recipe> LoadRecipies(string fileName)
        {
            List<Recipe> recipies = new List<Recipe>();

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<Recipe>));

            try
            {
                // десериализация
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                        recipies = (List<Recipe>)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("При чении из файла произошла ошибка: " + ex.Message);
            }

            return recipies;

        }

    }
}
