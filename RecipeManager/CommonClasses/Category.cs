using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CommonClasses
{

    /// <summary>
    /// Класс содержит информацию о категории
    /// </summary>
    [Serializable]
    public class Category
    {
        public Category()
        {
        }

        [XmlIgnore]
        public int Id { get; set; }


        /// <summary>
        /// Название Категории
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Навигационное свойство на Рецепт
        /// </summary>
        [XmlIgnore]
        public List<Recipe> Recipe { get; set; } 
    }


}
