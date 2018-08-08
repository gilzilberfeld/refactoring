using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringKungFu
{
    public class MockDispenser : IDispenser
    {
        private string log;
        public Ingredient GetIngredient(IngredientTypes ingredient, Places place)
        {
            log +="GetIngredient: " +
                ingredient.ToString() +
                " place: " +
                place.ToString();

            return new Ingredient(false);
        }

        public Ingredient GetPasta(PastaType pasta, Places place)
        {
            log+= "GetPlace: " +
               pasta.ToString() +
               " place: " +
               place.ToString();

            return new Ingredient(true);
        }

        public override string ToString()
        {
            return log;
        }
    }
}
