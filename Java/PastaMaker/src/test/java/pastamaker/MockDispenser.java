package pastamaker;

public class MockDispenser implements Dispenser {
	private String log = "";
	  
	public Ingredient getIngredient(IngredientType ingredient, Place place) {
		
		log += "getIngredient: ";
		log += "Ingredient Type: " + ingredient.toString();
		log += " Place: " + place.toString();
		log += "\n";
			 
		return new Ingredient(false);
	}
	
	public String toString(){
		return log;
	}

	public Ingredient getPasta(PastaType pasta, Place place) {
		log += "getPasta: ";
		log += "Pasta Type: " + pasta.toString();
		log += " Place: " + place.toString();
		log += "\n";
			 
		return new Ingredient(true);
	}

}
