package pastamaker;

import java.util.ArrayList;
import java.util.List;

public class PastaMaker {
	
	Dispenser dispenser;
	
	public PastaMaker(Dispenser dispenser) {
		this.dispenser = dispenser;
	}
	
    public void cook(SauceType sauce, PastaType pastaType)
    {
        List<Ingredient> ingredients = new ArrayList<Ingredient>();
        if (sauce == SauceType.Alfredo)
        {
            ingredients.add(getIngredient(IngredientType.Cream, Place.Refrigarator));
        }
        else if (sauce == SauceType.Bolognese || sauce == SauceType.Marinara)
        {
            ingredients.add(getIngredient(IngredientType.Tomato, Place.Garden));
        }
        else if (pastaType == PastaType.Ravioly)
        {
            List<Ingredient> tempIngredients = new ArrayList<Ingredient>(ingredients);
            ingredients.clear();
            ingredients.add(getPasta(PastaType.Ravioly, Place.Freezer));
            ingredients.addAll(tempIngredients);
        }
        else if (sauce == SauceType.Pesto || sauce == SauceType.Marinara)
        {
            ingredients.add(getIngredient(IngredientType.Basil, Place.Garden));
        }
        else if (sauce == SauceType.Marinara)
        {
            ingredients.add(getIngredient(IngredientType.Onion, Place.Garden));
        }
        else if (pastaType == PastaType.FreshSpaghetti)
        {
            ingredients.add(getPasta(PastaType.FreshSpaghetti, Place.Freezer));
        }
        if (ingredients.get(0).isPastaType())
        {
            List<Ingredient> fillingIngredients = new ArrayList<Ingredient>(ingredients.subList(1, ingredients.size() - 1));
            prepare(ingredients.get(0));
            fill(fillingIngredients);
            cookPasta();
        }
        else
        {
            cookPasta();
            List<Ingredient> sauceIngredients = new ArrayList<Ingredient>(ingredients.subList(0, ingredients.size() - 1));
            prepare(ingredients.get(ingredients.size()- 1));
            fill(sauceIngredients);
            addSauce();
        }
    }

    // TODO: Add more implementation
    private Ingredient getIngredient(IngredientType ingredient, Place place) { return new Ingredient(false); }
    private Ingredient getPasta(PastaType pasta, Place place) { return new Ingredient(true); }

    private void fill(List<Ingredient> sauceIngredients) { }
    private void prepare(Ingredient ingredient) { }
    private void cookPasta() { }
    private void addSauce() { }

}
