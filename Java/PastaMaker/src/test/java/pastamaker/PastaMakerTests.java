package pastamaker;

import java.util.List;

import org.approvaltests.Approvals;
import org.approvaltests.reporters.DiffReporter;
import org.approvaltests.reporters.UseReporter;
import org.junit.Test;

@UseReporter(DiffReporter.class)
public class PastaMakerTests {

    List<Dish> dishes = List.of (
        new Dish(SauceType.Alfredo, PastaType.FreshSpaghetti),
        new Dish(SauceType.Bolognese, PastaType.FreshSpaghetti),
        new Dish(SauceType.Marinara, PastaType.FreshSpaghetti),
        new Dish(SauceType.Pesto, PastaType.FreshSpaghetti),
        new Dish(SauceType.Alfredo, PastaType.Ravioly),
        new Dish(SauceType.Bolognese, PastaType.Ravioly),
        new Dish(SauceType.Marinara, PastaType.Ravioly),
        new Dish(SauceType.Pesto, PastaType.Ravioly)
    );

	@Test
	public void pastaMakerTest() {
	      MockDispenser dispenser = new MockDispenser();
	      StringBuilder log = new StringBuilder();
	      PastaMaker maker = new PastaMaker(dispenser);
	      
          dishes.forEach(dish ->
          {
              log.append(dish.toString());
              maker.cook(dish.sauce, dish.pasta);
          });

          log.append(dispenser.toString());
          Approvals.verify(log);
	}
}
