using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CommonClasses
{

    /// <summary>
    /// Класс содержит информацию о продукте
    /// </summary>

    [Serializable]
    public class Product
    {

        public Product() { }

        [XmlIgnore]
        public int Id { get; set; }


        /// <summary>
        /// Название
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Навигационное свойство
        /// </summary>
        [XmlIgnore]
        public List<Ingredient> Ingredient { get; set; }

        /// <summary>
        /// Картинка
        /// </summary>
        public byte[] BytePicture { get; set; }

        [XmlIgnore]
        [NotMapped]
        public Image Image 
        {
            get
            {
                //преобразуем массив байт в картинку
                if (BytePicture!=null && BytePicture.Length > 0)
                {
                    ImageConverter imageConverter = new ImageConverter();
                    var image = imageConverter.ConvertFrom((object)BytePicture);
                    return (Image)image;
                }
                else return null;

            } 
            set //преобразуем картинку в массив байт
            {
                if (value != null)
                {
                    ImageConverter imageConverter = new ImageConverter();
                    BytePicture = (byte[])imageConverter.ConvertTo(value, typeof(byte[]));
                }
                
            }
        }
    }

}
