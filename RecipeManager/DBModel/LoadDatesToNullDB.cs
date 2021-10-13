using CommonClasses;
using Microsoft.EntityFrameworkCore;
using ModelDB.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDB
{

    /// <summary>
    /// Запись начальных данных в БД
    /// </summary>
    class SaveDatesToNullDB
    {

        static public void SaveDatesToDB(DB db)
        {

            Category c1 = new Category { Name = "Первые блюда" };
            Category c2 = new Category { Name = "Вторые блюда" };
            Category c3 = new Category { Name = "Закуски" };
            Category c4 = new Category { Name = "Салаты" };
            Category c5 = new Category { Name = "Соусы" };
            Category c6 = new Category { Name = "Напитки" };
            Category c7 = new Category { Name = "Десерты" };

            db.Categories.AddRangeAsync(c1,c2,c3,c4,c5,c6,c7);

            db.SaveChanges();
        

            Product p1 = new Product { Name = "Вода", Image = Resources.voda };
            Product p2 = new Product { Name = "Сливки", Image = Resources.slivki };
            Product p3 = new Product { Name = "Брокколи", Image = Resources.brokkoli };
            Product p4 = new Product { Name = "Картофель", Image = Resources.kartofel };
            Product p5 = new Product { Name = "Лук репчатый", Image = Resources.luk_repchatyj };
            Product p6 = new Product { Name = "Масло сливочное", Image = Resources.maslo_slivochnoe };
            Product p7 = new Product { Name = "Масло растительное", Image = Resources.maslo_rastitelnoe };
            Product p8 = new Product { Name = "Поваренная соль", Image = Resources.povarennaya_sol };
            Product p9 = new Product { Name = "Перец черный молотый", Image = Resources.perec_chernyj_molotyj };
            Product p10 = new Product { Name = "Чеснок", Image = Resources.chesnok };
            Product p11 = new Product { Name = "Морковь", Image = Resources.Morkov };
            Product p12 = new Product { Name = "Сок апельсиновый", Image = Resources.Sok_apelsin };
            Product p13 = new Product { Name = "Сок томатный", Image = Resources.Sok_tomat };
            Product p14 = new Product { Name = "Вермишель", Image = Resources.vermisel };
            Product p15 = new Product { Name = "Яица", Image = Resources.yaica };
            Product p16 = new Product { Name = "Зелень", Image = Resources.zelen };


            db.Products.AddRangeAsync(p1, p2, p3, p4,p5,p6,p7,p8,p9, p10,p11,p12,p13,p14,p15,p16);
            db.SaveChanges();


           


            Recipe rec1 = new Recipe
            {
                Name = "Суп картофельный с вермишелью",
                Category=c1,
                Description = "Приготовим на обед простой и вкусный суп картофельный с вермишелью. " +
                "Хорошо также подходят к такому супу мелкие макаронные изделия типа «паутинки» и «звездочки»."
            };

            Recipe rec2 = new Recipe
            {
                Name = "Закуска Брокколи",
                Category = c2,
                Description= "Бро́кколи, или Спа́ржевая капу́ста"
                
            };



            Recipe rec3 = new Recipe
            {
                Name = "Яичница-глазунья",
                Category = c2,
                Description = "Максимально простое и так любимое многими блюдо - яичница-глазунья. " +
                "Растапливаем сливочное масло.Аккуратно разбиваем яйца и выливаем их на сковороду." +
                "Жарим яичницу-глазунью на минимальном огне примерно 3-4 минуты"
            };



            Recipe rec4 = new Recipe
            {
                Name = "Сок томатный <Чудный> ",
                Category = c6,
                Description = "Сок, полученный из томатов. Потребляется в виде напитка, " +
                "а также является ингредиентом для приготовления некоторых коктейлей, " +
                "таких как «Кровавая Мэри», «Сангрита» и «Мичелада»."
            };

            Recipe rec5 = new Recipe
            {
                Name = "Сок апельсиновый <Задорный> ",
                Category = c6,
                Description = "Продукт, получаемый из апельсинов."
            };



            db.Recipies.AddRangeAsync(rec1, rec2, rec3, rec4, rec5);
            db.SaveChanges();

            Ingredient ing1 = new Ingredient { Recipe = rec1,  Product = p4, Weight = 4, MeasurementUnit = MeasurementUnit.шт.ToString() };
            Ingredient ing2 = new Ingredient { Recipe = rec1, Product = p14, Weight = 100, MeasurementUnit = MeasurementUnit.г.ToString() };
            Ingredient ing11 = new Ingredient { Recipe = rec1, Product = p1, Weight = 2, MeasurementUnit = MeasurementUnit.л.ToString() };
            Ingredient ing12 = new Ingredient { Recipe = rec1, Product = p11, Weight = 1, MeasurementUnit = MeasurementUnit.шт.ToString() };

            Ingredient ing3 = new Ingredient { Recipe = rec2, Product = p3, Weight = 3, MeasurementUnit = MeasurementUnit.шт.ToString() };
            Ingredient ing4 = new Ingredient { Recipe = rec2, Product = p8, Weight = 20, MeasurementUnit = MeasurementUnit.г.ToString() };

            Ingredient ing5 = new Ingredient { Recipe = rec3, Product = p6, Weight = 100, MeasurementUnit = MeasurementUnit.г.ToString() };
            Ingredient ing6 = new Ingredient { Recipe = rec3, Product = p15, Weight = 5, MeasurementUnit = MeasurementUnit.шт.ToString() };


            Ingredient ing7 = new Ingredient { Recipe = rec4, Product = p13, Weight = 200, MeasurementUnit = MeasurementUnit.мл.ToString() };
            Ingredient ing8 = new Ingredient { Recipe = rec5, Product = p12, Weight = 200, MeasurementUnit = MeasurementUnit.мл.ToString() };

            db.Ingredients.AddRangeAsync(ing1, ing2, ing11, ing12,  ing3, ing4,  ing5,ing6, ing7,ing8);
            db.SaveChanges();
        }


    }
}
