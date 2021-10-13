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
    /// Класс содержит информацию об ингредиенте
    /// </summary>
    [Serializable]
    public class Ingredient
    {
        
        public Ingredient()
        {
        }

        [XmlIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Внешний ключ на Рецепт
        /// </summary>
        [XmlIgnore]
        public int RecipeId { get; set; }
        [XmlIgnore]
        public Recipe Recipe { get; set; } //навигационное свойство

        /// <summary>
        /// Внешний ключ на продукт/инградиент для рецепта
        /// </summary>
        [XmlIgnore]
        public int ProductId { get; set; }
        public Product Product { get; set; } //навигационное свойство
        
        /// <summary>
        /// Вес/объём продукта для рецепта
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Единица измерения веса/объёма продукта в рецепте
        /// </summary>
        [MaxLength(20)]
        public string MeasurementUnit { get; set; }

    }

    
}
