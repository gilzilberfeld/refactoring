using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace approvaltestRefactoring
{
    public class Dispenser : IDispenser
    {
        public virtual Ingredient GetIngredient(IngredientTypes ingredient, Places place)
        {
            return new Ingredient(false);
        }

        public virtual Ingredient GetPasta(PastaType pasta, Places place)
        {
            return new Ingredient(true);
        }
    }
}
