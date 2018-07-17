namespace RefactoringKungFu
{
    public interface IDispenser
    {
        Ingredient GetIngredient(IngredientTypes ingredient, Places place);
        Ingredient GetPasta(PastaType pasta, Places place);
    }
}
