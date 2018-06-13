using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace approvaltestRefactoring
{
    public interface IDispenser
    {
        Ingredient GetIngredient(IngredientTypes ingredient, Places place); 
        Ingredient GetPasta(PastaType pasta, Places place);

    }
}
