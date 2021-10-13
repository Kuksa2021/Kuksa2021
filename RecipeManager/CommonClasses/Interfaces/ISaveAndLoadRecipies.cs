using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
   public interface ISaveAndLoadRecipies
    {
            void SaveRecipies(List<Recipe> recipies, string fileName);
            List<Recipe> LoadRecipies(string fileName);
    }
}
