using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RefactoringKungFu
{
    [UseReporter(typeof(DiffReporter))]
    [TestClass]
    public partial class PastaMakerTests
    {
        List<Dish> Examples = new List<Dish>
        {
            new Dish(SauceType.Alfredo, PastaType.FreshSpaghetti),
            new Dish(SauceType.Bolognese, PastaType.FreshSpaghetti),
            new Dish(SauceType.Marinara, PastaType.FreshSpaghetti),
            new Dish(SauceType.Pesto, PastaType.FreshSpaghetti),
            new Dish(SauceType.Alfredo, PastaType.Ravioly),
            new Dish(SauceType.Bolognese, PastaType.Ravioly),
            new Dish(SauceType.Marinara, PastaType.Ravioly),
            new Dish(SauceType.Pesto, PastaType.Ravioly),
        };


        [TestMethod]
        public void PastaMakerTest()
        {
            {
                MockDispenser dispenser = new MockDispenser();
                PastaMaker maker = new PastaMaker(dispenser);
                string output = "";
                foreach (var dish in Examples)
                {
                    output += dish.ToString();
                    maker.Cook(dish.sauce, dish.pasta);
                }

                output += dispenser.ToString();
                Approvals.Verify(output);
            }
        }
    }
}
