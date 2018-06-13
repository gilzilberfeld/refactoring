using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace approvaltestRefactoring
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
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
        public void PastaMakerTestCases()
        {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            ReportingDispenser dispenser = new ReportingDispenser();

            foreach (var dish in Examples)
            {
                Console.WriteLine(dish.ToString());
                PastaMaker maker = new PastaMaker(dispenser);
                maker.Cook(dish.sauce, dish.pasta);
            }

            string output = fakeoutput.ToString();
            Approvals.Verify(output);
        }

    }
}
