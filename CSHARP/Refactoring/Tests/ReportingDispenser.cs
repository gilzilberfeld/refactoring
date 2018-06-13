using System;


namespace approvaltestRefactoring
{
    public class ReportingDispenser : Dispenser
    {
        public override Ingredient GetIngredient(IngredientTypes ingredient, Places place)
        {
            Console.WriteLine("GetIngredient: " +
                ingredient.ToString() +
                " place: " +
                place.ToString());

            return base.GetIngredient(ingredient, place);
        }

        public override Ingredient GetPasta(PastaType pasta, Places place)
        {
            Console.WriteLine("GetPlace: " +
               pasta.ToString() +
               " place: " +
               place.ToString());
            return base.GetPasta(pasta, place);
        }

    }
}
