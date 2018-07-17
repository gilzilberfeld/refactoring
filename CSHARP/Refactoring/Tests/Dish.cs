namespace RefactoringKungFu
{
    public partial class PastaMakerTests
    {
        public class Dish
        {
            public Dish(SauceType sauce, PastaType pasta)
            {
                this.sauce = sauce;
                this.pasta = pasta;
            }
            public readonly SauceType sauce;
            public readonly PastaType pasta;

            public override string ToString()
            {
                string result = "Sauce: " +
                    sauce.ToString() +
                    " Pasta : " +
                    pasta.ToString();
                return result;

            }
        }

    }
}
