using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CommonClasses
{

    /// <summary>
    /// Класс содержит информацию о рецепте
    /// </summary>
    [Serializable]
    public class Recipe
    {
        public Recipe()
        {
        }

        [XmlIgnore] 
        public int Id { get; set; }


        /// <summary>
        /// Название рецепта
        /// </summary>
        public string Name { get; set; }
        
        
        /// <summary>
        /// Описание рецепта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Внешний ключ на Категорию блюда
        /// </summary>
        [XmlIgnore]
        public int? CategoryID { get;set; } 
        
        /// <summary>
        /// Навигационное свойство на Категорию
        /// </summary>
        public Category Category { get; set; }


        /// <summary>
        /// Навигационное свойство на Инградиенты
        /// </summary>
        public List<Ingredient> Ingradients { get; set; } = new List<Ingredient>();
    }
}
